using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Arch.Core;
using Arch.Core.Extensions;
using Arch.Core.Extensions.Internal;
using Arch.Core.Utils;
using Collections.Pooled;
using CommunityToolkit.HighPerformance;

namespace Arch.Buffer;

/// <summary>
///     The <see cref="CreateCommand"/> struct
///     contains data for creating a new <see cref="Entity"/>.
/// </summary>
public readonly record struct CreateCommand
{
    public readonly int Index;
    public readonly HashSet<ComponentType> Types;

    /// <summary>
    ///     Initializes a new instance of the <see cref="CreateCommand"/> struct.
    /// </summary>
    /// <param name="index">The <see cref="Entity"/>'s buffer id.</param>
    /// <param name="types">Its <see cref="ComponentType"/>'s array.</param>
    public CreateCommand(int index, ComponentType[] types)
    {
        Index = index;
        Types = new HashSet<ComponentType>(types);
    }
}

/// <summary>
///     The <see cref="BufferedEntityInfo"/> struct
///     contains data about a buffered <see cref="Entity"/>.
/// </summary>
/// <remarks>
///     This struct's purpose is to speed up lookups into an <see cref="Entity"/>'s internal data.
/// </remarks>
public readonly record struct BufferedEntityInfo
{
    public readonly int Index;
    public readonly int SetIndex;
    public readonly int AddIndex;
    public readonly int RemoveIndex;

    /// <summary>
    ///      Initializes a new instance of the <see cref="CreateCommand"/> struct.
    /// </summary>
    /// <param name="index">Its <see cref="CommandBuffer"/> index.</param>
    /// <param name="setIndex">Its <see cref="CommandBuffer.Sets"/> index.</param>
    /// <param name="addIndex">Its <see cref="CommandBuffer.Adds"/> index.</param>
    /// <param name="removeIndex">Its <see cref="CommandBuffer.Removes"/> index.</param>
    public BufferedEntityInfo(int index, int setIndex, int addIndex, int removeIndex)
    {
        Index = index;
        SetIndex = setIndex;
        AddIndex = addIndex;
        RemoveIndex = removeIndex;
    }
}

/// <summary>
///     The <see cref="CommandBuffer"/> class
///     stores operation to <see cref="Entity"/>'s between to play and implement them at a later time in the <see cref="World"/>.
/// </summary>
public sealed partial class CommandBuffer : IDisposable
{
    private readonly PooledList<ComponentType> _addTypes;
    private readonly PooledList<ComponentType> _removeTypes;

    /// <summary>
    ///     Initializes a new instance of the <see cref="CommandBuffer"/> class
    ///     with the specified <see cref="Core.World"/> and an optional <paramref name="initialCapacity"/> (default: 128).
    /// </summary>
    /// <param name="initialCapacity">The initial capacity.</param>
    public CommandBuffer(int initialCapacity = 128)
    {
        Entities = new PooledList<Entity>(initialCapacity);
        BufferedEntityInfo = new PooledDictionary<int, BufferedEntityInfo>(initialCapacity);
        Creates = new PooledList<CreateCommand>(initialCapacity);
        Sets = new SparseSet(initialCapacity);
        Adds = new StructuralSparseSet(initialCapacity);
        Removes = new StructuralSparseSet(initialCapacity);
        Destroys = new PooledList<int>(initialCapacity);
        _addTypes = new PooledList<ComponentType>(16);
        _removeTypes = new PooledList<ComponentType>(16);
    }

    /// <summary>
    ///     Gets the amount of <see cref="Entity"/> instances targeted by this <see cref="CommandBuffer"/>.
    /// </summary>
    public int Size { get; private set; }

    /// <summary>
    ///     All <see cref="Entity"/>'s created or modified in this <see cref="CommandBuffer"/>.
    /// </summary>
    internal PooledList<Entity> Entities { get; set; }

    /// <summary>
    ///     A map that stores some additional information for each <see cref="Entity"/>, which is needed for the internal <see cref="CommandBuffer"/> operations.
    /// </summary>
    internal PooledDictionary<int, BufferedEntityInfo> BufferedEntityInfo { get; set; }

