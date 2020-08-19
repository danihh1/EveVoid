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
  public class GetCharactersCharacterIdSkillqueue200Ok {
    /// <summary>
    /// Date on which training of the skill will complete. Omitted if the skill queue is paused.
    /// </summary>
    /// <value>Date on which training of the skill will complete. Omitted if the skill queue is paused.</value>
    [DataMember(Name="finish_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "finish_date")]
    public DateTime? FinishDate { get; set; }

    /// <summary>
    /// finished_level integer
    /// </summary>
    /// <value>finished_level integer</value>
    [DataMember(Name="finished_level", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "finished_level")]
    public int? FinishedLevel { get; set; }

    /// <summary>
    /// level_end_sp integer
    /// </summary>
    /// <value>level_end_sp integer</value>
    [DataMember(Name="level_end_sp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "level_end_sp")]
    public int? LevelEndSp { get; set; }

    /// <summary>
    /// Amount of SP that was in the skill when it started training it's current level. Used to calculate % of current level complete.
    /// </summary>
    /// <value>Amount of SP that was in the skill when it started training it's current level. Used to calculate % of current level complete.</value>
    [DataMember(Name="level_start_sp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "level_start_sp")]
    public int? LevelStartSp { get; set; }

    /// <summary>
    /// queue_position integer
    /// </summary>
    /// <value>queue_position integer</value>
    [DataMember(Name="queue_position", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "queue_position")]
    public int? QueuePosition { get; set; }

    /// <summary>
    /// skill_id integer
    /// </summary>
    /// <value>skill_id integer</value>
    [DataMember(Name="skill_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "skill_id")]
    public int? SkillId { get; set; }

    /// <summary>
    /// start_date string
    /// </summary>
    /// <value>start_date string</value>
    [DataMember(Name="start_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "start_date")]
    public DateTime? StartDate { get; set; }

    /// <summary>
    /// training_start_sp integer
    /// </summary>
    /// <value>training_start_sp integer</value>
    [DataMember(Name="training_start_sp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "training_start_sp")]
    public int? TrainingStartSp { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCharactersCharacterIdSkillqueue200Ok {\n");
      sb.Append("  FinishDate: ").Append(FinishDate).Append("\n");
      sb.Append("  FinishedLevel: ").Append(FinishedLevel).Append("\n");
      sb.Append("  LevelEndSp: ").Append(LevelEndSp).Append("\n");
      sb.Append("  LevelStartSp: ").Append(LevelStartSp).Append("\n");
      sb.Append("  QueuePosition: ").Append(QueuePosition).Append("\n");
      sb.Append("  SkillId: ").Append(SkillId).Append("\n");
      sb.Append("  StartDate: ").Append(StartDate).Append("\n");
      sb.Append("  TrainingStartSp: ").Append(TrainingStartSp).Append("\n");
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
