using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// pin object
  /// </summary>
  [DataContract]
  public class GetCharactersCharacterIdPlanetsPlanetIdPin {
    /// <summary>
    /// contents array
    /// </summary>
    /// <value>contents array</value>
    [DataMember(Name="contents", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contents")]
    public List<GetCharactersCharacterIdPlanetsPlanetIdContent> Contents { get; set; }

    /// <summary>
    /// expiry_time string
    /// </summary>
    /// <value>expiry_time string</value>
    [DataMember(Name="expiry_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expiry_time")]
    public DateTime? ExpiryTime { get; set; }

    /// <summary>
    /// Gets or Sets ExtractorDetails
    /// </summary>
    [DataMember(Name="extractor_details", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "extractor_details")]
    public GetCharactersCharacterIdPlanetsPlanetIdExtractorDetails ExtractorDetails { get; set; }

    /// <summary>
    /// Gets or Sets FactoryDetails
    /// </summary>
    [DataMember(Name="factory_details", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "factory_details")]
    public GetCharactersCharacterIdPlanetsPlanetIdFactoryDetails FactoryDetails { get; set; }

    /// <summary>
    /// install_time string
    /// </summary>
    /// <value>install_time string</value>
    [DataMember(Name="install_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "install_time")]
    public DateTime? InstallTime { get; set; }

    /// <summary>
    /// last_cycle_start string
    /// </summary>
    /// <value>last_cycle_start string</value>
    [DataMember(Name="last_cycle_start", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last_cycle_start")]
    public DateTime? LastCycleStart { get; set; }

    /// <summary>
    /// latitude number
    /// </summary>
    /// <value>latitude number</value>
    [DataMember(Name="latitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "latitude")]
    public float? Latitude { get; set; }

    /// <summary>
    /// longitude number
    /// </summary>
    /// <value>longitude number</value>
    [DataMember(Name="longitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "longitude")]
    public float? Longitude { get; set; }

    /// <summary>
    /// pin_id integer
    /// </summary>
    /// <value>pin_id integer</value>
    [DataMember(Name="pin_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pin_id")]
    public long? PinId { get; set; }

    /// <summary>
    /// schematic_id integer
    /// </summary>
    /// <value>schematic_id integer</value>
    [DataMember(Name="schematic_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "schematic_id")]
    public int? SchematicId { get; set; }

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
      sb.Append("class GetCharactersCharacterIdPlanetsPlanetIdPin {\n");
      sb.Append("  Contents: ").Append(Contents).Append("\n");
      sb.Append("  ExpiryTime: ").Append(ExpiryTime).Append("\n");
      sb.Append("  ExtractorDetails: ").Append(ExtractorDetails).Append("\n");
      sb.Append("  FactoryDetails: ").Append(FactoryDetails).Append("\n");
      sb.Append("  InstallTime: ").Append(InstallTime).Append("\n");
      sb.Append("  LastCycleStart: ").Append(LastCycleStart).Append("\n");
      sb.Append("  Latitude: ").Append(Latitude).Append("\n");
      sb.Append("  Longitude: ").Append(Longitude).Append("\n");
      sb.Append("  PinId: ").Append(PinId).Append("\n");
      sb.Append("  SchematicId: ").Append(SchematicId).Append("\n");
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
