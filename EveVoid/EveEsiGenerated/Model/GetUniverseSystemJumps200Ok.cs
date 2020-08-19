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
  public class GetUniverseSystemJumps200Ok {
    /// <summary>
    /// ship_jumps integer
    /// </summary>
    /// <value>ship_jumps integer</value>
    [DataMember(Name="ship_jumps", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ship_jumps")]
    public int? ShipJumps { get; set; }

    /// <summary>
    /// system_id integer
    /// </summary>
    /// <value>system_id integer</value>
    [DataMember(Name="system_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "system_id")]
    public int? SystemId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetUniverseSystemJumps200Ok {\n");
      sb.Append("  ShipJumps: ").Append(ShipJumps).Append("\n");
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
