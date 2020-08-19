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
  public class GetFwSystems200Ok {
    /// <summary>
    /// contested string
    /// </summary>
    /// <value>contested string</value>
    [DataMember(Name="contested", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contested")]
    public string Contested { get; set; }

    /// <summary>
    /// occupier_faction_id integer
    /// </summary>
    /// <value>occupier_faction_id integer</value>
    [DataMember(Name="occupier_faction_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "occupier_faction_id")]
    public int? OccupierFactionId { get; set; }

    /// <summary>
    /// owner_faction_id integer
    /// </summary>
    /// <value>owner_faction_id integer</value>
    [DataMember(Name="owner_faction_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "owner_faction_id")]
    public int? OwnerFactionId { get; set; }

    /// <summary>
    /// solar_system_id integer
    /// </summary>
    /// <value>solar_system_id integer</value>
    [DataMember(Name="solar_system_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "solar_system_id")]
    public int? SolarSystemId { get; set; }

    /// <summary>
    /// victory_points integer
    /// </summary>
    /// <value>victory_points integer</value>
    [DataMember(Name="victory_points", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "victory_points")]
    public int? VictoryPoints { get; set; }

    /// <summary>
    /// victory_points_threshold integer
    /// </summary>
    /// <value>victory_points_threshold integer</value>
    [DataMember(Name="victory_points_threshold", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "victory_points_threshold")]
    public int? VictoryPointsThreshold { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetFwSystems200Ok {\n");
      sb.Append("  Contested: ").Append(Contested).Append("\n");
      sb.Append("  OccupierFactionId: ").Append(OccupierFactionId).Append("\n");
      sb.Append("  OwnerFactionId: ").Append(OwnerFactionId).Append("\n");
      sb.Append("  SolarSystemId: ").Append(SolarSystemId).Append("\n");
      sb.Append("  VictoryPoints: ").Append(VictoryPoints).Append("\n");
      sb.Append("  VictoryPointsThreshold: ").Append(VictoryPointsThreshold).Append("\n");
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
