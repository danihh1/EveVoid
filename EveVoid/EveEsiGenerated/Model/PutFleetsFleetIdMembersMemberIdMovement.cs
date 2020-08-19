using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// movement object
  /// </summary>
  [DataContract]
  public class PutFleetsFleetIdMembersMemberIdMovement {
    /// <summary>
    /// If a character is moved to the `fleet_commander` role, neither `wing_id` or `squad_id` should be specified. If a character is moved to the `wing_commander` role, only `wing_id` should be specified. If a character is moved to the `squad_commander` role, both `wing_id` and `squad_id` should be specified. If a character is moved to the `squad_member` role, both `wing_id` and `squad_id` should be specified.
    /// </summary>
    /// <value>If a character is moved to the `fleet_commander` role, neither `wing_id` or `squad_id` should be specified. If a character is moved to the `wing_commander` role, only `wing_id` should be specified. If a character is moved to the `squad_commander` role, both `wing_id` and `squad_id` should be specified. If a character is moved to the `squad_member` role, both `wing_id` and `squad_id` should be specified.</value>
    [DataMember(Name="role", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "role")]
    public string Role { get; set; }

    /// <summary>
    /// squad_id integer
    /// </summary>
    /// <value>squad_id integer</value>
    [DataMember(Name="squad_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "squad_id")]
    public long? SquadId { get; set; }

    /// <summary>
    /// wing_id integer
    /// </summary>
    /// <value>wing_id integer</value>
    [DataMember(Name="wing_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "wing_id")]
    public long? WingId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PutFleetsFleetIdMembersMemberIdMovement {\n");
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
