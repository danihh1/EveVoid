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
  public class GetCharactersCharacterIdFwStatsOk {
    /// <summary>
    /// The given character's current faction rank
    /// </summary>
    /// <value>The given character's current faction rank</value>
    [DataMember(Name="current_rank", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "current_rank")]
    public int? CurrentRank { get; set; }

    /// <summary>
    /// The enlistment date of the given character into faction warfare. Will not be included if character is not enlisted in faction warfare
    /// </summary>
    /// <value>The enlistment date of the given character into faction warfare. Will not be included if character is not enlisted in faction warfare</value>
    [DataMember(Name="enlisted_on", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enlisted_on")]
    public DateTime? EnlistedOn { get; set; }

    /// <summary>
    /// The faction the given character is enlisted to fight for. Will not be included if character is not enlisted in faction warfare
    /// </summary>
    /// <value>The faction the given character is enlisted to fight for. Will not be included if character is not enlisted in faction warfare</value>
    [DataMember(Name="faction_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "faction_id")]
    public int? FactionId { get; set; }

    /// <summary>
    /// The given character's highest faction rank achieved
    /// </summary>
    /// <value>The given character's highest faction rank achieved</value>
    [DataMember(Name="highest_rank", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "highest_rank")]
    public int? HighestRank { get; set; }

    /// <summary>
    /// Gets or Sets Kills
    /// </summary>
    [DataMember(Name="kills", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kills")]
    public GetCharactersCharacterIdFwStatsKills Kills { get; set; }

    /// <summary>
    /// Gets or Sets VictoryPoints
    /// </summary>
    [DataMember(Name="victory_points", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "victory_points")]
    public GetCharactersCharacterIdFwStatsVictoryPoints VictoryPoints { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCharactersCharacterIdFwStatsOk {\n");
      sb.Append("  CurrentRank: ").Append(CurrentRank).Append("\n");
      sb.Append("  EnlistedOn: ").Append(EnlistedOn).Append("\n");
      sb.Append("  FactionId: ").Append(FactionId).Append("\n");
      sb.Append("  HighestRank: ").Append(HighestRank).Append("\n");
      sb.Append("  Kills: ").Append(Kills).Append("\n");
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
