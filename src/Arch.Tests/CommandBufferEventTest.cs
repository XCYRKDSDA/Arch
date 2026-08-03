using Arch.Buffer;
using Arch.Core;
using Arch.Core.Utils;

namespace Arch.Tests;

#if EVENTS

/// <summary>
///     Verifies the event semantics of <see cref="CommandBuffer"/> playback.
///     Events are raised at the end of playback in a fixed order:
///     <see cref="World.OnEntityDestroyed"/> → <see cref="World.OnComponentRemoved"/> →
///     <see cref="World.OnEntityCreated"/> → <see cref="World.OnComponentAdded"/> →
///     <see cref="World.OnComponentSet"/>.
///     Only counts and values are asserted; the internal order of events of the same type is not asserted.
/// </summary>
[TestFixture]
public sealed class CommandBufferEventTest
{
    private struct EventBufferTestComponent
    {
        public int Value;
    }

    [Test]
    public void CreateAndSet_EmitsSingleAddWithValue()
    {
        using var world = World.Create();
        var added = new List<(Entity Entity, int Value)>();
        var set = new List<(Entity Entity, int Value)>();
        world.SubscribeComponentAdded<EventBufferTestComponent>((in Entity entity, ref EventBufferTestComponent cmp) => added.Add((entity, cmp.Value)));
        world.SubscribeComponentSet<EventBufferTestComponent>((in Entity entity, in EventBufferTestComponent _, ref EventBufferTestComponent cmp) => set.Add((entity, cmp.Value)));

        using var buffer = new CommandBuffer();
        var buffered = buffer.Create([typeof(EventBufferTestComponent)]);
        buffer.Set(buffered, new EventBufferTestComponent { Value = 42 });
        buffer.Playback(world);

        Assert.That(added, Has.Count.EqualTo(1));
        // 只断言 Id 与 Version，不断言 WorldId：World.Id 来自全局静态注册表，非确定性（与 WorldRecycle flaky 同机制）。
        Assert.That(added[0].Entity.Id, Is.EqualTo(0));
        Assert.That(added[0].Entity.Version, Is.EqualTo(1));
        Assert.That(added[0].Value, Is.EqualTo(42));
        Assert.That(set, Is.Empty);
    }

    [Test]
    public void AddAndSet_EmitsSingleAddWithValue()
    {
        using var world = World.Create();
        // Create before subscribing so the creation itself is not captured.
        var entity = world.Create<EventBufferTestComponent>();
        var added = new List<(Entity Entity, int Value)>();
        var set = new List<(Entity Entity, int Value)>();
        world.SubscribeComponentAdded<EventBufferTestComponent>((in Entity entity, ref EventBufferTestComponent cmp) => added.Add((entity, cmp.Value)));
        world.SubscribeComponentSet<EventBufferTestComponent>((in Entity entity, in EventBufferTestComponent _, ref EventBufferTestComponent cmp) => set.Add((entity, cmp.Value)));

        using var buffer = new CommandBuffer();
        buffer.Add(entity, new EventBufferTestComponent { Value = 99 });
        buffer.Playback(world);

        Assert.That(added, Has.Count.EqualTo(1));
        Assert.That(added[0].Entity, Is.EqualTo(entity));
        Assert.That(added[0].Value, Is.EqualTo(99));
        Assert.That(set, Is.Empty);
    }

    [Test]
    public void CreateWithoutSet_EmitsSingleAddWithDefaultValue()
    {
        using var world = World.Create();
        var added = new List<(Entity Entity, int Value)>();
        var set = new List<(Entity Entity, int Value)>();
        world.SubscribeComponentAdded<EventBufferTestComponent>((in Entity entity, ref EventBufferTestComponent cmp) => added.Add((entity, cmp.Value)));
        world.SubscribeComponentSet<EventBufferTestComponent>((in Entity entity, in EventBufferTestComponent _, ref EventBufferTestComponent cmp) => set.Add((entity, cmp.Value)));

        using var buffer = new CommandBuffer();
        buffer.Create([typeof(EventBufferTestComponent)]);
        buffer.Playback(world);

        Assert.That(added, Has.Count.EqualTo(1));
        // 只断言 Id 与 Version，不断言 WorldId：World.Id 来自全局静态注册表，非确定性（与 WorldRecycle flaky 同机制）。
        Assert.That(added[0].Entity.Id, Is.EqualTo(0));
        Assert.That(added[0].Entity.Version, Is.EqualTo(1));
        Assert.That(added[0].Value, Is.EqualTo(0));
        Assert.That(set, Is.Empty);
    }

