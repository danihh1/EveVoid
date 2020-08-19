using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// recipient object
  /// </summary>
  [DataContract]
  public class GetCharactersCharacterIdMailRecipient {
    /// <summary>
    /// recipient_id integer
    /// </summary>
    /// <value>recipient_id integer</value>
    [DataMember(Name="recipient_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recipient_id")]
    public int? RecipientId { get; set; }

    /// <summary>
    /// recipient_type string
    /// </summary>
    /// <value>recipient_type string</value>
    [DataMember(Name="recipient_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recipient_type")]
    public string RecipientType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCharactersCharacterIdMailRecipient {\n");
      sb.Append("  RecipientId: ").Append(RecipientId).Append("\n");
      sb.Append("  RecipientType: ").Append(RecipientType).Append("\n");
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
