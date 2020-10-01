using System;

using EverythingSharp.API.Templates;
using EverythingSharp.API.Traits;

namespace EverythingSharp.API.Entities
{

  public interface IUnit<out TTemplate> : IUnit, ITemplated <TTemplate>
    where TTemplate : ITemplate
  {
  }

  public interface IUnit : IEntity
  {
    event EventHandler FireStateChanged;
    event EventHandler HealthChanged;

    event EventHandler Died;

    int Health { get; }
    int MaxHealth { get; }

    void SetAlive(bool value = true);
    void SetOnFire(bool value = true);

    bool IsDead();
    bool IsAlive();

    bool IsOnFire();
  }

}