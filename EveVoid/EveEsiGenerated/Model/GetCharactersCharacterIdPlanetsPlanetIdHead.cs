using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// head object
  /// </summary>
  [DataContract]
  public class GetCharactersCharacterIdPlanetsPlanetIdHead {
    /// <summary>
    /// head_id integer
    /// </summary>
    /// <value>head_id integer</value>
    [DataMember(Name="head_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "head_id")]
    public int? HeadId { get; set; }

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
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCharactersCharacterIdPlanetsPlanetIdHead {\n");
      sb.Append("  HeadId: ").Append(HeadId).Append("\n");
      sb.Append("  Latitude: ").Append(Latitude).Append("\n");
      sb.Append("  Longitude: ").Append(Longitude).Append("\n");
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
