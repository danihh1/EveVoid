using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// jump_clone object
  /// </summary>
  [DataContract]
  public class GetCharactersCharacterIdClonesJumpClone {
    /// <summary>
    /// implants array
    /// </summary>
    /// <value>implants array</value>
    [DataMember(Name="implants", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "implants")]
    public List<int?> Implants { get; set; }

    /// <summary>
    /// jump_clone_id integer
    /// </summary>
    /// <value>jump_clone_id integer</value>
    [DataMember(Name="jump_clone_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jump_clone_id")]
    public int? JumpCloneId { get; set; }

    /// <summary>
    /// location_id integer
    /// </summary>
    /// <value>location_id integer</value>
    [DataMember(Name="location_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "location_id")]
    public long? LocationId { get; set; }

    /// <summary>
    /// location_type string
    /// </summary>
    /// <value>location_type string</value>
    [DataMember(Name="location_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "location_type")]
    public string LocationType { get; set; }

    /// <summary>
    /// name string
    /// </summary>
    /// <value>name string</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCharactersCharacterIdClonesJumpClone {\n");
      sb.Append("  Implants: ").Append(Implants).Append("\n");
      sb.Append("  JumpCloneId: ").Append(JumpCloneId).Append("\n");
      sb.Append("  LocationId: ").Append(LocationId).Append("\n");
      sb.Append("  LocationType: ").Append(LocationType).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
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
