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
  public class GetDogmaDynamicItemsTypeIdItemIdOk {
    /// <summary>
    /// The ID of the character who created the item
    /// </summary>
    /// <value>The ID of the character who created the item</value>
    [DataMember(Name="created_by", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_by")]
    public int? CreatedBy { get; set; }

    /// <summary>
    /// dogma_attributes array
    /// </summary>
    /// <value>dogma_attributes array</value>
    [DataMember(Name="dogma_attributes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dogma_attributes")]
    public List<GetDogmaDynamicItemsTypeIdItemIdDogmaAttribute> DogmaAttributes { get; set; }

    /// <summary>
    /// dogma_effects array
    /// </summary>
    /// <value>dogma_effects array</value>
    [DataMember(Name="dogma_effects", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dogma_effects")]
    public List<GetDogmaDynamicItemsTypeIdItemIdDogmaEffect> DogmaEffects { get; set; }

    /// <summary>
    /// The type ID of the mutator used to generate the dynamic item.
    /// </summary>
    /// <value>The type ID of the mutator used to generate the dynamic item.</value>
    [DataMember(Name="mutator_type_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mutator_type_id")]
    public int? MutatorTypeId { get; set; }

    /// <summary>
    /// The type ID of the source item the mutator was applied to create the dynamic item.
    /// </summary>
    /// <value>The type ID of the source item the mutator was applied to create the dynamic item.</value>
    [DataMember(Name="source_type_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "source_type_id")]
    public int? SourceTypeId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetDogmaDynamicItemsTypeIdItemIdOk {\n");
      sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
      sb.Append("  DogmaAttributes: ").Append(DogmaAttributes).Append("\n");
      sb.Append("  DogmaEffects: ").Append(DogmaEffects).Append("\n");
      sb.Append("  MutatorTypeId: ").Append(MutatorTypeId).Append("\n");
      sb.Append("  SourceTypeId: ").Append(SourceTypeId).Append("\n");
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
