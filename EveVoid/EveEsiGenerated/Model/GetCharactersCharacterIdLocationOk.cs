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
  public class GetCharactersCharacterIdLocationOk {
    /// <summary>
    /// solar_system_id integer
    /// </summary>
    /// <value>solar_system_id integer</value>
    [DataMember(Name="solar_system_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "solar_system_id")]
    public int? SolarSystemId { get; set; }

    /// <summary>
    /// station_id integer
    /// </summary>
    /// <value>station_id integer</value>
    [DataMember(Name="station_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "station_id")]
    public int? StationId { get; set; }

    /// <summary>
    /// structure_id integer
    /// </summary>
    /// <value>structure_id integer</value>
    [DataMember(Name="structure_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "structure_id")]
    public long? StructureId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCharactersCharacterIdLocationOk {\n");
      sb.Append("  SolarSystemId: ").Append(SolarSystemId).Append("\n");
      sb.Append("  StationId: ").Append(StationId).Append("\n");
      sb.Append("  StructureId: ").Append(StructureId).Append("\n");
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
