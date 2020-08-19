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
  public class PostCharactersCharacterIdFittingsCreated {
    /// <summary>
    /// fitting_id integer
    /// </summary>
    /// <value>fitting_id integer</value>
    [DataMember(Name="fitting_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fitting_id")]
    public int? FittingId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PostCharactersCharacterIdFittingsCreated {\n");
      sb.Append("  FittingId: ").Append(FittingId).Append("\n");
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
