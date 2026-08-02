using Arch.Buffer;
using Arch.Core;

namespace Arch.Tests;

[TestFixture]
public sealed class StructuralSparseSetTest
{
    [Test]
    public void RemoveT_RemovesOnlySpecifiedType()
    {
        var test = new StructuralSparseSet();

        test.Create(new Entity(0, 1));
        test.Create(new Entity(1, 1));
        test.Set<Transform>(0);
        test.Set<Transform>(1);
        test.Set<Rotation>(0);
        test.Set<Rotation>(1);

        test.Remove<Transform>(0);

        Assert.That(test.Contains<Transform>(0), Is.False);
        Assert.That(test.Contains<Transform>(1), Is.True, "其他实体的 Transform 不受影响");
        Assert.That(test.Contains<Rotation>(0), Is.True, "其他类型的记录不受影响");
        Assert.That(test.Contains<Rotation>(1), Is.True);
    }

    [Test]
    public void Remove_RemovesIndexFromAllTypes()
    {
        var test = new StructuralSparseSet();

        test.Create(new Entity(0, 1));
        test.Create(new Entity(1, 1));
        test.Set<Transform>(0);
        test.Set<Transform>(1);
        test.Set<Rotation>(0);
        test.Set<Rotation>(1);

        test.Remove(0);

        Assert.That(test.Contains<Transform>(0), Is.False);
        Assert.That(test.Contains<Rotation>(0), Is.False);
        Assert.That(test.Contains<Transform>(1), Is.True, "实体 1 的 Transform 不受影响");
        Assert.That(test.Contains<Rotation>(1), Is.True, "实体 1 的 Rotation 不受影响");
    }

    [Test]
    public void RemoveT_WhenTypeNeverRegistered_IsNoOp()
    {
        var test = new StructuralSparseSet();

        test.Create(new Entity(0, 1));
        test.Set<Transform>(0);

        Assert.DoesNotThrow(() => test.Remove<Ai>(0));
        Assert.That(test.Contains<Transform>(0), Is.True, "Transform 记录不受影响");
    }

    [Test]
    public void RemoveThenSet_RestoresRecord()
    {
        var test = new StructuralSparseSet();

        test.Create(new Entity(0, 1));
        test.Set<Transform>(0);
        test.Remove<Transform>(0);
        Assert.That(test.Contains<Transform>(0), Is.False);

        test.Set<Transform>(0);
        Assert.That(test.Contains<Transform>(0), Is.True, "重新 Set 后恢复");
    }

    [Test]
    public void ContainsT_WhenTypeIdExceedsCapacity_ReturnsFalse()
    {
        var test = new StructuralSparseSet();
        test.Create(new Entity(0, 1));

        Assert.That(test.Contains<Ai>(0), Is.False);
        Assert.That(test.Contains<Rotation>(0), Is.False);
    }
}
