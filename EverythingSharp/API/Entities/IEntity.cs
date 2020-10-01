using EverythingSharp.API.Traits;

namespace EverythingSharp.API.Entities
{

  public interface IEntity : IDeletable
  {
    ulong Id { get; }
    void Initialize();
  }

}