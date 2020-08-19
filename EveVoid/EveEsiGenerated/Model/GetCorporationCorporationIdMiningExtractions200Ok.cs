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
  public class GetCorporationCorporationIdMiningExtractions200Ok {
    /// <summary>
    /// The time at which the chunk being extracted will arrive and can be fractured by the moon mining drill. 
    /// </summary>
    /// <value>The time at which the chunk being extracted will arrive and can be fractured by the moon mining drill. </value>
    [DataMember(Name="chunk_arrival_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "chunk_arrival_time")]
    public DateTime? ChunkArrivalTime { get; set; }

    /// <summary>
    /// The time at which the current extraction was initiated. 
    /// </summary>
    /// <value>The time at which the current extraction was initiated. </value>
    [DataMember(Name="extraction_start_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "extraction_start_time")]
    public DateTime? ExtractionStartTime { get; set; }

    /// <summary>
    /// moon_id integer
    /// </summary>
    /// <value>moon_id integer</value>
    [DataMember(Name="moon_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "moon_id")]
    public int? MoonId { get; set; }

    /// <summary>
    /// The time at which the chunk being extracted will naturally fracture if it is not first fractured by the moon mining drill. 
    /// </summary>
    /// <value>The time at which the chunk being extracted will naturally fracture if it is not first fractured by the moon mining drill. </value>
    [DataMember(Name="natural_decay_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "natural_decay_time")]
    public DateTime? NaturalDecayTime { get; set; }

    /// <summary>
    /// structure_id integer
    /// </summary>
    /// <value>structure_id integer</value>
    [DataMember(Name="structure_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "structure_id")]
    public long? StructureId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCorporationCorporationIdMiningExtractions200Ok {\n");
      sb.Append("  ChunkArrivalTime: ").Append(ChunkArrivalTime).Append("\n");
      sb.Append("  ExtractionStartTime: ").Append(ExtractionStartTime).Append("\n");
      sb.Append("  MoonId: ").Append(MoonId).Append("\n");
      sb.Append("  NaturalDecayTime: ").Append(NaturalDecayTime).Append("\n");
      sb.Append("  StructureId: ").Append(StructureId).Append("\n");
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
