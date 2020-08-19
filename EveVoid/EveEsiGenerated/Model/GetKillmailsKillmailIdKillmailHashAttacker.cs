using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// attacker object
  /// </summary>
  [DataContract]
  public class GetKillmailsKillmailIdKillmailHashAttacker {
    /// <summary>
    /// alliance_id integer
    /// </summary>
    /// <value>alliance_id integer</value>
    [DataMember(Name="alliance_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "alliance_id")]
    public int? AllianceId { get; set; }

    /// <summary>
    /// character_id integer
    /// </summary>
    /// <value>character_id integer</value>
    [DataMember(Name="character_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "character_id")]
    public int? CharacterId { get; set; }

    /// <summary>
    /// corporation_id integer
    /// </summary>
    /// <value>corporation_id integer</value>
    [DataMember(Name="corporation_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "corporation_id")]
    public int? CorporationId { get; set; }

    /// <summary>
    /// damage_done integer
    /// </summary>
    /// <value>damage_done integer</value>
    [DataMember(Name="damage_done", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "damage_done")]
    public int? DamageDone { get; set; }

    /// <summary>
    /// faction_id integer
    /// </summary>
    /// <value>faction_id integer</value>
    [DataMember(Name="faction_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "faction_id")]
    public int? FactionId { get; set; }

    /// <summary>
    /// Was the attacker the one to achieve the final blow 
    /// </summary>
    /// <value>Was the attacker the one to achieve the final blow </value>
    [DataMember(Name="final_blow", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "final_blow")]
    public bool? FinalBlow { get; set; }

    /// <summary>
    /// Security status for the attacker 
    /// </summary>
    /// <value>Security status for the attacker </value>
    [DataMember(Name="security_status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "security_status")]
    public float? SecurityStatus { get; set; }

    /// <summary>
    /// What ship was the attacker flying 
    /// </summary>
    /// <value>What ship was the attacker flying </value>
    [DataMember(Name="ship_type_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ship_type_id")]
    public int? ShipTypeId { get; set; }

    /// <summary>
    /// What weapon was used by the attacker for the kill 
    /// </summary>
    /// <value>What weapon was used by the attacker for the kill </value>
    [DataMember(Name="weapon_type_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "weapon_type_id")]
    public int? WeaponTypeId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetKillmailsKillmailIdKillmailHashAttacker {\n");
      sb.Append("  AllianceId: ").Append(AllianceId).Append("\n");
      sb.Append("  CharacterId: ").Append(CharacterId).Append("\n");
      sb.Append("  CorporationId: ").Append(CorporationId).Append("\n");
      sb.Append("  DamageDone: ").Append(DamageDone).Append("\n");
      sb.Append("  FactionId: ").Append(FactionId).Append("\n");
      sb.Append("  FinalBlow: ").Append(FinalBlow).Append("\n");
      sb.Append("  SecurityStatus: ").Append(SecurityStatus).Append("\n");
      sb.Append("  ShipTypeId: ").Append(ShipTypeId).Append("\n");
      sb.Append("  WeaponTypeId: ").Append(WeaponTypeId).Append("\n");
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
