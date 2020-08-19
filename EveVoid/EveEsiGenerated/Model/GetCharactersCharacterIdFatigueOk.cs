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
  public class GetCharactersCharacterIdFatigueOk {
    /// <summary>
    /// Character's jump fatigue expiry
    /// </summary>
    /// <value>Character's jump fatigue expiry</value>
    [DataMember(Name="jump_fatigue_expire_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jump_fatigue_expire_date")]
    public DateTime? JumpFatigueExpireDate { get; set; }

    /// <summary>
    /// Character's last jump activation
    /// </summary>
    /// <value>Character's last jump activation</value>
    [DataMember(Name="last_jump_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last_jump_date")]
    public DateTime? LastJumpDate { get; set; }

    /// <summary>
    /// Character's last jump update
    /// </summary>
    /// <value>Character's last jump update</value>
    [DataMember(Name="last_update_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last_update_date")]
    public DateTime? LastUpdateDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCharactersCharacterIdFatigueOk {\n");
      sb.Append("  JumpFatigueExpireDate: ").Append(JumpFatigueExpireDate).Append("\n");
      sb.Append("  LastJumpDate: ").Append(LastJumpDate).Append("\n");
      sb.Append("  LastUpdateDate: ").Append(LastUpdateDate).Append("\n");
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
