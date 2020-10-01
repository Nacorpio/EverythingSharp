using System;

using EverythingSharp.API.Entities;
using EverythingSharp.Common.Templates;

namespace EverythingSharp.Common.Entities
{
  public abstract class Unit<TTemplate> : Thing<TTemplate>, IUnit<TTemplate>
    where TTemplate : UnitTemplate
  {
    public event EventHandler FireStateChanged;
    public event EventHandler HealthChanged;
    public event EventHandler Died;

    private bool _isAlive;
    private bool _isOnFire;

    protected Unit(ulong id, TTemplate template) : base(id, template)
    {
    }

    public int Health { get; set; }
    public int MaxHealth { get; set; }

    public void SetAlive(bool value = true)
    {
      _isAlive = value;
    }

    public void SetOnFire(bool value = true)
    {
      _isOnFire = value;
    }

    public bool IsAlive()
    {
      return _isAlive;
    }

    public bool IsDead()
    {
      return !IsAlive();
    }

    public bool IsOnFire()
    {
      return _isOnFire;
    }

    protected virtual void OnFireStateChanged()
    {
      FireStateChanged?.Invoke(this, EventArgs.Empty);
    }

    protected virtual void OnHealthChanged()
    {
      HealthChanged?.Invoke(this, EventArgs.Empty);
    }

    protected virtual void OnDied()
    {
      Died?.Invoke(this, EventArgs.Empty);
    }

  }

}