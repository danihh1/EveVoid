using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// cost_indice object
  /// </summary>
  [DataContract]
  public class GetIndustrySystemsCostIndice {
    /// <summary>
    /// activity string
    /// </summary>
    /// <value>activity string</value>
    [DataMember(Name="activity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activity")]
    public string Activity { get; set; }

    /// <summary>
    /// cost_index number
    /// </summary>
    /// <value>cost_index number</value>
    [DataMember(Name="cost_index", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cost_index")]
    public float? CostIndex { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetIndustrySystemsCostIndice {\n");
      sb.Append("  Activity: ").Append(Activity).Append("\n");
      sb.Append("  CostIndex: ").Append(CostIndex).Append("\n");
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
