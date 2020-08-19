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
  public class GetCorporationsCorporationIdShareholders200Ok {
    /// <summary>
    /// share_count integer
    /// </summary>
    /// <value>share_count integer</value>
    [DataMember(Name="share_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "share_count")]
    public long? ShareCount { get; set; }

    /// <summary>
    /// shareholder_id integer
    /// </summary>
    /// <value>shareholder_id integer</value>
    [DataMember(Name="shareholder_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shareholder_id")]
    public int? ShareholderId { get; set; }

    /// <summary>
    /// shareholder_type string
    /// </summary>
    /// <value>shareholder_type string</value>
    [DataMember(Name="shareholder_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shareholder_type")]
    public string ShareholderType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCorporationsCorporationIdShareholders200Ok {\n");
      sb.Append("  ShareCount: ").Append(ShareCount).Append("\n");
      sb.Append("  ShareholderId: ").Append(ShareholderId).Append("\n");
      sb.Append("  ShareholderType: ").Append(ShareholderType).Append("\n");
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
