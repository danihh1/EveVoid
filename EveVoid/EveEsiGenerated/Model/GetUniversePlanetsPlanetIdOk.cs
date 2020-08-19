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
  public class GetUniversePlanetsPlanetIdOk {
    /// <summary>
    /// name string
    /// </summary>
    /// <value>name string</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// planet_id integer
    /// </summary>
    /// <value>planet_id integer</value>
    [DataMember(Name="planet_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "planet_id")]
    public int? PlanetId { get; set; }

    /// <summary>
    /// Gets or Sets Position
    /// </summary>
    [DataMember(Name="position", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "position")]
    public GetUniversePlanetsPlanetIdPosition Position { get; set; }

    /// <summary>
    /// The solar system this planet is in
    /// </summary>
    /// <value>The solar system this planet is in</value>
    [DataMember(Name="system_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "system_id")]
    public int? SystemId { get; set; }

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
      sb.Append("class GetUniversePlanetsPlanetIdOk {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  PlanetId: ").Append(PlanetId).Append("\n");
      sb.Append("  Position: ").Append(Position).Append("\n");
      sb.Append("  SystemId: ").Append(SystemId).Append("\n");
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
