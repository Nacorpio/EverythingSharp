using EverythingSharp.API.Entities;

namespace EverythingSharp.Common.Entities
{

  public abstract class Entity : IEntity
  {
    protected Entity(ulong id)
    {
      Id = id;
    }

    public ulong Id { get; }

    public virtual void Initialize()
    {
    }

    public virtual void Delete()
    {
    }
  }

}