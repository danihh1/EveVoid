using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 201 created object
  /// </summary>
  [DataContract]
  public class PostFleetsFleetIdWingsCreated {
    /// <summary>
    /// The wing_id of the newly created wing
    /// </summary>
    /// <value>The wing_id of the newly created wing</value>
    [DataMember(Name="wing_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "wing_id")]
    public long? WingId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PostFleetsFleetIdWingsCreated {\n");
      sb.Append("  WingId: ").Append(WingId).Append("\n");
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
