using UnitsNet;

namespace EverythingSharp.API.Data
{

  public interface IStackOf<out T>
  {
    T Item { get; }
    Mass Mass { get; }
  }

}