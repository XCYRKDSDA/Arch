using Arch.Buffer;

namespace Arch.Tests;

[TestFixture]
public sealed partial class StructuralSparseArrayTest
{
    private static void TestEquivalent(StructuralSparseArray test, HashSet<int> control)
    {
        // Brute force test every index
        for (int i = 0; i < 128; i++)
        {
            bool contains = control.Contains(i);
            Assert.That(test.Contains(i), Is.EqualTo(contains));
        }
    }

    [Test]
    public void ClearAndAccessMany()
    {
        var test = new StructuralSparseArray(new(1, 0));
        var control = new HashSet<int>();

        for (int i = 0; i < 10; i++)
        {
            control.Add(52 + i);
            test.Add(52 + i);

            TestEquivalent(test, control);
            Assert.That(test.Size, Is.EqualTo(control.Count));

            control.Add(3 + i);
            test.Add(3 + i);

            TestEquivalent(test, control);
            Assert.That(test.Size, Is.EqualTo(control.Count));

            control.Clear();
            test.Clear();

            TestEquivalent(test, control);
            Assert.That(test.Size, Is.EqualTo(control.Count));

            control.Add(3);
            test.Add(3);

            TestEquivalent(test, control);
            Assert.That(test.Size, Is.EqualTo(control.Count));

            control.Add(3);
            test.Add(3);

            TestEquivalent(test, control);
            Assert.That(test.Size, Is.EqualTo(control.Count));

            control.Clear();
            test.Clear();

            TestEquivalent(test, control);
            Assert.That(test.Size, Is.EqualTo(control.Count));
        }
    }

    [Test]
    public void AddIsIdempotent()
    {
        var test = new StructuralSparseArray(new(1, 0));
        var control = new HashSet<int>();

        control.Add(3);
        test.Add(3);
        control.Add(3);
        test.Add(3);

        Assert.That(test.Size, Is.EqualTo(control.Count));
        Assert.That(test.Size, Is.EqualTo(1));
        Assert.That(test.Contains(3), Is.True);
    }

    [Test]
    public void RemoveNonExistentKeepsSize()
    {
        var test = new StructuralSparseArray(new(1, 0));
        var control = new HashSet<int>();

        test.Remove(3);
        control.Remove(3);
        Assert.That(test.Size, Is.EqualTo(control.Count));
        Assert.That(test.Size, Is.EqualTo(0));

        control.Add(5);
        test.Add(5);
        Assert.That(test.Size, Is.EqualTo(control.Count));

        test.Remove(-1);
        test.Remove(9999);
        control.Remove(-1);
        control.Remove(9999);
        Assert.That(test.Size, Is.EqualTo(control.Count));
        Assert.That(test.Size, Is.EqualTo(1));
    }

    [Test]
    public void AddRemoveAlternatingKeepsSize()
    {
        var test = new StructuralSparseArray(new(1, 0));
        var control = new HashSet<int>();

        control.Add(1);
        test.Add(1);
        Assert.That(test.Size, Is.EqualTo(control.Count));

        control.Add(2);
        test.Add(2);
        Assert.That(test.Size, Is.EqualTo(control.Count));

        control.Remove(1);
        test.Remove(1);
        Assert.That(test.Size, Is.EqualTo(control.Count));

        control.Add(1);
        test.Add(1);
        Assert.That(test.Size, Is.EqualTo(control.Count));

        control.Add(2);
        test.Add(2);
        Assert.That(test.Size, Is.EqualTo(control.Count));

        Assert.That(test.Size, Is.EqualTo(2));
    }

    [Test]
    public void AddBeyondCapacityWorks()
    {
        var test = new StructuralSparseArray(new(1, 0), 64);

        test.Add(0);
        Assert.That(test.Size, Is.EqualTo(1));

        // 越界 Add：触发扩容路径。回归：曾因 Array.Fill 漏填新末槽（默认值 0）
        // 导致幂等守卫误判"已存在"而静默丢失登记。
        test.Add(100);
        Assert.That(test.Size, Is.EqualTo(2));
        Assert.That(test.Contains(0), Is.True);
        Assert.That(test.Contains(100), Is.True);

        // 扩容后再 Add 已存在 index：幂等
        test.Add(100);
        Assert.That(test.Size, Is.EqualTo(2));

        // 扩容后 Remove 存在 index：Size-- 正确
        test.Remove(100);
        Assert.That(test.Size, Is.EqualTo(1));
        Assert.That(test.Contains(100), Is.False);
    }
}
