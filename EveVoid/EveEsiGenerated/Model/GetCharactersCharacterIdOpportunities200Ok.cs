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
  public class GetCharactersCharacterIdOpportunities200Ok {
    /// <summary>
    /// completed_at string
    /// </summary>
    /// <value>completed_at string</value>
    [DataMember(Name="completed_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "completed_at")]
    public DateTime? CompletedAt { get; set; }

    /// <summary>
    /// task_id integer
    /// </summary>
    /// <value>task_id integer</value>
    [DataMember(Name="task_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "task_id")]
    public int? TaskId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCharactersCharacterIdOpportunities200Ok {\n");
      sb.Append("  CompletedAt: ").Append(CompletedAt).Append("\n");
      sb.Append("  TaskId: ").Append(TaskId).Append("\n");
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
