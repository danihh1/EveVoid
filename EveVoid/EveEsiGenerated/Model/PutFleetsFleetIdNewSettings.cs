using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// new_settings object
  /// </summary>
  [DataContract]
  public class PutFleetsFleetIdNewSettings {
    /// <summary>
    /// Should free-move be enabled in the fleet
    /// </summary>
    /// <value>Should free-move be enabled in the fleet</value>
    [DataMember(Name="is_free_move", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_free_move")]
    public bool? IsFreeMove { get; set; }

    /// <summary>
    /// New fleet MOTD in CCP flavoured HTML
    /// </summary>
    /// <value>New fleet MOTD in CCP flavoured HTML</value>
    [DataMember(Name="motd", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "motd")]
    public string Motd { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PutFleetsFleetIdNewSettings {\n");
      sb.Append("  IsFreeMove: ").Append(IsFreeMove).Append("\n");
      sb.Append("  Motd: ").Append(Motd).Append("\n");
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
