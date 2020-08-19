using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// home_location object
  /// </summary>
  [DataContract]
  public class GetCharactersCharacterIdClonesHomeLocation {
    /// <summary>
    /// location_id integer
    /// </summary>
    /// <value>location_id integer</value>
    [DataMember(Name="location_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "location_id")]
    public long? LocationId { get; set; }

    /// <summary>
    /// location_type string
    /// </summary>
    /// <value>location_type string</value>
    [DataMember(Name="location_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "location_type")]
    public string LocationType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCharactersCharacterIdClonesHomeLocation {\n");
      sb.Append("  LocationId: ").Append(LocationId).Append("\n");
      sb.Append("  LocationType: ").Append(LocationType).Append("\n");
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
