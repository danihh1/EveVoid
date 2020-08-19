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
  public class GetIncursions200Ok {
    /// <summary>
    /// The constellation id in which this incursion takes place
    /// </summary>
    /// <value>The constellation id in which this incursion takes place</value>
    [DataMember(Name="constellation_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "constellation_id")]
    public int? ConstellationId { get; set; }

    /// <summary>
    /// The attacking faction's id
    /// </summary>
    /// <value>The attacking faction's id</value>
    [DataMember(Name="faction_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "faction_id")]
    public int? FactionId { get; set; }

    /// <summary>
    /// Whether the final encounter has boss or not
    /// </summary>
    /// <value>Whether the final encounter has boss or not</value>
    [DataMember(Name="has_boss", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "has_boss")]
    public bool? HasBoss { get; set; }

    /// <summary>
    /// A list of infested solar system ids that are a part of this incursion
    /// </summary>
    /// <value>A list of infested solar system ids that are a part of this incursion</value>
    [DataMember(Name="infested_solar_systems", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "infested_solar_systems")]
    public List<int?> InfestedSolarSystems { get; set; }

    /// <summary>
    /// Influence of this incursion as a float from 0 to 1
    /// </summary>
    /// <value>Influence of this incursion as a float from 0 to 1</value>
    [DataMember(Name="influence", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "influence")]
    public float? Influence { get; set; }

    /// <summary>
    /// Staging solar system for this incursion
    /// </summary>
    /// <value>Staging solar system for this incursion</value>
    [DataMember(Name="staging_solar_system_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "staging_solar_system_id")]
    public int? StagingSolarSystemId { get; set; }

    /// <summary>
    /// The state of this incursion
    /// </summary>
    /// <value>The state of this incursion</value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// The type of this incursion
    /// </summary>
    /// <value>The type of this incursion</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetIncursions200Ok {\n");
      sb.Append("  ConstellationId: ").Append(ConstellationId).Append("\n");
      sb.Append("  FactionId: ").Append(FactionId).Append("\n");
      sb.Append("  HasBoss: ").Append(HasBoss).Append("\n");
      sb.Append("  InfestedSolarSystems: ").Append(InfestedSolarSystems).Append("\n");
      sb.Append("  Influence: ").Append(Influence).Append("\n");
      sb.Append("  StagingSolarSystemId: ").Append(StagingSolarSystemId).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
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
