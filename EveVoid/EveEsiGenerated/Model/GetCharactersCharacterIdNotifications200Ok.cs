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
  public class GetCharactersCharacterIdNotifications200Ok {
    /// <summary>
    /// is_read boolean
    /// </summary>
    /// <value>is_read boolean</value>
    [DataMember(Name="is_read", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_read")]
    public bool? IsRead { get; set; }

    /// <summary>
    /// notification_id integer
    /// </summary>
    /// <value>notification_id integer</value>
    [DataMember(Name="notification_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notification_id")]
    public long? NotificationId { get; set; }

    /// <summary>
    /// sender_id integer
    /// </summary>
    /// <value>sender_id integer</value>
    [DataMember(Name="sender_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sender_id")]
    public int? SenderId { get; set; }

    /// <summary>
    /// sender_type string
    /// </summary>
    /// <value>sender_type string</value>
    [DataMember(Name="sender_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sender_type")]
    public string SenderType { get; set; }

    /// <summary>
    /// text string
    /// </summary>
    /// <value>text string</value>
    [DataMember(Name="text", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "text")]
    public string Text { get; set; }

    /// <summary>
    /// timestamp string
    /// </summary>
    /// <value>timestamp string</value>
    [DataMember(Name="timestamp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timestamp")]
    public DateTime? Timestamp { get; set; }

    /// <summary>
    /// type string
    /// </summary>
    /// <value>type string</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCharactersCharacterIdNotifications200Ok {\n");
      sb.Append("  IsRead: ").Append(IsRead).Append("\n");
      sb.Append("  NotificationId: ").Append(NotificationId).Append("\n");
      sb.Append("  SenderId: ").Append(SenderId).Append("\n");
      sb.Append("  SenderType: ").Append(SenderType).Append("\n");
      sb.Append("  Text: ").Append(Text).Append("\n");
      sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
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
