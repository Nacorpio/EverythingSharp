using EverythingSharp.API.Templates;
using EverythingSharp.API.Traits;

namespace EverythingSharp.API.Entities
{

  public interface IPawn <out TTemplate> : IPawn, ITemplated <TTemplate>
    where TTemplate : ITemplate
  {
  }

  /// <summary>
  /// Defines functionality for an object that is a pawn (or person).
  /// </summary>
  public interface IPawn : IUnit
  {
    /// <summary>
    /// Kills the <see cref="IPawn"/>.
    /// </summary>
    void Kill();

    /// <summary>
    /// Revives the <see cref="IPawn"/>.
    /// </summary>
    /// <param name="health">The new health value.</param>
    void Revive(int? health = null);


    /// <summary>
    /// Makes the <see cref="IPawn"/> use the specified item.
    /// </summary>
    /// <param name="item">The item to use.</param>
    void Use(IItem item);
  }

}