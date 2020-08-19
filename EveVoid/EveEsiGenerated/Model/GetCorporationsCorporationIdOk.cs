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
  public class GetCorporationsCorporationIdOk {
    /// <summary>
    /// ID of the alliance that corporation is a member of, if any
    /// </summary>
    /// <value>ID of the alliance that corporation is a member of, if any</value>
    [DataMember(Name="alliance_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "alliance_id")]
    public int? AllianceId { get; set; }

    /// <summary>
    /// ceo_id integer
    /// </summary>
    /// <value>ceo_id integer</value>
    [DataMember(Name="ceo_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ceo_id")]
    public int? CeoId { get; set; }

    /// <summary>
    /// creator_id integer
    /// </summary>
    /// <value>creator_id integer</value>
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
    /// description string
    /// </summary>
    /// <value>description string</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// faction_id integer
    /// </summary>
    /// <value>faction_id integer</value>
    [DataMember(Name="faction_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "faction_id")]
    public int? FactionId { get; set; }

    /// <summary>
    /// home_station_id integer
    /// </summary>
    /// <value>home_station_id integer</value>
    [DataMember(Name="home_station_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "home_station_id")]
    public int? HomeStationId { get; set; }

    /// <summary>
    /// member_count integer
    /// </summary>
    /// <value>member_count integer</value>
    [DataMember(Name="member_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "member_count")]
    public int? MemberCount { get; set; }

    /// <summary>
    /// the full name of the corporation
    /// </summary>
    /// <value>the full name of the corporation</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// shares integer
    /// </summary>
    /// <value>shares integer</value>
    [DataMember(Name="shares", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shares")]
    public long? Shares { get; set; }

    /// <summary>
    /// tax_rate number
    /// </summary>
    /// <value>tax_rate number</value>
    [DataMember(Name="tax_rate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tax_rate")]
    public float? TaxRate { get; set; }

    /// <summary>
    /// the short name of the corporation
    /// </summary>
    /// <value>the short name of the corporation</value>
    [DataMember(Name="ticker", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ticker")]
    public string Ticker { get; set; }

    /// <summary>
    /// url string
    /// </summary>
    /// <value>url string</value>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// war_eligible boolean
    /// </summary>
    /// <value>war_eligible boolean</value>
    [DataMember(Name="war_eligible", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "war_eligible")]
    public bool? WarEligible { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCorporationsCorporationIdOk {\n");
      sb.Append("  AllianceId: ").Append(AllianceId).Append("\n");
      sb.Append("  CeoId: ").Append(CeoId).Append("\n");
      sb.Append("  CreatorId: ").Append(CreatorId).Append("\n");
      sb.Append("  DateFounded: ").Append(DateFounded).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  FactionId: ").Append(FactionId).Append("\n");
      sb.Append("  HomeStationId: ").Append(HomeStationId).Append("\n");
      sb.Append("  MemberCount: ").Append(MemberCount).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Shares: ").Append(Shares).Append("\n");
      sb.Append("  TaxRate: ").Append(TaxRate).Append("\n");
      sb.Append("  Ticker: ").Append(Ticker).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  WarEligible: ").Append(WarEligible).Append("\n");
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
