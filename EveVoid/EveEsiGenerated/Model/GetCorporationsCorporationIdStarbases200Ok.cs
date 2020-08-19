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
  public class GetCorporationsCorporationIdStarbases200Ok {
    /// <summary>
    /// The moon this starbase (POS) is anchored on, unanchored POSes do not have this information
    /// </summary>
    /// <value>The moon this starbase (POS) is anchored on, unanchored POSes do not have this information</value>
    [DataMember(Name="moon_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "moon_id")]
    public int? MoonId { get; set; }

    /// <summary>
    /// When the POS onlined, for starbases (POSes) in online state
    /// </summary>
    /// <value>When the POS onlined, for starbases (POSes) in online state</value>
    [DataMember(Name="onlined_since", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "onlined_since")]
    public DateTime? OnlinedSince { get; set; }

    /// <summary>
    /// When the POS will be out of reinforcement, for starbases (POSes) in reinforced state
    /// </summary>
    /// <value>When the POS will be out of reinforcement, for starbases (POSes) in reinforced state</value>
    [DataMember(Name="reinforced_until", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reinforced_until")]
    public DateTime? ReinforcedUntil { get; set; }

    /// <summary>
    /// Unique ID for this starbase (POS)
    /// </summary>
    /// <value>Unique ID for this starbase (POS)</value>
    [DataMember(Name="starbase_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "starbase_id")]
    public long? StarbaseId { get; set; }

    /// <summary>
    /// state string
    /// </summary>
    /// <value>state string</value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// The solar system this starbase (POS) is in, unanchored POSes have this information
    /// </summary>
    /// <value>The solar system this starbase (POS) is in, unanchored POSes have this information</value>
    [DataMember(Name="system_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "system_id")]
    public int? SystemId { get; set; }

    /// <summary>
    /// Starbase (POS) type
    /// </summary>
    /// <value>Starbase (POS) type</value>
    [DataMember(Name="type_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type_id")]
    public int? TypeId { get; set; }

    /// <summary>
    /// When the POS started unanchoring, for starbases (POSes) in unanchoring state
    /// </summary>
    /// <value>When the POS started unanchoring, for starbases (POSes) in unanchoring state</value>
    [DataMember(Name="unanchor_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unanchor_at")]
    public DateTime? UnanchorAt { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCorporationsCorporationIdStarbases200Ok {\n");
      sb.Append("  MoonId: ").Append(MoonId).Append("\n");
      sb.Append("  OnlinedSince: ").Append(OnlinedSince).Append("\n");
      sb.Append("  ReinforcedUntil: ").Append(ReinforcedUntil).Append("\n");
      sb.Append("  StarbaseId: ").Append(StarbaseId).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  SystemId: ").Append(SystemId).Append("\n");
      sb.Append("  TypeId: ").Append(TypeId).Append("\n");
      sb.Append("  UnanchorAt: ").Append(UnanchorAt).Append("\n");
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
