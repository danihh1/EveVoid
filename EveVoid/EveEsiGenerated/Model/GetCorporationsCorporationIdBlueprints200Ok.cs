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
  public class GetCorporationsCorporationIdBlueprints200Ok {
    /// <summary>
    /// Unique ID for this item.
    /// </summary>
    /// <value>Unique ID for this item.</value>
    [DataMember(Name="item_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "item_id")]
    public long? ItemId { get; set; }

    /// <summary>
    /// Type of the location_id
    /// </summary>
    /// <value>Type of the location_id</value>
    [DataMember(Name="location_flag", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "location_flag")]
    public string LocationFlag { get; set; }

    /// <summary>
    /// References a station, a ship or an item_id if this blueprint is located within a container.
    /// </summary>
    /// <value>References a station, a ship or an item_id if this blueprint is located within a container.</value>
    [DataMember(Name="location_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "location_id")]
    public long? LocationId { get; set; }

    /// <summary>
    /// Material Efficiency Level of the blueprint.
    /// </summary>
    /// <value>Material Efficiency Level of the blueprint.</value>
    [DataMember(Name="material_efficiency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "material_efficiency")]
    public int? MaterialEfficiency { get; set; }

    /// <summary>
    /// A range of numbers with a minimum of -2 and no maximum value where -1 is an original and -2 is a copy. It can be a positive integer if it is a stack of blueprint originals fresh from the market (e.g. no activities performed on them yet).
    /// </summary>
    /// <value>A range of numbers with a minimum of -2 and no maximum value where -1 is an original and -2 is a copy. It can be a positive integer if it is a stack of blueprint originals fresh from the market (e.g. no activities performed on them yet).</value>
    [DataMember(Name="quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quantity")]
    public int? Quantity { get; set; }

    /// <summary>
    /// Number of runs remaining if the blueprint is a copy, -1 if it is an original.
    /// </summary>
    /// <value>Number of runs remaining if the blueprint is a copy, -1 if it is an original.</value>
    [DataMember(Name="runs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "runs")]
    public int? Runs { get; set; }

    /// <summary>
    /// Time Efficiency Level of the blueprint.
    /// </summary>
    /// <value>Time Efficiency Level of the blueprint.</value>
    [DataMember(Name="time_efficiency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "time_efficiency")]
    public int? TimeEfficiency { get; set; }

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
      sb.Append("class GetCorporationsCorporationIdBlueprints200Ok {\n");
      sb.Append("  ItemId: ").Append(ItemId).Append("\n");
      sb.Append("  LocationFlag: ").Append(LocationFlag).Append("\n");
      sb.Append("  LocationId: ").Append(LocationId).Append("\n");
      sb.Append("  MaterialEfficiency: ").Append(MaterialEfficiency).Append("\n");
      sb.Append("  Quantity: ").Append(Quantity).Append("\n");
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
