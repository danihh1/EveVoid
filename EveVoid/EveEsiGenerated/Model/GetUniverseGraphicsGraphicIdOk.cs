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
  public class GetUniverseGraphicsGraphicIdOk {
    /// <summary>
    /// collision_file string
    /// </summary>
    /// <value>collision_file string</value>
    [DataMember(Name="collision_file", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "collision_file")]
    public string CollisionFile { get; set; }

    /// <summary>
    /// graphic_file string
    /// </summary>
    /// <value>graphic_file string</value>
    [DataMember(Name="graphic_file", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "graphic_file")]
    public string GraphicFile { get; set; }

    /// <summary>
    /// graphic_id integer
    /// </summary>
    /// <value>graphic_id integer</value>
    [DataMember(Name="graphic_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "graphic_id")]
    public int? GraphicId { get; set; }

    /// <summary>
    /// icon_folder string
    /// </summary>
    /// <value>icon_folder string</value>
    [DataMember(Name="icon_folder", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "icon_folder")]
    public string IconFolder { get; set; }

    /// <summary>
    /// sof_dna string
    /// </summary>
    /// <value>sof_dna string</value>
    [DataMember(Name="sof_dna", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sof_dna")]
    public string SofDna { get; set; }

    /// <summary>
    /// sof_fation_name string
    /// </summary>
    /// <value>sof_fation_name string</value>
    [DataMember(Name="sof_fation_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sof_fation_name")]
    public string SofFationName { get; set; }

    /// <summary>
    /// sof_hull_name string
    /// </summary>
    /// <value>sof_hull_name string</value>
    [DataMember(Name="sof_hull_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sof_hull_name")]
    public string SofHullName { get; set; }

    /// <summary>
    /// sof_race_name string
    /// </summary>
    /// <value>sof_race_name string</value>
    [DataMember(Name="sof_race_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sof_race_name")]
    public string SofRaceName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetUniverseGraphicsGraphicIdOk {\n");
      sb.Append("  CollisionFile: ").Append(CollisionFile).Append("\n");
      sb.Append("  GraphicFile: ").Append(GraphicFile).Append("\n");
      sb.Append("  GraphicId: ").Append(GraphicId).Append("\n");
      sb.Append("  IconFolder: ").Append(IconFolder).Append("\n");
      sb.Append("  SofDna: ").Append(SofDna).Append("\n");
      sb.Append("  SofFationName: ").Append(SofFationName).Append("\n");
      sb.Append("  SofHullName: ").Append(SofHullName).Append("\n");
      sb.Append("  SofRaceName: ").Append(SofRaceName).Append("\n");
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
