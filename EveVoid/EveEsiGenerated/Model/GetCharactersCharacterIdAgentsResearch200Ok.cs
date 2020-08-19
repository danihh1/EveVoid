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
  public class GetCharactersCharacterIdAgentsResearch200Ok {
    /// <summary>
    /// agent_id integer
    /// </summary>
    /// <value>agent_id integer</value>
    [DataMember(Name="agent_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "agent_id")]
    public int? AgentId { get; set; }

    /// <summary>
    /// points_per_day number
    /// </summary>
    /// <value>points_per_day number</value>
    [DataMember(Name="points_per_day", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "points_per_day")]
    public float? PointsPerDay { get; set; }

    /// <summary>
    /// remainder_points number
    /// </summary>
    /// <value>remainder_points number</value>
    [DataMember(Name="remainder_points", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "remainder_points")]
    public float? RemainderPoints { get; set; }

    /// <summary>
    /// skill_type_id integer
    /// </summary>
    /// <value>skill_type_id integer</value>
    [DataMember(Name="skill_type_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "skill_type_id")]
    public int? SkillTypeId { get; set; }

    /// <summary>
    /// started_at string
    /// </summary>
    /// <value>started_at string</value>
    [DataMember(Name="started_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "started_at")]
    public DateTime? StartedAt { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCharactersCharacterIdAgentsResearch200Ok {\n");
      sb.Append("  AgentId: ").Append(AgentId).Append("\n");
      sb.Append("  PointsPerDay: ").Append(PointsPerDay).Append("\n");
      sb.Append("  RemainderPoints: ").Append(RemainderPoints).Append("\n");
      sb.Append("  SkillTypeId: ").Append(SkillTypeId).Append("\n");
      sb.Append("  StartedAt: ").Append(StartedAt).Append("\n");
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
