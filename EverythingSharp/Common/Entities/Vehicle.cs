using System.Collections.Generic;

using EverythingSharp.API.Entities;
using EverythingSharp.Common.Collections;
using EverythingSharp.Common.Enums;
using EverythingSharp.Common.Templates;

namespace EverythingSharp.Common.Entities
{
  public class Vehicle<TTemplate> : Unit<TTemplate>, IVehicle
    where TTemplate : UnitTemplate
  {
    private bool _isEngineRunning;

    public Vehicle(ulong id, TTemplate template) : base(id, template)
    {
      Seats = new VehicleSeatMap();
      Parts = new VehiclePartMap();
    }

    public VehicleSeatMap Seats { get; }
    public VehiclePartMap Parts { get; }

    public IEnumerable<IPawn> Occupants => Seats.Occupants;

    public bool IsEngineRunning() => _isEngineRunning;
    public bool IsDriving() => throw new System.NotImplementedException();

    public void StartEngine()
    {
      if (IsEngineRunning())
      {
        return;
      }

      _isEngineRunning = true;
    }

    public void StopEngine()
    {
      if (!IsEngineRunning())
      {
        return;
      }

      _isEngineRunning = false;
    }

    public void EnterVehicle(IPawn pawn, VehicleSeatIndex seatIndex, bool @override = false)
    {
      if (!(Seats.GetSeat(seatIndex) is VehicleSeat seat))
      {
        return;
      }

      if (@override && seat.IsOccupied())
      {
        seat.Occupy(pawn);
      }
      else if (seat.IsOccupied())
      {
        seat.Occupy(pawn);
      }
    }
  }

}