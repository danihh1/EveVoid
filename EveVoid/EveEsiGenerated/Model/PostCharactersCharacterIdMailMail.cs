using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// mail object
  /// </summary>
  [DataContract]
  public class PostCharactersCharacterIdMailMail {
    /// <summary>
    /// approved_cost integer
    /// </summary>
    /// <value>approved_cost integer</value>
    [DataMember(Name="approved_cost", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "approved_cost")]
    public long? ApprovedCost { get; set; }

    /// <summary>
    /// body string
    /// </summary>
    /// <value>body string</value>
    [DataMember(Name="body", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "body")]
    public string Body { get; set; }

    /// <summary>
    /// recipients array
    /// </summary>
    /// <value>recipients array</value>
    [DataMember(Name="recipients", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recipients")]
    public List<PostCharactersCharacterIdMailRecipient> Recipients { get; set; }

    /// <summary>
    /// subject string
    /// </summary>
    /// <value>subject string</value>
    [DataMember(Name="subject", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subject")]
    public string Subject { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PostCharactersCharacterIdMailMail {\n");
      sb.Append("  ApprovedCost: ").Append(ApprovedCost).Append("\n");
      sb.Append("  Body: ").Append(Body).Append("\n");
      sb.Append("  Recipients: ").Append(Recipients).Append("\n");
      sb.Append("  Subject: ").Append(Subject).Append("\n");
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
