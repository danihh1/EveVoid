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
  public class GetCharactersCharacterIdAttributesOk {
    /// <summary>
    /// Neural remapping cooldown after a character uses remap accrued over time
    /// </summary>
    /// <value>Neural remapping cooldown after a character uses remap accrued over time</value>
    [DataMember(Name="accrued_remap_cooldown_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accrued_remap_cooldown_date")]
    public DateTime? AccruedRemapCooldownDate { get; set; }

    /// <summary>
    /// Number of available bonus character neural remaps
    /// </summary>
    /// <value>Number of available bonus character neural remaps</value>
    [DataMember(Name="bonus_remaps", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bonus_remaps")]
    public int? BonusRemaps { get; set; }

    /// <summary>
    /// charisma integer
    /// </summary>
    /// <value>charisma integer</value>
    [DataMember(Name="charisma", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "charisma")]
    public int? Charisma { get; set; }

    /// <summary>
    /// intelligence integer
    /// </summary>
    /// <value>intelligence integer</value>
    [DataMember(Name="intelligence", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "intelligence")]
    public int? Intelligence { get; set; }

    /// <summary>
    /// Datetime of last neural remap, including usage of bonus remaps
    /// </summary>
    /// <value>Datetime of last neural remap, including usage of bonus remaps</value>
    [DataMember(Name="last_remap_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last_remap_date")]
    public DateTime? LastRemapDate { get; set; }

    /// <summary>
    /// memory integer
    /// </summary>
    /// <value>memory integer</value>
    [DataMember(Name="memory", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "memory")]
    public int? Memory { get; set; }

    /// <summary>
    /// perception integer
    /// </summary>
    /// <value>perception integer</value>
    [DataMember(Name="perception", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "perception")]
    public int? Perception { get; set; }

    /// <summary>
    /// willpower integer
    /// </summary>
    /// <value>willpower integer</value>
    [DataMember(Name="willpower", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "willpower")]
    public int? Willpower { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCharactersCharacterIdAttributesOk {\n");
      sb.Append("  AccruedRemapCooldownDate: ").Append(AccruedRemapCooldownDate).Append("\n");
      sb.Append("  BonusRemaps: ").Append(BonusRemaps).Append("\n");
      sb.Append("  Charisma: ").Append(Charisma).Append("\n");
      sb.Append("  Intelligence: ").Append(Intelligence).Append("\n");
      sb.Append("  LastRemapDate: ").Append(LastRemapDate).Append("\n");
      sb.Append("  Memory: ").Append(Memory).Append("\n");
      sb.Append("  Perception: ").Append(Perception).Append("\n");
      sb.Append("  Willpower: ").Append(Willpower).Append("\n");
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
