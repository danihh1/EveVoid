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
  public class GetFleetsFleetIdOk {
    /// <summary>
    /// Is free-move enabled
    /// </summary>
    /// <value>Is free-move enabled</value>
    [DataMember(Name="is_free_move", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_free_move")]
    public bool? IsFreeMove { get; set; }

    /// <summary>
    /// Does the fleet have an active fleet advertisement
    /// </summary>
    /// <value>Does the fleet have an active fleet advertisement</value>
    [DataMember(Name="is_registered", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_registered")]
    public bool? IsRegistered { get; set; }

    /// <summary>
    /// Is EVE Voice enabled
    /// </summary>
    /// <value>Is EVE Voice enabled</value>
    [DataMember(Name="is_voice_enabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_voice_enabled")]
    public bool? IsVoiceEnabled { get; set; }

    /// <summary>
    /// Fleet MOTD in CCP flavoured HTML
    /// </summary>
    /// <value>Fleet MOTD in CCP flavoured HTML</value>
    [DataMember(Name="motd", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "motd")]
    public string Motd { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetFleetsFleetIdOk {\n");
      sb.Append("  IsFreeMove: ").Append(IsFreeMove).Append("\n");
      sb.Append("  IsRegistered: ").Append(IsRegistered).Append("\n");
      sb.Append("  IsVoiceEnabled: ").Append(IsVoiceEnabled).Append("\n");
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
