using System;

using EverythingSharp.API.Templates;
using EverythingSharp.API.Traits;
using EverythingSharp.Common.Collections;
using EverythingSharp.Common.Templates;

namespace EverythingSharp.API.Entities
{
  public interface IVehiclePart<out TTemplate> : IVehiclePart, ITemplated<TTemplate>
    where TTemplate : ITemplate
  {
  }

  public interface IVehiclePart : IEntity
  {
    event EventHandler <IVehicle> Installed;
    event EventHandler <IVehicle> Uninstalled;

    VehiclePartMap Map { get; }
    VehiclePartTemplate Template { get; }

    int Health { get; }

    bool IsEnabled { get; }
    bool IsBroken { get; }

    void SetEnabled(bool value);
    void SetHealth(int newValue);
  }

}