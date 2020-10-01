using System.Collections.Generic;

namespace EverythingSharp.API.Data
{

  /// <summary>
  /// Defines functionality for a reference to a <see cref="T"/> item inside a list.
  /// </summary>
  /// <typeparam name="T">The item type.</typeparam>
  public interface IListItemRef<T>
  {
    /// <summary>
    /// Gets the zero-based index of the item being referred to.
    /// </summary>
    int Index { get; }


    /// <summary>
    /// Gets the parent list.
    /// </summary>
    IList<T> List { get; }

    /// <summary>
    /// Gets the item that the object is referring to.
    /// </summary>
    T Item { get; }


    /// <summary>
    /// Returns a value indicating whether the item exists in the parent list.
    /// </summary>
    /// <returns><c>true</c> if the item exists; otherwise, <c>false</c>.</returns>
    bool Exists();

    /// <summary>
    /// Removes the item from the parent list.
    /// </summary>
    /// <returns><c>true</c> if the item was removed; otherwise, <c>false</c>.</returns>
    bool Remove();
  }

}