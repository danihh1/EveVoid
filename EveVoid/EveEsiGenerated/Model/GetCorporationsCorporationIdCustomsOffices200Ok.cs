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
  public class GetCorporationsCorporationIdCustomsOffices200Ok {
    /// <summary>
    /// Only present if alliance access is allowed
    /// </summary>
    /// <value>Only present if alliance access is allowed</value>
    [DataMember(Name="alliance_tax_rate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "alliance_tax_rate")]
    public float? AllianceTaxRate { get; set; }

    /// <summary>
    /// standing_level and any standing related tax rate only present when this is true
    /// </summary>
    /// <value>standing_level and any standing related tax rate only present when this is true</value>
    [DataMember(Name="allow_access_with_standings", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allow_access_with_standings")]
    public bool? AllowAccessWithStandings { get; set; }

    /// <summary>
    /// allow_alliance_access boolean
    /// </summary>
    /// <value>allow_alliance_access boolean</value>
    [DataMember(Name="allow_alliance_access", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allow_alliance_access")]
    public bool? AllowAllianceAccess { get; set; }

    /// <summary>
    /// bad_standing_tax_rate number
    /// </summary>
    /// <value>bad_standing_tax_rate number</value>
    [DataMember(Name="bad_standing_tax_rate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bad_standing_tax_rate")]
    public float? BadStandingTaxRate { get; set; }

    /// <summary>
    /// corporation_tax_rate number
    /// </summary>
    /// <value>corporation_tax_rate number</value>
    [DataMember(Name="corporation_tax_rate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "corporation_tax_rate")]
    public float? CorporationTaxRate { get; set; }

    /// <summary>
    /// Tax rate for entities with excellent level of standing, only present if this level is allowed, same for all other standing related tax rates
    /// </summary>
    /// <value>Tax rate for entities with excellent level of standing, only present if this level is allowed, same for all other standing related tax rates</value>
    [DataMember(Name="excellent_standing_tax_rate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "excellent_standing_tax_rate")]
    public float? ExcellentStandingTaxRate { get; set; }

    /// <summary>
    /// good_standing_tax_rate number
    /// </summary>
    /// <value>good_standing_tax_rate number</value>
    [DataMember(Name="good_standing_tax_rate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "good_standing_tax_rate")]
    public float? GoodStandingTaxRate { get; set; }

    /// <summary>
    /// neutral_standing_tax_rate number
    /// </summary>
    /// <value>neutral_standing_tax_rate number</value>
    [DataMember(Name="neutral_standing_tax_rate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "neutral_standing_tax_rate")]
    public float? NeutralStandingTaxRate { get; set; }

    /// <summary>
    /// unique ID of this customs office
    /// </summary>
    /// <value>unique ID of this customs office</value>
    [DataMember(Name="office_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "office_id")]
    public long? OfficeId { get; set; }

    /// <summary>
    /// reinforce_exit_end integer
    /// </summary>
    /// <value>reinforce_exit_end integer</value>
    [DataMember(Name="reinforce_exit_end", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reinforce_exit_end")]
    public int? ReinforceExitEnd { get; set; }

    /// <summary>
    /// Together with reinforce_exit_end, marks a 2-hour period where this customs office could exit reinforcement mode during the day after initial attack
    /// </summary>
    /// <value>Together with reinforce_exit_end, marks a 2-hour period where this customs office could exit reinforcement mode during the day after initial attack</value>
    [DataMember(Name="reinforce_exit_start", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reinforce_exit_start")]
    public int? ReinforceExitStart { get; set; }

    /// <summary>
    /// Access is allowed only for entities with this level of standing or better
    /// </summary>
    /// <value>Access is allowed only for entities with this level of standing or better</value>
    [DataMember(Name="standing_level", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "standing_level")]
    public string StandingLevel { get; set; }

    /// <summary>
    /// ID of the solar system this customs office is located in
    /// </summary>
    /// <value>ID of the solar system this customs office is located in</value>
    [DataMember(Name="system_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "system_id")]
    public int? SystemId { get; set; }

    /// <summary>
    /// terrible_standing_tax_rate number
    /// </summary>
    /// <value>terrible_standing_tax_rate number</value>
    [DataMember(Name="terrible_standing_tax_rate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "terrible_standing_tax_rate")]
    public float? TerribleStandingTaxRate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCorporationsCorporationIdCustomsOffices200Ok {\n");
      sb.Append("  AllianceTaxRate: ").Append(AllianceTaxRate).Append("\n");
      sb.Append("  AllowAccessWithStandings: ").Append(AllowAccessWithStandings).Append("\n");
      sb.Append("  AllowAllianceAccess: ").Append(AllowAllianceAccess).Append("\n");
      sb.Append("  BadStandingTaxRate: ").Append(BadStandingTaxRate).Append("\n");
      sb.Append("  CorporationTaxRate: ").Append(CorporationTaxRate).Append("\n");
      sb.Append("  ExcellentStandingTaxRate: ").Append(ExcellentStandingTaxRate).Append("\n");
      sb.Append("  GoodStandingTaxRate: ").Append(GoodStandingTaxRate).Append("\n");
      sb.Append("  NeutralStandingTaxRate: ").Append(NeutralStandingTaxRate).Append("\n");
      sb.Append("  OfficeId: ").Append(OfficeId).Append("\n");
      sb.Append("  ReinforceExitEnd: ").Append(ReinforceExitEnd).Append("\n");
      sb.Append("  ReinforceExitStart: ").Append(ReinforceExitStart).Append("\n");
      sb.Append("  StandingLevel: ").Append(StandingLevel).Append("\n");
      sb.Append("  SystemId: ").Append(SystemId).Append("\n");
      sb.Append("  TerribleStandingTaxRate: ").Append(TerribleStandingTaxRate).Append("\n");
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
