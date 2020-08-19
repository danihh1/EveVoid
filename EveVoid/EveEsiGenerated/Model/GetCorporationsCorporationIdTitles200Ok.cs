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
  public class GetCorporationsCorporationIdTitles200Ok {
    /// <summary>
    /// grantable_roles array
    /// </summary>
    /// <value>grantable_roles array</value>
    [DataMember(Name="grantable_roles", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "grantable_roles")]
    public List<string> GrantableRoles { get; set; }

    /// <summary>
    /// grantable_roles_at_base array
    /// </summary>
    /// <value>grantable_roles_at_base array</value>
    [DataMember(Name="grantable_roles_at_base", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "grantable_roles_at_base")]
    public List<string> GrantableRolesAtBase { get; set; }

    /// <summary>
    /// grantable_roles_at_hq array
    /// </summary>
    /// <value>grantable_roles_at_hq array</value>
    [DataMember(Name="grantable_roles_at_hq", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "grantable_roles_at_hq")]
    public List<string> GrantableRolesAtHq { get; set; }

    /// <summary>
    /// grantable_roles_at_other array
    /// </summary>
    /// <value>grantable_roles_at_other array</value>
    [DataMember(Name="grantable_roles_at_other", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "grantable_roles_at_other")]
    public List<string> GrantableRolesAtOther { get; set; }

    /// <summary>
    /// name string
    /// </summary>
    /// <value>name string</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

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
    /// title_id integer
    /// </summary>
    /// <value>title_id integer</value>
    [DataMember(Name="title_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title_id")]
    public int? TitleId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCorporationsCorporationIdTitles200Ok {\n");
      sb.Append("  GrantableRoles: ").Append(GrantableRoles).Append("\n");
      sb.Append("  GrantableRolesAtBase: ").Append(GrantableRolesAtBase).Append("\n");
      sb.Append("  GrantableRolesAtHq: ").Append(GrantableRolesAtHq).Append("\n");
      sb.Append("  GrantableRolesAtOther: ").Append(GrantableRolesAtOther).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Roles: ").Append(Roles).Append("\n");
      sb.Append("  RolesAtBase: ").Append(RolesAtBase).Append("\n");
      sb.Append("  RolesAtHq: ").Append(RolesAtHq).Append("\n");
      sb.Append("  RolesAtOther: ").Append(RolesAtOther).Append("\n");
      sb.Append("  TitleId: ").Append(TitleId).Append("\n");
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
