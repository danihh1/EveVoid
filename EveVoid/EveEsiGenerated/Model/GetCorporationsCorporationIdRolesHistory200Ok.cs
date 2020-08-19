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
  public class GetCorporationsCorporationIdRolesHistory200Ok {
    /// <summary>
    /// changed_at string
    /// </summary>
    /// <value>changed_at string</value>
    [DataMember(Name="changed_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "changed_at")]
    public DateTime? ChangedAt { get; set; }

    /// <summary>
    /// The character whose roles are changed
    /// </summary>
    /// <value>The character whose roles are changed</value>
    [DataMember(Name="character_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "character_id")]
    public int? CharacterId { get; set; }

    /// <summary>
    /// ID of the character who issued this change
    /// </summary>
    /// <value>ID of the character who issued this change</value>
    [DataMember(Name="issuer_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issuer_id")]
    public int? IssuerId { get; set; }

    /// <summary>
    /// new_roles array
    /// </summary>
    /// <value>new_roles array</value>
    [DataMember(Name="new_roles", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "new_roles")]
    public List<string> NewRoles { get; set; }

    /// <summary>
    /// old_roles array
    /// </summary>
    /// <value>old_roles array</value>
    [DataMember(Name="old_roles", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "old_roles")]
    public List<string> OldRoles { get; set; }

    /// <summary>
    /// role_type string
    /// </summary>
    /// <value>role_type string</value>
    [DataMember(Name="role_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "role_type")]
    public string RoleType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCorporationsCorporationIdRolesHistory200Ok {\n");
      sb.Append("  ChangedAt: ").Append(ChangedAt).Append("\n");
      sb.Append("  CharacterId: ").Append(CharacterId).Append("\n");
      sb.Append("  IssuerId: ").Append(IssuerId).Append("\n");
      sb.Append("  NewRoles: ").Append(NewRoles).Append("\n");
      sb.Append("  OldRoles: ").Append(OldRoles).Append("\n");
      sb.Append("  RoleType: ").Append(RoleType).Append("\n");
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
