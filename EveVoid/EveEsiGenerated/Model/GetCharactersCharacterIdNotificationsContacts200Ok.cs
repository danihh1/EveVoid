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
  public class GetCharactersCharacterIdNotificationsContacts200Ok {
    /// <summary>
    /// message string
    /// </summary>
    /// <value>message string</value>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }

    /// <summary>
    /// notification_id integer
    /// </summary>
    /// <value>notification_id integer</value>
    [DataMember(Name="notification_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notification_id")]
    public int? NotificationId { get; set; }

    /// <summary>
    /// send_date string
    /// </summary>
    /// <value>send_date string</value>
    [DataMember(Name="send_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "send_date")]
    public DateTime? SendDate { get; set; }

    /// <summary>
    /// sender_character_id integer
    /// </summary>
    /// <value>sender_character_id integer</value>
    [DataMember(Name="sender_character_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sender_character_id")]
    public int? SenderCharacterId { get; set; }

    /// <summary>
    /// A number representing the standing level the receiver has been added at by the sender. The standing levels are as follows: -10 -> Terrible | -5 -> Bad |  0 -> Neutral |  5 -> Good |  10 -> Excellent
    /// </summary>
    /// <value>A number representing the standing level the receiver has been added at by the sender. The standing levels are as follows: -10 -> Terrible | -5 -> Bad |  0 -> Neutral |  5 -> Good |  10 -> Excellent</value>
    [DataMember(Name="standing_level", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "standing_level")]
    public float? StandingLevel { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCharactersCharacterIdNotificationsContacts200Ok {\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
      sb.Append("  NotificationId: ").Append(NotificationId).Append("\n");
      sb.Append("  SendDate: ").Append(SendDate).Append("\n");
      sb.Append("  SenderCharacterId: ").Append(SenderCharacterId).Append("\n");
      sb.Append("  StandingLevel: ").Append(StandingLevel).Append("\n");
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