    /// <summary>
    ///     All create commands recorded in this <see cref="CommandBuffer"/>. Used to create <see cref="Entity"/>'s during <see cref="Playback"/>.
    /// </summary>
    internal PooledList<CreateCommand> Creates { get; set; }

    /// <summary>
    ///     Saves set operations for components to play them back later during <see cref="Playback"/>.
    /// </summary>
    internal SparseSet Sets { get; set; }

    /// <summary>
    ///     Saves add operations for components to play them back later during <see cref="Playback"/>.
    /// </summary>
    internal StructuralSparseSet Adds { get; set; }

    /// <summary>
    ///     Saves remove operations for components to play them back later during <see cref="Playback"/>.
    /// </summary>
    internal StructuralSparseSet Removes { get; set; }

    /// <summary>
    ///     Saves remove operations for <see cref="Entity"/>'s to play them back later during <see cref="Playback"/>.
    /// </summary>
    internal PooledList<int> Destroys { get; set; }

    /// <summary>
    ///     Registers a new <see cref="Entity"/> into the <see cref="CommandBuffer"/>.
    ///     An <see langword="out"/> parameter contains its <see cref="Arch.Buffer.BufferedEntityInfo"/>.
    /// </summary>
    /// <param name="entity">The <see cref="Entity"/> to register.</param>
    /// <param name="info">Its <see cref="BufferedEntityInfo"/> which stores indexes used for <see cref="CommandBuffer"/> operations.</param>

    internal void Register(in Entity entity, out BufferedEntityInfo info)
    {
        var setIndex = Sets.Create(in entity);
        var addIndex = Adds.Create(in entity);
        var removeIndex = Removes.Create(in entity);

        info = new BufferedEntityInfo(Size, setIndex, addIndex, removeIndex);

        Entities.Add(entity);
        BufferedEntityInfo.Add(entity.Id, info);
        Size++;
    }

    /// TODO : Probably just run this if the wrapped entity is negative? To save some overhead?
    /// <summary>
    ///     Resolves an <see cref="Entity"/> originally either from a <see cref="StructuralSparseArray"/> or <see cref="SparseArray"/> to its real <see cref="Entity"/>.
    ///     This is required since we can also create new entities via this buffer and buffer operations for it. So sometimes there negative entities stored in the arrays and those must then be resolved to its newly created real entity.
    ///     <remarks>Probably hard to understand, blame genaray for this.</remarks>
    /// </summary>
    /// <param name="entity">The <see cref="Entity"/> with a negative or positive id to resolve.</param>
    /// <returns>Its real <see cref="Entity"/>.</returns>

    internal Entity Resolve(Entity entity)
    {
        var entityIndex = BufferedEntityInfo[entity.Id].Index;
        return Entities[entityIndex];
    }

    /// <summary>
    ///     Records a Create operation for an <see cref="Entity"/> based on its component structure.
    ///     Will be created during <see cref="Playback"/>.
    /// </summary>
    /// <param name="types">The <see cref="Entity"/>'s component structure/<see cref="Archetype"/>.</param>
    /// <returns>The buffered <see cref="Entity"/> with an index of <c>-1</c>.</returns>

    public Entity Create(ComponentType[] types)
    {
        lock (this)
        {
            var entity = new Entity(-(Size + 1), -1);
            Register(entity, out _);

            var command = new CreateCommand(Size - 1, types);
            Creates.Add(command);

            return entity;
        }
    }

    /// <summary>
    ///     Record a Destroy operation for an (buffered) <see cref="Entity"/>.
    ///     Will be destroyed during <see cref="Playback"/>.
    /// </summary>
    /// <param name="entity">The <see cref="Entity"/> to destroy.</param>

    public void Destroy(in Entity entity)
    {
        lock (this)
        {
            if (!BufferedEntityInfo.TryGetValue(entity.Id, out var info))
            {
                Register(entity, out info);
            }

            if (entity.Id < 0)
            {
                // 如果是负数 id，即实体为 CommandBuffer 新创建的
                var ci = Creates.FindIndex(c => c.Index == info.Index); // TODO 待优化
                if (ci >= 0)
                {
                    // 如果有对应的创建命令，则直接移除该命令
                    Creates.RemoveAt(ci);
                }
                else
                {
                    // 否则说明该实体已经被 Destroy 过，静默忽略
                    return;
                }
            }
            else
            {
                // 如果不是 CommandBuffer 新创建的实体，才添加 Destroy 命令
                Destroys.Add(info.Index);
            }

            // 不管怎么样，总是移除对应的 Sets、Adds 和 Removes 集合中的内容
            Sets.Remove(info.SetIndex);
            Adds.Remove(info.AddIndex);
            Removes.Remove(info.RemoveIndex);
        }
    }

