using System.Collections.Generic;

using EverythingSharp.API.Templates;
using EverythingSharp.API.Traits;
using EverythingSharp.Common.Collections;
using EverythingSharp.Common.Enums;

using JetBrains.Annotations;

namespace EverythingSharp.API.Entities
{

  public interface IVehicle<out TTemplate> : IVehicle, ITemplated<TTemplate>
    where TTemplate : ITemplate
  {
  }

  public interface IVehicle : IUnit
  {
    IEnumerable <IPawn> Occupants { get; }
    VehiclePartMap Parts { get; }

    bool IsEngineRunning();
    bool IsDriving();

    void StartEngine();
    void StopEngine();

    void EnterVehicle([NotNull] IPawn pawn, VehicleSeatIndex seatIndex, bool @override = false);
  }

}