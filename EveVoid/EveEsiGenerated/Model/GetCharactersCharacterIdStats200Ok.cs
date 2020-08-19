using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Aggregate stats for a year
  /// </summary>
  [DataContract]
  public class GetCharactersCharacterIdStats200Ok {
    /// <summary>
    /// Gets or Sets Character
    /// </summary>
    [DataMember(Name="character", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "character")]
    public GetCharactersCharacterIdStatsCharacter Character { get; set; }

    /// <summary>
    /// Gets or Sets Combat
    /// </summary>
    [DataMember(Name="combat", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "combat")]
    public GetCharactersCharacterIdStatsCombat Combat { get; set; }

    /// <summary>
    /// Gets or Sets Industry
    /// </summary>
    [DataMember(Name="industry", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "industry")]
    public GetCharactersCharacterIdStatsIndustry Industry { get; set; }

    /// <summary>
    /// Gets or Sets Inventory
    /// </summary>
    [DataMember(Name="inventory", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "inventory")]
    public GetCharactersCharacterIdStatsInventory Inventory { get; set; }

    /// <summary>
    /// Gets or Sets Isk
    /// </summary>
    [DataMember(Name="isk", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isk")]
    public GetCharactersCharacterIdStatsIsk Isk { get; set; }

    /// <summary>
    /// Gets or Sets Market
    /// </summary>
    [DataMember(Name="market", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "market")]
    public GetCharactersCharacterIdStatsMarket Market { get; set; }

    /// <summary>
    /// Gets or Sets Mining
    /// </summary>
    [DataMember(Name="mining", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mining")]
    public GetCharactersCharacterIdStatsMining Mining { get; set; }

    /// <summary>
    /// Gets or Sets Module
    /// </summary>
    [DataMember(Name="module", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "module")]
    public GetCharactersCharacterIdStatsModule Module { get; set; }

    /// <summary>
    /// Gets or Sets Orbital
    /// </summary>
    [DataMember(Name="orbital", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "orbital")]
    public GetCharactersCharacterIdStatsOrbital Orbital { get; set; }

    /// <summary>
    /// Gets or Sets Pve
    /// </summary>
    [DataMember(Name="pve", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pve")]
    public GetCharactersCharacterIdStatsPve Pve { get; set; }

    /// <summary>
    /// Gets or Sets Social
    /// </summary>
    [DataMember(Name="social", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "social")]
    public GetCharactersCharacterIdStatsSocial Social { get; set; }

    /// <summary>
    /// Gets or Sets Travel
    /// </summary>
    [DataMember(Name="travel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "travel")]
    public GetCharactersCharacterIdStatsTravel Travel { get; set; }

    /// <summary>
    /// Gregorian year for this set of aggregates
    /// </summary>
    /// <value>Gregorian year for this set of aggregates</value>
    [DataMember(Name="year", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "year")]
    public int? Year { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCharactersCharacterIdStats200Ok {\n");
      sb.Append("  Character: ").Append(Character).Append("\n");
      sb.Append("  Combat: ").Append(Combat).Append("\n");
      sb.Append("  Industry: ").Append(Industry).Append("\n");
      sb.Append("  Inventory: ").Append(Inventory).Append("\n");
      sb.Append("  Isk: ").Append(Isk).Append("\n");
      sb.Append("  Market: ").Append(Market).Append("\n");
      sb.Append("  Mining: ").Append(Mining).Append("\n");
      sb.Append("  Module: ").Append(Module).Append("\n");
      sb.Append("  Orbital: ").Append(Orbital).Append("\n");
      sb.Append("  Pve: ").Append(Pve).Append("\n");
      sb.Append("  Social: ").Append(Social).Append("\n");
      sb.Append("  Travel: ").Append(Travel).Append("\n");
      sb.Append("  Year: ").Append(Year).Append("\n");
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
