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
  public class GetFwStats200Ok {
    /// <summary>
    /// faction_id integer
    /// </summary>
    /// <value>faction_id integer</value>
    [DataMember(Name="faction_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "faction_id")]
    public int? FactionId { get; set; }

    /// <summary>
    /// Gets or Sets Kills
    /// </summary>
    [DataMember(Name="kills", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kills")]
    public GetFwStatsKills Kills { get; set; }

    /// <summary>
    /// How many pilots fight for the given faction
    /// </summary>
    /// <value>How many pilots fight for the given faction</value>
    [DataMember(Name="pilots", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pilots")]
    public int? Pilots { get; set; }

    /// <summary>
    /// The number of solar systems controlled by the given faction
    /// </summary>
    /// <value>The number of solar systems controlled by the given faction</value>
    [DataMember(Name="systems_controlled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "systems_controlled")]
    public int? SystemsControlled { get; set; }

    /// <summary>
    /// Gets or Sets VictoryPoints
    /// </summary>
    [DataMember(Name="victory_points", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "victory_points")]
    public GetFwStatsVictoryPoints VictoryPoints { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetFwStats200Ok {\n");
      sb.Append("  FactionId: ").Append(FactionId).Append("\n");
      sb.Append("  Kills: ").Append(Kills).Append("\n");
      sb.Append("  Pilots: ").Append(Pilots).Append("\n");
      sb.Append("  SystemsControlled: ").Append(SystemsControlled).Append("\n");
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
