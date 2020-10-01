using System;

using EverythingSharp.API.Collections;

using JetBrains.Annotations;

namespace EverythingSharp.Common.Events
{

  public class KeyValueMapEventArgs<TKey, TValue> : EventArgs
  {
    public KeyValueMapEventArgs([NotNull] IKeyValueMap<TKey, TValue> map)
    {
      Map = map;
    }

    public IKeyValueMap<TKey, TValue> Map { get; }
  }

}