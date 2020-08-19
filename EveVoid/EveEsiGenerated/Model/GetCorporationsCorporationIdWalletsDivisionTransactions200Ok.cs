using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// wallet transaction
  /// </summary>
  [DataContract]
  public class GetCorporationsCorporationIdWalletsDivisionTransactions200Ok {
    /// <summary>
    /// client_id integer
    /// </summary>
    /// <value>client_id integer</value>
    [DataMember(Name="client_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "client_id")]
    public int? ClientId { get; set; }

    /// <summary>
    /// Date and time of transaction
    /// </summary>
    /// <value>Date and time of transaction</value>
    [DataMember(Name="date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date")]
    public DateTime? Date { get; set; }

    /// <summary>
    /// is_buy boolean
    /// </summary>
    /// <value>is_buy boolean</value>
    [DataMember(Name="is_buy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_buy")]
    public bool? IsBuy { get; set; }

    /// <summary>
    /// -1 if there is no corresponding wallet journal entry
    /// </summary>
    /// <value>-1 if there is no corresponding wallet journal entry</value>
    [DataMember(Name="journal_ref_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "journal_ref_id")]
    public long? JournalRefId { get; set; }

    /// <summary>
    /// location_id integer
    /// </summary>
    /// <value>location_id integer</value>
    [DataMember(Name="location_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "location_id")]
    public long? LocationId { get; set; }

    /// <summary>
    /// quantity integer
    /// </summary>
    /// <value>quantity integer</value>
    [DataMember(Name="quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quantity")]
    public int? Quantity { get; set; }

    /// <summary>
    /// Unique transaction ID
    /// </summary>
    /// <value>Unique transaction ID</value>
    [DataMember(Name="transaction_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transaction_id")]
    public long? TransactionId { get; set; }

    /// <summary>
    /// type_id integer
    /// </summary>
    /// <value>type_id integer</value>
    [DataMember(Name="type_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type_id")]
    public int? TypeId { get; set; }

    /// <summary>
    /// Amount paid per unit
    /// </summary>
    /// <value>Amount paid per unit</value>
    [DataMember(Name="unit_price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unit_price")]
    public double? UnitPrice { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCorporationsCorporationIdWalletsDivisionTransactions200Ok {\n");
      sb.Append("  ClientId: ").Append(ClientId).Append("\n");
      sb.Append("  Date: ").Append(Date).Append("\n");
      sb.Append("  IsBuy: ").Append(IsBuy).Append("\n");
      sb.Append("  JournalRefId: ").Append(JournalRefId).Append("\n");
      sb.Append("  LocationId: ").Append(LocationId).Append("\n");
      sb.Append("  Quantity: ").Append(Quantity).Append("\n");
      sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
      sb.Append("  TypeId: ").Append(TypeId).Append("\n");
      sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
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
