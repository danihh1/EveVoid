using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// event
  /// </summary>
  [DataContract]
  public class GetCharactersCharacterIdCalendar200Ok {
    /// <summary>
    /// event_date string
    /// </summary>
    /// <value>event_date string</value>
    [DataMember(Name="event_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "event_date")]
    public DateTime? EventDate { get; set; }

    /// <summary>
    /// event_id integer
    /// </summary>
    /// <value>event_id integer</value>
    [DataMember(Name="event_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "event_id")]
    public int? EventId { get; set; }

    /// <summary>
    /// event_response string
    /// </summary>
    /// <value>event_response string</value>
    [DataMember(Name="event_response", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "event_response")]
    public string EventResponse { get; set; }

    /// <summary>
    /// importance integer
    /// </summary>
    /// <value>importance integer</value>
    [DataMember(Name="importance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "importance")]
    public int? Importance { get; set; }

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
      sb.Append("class GetCharactersCharacterIdCalendar200Ok {\n");
      sb.Append("  EventDate: ").Append(EventDate).Append("\n");
      sb.Append("  EventId: ").Append(EventId).Append("\n");
      sb.Append("  EventResponse: ").Append(EventResponse).Append("\n");
      sb.Append("  Importance: ").Append(Importance).Append("\n");
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