    /// <summary>
    ///     Records a set operation for an (buffered) <see cref="Entity"/>.
    ///     Overwrites previous values.
    ///     Will be set during <see cref="Playback"/>.
    /// </summary>
    /// <typeparam name="T">The component type.</typeparam>
    /// <param name="entity">The <see cref="Entity"/>.</param>
    /// <param name="component">The component value.</param>

    public void Set<T>(in Entity entity, in T? component = default)
    {
        BufferedEntityInfo info;
        lock (this)
        {
            if (!BufferedEntityInfo.TryGetValue(entity.Id, out info))
            {
                Register(entity, out info);
            }
        }

        if (entity.Id < 0)
        {
            // 如果是负数 id，即实体为 CommandBuffer 新创建的
            var ci = Creates.FindIndex(c => c.Index == info.Index); // TODO 待优化
            if (ci < 0)
            {
                // 如果没有 CreateCommand，说明该实体已经被 Destroy 过，静默忽略
                return;
            }
        }
        else if (Destroys.Contains(info.Index))
        {
            // 如果是正数 id 且已经登记销毁，说明该实体已经被 Destroy 过，静默忽略
            return;
        }

        if (Removes.Contains<T>(info.RemoveIndex))
        {
            // 如果已经 Remove 过，则抛弃此次 Set 操作
            return;
        }

        Sets.Set(info.SetIndex, in component);
    }

    /// <summary>
    ///     Records a add operation for an (buffered) <see cref="Entity"/>.
    ///     Overwrites previous values.
    ///     Will be added during <see cref="Playback"/>.
    /// </summary>
    /// <typeparam name="T">The component type.</typeparam>
    /// <param name="entity">The <see cref="Entity"/>.</param>
    /// <param name="component">The component value.</param>

    public void Add<T>(in Entity entity, in T? component = default)
    {
        BufferedEntityInfo info;
        lock (this)
        {
            if (!BufferedEntityInfo.TryGetValue(entity.Id, out info))
            {
                Register(entity, out info);
            }
        }

        if (entity.Id < 0)
        {
            // 如果是负数 id，即实体为 CommandBuffer 新创建的
            var ci = Creates.FindIndex(c => c.Index == info.Index); // TODO 待优化
            if (ci >= 0)
            {
                // 如果有对应的创建命令，则直接追加到创建命令中
                Creates[ci].Types.Add(Component<T>.ComponentType);
            }
            else
            {
                // 否则说明该实体已经被 Destroy 过，静默忽略
                return;
            }
        }
        else if (Destroys.Contains(info.Index))
        {
            // 如果是正数 id 且已经登记销毁，说明该实体已经被 Destroy 过，静默忽略
            return;
        }
        else
        {
            // 否则记录到 Adds 集合
            Adds.Set<T>(info.AddIndex);
        }

        // 抛弃之前的 remove 记录
        Removes.Remove<T>(info.RemoveIndex);

        Sets.Set(info.SetIndex, in component);
    }

    /// <summary>
    ///     Records a remove operation for an (buffered) <see cref="Entity"/>.
    ///     Will be removed during <see cref="Playback"/>.
    /// </summary>
    /// <typeparam name="T">The component type.</typeparam>
    /// <param name="entity">The <see cref="Entity"/>.</param>

