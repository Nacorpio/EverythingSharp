using System;

using EverythingSharp.API.Entities;

namespace EverythingSharp.Common.Factories
{

  /// <summary>
  /// Represents the base class for all entity factories.
  /// </summary>
  /// <typeparam name="TEntity">The type of entity to build.</typeparam>
  public abstract class EntityFactoryBase<TEntity> : FactoryBase<TEntity, ulong>
    where TEntity : IEntity
  {
    /// <summary>
    /// Builds an object of type <see cref="TEntity"/> using the specified unique identifier.
    /// </summary>
    /// <typeparam name="TBuilder">The builder type.</typeparam>
    /// <typeparam name="TTemplate">The template type.</typeparam>
    /// <param name="template">The template to use.</param>
    /// <param name="id">The id.</param>
    /// <param name="act">The builder function.</param>
    /// <returns>The output, if successfully built; otherwise, <c>null</c>.</returns>
    public override TEntity Build<TTemplate, TBuilder>(TTemplate template, ulong id, Action<TBuilder> act = null)
    {
      var builder = new TBuilder();
      act?.Invoke(builder);

      var build = builder.Build(template, id);
      build.Initialize();

      return build;
    }
  }

}