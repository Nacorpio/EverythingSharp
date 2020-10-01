using Newtonsoft.Json;

namespace EverythingSharp.API.Templates
{

  public interface IUnitTemplate : IThingTemplate
  {
    [JsonProperty("max_health")]
    float MaxHealth { get; set; }
  }

}