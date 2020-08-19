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
  public class GetCorporationsCorporationIdContacts200Ok {
    /// <summary>
    /// contact_id integer
    /// </summary>
    /// <value>contact_id integer</value>
    [DataMember(Name="contact_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contact_id")]
    public int? ContactId { get; set; }

    /// <summary>
    /// contact_type string
    /// </summary>
    /// <value>contact_type string</value>
    [DataMember(Name="contact_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contact_type")]
    public string ContactType { get; set; }

    /// <summary>
    /// Whether this contact is being watched
    /// </summary>
    /// <value>Whether this contact is being watched</value>
    [DataMember(Name="is_watched", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_watched")]
    public bool? IsWatched { get; set; }

    /// <summary>
    /// label_ids array
    /// </summary>
    /// <value>label_ids array</value>
    [DataMember(Name="label_ids", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "label_ids")]
    public List<long?> LabelIds { get; set; }

    /// <summary>
    /// Standing of the contact
    /// </summary>
    /// <value>Standing of the contact</value>
    [DataMember(Name="standing", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "standing")]
    public float? Standing { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCorporationsCorporationIdContacts200Ok {\n");
      sb.Append("  ContactId: ").Append(ContactId).Append("\n");
      sb.Append("  ContactType: ").Append(ContactType).Append("\n");
      sb.Append("  IsWatched: ").Append(IsWatched).Append("\n");
      sb.Append("  LabelIds: ").Append(LabelIds).Append("\n");
      sb.Append("  Standing: ").Append(Standing).Append("\n");
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
