using EverythingSharp.API.Entities;
using EverythingSharp.Common.Enums;

namespace EverythingSharp.Common.Entities
{

  public class VehicleSeat : IVehicleSeat
  {
    public VehicleSeat(ulong id, VehicleSeatIndex index)
    {
      Id = id;
      Index = index;
    }

    public ulong Id { get; }

    public VehicleSeatIndex Index { get; }
    public IPawn Occupant { get; private set; }


    public bool IsOccupied()
    {
      return Occupant != null;
    }


    public void Occupy(IPawn pawn)
    {
      Occupant = pawn;
    }


    public virtual void Initialize()
    {
    }

    public virtual void Delete()
    {
    }
  }

}