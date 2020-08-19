using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// planet object
  /// </summary>
  [DataContract]
  public class GetUniverseSystemsSystemIdPlanet {
    /// <summary>
    /// asteroid_belts array
    /// </summary>
    /// <value>asteroid_belts array</value>
    [DataMember(Name="asteroid_belts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "asteroid_belts")]
    public List<int?> AsteroidBelts { get; set; }

    /// <summary>
    /// moons array
    /// </summary>
    /// <value>moons array</value>
    [DataMember(Name="moons", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "moons")]
    public List<int?> Moons { get; set; }

    /// <summary>
    /// planet_id integer
    /// </summary>
    /// <value>planet_id integer</value>
    [DataMember(Name="planet_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "planet_id")]
    public int? PlanetId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetUniverseSystemsSystemIdPlanet {\n");
      sb.Append("  AsteroidBelts: ").Append(AsteroidBelts).Append("\n");
      sb.Append("  Moons: ").Append(Moons).Append("\n");
      sb.Append("  PlanetId: ").Append(PlanetId).Append("\n");
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
