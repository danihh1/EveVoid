using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// link object
  /// </summary>
  [DataContract]
  public class GetCharactersCharacterIdPlanetsPlanetIdLink {
    /// <summary>
    /// destination_pin_id integer
    /// </summary>
    /// <value>destination_pin_id integer</value>
    [DataMember(Name="destination_pin_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "destination_pin_id")]
    public long? DestinationPinId { get; set; }

    /// <summary>
    /// link_level integer
    /// </summary>
    /// <value>link_level integer</value>
    [DataMember(Name="link_level", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "link_level")]
    public int? LinkLevel { get; set; }

    /// <summary>
    /// source_pin_id integer
    /// </summary>
    /// <value>source_pin_id integer</value>
    [DataMember(Name="source_pin_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "source_pin_id")]
    public long? SourcePinId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCharactersCharacterIdPlanetsPlanetIdLink {\n");
      sb.Append("  DestinationPinId: ").Append(DestinationPinId).Append("\n");
      sb.Append("  LinkLevel: ").Append(LinkLevel).Append("\n");
      sb.Append("  SourcePinId: ").Append(SourcePinId).Append("\n");
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
