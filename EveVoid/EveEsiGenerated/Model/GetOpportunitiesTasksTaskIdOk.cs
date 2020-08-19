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
  public class GetOpportunitiesTasksTaskIdOk {
    /// <summary>
    /// description string
    /// </summary>
    /// <value>description string</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// name string
    /// </summary>
    /// <value>name string</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// notification string
    /// </summary>
    /// <value>notification string</value>
    [DataMember(Name="notification", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notification")]
    public string Notification { get; set; }

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
      sb.Append("class GetOpportunitiesTasksTaskIdOk {\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Notification: ").Append(Notification).Append("\n");
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
