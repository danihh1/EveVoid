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
  public class PostFleetsFleetIdWingsWingIdSquadsCreated {
    /// <summary>
    /// The squad_id of the newly created squad
    /// </summary>
    /// <value>The squad_id of the newly created squad</value>
    [DataMember(Name="squad_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "squad_id")]
    public long? SquadId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PostFleetsFleetIdWingsWingIdSquadsCreated {\n");
      sb.Append("  SquadId: ").Append(SquadId).Append("\n");
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
