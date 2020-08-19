using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// pve object
  /// </summary>
  [DataContract]
  public class GetCharactersCharacterIdStatsPve {
    /// <summary>
    /// dungeons_completed_agent integer
    /// </summary>
    /// <value>dungeons_completed_agent integer</value>
    [DataMember(Name="dungeons_completed_agent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dungeons_completed_agent")]
    public long? DungeonsCompletedAgent { get; set; }

    /// <summary>
    /// dungeons_completed_distribution integer
    /// </summary>
    /// <value>dungeons_completed_distribution integer</value>
    [DataMember(Name="dungeons_completed_distribution", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dungeons_completed_distribution")]
    public long? DungeonsCompletedDistribution { get; set; }

    /// <summary>
    /// missions_succeeded integer
    /// </summary>
    /// <value>missions_succeeded integer</value>
    [DataMember(Name="missions_succeeded", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "missions_succeeded")]
    public long? MissionsSucceeded { get; set; }

    /// <summary>
    /// missions_succeeded_epic_arc integer
    /// </summary>
    /// <value>missions_succeeded_epic_arc integer</value>
    [DataMember(Name="missions_succeeded_epic_arc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "missions_succeeded_epic_arc")]
    public long? MissionsSucceededEpicArc { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCharactersCharacterIdStatsPve {\n");
      sb.Append("  DungeonsCompletedAgent: ").Append(DungeonsCompletedAgent).Append("\n");
      sb.Append("  DungeonsCompletedDistribution: ").Append(DungeonsCompletedDistribution).Append("\n");
      sb.Append("  MissionsSucceeded: ").Append(MissionsSucceeded).Append("\n");
      sb.Append("  MissionsSucceededEpicArc: ").Append(MissionsSucceededEpicArc).Append("\n");
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
