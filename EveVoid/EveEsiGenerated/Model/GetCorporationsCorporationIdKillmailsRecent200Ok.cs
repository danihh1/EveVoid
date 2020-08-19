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
  public class GetCorporationsCorporationIdKillmailsRecent200Ok {
    /// <summary>
    /// A hash of this killmail
    /// </summary>
    /// <value>A hash of this killmail</value>
    [DataMember(Name="killmail_hash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "killmail_hash")]
    public string KillmailHash { get; set; }

    /// <summary>
    /// ID of this killmail
    /// </summary>
    /// <value>ID of this killmail</value>
    [DataMember(Name="killmail_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "killmail_id")]
    public int? KillmailId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCorporationsCorporationIdKillmailsRecent200Ok {\n");
      sb.Append("  KillmailHash: ").Append(KillmailHash).Append("\n");
      sb.Append("  KillmailId: ").Append(KillmailId).Append("\n");
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
