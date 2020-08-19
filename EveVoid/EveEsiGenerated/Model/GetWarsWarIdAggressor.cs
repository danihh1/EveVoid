using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// The aggressor corporation or alliance that declared this war, only contains either corporation_id or alliance_id
  /// </summary>
  [DataContract]
  public class GetWarsWarIdAggressor {
    /// <summary>
    /// Alliance ID if and only if the aggressor is an alliance
    /// </summary>
    /// <value>Alliance ID if and only if the aggressor is an alliance</value>
    [DataMember(Name="alliance_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "alliance_id")]
    public int? AllianceId { get; set; }

    /// <summary>
    /// Corporation ID if and only if the aggressor is a corporation
    /// </summary>
    /// <value>Corporation ID if and only if the aggressor is a corporation</value>
    [DataMember(Name="corporation_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "corporation_id")]
    public int? CorporationId { get; set; }

    /// <summary>
    /// ISK value of ships the aggressor has destroyed
    /// </summary>
    /// <value>ISK value of ships the aggressor has destroyed</value>
    [DataMember(Name="isk_destroyed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isk_destroyed")]
    public float? IskDestroyed { get; set; }

    /// <summary>
    /// The number of ships the aggressor has killed
    /// </summary>
    /// <value>The number of ships the aggressor has killed</value>
    [DataMember(Name="ships_killed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ships_killed")]
    public int? ShipsKilled { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetWarsWarIdAggressor {\n");
      sb.Append("  AllianceId: ").Append(AllianceId).Append("\n");
      sb.Append("  CorporationId: ").Append(CorporationId).Append("\n");
      sb.Append("  IskDestroyed: ").Append(IskDestroyed).Append("\n");
      sb.Append("  ShipsKilled: ").Append(ShipsKilled).Append("\n");
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
