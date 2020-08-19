using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// market object
  /// </summary>
  [DataContract]
  public class GetCharactersCharacterIdStatsMarket {
    /// <summary>
    /// accept_contracts_courier integer
    /// </summary>
    /// <value>accept_contracts_courier integer</value>
    [DataMember(Name="accept_contracts_courier", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accept_contracts_courier")]
    public long? AcceptContractsCourier { get; set; }

    /// <summary>
    /// accept_contracts_item_exchange integer
    /// </summary>
    /// <value>accept_contracts_item_exchange integer</value>
    [DataMember(Name="accept_contracts_item_exchange", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accept_contracts_item_exchange")]
    public long? AcceptContractsItemExchange { get; set; }

    /// <summary>
    /// buy_orders_placed integer
    /// </summary>
    /// <value>buy_orders_placed integer</value>
    [DataMember(Name="buy_orders_placed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "buy_orders_placed")]
    public long? BuyOrdersPlaced { get; set; }

    /// <summary>
    /// cancel_market_order integer
    /// </summary>
    /// <value>cancel_market_order integer</value>
    [DataMember(Name="cancel_market_order", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cancel_market_order")]
    public long? CancelMarketOrder { get; set; }

    /// <summary>
    /// create_contracts_auction integer
    /// </summary>
    /// <value>create_contracts_auction integer</value>
    [DataMember(Name="create_contracts_auction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "create_contracts_auction")]
    public long? CreateContractsAuction { get; set; }

    /// <summary>
    /// create_contracts_courier integer
    /// </summary>
    /// <value>create_contracts_courier integer</value>
    [DataMember(Name="create_contracts_courier", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "create_contracts_courier")]
    public long? CreateContractsCourier { get; set; }

    /// <summary>
    /// create_contracts_item_exchange integer
    /// </summary>
    /// <value>create_contracts_item_exchange integer</value>
    [DataMember(Name="create_contracts_item_exchange", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "create_contracts_item_exchange")]
    public long? CreateContractsItemExchange { get; set; }

    /// <summary>
    /// deliver_courier_contract integer
    /// </summary>
    /// <value>deliver_courier_contract integer</value>
    [DataMember(Name="deliver_courier_contract", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deliver_courier_contract")]
    public long? DeliverCourierContract { get; set; }

    /// <summary>
    /// isk_gained integer
    /// </summary>
    /// <value>isk_gained integer</value>
    [DataMember(Name="isk_gained", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isk_gained")]
    public long? IskGained { get; set; }

    /// <summary>
    /// isk_spent integer
    /// </summary>
    /// <value>isk_spent integer</value>
    [DataMember(Name="isk_spent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isk_spent")]
    public long? IskSpent { get; set; }

    /// <summary>
    /// modify_market_order integer
    /// </summary>
    /// <value>modify_market_order integer</value>
    [DataMember(Name="modify_market_order", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "modify_market_order")]
    public long? ModifyMarketOrder { get; set; }

    /// <summary>
    /// search_contracts integer
    /// </summary>
    /// <value>search_contracts integer</value>
    [DataMember(Name="search_contracts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "search_contracts")]
    public long? SearchContracts { get; set; }

    /// <summary>
    /// sell_orders_placed integer
    /// </summary>
    /// <value>sell_orders_placed integer</value>
    [DataMember(Name="sell_orders_placed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sell_orders_placed")]
    public long? SellOrdersPlaced { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCharactersCharacterIdStatsMarket {\n");
      sb.Append("  AcceptContractsCourier: ").Append(AcceptContractsCourier).Append("\n");
      sb.Append("  AcceptContractsItemExchange: ").Append(AcceptContractsItemExchange).Append("\n");
      sb.Append("  BuyOrdersPlaced: ").Append(BuyOrdersPlaced).Append("\n");
      sb.Append("  CancelMarketOrder: ").Append(CancelMarketOrder).Append("\n");
      sb.Append("  CreateContractsAuction: ").Append(CreateContractsAuction).Append("\n");
      sb.Append("  CreateContractsCourier: ").Append(CreateContractsCourier).Append("\n");
      sb.Append("  CreateContractsItemExchange: ").Append(CreateContractsItemExchange).Append("\n");
      sb.Append("  DeliverCourierContract: ").Append(DeliverCourierContract).Append("\n");
      sb.Append("  IskGained: ").Append(IskGained).Append("\n");
      sb.Append("  IskSpent: ").Append(IskSpent).Append("\n");
      sb.Append("  ModifyMarketOrder: ").Append(ModifyMarketOrder).Append("\n");
      sb.Append("  SearchContracts: ").Append(SearchContracts).Append("\n");
      sb.Append("  SellOrdersPlaced: ").Append(SellOrdersPlaced).Append("\n");
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
