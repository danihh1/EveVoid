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
  public class GetSearchOk {
    /// <summary>
    /// agent array
    /// </summary>
    /// <value>agent array</value>
    [DataMember(Name="agent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "agent")]
    public List<int?> Agent { get; set; }

    /// <summary>
    /// alliance array
    /// </summary>
    /// <value>alliance array</value>
    [DataMember(Name="alliance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "alliance")]
    public List<int?> Alliance { get; set; }

    /// <summary>
    /// character array
    /// </summary>
    /// <value>character array</value>
    [DataMember(Name="character", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "character")]
    public List<int?> Character { get; set; }

    /// <summary>
    /// constellation array
    /// </summary>
    /// <value>constellation array</value>
    [DataMember(Name="constellation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "constellation")]
    public List<int?> Constellation { get; set; }

    /// <summary>
    /// corporation array
    /// </summary>
    /// <value>corporation array</value>
    [DataMember(Name="corporation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "corporation")]
    public List<int?> Corporation { get; set; }

    /// <summary>
    /// faction array
    /// </summary>
    /// <value>faction array</value>
    [DataMember(Name="faction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "faction")]
    public List<int?> Faction { get; set; }

    /// <summary>
    /// inventory_type array
    /// </summary>
    /// <value>inventory_type array</value>
    [DataMember(Name="inventory_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "inventory_type")]
    public List<int?> InventoryType { get; set; }

    /// <summary>
    /// region array
    /// </summary>
    /// <value>region array</value>
    [DataMember(Name="region", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "region")]
    public List<int?> Region { get; set; }

    /// <summary>
    /// solar_system array
    /// </summary>
    /// <value>solar_system array</value>
    [DataMember(Name="solar_system", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "solar_system")]
    public List<int?> SolarSystem { get; set; }

    /// <summary>
    /// station array
    /// </summary>
    /// <value>station array</value>
    [DataMember(Name="station", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "station")]
    public List<int?> Station { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetSearchOk {\n");
      sb.Append("  Agent: ").Append(Agent).Append("\n");
      sb.Append("  Alliance: ").Append(Alliance).Append("\n");
      sb.Append("  Character: ").Append(Character).Append("\n");
      sb.Append("  Constellation: ").Append(Constellation).Append("\n");
      sb.Append("  Corporation: ").Append(Corporation).Append("\n");
      sb.Append("  Faction: ").Append(Faction).Append("\n");
      sb.Append("  InventoryType: ").Append(InventoryType).Append("\n");
      sb.Append("  Region: ").Append(Region).Append("\n");
      sb.Append("  SolarSystem: ").Append(SolarSystem).Append("\n");
      sb.Append("  Station: ").Append(Station).Append("\n");
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
