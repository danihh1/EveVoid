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
  public class GetCharactersCharacterIdMail200Ok {
    /// <summary>
    /// From whom the mail was sent
    /// </summary>
    /// <value>From whom the mail was sent</value>
    [DataMember(Name="from", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "from")]
    public int? From { get; set; }

    /// <summary>
    /// is_read boolean
    /// </summary>
    /// <value>is_read boolean</value>
    [DataMember(Name="is_read", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_read")]
    public bool? IsRead { get; set; }

    /// <summary>
    /// labels array
    /// </summary>
    /// <value>labels array</value>
    [DataMember(Name="labels", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "labels")]
    public List<int?> Labels { get; set; }

    /// <summary>
    /// mail_id integer
    /// </summary>
    /// <value>mail_id integer</value>
    [DataMember(Name="mail_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mail_id")]
    public int? MailId { get; set; }

    /// <summary>
    /// Recipients of the mail
    /// </summary>
    /// <value>Recipients of the mail</value>
    [DataMember(Name="recipients", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recipients")]
    public List<GetCharactersCharacterIdMailRecipient> Recipients { get; set; }

    /// <summary>
    /// Mail subject
    /// </summary>
    /// <value>Mail subject</value>
    [DataMember(Name="subject", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subject")]
    public string Subject { get; set; }

    /// <summary>
    /// When the mail was sent
    /// </summary>
    /// <value>When the mail was sent</value>
    [DataMember(Name="timestamp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timestamp")]
    public DateTime? Timestamp { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCharactersCharacterIdMail200Ok {\n");
      sb.Append("  From: ").Append(From).Append("\n");
      sb.Append("  IsRead: ").Append(IsRead).Append("\n");
      sb.Append("  Labels: ").Append(Labels).Append("\n");
      sb.Append("  MailId: ").Append(MailId).Append("\n");
      sb.Append("  Recipients: ").Append(Recipients).Append("\n");
      sb.Append("  Subject: ").Append(Subject).Append("\n");
      sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
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
