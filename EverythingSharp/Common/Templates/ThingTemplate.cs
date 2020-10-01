using EverythingSharp.API.Templates;
using Newtonsoft.Json;

namespace EverythingSharp.Common.Templates
{

  public class ThingTemplate : TemplateBase, IUnitTemplate
  {
    [JsonConstructor]
    internal ThingTemplate(ulong? id) : base(id)
    {
      Mass = 0d;
      MaxHealth = 0f;
    }

    [JsonProperty("mass")]
    public double Mass { get; set; }

    [JsonProperty("max_health")]
    public float MaxHealth { get; set; }
  }

}