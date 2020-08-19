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
  public class GetUniverseSystemKills200Ok {
    /// <summary>
    /// Number of NPC ships killed in this system
    /// </summary>
    /// <value>Number of NPC ships killed in this system</value>
    [DataMember(Name="npc_kills", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "npc_kills")]
    public int? NpcKills { get; set; }

    /// <summary>
    /// Number of pods killed in this system
    /// </summary>
    /// <value>Number of pods killed in this system</value>
    [DataMember(Name="pod_kills", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pod_kills")]
    public int? PodKills { get; set; }

    /// <summary>
    /// Number of player ships killed in this system
    /// </summary>
    /// <value>Number of player ships killed in this system</value>
    [DataMember(Name="ship_kills", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ship_kills")]
    public int? ShipKills { get; set; }

    /// <summary>
    /// system_id integer
    /// </summary>
    /// <value>system_id integer</value>
    [DataMember(Name="system_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "system_id")]
    public int? SystemId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetUniverseSystemKills200Ok {\n");
      sb.Append("  NpcKills: ").Append(NpcKills).Append("\n");
      sb.Append("  PodKills: ").Append(PodKills).Append("\n");
      sb.Append("  ShipKills: ").Append(ShipKills).Append("\n");
      sb.Append("  SystemId: ").Append(SystemId).Append("\n");
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
