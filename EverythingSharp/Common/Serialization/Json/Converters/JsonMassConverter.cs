﻿using System;

using Newtonsoft.Json;

using UnitsNet;

namespace EverythingSharp.Common.Serialization.Json.Converters
{

  public class JsonMassConverter : JsonConverter<Mass>
  {
    /// <summary>Writes the JSON representation of the object.</summary>
    /// <param name="writer">The <see cref="T:Newtonsoft.Json.JsonWriter" /> to write to.</param>
    /// <param name="value">The value.</param>
    /// <param name="serializer">The calling serializer.</param>
    public override void WriteJson(JsonWriter writer, Mass value, JsonSerializer serializer)
    {
      writer.WriteValue(value.ToString());
    }

    /// <summary>Reads the JSON representation of the object.</summary>
    /// <param name="reader">The <see cref="T:Newtonsoft.Json.JsonReader" /> to read from.</param>
    /// <param name="objectType">Type of the object.</param>
    /// <param name="existingValue">The existing value of object being read. If there is no existing value then <c>null</c> will be used.</param>
    /// <param name="hasExistingValue">The existing value has a value.</param>
    /// <param name="serializer">The calling serializer.</param>
    /// <returns>The object value.</returns>
    public override Mass ReadJson(JsonReader reader, Type objectType, Mass existingValue, bool hasExistingValue, JsonSerializer serializer)
    {
      return reader.ReadAsString() is { } value ? Mass.Parse(value) : default;
    }
  }

}