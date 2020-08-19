using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Gateway timeout model
  /// </summary>
  [DataContract]
  public class GatewayTimeout {
    /// <summary>
    /// Gateway timeout message
    /// </summary>
    /// <value>Gateway timeout message</value>
    [DataMember(Name="error", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "error")]
    public string Error { get; set; }

    /// <summary>
    /// number of seconds the request was given
    /// </summary>
    /// <value>number of seconds the request was given</value>
    [DataMember(Name="timeout", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timeout")]
    public int? Timeout { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GatewayTimeout {\n");
      sb.Append("  Error: ").Append(Error).Append("\n");
      sb.Append("  Timeout: ").Append(Timeout).Append("\n");
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
