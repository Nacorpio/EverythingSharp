using Newtonsoft.Json;

using UnitsNet;

namespace EverythingSharp.Common.Templates
{
  /// <summary>
  /// Represents the base class for all vehicle part templates.
  /// </summary>
  public class VehiclePartTemplate : TemplateBase
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="VehiclePartTemplate"/> class.
    /// </summary>
    /// <param name="id">The unique identifier.</param>
    [JsonConstructor]
    internal VehiclePartTemplate(ulong? id) : base(id)
    {
    }

    /// <summary>
    /// Gets or sets the maximum health value of the <see cref="VehiclePartTemplate"/>.
    /// </summary>
    [JsonProperty("max_health")]
    public int MaxHealth { get; set; }

    /// <summary>
    /// Gets or sets the mass of the <see cref="ItemTemplateBase"/>.
    /// </summary>
    [JsonProperty("mass")]
    public Mass Mass { get; set; }
  }

}