    public void Remove<T>(in Entity entity)
    {
        BufferedEntityInfo info;
        lock (this)
        {
            if (!BufferedEntityInfo.TryGetValue(entity.Id, out info))
            {
                Register(entity, out info);
            }
        }

        if (entity.Id < 0)
        {
            // 如果是负数 id，即实体为 CommandBuffer 新创建的
            var ci = Creates.FindIndex(c => c.Index == info.Index); // TODO 待优化
            if (ci >= 0)
            {
                // 如果有对应的创建命令，则直接从创建命令中移除
                Creates[ci].Types.Remove(Component<T>.ComponentType);
            }
            else
            {
                // 否则说明该实体已经被 Destroy 过，静默忽略
                return;
            }
        }
        else if (Destroys.Contains(info.Index))
        {
            // 如果是正数 id 且已经登记销毁，说明该实体已经被 Destroy 过，静默忽略
            return;
        }
        else
        {
            Removes.Set<T>(info.RemoveIndex);
        }

        // 抛弃之前的 add 和 set 记录
        Adds.Remove<T>(info.AddIndex);
        Sets.Remove<T>(info.SetIndex);
    }

    /// <summary>
    ///     Plays back all recorded commands, modifying the world.
    /// </summary>
    /// <remarks>
    ///     This operation should only happen on the main thread.
    /// </remarks>
    /// <param name="world">The <see cref="World"/> where the commands will be playbacked too.</param>
    /// <param name="dispose">If true it will clear the recorded operations after they were playbacked, if not they will stay.</param>

