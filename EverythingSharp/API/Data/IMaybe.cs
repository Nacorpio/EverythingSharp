namespace EverythingSharp.API.Data
{

  /// <summary>
  /// Defines functionality for an object that *might* be available.
  /// </summary>
  /// <typeparam name="T">The object type.</typeparam>
  public interface IMaybe<T>
  {
    /// <summary>
    /// Gets the value of the object.
    /// </summary>
    T Value { get; }

    /// <summary>
    /// Gets a value indicating whether the object has a value.
    /// </summary>
    bool HasValue { get; }


    /// <summary>
    /// Returns the value of the object, if available, or returns the fallback value.
    /// </summary>
    /// <param name="fallback">The fallback value.</param>
    /// <returns>The resulting value.</returns>
    T GetValueOrDefault(T fallback = default);
  }

}