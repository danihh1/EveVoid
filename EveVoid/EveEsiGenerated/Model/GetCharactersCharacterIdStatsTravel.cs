using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// travel object
  /// </summary>
  [DataContract]
  public class GetCharactersCharacterIdStatsTravel {
    /// <summary>
    /// acceleration_gate_activations integer
    /// </summary>
    /// <value>acceleration_gate_activations integer</value>
    [DataMember(Name="acceleration_gate_activations", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "acceleration_gate_activations")]
    public long? AccelerationGateActivations { get; set; }

    /// <summary>
    /// align_to integer
    /// </summary>
    /// <value>align_to integer</value>
    [DataMember(Name="align_to", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "align_to")]
    public long? AlignTo { get; set; }

    /// <summary>
    /// distance_warped_high_sec integer
    /// </summary>
    /// <value>distance_warped_high_sec integer</value>
    [DataMember(Name="distance_warped_high_sec", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "distance_warped_high_sec")]
    public long? DistanceWarpedHighSec { get; set; }

    /// <summary>
    /// distance_warped_low_sec integer
    /// </summary>
    /// <value>distance_warped_low_sec integer</value>
    [DataMember(Name="distance_warped_low_sec", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "distance_warped_low_sec")]
    public long? DistanceWarpedLowSec { get; set; }

    /// <summary>
    /// distance_warped_null_sec integer
    /// </summary>
    /// <value>distance_warped_null_sec integer</value>
    [DataMember(Name="distance_warped_null_sec", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "distance_warped_null_sec")]
    public long? DistanceWarpedNullSec { get; set; }

    /// <summary>
    /// distance_warped_wormhole integer
    /// </summary>
    /// <value>distance_warped_wormhole integer</value>
    [DataMember(Name="distance_warped_wormhole", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "distance_warped_wormhole")]
    public long? DistanceWarpedWormhole { get; set; }

    /// <summary>
    /// docks_high_sec integer
    /// </summary>
    /// <value>docks_high_sec integer</value>
    [DataMember(Name="docks_high_sec", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "docks_high_sec")]
    public long? DocksHighSec { get; set; }

    /// <summary>
    /// docks_low_sec integer
    /// </summary>
    /// <value>docks_low_sec integer</value>
    [DataMember(Name="docks_low_sec", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "docks_low_sec")]
    public long? DocksLowSec { get; set; }

    /// <summary>
    /// docks_null_sec integer
    /// </summary>
    /// <value>docks_null_sec integer</value>
    [DataMember(Name="docks_null_sec", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "docks_null_sec")]
    public long? DocksNullSec { get; set; }

    /// <summary>
    /// jumps_stargate_high_sec integer
    /// </summary>
    /// <value>jumps_stargate_high_sec integer</value>
    [DataMember(Name="jumps_stargate_high_sec", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jumps_stargate_high_sec")]
    public long? JumpsStargateHighSec { get; set; }

    /// <summary>
    /// jumps_stargate_low_sec integer
    /// </summary>
    /// <value>jumps_stargate_low_sec integer</value>
    [DataMember(Name="jumps_stargate_low_sec", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jumps_stargate_low_sec")]
    public long? JumpsStargateLowSec { get; set; }

    /// <summary>
    /// jumps_stargate_null_sec integer
    /// </summary>
    /// <value>jumps_stargate_null_sec integer</value>
    [DataMember(Name="jumps_stargate_null_sec", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jumps_stargate_null_sec")]
    public long? JumpsStargateNullSec { get; set; }

    /// <summary>
    /// jumps_wormhole integer
    /// </summary>
    /// <value>jumps_wormhole integer</value>
    [DataMember(Name="jumps_wormhole", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jumps_wormhole")]
    public long? JumpsWormhole { get; set; }

    /// <summary>
    /// warps_high_sec integer
    /// </summary>
    /// <value>warps_high_sec integer</value>
    [DataMember(Name="warps_high_sec", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "warps_high_sec")]
    public long? WarpsHighSec { get; set; }

    /// <summary>
    /// warps_low_sec integer
    /// </summary>
    /// <value>warps_low_sec integer</value>
    [DataMember(Name="warps_low_sec", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "warps_low_sec")]
    public long? WarpsLowSec { get; set; }

    /// <summary>
    /// warps_null_sec integer
    /// </summary>
    /// <value>warps_null_sec integer</value>
    [DataMember(Name="warps_null_sec", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "warps_null_sec")]
    public long? WarpsNullSec { get; set; }

    /// <summary>
    /// warps_to_bookmark integer
    /// </summary>
    /// <value>warps_to_bookmark integer</value>
    [DataMember(Name="warps_to_bookmark", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "warps_to_bookmark")]
    public long? WarpsToBookmark { get; set; }

    /// <summary>
    /// warps_to_celestial integer
    /// </summary>
    /// <value>warps_to_celestial integer</value>
    [DataMember(Name="warps_to_celestial", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "warps_to_celestial")]
    public long? WarpsToCelestial { get; set; }

    /// <summary>
    /// warps_to_fleet_member integer
    /// </summary>
    /// <value>warps_to_fleet_member integer</value>
    [DataMember(Name="warps_to_fleet_member", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "warps_to_fleet_member")]
    public long? WarpsToFleetMember { get; set; }

    /// <summary>
    /// warps_to_scan_result integer
    /// </summary>
    /// <value>warps_to_scan_result integer</value>
    [DataMember(Name="warps_to_scan_result", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "warps_to_scan_result")]
    public long? WarpsToScanResult { get; set; }

    /// <summary>
    /// warps_wormhole integer
    /// </summary>
    /// <value>warps_wormhole integer</value>
    [DataMember(Name="warps_wormhole", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "warps_wormhole")]
    public long? WarpsWormhole { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCharactersCharacterIdStatsTravel {\n");
      sb.Append("  AccelerationGateActivations: ").Append(AccelerationGateActivations).Append("\n");
      sb.Append("  AlignTo: ").Append(AlignTo).Append("\n");
      sb.Append("  DistanceWarpedHighSec: ").Append(DistanceWarpedHighSec).Append("\n");
      sb.Append("  DistanceWarpedLowSec: ").Append(DistanceWarpedLowSec).Append("\n");
      sb.Append("  DistanceWarpedNullSec: ").Append(DistanceWarpedNullSec).Append("\n");
      sb.Append("  DistanceWarpedWormhole: ").Append(DistanceWarpedWormhole).Append("\n");
      sb.Append("  DocksHighSec: ").Append(DocksHighSec).Append("\n");
      sb.Append("  DocksLowSec: ").Append(DocksLowSec).Append("\n");
      sb.Append("  DocksNullSec: ").Append(DocksNullSec).Append("\n");
      sb.Append("  JumpsStargateHighSec: ").Append(JumpsStargateHighSec).Append("\n");
      sb.Append("  JumpsStargateLowSec: ").Append(JumpsStargateLowSec).Append("\n");
      sb.Append("  JumpsStargateNullSec: ").Append(JumpsStargateNullSec).Append("\n");
      sb.Append("  JumpsWormhole: ").Append(JumpsWormhole).Append("\n");
      sb.Append("  WarpsHighSec: ").Append(WarpsHighSec).Append("\n");
      sb.Append("  WarpsLowSec: ").Append(WarpsLowSec).Append("\n");
      sb.Append("  WarpsNullSec: ").Append(WarpsNullSec).Append("\n");
      sb.Append("  WarpsToBookmark: ").Append(WarpsToBookmark).Append("\n");
      sb.Append("  WarpsToCelestial: ").Append(WarpsToCelestial).Append("\n");
      sb.Append("  WarpsToFleetMember: ").Append(WarpsToFleetMember).Append("\n");
      sb.Append("  WarpsToScanResult: ").Append(WarpsToScanResult).Append("\n");
      sb.Append("  WarpsWormhole: ").Append(WarpsWormhole).Append("\n");
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
