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
  public class GetOpportunitiesGroupsGroupIdOk {
    /// <summary>
    /// The groups that are connected to this group on the opportunities map
    /// </summary>
    /// <value>The groups that are connected to this group on the opportunities map</value>
    [DataMember(Name="connected_groups", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "connected_groups")]
    public List<int?> ConnectedGroups { get; set; }

    /// <summary>
    /// description string
    /// </summary>
    /// <value>description string</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// group_id integer
    /// </summary>
    /// <value>group_id integer</value>
    [DataMember(Name="group_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "group_id")]
    public int? GroupId { get; set; }

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
    /// Tasks need to complete for this group
    /// </summary>
    /// <value>Tasks need to complete for this group</value>
    [DataMember(Name="required_tasks", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "required_tasks")]
    public List<int?> RequiredTasks { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetOpportunitiesGroupsGroupIdOk {\n");
      sb.Append("  ConnectedGroups: ").Append(ConnectedGroups).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  GroupId: ").Append(GroupId).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Notification: ").Append(Notification).Append("\n");
      sb.Append("  RequiredTasks: ").Append(RequiredTasks).Append("\n");
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
