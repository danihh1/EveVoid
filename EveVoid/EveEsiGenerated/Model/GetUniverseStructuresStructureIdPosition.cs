using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Coordinates of the structure in Cartesian space relative to the Sun, in metres. 
  /// </summary>
  [DataContract]
  public class GetUniverseStructuresStructureIdPosition {
    /// <summary>
    /// x number
    /// </summary>
    /// <value>x number</value>
    [DataMember(Name="x", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "x")]
    public double? X { get; set; }

    /// <summary>
    /// y number
    /// </summary>
    /// <value>y number</value>
    [DataMember(Name="y", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "y")]
    public double? Y { get; set; }

    /// <summary>
    /// z number
    /// </summary>
    /// <value>z number</value>
    [DataMember(Name="z", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "z")]
    public double? Z { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetUniverseStructuresStructureIdPosition {\n");
      sb.Append("  X: ").Append(X).Append("\n");
      sb.Append("  Y: ").Append(Y).Append("\n");
      sb.Append("  Z: ").Append(Z).Append("\n");
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
