using System.Collections.Generic;
using System.Linq;

using EverythingSharp.API.Entities;
using EverythingSharp.Common.Entities;
using EverythingSharp.Common.Templates;

using JetBrains.Annotations;

namespace EverythingSharp.Common.Collections
{

  /// <summary>
  /// Represents a mapped collection of vehicle parts.
  /// </summary>
  public class VehiclePartMap
  {
    private readonly Dictionary<ulong, IVehiclePart> _parts;

    /// <summary>
    /// Initializes a new instance of the <see cref="VehiclePartMap"/> class.
    /// </summary>
    public VehiclePartMap()
    {
      _parts = new Dictionary<ulong, IVehiclePart>();
    }

    /// <summary>
    /// Gets a collection of all vehicle parts contained in the <see cref="VehiclePartMap"/>.
    /// </summary>
    public IEnumerable<IVehiclePart> Parts => _parts.Values;


    /// <summary>
    /// Returns the vehicle engine part.
    /// </summary>
    /// <returns>The vehicle engine part.</returns>
    public IVehiclePartEngine GetEngine() => GetPart <VehiclePartEngineTemplate>() as IVehiclePartEngine;


    /// <summary>
    /// Adds the specified collection of vehicle parts to the <see cref="VehiclePartMap"/>.
    /// </summary>
    /// <param name="collection">The collection of vehicle parts to add.</param>
    public void AddParts([NotNull] IEnumerable<IVehiclePart> collection)
    {
      foreach (var part in collection)
      {
        AddPart((VehiclePart)part);
      }
    }

    /// <summary>
    /// Adds the specified vehicle part to the <see cref="VehiclePartMap"/>.
    /// </summary>
    /// <param name="vehiclePart">The vehicle part to add.</param>
    public void AddPart([NotNull] IVehiclePart vehiclePart)
    {
      if (HasPart(vehiclePart) || !(vehiclePart is VehiclePart part))
      {
        return;
      }

      _parts.Add(vehiclePart.Id, part);
      part.Map = this;
    }

    /// <summary>
    /// Returns a value indicating whether the <see cref="VehiclePartMap"/> has the specified vehicle part.
    /// </summary>
    /// <param name="vehiclePart">The vehicle part to find.</param>
    /// <returns><c>true</c> if the vehicle part was found; otherwise, <c>false</c>.</returns>
    public bool HasPart([NotNull] IVehiclePart vehiclePart)
    {
      return _parts.ContainsKey(vehiclePart.Id);
    }

    /// <summary>
    /// Returns a value indicating whether the <see cref="VehiclePartMap"/> contains at least one vehicle part with the specified template.
    /// </summary>
    /// <typeparam name="TTemplate">The template type.</typeparam>
    /// <param name="template">The template of the entity to find.</param>
    /// <returns><c>true</c> if a vehicle part was found; otherwise, <c>false</c>.</returns>
    public bool HasPart<TTemplate>([NotNull] TTemplate template)
      where TTemplate : VehiclePartTemplate
    {
      return _parts.Any(x => x.Value.Template.Id.Equals(template.Id));
    }

    /// <summary>
    /// Returns the first vehicle part with the specified template.
    /// </summary>
    /// <typeparam name="TTemplate">The template type.</typeparam>
    /// <returns>The vehicle part, if found; otherwise, <c>null</c>.</returns>
    public IVehiclePart GetPart<TTemplate>()
      where TTemplate : VehiclePartTemplate
    {
      return GetParts<TTemplate>().FirstOrDefault();
    }

    /// <summary>
    /// Returns a collection of vehicle parts with the specified template.
    /// </summary>
    /// <typeparam name="TTemplate">The template type.</typeparam>
    /// <returns>A collection of vehicle parts.</returns>
    public IEnumerable<IVehiclePart> GetParts<TTemplate>()
      where TTemplate : VehiclePartTemplate
    {
      return _parts
       .Where(x => x.Value.Template.GetType() == typeof(TTemplate))
       .Select(x => x.Value);
    }
  }

}