    [Test]
    public void SetOnExistingComponent_EmitsSingleSet()
    {
        using var world = World.Create();
        // Create before subscribing so the creation itself is not captured.
        var entity = world.Create<EventBufferTestComponent>();
        var added = new List<(Entity Entity, int Value)>();
        var set = new List<(Entity Entity, int OldValue, int NewValue)>();
        world.SubscribeComponentAdded<EventBufferTestComponent>((in Entity entity, ref EventBufferTestComponent cmp) => added.Add((entity, cmp.Value)));
        world.SubscribeComponentSet<EventBufferTestComponent>((in Entity entity, in EventBufferTestComponent oldValue, ref EventBufferTestComponent cmp) => set.Add((entity, oldValue.Value, cmp.Value)));

        using var buffer = new CommandBuffer();
        buffer.Set(entity, new EventBufferTestComponent { Value = 7 });
        buffer.Playback(world);

        Assert.That(set, Has.Count.EqualTo(1));
        Assert.That(set[0].Entity, Is.EqualTo(entity));
        Assert.That(set[0].OldValue, Is.EqualTo(0), "旧值为实体在写值前的组件值（默认值）");
        Assert.That(set[0].NewValue, Is.EqualTo(7));
        Assert.That(added, Is.Empty);
    }

    [Test]
    public void SetOnNonDefaultValue_EmitsOldValueFromEntity()
    {
        using var world = World.Create();
        // Create with a non-default value before subscribing so the creation itself is not captured.
        var entity = world.Create(new EventBufferTestComponent { Value = 5 });
        var set = new List<(Entity Entity, int OldValue, int NewValue)>();
        world.SubscribeComponentSet<EventBufferTestComponent>((in Entity entity, in EventBufferTestComponent oldValue, ref EventBufferTestComponent cmp) => set.Add((entity, oldValue.Value, cmp.Value)));

        using var buffer = new CommandBuffer();
        buffer.Set(entity, new EventBufferTestComponent { Value = 7 });
        buffer.Playback(world);

        Assert.That(set, Has.Count.EqualTo(1));
        Assert.That(set[0].Entity, Is.EqualTo(entity));
        Assert.That(set[0].OldValue, Is.EqualTo(5), "旧值来自实体在写值前的状态");
        Assert.That(set[0].NewValue, Is.EqualTo(7));
    }

    [Test]
    public void CancelledCreate_EmitsNoEvents()
    {
        using var world = World.Create();
        var created = new List<Entity>();
        var destroyed = new List<Entity>();
        var added = new List<Entity>();
        var set = new List<Entity>();
        var removed = new List<Entity>();
        world.SubscribeEntityCreated((in Entity entity) => created.Add(entity));
        world.SubscribeEntityDestroyed((in Entity entity) => destroyed.Add(entity));
        world.SubscribeComponentAdded<EventBufferTestComponent>((in Entity entity, ref EventBufferTestComponent _) => added.Add(entity));
        world.SubscribeComponentSet<EventBufferTestComponent>((in Entity entity, in EventBufferTestComponent _, ref EventBufferTestComponent _) => set.Add(entity));
        world.SubscribeComponentRemoved<EventBufferTestComponent>((in Entity entity, ref EventBufferTestComponent _) => removed.Add(entity));

        using var buffer = new CommandBuffer();
        var buffered = buffer.Create([typeof(EventBufferTestComponent)]);
        buffer.Destroy(buffered);
        buffer.Playback(world);

        Assert.That(world.Size, Is.EqualTo(0));
        Assert.That(created, Is.Empty);
        Assert.That(destroyed, Is.Empty);
        Assert.That(added, Is.Empty);
        Assert.That(set, Is.Empty);
        Assert.That(removed, Is.Empty);
    }

    [Test]
    public void Remove_EmitsComponentRemoved()
    {
        using var world = World.Create();
        // Create before subscribing so the creation itself is not captured.
        var entity = world.Create<EventBufferTestComponent>();
        var removed = new List<Entity>();
        world.SubscribeComponentRemoved<EventBufferTestComponent>((in Entity entity, ref EventBufferTestComponent _) => removed.Add(entity));

        using var buffer = new CommandBuffer();
        buffer.Remove<EventBufferTestComponent>(entity);
        buffer.Playback(world);

        Assert.That(removed, Has.Count.EqualTo(1));
        Assert.That(removed[0], Is.EqualTo(entity));
    }

