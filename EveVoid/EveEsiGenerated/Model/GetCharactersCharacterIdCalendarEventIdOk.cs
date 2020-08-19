using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Full details of a specific event
  /// </summary>
  [DataContract]
  public class GetCharactersCharacterIdCalendarEventIdOk {
    /// <summary>
    /// date string
    /// </summary>
    /// <value>date string</value>
    [DataMember(Name="date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date")]
    public DateTime? Date { get; set; }

    /// <summary>
    /// Length in minutes
    /// </summary>
    /// <value>Length in minutes</value>
    [DataMember(Name="duration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "duration")]
    public int? Duration { get; set; }

    /// <summary>
    /// event_id integer
    /// </summary>
    /// <value>event_id integer</value>
    [DataMember(Name="event_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "event_id")]
    public int? EventId { get; set; }

    /// <summary>
    /// importance integer
    /// </summary>
    /// <value>importance integer</value>
    [DataMember(Name="importance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "importance")]
    public int? Importance { get; set; }

    /// <summary>
    /// owner_id integer
    /// </summary>
    /// <value>owner_id integer</value>
    [DataMember(Name="owner_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "owner_id")]
    public int? OwnerId { get; set; }

    /// <summary>
    /// owner_name string
    /// </summary>
    /// <value>owner_name string</value>
    [DataMember(Name="owner_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "owner_name")]
    public string OwnerName { get; set; }

    /// <summary>
    /// owner_type string
    /// </summary>
    /// <value>owner_type string</value>
    [DataMember(Name="owner_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "owner_type")]
    public string OwnerType { get; set; }

    /// <summary>
    /// response string
    /// </summary>
    /// <value>response string</value>
    [DataMember(Name="response", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "response")]
    public string Response { get; set; }

    /// <summary>
    /// text string
    /// </summary>
    /// <value>text string</value>
    [DataMember(Name="text", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "text")]
    public string Text { get; set; }

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
      sb.Append("class GetCharactersCharacterIdCalendarEventIdOk {\n");
      sb.Append("  Date: ").Append(Date).Append("\n");
      sb.Append("  Duration: ").Append(Duration).Append("\n");
      sb.Append("  EventId: ").Append(EventId).Append("\n");
      sb.Append("  Importance: ").Append(Importance).Append("\n");
      sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
      sb.Append("  OwnerName: ").Append(OwnerName).Append("\n");
      sb.Append("  OwnerType: ").Append(OwnerType).Append("\n");
      sb.Append("  Response: ").Append(Response).Append("\n");
      sb.Append("  Text: ").Append(Text).Append("\n");
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
