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
  public class GetCharactersCharacterIdMedals200Ok {
    /// <summary>
    /// corporation_id integer
    /// </summary>
    /// <value>corporation_id integer</value>
    [DataMember(Name="corporation_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "corporation_id")]
    public int? CorporationId { get; set; }

    /// <summary>
    /// date string
    /// </summary>
    /// <value>date string</value>
    [DataMember(Name="date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date")]
    public DateTime? Date { get; set; }

    /// <summary>
    /// description string
    /// </summary>
    /// <value>description string</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// graphics array
    /// </summary>
    /// <value>graphics array</value>
    [DataMember(Name="graphics", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "graphics")]
    public List<GetCharactersCharacterIdMedalsGraphic> Graphics { get; set; }

    /// <summary>
    /// issuer_id integer
    /// </summary>
    /// <value>issuer_id integer</value>
    [DataMember(Name="issuer_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issuer_id")]
    public int? IssuerId { get; set; }

    /// <summary>
    /// medal_id integer
    /// </summary>
    /// <value>medal_id integer</value>
    [DataMember(Name="medal_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "medal_id")]
    public int? MedalId { get; set; }

    /// <summary>
    /// reason string
    /// </summary>
    /// <value>reason string</value>
    [DataMember(Name="reason", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reason")]
    public string Reason { get; set; }

    /// <summary>
    /// status string
    /// </summary>
    /// <value>status string</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// title string
    /// </summary>
    /// <value>title string</value>
    [DataMember(Name="title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title")]
    public string Title { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCharactersCharacterIdMedals200Ok {\n");
      sb.Append("  CorporationId: ").Append(CorporationId).Append("\n");
      sb.Append("  Date: ").Append(Date).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Graphics: ").Append(Graphics).Append("\n");
      sb.Append("  IssuerId: ").Append(IssuerId).Append("\n");
      sb.Append("  MedalId: ").Append(MedalId).Append("\n");
      sb.Append("  Reason: ").Append(Reason).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
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
