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
  public class GetDogmaEffectsEffectIdOk {
    /// <summary>
    /// description string
    /// </summary>
    /// <value>description string</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// disallow_auto_repeat boolean
    /// </summary>
    /// <value>disallow_auto_repeat boolean</value>
    [DataMember(Name="disallow_auto_repeat", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "disallow_auto_repeat")]
    public bool? DisallowAutoRepeat { get; set; }

    /// <summary>
    /// discharge_attribute_id integer
    /// </summary>
    /// <value>discharge_attribute_id integer</value>
    [DataMember(Name="discharge_attribute_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "discharge_attribute_id")]
    public int? DischargeAttributeId { get; set; }

    /// <summary>
    /// display_name string
    /// </summary>
    /// <value>display_name string</value>
    [DataMember(Name="display_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "display_name")]
    public string DisplayName { get; set; }

    /// <summary>
    /// duration_attribute_id integer
    /// </summary>
    /// <value>duration_attribute_id integer</value>
    [DataMember(Name="duration_attribute_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "duration_attribute_id")]
    public int? DurationAttributeId { get; set; }

    /// <summary>
    /// effect_category integer
    /// </summary>
    /// <value>effect_category integer</value>
    [DataMember(Name="effect_category", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "effect_category")]
    public int? EffectCategory { get; set; }

    /// <summary>
    /// effect_id integer
    /// </summary>
    /// <value>effect_id integer</value>
    [DataMember(Name="effect_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "effect_id")]
    public int? EffectId { get; set; }

    /// <summary>
    /// electronic_chance boolean
    /// </summary>
    /// <value>electronic_chance boolean</value>
    [DataMember(Name="electronic_chance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "electronic_chance")]
    public bool? ElectronicChance { get; set; }

    /// <summary>
    /// falloff_attribute_id integer
    /// </summary>
    /// <value>falloff_attribute_id integer</value>
    [DataMember(Name="falloff_attribute_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "falloff_attribute_id")]
    public int? FalloffAttributeId { get; set; }

    /// <summary>
    /// icon_id integer
    /// </summary>
    /// <value>icon_id integer</value>
    [DataMember(Name="icon_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "icon_id")]
    public int? IconId { get; set; }

    /// <summary>
    /// is_assistance boolean
    /// </summary>
    /// <value>is_assistance boolean</value>
    [DataMember(Name="is_assistance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_assistance")]
    public bool? IsAssistance { get; set; }

    /// <summary>
    /// is_offensive boolean
    /// </summary>
    /// <value>is_offensive boolean</value>
    [DataMember(Name="is_offensive", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_offensive")]
    public bool? IsOffensive { get; set; }

    /// <summary>
    /// is_warp_safe boolean
    /// </summary>
    /// <value>is_warp_safe boolean</value>
    [DataMember(Name="is_warp_safe", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_warp_safe")]
    public bool? IsWarpSafe { get; set; }

    /// <summary>
    /// modifiers array
    /// </summary>
    /// <value>modifiers array</value>
    [DataMember(Name="modifiers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "modifiers")]
    public List<GetDogmaEffectsEffectIdModifier> Modifiers { get; set; }

    /// <summary>
    /// name string
    /// </summary>
    /// <value>name string</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// post_expression integer
    /// </summary>
    /// <value>post_expression integer</value>
    [DataMember(Name="post_expression", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "post_expression")]
    public int? PostExpression { get; set; }

    /// <summary>
    /// pre_expression integer
    /// </summary>
    /// <value>pre_expression integer</value>
    [DataMember(Name="pre_expression", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pre_expression")]
    public int? PreExpression { get; set; }

    /// <summary>
    /// published boolean
    /// </summary>
    /// <value>published boolean</value>
    [DataMember(Name="published", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "published")]
    public bool? Published { get; set; }

    /// <summary>
    /// range_attribute_id integer
    /// </summary>
    /// <value>range_attribute_id integer</value>
    [DataMember(Name="range_attribute_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "range_attribute_id")]
    public int? RangeAttributeId { get; set; }

    /// <summary>
    /// range_chance boolean
    /// </summary>
    /// <value>range_chance boolean</value>
    [DataMember(Name="range_chance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "range_chance")]
    public bool? RangeChance { get; set; }

    /// <summary>
    /// tracking_speed_attribute_id integer
    /// </summary>
    /// <value>tracking_speed_attribute_id integer</value>
    [DataMember(Name="tracking_speed_attribute_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tracking_speed_attribute_id")]
    public int? TrackingSpeedAttributeId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetDogmaEffectsEffectIdOk {\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  DisallowAutoRepeat: ").Append(DisallowAutoRepeat).Append("\n");
      sb.Append("  DischargeAttributeId: ").Append(DischargeAttributeId).Append("\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  DurationAttributeId: ").Append(DurationAttributeId).Append("\n");
      sb.Append("  EffectCategory: ").Append(EffectCategory).Append("\n");
      sb.Append("  EffectId: ").Append(EffectId).Append("\n");
      sb.Append("  ElectronicChance: ").Append(ElectronicChance).Append("\n");
      sb.Append("  FalloffAttributeId: ").Append(FalloffAttributeId).Append("\n");
      sb.Append("  IconId: ").Append(IconId).Append("\n");
      sb.Append("  IsAssistance: ").Append(IsAssistance).Append("\n");
      sb.Append("  IsOffensive: ").Append(IsOffensive).Append("\n");
      sb.Append("  IsWarpSafe: ").Append(IsWarpSafe).Append("\n");
      sb.Append("  Modifiers: ").Append(Modifiers).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  PostExpression: ").Append(PostExpression).Append("\n");
      sb.Append("  PreExpression: ").Append(PreExpression).Append("\n");
      sb.Append("  Published: ").Append(Published).Append("\n");
      sb.Append("  RangeAttributeId: ").Append(RangeAttributeId).Append("\n");
      sb.Append("  RangeChance: ").Append(RangeChance).Append("\n");
      sb.Append("  TrackingSpeedAttributeId: ").Append(TrackingSpeedAttributeId).Append("\n");
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
