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
  public class GetUniverseRegionsRegionIdOk {
    /// <summary>
    /// constellations array
    /// </summary>
    /// <value>constellations array</value>
    [DataMember(Name="constellations", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "constellations")]
    public List<int?> Constellations { get; set; }

    /// <summary>
    /// description string
    /// </summary>
    /// <value>description string</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// name string
    /// </summary>
    /// <value>name string</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// region_id integer
    /// </summary>
    /// <value>region_id integer</value>
    [DataMember(Name="region_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "region_id")]
    public int? RegionId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetUniverseRegionsRegionIdOk {\n");
      sb.Append("  Constellations: ").Append(Constellations).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  RegionId: ").Append(RegionId).Append("\n");
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
