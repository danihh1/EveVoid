using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// level object
  /// </summary>
  [DataContract]
  public class GetInsurancePricesLevel {
    /// <summary>
    /// cost number
    /// </summary>
    /// <value>cost number</value>
    [DataMember(Name="cost", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cost")]
    public float? Cost { get; set; }

    /// <summary>
    /// Localized insurance level
    /// </summary>
    /// <value>Localized insurance level</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// payout number
    /// </summary>
    /// <value>payout number</value>
    [DataMember(Name="payout", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payout")]
    public float? Payout { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetInsurancePricesLevel {\n");
      sb.Append("  Cost: ").Append(Cost).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Payout: ").Append(Payout).Append("\n");
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
