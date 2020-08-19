using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// dogma_attribute object
  /// </summary>
  [DataContract]
  public class GetUniverseTypesTypeIdDogmaAttribute {
    /// <summary>
    /// attribute_id integer
    /// </summary>
    /// <value>attribute_id integer</value>
    [DataMember(Name="attribute_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attribute_id")]
    public int? AttributeId { get; set; }

    /// <summary>
    /// value number
    /// </summary>
    /// <value>value number</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public float? Value { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetUniverseTypesTypeIdDogmaAttribute {\n");
      sb.Append("  AttributeId: ").Append(AttributeId).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
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
