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
  public class GetSovereigntyCampaigns200Ok {
    /// <summary>
    /// Score for all attacking parties, only present in Defense Events. 
    /// </summary>
    /// <value>Score for all attacking parties, only present in Defense Events. </value>
    [DataMember(Name="attackers_score", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attackers_score")]
    public float? AttackersScore { get; set; }

    /// <summary>
    /// Unique ID for this campaign.
    /// </summary>
    /// <value>Unique ID for this campaign.</value>
    [DataMember(Name="campaign_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "campaign_id")]
    public int? CampaignId { get; set; }

    /// <summary>
    /// The constellation in which the campaign will take place. 
    /// </summary>
    /// <value>The constellation in which the campaign will take place. </value>
    [DataMember(Name="constellation_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "constellation_id")]
    public int? ConstellationId { get; set; }

    /// <summary>
    /// Defending alliance, only present in Defense Events 
    /// </summary>
    /// <value>Defending alliance, only present in Defense Events </value>
    [DataMember(Name="defender_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defender_id")]
    public int? DefenderId { get; set; }

    /// <summary>
    /// Score for the defending alliance, only present in Defense Events. 
    /// </summary>
    /// <value>Score for the defending alliance, only present in Defense Events. </value>
    [DataMember(Name="defender_score", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defender_score")]
    public float? DefenderScore { get; set; }

    /// <summary>
    /// Type of event this campaign is for. tcu_defense, ihub_defense and station_defense are referred to as \"Defense Events\", station_freeport as \"Freeport Events\". 
    /// </summary>
    /// <value>Type of event this campaign is for. tcu_defense, ihub_defense and station_defense are referred to as \"Defense Events\", station_freeport as \"Freeport Events\". </value>
    [DataMember(Name="event_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "event_type")]
    public string EventType { get; set; }

    /// <summary>
    /// Alliance participating and their respective scores, only present in Freeport Events. 
    /// </summary>
    /// <value>Alliance participating and their respective scores, only present in Freeport Events. </value>
    [DataMember(Name="participants", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "participants")]
    public List<GetSovereigntyCampaignsParticipant> Participants { get; set; }

    /// <summary>
    /// The solar system the structure is located in. 
    /// </summary>
    /// <value>The solar system the structure is located in. </value>
    [DataMember(Name="solar_system_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "solar_system_id")]
    public int? SolarSystemId { get; set; }

    /// <summary>
    /// Time the event is scheduled to start. 
    /// </summary>
    /// <value>Time the event is scheduled to start. </value>
    [DataMember(Name="start_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "start_time")]
    public DateTime? StartTime { get; set; }

    /// <summary>
    /// The structure item ID that is related to this campaign. 
    /// </summary>
    /// <value>The structure item ID that is related to this campaign. </value>
    [DataMember(Name="structure_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "structure_id")]
    public long? StructureId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetSovereigntyCampaigns200Ok {\n");
      sb.Append("  AttackersScore: ").Append(AttackersScore).Append("\n");
      sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
      sb.Append("  ConstellationId: ").Append(ConstellationId).Append("\n");
      sb.Append("  DefenderId: ").Append(DefenderId).Append("\n");
      sb.Append("  DefenderScore: ").Append(DefenderScore).Append("\n");
      sb.Append("  EventType: ").Append(EventType).Append("\n");
      sb.Append("  Participants: ").Append(Participants).Append("\n");
      sb.Append("  SolarSystemId: ").Append(SolarSystemId).Append("\n");
      sb.Append("  StartTime: ").Append(StartTime).Append("\n");
      sb.Append("  StructureId: ").Append(StructureId).Append("\n");
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
