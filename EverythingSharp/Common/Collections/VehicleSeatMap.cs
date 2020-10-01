using System.Collections.Generic;
using System.Linq;

using EverythingSharp.API.Entities;
using EverythingSharp.Common.Entities;
using EverythingSharp.Common.Enums;

namespace EverythingSharp.Common.Collections
{

  public class VehicleSeatMap
  {
    private readonly List<IVehicleSeat> _seats;

    public VehicleSeatMap(int passengerSeatCount = 4)
    {
      _seats = new List<IVehicleSeat>();

      // The driver seat is always index 0.
      AddSeat(VehicleSeatIndex.Driver);

      for (var i = 0; i < passengerSeatCount; ++i)
      {
        AddSeat(VehicleSeatIndex.Passenger);
      }
    }

    public int SeatCount => _seats.Count;
    public int PassengerSeatCount => _seats.Count(x => x.Index.Equals(VehicleSeatIndex.Passenger));


    public IPawn Driver => GetSeat(
      VehicleSeatIndex.Driver
    ) is VehicleSeat seat
      ? seat.Occupant
      : null;


    public IEnumerable<IPawn> Passengers => _seats.Where(
        x => x.Index.Equals(
          VehicleSeatIndex.Passenger
        )
      )
     .Select(
        x => x.Occupant
      );

    public IEnumerable <IPawn> Occupants => _seats.Where(
        x => x.IsOccupied()
      )
     .Select(
        x => x.Occupant
      );


    internal void AddSeat(VehicleSeatIndex seatIndex)
    {
      if (HasSeat(seatIndex))
      {
        return;
      }

      _seats.Add(new VehicleSeat((ulong)_seats.Count, seatIndex));
    }

    internal IVehicleSeat GetSeat(VehicleSeatIndex seatIndex)
    {
      return HasSeat(seatIndex) ? _seats.FirstOrDefault(x => x.Index.Equals(seatIndex)) : null;
    }

    internal bool HasSeat(VehicleSeatIndex seatIndex)
    {
      return _seats.Any(x => x.Index.Equals(seatIndex));
    }

    public void SetOccupant(VehicleSeatIndex seatIndex, IPawn pawn, bool @override = false)
    {
      if (!(GetSeat(seatIndex) is VehicleSeat seat))
      {
        return;
      }

      if ((seat.Occupant == null || !@override) && seat.Occupant != null)
      {
        return;
      }

      seat.Occupy(pawn);
    }

    public IPawn GetOccupant(VehicleSeatIndex seatIndex)
    {
      if (!(GetSeat(seatIndex) is VehicleSeat seat))
      {
        return null;
      }

      return seat.Occupant;
    }

    public bool HasOccupant(IPawn pawn, VehicleSeatIndex seatIndex)
    {
      return GetSeat(
          seatIndex
        ) is VehicleSeat seat
        && seat.IsOccupied()
        && seat.Occupant.Id.Equals(
          pawn.Id
        );
    }

    public bool HasOccupant(IPawn pawn)
    {
      return _seats.Any(x => x.Occupant.Id.Equals(pawn.Id));
    }

    public bool IsOccupied(VehicleSeatIndex seatIndex)
    {
      return GetSeat(seatIndex) is VehicleSeat seat && seat.IsOccupied();
    }
  }

}