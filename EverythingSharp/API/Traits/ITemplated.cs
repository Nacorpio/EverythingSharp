using EverythingSharp.API.Templates;

namespace EverythingSharp.API.Traits
{

  public interface ITemplated<out TTemplate> where TTemplate : ITemplate
  {
    TTemplate Template { get; }
  }

}