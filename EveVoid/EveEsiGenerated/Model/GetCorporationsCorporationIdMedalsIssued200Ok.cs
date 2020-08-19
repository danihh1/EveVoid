using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 200 ok object
  /// </summary>
  [DataContract]
  public class GetCorporationsCorporationIdMedalsIssued200Ok {
    /// <summary>
    /// ID of the character who was rewarded this medal
    /// </summary>
    /// <value>ID of the character who was rewarded this medal</value>
    [DataMember(Name="character_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "character_id")]
    public int? CharacterId { get; set; }

    /// <summary>
    /// issued_at string
    /// </summary>
    /// <value>issued_at string</value>
    [DataMember(Name="issued_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issued_at")]
    public DateTime? IssuedAt { get; set; }

    /// <summary>
    /// ID of the character who issued the medal
    /// </summary>
    /// <value>ID of the character who issued the medal</value>
    [DataMember(Name="issuer_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issuer_id")]
    public int? IssuerId { get; set; }

    /// <summary>
    /// medal_id integer
    /// </summary>
    /// <value>medal_id integer</value>
    [DataMember(Name="medal_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "medal_id")]
    public int? MedalId { get; set; }

    /// <summary>
    /// reason string
    /// </summary>
    /// <value>reason string</value>
    [DataMember(Name="reason", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reason")]
    public string Reason { get; set; }

    /// <summary>
    /// status string
    /// </summary>
    /// <value>status string</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCorporationsCorporationIdMedalsIssued200Ok {\n");
      sb.Append("  CharacterId: ").Append(CharacterId).Append("\n");
      sb.Append("  IssuedAt: ").Append(IssuedAt).Append("\n");
      sb.Append("  IssuerId: ").Append(IssuerId).Append("\n");
      sb.Append("  MedalId: ").Append(MedalId).Append("\n");
      sb.Append("  Reason: ").Append(Reason).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
