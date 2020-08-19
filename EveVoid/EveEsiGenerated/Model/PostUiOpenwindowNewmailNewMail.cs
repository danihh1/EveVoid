using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// new_mail object
  /// </summary>
  [DataContract]
  public class PostUiOpenwindowNewmailNewMail {
    /// <summary>
    /// body string
    /// </summary>
    /// <value>body string</value>
    [DataMember(Name="body", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "body")]
    public string Body { get; set; }

    /// <summary>
    /// recipients array
    /// </summary>
    /// <value>recipients array</value>
    [DataMember(Name="recipients", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recipients")]
    public List<int?> Recipients { get; set; }

    /// <summary>
    /// subject string
    /// </summary>
    /// <value>subject string</value>
    [DataMember(Name="subject", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subject")]
    public string Subject { get; set; }

    /// <summary>
    /// to_corp_or_alliance_id integer
    /// </summary>
    /// <value>to_corp_or_alliance_id integer</value>
    [DataMember(Name="to_corp_or_alliance_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "to_corp_or_alliance_id")]
    public int? ToCorpOrAllianceId { get; set; }

    /// <summary>
    /// Corporations, alliances and mailing lists are all types of mailing groups. You may only send to one mailing group, at a time, so you may fill out either this field or the to_corp_or_alliance_ids field
    /// </summary>
    /// <value>Corporations, alliances and mailing lists are all types of mailing groups. You may only send to one mailing group, at a time, so you may fill out either this field or the to_corp_or_alliance_ids field</value>
    [DataMember(Name="to_mailing_list_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "to_mailing_list_id")]
    public int? ToMailingListId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PostUiOpenwindowNewmailNewMail {\n");
      sb.Append("  Body: ").Append(Body).Append("\n");
      sb.Append("  Recipients: ").Append(Recipients).Append("\n");
      sb.Append("  Subject: ").Append(Subject).Append("\n");
      sb.Append("  ToCorpOrAllianceId: ").Append(ToCorpOrAllianceId).Append("\n");
      sb.Append("  ToMailingListId: ").Append(ToMailingListId).Append("\n");
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
