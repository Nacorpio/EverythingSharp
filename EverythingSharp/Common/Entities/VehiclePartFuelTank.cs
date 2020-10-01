using System;

using EverythingSharp.API.Entities;
using EverythingSharp.Common.Templates;

using UnitsNet;
using UnitsNet.Units;

namespace EverythingSharp.Common.Entities
{

  public class VehiclePartFuelTank : VehiclePart<VehiclePartFuelTankTemplate>, IVehiclePartFuelTank
  {
    public event EventHandler Refilled;
    public event EventHandler Exhausted;

    public VehiclePartFuelTank(ulong id, VehiclePartFuelTankTemplate template) : base(id, template)
    {
    }

    public new VehiclePartFuelTankTemplate Template => base.Template as VehiclePartFuelTankTemplate;
    public double FuelValue { get; private set; }

    public bool IsFull => FuelValue >= Template.Volume;
    public bool IsEmpty => FuelValue.Equals(0d);

    public override void Initialize()
    {
      base.Initialize();
      FuelValue = Template.Volume;
    }

    public void Fill()
    {
      FuelValue = Template.Volume;
    }

    public void Refill(Volume amount)
    {
      var converted = amount.ToUnit(VolumeUnit.Liter).Value;

      if (FuelValue + converted > Template.Volume)
      {
        FuelValue = Template.Volume;
        return;
      }

      FuelValue += converted;
    }

    public void Clear()
    {
      FuelValue = 0d;
    }
  }

}