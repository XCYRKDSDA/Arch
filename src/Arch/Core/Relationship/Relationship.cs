namespace Arch.Core.Relationship;

/// <summary>
/// 关系组件类型，包含一份契约和内部的索引
/// </summary>
/// <typeparam name="TR">关系契约类型</typeparam>
/// <typeparam name="T1">参与关系的第一个实体的身份标识类型</typeparam>
/// <typeparam name="T2">参与关系的第二个实体的身份标识类型</typeparam>
/// <param name="contract">关系契约对象</param>
public struct Relationship<TR, T1, T2>(TR contract)
    where TR : struct, IRelationshipContract<T1, T2>
{
    internal int RecordPosition1 = -1;
    internal int RecordPosition2 = -1;

    public TR Contract = contract;
}

