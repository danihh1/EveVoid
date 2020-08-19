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
  public class GetMarketsRegionIdHistory200Ok {
    /// <summary>
    /// average number
    /// </summary>
    /// <value>average number</value>
    [DataMember(Name="average", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "average")]
    public double? Average { get; set; }

    /// <summary>
    /// The date of this historical statistic entry
    /// </summary>
    /// <value>The date of this historical statistic entry</value>
    [DataMember(Name="date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date")]
    public DateTime? Date { get; set; }

    /// <summary>
    /// highest number
    /// </summary>
    /// <value>highest number</value>
    [DataMember(Name="highest", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "highest")]
    public double? Highest { get; set; }

    /// <summary>
    /// lowest number
    /// </summary>
    /// <value>lowest number</value>
    [DataMember(Name="lowest", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lowest")]
    public double? Lowest { get; set; }

    /// <summary>
    /// Total number of orders happened that day
    /// </summary>
    /// <value>Total number of orders happened that day</value>
    [DataMember(Name="order_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order_count")]
    public long? OrderCount { get; set; }

    /// <summary>
    /// Total
    /// </summary>
    /// <value>Total</value>
    [DataMember(Name="volume", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "volume")]
    public long? Volume { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetMarketsRegionIdHistory200Ok {\n");
      sb.Append("  Average: ").Append(Average).Append("\n");
      sb.Append("  Date: ").Append(Date).Append("\n");
      sb.Append("  Highest: ").Append(Highest).Append("\n");
      sb.Append("  Lowest: ").Append(Lowest).Append("\n");
      sb.Append("  OrderCount: ").Append(OrderCount).Append("\n");
      sb.Append("  Volume: ").Append(Volume).Append("\n");
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
