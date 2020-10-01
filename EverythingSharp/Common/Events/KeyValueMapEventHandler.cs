namespace EverythingSharp.Common.Events
{

  public delegate void KeyValueMapEventHandler<TKey, TValue>
    (object sender, KeyValueMapEventArgs<TKey, TValue> eventArgs);

  public delegate void KeyValueMapItemAddedEventHandler<TKey, TValue>
    (object sender, KeyValueMapItemAddedEventArgs<TKey, TValue> eventArgs);

  public delegate void KeyValueMapItemRemovedEventHandler<TKey, TValue>
    (object sender, KeyValueMapItemRemovedEventArgs<TKey, TValue> eventArgs);

  public delegate void KeyValueMapItemModifiedEventHandler<TKey, TValue>
    (object sender, KeyValueMapItemModifiedEventArgs<TKey, TValue> eventArgs);

}