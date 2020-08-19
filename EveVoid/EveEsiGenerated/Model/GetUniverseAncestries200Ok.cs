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
  public class GetUniverseAncestries200Ok {
    /// <summary>
    /// The bloodline associated with this ancestry
    /// </summary>
    /// <value>The bloodline associated with this ancestry</value>
    [DataMember(Name="bloodline_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bloodline_id")]
    public int? BloodlineId { get; set; }

    /// <summary>
    /// description string
    /// </summary>
    /// <value>description string</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// icon_id integer
    /// </summary>
    /// <value>icon_id integer</value>
    [DataMember(Name="icon_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "icon_id")]
    public int? IconId { get; set; }

    /// <summary>
    /// id integer
    /// </summary>
    /// <value>id integer</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// name string
    /// </summary>
    /// <value>name string</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// short_description string
    /// </summary>
    /// <value>short_description string</value>
    [DataMember(Name="short_description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "short_description")]
    public string ShortDescription { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetUniverseAncestries200Ok {\n");
      sb.Append("  BloodlineId: ").Append(BloodlineId).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  IconId: ").Append(IconId).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  ShortDescription: ").Append(ShortDescription).Append("\n");
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
