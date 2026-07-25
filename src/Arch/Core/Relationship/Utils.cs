namespace Arch.Core.Relationship;

internal static class Utils
{
    /// <summary>
    /// 在所有参与者的组件中记录一个新的关系
    /// </summary>
    /// <typeparam name="TR">关系契约类型</typeparam>
    /// <typeparam name="T1">参与关系的第一个实体的身份标识类型</typeparam>
    /// <typeparam name="T2">参与关系的第二个实体的身份标识类型</typeparam>
    /// <param name="world">实体所在的世界对象</param>
    /// <param name="relationshipEntity">关系实体</param>
    /// <param name="relationshipComponent">关系组件</param>
    public static void RecordRelationship<TR, T1, T2>(
        World world,
        Entity relationshipEntity,
        ref Relationship<TR, T1, T2> relationshipComponent
    )
        where TR : struct, IRelationshipContract<T1, T2>
    {
        var (participant1, participant2) = relationshipComponent.Contract.Unpack();

        Debug.Assert(relationshipComponent.RecordPosition1 == -1);
        Debug.Assert(relationshipComponent.RecordPosition2 == -1);
        Debug.Assert(world.Has<Participant<TR, T2>>(participant1));
        Debug.Assert(world.Has<Participant<TR, T1>>(participant2));

        relationshipComponent.RecordPosition1 = world
            .Get<Participant<TR, T1>>(participant1)
            .Participations.Add(relationshipEntity, relationshipComponent.Contract);
        relationshipComponent.RecordPosition2 = world
            .Get<Participant<TR, T2>>(participant2)
            .Participations.Add(relationshipEntity, relationshipComponent.Contract);
    }

    /// <summary>
    /// 在所有参与者的组件中移除一个关系
    /// </summary>
    /// <typeparam name="TR">关系契约类型</typeparam>
    /// <typeparam name="T1">参与关系的第一个实体的身份标识类型</typeparam>
    /// <typeparam name="T2">参与关系的第二个实体的身份标识类型</typeparam>
    /// <param name="world">实体所在的世界对象</param>
    /// <param name="relationship">关系组件</param>
    public static void EraseRelationship<TR, T1, T2>(
        World world,
        ref Relationship<TR, T1, T2> relationship
    )
        where TR : struct, IRelationshipContract<T1, T2>
    {
        var (participant1, participant2) = relationship.Contract.Unpack();

        Debug.Assert(relationship.RecordPosition1 != -1);
        Debug.Assert(relationship.RecordPosition2 != -1);
        Debug.Assert(world.Has<Participant<TR, T1>>(participant1));
        Debug.Assert(world.Has<Participant<TR, T2>>(participant2));

        var swappedEntity1 = world
            .Get<Participant<TR, T1>>(participant1)
            .Participations.SwapRemove(relationship.RecordPosition1);
        if (swappedEntity1.HasValue)
        {
            world.Get<Relationship<TR, T1, T2>>(swappedEntity1.Value).RecordPosition1 =
                relationship.RecordPosition1;
        }

        var swappedEntity2 = world
            .Get<Participant<TR, T2>>(participant2)
            .Participations.SwapRemove(relationship.RecordPosition2);
        if (swappedEntity2.HasValue)
        {
            world.Get<Relationship<TR, T1, T2>>(swappedEntity2.Value).RecordPosition2 =
                relationship.RecordPosition2;
        }
    }
}

