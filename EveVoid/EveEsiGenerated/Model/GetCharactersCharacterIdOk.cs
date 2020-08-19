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
  public class GetCharactersCharacterIdOk {
    /// <summary>
    /// The character's alliance ID
    /// </summary>
    /// <value>The character's alliance ID</value>
    [DataMember(Name="alliance_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "alliance_id")]
    public int? AllianceId { get; set; }

    /// <summary>
    /// ancestry_id integer
    /// </summary>
    /// <value>ancestry_id integer</value>
    [DataMember(Name="ancestry_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ancestry_id")]
    public int? AncestryId { get; set; }

    /// <summary>
    /// Creation date of the character
    /// </summary>
    /// <value>Creation date of the character</value>
    [DataMember(Name="birthday", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "birthday")]
    public DateTime? Birthday { get; set; }

    /// <summary>
    /// bloodline_id integer
    /// </summary>
    /// <value>bloodline_id integer</value>
    [DataMember(Name="bloodline_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bloodline_id")]
    public int? BloodlineId { get; set; }

    /// <summary>
    /// The character's corporation ID
    /// </summary>
    /// <value>The character's corporation ID</value>
    [DataMember(Name="corporation_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "corporation_id")]
    public int? CorporationId { get; set; }

    /// <summary>
    /// description string
    /// </summary>
    /// <value>description string</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// ID of the faction the character is fighting for, if the character is enlisted in Factional Warfare
    /// </summary>
    /// <value>ID of the faction the character is fighting for, if the character is enlisted in Factional Warfare</value>
    [DataMember(Name="faction_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "faction_id")]
    public int? FactionId { get; set; }

    /// <summary>
    /// gender string
    /// </summary>
    /// <value>gender string</value>
    [DataMember(Name="gender", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gender")]
    public string Gender { get; set; }

    /// <summary>
    /// name string
    /// </summary>
    /// <value>name string</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// race_id integer
    /// </summary>
    /// <value>race_id integer</value>
    [DataMember(Name="race_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "race_id")]
    public int? RaceId { get; set; }

    /// <summary>
    /// security_status number
    /// </summary>
    /// <value>security_status number</value>
    [DataMember(Name="security_status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "security_status")]
    public float? SecurityStatus { get; set; }

    /// <summary>
    /// The individual title of the character
    /// </summary>
    /// <value>The individual title of the character</value>
    [DataMember(Name="title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title")]
    public string Title { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCharactersCharacterIdOk {\n");
      sb.Append("  AllianceId: ").Append(AllianceId).Append("\n");
      sb.Append("  AncestryId: ").Append(AncestryId).Append("\n");
      sb.Append("  Birthday: ").Append(Birthday).Append("\n");
      sb.Append("  BloodlineId: ").Append(BloodlineId).Append("\n");
      sb.Append("  CorporationId: ").Append(CorporationId).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  FactionId: ").Append(FactionId).Append("\n");
      sb.Append("  Gender: ").Append(Gender).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  RaceId: ").Append(RaceId).Append("\n");
      sb.Append("  SecurityStatus: ").Append(SecurityStatus).Append("\n");
      sb.Append("  Title: ").Append(Title).Append("\n");
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
