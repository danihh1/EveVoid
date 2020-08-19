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
  public class GetCharactersCharacterIdOnlineOk {
    /// <summary>
    /// Timestamp of the last login
    /// </summary>
    /// <value>Timestamp of the last login</value>
    [DataMember(Name="last_login", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last_login")]
    public DateTime? LastLogin { get; set; }

    /// <summary>
    /// Timestamp of the last logout
    /// </summary>
    /// <value>Timestamp of the last logout</value>
    [DataMember(Name="last_logout", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last_logout")]
    public DateTime? LastLogout { get; set; }

    /// <summary>
    /// Total number of times the character has logged in
    /// </summary>
    /// <value>Total number of times the character has logged in</value>
    [DataMember(Name="logins", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "logins")]
    public int? Logins { get; set; }

    /// <summary>
    /// If the character is online
    /// </summary>
    /// <value>If the character is online</value>
    [DataMember(Name="online", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "online")]
    public bool? Online { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCharactersCharacterIdOnlineOk {\n");
      sb.Append("  LastLogin: ").Append(LastLogin).Append("\n");
      sb.Append("  LastLogout: ").Append(LastLogout).Append("\n");
      sb.Append("  Logins: ").Append(Logins).Append("\n");
      sb.Append("  Online: ").Append(Online).Append("\n");
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
