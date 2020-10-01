using Newtonsoft.Json;

namespace EverythingSharp.API.Templates
{

  public interface IThingTemplate : ITemplate
  {
    [JsonProperty("mass")]
    double Mass { get; set; }
  }

}