using EverythingSharp.API.Collections;

using JetBrains.Annotations;

namespace EverythingSharp.Common.Events
{

  public class KeyValueMapItemRemovedEventArgs<TKey, TValue> : KeyValueMapEventArgs<TKey, TValue>
  {
    public KeyValueMapItemRemovedEventArgs([NotNull] IKeyValueMap<TKey, TValue> map, [NotNull] TKey key) : base(map)
    {
      Key = key;
    }

    public TKey Key { get; }
  }

}