using EverythingSharp.API.Entities;

namespace EverythingSharp.Common.Builders
{

  public abstract class EntityBuilderBase<TEntity> : BuilderBase<TEntity, ulong>
    where TEntity : IEntity
  {
  }

}