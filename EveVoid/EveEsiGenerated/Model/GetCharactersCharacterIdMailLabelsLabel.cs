using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// label object
  /// </summary>
  [DataContract]
  public class GetCharactersCharacterIdMailLabelsLabel {
    /// <summary>
    /// color string
    /// </summary>
    /// <value>color string</value>
    [DataMember(Name="color", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "color")]
    public string Color { get; set; }

    /// <summary>
    /// label_id integer
    /// </summary>
    /// <value>label_id integer</value>
    [DataMember(Name="label_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "label_id")]
    public int? LabelId { get; set; }

    /// <summary>
    /// name string
    /// </summary>
    /// <value>name string</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// unread_count integer
    /// </summary>
    /// <value>unread_count integer</value>
    [DataMember(Name="unread_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unread_count")]
    public int? UnreadCount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCharactersCharacterIdMailLabelsLabel {\n");
      sb.Append("  Color: ").Append(Color).Append("\n");
      sb.Append("  LabelId: ").Append(LabelId).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  UnreadCount: ").Append(UnreadCount).Append("\n");
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
