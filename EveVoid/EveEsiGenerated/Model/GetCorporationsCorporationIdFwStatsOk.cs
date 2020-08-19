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
  public class GetCorporationsCorporationIdFwStatsOk {
    /// <summary>
    /// The enlistment date of the given corporation into faction warfare. Will not be included if corporation is not enlisted in faction warfare
    /// </summary>
    /// <value>The enlistment date of the given corporation into faction warfare. Will not be included if corporation is not enlisted in faction warfare</value>
    [DataMember(Name="enlisted_on", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enlisted_on")]
    public DateTime? EnlistedOn { get; set; }

    /// <summary>
    /// The faction the given corporation is enlisted to fight for. Will not be included if corporation is not enlisted in faction warfare
    /// </summary>
    /// <value>The faction the given corporation is enlisted to fight for. Will not be included if corporation is not enlisted in faction warfare</value>
    [DataMember(Name="faction_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "faction_id")]
    public int? FactionId { get; set; }

    /// <summary>
    /// Gets or Sets Kills
    /// </summary>
    [DataMember(Name="kills", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kills")]
    public GetCorporationsCorporationIdFwStatsKills Kills { get; set; }

    /// <summary>
    /// How many pilots the enlisted corporation has. Will not be included if corporation is not enlisted in faction warfare
    /// </summary>
    /// <value>How many pilots the enlisted corporation has. Will not be included if corporation is not enlisted in faction warfare</value>
    [DataMember(Name="pilots", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pilots")]
    public int? Pilots { get; set; }

    /// <summary>
    /// Gets or Sets VictoryPoints
    /// </summary>
    [DataMember(Name="victory_points", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "victory_points")]
    public GetCorporationsCorporationIdFwStatsVictoryPoints VictoryPoints { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCorporationsCorporationIdFwStatsOk {\n");
      sb.Append("  EnlistedOn: ").Append(EnlistedOn).Append("\n");
      sb.Append("  FactionId: ").Append(FactionId).Append("\n");
      sb.Append("  Kills: ").Append(Kills).Append("\n");
      sb.Append("  Pilots: ").Append(Pilots).Append("\n");
      sb.Append("  VictoryPoints: ").Append(VictoryPoints).Append("\n");
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
