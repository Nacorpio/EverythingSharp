using EverythingSharp.API.Data;

namespace EverythingSharp.Common.Data
{

  public static class Maybe
  {
    /// <summary>
    /// Creates a new <see cref="Maybe{T}"/> instance using the specified value.
    /// </summary>
    /// <typeparam name="T">The value type.</typeparam>
    /// <param name="value">The value of the maybe.</param>
    /// <returns>The new maybe instance.</returns>
    public static Maybe<T> New<T>(T value = default)
    {
      return new Maybe<T>(value);
    }
  }

  public readonly struct Maybe<T> : IMaybe<T>
  {
    /// <summary>
    /// Gets the default representation of <see cref="Maybe{T}"/>.
    /// </summary>
    public static Maybe<T> Default => new Maybe<T>();

    /// <summary>
    /// Initializes a new instance of the <see cref="Maybe{T}"/> structure.
    /// </summary>
    /// <param name="value">The value.</param>
    public Maybe(T value = default) : this()
    {
      Value = value;
    }


    /// <summary>
    /// Gets the value of the object.
    /// </summary>
    public T Value { get; }

    /// <summary>
    /// Gets a value indicating whether the object has a value.
    /// </summary>
    public bool HasValue => !Value.Equals(default);


    /// <summary>
    /// Returns the value of the object, if available, or returns the fallback value.
    /// </summary>
    /// <param name="fallback">The fallback value.</param>
    /// <returns>The resulting value.</returns>
    public T GetValueOrDefault(T fallback = default)
    {
      return HasValue ? Value : fallback;
    }


    public static implicit operator T(Maybe<T> _)
    {
      return _.GetValueOrDefault();
    }

    public static implicit operator Maybe<T>(T _)
    {
      return new Maybe<T>(_);
    }
  }

}