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
  public class GetContractsPublicItemsContractId200Ok {
    /// <summary>
    /// is_blueprint_copy boolean
    /// </summary>
    /// <value>is_blueprint_copy boolean</value>
    [DataMember(Name="is_blueprint_copy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_blueprint_copy")]
    public bool? IsBlueprintCopy { get; set; }

    /// <summary>
    /// true if the contract issuer has submitted this item with the contract, false if the isser is asking for this item in the contract
    /// </summary>
    /// <value>true if the contract issuer has submitted this item with the contract, false if the isser is asking for this item in the contract</value>
    [DataMember(Name="is_included", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_included")]
    public bool? IsIncluded { get; set; }

    /// <summary>
    /// Unique ID for the item being sold. Not present if item is being requested by contract rather than sold with contract
    /// </summary>
    /// <value>Unique ID for the item being sold. Not present if item is being requested by contract rather than sold with contract</value>
    [DataMember(Name="item_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "item_id")]
    public long? ItemId { get; set; }

    /// <summary>
    /// Material Efficiency Level of the blueprint
    /// </summary>
    /// <value>Material Efficiency Level of the blueprint</value>
    [DataMember(Name="material_efficiency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "material_efficiency")]
    public int? MaterialEfficiency { get; set; }

    /// <summary>
    /// Number of items in the stack
    /// </summary>
    /// <value>Number of items in the stack</value>
    [DataMember(Name="quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quantity")]
    public int? Quantity { get; set; }

    /// <summary>
    /// Unique ID for the item, used by the contract system
    /// </summary>
    /// <value>Unique ID for the item, used by the contract system</value>
    [DataMember(Name="record_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "record_id")]
    public long? RecordId { get; set; }

    /// <summary>
    /// Number of runs remaining if the blueprint is a copy, -1 if it is an original
    /// </summary>
    /// <value>Number of runs remaining if the blueprint is a copy, -1 if it is an original</value>
    [DataMember(Name="runs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "runs")]
    public int? Runs { get; set; }

    /// <summary>
    /// Time Efficiency Level of the blueprint
    /// </summary>
    /// <value>Time Efficiency Level of the blueprint</value>
    [DataMember(Name="time_efficiency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "time_efficiency")]
    public int? TimeEfficiency { get; set; }

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
      sb.Append("class GetContractsPublicItemsContractId200Ok {\n");
      sb.Append("  IsBlueprintCopy: ").Append(IsBlueprintCopy).Append("\n");
      sb.Append("  IsIncluded: ").Append(IsIncluded).Append("\n");
      sb.Append("  ItemId: ").Append(ItemId).Append("\n");
      sb.Append("  MaterialEfficiency: ").Append(MaterialEfficiency).Append("\n");
      sb.Append("  Quantity: ").Append(Quantity).Append("\n");
      sb.Append("  RecordId: ").Append(RecordId).Append("\n");
      sb.Append("  Runs: ").Append(Runs).Append("\n");
      sb.Append("  TimeEfficiency: ").Append(TimeEfficiency).Append("\n");
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
