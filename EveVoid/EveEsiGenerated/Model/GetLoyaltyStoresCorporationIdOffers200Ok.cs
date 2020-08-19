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
  public class GetLoyaltyStoresCorporationIdOffers200Ok {
    /// <summary>
    /// Analysis kredit cost
    /// </summary>
    /// <value>Analysis kredit cost</value>
    [DataMember(Name="ak_cost", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ak_cost")]
    public int? AkCost { get; set; }

    /// <summary>
    /// isk_cost integer
    /// </summary>
    /// <value>isk_cost integer</value>
    [DataMember(Name="isk_cost", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isk_cost")]
    public long? IskCost { get; set; }

    /// <summary>
    /// lp_cost integer
    /// </summary>
    /// <value>lp_cost integer</value>
    [DataMember(Name="lp_cost", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lp_cost")]
    public int? LpCost { get; set; }

    /// <summary>
    /// offer_id integer
    /// </summary>
    /// <value>offer_id integer</value>
    [DataMember(Name="offer_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offer_id")]
    public int? OfferId { get; set; }

    /// <summary>
    /// quantity integer
    /// </summary>
    /// <value>quantity integer</value>
    [DataMember(Name="quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quantity")]
    public int? Quantity { get; set; }

    /// <summary>
    /// required_items array
    /// </summary>
    /// <value>required_items array</value>
    [DataMember(Name="required_items", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "required_items")]
    public List<GetLoyaltyStoresCorporationIdOffersRequiredItem> RequiredItems { get; set; }

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
      sb.Append("class GetLoyaltyStoresCorporationIdOffers200Ok {\n");
      sb.Append("  AkCost: ").Append(AkCost).Append("\n");
      sb.Append("  IskCost: ").Append(IskCost).Append("\n");
      sb.Append("  LpCost: ").Append(LpCost).Append("\n");
      sb.Append("  OfferId: ").Append(OfferId).Append("\n");
      sb.Append("  Quantity: ").Append(Quantity).Append("\n");
      sb.Append("  RequiredItems: ").Append(RequiredItems).Append("\n");
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
