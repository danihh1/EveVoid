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
  public class GetUniverseConstellationsConstellationIdOk {
    /// <summary>
    /// constellation_id integer
    /// </summary>
    /// <value>constellation_id integer</value>
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
    /// Gets or Sets Position
    /// </summary>
    [DataMember(Name="position", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "position")]
    public GetUniverseConstellationsConstellationIdPosition Position { get; set; }

    /// <summary>
    /// The region this constellation is in
    /// </summary>
    /// <value>The region this constellation is in</value>
    [DataMember(Name="region_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "region_id")]
    public int? RegionId { get; set; }

    /// <summary>
    /// systems array
    /// </summary>
    /// <value>systems array</value>
    [DataMember(Name="systems", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "systems")]
    public List<int?> Systems { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetUniverseConstellationsConstellationIdOk {\n");
      sb.Append("  ConstellationId: ").Append(ConstellationId).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Position: ").Append(Position).Append("\n");
      sb.Append("  RegionId: ").Append(RegionId).Append("\n");
      sb.Append("  Systems: ").Append(Systems).Append("\n");
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
