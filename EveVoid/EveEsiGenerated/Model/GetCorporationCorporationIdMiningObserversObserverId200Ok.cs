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
  public class GetCorporationCorporationIdMiningObserversObserverId200Ok {
    /// <summary>
    /// The character that did the mining 
    /// </summary>
    /// <value>The character that did the mining </value>
    [DataMember(Name="character_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "character_id")]
    public int? CharacterId { get; set; }

    /// <summary>
    /// last_updated string
    /// </summary>
    /// <value>last_updated string</value>
    [DataMember(Name="last_updated", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last_updated")]
    public DateTime? LastUpdated { get; set; }

    /// <summary>
    /// quantity integer
    /// </summary>
    /// <value>quantity integer</value>
    [DataMember(Name="quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quantity")]
    public long? Quantity { get; set; }

    /// <summary>
    /// The corporation id of the character at the time data was recorded. 
    /// </summary>
    /// <value>The corporation id of the character at the time data was recorded. </value>
    [DataMember(Name="recorded_corporation_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recorded_corporation_id")]
    public int? RecordedCorporationId { get; set; }

    /// <summary>
    /// type_id integer
    /// </summary>
    /// <value>type_id integer</value>
    [DataMember(Name="type_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type_id")]
    public int? TypeId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCorporationCorporationIdMiningObserversObserverId200Ok {\n");
      sb.Append("  CharacterId: ").Append(CharacterId).Append("\n");
      sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
      sb.Append("  Quantity: ").Append(Quantity).Append("\n");
      sb.Append("  RecordedCorporationId: ").Append(RecordedCorporationId).Append("\n");
      sb.Append("  TypeId: ").Append(TypeId).Append("\n");
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
