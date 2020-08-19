using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// factory_details object
  /// </summary>
  [DataContract]
  public class GetCharactersCharacterIdPlanetsPlanetIdFactoryDetails {
    /// <summary>
    /// schematic_id integer
    /// </summary>
    /// <value>schematic_id integer</value>
    [DataMember(Name="schematic_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "schematic_id")]
    public int? SchematicId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCharactersCharacterIdPlanetsPlanetIdFactoryDetails {\n");
      sb.Append("  SchematicId: ").Append(SchematicId).Append("\n");
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
