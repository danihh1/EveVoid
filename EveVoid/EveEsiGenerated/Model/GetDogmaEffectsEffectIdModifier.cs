using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// modifier object
  /// </summary>
  [DataContract]
  public class GetDogmaEffectsEffectIdModifier {
    /// <summary>
    /// domain string
    /// </summary>
    /// <value>domain string</value>
    [DataMember(Name="domain", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "domain")]
    public string Domain { get; set; }

    /// <summary>
    /// effect_id integer
    /// </summary>
    /// <value>effect_id integer</value>
    [DataMember(Name="effect_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "effect_id")]
    public int? EffectId { get; set; }

    /// <summary>
    /// func string
    /// </summary>
    /// <value>func string</value>
    [DataMember(Name="func", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "func")]
    public string Func { get; set; }

    /// <summary>
    /// modified_attribute_id integer
    /// </summary>
    /// <value>modified_attribute_id integer</value>
    [DataMember(Name="modified_attribute_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "modified_attribute_id")]
    public int? ModifiedAttributeId { get; set; }

    /// <summary>
    /// modifying_attribute_id integer
    /// </summary>
    /// <value>modifying_attribute_id integer</value>
    [DataMember(Name="modifying_attribute_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "modifying_attribute_id")]
    public int? ModifyingAttributeId { get; set; }

    /// <summary>
    /// operator integer
    /// </summary>
    /// <value>operator integer</value>
    [DataMember(Name="operator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "operator")]
    public int? Operator { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetDogmaEffectsEffectIdModifier {\n");
      sb.Append("  Domain: ").Append(Domain).Append("\n");
      sb.Append("  EffectId: ").Append(EffectId).Append("\n");
      sb.Append("  Func: ").Append(Func).Append("\n");
      sb.Append("  ModifiedAttributeId: ").Append(ModifiedAttributeId).Append("\n");
      sb.Append("  ModifyingAttributeId: ").Append(ModifyingAttributeId).Append("\n");
      sb.Append("  Operator: ").Append(Operator).Append("\n");
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
