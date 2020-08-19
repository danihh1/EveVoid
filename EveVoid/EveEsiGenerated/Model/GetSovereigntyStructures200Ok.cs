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
  public class GetSovereigntyStructures200Ok {
    /// <summary>
    /// The alliance that owns the structure. 
    /// </summary>
    /// <value>The alliance that owns the structure. </value>
    [DataMember(Name="alliance_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "alliance_id")]
    public int? AllianceId { get; set; }

    /// <summary>
    /// Solar system in which the structure is located. 
    /// </summary>
    /// <value>Solar system in which the structure is located. </value>
    [DataMember(Name="solar_system_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "solar_system_id")]
    public int? SolarSystemId { get; set; }

    /// <summary>
    /// Unique item ID for this structure.
    /// </summary>
    /// <value>Unique item ID for this structure.</value>
    [DataMember(Name="structure_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "structure_id")]
    public long? StructureId { get; set; }

    /// <summary>
    /// A reference to the type of structure this is. 
    /// </summary>
    /// <value>A reference to the type of structure this is. </value>
    [DataMember(Name="structure_type_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "structure_type_id")]
    public int? StructureTypeId { get; set; }

    /// <summary>
    /// The occupancy level for the next or current vulnerability window. This takes into account all development indexes and capital system bonuses. Also known as Activity Defense Multiplier from in the client. It increases the time that attackers must spend using their entosis links on the structure. 
    /// </summary>
    /// <value>The occupancy level for the next or current vulnerability window. This takes into account all development indexes and capital system bonuses. Also known as Activity Defense Multiplier from in the client. It increases the time that attackers must spend using their entosis links on the structure. </value>
    [DataMember(Name="vulnerability_occupancy_level", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vulnerability_occupancy_level")]
    public float? VulnerabilityOccupancyLevel { get; set; }

    /// <summary>
    /// The time at which the next or current vulnerability window ends. At the end of a vulnerability window the next window is recalculated and locked in along with the vulnerabilityOccupancyLevel. If the structure is not in 100% entosis control of the defender, it will go in to 'overtime' and stay vulnerable for as long as that situation persists. Only once the defenders have 100% entosis control and has the vulnerableEndTime passed does the vulnerability interval expire and a new one is calculated. 
    /// </summary>
    /// <value>The time at which the next or current vulnerability window ends. At the end of a vulnerability window the next window is recalculated and locked in along with the vulnerabilityOccupancyLevel. If the structure is not in 100% entosis control of the defender, it will go in to 'overtime' and stay vulnerable for as long as that situation persists. Only once the defenders have 100% entosis control and has the vulnerableEndTime passed does the vulnerability interval expire and a new one is calculated. </value>
    [DataMember(Name="vulnerable_end_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vulnerable_end_time")]
    public DateTime? VulnerableEndTime { get; set; }

    /// <summary>
    /// The next time at which the structure will become vulnerable. Or the start time of the current window if current time is between this and vulnerableEndTime. 
    /// </summary>
    /// <value>The next time at which the structure will become vulnerable. Or the start time of the current window if current time is between this and vulnerableEndTime. </value>
    [DataMember(Name="vulnerable_start_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vulnerable_start_time")]
    public DateTime? VulnerableStartTime { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetSovereigntyStructures200Ok {\n");
      sb.Append("  AllianceId: ").Append(AllianceId).Append("\n");
      sb.Append("  SolarSystemId: ").Append(SolarSystemId).Append("\n");
      sb.Append("  StructureId: ").Append(StructureId).Append("\n");
      sb.Append("  StructureTypeId: ").Append(StructureTypeId).Append("\n");
      sb.Append("  VulnerabilityOccupancyLevel: ").Append(VulnerabilityOccupancyLevel).Append("\n");
      sb.Append("  VulnerableEndTime: ").Append(VulnerableEndTime).Append("\n");
      sb.Append("  VulnerableStartTime: ").Append(VulnerableStartTime).Append("\n");
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
