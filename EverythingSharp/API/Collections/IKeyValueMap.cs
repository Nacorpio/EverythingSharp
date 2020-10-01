using System.Collections.Generic;

using EverythingSharp.Common.Events;

using JetBrains.Annotations;

namespace EverythingSharp.API.Collections
{

  public interface IReadOnlyKeyValueMap<TKey, TValue>
  {
    TValue this[TKey key] { get; }

    IEnumerable<TKey> Keys { get; }
    IEnumerable<TValue> Values { get; }

    bool Contains(TKey key);
    bool TryGetItem(TKey key, out TValue value);
  }

  public interface IKeyValueMap<TKey, TValue> : IReadOnlyKeyValueMap <TKey, TValue>
  {
    event KeyValueMapItemAddedEventHandler<TKey, TValue> ItemAdded;
    event KeyValueMapItemRemovedEventHandler<TKey, TValue> ItemRemoved;
    event KeyValueMapItemModifiedEventHandler<TKey, TValue> ItemModified;

    void Add([NotNull] TKey key, TValue value);
    bool Remove([NotNull] TKey key);
  }

}