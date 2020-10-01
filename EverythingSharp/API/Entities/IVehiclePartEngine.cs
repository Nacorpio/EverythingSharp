using System;

namespace EverythingSharp.API.Entities
{

  /// <summary>
  /// Defines functionality for a part that is a vehicle engine.
  /// </summary>
  public interface IVehiclePartEngine : IVehiclePart
  {
    /// <summary>
    /// Raised when the engine has started.
    /// </summary>
    event EventHandler Started;

    /// <summary>
    /// Raised when the engine has stopped.
    /// </summary>
    event EventHandler Stopped;


    /// <summary>
    /// Returns a value indicating whether the engine is functional.
    /// </summary>
    /// <returns><c>true</c> if the engine is functional; otherwise, <c>false</c>.</returns>
    bool IsFunctional();

    /// <summary>
    /// Returns a value indicating whether the engine is running.
    /// </summary>
    /// <returns><c>true</c> if the engine is running; otherwise, <c>false</c>.</returns>
    bool IsRunning();


    /// <summary>
    /// Starts the engine.
    /// </summary>
    void Start();

    /// <summary>
    /// Stops the engine.
    /// </summary>
    void Stop();
  }

}