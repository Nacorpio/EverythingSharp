using System;

using EverythingSharp.Common.Enums;

using Newtonsoft.Json;

namespace EverythingSharp.Common.Templates
{

  public class PawnTemplate : UnitTemplate
  {
    [JsonConstructor]
    internal PawnTemplate(ulong? id) : base(id)
    {
      BirthDate = DateTime.Now;
      Gender = PawnGender.Undefined;
    }

    [JsonProperty("birth_date")]
    public DateTime BirthDate { get; set; }

    [JsonProperty("gender")]
    public PawnGender Gender { get; set; }
  }

}