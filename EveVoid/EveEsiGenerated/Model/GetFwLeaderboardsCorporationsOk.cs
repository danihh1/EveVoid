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
  public class GetFwLeaderboardsCorporationsOk {
    /// <summary>
    /// Gets or Sets Kills
    /// </summary>
    [DataMember(Name="kills", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kills")]
    public GetFwLeaderboardsCorporationsKills Kills { get; set; }

    /// <summary>
    /// Gets or Sets VictoryPoints
    /// </summary>
    [DataMember(Name="victory_points", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "victory_points")]
    public GetFwLeaderboardsCorporationsVictoryPoints VictoryPoints { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetFwLeaderboardsCorporationsOk {\n");
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
