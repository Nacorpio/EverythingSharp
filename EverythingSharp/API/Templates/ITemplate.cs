using Newtonsoft.Json;

namespace EverythingSharp.API.Templates
{

  public interface ITemplate
  {
    [JsonProperty("id", Required = Required.AllowNull)]
    ulong? Id { get; }


    [JsonProperty("name", Required = Required.AllowNull)]
    string Name { get; }

    [JsonProperty("display_name", Required = Required.AllowNull)]
    string DisplayName { get; }

    [JsonProperty("summary", Required = Required.AllowNull)]
    string Summary { get; }
  }

}