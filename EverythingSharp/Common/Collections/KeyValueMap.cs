using System.Collections.Generic;

using EverythingSharp.API.Collections;
using EverythingSharp.Common.Events;

namespace EverythingSharp.Common.Collections
{

  public class KeyValueMap<TKey, TValue> : IKeyValueMap<TKey, TValue>
  {
    public event KeyValueMapItemAddedEventHandler<TKey, TValue> ItemAdded;
    public event KeyValueMapItemRemovedEventHandler<TKey, TValue> ItemRemoved;
    public event KeyValueMapItemModifiedEventHandler<TKey, TValue> ItemModified;

    private readonly Dictionary<TKey, TValue> _map;

    public KeyValueMap()
    {
      _map = new Dictionary<TKey, TValue>();
    }

    public TValue this[TKey key] => throw new System.NotImplementedException();

    public IEnumerable<TKey> Keys => _map.Keys;
    public IEnumerable<TValue> Values => _map.Values;

    public void Add(TKey key, TValue value)
    {
      if (Contains(key))
      {
        return;
      }

      _map.Add(key, value);
      ItemAdded?.Invoke(this, new KeyValueMapItemAddedEventArgs<TKey, TValue>(this, key, value));
    }

    public bool Remove(TKey key)
    {
      if (!Contains(key))
      {
        return false;
      }

      _map.Remove(key);
      ItemRemoved?.Invoke(this, new KeyValueMapItemRemovedEventArgs<TKey, TValue>(this, key));

      return true;
    }

    public bool Contains(TKey key)
    {
      return _map.ContainsKey(key);
    }

    public bool TryGetItem(TKey key, out TValue value)
    {
      return _map.TryGetValue(key, out value);
    }
  }

}