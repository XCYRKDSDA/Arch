namespace Arch.Core.Relationship;

/// <summary>
/// 参与者组件，描述了以特定身份参与特定关系的能力，同时记录索引
/// </summary>
/// <typeparam name="TR">关系契约类型</typeparam>
/// <typeparam name="T">参与者在关系中的身份标识类型</typeparam>
public struct Participant<TR, T>()
    where TR : struct
{
    public PaticipationCollection<TR> Participations;
}

