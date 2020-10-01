using System;

using UnitsNet;

namespace EverythingSharp.API.Entities
{

  public interface IVehiclePartFuelTank : IVehiclePart
  {
    event EventHandler Refilled;
    event EventHandler Exhausted;

    double FuelValue { get; }

    bool IsFull { get; }
    bool IsEmpty { get; }

    void Fill();
    void Refill(Volume amount);

    void Clear();
  }

}