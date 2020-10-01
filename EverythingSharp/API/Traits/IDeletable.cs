namespace EverythingSharp.API.Traits
{
  /// <summary>
  /// Defines functionality for an object that can be deleted.
  /// </summary>
  public interface IDeletable
  {
    /// <summary>
    /// Deletes the object.
    /// </summary>
    void Delete();
  }

}