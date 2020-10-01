using EverythingSharp.API.Templates;

namespace EverythingSharp.API.Entities
{

  public interface IConsumableItem<out TTemplate> : IItem<TTemplate>
    where TTemplate : ITemplate
  {
    void Consume(IPawn pawn);
  }

}