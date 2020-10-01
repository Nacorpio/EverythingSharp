using System;

using EverythingSharp.API.Templates;
using EverythingSharp.Common.Builders;

namespace EverythingSharp.API.Factories
{
  /// <summary>
  /// Defines functionality for a factory that builds objects of type <see cref="TInput"/> using a builder.
  /// </summary>
  /// <typeparam name="TOutput">The output type.</typeparam>
  /// <typeparam name="TInput">The id type.</typeparam>
  public interface IFactory<TOutput, TInput>
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
    TOutput Build<TTemplate, TBuilder>(TTemplate template, TInput id, Action<TBuilder> act = null)
      where TTemplate : ITemplate
      where TBuilder : BuilderBase<TOutput, TInput>, new();
  }

}