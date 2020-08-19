using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Summary of kills against an enemy faction for the given faction
  /// </summary>
  [DataContract]
  public class GetFwStatsKills {
    /// <summary>
    /// Last week's total number of kills against enemy factions
    /// </summary>
    /// <value>Last week's total number of kills against enemy factions</value>
    [DataMember(Name="last_week", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last_week")]
    public int? LastWeek { get; set; }

    /// <summary>
    /// Total number of kills against enemy factions since faction warfare began
    /// </summary>
    /// <value>Total number of kills against enemy factions since faction warfare began</value>
    [DataMember(Name="total", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total")]
    public int? Total { get; set; }

    /// <summary>
    /// Yesterday's total number of kills against enemy factions
    /// </summary>
    /// <value>Yesterday's total number of kills against enemy factions</value>
    [DataMember(Name="yesterday", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "yesterday")]
    public int? Yesterday { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetFwStatsKills {\n");
      sb.Append("  LastWeek: ").Append(LastWeek).Append("\n");
      sb.Append("  Total: ").Append(Total).Append("\n");
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
