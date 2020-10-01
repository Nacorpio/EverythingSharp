using Newtonsoft.Json;

using UnitsNet;

namespace EverythingSharp.Common.Templates
{
  /// <summary>
  /// Represents the base class for all item templates.
  /// </summary>
  public class ItemTemplateBase : TemplateBase
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="ItemTemplateBase"/> class.
    /// </summary>
    /// <param name="id">The unique identifier.</param>
    internal ItemTemplateBase(ulong? id) : base(id)
    {
    }

    /// <summary>
    /// Gets or sets the mass of the <see cref="ItemTemplateBase"/>.
    /// </summary>
    [JsonProperty("mass")]
    public Mass Mass { get; set; }

    /// <summary>
    /// Gets or sets the volume of the <see cref="ItemTemplateBase"/>.
    /// </summary>
    [JsonProperty("volume")]
    public Volume Volume { get; set; }
  }

}