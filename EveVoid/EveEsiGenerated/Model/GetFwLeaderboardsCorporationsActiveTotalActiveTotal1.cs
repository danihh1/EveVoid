using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// active_total object
  /// </summary>
  [DataContract]
  public class GetFwLeaderboardsCorporationsActiveTotalActiveTotal1 {
    /// <summary>
    /// Amount of victory points
    /// </summary>
    /// <value>Amount of victory points</value>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public int? Amount { get; set; }

    /// <summary>
    /// corporation_id integer
    /// </summary>
    /// <value>corporation_id integer</value>
    [DataMember(Name="corporation_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "corporation_id")]
    public int? CorporationId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetFwLeaderboardsCorporationsActiveTotalActiveTotal1 {\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  CorporationId: ").Append(CorporationId).Append("\n");
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
