using System;

using EverythingSharp.API.Entities;
using EverythingSharp.API.Traits;
using EverythingSharp.Common.Collections;
using EverythingSharp.Common.Templates;

namespace EverythingSharp.Common.Entities
{

  public class VehiclePart<TTemplate> : VehiclePart, IVehiclePart<TTemplate>, ITemplated<VehiclePartTemplate>
    where TTemplate : TemplateBase
  {
    public VehiclePart(ulong id, TTemplate template) : base(id, template as VehiclePartTemplate)
    {
    }

    public new VehiclePartTemplate Template => (VehiclePartTemplate)base.Template;
    TTemplate ITemplated<TTemplate>.Template => Template as TTemplate;
  }

  public class VehiclePart : Thing, IVehiclePart
  {
    public event EventHandler<IVehicle> Installed;
    public event EventHandler<IVehicle> Uninstalled;

    internal VehiclePart(ulong id, VehiclePartTemplate template) : base(id, template)
    {
      Health = 0;
    }

    public VehiclePartMap Map { get; internal set; }

    public int Health { get; private set; }

    public bool IsEnabled { get; private set; }
    public bool IsBroken => Health == 0;

    public new VehiclePartTemplate Template => base.Template as VehiclePartTemplate;

    public void SetHealth(int newValue)
    {
      Health = newValue;
    }

    public void SetEnabled(bool value)
    {
      IsEnabled = value;
    }

    public override void Initialize()
    {
      base.Initialize();
      Health = Template.MaxHealth;
    }

    protected virtual void OnInstalled(object sender, IVehicle e)
    {
      Installed?.Invoke(sender, e);
    }

    protected virtual void OnUninstalled(object sender, IVehicle e)
    {
      Uninstalled?.Invoke(sender, e);
    }

  }
}