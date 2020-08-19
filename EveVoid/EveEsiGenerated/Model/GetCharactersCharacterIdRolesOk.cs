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
  public class GetCharactersCharacterIdRolesOk {
    /// <summary>
    /// roles array
    /// </summary>
    /// <value>roles array</value>
    [DataMember(Name="roles", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "roles")]
    public List<string> Roles { get; set; }

    /// <summary>
    /// roles_at_base array
    /// </summary>
    /// <value>roles_at_base array</value>
    [DataMember(Name="roles_at_base", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "roles_at_base")]
    public List<string> RolesAtBase { get; set; }

    /// <summary>
    /// roles_at_hq array
    /// </summary>
    /// <value>roles_at_hq array</value>
    [DataMember(Name="roles_at_hq", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "roles_at_hq")]
    public List<string> RolesAtHq { get; set; }

    /// <summary>
    /// roles_at_other array
    /// </summary>
    /// <value>roles_at_other array</value>
    [DataMember(Name="roles_at_other", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "roles_at_other")]
    public List<string> RolesAtOther { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCharactersCharacterIdRolesOk {\n");
      sb.Append("  Roles: ").Append(Roles).Append("\n");
      sb.Append("  RolesAtBase: ").Append(RolesAtBase).Append("\n");
      sb.Append("  RolesAtHq: ").Append(RolesAtHq).Append("\n");
      sb.Append("  RolesAtOther: ").Append(RolesAtOther).Append("\n");
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
