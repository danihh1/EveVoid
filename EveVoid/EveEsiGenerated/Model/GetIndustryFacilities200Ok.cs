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
  public class GetIndustryFacilities200Ok {
    /// <summary>
    /// ID of the facility
    /// </summary>
    /// <value>ID of the facility</value>
    [DataMember(Name="facility_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "facility_id")]
    public long? FacilityId { get; set; }

    /// <summary>
    /// Owner of the facility
    /// </summary>
    /// <value>Owner of the facility</value>
    [DataMember(Name="owner_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "owner_id")]
    public int? OwnerId { get; set; }

    /// <summary>
    /// Region ID where the facility is
    /// </summary>
    /// <value>Region ID where the facility is</value>
    [DataMember(Name="region_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "region_id")]
    public int? RegionId { get; set; }

    /// <summary>
    /// Solar system ID where the facility is
    /// </summary>
    /// <value>Solar system ID where the facility is</value>
    [DataMember(Name="solar_system_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "solar_system_id")]
    public int? SolarSystemId { get; set; }

    /// <summary>
    /// Tax imposed by the facility
    /// </summary>
    /// <value>Tax imposed by the facility</value>
    [DataMember(Name="tax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tax")]
    public float? Tax { get; set; }

    /// <summary>
    /// Type ID of the facility
    /// </summary>
    /// <value>Type ID of the facility</value>
    [DataMember(Name="type_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type_id")]
    public int? TypeId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetIndustryFacilities200Ok {\n");
      sb.Append("  FacilityId: ").Append(FacilityId).Append("\n");
      sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
      sb.Append("  RegionId: ").Append(RegionId).Append("\n");
      sb.Append("  SolarSystemId: ").Append(SolarSystemId).Append("\n");
      sb.Append("  Tax: ").Append(Tax).Append("\n");
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
