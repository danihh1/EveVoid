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
  public class GetCorporationsCorporationIdAssets200Ok {
    /// <summary>
    /// is_blueprint_copy boolean
    /// </summary>
    /// <value>is_blueprint_copy boolean</value>
    [DataMember(Name="is_blueprint_copy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_blueprint_copy")]
    public bool? IsBlueprintCopy { get; set; }

    /// <summary>
    /// is_singleton boolean
    /// </summary>
    /// <value>is_singleton boolean</value>
    [DataMember(Name="is_singleton", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_singleton")]
    public bool? IsSingleton { get; set; }

    /// <summary>
    /// item_id integer
    /// </summary>
    /// <value>item_id integer</value>
    [DataMember(Name="item_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "item_id")]
    public long? ItemId { get; set; }

    /// <summary>
    /// location_flag string
    /// </summary>
    /// <value>location_flag string</value>
    [DataMember(Name="location_flag", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "location_flag")]
    public string LocationFlag { get; set; }

    /// <summary>
    /// location_id integer
    /// </summary>
    /// <value>location_id integer</value>
    [DataMember(Name="location_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "location_id")]
    public long? LocationId { get; set; }

    /// <summary>
    /// location_type string
    /// </summary>
    /// <value>location_type string</value>
    [DataMember(Name="location_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "location_type")]
    public string LocationType { get; set; }

    /// <summary>
    /// quantity integer
    /// </summary>
    /// <value>quantity integer</value>
    [DataMember(Name="quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quantity")]
    public int? Quantity { get; set; }

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
      sb.Append("class GetCorporationsCorporationIdAssets200Ok {\n");
      sb.Append("  IsBlueprintCopy: ").Append(IsBlueprintCopy).Append("\n");
      sb.Append("  IsSingleton: ").Append(IsSingleton).Append("\n");
      sb.Append("  ItemId: ").Append(ItemId).Append("\n");
      sb.Append("  LocationFlag: ").Append(LocationFlag).Append("\n");
      sb.Append("  LocationId: ").Append(LocationId).Append("\n");
      sb.Append("  LocationType: ").Append(LocationType).Append("\n");
      sb.Append("  Quantity: ").Append(Quantity).Append("\n");
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
