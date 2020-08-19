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
  public class GetCharactersCharacterIdPlanetsPlanetIdOk {
    /// <summary>
    /// links array
    /// </summary>
    /// <value>links array</value>
    [DataMember(Name="links", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "links")]
    public List<GetCharactersCharacterIdPlanetsPlanetIdLink> Links { get; set; }

    /// <summary>
    /// pins array
    /// </summary>
    /// <value>pins array</value>
    [DataMember(Name="pins", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pins")]
    public List<GetCharactersCharacterIdPlanetsPlanetIdPin> Pins { get; set; }

    /// <summary>
    /// routes array
    /// </summary>
    /// <value>routes array</value>
    [DataMember(Name="routes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "routes")]
    public List<GetCharactersCharacterIdPlanetsPlanetIdRoute> Routes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCharactersCharacterIdPlanetsPlanetIdOk {\n");
      sb.Append("  Links: ").Append(Links).Append("\n");
      sb.Append("  Pins: ").Append(Pins).Append("\n");
      sb.Append("  Routes: ").Append(Routes).Append("\n");
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
