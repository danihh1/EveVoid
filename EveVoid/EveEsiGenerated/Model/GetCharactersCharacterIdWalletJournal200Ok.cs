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
  public class GetCharactersCharacterIdWalletJournal200Ok {
    /// <summary>
    /// The amount of ISK given or taken from the wallet as a result of the given transaction. Positive when ISK is deposited into the wallet and negative when ISK is withdrawn
    /// </summary>
    /// <value>The amount of ISK given or taken from the wallet as a result of the given transaction. Positive when ISK is deposited into the wallet and negative when ISK is withdrawn</value>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public double? Amount { get; set; }

    /// <summary>
    /// Wallet balance after transaction occurred
    /// </summary>
    /// <value>Wallet balance after transaction occurred</value>
    [DataMember(Name="balance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "balance")]
    public double? Balance { get; set; }

    /// <summary>
    /// An ID that gives extra context to the particular transaction. Because of legacy reasons the context is completely different per ref_type and means different things. It is also possible to not have a context_id
    /// </summary>
    /// <value>An ID that gives extra context to the particular transaction. Because of legacy reasons the context is completely different per ref_type and means different things. It is also possible to not have a context_id</value>
    [DataMember(Name="context_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "context_id")]
    public long? ContextId { get; set; }

    /// <summary>
    /// The type of the given context_id if present
    /// </summary>
    /// <value>The type of the given context_id if present</value>
    [DataMember(Name="context_id_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "context_id_type")]
    public string ContextIdType { get; set; }

    /// <summary>
    /// Date and time of transaction
    /// </summary>
    /// <value>Date and time of transaction</value>
    [DataMember(Name="date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date")]
    public DateTime? Date { get; set; }

    /// <summary>
    /// The reason for the transaction, mirrors what is seen in the client
    /// </summary>
    /// <value>The reason for the transaction, mirrors what is seen in the client</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// The id of the first party involved in the transaction. This attribute has no consistency and is different or non existant for particular ref_types. The description attribute will help make sense of what this attribute means. For more info about the given ID it can be dropped into the /universe/names/ ESI route to determine its type and name
    /// </summary>
    /// <value>The id of the first party involved in the transaction. This attribute has no consistency and is different or non existant for particular ref_types. The description attribute will help make sense of what this attribute means. For more info about the given ID it can be dropped into the /universe/names/ ESI route to determine its type and name</value>
    [DataMember(Name="first_party_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "first_party_id")]
    public int? FirstPartyId { get; set; }

    /// <summary>
    /// Unique journal reference ID
    /// </summary>
    /// <value>Unique journal reference ID</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// The user stated reason for the transaction. Only applies to some ref_types
    /// </summary>
    /// <value>The user stated reason for the transaction. Only applies to some ref_types</value>
    [DataMember(Name="reason", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reason")]
    public string Reason { get; set; }

    /// <summary>
    /// \"The transaction type for the given. transaction. Different transaction types will populate different attributes.\"
    /// </summary>
    /// <value>\"The transaction type for the given. transaction. Different transaction types will populate different attributes.\"</value>
    [DataMember(Name="ref_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ref_type")]
    public string RefType { get; set; }

    /// <summary>
    /// The id of the second party involved in the transaction. This attribute has no consistency and is different or non existant for particular ref_types. The description attribute will help make sense of what this attribute means. For more info about the given ID it can be dropped into the /universe/names/ ESI route to determine its type and name
    /// </summary>
    /// <value>The id of the second party involved in the transaction. This attribute has no consistency and is different or non existant for particular ref_types. The description attribute will help make sense of what this attribute means. For more info about the given ID it can be dropped into the /universe/names/ ESI route to determine its type and name</value>
    [DataMember(Name="second_party_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "second_party_id")]
    public int? SecondPartyId { get; set; }

    /// <summary>
    /// Tax amount received. Only applies to tax related transactions
    /// </summary>
    /// <value>Tax amount received. Only applies to tax related transactions</value>
    [DataMember(Name="tax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tax")]
    public double? Tax { get; set; }

    /// <summary>
    /// The corporation ID receiving any tax paid. Only applies to tax related transactions
    /// </summary>
    /// <value>The corporation ID receiving any tax paid. Only applies to tax related transactions</value>
    [DataMember(Name="tax_receiver_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tax_receiver_id")]
    public int? TaxReceiverId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCharactersCharacterIdWalletJournal200Ok {\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  Balance: ").Append(Balance).Append("\n");
      sb.Append("  ContextId: ").Append(ContextId).Append("\n");
      sb.Append("  ContextIdType: ").Append(ContextIdType).Append("\n");
      sb.Append("  Date: ").Append(Date).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  FirstPartyId: ").Append(FirstPartyId).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Reason: ").Append(Reason).Append("\n");
      sb.Append("  RefType: ").Append(RefType).Append("\n");
      sb.Append("  SecondPartyId: ").Append(SecondPartyId).Append("\n");
      sb.Append("  Tax: ").Append(Tax).Append("\n");
      sb.Append("  TaxReceiverId: ").Append(TaxReceiverId).Append("\n");
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
