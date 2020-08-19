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
  public class GetCharactersCharacterIdFleetOk {
    /// <summary>
    /// The character's current fleet ID
    /// </summary>
    /// <value>The character's current fleet ID</value>
    [DataMember(Name="fleet_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fleet_id")]
    public long? FleetId { get; set; }

    /// <summary>
    /// Member’s role in fleet
    /// </summary>
    /// <value>Member’s role in fleet</value>
    [DataMember(Name="role", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "role")]
    public string Role { get; set; }

    /// <summary>
    /// ID of the squad the member is in. If not applicable, will be set to -1
    /// </summary>
    /// <value>ID of the squad the member is in. If not applicable, will be set to -1</value>
    [DataMember(Name="squad_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "squad_id")]
    public long? SquadId { get; set; }

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
      sb.Append("class GetCharactersCharacterIdFleetOk {\n");
      sb.Append("  FleetId: ").Append(FleetId).Append("\n");
      sb.Append("  Role: ").Append(Role).Append("\n");
      sb.Append("  SquadId: ").Append(SquadId).Append("\n");
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
