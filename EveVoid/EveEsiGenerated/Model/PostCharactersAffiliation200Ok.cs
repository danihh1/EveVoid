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
  public class PostCharactersAffiliation200Ok {
    /// <summary>
    /// The character's alliance ID, if their corporation is in an alliance
    /// </summary>
    /// <value>The character's alliance ID, if their corporation is in an alliance</value>
    [DataMember(Name="alliance_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "alliance_id")]
    public int? AllianceId { get; set; }

    /// <summary>
    /// The character's ID
    /// </summary>
    /// <value>The character's ID</value>
    [DataMember(Name="character_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "character_id")]
    public int? CharacterId { get; set; }

    /// <summary>
    /// The character's corporation ID
    /// </summary>
    /// <value>The character's corporation ID</value>
    [DataMember(Name="corporation_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "corporation_id")]
    public int? CorporationId { get; set; }

    /// <summary>
    /// The character's faction ID, if their corporation is in a faction
    /// </summary>
    /// <value>The character's faction ID, if their corporation is in a faction</value>
    [DataMember(Name="faction_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "faction_id")]
    public int? FactionId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PostCharactersAffiliation200Ok {\n");
      sb.Append("  AllianceId: ").Append(AllianceId).Append("\n");
      sb.Append("  CharacterId: ").Append(CharacterId).Append("\n");
      sb.Append("  CorporationId: ").Append(CorporationId).Append("\n");
      sb.Append("  FactionId: ").Append(FactionId).Append("\n");
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
