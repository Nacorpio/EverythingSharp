using EverythingSharp.API.Collections;

using JetBrains.Annotations;

namespace EverythingSharp.Common.Events
{

  public class KeyValueMapItemAddedEventArgs<TKey, TValue> : KeyValueMapEventArgs<TKey, TValue>
  {
    public KeyValueMapItemAddedEventArgs
    (
      [NotNull] IKeyValueMap<TKey, TValue> map,
      [NotNull] TKey key,
      [CanBeNull] TValue value) : base(
      map
    )
    {
      Key = key;
      Value = value;
    }

    public TKey Key { get; }
    public TValue Value { get; }
  }

}