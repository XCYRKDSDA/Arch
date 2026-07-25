namespace Arch.Core.Relationship;

/// <summary>
/// 关系契约接口，用于桥接用户自定义的关系契约和框架实现。
/// 用户可以自定义参与实体的存储方式，只要提供 Unpack 接口供框架访问即可
/// </summary>
/// <typeparam name="T1">参与关系的第一个实体的身份标识类型</typeparam>
/// <typeparam name="T2">参与关系的第二个实体的身份标识类型</typeparam>
public interface IRelationshipContract<T1, T2>
{
    (Entity, Entity) Unpack();
}

