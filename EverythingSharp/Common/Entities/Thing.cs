using EverythingSharp.API.Templates;
using EverythingSharp.Common.Templates;

namespace EverythingSharp.Common.Entities
{
  public abstract class Thing<TTemplate> : Entity
    where TTemplate : ThingTemplate, IUnitTemplate
  {
    protected Thing(ulong id, TTemplate template) : base(id)
    {
      Template = template;
    }

    public TTemplate Template { get; }
  }

  public abstract class Thing : Thing<ThingTemplate>
  {
    protected Thing(ulong id, ThingTemplate template) : base(id, template)
    {
    }
  }

}