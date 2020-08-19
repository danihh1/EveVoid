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
  public class GetAlliancesAllianceIdContactsLabels200Ok {
    /// <summary>
    /// label_id integer
    /// </summary>
    /// <value>label_id integer</value>
    [DataMember(Name="label_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "label_id")]
    public long? LabelId { get; set; }

    /// <summary>
    /// label_name string
    /// </summary>
    /// <value>label_name string</value>
    [DataMember(Name="label_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "label_name")]
    public string LabelName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetAlliancesAllianceIdContactsLabels200Ok {\n");
      sb.Append("  LabelId: ").Append(LabelId).Append("\n");
      sb.Append("  LabelName: ").Append(LabelName).Append("\n");
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
