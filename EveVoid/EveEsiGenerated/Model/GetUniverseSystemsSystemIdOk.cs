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
  public class GetUniverseSystemsSystemIdOk {
    /// <summary>
    /// The constellation this solar system is in
    /// </summary>
    /// <value>The constellation this solar system is in</value>
    [DataMember(Name="constellation_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "constellation_id")]
    public int? ConstellationId { get; set; }

    /// <summary>
    /// name string
    /// </summary>
    /// <value>name string</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// planets array
    /// </summary>
    /// <value>planets array</value>
    [DataMember(Name="planets", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "planets")]
    public List<GetUniverseSystemsSystemIdPlanet> Planets { get; set; }

    /// <summary>
    /// Gets or Sets Position
    /// </summary>
    [DataMember(Name="position", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "position")]
    public GetUniverseSystemsSystemIdPosition Position { get; set; }

    /// <summary>
    /// security_class string
    /// </summary>
    /// <value>security_class string</value>
    [DataMember(Name="security_class", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "security_class")]
    public string SecurityClass { get; set; }

    /// <summary>
    /// security_status number
    /// </summary>
    /// <value>security_status number</value>
    [DataMember(Name="security_status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "security_status")]
    public float? SecurityStatus { get; set; }

    /// <summary>
    /// star_id integer
    /// </summary>
    /// <value>star_id integer</value>
    [DataMember(Name="star_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "star_id")]
    public int? StarId { get; set; }

    /// <summary>
    /// stargates array
    /// </summary>
    /// <value>stargates array</value>
    [DataMember(Name="stargates", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stargates")]
    public List<int?> Stargates { get; set; }

    /// <summary>
    /// stations array
    /// </summary>
    /// <value>stations array</value>
    [DataMember(Name="stations", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stations")]
    public List<int?> Stations { get; set; }

    /// <summary>
    /// system_id integer
    /// </summary>
    /// <value>system_id integer</value>
    [DataMember(Name="system_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "system_id")]
    public int? SystemId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetUniverseSystemsSystemIdOk {\n");
      sb.Append("  ConstellationId: ").Append(ConstellationId).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Planets: ").Append(Planets).Append("\n");
      sb.Append("  Position: ").Append(Position).Append("\n");
      sb.Append("  SecurityClass: ").Append(SecurityClass).Append("\n");
      sb.Append("  SecurityStatus: ").Append(SecurityStatus).Append("\n");
      sb.Append("  StarId: ").Append(StarId).Append("\n");
      sb.Append("  Stargates: ").Append(Stargates).Append("\n");
      sb.Append("  Stations: ").Append(Stations).Append("\n");
      sb.Append("  SystemId: ").Append(SystemId).Append("\n");
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