    public void Playback(World world, bool dispose = true)
    {
        // Create recorded entities.
        int createCount = Creates.Count;
        foreach (var cmd in Creates)
        {
            var entity = CreateWithoutEvents(world, new Signature([.. cmd.Types]));
            Entities[cmd.Index] = entity;

#if EVENTS
            // 触发创建事件：先触发 OnEntityCreated；对每个组件类型，如果它不在 Sets 稀疏集中
            // （说明从未被 Set 过，值是默认值），则触发 OnComponentAdded。在 Sets 稀疏集中有记录的
            // 组件类型由 Sets 写值循环负责触发，避免同一组件触发两次。
            world.OnEntityCreated(entity);

            var info = BufferedEntityInfo[-(cmd.Index + 1)];
            foreach (var type in cmd.Types)
            {
                if (type.Id < Sets.Components.Length
                    && Sets.Components[type.Id] is { } setArray
                    && setArray.Contains(info.SetIndex))
                {
                    continue;
                }

                world.OnComponentAdded(entity, type);
            }
#endif
        }

        // Play back additions.
        // Add<T> 在记录期总是会调用 Sets.Set 写入值（见上方 Add<T>），所以凡是 Add 过的组件类型，
        // 一定会在 Sets 稀疏集中留下记录。因此 Adds 阶段只负责把组件实际添加到实体上（结构变更），
        // 不在这里触发事件；Add 事件在后面的 Sets 写值循环中触发（此时值已写入，处理器能读到最终值）。
        int addCount = Adds.Count;
        for (var index = 0; index < addCount; index++)
        {
            var wrappedEntity = Adds.Entities[index];
            var entity = Resolve(wrappedEntity.Entity);
            // 新建实体被取消创建后，其占位符未被替换成真实实体，Resolve 返回的仍是负 id 实体。
            // 该实体从未真正创建，不触发任何事件。
            if (entity.Id < 0)
            {
                continue;
            }

            for (var i = 0; i < Adds.UsedSize; i++)
            {
                var usedIndex = Adds.Used[i];
                var sparseSet = Adds.Components[usedIndex];

                if (!sparseSet.Contains(wrappedEntity.Index))
                {
                    continue;
                }

                _addTypes.Add(sparseSet.Type);
            }

            if (_addTypes.Count <= 0)
            {
                continue;
            }

            Debug.Assert(world.IsAlive(entity), $"CommandBuffer can not to add components to the dead {wrappedEntity.Entity}");

            AddRange(world, entity, _addTypes.Span);
            _addTypes.Clear();
        }

        // Play back sets.
        int setCount = Sets.Count;
        for (var index = 0; index < setCount; index++)
        {
            // Get wrapped entity
            var wrappedEntity = Sets.Entities[index];
            var entity = Resolve(wrappedEntity.Entity);
            // 新建实体被取消创建后，其占位符未被替换成真实实体，Resolve 返回的仍是负 id 实体。
            // 该实体从未真正创建，跳过它，不写值。
            if (entity.Id < 0)
            {
                continue;
            }

            var id = wrappedEntity.Index;

            Debug.Assert(world.IsAlive(entity), $"CommandBuffer can not to set components to the dead {wrappedEntity.Entity}");

            // Get entity chunk
            var entityInfo = world.EntityInfo.GetEntityData(entity.Id);
            var archetype = entityInfo.Archetype;
            ref readonly var chunk = ref archetype.GetChunk(entityInfo.Slot.ChunkIndex);
            var chunkIndex = entityInfo.Slot.Index;

            // Loop over all sparset component arrays and if our entity is in one, copy the set component to its chunk
            for (var i = 0; i < Sets.UsedSize; i++)
            {
                var used = Sets.Used[i];
                var sparseArray = Sets.Components[used];

                // 该实体在此组件类型上没有写值记录（例如先 Set 后又 Remove，Set 记录已被撤销）→ 跳过。
                if (!sparseArray.Contains(id))
                {
                    continue;
                }

                var chunkArray = chunk.GetArray(sparseArray.Type);
                var oldValue = chunkArray.GetValue(chunkIndex);
                Array.Copy(sparseArray.Components, sparseArray.Entities[id], chunkArray, chunkIndex, 1);

#if EVENTS
                // 逐条判断每个写值记录应该触发 Add 还是 Set 事件，判断依据只看 CommandBuffer 自己的操作记录：
                //   组件在操作前不存在、操作后存在（新建实体的创建命令里，或已存在实体的 Adds 记录里）→ Add 事件，只触发一次；
                //   组件在操作前已存在（只有 Set 记录）→ Set 事件。
                // 数据来源按实体身份区分：新建实体（负数 id）的组件集合在创建命令的 Types 里；
                // 已存在实体（正数 id）的新增组件记录在 Adds 稀疏集里。
                var type = sparseArray.Type;
                if (wrappedEntity.Entity.Id < 0)
                {
                    // 新建实体：它的 Add 操作都直接添加进创建命令的组件类型集合，所以 Sets 稀疏集里有写值记录的
                    // 类型必然也在创建命令的 Types 里（Debug 断言验证这个关系）。触发 Add 事件。
                    var createInfo = BufferedEntityInfo[wrappedEntity.Entity.Id];
                    var ci = Creates.FindIndex(c => c.Index == createInfo.Index);
                    Debug.Assert(ci >= 0 && Creates[ci].Types.Contains(type), "新建实体的 Sets 记录类型必在创建命令中");
                    world.OnComponentAdded(entity, type);
                }
                else
                {
                    // 已存在实体：判断这个组件是否是通过 Add 操作加入的，查该实体在 Adds 稀疏集中的记录。
                    var addInfo = BufferedEntityInfo[wrappedEntity.Entity.Id].AddIndex;
                    if (type.Id < Adds.Components.Length
                        && Adds.Components[type.Id] is { } addArray
                        && addArray.Contains(addInfo))
                    {
                        // 组件在 Adds 稀疏集里有记录 → 本次属于新增，触发 Add 事件（Add 阶段只做了
                        // 结构变更不触发事件，Add 事件在这里触发）。
                        world.OnComponentAdded(entity, type);
                    }
                    else
                    {
                        // 组件在 Adds 稀疏集里没有记录 → 这是对已存在组件的赋值操作，触发 Set 事件。
                        world.OnComponentSet(entity, type, oldValue);
                    }
                }
#endif
            }
        }

        // Play back removals.
        int removeCount = Removes.Count;
        for (var index = 0; index < removeCount; index++)
        {
            var wrappedEntity = Removes.Entities[index];
            var entity = Resolve(wrappedEntity.Entity);
            // 新建实体被取消创建后，其占位符未被替换成真实实体，Resolve 返回的仍是负 id 实体。
            // 该实体从未真正创建，不触发任何事件。
            if (entity.Id < 0)
            {
                continue;
            }

            for (var i = 0; i < Removes.UsedSize; i++)
            {
                var usedIndex = Removes.Used[i];
                var sparseSet = Removes.Components[usedIndex];
                if (!sparseSet.Contains(wrappedEntity.Index))
                {
                    continue;
                }

                _removeTypes.Add(sparseSet.Type);
            }

            if (_removeTypes.Count <= 0)
            {
                continue;
            }

            Debug.Assert(world.IsAlive(entity), $"CommandBuffer can not to remove components from the dead {wrappedEntity.Entity}");

            world.RemoveRange(entity, _removeTypes.Span);
            _removeTypes.Clear();
        }

        // Play back destructions.
        int destroyCount = Destroys.Count;
        foreach (var cmd in Destroys)
        {
            world.Destroy(Entities[cmd]);
        }

        // Reset values.
        if (!dispose)
        {
            return;
        }

        Size = 0;
        Entities.Clear();
        BufferedEntityInfo.Clear();
        if (createCount > 0)
        {
            Creates.Clear();
        }
        if (setCount > 0)
        {
            Sets.Clear();
        }
        if (addCount > 0)
        {
            Adds.Clear();
        }
        if (removeCount > 0)
        {
            Removes.Clear();
        }
        if (destroyCount > 0)
        {
            Destroys.Clear();
        }
        _addTypes.Clear();
        _removeTypes.Clear();
    }

