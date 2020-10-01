namespace EverythingSharp.API.Traits
{

  /// <summary>
  /// Defines functionality for an object that can be removed.
  /// </summary>
  public interface IRemovable
  {
    /// <summary>
    /// Removes the object.
    /// </summary>
    /// <returns><c>true</c> if the object was removed; otherwise, <c>false</c>.</returns>
    bool Remove();
  }

}