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
  public class GetCharactersCharacterIdSkillsOk {
    /// <summary>
    /// skills array
    /// </summary>
    /// <value>skills array</value>
    [DataMember(Name="skills", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "skills")]
    public List<GetCharactersCharacterIdSkillsSkill> Skills { get; set; }

    /// <summary>
    /// total_sp integer
    /// </summary>
    /// <value>total_sp integer</value>
    [DataMember(Name="total_sp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total_sp")]
    public long? TotalSp { get; set; }

    /// <summary>
    /// Skill points available to be assigned
    /// </summary>
    /// <value>Skill points available to be assigned</value>
    [DataMember(Name="unallocated_sp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unallocated_sp")]
    public int? UnallocatedSp { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCharactersCharacterIdSkillsOk {\n");
      sb.Append("  Skills: ").Append(Skills).Append("\n");
      sb.Append("  TotalSp: ").Append(TotalSp).Append("\n");
      sb.Append("  UnallocatedSp: ").Append(UnallocatedSp).Append("\n");
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