    [Test]
    public void CreateAndSet_DoesNotDoubleFireAdd()
    {
        using var world = World.Create();
        var added = new List<Entity>();
        world.SubscribeComponentAdded<EventBufferTestComponent>((in Entity entity, ref EventBufferTestComponent _) => added.Add(entity));

        using var buffer = new CommandBuffer();
        var buffered = buffer.Create([typeof(EventBufferTestComponent)]);
        buffer.Set(buffered, new EventBufferTestComponent { Value = 1 });
        buffer.Playback(world);

        Assert.That(added, Has.Count.EqualTo(1));
    }

    [Test]
    public void CreateAndSet_EntityCreatedFiresBeforeComponentAdded()
    {
        using var world = World.Create();
        var log = new List<(string Kind, Entity Entity)>();
        world.SubscribeEntityCreated((in Entity entity) => log.Add(("Created", entity)));
        world.SubscribeComponentAdded<EventBufferTestComponent>((in Entity entity, ref EventBufferTestComponent _) => log.Add(("Added", entity)));

        using var buffer = new CommandBuffer();
        var buffered = buffer.Create([typeof(EventBufferTestComponent)]);
        buffer.Set(buffered, new EventBufferTestComponent { Value = 1 });
        buffer.Playback(world);

        Assert.That(log, Has.Count.EqualTo(2));
        Assert.That(log[0].Kind, Is.EqualTo("Created"));
        Assert.That(log[1].Kind, Is.EqualTo("Added"));
        Assert.That(log[0].Entity, Is.EqualTo(log[1].Entity));
    }

    [Test]
    public void CreateMultipleComponents_EmitsAddPerComponent()
    {
        using var world = World.Create();
        var created = new List<Entity>();
        var addedComponent = new List<Entity>();
        var addedTransform = new List<Entity>();
        var set = new List<Entity>();
        world.SubscribeEntityCreated((in Entity entity) => created.Add(entity));
        world.SubscribeComponentAdded<EventBufferTestComponent>((in Entity entity, ref EventBufferTestComponent _) => addedComponent.Add(entity));
        world.SubscribeComponentAdded<Transform>((in Entity entity, ref Transform _) => addedTransform.Add(entity));
        world.SubscribeComponentSet<EventBufferTestComponent>((in Entity entity, in EventBufferTestComponent _, ref EventBufferTestComponent _) => set.Add(entity));

        using var buffer = new CommandBuffer();
        buffer.Create([typeof(EventBufferTestComponent), typeof(Transform)]);
        buffer.Playback(world);

        Assert.That(created, Has.Count.EqualTo(1));
        Assert.That(addedComponent, Has.Count.EqualTo(1));
        Assert.That(addedTransform, Has.Count.EqualTo(1));
        Assert.That(addedComponent[0], Is.EqualTo(addedTransform[0]), "同一实体的组件事件");
        Assert.That(set, Is.Empty);
    }

    [Test]
    public void AddComponent_EmitsAddForNewComponentOnly()
    {
        using var world = World.Create();
        // Create before subscribing so the creation itself is not captured.
        var entity = world.Create<EventBufferTestComponent>();
        var addedComponent = new List<Entity>();
        var addedTransform = new List<Entity>();
        var set = new List<Entity>();
        world.SubscribeComponentAdded<EventBufferTestComponent>((in Entity entity, ref EventBufferTestComponent _) => addedComponent.Add(entity));
        world.SubscribeComponentAdded<Transform>((in Entity entity, ref Transform _) => addedTransform.Add(entity));
        world.SubscribeComponentSet<EventBufferTestComponent>((in Entity entity, in EventBufferTestComponent _, ref EventBufferTestComponent _) => set.Add(entity));

        using var buffer = new CommandBuffer();
        buffer.Add<Transform>(entity);
        buffer.Playback(world);

        Assert.That(addedComponent, Is.Empty, "已存在的组件不触发 Add");
        Assert.That(addedTransform, Has.Count.EqualTo(1));
        Assert.That(set, Is.Empty);
    }

    [Test]
    public void MultipleEntities_EmitsEventsIndependently()
    {
        using var world = World.Create();
        var added = new List<Entity>();
        world.SubscribeComponentAdded<EventBufferTestComponent>((in Entity entity, ref EventBufferTestComponent _) => added.Add(entity));

        using var buffer = new CommandBuffer();
        var first = buffer.Create([typeof(EventBufferTestComponent)]);
        var second = buffer.Create([typeof(EventBufferTestComponent)]);
        buffer.Playback(world);

        Assert.That(added, Has.Count.EqualTo(2));
        Assert.That(added[0].Id, Is.Not.EqualTo(added[1].Id), "两个实体各自触发一次");
    }

