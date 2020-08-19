using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// destination object
  /// </summary>
  [DataContract]
  public class GetUniverseStargatesStargateIdDestination {
    /// <summary>
    /// The stargate this stargate connects to
    /// </summary>
    /// <value>The stargate this stargate connects to</value>
    [DataMember(Name="stargate_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stargate_id")]
    public int? StargateId { get; set; }

    /// <summary>
    /// The solar system this stargate connects to
    /// </summary>
    /// <value>The solar system this stargate connects to</value>
    [DataMember(Name="system_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "system_id")]
    public int? SystemId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetUniverseStargatesStargateIdDestination {\n");
      sb.Append("  StargateId: ").Append(StargateId).Append("\n");
      sb.Append("  SystemId: ").Append(SystemId).Append("\n");
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
