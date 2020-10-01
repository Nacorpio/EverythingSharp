using System.Collections.Generic;

using EverythingSharp.API.Traits;

namespace EverythingSharp.API.Data
{

  /// <summary>
  /// Defines functionality for a reference to a pair inside of a <see cref="IDictionary{TKey,TValue}"/>.
  /// </summary>
  /// <typeparam name="TKey">The key type.</typeparam>
  /// <typeparam name="TValue">The value type.</typeparam>
  public interface IDictionaryPairRef<TKey, TValue> : IRemovable
  {
    /// <summary>
    /// Gets the key of the pair being referred to.
    /// </summary>
    TKey Key { get; }


    /// <summary>
    /// Gets the parent dictionary.
    /// </summary>
    IDictionary<TKey, TValue> Dictionary { get; }

    /// <summary>
    /// Gets the pair that the object is referring to.
    /// </summary>
    KeyValuePair<TKey, TValue> Pair { get; }


    /// <summary>
    /// Returns a value indicating whether the pair exists in the parent dictionary.
    /// </summary>
    /// <returns><c>true</c> if the pair exists; otherwise, <c>false</c>.</returns>
    bool Exists();

    /// <summary>
    /// Removes the pair from the parent dictionary.
    /// </summary>
    /// <returns><c>true</c> if the pair was removed; otherwise, <c>false</c>.</returns>
    bool Remove();
  }

}