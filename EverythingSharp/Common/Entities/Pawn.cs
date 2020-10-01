using EverythingSharp.API.Entities;
using EverythingSharp.Common.Templates;

namespace EverythingSharp.Common.Entities
{
  public class Pawn<TTemplate> : Unit<TTemplate>, IPawn
    where TTemplate : PawnTemplate
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="Pawn{TTemplate}"/> class.
    /// </summary>
    /// <param name="id">The unique identifier.</param>
    /// <param name="template">The template to use.</param>
    internal Pawn(ulong id, PawnTemplate template) : base(id, template as TTemplate)
    {
    }

    /// <summary>
    /// Kills the <see cref="Pawn{TTemplate}"/>.
    /// </summary>
    public void Kill()
    {
      SetAlive(false);
    }

    /// <summary>
    /// Revives the <see cref="Pawn{TTemplate}"/>.
    /// </summary>
    /// <param name="health">The new health value.</param>
    public void Revive(int? health = null)
    {
    }

    /// <summary>
    /// Makes the <see cref="Pawn{TTemplate}"/> use the specified item.
    /// </summary>
    /// <param name="item">The item to use.</param>
    public void Use(IItem item)
    {
    }
  }

  public class Pawn : Pawn<PawnTemplate>
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="Pawn{TTemplate}"/> class.
    /// </summary>
    /// <param name="id">The unique identifier.</param>
    /// <param name="template">The template to use.</param>
    internal Pawn(ulong id, PawnTemplate template) : base(id, template)
    {
    }
  }

}