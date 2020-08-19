using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// extractor_details object
  /// </summary>
  [DataContract]
  public class GetCharactersCharacterIdPlanetsPlanetIdExtractorDetails {
    /// <summary>
    /// in seconds
    /// </summary>
    /// <value>in seconds</value>
    [DataMember(Name="cycle_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cycle_time")]
    public int? CycleTime { get; set; }

    /// <summary>
    /// head_radius number
    /// </summary>
    /// <value>head_radius number</value>
    [DataMember(Name="head_radius", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "head_radius")]
    public float? HeadRadius { get; set; }

    /// <summary>
    /// heads array
    /// </summary>
    /// <value>heads array</value>
    [DataMember(Name="heads", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "heads")]
    public List<GetCharactersCharacterIdPlanetsPlanetIdHead> Heads { get; set; }

    /// <summary>
    /// product_type_id integer
    /// </summary>
    /// <value>product_type_id integer</value>
    [DataMember(Name="product_type_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "product_type_id")]
    public int? ProductTypeId { get; set; }

    /// <summary>
    /// qty_per_cycle integer
    /// </summary>
    /// <value>qty_per_cycle integer</value>
    [DataMember(Name="qty_per_cycle", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "qty_per_cycle")]
    public int? QtyPerCycle { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCharactersCharacterIdPlanetsPlanetIdExtractorDetails {\n");
      sb.Append("  CycleTime: ").Append(CycleTime).Append("\n");
      sb.Append("  HeadRadius: ").Append(HeadRadius).Append("\n");
      sb.Append("  Heads: ").Append(Heads).Append("\n");
      sb.Append("  ProductTypeId: ").Append(ProductTypeId).Append("\n");
      sb.Append("  QtyPerCycle: ").Append(QtyPerCycle).Append("\n");
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
