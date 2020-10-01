using EverythingSharp.API.Collections;

using JetBrains.Annotations;

namespace EverythingSharp.Common.Events
{

  public class KeyValueMapItemModifiedEventArgs<TKey, TValue> : KeyValueMapEventArgs<TKey, TValue>
  {
    public KeyValueMapItemModifiedEventArgs
    (
      [NotNull] IKeyValueMap<TKey, TValue> map,
      [NotNull] TKey key,
      [CanBeNull] TValue newValue,
      [CanBeNull] TValue oldValue) : base(
      map
    )
    {
      Key = key;
      NewValue = newValue;
      OldValue = oldValue;
    }

    public TKey Key { get; }

    public TValue NewValue { get; }
    public TValue OldValue { get; }
  }

}