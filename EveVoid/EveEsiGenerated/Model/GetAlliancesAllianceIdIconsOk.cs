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
  public class GetAlliancesAllianceIdIconsOk {
    /// <summary>
    /// px128x128 string
    /// </summary>
    /// <value>px128x128 string</value>
    [DataMember(Name="px128x128", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "px128x128")]
    public string Px128x128 { get; set; }

    /// <summary>
    /// px64x64 string
    /// </summary>
    /// <value>px64x64 string</value>
    [DataMember(Name="px64x64", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "px64x64")]
    public string Px64x64 { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetAlliancesAllianceIdIconsOk {\n");
      sb.Append("  Px128x128: ").Append(Px128x128).Append("\n");
      sb.Append("  Px64x64: ").Append(Px64x64).Append("\n");
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
