using EverythingSharp.API.Data;

using UnitsNet;

namespace EverythingSharp.Common.Data
{

  public readonly struct PhysicalStackOf<T> : IStackOf<T>
  {
    public PhysicalStackOf(T item, Mass mass)
    {
      Item = item;
      Mass = mass;
    }

    public T Item { get; }
    public Mass Mass { get; }
  }

}