using System;

using EverythingSharp.API.Factories;
using EverythingSharp.API.Templates;
using EverythingSharp.Common.Builders;

using JetBrains.Annotations;

namespace EverythingSharp.Common.Factories
{
  /// <summary>
  /// Represents the base class for all factories.
  /// </summary>
  /// <typeparam name="TOutput">The output type.</typeparam>
  /// <typeparam name="TInput">The id type.</typeparam>
  public abstract class FactoryBase<TOutput, TInput> : IFactory<TOutput, TInput>
  {
    /// <summary>
    /// Builds an object of type <see cref="TOutput"/> using the specified id.
    /// </summary>
    /// <typeparam name="TBuilder">The builder type.</typeparam>
    /// <typeparam name="TTemplate">The template type.</typeparam>
    /// <param name="template">The template to use.</param>
    /// <param name="id">The id.</param>
    /// <param name="act">The builder function.</param>
    /// <returns>The output, if successfully built; otherwise, <c>null</c>.</returns>
    public virtual TOutput Build<TTemplate, TBuilder>([NotNull] TTemplate template, TInput id, [CanBeNull] Action<TBuilder> act = null)
      where TBuilder : BuilderBase<TOutput, TInput>, new()
      where TTemplate : ITemplate
    {
      var builder = new TBuilder();
      var result = builder.Build(template, id);

      act?.Invoke(builder);

      return result;
    }
  }

}