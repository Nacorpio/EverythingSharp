using EverythingSharp.API.Builders;
using EverythingSharp.API.Templates;

namespace EverythingSharp.Common.Builders
{
  /// <summary>
  /// Represents the base class for all builders.
  /// </summary>
  /// <typeparam name="TOutput">The output type.</typeparam>
  /// <typeparam name="TInput">The input type.</typeparam>
  public abstract class BuilderBase<TOutput, TInput> : IBuilder<TOutput, TInput>
  {
    /// <summary>
    /// Builds an object of type <see cref="TOutput"/> using the specified <see cref="TInput"/> and template.
    /// </summary>
    /// <param name="template">The template to use.</param>
    /// <param name="input">The input.</param>
    /// <returns>The output, if successfully built; otherwise, <c>null</c>.</returns>
    public abstract TOutput Build<TTemplate>(TTemplate template, TInput input)
      where TTemplate : ITemplate;
  }

}