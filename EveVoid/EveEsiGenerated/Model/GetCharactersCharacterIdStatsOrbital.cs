using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// orbital object
  /// </summary>
  [DataContract]
  public class GetCharactersCharacterIdStatsOrbital {
    /// <summary>
    /// strike_characters_killed integer
    /// </summary>
    /// <value>strike_characters_killed integer</value>
    [DataMember(Name="strike_characters_killed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "strike_characters_killed")]
    public long? StrikeCharactersKilled { get; set; }

    /// <summary>
    /// strike_damage_to_players_armor_amount integer
    /// </summary>
    /// <value>strike_damage_to_players_armor_amount integer</value>
    [DataMember(Name="strike_damage_to_players_armor_amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "strike_damage_to_players_armor_amount")]
    public long? StrikeDamageToPlayersArmorAmount { get; set; }

    /// <summary>
    /// strike_damage_to_players_shield_amount integer
    /// </summary>
    /// <value>strike_damage_to_players_shield_amount integer</value>
    [DataMember(Name="strike_damage_to_players_shield_amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "strike_damage_to_players_shield_amount")]
    public long? StrikeDamageToPlayersShieldAmount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCharactersCharacterIdStatsOrbital {\n");
      sb.Append("  StrikeCharactersKilled: ").Append(StrikeCharactersKilled).Append("\n");
      sb.Append("  StrikeDamageToPlayersArmorAmount: ").Append(StrikeDamageToPlayersArmorAmount).Append("\n");
      sb.Append("  StrikeDamageToPlayersShieldAmount: ").Append(StrikeDamageToPlayersShieldAmount).Append("\n");
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
