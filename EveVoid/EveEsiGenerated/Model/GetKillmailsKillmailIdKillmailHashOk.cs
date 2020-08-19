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
  public class GetKillmailsKillmailIdKillmailHashOk {
    /// <summary>
    /// attackers array
    /// </summary>
    /// <value>attackers array</value>
    [DataMember(Name="attackers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attackers")]
    public List<GetKillmailsKillmailIdKillmailHashAttacker> Attackers { get; set; }

    /// <summary>
    /// ID of the killmail
    /// </summary>
    /// <value>ID of the killmail</value>
    [DataMember(Name="killmail_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "killmail_id")]
    public int? KillmailId { get; set; }

    /// <summary>
    /// Time that the victim was killed and the killmail generated 
    /// </summary>
    /// <value>Time that the victim was killed and the killmail generated </value>
    [DataMember(Name="killmail_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "killmail_time")]
    public DateTime? KillmailTime { get; set; }

    /// <summary>
    /// Moon if the kill took place at one
    /// </summary>
    /// <value>Moon if the kill took place at one</value>
    [DataMember(Name="moon_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "moon_id")]
    public int? MoonId { get; set; }

    /// <summary>
    /// Solar system that the kill took place in 
    /// </summary>
    /// <value>Solar system that the kill took place in </value>
    [DataMember(Name="solar_system_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "solar_system_id")]
    public int? SolarSystemId { get; set; }

    /// <summary>
    /// Gets or Sets Victim
    /// </summary>
    [DataMember(Name="victim", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "victim")]
    public GetKillmailsKillmailIdKillmailHashVictim Victim { get; set; }

    /// <summary>
    /// War if the killmail is generated in relation to an official war 
    /// </summary>
    /// <value>War if the killmail is generated in relation to an official war </value>
    [DataMember(Name="war_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "war_id")]
    public int? WarId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetKillmailsKillmailIdKillmailHashOk {\n");
      sb.Append("  Attackers: ").Append(Attackers).Append("\n");
      sb.Append("  KillmailId: ").Append(KillmailId).Append("\n");
      sb.Append("  KillmailTime: ").Append(KillmailTime).Append("\n");
      sb.Append("  MoonId: ").Append(MoonId).Append("\n");
      sb.Append("  SolarSystemId: ").Append(SolarSystemId).Append("\n");
      sb.Append("  Victim: ").Append(Victim).Append("\n");
      sb.Append("  WarId: ").Append(WarId).Append("\n");
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
