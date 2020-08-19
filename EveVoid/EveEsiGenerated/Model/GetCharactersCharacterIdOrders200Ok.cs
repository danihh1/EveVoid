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
  public class GetCharactersCharacterIdOrders200Ok {
    /// <summary>
    /// Number of days for which order is valid (starting from the issued date). An order expires at time issued + duration
    /// </summary>
    /// <value>Number of days for which order is valid (starting from the issued date). An order expires at time issued + duration</value>
    [DataMember(Name="duration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "duration")]
    public int? Duration { get; set; }

    /// <summary>
    /// For buy orders, the amount of ISK in escrow
    /// </summary>
    /// <value>For buy orders, the amount of ISK in escrow</value>
    [DataMember(Name="escrow", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "escrow")]
    public double? Escrow { get; set; }

    /// <summary>
    /// True if the order is a bid (buy) order
    /// </summary>
    /// <value>True if the order is a bid (buy) order</value>
    [DataMember(Name="is_buy_order", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_buy_order")]
    public bool? IsBuyOrder { get; set; }

    /// <summary>
    /// Signifies whether the buy/sell order was placed on behalf of a corporation.
    /// </summary>
    /// <value>Signifies whether the buy/sell order was placed on behalf of a corporation.</value>
    [DataMember(Name="is_corporation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_corporation")]
    public bool? IsCorporation { get; set; }

    /// <summary>
    /// Date and time when this order was issued
    /// </summary>
    /// <value>Date and time when this order was issued</value>
    [DataMember(Name="issued", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issued")]
    public DateTime? Issued { get; set; }

    /// <summary>
    /// ID of the location where order was placed
    /// </summary>
    /// <value>ID of the location where order was placed</value>
    [DataMember(Name="location_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "location_id")]
    public long? LocationId { get; set; }

    /// <summary>
    /// For buy orders, the minimum quantity that will be accepted in a matching sell order
    /// </summary>
    /// <value>For buy orders, the minimum quantity that will be accepted in a matching sell order</value>
    [DataMember(Name="min_volume", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "min_volume")]
    public int? MinVolume { get; set; }

    /// <summary>
    /// Unique order ID
    /// </summary>
    /// <value>Unique order ID</value>
    [DataMember(Name="order_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order_id")]
    public long? OrderId { get; set; }

    /// <summary>
    /// Cost per unit for this order
    /// </summary>
    /// <value>Cost per unit for this order</value>
    [DataMember(Name="price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "price")]
    public double? Price { get; set; }

    /// <summary>
    /// Valid order range, numbers are ranges in jumps
    /// </summary>
    /// <value>Valid order range, numbers are ranges in jumps</value>
    [DataMember(Name="range", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "range")]
    public string Range { get; set; }

    /// <summary>
    /// ID of the region where order was placed
    /// </summary>
    /// <value>ID of the region where order was placed</value>
    [DataMember(Name="region_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "region_id")]
    public int? RegionId { get; set; }

    /// <summary>
    /// The type ID of the item transacted in this order
    /// </summary>
    /// <value>The type ID of the item transacted in this order</value>
    [DataMember(Name="type_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type_id")]
    public int? TypeId { get; set; }

    /// <summary>
    /// Quantity of items still required or offered
    /// </summary>
    /// <value>Quantity of items still required or offered</value>
    [DataMember(Name="volume_remain", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "volume_remain")]
    public int? VolumeRemain { get; set; }

    /// <summary>
    /// Quantity of items required or offered at time order was placed
    /// </summary>
    /// <value>Quantity of items required or offered at time order was placed</value>
    [DataMember(Name="volume_total", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "volume_total")]
    public int? VolumeTotal { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCharactersCharacterIdOrders200Ok {\n");
      sb.Append("  Duration: ").Append(Duration).Append("\n");
      sb.Append("  Escrow: ").Append(Escrow).Append("\n");
      sb.Append("  IsBuyOrder: ").Append(IsBuyOrder).Append("\n");
      sb.Append("  IsCorporation: ").Append(IsCorporation).Append("\n");
      sb.Append("  Issued: ").Append(Issued).Append("\n");
      sb.Append("  LocationId: ").Append(LocationId).Append("\n");
      sb.Append("  MinVolume: ").Append(MinVolume).Append("\n");
      sb.Append("  OrderId: ").Append(OrderId).Append("\n");
      sb.Append("  Price: ").Append(Price).Append("\n");
      sb.Append("  Range: ").Append(Range).Append("\n");
      sb.Append("  RegionId: ").Append(RegionId).Append("\n");
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
