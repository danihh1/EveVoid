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
  public class GetUniverseGroupsGroupIdOk {
    /// <summary>
    /// category_id integer
    /// </summary>
    /// <value>category_id integer</value>
    [DataMember(Name="category_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "category_id")]
    public int? CategoryId { get; set; }

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
    /// published boolean
    /// </summary>
    /// <value>published boolean</value>
    [DataMember(Name="published", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "published")]
    public bool? Published { get; set; }

    /// <summary>
    /// types array
    /// </summary>
    /// <value>types array</value>
    [DataMember(Name="types", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "types")]
    public List<int?> Types { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetUniverseGroupsGroupIdOk {\n");
      sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
      sb.Append("  GroupId: ").Append(GroupId).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Published: ").Append(Published).Append("\n");
      sb.Append("  Types: ").Append(Types).Append("\n");
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
