using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// character_id and response of an attendee
  /// </summary>
  [DataContract]
  public class GetCharactersCharacterIdCalendarEventIdAttendees200Ok {
    /// <summary>
    /// character_id integer
    /// </summary>
    /// <value>character_id integer</value>
    [DataMember(Name="character_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "character_id")]
    public int? CharacterId { get; set; }

    /// <summary>
    /// event_response string
    /// </summary>
    /// <value>event_response string</value>
    [DataMember(Name="event_response", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "event_response")]
    public string EventResponse { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCharactersCharacterIdCalendarEventIdAttendees200Ok {\n");
      sb.Append("  CharacterId: ").Append(CharacterId).Append("\n");
      sb.Append("  EventResponse: ").Append(EventResponse).Append("\n");
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
