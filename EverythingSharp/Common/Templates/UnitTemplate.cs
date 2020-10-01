using Newtonsoft.Json;

namespace EverythingSharp.Common.Templates
{

  public class UnitTemplate : ThingTemplate
  {
    [JsonConstructor]
    internal UnitTemplate(ulong? id) : base(id)
    {
    }
  }

}