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
  public class GetDogmaAttributesAttributeIdOk {
    /// <summary>
    /// attribute_id integer
    /// </summary>
    /// <value>attribute_id integer</value>
    [DataMember(Name="attribute_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attribute_id")]
    public int? AttributeId { get; set; }

    /// <summary>
    /// default_value number
    /// </summary>
    /// <value>default_value number</value>
    [DataMember(Name="default_value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "default_value")]
    public float? DefaultValue { get; set; }

    /// <summary>
    /// description string
    /// </summary>
    /// <value>description string</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// display_name string
    /// </summary>
    /// <value>display_name string</value>
    [DataMember(Name="display_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "display_name")]
    public string DisplayName { get; set; }

    /// <summary>
    /// high_is_good boolean
    /// </summary>
    /// <value>high_is_good boolean</value>
    [DataMember(Name="high_is_good", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "high_is_good")]
    public bool? HighIsGood { get; set; }

    /// <summary>
    /// icon_id integer
    /// </summary>
    /// <value>icon_id integer</value>
    [DataMember(Name="icon_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "icon_id")]
    public int? IconId { get; set; }

    /// <summary>
    /// name string
    /// </summary>
    /// <value>name string</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// published boolean
    /// </summary>
    /// <value>published boolean</value>
    [DataMember(Name="published", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "published")]
    public bool? Published { get; set; }

    /// <summary>
    /// stackable boolean
    /// </summary>
    /// <value>stackable boolean</value>
    [DataMember(Name="stackable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stackable")]
    public bool? Stackable { get; set; }

    /// <summary>
    /// unit_id integer
    /// </summary>
    /// <value>unit_id integer</value>
    [DataMember(Name="unit_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unit_id")]
    public int? UnitId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetDogmaAttributesAttributeIdOk {\n");
      sb.Append("  AttributeId: ").Append(AttributeId).Append("\n");
      sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  HighIsGood: ").Append(HighIsGood).Append("\n");
      sb.Append("  IconId: ").Append(IconId).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Published: ").Append(Published).Append("\n");
      sb.Append("  Stackable: ").Append(Stackable).Append("\n");
      sb.Append("  UnitId: ").Append(UnitId).Append("\n");
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
