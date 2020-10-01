using EverythingSharp.API.Entities;
using EverythingSharp.Common.Templates;

using UnitsNet;

namespace EverythingSharp.Common.Entities
{

  public class Item<TTemplate> : Item, IItem<TTemplate>
    where TTemplate : ItemTemplateBase
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="Item{TTemplate}"/> class.
    /// </summary>
    /// <param name="id">The unique identifier.</param>
    /// <param name="template">The template to use.</param>
    internal Item(ulong id, TTemplate template) : base(id, template)
    {
      Template = template;
    }

    /// <summary>
    /// Gets the template of the <see cref="Item{TTemplate}"/>.
    /// </summary>
    public new TTemplate Template { get; }

    /// <summary>
    /// Gets the density (p = m/V) of the <see cref="Item{TTemplate}"/>.
    /// </summary>
    public Density Density => Template.Mass / Template.Volume;
  }

  public class Item : Entity, IItem
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="Item"/> class.
    /// </summary>
    /// <param name="id">The unique identifier.</param>
    /// <param name="templateBase">The template to use.</param>
    internal Item(ulong id, ItemTemplateBase templateBase) : base(id)
    {
      TemplateBase = templateBase;
    }

    /// <summary>
    /// Gets the template of the <see cref="Item"/>.
    /// </summary>
    public ItemTemplateBase TemplateBase { get; }
  }

}