using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Top 4 rankings of factions by number of kills from yesterday, last week and in total
  /// </summary>
  [DataContract]
  public class GetFwLeaderboardsKills {
    /// <summary>
    /// Top 4 ranking of factions active in faction warfare by total kills. A faction is considered \"active\" if they have participated in faction warfare in the past 14 days
    /// </summary>
    /// <value>Top 4 ranking of factions active in faction warfare by total kills. A faction is considered \"active\" if they have participated in faction warfare in the past 14 days</value>
    [DataMember(Name="active_total", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "active_total")]
    public List<GetFwLeaderboardsActiveTotalActiveTotal> ActiveTotal { get; set; }

    /// <summary>
    /// Top 4 ranking of factions by kills in the past week
    /// </summary>
    /// <value>Top 4 ranking of factions by kills in the past week</value>
    [DataMember(Name="last_week", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last_week")]
    public List<GetFwLeaderboardsLastWeekLastWeek> LastWeek { get; set; }

    /// <summary>
    /// Top 4 ranking of factions by kills in the past day
    /// </summary>
    /// <value>Top 4 ranking of factions by kills in the past day</value>
    [DataMember(Name="yesterday", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "yesterday")]
    public List<GetFwLeaderboardsYesterdayYesterday> Yesterday { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetFwLeaderboardsKills {\n");
      sb.Append("  ActiveTotal: ").Append(ActiveTotal).Append("\n");
      sb.Append("  LastWeek: ").Append(LastWeek).Append("\n");
      sb.Append("  Yesterday: ").Append(Yesterday).Append("\n");
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
