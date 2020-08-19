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
  public class PostUniverseIdsOk {
    /// <summary>
    /// agents array
    /// </summary>
    /// <value>agents array</value>
    [DataMember(Name="agents", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "agents")]
    public List<PostUniverseIdsAgent> Agents { get; set; }

    /// <summary>
    /// alliances array
    /// </summary>
    /// <value>alliances array</value>
    [DataMember(Name="alliances", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "alliances")]
    public List<PostUniverseIdsAlliance> Alliances { get; set; }

    /// <summary>
    /// characters array
    /// </summary>
    /// <value>characters array</value>
    [DataMember(Name="characters", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "characters")]
    public List<PostUniverseIdsCharacter> Characters { get; set; }

    /// <summary>
    /// constellations array
    /// </summary>
    /// <value>constellations array</value>
    [DataMember(Name="constellations", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "constellations")]
    public List<PostUniverseIdsConstellation> Constellations { get; set; }

    /// <summary>
    /// corporations array
    /// </summary>
    /// <value>corporations array</value>
    [DataMember(Name="corporations", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "corporations")]
    public List<PostUniverseIdsCorporation> Corporations { get; set; }

    /// <summary>
    /// factions array
    /// </summary>
    /// <value>factions array</value>
    [DataMember(Name="factions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "factions")]
    public List<PostUniverseIdsFaction> Factions { get; set; }

    /// <summary>
    /// inventory_types array
    /// </summary>
    /// <value>inventory_types array</value>
    [DataMember(Name="inventory_types", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "inventory_types")]
    public List<PostUniverseIdsInventoryType> InventoryTypes { get; set; }

    /// <summary>
    /// regions array
    /// </summary>
    /// <value>regions array</value>
    [DataMember(Name="regions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "regions")]
    public List<PostUniverseIdsRegion> Regions { get; set; }

    /// <summary>
    /// stations array
    /// </summary>
    /// <value>stations array</value>
    [DataMember(Name="stations", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stations")]
    public List<PostUniverseIdsStation> Stations { get; set; }

    /// <summary>
    /// systems array
    /// </summary>
    /// <value>systems array</value>
    [DataMember(Name="systems", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "systems")]
    public List<PostUniverseIdsSystem> Systems { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PostUniverseIdsOk {\n");
      sb.Append("  Agents: ").Append(Agents).Append("\n");
      sb.Append("  Alliances: ").Append(Alliances).Append("\n");
      sb.Append("  Characters: ").Append(Characters).Append("\n");
      sb.Append("  Constellations: ").Append(Constellations).Append("\n");
      sb.Append("  Corporations: ").Append(Corporations).Append("\n");
      sb.Append("  Factions: ").Append(Factions).Append("\n");
      sb.Append("  InventoryTypes: ").Append(InventoryTypes).Append("\n");
      sb.Append("  Regions: ").Append(Regions).Append("\n");
      sb.Append("  Stations: ").Append(Stations).Append("\n");
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
