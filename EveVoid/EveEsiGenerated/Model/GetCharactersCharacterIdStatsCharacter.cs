using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// character object
  /// </summary>
  [DataContract]
  public class GetCharactersCharacterIdStatsCharacter {
    /// <summary>
    /// days_of_activity integer
    /// </summary>
    /// <value>days_of_activity integer</value>
    [DataMember(Name="days_of_activity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "days_of_activity")]
    public long? DaysOfActivity { get; set; }

    /// <summary>
    /// minutes integer
    /// </summary>
    /// <value>minutes integer</value>
    [DataMember(Name="minutes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "minutes")]
    public long? Minutes { get; set; }

    /// <summary>
    /// sessions_started integer
    /// </summary>
    /// <value>sessions_started integer</value>
    [DataMember(Name="sessions_started", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sessions_started")]
    public long? SessionsStarted { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCharactersCharacterIdStatsCharacter {\n");
      sb.Append("  DaysOfActivity: ").Append(DaysOfActivity).Append("\n");
      sb.Append("  Minutes: ").Append(Minutes).Append("\n");
      sb.Append("  SessionsStarted: ").Append(SessionsStarted).Append("\n");
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
