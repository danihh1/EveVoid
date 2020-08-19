using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Summary of kills done by the given corporation against enemy factions
  /// </summary>
  [DataContract]
  public class GetCorporationsCorporationIdFwStatsKills {
    /// <summary>
    /// Last week's total number of kills by members of the given corporation against enemy factions
    /// </summary>
    /// <value>Last week's total number of kills by members of the given corporation against enemy factions</value>
    [DataMember(Name="last_week", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last_week")]
    public int? LastWeek { get; set; }

    /// <summary>
    /// Total number of kills by members of the given corporation against enemy factions since the corporation enlisted
    /// </summary>
    /// <value>Total number of kills by members of the given corporation against enemy factions since the corporation enlisted</value>
    [DataMember(Name="total", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total")]
    public int? Total { get; set; }

    /// <summary>
    /// Yesterday's total number of kills by members of the given corporation against enemy factions
    /// </summary>
    /// <value>Yesterday's total number of kills by members of the given corporation against enemy factions</value>
    [DataMember(Name="yesterday", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "yesterday")]
    public int? Yesterday { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCorporationsCorporationIdFwStatsKills {\n");
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
