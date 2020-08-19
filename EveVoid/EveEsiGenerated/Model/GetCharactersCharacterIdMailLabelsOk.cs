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
  public class GetCharactersCharacterIdMailLabelsOk {
    /// <summary>
    /// labels array
    /// </summary>
    /// <value>labels array</value>
    [DataMember(Name="labels", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "labels")]
    public List<GetCharactersCharacterIdMailLabelsLabel> Labels { get; set; }

    /// <summary>
    /// total_unread_count integer
    /// </summary>
    /// <value>total_unread_count integer</value>
    [DataMember(Name="total_unread_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total_unread_count")]
    public int? TotalUnreadCount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCharactersCharacterIdMailLabelsOk {\n");
      sb.Append("  Labels: ").Append(Labels).Append("\n");
      sb.Append("  TotalUnreadCount: ").Append(TotalUnreadCount).Append("\n");
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
