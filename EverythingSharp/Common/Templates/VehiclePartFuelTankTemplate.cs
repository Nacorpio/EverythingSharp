using Newtonsoft.Json;

namespace EverythingSharp.Common.Templates
{

  public class VehiclePartFuelTankTemplate : VehiclePartTemplate
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="VehiclePartTemplate"/> class.
    /// </summary>
    /// <param name="id">The unique identifier.</param>
    [JsonConstructor]
    internal VehiclePartFuelTankTemplate(ulong? id) : base(id)
    {
    }

    /// <summary>
    /// Gets or sets the volume of the <see cref="VehiclePartFuelTankTemplate"/>, in liters.
    /// </summary>
    [JsonProperty("volume")]
    public double Volume { get; set; }
  }

}