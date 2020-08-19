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
  public class GetIndustrySystems200Ok {
    /// <summary>
    /// cost_indices array
    /// </summary>
    /// <value>cost_indices array</value>
    [DataMember(Name="cost_indices", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cost_indices")]
    public List<GetIndustrySystemsCostIndice> CostIndices { get; set; }

    /// <summary>
    /// solar_system_id integer
    /// </summary>
    /// <value>solar_system_id integer</value>
    [DataMember(Name="solar_system_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "solar_system_id")]
    public int? SolarSystemId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetIndustrySystems200Ok {\n");
      sb.Append("  CostIndices: ").Append(CostIndices).Append("\n");
      sb.Append("  SolarSystemId: ").Append(SolarSystemId).Append("\n");
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
