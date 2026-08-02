using Arch.Buffer;
using Arch.Core;

namespace Arch.Tests;

[TestFixture]
public sealed class SparseArrayTest
{
    private const int Range = 65;

    private static void AssertConsistent(SparseArray array, Dictionary<int, int> model, int step)
    {
        for (int i = 0; i < Range; i++)
        {
            bool contains = model.ContainsKey(i);
            Assert.That(array.Contains(i), Is.EqualTo(contains), $"Contains mismatch at step {step}, index {i}");
            if (!contains)
            {
                continue;
            }

            Assert.That(array.Get<int>(i), Is.EqualTo(model[i]), $"Value mismatch at step {step}, index {i}");

            int pos = array.Entities[i];
            Assert.That(pos, Is.InRange(0, array.Size - 1), $"Entities[{i}] out of range at step {step}");
            Assert.That(array.Dense[pos], Is.EqualTo(i), $"Dense inversion broken at step {step}, index {i}");
        }

        Assert.That(array.Size, Is.EqualTo(model.Count), $"Size mismatch at step {step}");
    }

    [Test]
    public void RandomDifferentialOperations()
    {
        var array = new SparseArray(Component<int>.ComponentType, Range);
        var model = new Dictionary<int, int>();
        var random = new Random(42);

        for (int step = 0; step < 2000; step++)
        {
            int action = random.Next(5);
            int index = random.Next(Range);

            switch (action)
            {
                case 0: // Add
                    array.Add(index);
                    if (!model.ContainsKey(index))
                    {
                        // A freshly added slot may hold stale data left by swap-remove; record its actual value.
                        model[index] = array.Get<int>(index);
                    }
                    break;

                case 1: // Remove
                    array.Remove(index);
                    model.Remove(index);
                    break;

                case 2: // Set
                    if (model.ContainsKey(index))
                    {
                        int value = random.Next(1_000_000);
                        model[index] = value;
                        array.Set(index, value);
                    }
                    break;

                case 3: // Get
                    if (model.ContainsKey(index))
                    {
                        Assert.That(array.Get<int>(index), Is.EqualTo(model[index]), $"Get mismatch at step {step}, index {index}");
                    }
                    break;

                default: // Contains
                    Assert.That(array.Contains(index), Is.EqualTo(model.ContainsKey(index)), $"Contains mismatch at step {step}, index {index}");
                    break;
            }

            AssertConsistent(array, model, step);
        }
    }

    [Test]
    public void SwapRemovePreservesValuesAndRecovery()
    {
        var array = new SparseArray(Component<int>.ComponentType, Range);

        array.Add(5);
        array.Add(3);
        array.Add(9);
        array.Add(3);
        Assert.That(array.Size, Is.EqualTo(3));

        array.Set(3, 333);
        array.Set(5, 555);
        array.Set(9, 999);

        array.Remove(5);

        Assert.That(array.Contains(3), Is.True);
        Assert.That(array.Contains(9), Is.True);
        Assert.That(array.Contains(5), Is.False);
        Assert.That(array.Size, Is.EqualTo(2));
        Assert.That(array.Get<int>(9), Is.EqualTo(999), "Value must survive the swap");
        Assert.That(array.Get<int>(3), Is.EqualTo(333));

        array.Add(5);
        array.Set(5, 55);

        Assert.That(array.Contains(5), Is.True);
        Assert.That(array.Get<int>(5), Is.EqualTo(55));
        Assert.That(array.Size, Is.EqualTo(3));
    }

    [Test]
    public void RemoveAddLoopDoesNotOverflow()
    {
        var array = new SparseArray(Component<int>.ComponentType, 64);

        for (int i = 0; i < 200; i++)
        {
            array.Remove(0);
            array.Add(0);
            array.Set(0, i);

            Assert.That(array.Get<int>(0), Is.EqualTo(i));
            Assert.That(array.Size, Is.EqualTo(1));
        }
    }

    [Test]
    public void RemovingAbsentIndexIsNoOp()
    {
        var array = new SparseArray(Component<int>.ComponentType, Range);

        array.Remove(1000);
        Assert.That(array.Size, Is.EqualTo(0));

        array.Add(7);
        array.Add(7);
        Assert.That(array.Size, Is.EqualTo(1));

        array.Remove(7);
        array.Remove(7);
        Assert.That(array.Size, Is.EqualTo(0));
        Assert.That(array.Contains(7), Is.False);

        array.Remove(7);
        Assert.That(array.Size, Is.EqualTo(0));
    }

    [Test]
    public void ClearResetsState()
    {
        var array = new SparseArray(Component<int>.ComponentType, Range);

        array.Add(2);
        array.Add(9);
        array.Set(2, 22);
        array.Set(9, 99);

        array.Clear();

        Assert.That(array.Size, Is.EqualTo(0));
        for (int i = 0; i < Range; i++)
        {
            Assert.That(array.Contains(i), Is.False);
            Assert.That(array.Entities[i], Is.EqualTo(-1));
            Assert.That(array.Dense[i], Is.EqualTo(-1));
        }
    }
}
