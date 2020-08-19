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
  public class GetCorporationsCorporationIdStandings200Ok {
    /// <summary>
    /// from_id integer
    /// </summary>
    /// <value>from_id integer</value>
    [DataMember(Name="from_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "from_id")]
    public int? FromId { get; set; }

    /// <summary>
    /// from_type string
    /// </summary>
    /// <value>from_type string</value>
    [DataMember(Name="from_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "from_type")]
    public string FromType { get; set; }

    /// <summary>
    /// standing number
    /// </summary>
    /// <value>standing number</value>
    [DataMember(Name="standing", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "standing")]
    public float? Standing { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCorporationsCorporationIdStandings200Ok {\n");
      sb.Append("  FromId: ").Append(FromId).Append("\n");
      sb.Append("  FromType: ").Append(FromType).Append("\n");
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
