using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// skill object
  /// </summary>
  [DataContract]
  public class GetCharactersCharacterIdSkillsSkill {
    /// <summary>
    /// active_skill_level integer
    /// </summary>
    /// <value>active_skill_level integer</value>
    [DataMember(Name="active_skill_level", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "active_skill_level")]
    public int? ActiveSkillLevel { get; set; }

    /// <summary>
    /// skill_id integer
    /// </summary>
    /// <value>skill_id integer</value>
    [DataMember(Name="skill_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "skill_id")]
    public int? SkillId { get; set; }

    /// <summary>
    /// skillpoints_in_skill integer
    /// </summary>
    /// <value>skillpoints_in_skill integer</value>
    [DataMember(Name="skillpoints_in_skill", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "skillpoints_in_skill")]
    public long? SkillpointsInSkill { get; set; }

    /// <summary>
    /// trained_skill_level integer
    /// </summary>
    /// <value>trained_skill_level integer</value>
    [DataMember(Name="trained_skill_level", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "trained_skill_level")]
    public int? TrainedSkillLevel { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCharactersCharacterIdSkillsSkill {\n");
      sb.Append("  ActiveSkillLevel: ").Append(ActiveSkillLevel).Append("\n");
      sb.Append("  SkillId: ").Append(SkillId).Append("\n");
      sb.Append("  SkillpointsInSkill: ").Append(SkillpointsInSkill).Append("\n");
      sb.Append("  TrainedSkillLevel: ").Append(TrainedSkillLevel).Append("\n");
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
