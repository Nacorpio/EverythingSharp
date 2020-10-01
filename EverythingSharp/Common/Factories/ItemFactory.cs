using System;
using EverythingSharp.API.Entities;
using EverythingSharp.Common.Templates;

namespace EverythingSharp.Common.Factories
{

  public class ItemFactory : EntityFactoryBase<IItem>
  {
    /// <summary>
    /// Builds an object of type <see cref="IItem"/> using the specified unique identifier.
    /// </summary>
    /// <typeparam name="TBuilder">The builder type.</typeparam>
    /// <typeparam name="TTemplate">The template type.</typeparam>
    /// <param name="template">The template to use.</param>
    /// <param name="id">The id.</param>
    /// <param name="act">The builder function.</param>
    /// <returns>The output, if successfully built; otherwise, <c>null</c>.</returns>
    public override IItem Build <TTemplate, TBuilder>(TTemplate template, ulong id, Action <TBuilder> act = null)
    {
      var _ = base.Build(template, id, act);

      // Build the item depending on its template.
      switch (template)
      {
        case ConsumableItemTemplateBase _ :
        {
          // The item is consumable.
          break;
        }
      }

      return _;
    }
  }

}