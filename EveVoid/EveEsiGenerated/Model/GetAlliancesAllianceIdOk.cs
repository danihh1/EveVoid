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
  public class GetAlliancesAllianceIdOk {
    /// <summary>
    /// ID of the corporation that created the alliance
    /// </summary>
    /// <value>ID of the corporation that created the alliance</value>
    [DataMember(Name="creator_corporation_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creator_corporation_id")]
    public int? CreatorCorporationId { get; set; }

    /// <summary>
    /// ID of the character that created the alliance
    /// </summary>
    /// <value>ID of the character that created the alliance</value>
    [DataMember(Name="creator_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creator_id")]
    public int? CreatorId { get; set; }

    /// <summary>
    /// date_founded string
    /// </summary>
    /// <value>date_founded string</value>
    [DataMember(Name="date_founded", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date_founded")]
    public DateTime? DateFounded { get; set; }

    /// <summary>
    /// the executor corporation ID, if this alliance is not closed
    /// </summary>
    /// <value>the executor corporation ID, if this alliance is not closed</value>
    [DataMember(Name="executor_corporation_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "executor_corporation_id")]
    public int? ExecutorCorporationId { get; set; }

    /// <summary>
    /// Faction ID this alliance is fighting for, if this alliance is enlisted in factional warfare
    /// </summary>
    /// <value>Faction ID this alliance is fighting for, if this alliance is enlisted in factional warfare</value>
    [DataMember(Name="faction_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "faction_id")]
    public int? FactionId { get; set; }

    /// <summary>
    /// the full name of the alliance
    /// </summary>
    /// <value>the full name of the alliance</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// the short name of the alliance
    /// </summary>
    /// <value>the short name of the alliance</value>
    [DataMember(Name="ticker", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ticker")]
    public string Ticker { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetAlliancesAllianceIdOk {\n");
      sb.Append("  CreatorCorporationId: ").Append(CreatorCorporationId).Append("\n");
      sb.Append("  CreatorId: ").Append(CreatorId).Append("\n");
      sb.Append("  DateFounded: ").Append(DateFounded).Append("\n");
      sb.Append("  ExecutorCorporationId: ").Append(ExecutorCorporationId).Append("\n");
      sb.Append("  FactionId: ").Append(FactionId).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Ticker: ").Append(Ticker).Append("\n");
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
