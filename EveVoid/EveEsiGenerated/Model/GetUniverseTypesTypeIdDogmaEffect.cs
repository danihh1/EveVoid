using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// dogma_effect object
  /// </summary>
  [DataContract]
  public class GetUniverseTypesTypeIdDogmaEffect {
    /// <summary>
    /// effect_id integer
    /// </summary>
    /// <value>effect_id integer</value>
    [DataMember(Name="effect_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "effect_id")]
    public int? EffectId { get; set; }

    /// <summary>
    /// is_default boolean
    /// </summary>
    /// <value>is_default boolean</value>
    [DataMember(Name="is_default", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_default")]
    public bool? IsDefault { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetUniverseTypesTypeIdDogmaEffect {\n");
      sb.Append("  EffectId: ").Append(EffectId).Append("\n");
      sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
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
