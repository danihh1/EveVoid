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
  public class GetCorporationCorporationIdMiningObservers200Ok {
    /// <summary>
    /// last_updated string
    /// </summary>
    /// <value>last_updated string</value>
    [DataMember(Name="last_updated", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last_updated")]
    public DateTime? LastUpdated { get; set; }

    /// <summary>
    /// The entity that was observing the asteroid field when it was mined. 
    /// </summary>
    /// <value>The entity that was observing the asteroid field when it was mined. </value>
    [DataMember(Name="observer_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "observer_id")]
    public long? ObserverId { get; set; }

    /// <summary>
    /// The category of the observing entity
    /// </summary>
    /// <value>The category of the observing entity</value>
    [DataMember(Name="observer_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "observer_type")]
    public string ObserverType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCorporationCorporationIdMiningObservers200Ok {\n");
      sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
      sb.Append("  ObserverId: ").Append(ObserverId).Append("\n");
      sb.Append("  ObserverType: ").Append(ObserverType).Append("\n");
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
