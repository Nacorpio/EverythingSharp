using System;

using EverythingSharp.API.Entities;
using EverythingSharp.Common.Templates;

namespace EverythingSharp.Common.Entities
{
  public class VehiclePartEngine : VehiclePart<VehiclePartEngineTemplate>, IVehiclePartEngine
  {
    public event EventHandler Started;
    public event EventHandler Stopped;

    private bool _isRunning;

    internal VehiclePartEngine(ulong id, VehiclePartTemplate template)
      : base(id, template as VehiclePartEngineTemplate)
    {
      _isRunning = false;
    }

    public virtual bool IsFunctional() => true;
    public bool IsRunning() => _isRunning;

    public void Start()
    {
      if (!IsEnabled || _isRunning)
      {
        return;
      }

      _isRunning = true;
      OnStarted();
    }

    public void Stop()
    {
      if (!_isRunning)
      {
        return;
      }

      _isRunning = false;
      OnStopped();
    }

    protected virtual void OnStarted()
    {
      Started?.Invoke(this, EventArgs.Empty);
    }

    protected virtual void OnStopped()
    {
      Stopped?.Invoke(this, EventArgs.Empty);
    }
  }

}