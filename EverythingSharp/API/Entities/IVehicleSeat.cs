using EverythingSharp.Common.Enums;

using JetBrains.Annotations;

namespace EverythingSharp.API.Entities
{

  public interface IVehicleSeat : IEntity
  {
    VehicleSeatIndex Index { get; }
    IPawn Occupant { get; }

    bool IsOccupied();

    void Occupy([NotNull] IPawn pawn);
  }

}