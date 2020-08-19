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
  public class GetFleetsFleetIdMembers200Ok {
    /// <summary>
    /// character_id integer
    /// </summary>
    /// <value>character_id integer</value>
    [DataMember(Name="character_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "character_id")]
    public int? CharacterId { get; set; }

    /// <summary>
    /// join_time string
    /// </summary>
    /// <value>join_time string</value>
    [DataMember(Name="join_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "join_time")]
    public DateTime? JoinTime { get; set; }

    /// <summary>
    /// Member’s role in fleet
    /// </summary>
    /// <value>Member’s role in fleet</value>
    [DataMember(Name="role", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "role")]
    public string Role { get; set; }

    /// <summary>
    /// Localized role names
    /// </summary>
    /// <value>Localized role names</value>
    [DataMember(Name="role_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "role_name")]
    public string RoleName { get; set; }

    /// <summary>
    /// ship_type_id integer
    /// </summary>
    /// <value>ship_type_id integer</value>
    [DataMember(Name="ship_type_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ship_type_id")]
    public int? ShipTypeId { get; set; }

    /// <summary>
    /// Solar system the member is located in
    /// </summary>
    /// <value>Solar system the member is located in</value>
    [DataMember(Name="solar_system_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "solar_system_id")]
    public int? SolarSystemId { get; set; }

    /// <summary>
    /// ID of the squad the member is in. If not applicable, will be set to -1
    /// </summary>
    /// <value>ID of the squad the member is in. If not applicable, will be set to -1</value>
    [DataMember(Name="squad_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "squad_id")]
    public long? SquadId { get; set; }

    /// <summary>
    /// Station in which the member is docked in, if applicable
    /// </summary>
    /// <value>Station in which the member is docked in, if applicable</value>
    [DataMember(Name="station_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "station_id")]
    public long? StationId { get; set; }

    /// <summary>
    /// Whether the member take fleet warps
    /// </summary>
    /// <value>Whether the member take fleet warps</value>
    [DataMember(Name="takes_fleet_warp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "takes_fleet_warp")]
    public bool? TakesFleetWarp { get; set; }

    /// <summary>
    /// ID of the wing the member is in. If not applicable, will be set to -1
    /// </summary>
    /// <value>ID of the wing the member is in. If not applicable, will be set to -1</value>
    [DataMember(Name="wing_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "wing_id")]
    public long? WingId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetFleetsFleetIdMembers200Ok {\n");
      sb.Append("  CharacterId: ").Append(CharacterId).Append("\n");
      sb.Append("  JoinTime: ").Append(JoinTime).Append("\n");
      sb.Append("  Role: ").Append(Role).Append("\n");
      sb.Append("  RoleName: ").Append(RoleName).Append("\n");
      sb.Append("  ShipTypeId: ").Append(ShipTypeId).Append("\n");
      sb.Append("  SolarSystemId: ").Append(SolarSystemId).Append("\n");
      sb.Append("  SquadId: ").Append(SquadId).Append("\n");
      sb.Append("  StationId: ").Append(StationId).Append("\n");
      sb.Append("  TakesFleetWarp: ").Append(TakesFleetWarp).Append("\n");
      sb.Append("  WingId: ").Append(WingId).Append("\n");
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
