using EverythingSharp.API.Templates;

using JetBrains.Annotations;

namespace EverythingSharp.API.Builders
{
  /// <summary>
  /// Defines functionality for an object that builds objects of type <see cref="TOutput"/>.
  /// </summary>
  /// <typeparam name="TOutput">The output type.</typeparam>
  /// <typeparam name="TInput">The input type.</typeparam>
  public interface IBuilder<out TOutput, in TInput>
  {
    /// <summary>
    /// Builds an object of type <see cref="TOutput"/> using the specified <see cref="TInput"/>.
    /// </summary>
    /// <param name="template">The template to use.</param>
    /// <param name="input">The input.</param>
    /// <returns>The output, if successfully built; otherwise, <c>null</c>.</returns>
    TOutput Build<TTemplate>([NotNull] TTemplate template, TInput input)
      where TTemplate : ITemplate;
  }

}