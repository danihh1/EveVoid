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
  public class GetUniverseTypesTypeIdOk {
    /// <summary>
    /// capacity number
    /// </summary>
    /// <value>capacity number</value>
    [DataMember(Name="capacity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "capacity")]
    public float? Capacity { get; set; }

    /// <summary>
    /// description string
    /// </summary>
    /// <value>description string</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// dogma_attributes array
    /// </summary>
    /// <value>dogma_attributes array</value>
    [DataMember(Name="dogma_attributes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dogma_attributes")]
    public List<GetUniverseTypesTypeIdDogmaAttribute> DogmaAttributes { get; set; }

    /// <summary>
    /// dogma_effects array
    /// </summary>
    /// <value>dogma_effects array</value>
    [DataMember(Name="dogma_effects", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dogma_effects")]
    public List<GetUniverseTypesTypeIdDogmaEffect> DogmaEffects { get; set; }

    /// <summary>
    /// graphic_id integer
    /// </summary>
    /// <value>graphic_id integer</value>
    [DataMember(Name="graphic_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "graphic_id")]
    public int? GraphicId { get; set; }

    /// <summary>
    /// group_id integer
    /// </summary>
    /// <value>group_id integer</value>
    [DataMember(Name="group_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "group_id")]
    public int? GroupId { get; set; }

    /// <summary>
    /// icon_id integer
    /// </summary>
    /// <value>icon_id integer</value>
    [DataMember(Name="icon_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "icon_id")]
    public int? IconId { get; set; }

    /// <summary>
    /// This only exists for types that can be put on the market
    /// </summary>
    /// <value>This only exists for types that can be put on the market</value>
    [DataMember(Name="market_group_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "market_group_id")]
    public int? MarketGroupId { get; set; }

    /// <summary>
    /// mass number
    /// </summary>
    /// <value>mass number</value>
    [DataMember(Name="mass", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mass")]
    public float? Mass { get; set; }

    /// <summary>
    /// name string
    /// </summary>
    /// <value>name string</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// packaged_volume number
    /// </summary>
    /// <value>packaged_volume number</value>
    [DataMember(Name="packaged_volume", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "packaged_volume")]
    public float? PackagedVolume { get; set; }

    /// <summary>
    /// portion_size integer
    /// </summary>
    /// <value>portion_size integer</value>
    [DataMember(Name="portion_size", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "portion_size")]
    public int? PortionSize { get; set; }

    /// <summary>
    /// published boolean
    /// </summary>
    /// <value>published boolean</value>
    [DataMember(Name="published", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "published")]
    public bool? Published { get; set; }

    /// <summary>
    /// radius number
    /// </summary>
    /// <value>radius number</value>
    [DataMember(Name="radius", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "radius")]
    public float? Radius { get; set; }

    /// <summary>
    /// type_id integer
    /// </summary>
    /// <value>type_id integer</value>
    [DataMember(Name="type_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type_id")]
    public int? TypeId { get; set; }

    /// <summary>
    /// volume number
    /// </summary>
    /// <value>volume number</value>
    [DataMember(Name="volume", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "volume")]
    public float? Volume { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetUniverseTypesTypeIdOk {\n");
      sb.Append("  Capacity: ").Append(Capacity).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  DogmaAttributes: ").Append(DogmaAttributes).Append("\n");
      sb.Append("  DogmaEffects: ").Append(DogmaEffects).Append("\n");
      sb.Append("  GraphicId: ").Append(GraphicId).Append("\n");
      sb.Append("  GroupId: ").Append(GroupId).Append("\n");
      sb.Append("  IconId: ").Append(IconId).Append("\n");
      sb.Append("  MarketGroupId: ").Append(MarketGroupId).Append("\n");
      sb.Append("  Mass: ").Append(Mass).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  PackagedVolume: ").Append(PackagedVolume).Append("\n");
      sb.Append("  PortionSize: ").Append(PortionSize).Append("\n");
      sb.Append("  Published: ").Append(Published).Append("\n");
      sb.Append("  Radius: ").Append(Radius).Append("\n");
      sb.Append("  TypeId: ").Append(TypeId).Append("\n");
      sb.Append("  Volume: ").Append(Volume).Append("\n");
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
