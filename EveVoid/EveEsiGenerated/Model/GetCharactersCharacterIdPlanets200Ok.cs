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
  public class GetCharactersCharacterIdPlanets200Ok {
    /// <summary>
    /// last_update string
    /// </summary>
    /// <value>last_update string</value>
    [DataMember(Name="last_update", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last_update")]
    public DateTime? LastUpdate { get; set; }

    /// <summary>
    /// num_pins integer
    /// </summary>
    /// <value>num_pins integer</value>
    [DataMember(Name="num_pins", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "num_pins")]
    public int? NumPins { get; set; }

    /// <summary>
    /// owner_id integer
    /// </summary>
    /// <value>owner_id integer</value>
    [DataMember(Name="owner_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "owner_id")]
    public int? OwnerId { get; set; }

    /// <summary>
    /// planet_id integer
    /// </summary>
    /// <value>planet_id integer</value>
    [DataMember(Name="planet_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "planet_id")]
    public int? PlanetId { get; set; }

    /// <summary>
    /// planet_type string
    /// </summary>
    /// <value>planet_type string</value>
    [DataMember(Name="planet_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "planet_type")]
    public string PlanetType { get; set; }

    /// <summary>
    /// solar_system_id integer
    /// </summary>
    /// <value>solar_system_id integer</value>
    [DataMember(Name="solar_system_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "solar_system_id")]
    public int? SolarSystemId { get; set; }

    /// <summary>
    /// upgrade_level integer
    /// </summary>
    /// <value>upgrade_level integer</value>
    [DataMember(Name="upgrade_level", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "upgrade_level")]
    public int? UpgradeLevel { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCharactersCharacterIdPlanets200Ok {\n");
      sb.Append("  LastUpdate: ").Append(LastUpdate).Append("\n");
      sb.Append("  NumPins: ").Append(NumPins).Append("\n");
      sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
      sb.Append("  PlanetId: ").Append(PlanetId).Append("\n");
      sb.Append("  PlanetType: ").Append(PlanetType).Append("\n");
      sb.Append("  SolarSystemId: ").Append(SolarSystemId).Append("\n");
      sb.Append("  UpgradeLevel: ").Append(UpgradeLevel).Append("\n");
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
