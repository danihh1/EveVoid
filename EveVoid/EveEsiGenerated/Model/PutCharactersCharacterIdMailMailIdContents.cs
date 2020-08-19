using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// contents object
  /// </summary>
  [DataContract]
  public class PutCharactersCharacterIdMailMailIdContents {
    /// <summary>
    /// Labels to assign to the mail. Pre-existing labels are unassigned.
    /// </summary>
    /// <value>Labels to assign to the mail. Pre-existing labels are unassigned.</value>
    [DataMember(Name="labels", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "labels")]
    public List<int?> Labels { get; set; }

    /// <summary>
    /// Whether the mail is flagged as read
    /// </summary>
    /// <value>Whether the mail is flagged as read</value>
    [DataMember(Name="read", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "read")]
    public bool? Read { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PutCharactersCharacterIdMailMailIdContents {\n");
      sb.Append("  Labels: ").Append(Labels).Append("\n");
      sb.Append("  Read: ").Append(Read).Append("\n");
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
