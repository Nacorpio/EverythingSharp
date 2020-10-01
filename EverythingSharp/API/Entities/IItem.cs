using EverythingSharp.API.Traits;
using EverythingSharp.Common.Templates;

namespace EverythingSharp.API.Entities
{

  public interface IItem<out TTemplate> : IItem, ITemplated<TTemplate>
    where TTemplate : ItemTemplateBase
  {
  }

  public interface IItem : IEntity
  {
  }

}