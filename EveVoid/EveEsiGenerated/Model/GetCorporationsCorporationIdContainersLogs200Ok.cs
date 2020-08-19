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
  public class GetCorporationsCorporationIdContainersLogs200Ok {
    /// <summary>
    /// action string
    /// </summary>
    /// <value>action string</value>
    [DataMember(Name="action", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "action")]
    public string Action { get; set; }

    /// <summary>
    /// ID of the character who performed the action.
    /// </summary>
    /// <value>ID of the character who performed the action.</value>
    [DataMember(Name="character_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "character_id")]
    public int? CharacterId { get; set; }

    /// <summary>
    /// ID of the container
    /// </summary>
    /// <value>ID of the container</value>
    [DataMember(Name="container_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "container_id")]
    public long? ContainerId { get; set; }

    /// <summary>
    /// Type ID of the container
    /// </summary>
    /// <value>Type ID of the container</value>
    [DataMember(Name="container_type_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "container_type_id")]
    public int? ContainerTypeId { get; set; }

    /// <summary>
    /// location_flag string
    /// </summary>
    /// <value>location_flag string</value>
    [DataMember(Name="location_flag", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "location_flag")]
    public string LocationFlag { get; set; }

    /// <summary>
    /// location_id integer
    /// </summary>
    /// <value>location_id integer</value>
    [DataMember(Name="location_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "location_id")]
    public long? LocationId { get; set; }

    /// <summary>
    /// Timestamp when this log was created
    /// </summary>
    /// <value>Timestamp when this log was created</value>
    [DataMember(Name="logged_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "logged_at")]
    public DateTime? LoggedAt { get; set; }

    /// <summary>
    /// new_config_bitmask integer
    /// </summary>
    /// <value>new_config_bitmask integer</value>
    [DataMember(Name="new_config_bitmask", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "new_config_bitmask")]
    public int? NewConfigBitmask { get; set; }

    /// <summary>
    /// old_config_bitmask integer
    /// </summary>
    /// <value>old_config_bitmask integer</value>
    [DataMember(Name="old_config_bitmask", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "old_config_bitmask")]
    public int? OldConfigBitmask { get; set; }

    /// <summary>
    /// Type of password set if action is of type SetPassword or EnterPassword
    /// </summary>
    /// <value>Type of password set if action is of type SetPassword or EnterPassword</value>
    [DataMember(Name="password_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "password_type")]
    public string PasswordType { get; set; }

    /// <summary>
    /// Quantity of the item being acted upon
    /// </summary>
    /// <value>Quantity of the item being acted upon</value>
    [DataMember(Name="quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quantity")]
    public int? Quantity { get; set; }

    /// <summary>
    /// Type ID of the item being acted upon
    /// </summary>
    /// <value>Type ID of the item being acted upon</value>
    [DataMember(Name="type_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type_id")]
    public int? TypeId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCorporationsCorporationIdContainersLogs200Ok {\n");
      sb.Append("  Action: ").Append(Action).Append("\n");
      sb.Append("  CharacterId: ").Append(CharacterId).Append("\n");
      sb.Append("  ContainerId: ").Append(ContainerId).Append("\n");
      sb.Append("  ContainerTypeId: ").Append(ContainerTypeId).Append("\n");
      sb.Append("  LocationFlag: ").Append(LocationFlag).Append("\n");
      sb.Append("  LocationId: ").Append(LocationId).Append("\n");
      sb.Append("  LoggedAt: ").Append(LoggedAt).Append("\n");
      sb.Append("  NewConfigBitmask: ").Append(NewConfigBitmask).Append("\n");
      sb.Append("  OldConfigBitmask: ").Append(OldConfigBitmask).Append("\n");
      sb.Append("  PasswordType: ").Append(PasswordType).Append("\n");
      sb.Append("  Quantity: ").Append(Quantity).Append("\n");
      sb.Append("  TypeId: ").Append(TypeId).Append("\n");
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