    [Test]
    public void SetTwice_EmitsSingleSetWithFinalValue()
    {
        using var world = World.Create();
        // Create before subscribing so the creation itself is not captured.
        var entity = world.Create<EventBufferTestComponent>();
        var added = new List<Entity>();
        var set = new List<(Entity Entity, int OldValue, int NewValue)>();
        world.SubscribeComponentAdded<EventBufferTestComponent>((in Entity entity, ref EventBufferTestComponent _) => added.Add(entity));
        world.SubscribeComponentSet<EventBufferTestComponent>((in Entity entity, in EventBufferTestComponent oldValue, ref EventBufferTestComponent cmp) => set.Add((entity, oldValue.Value, cmp.Value)));

        using var buffer = new CommandBuffer();
        buffer.Set(entity, new EventBufferTestComponent { Value = 1 });
        buffer.Set(entity, new EventBufferTestComponent { Value = 2 });
        buffer.Playback(world);

        // 同实体同组件连续 Set 只保留一条记录（后值覆盖前值），因此只触发一次 Set 事件，值为最终写入值。
        Assert.That(added, Is.Empty, "Set 不触发 Add");
        Assert.That(set, Has.Count.EqualTo(1));
        Assert.That(set[0].OldValue, Is.EqualTo(0), "旧值为实体在 Playback 前的组件值（记录期不写实体）");
        Assert.That(set[0].NewValue, Is.EqualTo(2), "值为最终写入值");
    }

    [Test]
    public void SetTwoComponents_EmitsSetPerComponent()
    {
        using var world = World.Create();
        // Create before subscribing so the creation itself is not captured.
        var entity = world.Create<EventBufferTestComponent, Transform>();
        var setComponent = new List<(Entity Entity, int OldValue, int NewValue)>();
        var setTransform = new List<(Entity Entity, Transform OldValue, Transform NewValue)>();
        var added = new List<Entity>();
        world.SubscribeComponentSet<EventBufferTestComponent>((in Entity entity, in EventBufferTestComponent oldValue, ref EventBufferTestComponent cmp) => setComponent.Add((entity, oldValue.Value, cmp.Value)));
        world.SubscribeComponentSet<Transform>((in Entity entity, in Transform oldValue, ref Transform newValue) => setTransform.Add((entity, oldValue, newValue)));
        world.SubscribeComponentAdded<EventBufferTestComponent>((in Entity entity, ref EventBufferTestComponent _) => added.Add(entity));

        using var buffer = new CommandBuffer();
        buffer.Set(entity, new EventBufferTestComponent { Value = 1 });
        buffer.Set(entity, new Transform { X = 2 });
        buffer.Playback(world);

        Assert.That(setComponent, Has.Count.EqualTo(1));
        Assert.That(setComponent[0].OldValue, Is.EqualTo(0), "旧值为实体在写值前的组件值（默认值）");
        Assert.That(setComponent[0].NewValue, Is.EqualTo(1));
        Assert.That(setTransform, Has.Count.EqualTo(1));
        Assert.That(setTransform[0].OldValue.X, Is.EqualTo(0), "旧值为实体在写值前的组件值（默认值）");
        Assert.That(setTransform[0].NewValue.X, Is.EqualTo(2));
        Assert.That(added, Is.Empty);
    }

    [Test]
    public void Destroy_EmitsEntityDestroyedAndComponentRemovedPerSignature()
    {
        using var world = World.Create();
        // Create before subscribing so the creation itself is not captured.
        var entity = world.Create<EventBufferTestComponent, Transform>();
        var destroyed = new List<Entity>();
        var removedComponent = new List<Entity>();
        var removedTransform = new List<Entity>();
        world.SubscribeEntityDestroyed((in Entity entity) => destroyed.Add(entity));
        world.SubscribeComponentRemoved<EventBufferTestComponent>((in Entity entity, ref EventBufferTestComponent _) => removedComponent.Add(entity));
        world.SubscribeComponentRemoved<Transform>((in Entity entity, ref Transform _) => removedTransform.Add(entity));

        using var buffer = new CommandBuffer();
        buffer.Destroy(entity);
        buffer.Playback(world);

        Assert.That(destroyed, Has.Count.EqualTo(1));
        Assert.That(destroyed[0], Is.EqualTo(entity));
        Assert.That(removedComponent, Has.Count.EqualTo(1));
        Assert.That(removedTransform, Has.Count.EqualTo(1));
    }
}

#endif
