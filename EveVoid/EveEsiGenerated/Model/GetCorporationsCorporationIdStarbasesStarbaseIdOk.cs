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
  public class GetCorporationsCorporationIdStarbasesStarbaseIdOk {
    /// <summary>
    /// allow_alliance_members boolean
    /// </summary>
    /// <value>allow_alliance_members boolean</value>
    [DataMember(Name="allow_alliance_members", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allow_alliance_members")]
    public bool? AllowAllianceMembers { get; set; }

    /// <summary>
    /// allow_corporation_members boolean
    /// </summary>
    /// <value>allow_corporation_members boolean</value>
    [DataMember(Name="allow_corporation_members", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allow_corporation_members")]
    public bool? AllowCorporationMembers { get; set; }

    /// <summary>
    /// Who can anchor starbase (POS) and its structures
    /// </summary>
    /// <value>Who can anchor starbase (POS) and its structures</value>
    [DataMember(Name="anchor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "anchor")]
    public string Anchor { get; set; }

    /// <summary>
    /// attack_if_at_war boolean
    /// </summary>
    /// <value>attack_if_at_war boolean</value>
    [DataMember(Name="attack_if_at_war", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attack_if_at_war")]
    public bool? AttackIfAtWar { get; set; }

    /// <summary>
    /// attack_if_other_security_status_dropping boolean
    /// </summary>
    /// <value>attack_if_other_security_status_dropping boolean</value>
    [DataMember(Name="attack_if_other_security_status_dropping", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attack_if_other_security_status_dropping")]
    public bool? AttackIfOtherSecurityStatusDropping { get; set; }

    /// <summary>
    /// Starbase (POS) will attack if target's security standing is lower than this value
    /// </summary>
    /// <value>Starbase (POS) will attack if target's security standing is lower than this value</value>
    [DataMember(Name="attack_security_status_threshold", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attack_security_status_threshold")]
    public float? AttackSecurityStatusThreshold { get; set; }

    /// <summary>
    /// Starbase (POS) will attack if target's standing is lower than this value
    /// </summary>
    /// <value>Starbase (POS) will attack if target's standing is lower than this value</value>
    [DataMember(Name="attack_standing_threshold", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attack_standing_threshold")]
    public float? AttackStandingThreshold { get; set; }

    /// <summary>
    /// Who can take fuel blocks out of the starbase (POS)'s fuel bay
    /// </summary>
    /// <value>Who can take fuel blocks out of the starbase (POS)'s fuel bay</value>
    [DataMember(Name="fuel_bay_take", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fuel_bay_take")]
    public string FuelBayTake { get; set; }

    /// <summary>
    /// Who can view the starbase (POS)'s fule bay. Characters either need to have required role or belong to the starbase (POS) owner's corporation or alliance, as described by the enum, all other access settings follows the same scheme
    /// </summary>
    /// <value>Who can view the starbase (POS)'s fule bay. Characters either need to have required role or belong to the starbase (POS) owner's corporation or alliance, as described by the enum, all other access settings follows the same scheme</value>
    [DataMember(Name="fuel_bay_view", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fuel_bay_view")]
    public string FuelBayView { get; set; }

    /// <summary>
    /// Fuel blocks and other things that will be consumed when operating a starbase (POS)
    /// </summary>
    /// <value>Fuel blocks and other things that will be consumed when operating a starbase (POS)</value>
    [DataMember(Name="fuels", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fuels")]
    public List<GetCorporationsCorporationIdStarbasesStarbaseIdFuel> Fuels { get; set; }

    /// <summary>
    /// Who can offline starbase (POS) and its structures
    /// </summary>
    /// <value>Who can offline starbase (POS) and its structures</value>
    [DataMember(Name="offline", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offline")]
    public string Offline { get; set; }

    /// <summary>
    /// Who can online starbase (POS) and its structures
    /// </summary>
    /// <value>Who can online starbase (POS) and its structures</value>
    [DataMember(Name="online", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "online")]
    public string Online { get; set; }

    /// <summary>
    /// Who can unanchor starbase (POS) and its structures
    /// </summary>
    /// <value>Who can unanchor starbase (POS) and its structures</value>
    [DataMember(Name="unanchor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unanchor")]
    public string Unanchor { get; set; }

    /// <summary>
    /// True if the starbase (POS) is using alliance standings, otherwise using corporation's
    /// </summary>
    /// <value>True if the starbase (POS) is using alliance standings, otherwise using corporation's</value>
    [DataMember(Name="use_alliance_standings", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "use_alliance_standings")]
    public bool? UseAllianceStandings { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCorporationsCorporationIdStarbasesStarbaseIdOk {\n");
      sb.Append("  AllowAllianceMembers: ").Append(AllowAllianceMembers).Append("\n");
      sb.Append("  AllowCorporationMembers: ").Append(AllowCorporationMembers).Append("\n");
      sb.Append("  Anchor: ").Append(Anchor).Append("\n");
      sb.Append("  AttackIfAtWar: ").Append(AttackIfAtWar).Append("\n");
      sb.Append("  AttackIfOtherSecurityStatusDropping: ").Append(AttackIfOtherSecurityStatusDropping).Append("\n");
      sb.Append("  AttackSecurityStatusThreshold: ").Append(AttackSecurityStatusThreshold).Append("\n");
      sb.Append("  AttackStandingThreshold: ").Append(AttackStandingThreshold).Append("\n");
      sb.Append("  FuelBayTake: ").Append(FuelBayTake).Append("\n");
      sb.Append("  FuelBayView: ").Append(FuelBayView).Append("\n");
      sb.Append("  Fuels: ").Append(Fuels).Append("\n");
      sb.Append("  Offline: ").Append(Offline).Append("\n");
      sb.Append("  Online: ").Append(Online).Append("\n");
      sb.Append("  Unanchor: ").Append(Unanchor).Append("\n");
      sb.Append("  UseAllianceStandings: ").Append(UseAllianceStandings).Append("\n");
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
