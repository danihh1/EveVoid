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
  public class GetMarketsPrices200Ok {
    /// <summary>
    /// adjusted_price number
    /// </summary>
    /// <value>adjusted_price number</value>
    [DataMember(Name="adjusted_price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "adjusted_price")]
    public double? AdjustedPrice { get; set; }

    /// <summary>
    /// average_price number
    /// </summary>
    /// <value>average_price number</value>
    [DataMember(Name="average_price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "average_price")]
    public double? AveragePrice { get; set; }

    /// <summary>
    /// type_id integer
    /// </summary>
    /// <value>type_id integer</value>
    [DataMember(Name="type_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type_id")]
    public int? TypeId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetMarketsPrices200Ok {\n");
      sb.Append("  AdjustedPrice: ").Append(AdjustedPrice).Append("\n");
      sb.Append("  AveragePrice: ").Append(AveragePrice).Append("\n");
      sb.Append("  TypeId: ").Append(TypeId).Append("\n");
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
