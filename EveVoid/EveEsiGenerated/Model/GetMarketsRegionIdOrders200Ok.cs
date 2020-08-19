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
  public class GetMarketsRegionIdOrders200Ok {
    /// <summary>
    /// duration integer
    /// </summary>
    /// <value>duration integer</value>
    [DataMember(Name="duration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "duration")]
    public int? Duration { get; set; }

    /// <summary>
    /// is_buy_order boolean
    /// </summary>
    /// <value>is_buy_order boolean</value>
    [DataMember(Name="is_buy_order", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_buy_order")]
    public bool? IsBuyOrder { get; set; }

    /// <summary>
    /// issued string
    /// </summary>
    /// <value>issued string</value>
    [DataMember(Name="issued", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issued")]
    public DateTime? Issued { get; set; }

    /// <summary>
    /// location_id integer
    /// </summary>
    /// <value>location_id integer</value>
    [DataMember(Name="location_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "location_id")]
    public long? LocationId { get; set; }

    /// <summary>
    /// min_volume integer
    /// </summary>
    /// <value>min_volume integer</value>
    [DataMember(Name="min_volume", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "min_volume")]
    public int? MinVolume { get; set; }

    /// <summary>
    /// order_id integer
    /// </summary>
    /// <value>order_id integer</value>
    [DataMember(Name="order_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order_id")]
    public long? OrderId { get; set; }

    /// <summary>
    /// price number
    /// </summary>
    /// <value>price number</value>
    [DataMember(Name="price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "price")]
    public double? Price { get; set; }

    /// <summary>
    /// range string
    /// </summary>
    /// <value>range string</value>
    [DataMember(Name="range", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "range")]
    public string Range { get; set; }

    /// <summary>
    /// The solar system this order was placed
    /// </summary>
    /// <value>The solar system this order was placed</value>
    [DataMember(Name="system_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "system_id")]
    public int? SystemId { get; set; }

    /// <summary>
    /// type_id integer
    /// </summary>
    /// <value>type_id integer</value>
    [DataMember(Name="type_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type_id")]
    public int? TypeId { get; set; }

    /// <summary>
    /// volume_remain integer
    /// </summary>
    /// <value>volume_remain integer</value>
    [DataMember(Name="volume_remain", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "volume_remain")]
    public int? VolumeRemain { get; set; }

    /// <summary>
    /// volume_total integer
    /// </summary>
    /// <value>volume_total integer</value>
    [DataMember(Name="volume_total", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "volume_total")]
    public int? VolumeTotal { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetMarketsRegionIdOrders200Ok {\n");
      sb.Append("  Duration: ").Append(Duration).Append("\n");
      sb.Append("  IsBuyOrder: ").Append(IsBuyOrder).Append("\n");
      sb.Append("  Issued: ").Append(Issued).Append("\n");
      sb.Append("  LocationId: ").Append(LocationId).Append("\n");
      sb.Append("  MinVolume: ").Append(MinVolume).Append("\n");
      sb.Append("  OrderId: ").Append(OrderId).Append("\n");
      sb.Append("  Price: ").Append(Price).Append("\n");
      sb.Append("  Range: ").Append(Range).Append("\n");
      sb.Append("  SystemId: ").Append(SystemId).Append("\n");
      sb.Append("  TypeId: ").Append(TypeId).Append("\n");
      sb.Append("  VolumeRemain: ").Append(VolumeRemain).Append("\n");
      sb.Append("  VolumeTotal: ").Append(VolumeTotal).Append("\n");
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
