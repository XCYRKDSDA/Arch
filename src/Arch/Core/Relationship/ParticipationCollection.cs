namespace Arch.Core.Relationship;

/// <summary>
/// 存储参与关系的容器，对实体参与的每个关系，记录关系实体 Id 和关系契约本身的拷贝。
/// 针对小对象优化：在结构中直接存储第一个关系，因为大部分实体作为某个身份只会参与一个关系。
/// 超过一个的关系存储在列表中，后续待优化为 JaggedArray 以避免扩张时拷贝。
/// 为优化删除行为，容器使用 swap-remove 方法，因此整个容器没有顺序保证。
/// </summary>
/// <typeparam name="T">关系契约类型</typeparam>
public struct PaticipationCollection<T> : IReadOnlyCollection<(Entity Relationship, T Copy)>
    where T : struct
{
    private (Entity Relationship, T Copy)? _firstParticipation;

    private List<(Entity Relationship, T Copy)>? _otherParticipations; // TODO: 可以仿照 JaggedArray 或 Chunks 优化

    public readonly int Count
    {
        get => _firstParticipation is null ? 0 : (1 + (_otherParticipations?.Count ?? 0));
    }

    internal readonly (Entity Relationship, T Copy) this[int i]
    {
        get
        {
            Debug.Assert(i >= 0);
            Debug.Assert(i < Count);
            return i == 0 ? _firstParticipation!.Value : _otherParticipations![i - 1];
        }
    }

    /// <summary>
    /// 添加新的参与关系
    /// </summary>
    /// <param name="relationship">参与的关系实体</param>
    /// <param name="relationshipCopy">参与的关系契约的拷贝</param>
    /// <returns>新的关系在容器中所在的位置，供外部缓存下来之后用于删除</returns>
    internal int Add(Entity relationship, T relationshipCopy)
    {
        var newParticipation = (relationship, relationshipCopy);
        if (_firstParticipation is null)
        {
            _firstParticipation = newParticipation;
            return 0;
        }
        else
        {
            _otherParticipations ??= new List<(Entity Relationship, T Copy)>(16);
            _otherParticipations.Add(newParticipation);
            return _otherParticipations.Count;
        }
    }

    /// <summary>
    /// 移除某个位置的参与关系
    /// </summary>
    /// <param name="i">位置</param>
    /// <returns>如果发生了 swap，则为被 swap 的记录的关系实体，需要更新其中位置缓存</returns>
    internal Entity? SwapRemove(int i)
    {
        Debug.Assert(i >= 0);
        Debug.Assert(i < Count);
        if (i == Count - 1)
        {
            if (i == 0)
            {
                _firstParticipation = null;
            }
            else
            {
                _otherParticipations!.RemoveAt(_otherParticipations.Count - 1);
            }

            return null;
        }
        else
        {
            var tail = _otherParticipations![^1];
            _otherParticipations!.RemoveAt(_otherParticipations.Count - 1);
            if (i == 0)
            {
                _firstParticipation = tail;
            }
            else
            {
                _otherParticipations[i - 1] = tail;
            }

            return tail.Relationship;
        }
    }

    public IEnumerator<(Entity Relationship, T Copy)> GetEnumerator()
    {
        if (_firstParticipation.HasValue)
        {
            yield return _firstParticipation.Value;
        }

        if (_otherParticipations is not null)
        {
            for (int i = 0; i < _otherParticipations.Count; i++)
            {
                yield return _otherParticipations[i];
            }
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

