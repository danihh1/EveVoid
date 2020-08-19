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
  public class GetCharactersCharacterIdContractsContractIdItems200Ok {
    /// <summary>
    /// true if the contract issuer has submitted this item with the contract, false if the isser is asking for this item in the contract
    /// </summary>
    /// <value>true if the contract issuer has submitted this item with the contract, false if the isser is asking for this item in the contract</value>
    [DataMember(Name="is_included", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_included")]
    public bool? IsIncluded { get; set; }

    /// <summary>
    /// is_singleton boolean
    /// </summary>
    /// <value>is_singleton boolean</value>
    [DataMember(Name="is_singleton", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_singleton")]
    public bool? IsSingleton { get; set; }

    /// <summary>
    /// Number of items in the stack
    /// </summary>
    /// <value>Number of items in the stack</value>
    [DataMember(Name="quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quantity")]
    public int? Quantity { get; set; }

    /// <summary>
    /// -1 indicates that the item is a singleton (non-stackable). If the item happens to be a Blueprint, -1 is an Original and -2 is a Blueprint Copy
    /// </summary>
    /// <value>-1 indicates that the item is a singleton (non-stackable). If the item happens to be a Blueprint, -1 is an Original and -2 is a Blueprint Copy</value>
    [DataMember(Name="raw_quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "raw_quantity")]
    public int? RawQuantity { get; set; }

    /// <summary>
    /// Unique ID for the item
    /// </summary>
    /// <value>Unique ID for the item</value>
    [DataMember(Name="record_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "record_id")]
    public long? RecordId { get; set; }

    /// <summary>
    /// Type ID for item
    /// </summary>
    /// <value>Type ID for item</value>
    [DataMember(Name="type_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type_id")]
    public int? TypeId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCharactersCharacterIdContractsContractIdItems200Ok {\n");
      sb.Append("  IsIncluded: ").Append(IsIncluded).Append("\n");
      sb.Append("  IsSingleton: ").Append(IsSingleton).Append("\n");
      sb.Append("  Quantity: ").Append(Quantity).Append("\n");
      sb.Append("  RawQuantity: ").Append(RawQuantity).Append("\n");
      sb.Append("  RecordId: ").Append(RecordId).Append("\n");
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