    /// <summary>
    ///     Disposes the <see cref="CommandBuffer"/>.
    /// </summary>
    public void Dispose()
    {
        Entities.Dispose();
        BufferedEntityInfo.Dispose();
        Creates.Clear();
        Sets.Clear();
        Adds.Clear();
        Removes.Clear();
        Destroys.Dispose();
        _addTypes.Dispose();
        _removeTypes.Dispose();
        GC.SuppressFinalize(this);
    }
}

public sealed partial class CommandBuffer
{
    /// <summary>
    ///     Adds a list of new components to the <see cref="Entity"/> and moves it to the new <see cref="Archetype"/>.
    /// </summary>
    /// <param name="world">The world to operate on.</param>
    /// <param name="entity">The <see cref="Entity"/>.</param>
    /// <param name="components">A <see cref="IList{T}"/> of <see cref="ComponentType"/>'s, those are added to the <see cref="Entity"/>.</param>
    [SkipLocalsInit]
    internal static void AddRange(World world, Entity entity, Span<ComponentType> components)
    {
        ref var data = ref world.EntityInfo.EntityData[entity.Id];
        var oldArchetype = data.Archetype;

        // BitSet to stack/span bitset, size big enough to contain ALL registered components.
        Span<uint> stack = stackalloc uint[BitSet.RequiredLength(ComponentRegistry.Size)];
        oldArchetype.BitSet.AsSpan(stack);

        // Create a span bitset, doing it local saves us headache and gargabe
        var spanBitSet = new SpanBitSet(stack);

        for (var index = 0; index < components.Length; index++)
        {
            var type = components[index];
            spanBitSet.SetBit(type.Id);
        }

        if (!world.TryGetArchetype(spanBitSet.GetHashCode(), out var newArchetype))
        {
            var newSignature = Signature.Add(oldArchetype.Signature, components);
            newArchetype = world.GetOrCreate(newSignature);
        }

        world.Move(entity, ref data, oldArchetype, newArchetype, out _);
    }

    /// <summary>
    ///     Creates a new <see cref="Entity"/> with the given component structure without firing any events.
    ///     Combines <see cref="World.EnsureCapacity"/>, <see cref="World.GetOrCreateEntitiesInternal"/>, <see cref="Archetype.AddAll"/> and <see cref="World.AddEntityData"/>.
    /// </summary>
    /// <param name="world">The world to operate on.</param>
    /// <param name="signature">The component structure of the <see cref="Entity"/> to create.</param>
    /// <returns>The created <see cref="Entity"/>.</returns>
    internal static Entity CreateWithoutEvents(World world, in Signature signature)
    {
        // Ensure capacity of the archetype
        var archetype = world.EnsureCapacity(in signature, 1);

        // Prepare entities and data
        using var entityArray = Pool<Entity>.Rent(1);
        using var entityDataArray = Pool<EntityData>.Rent(1);
        var entities = entityArray.AsSpan();
        var entityData = entityDataArray.AsSpan();

        // Create entities
        world.GetOrCreateEntitiesInternal(archetype, entities, entityData, 1);
        archetype.AddAll(entities, 1);

        // Add entity to entityinfo
        world.AddEntityData(entities, entityData, 1);

        return entities[0];
    }
}
