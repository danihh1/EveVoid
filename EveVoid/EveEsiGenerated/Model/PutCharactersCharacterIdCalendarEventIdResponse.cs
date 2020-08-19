using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// response object
  /// </summary>
  [DataContract]
  public class PutCharactersCharacterIdCalendarEventIdResponse {
    /// <summary>
    /// response string
    /// </summary>
    /// <value>response string</value>
    [DataMember(Name="response", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "response")]
    public string Response { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PutCharactersCharacterIdCalendarEventIdResponse {\n");
      sb.Append("  Response: ").Append(Response).Append("\n");
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
