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
  public class GetUniverseFactions200Ok {
    /// <summary>
    /// corporation_id integer
    /// </summary>
    /// <value>corporation_id integer</value>
    [DataMember(Name="corporation_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "corporation_id")]
    public int? CorporationId { get; set; }

    /// <summary>
    /// description string
    /// </summary>
    /// <value>description string</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// faction_id integer
    /// </summary>
    /// <value>faction_id integer</value>
    [DataMember(Name="faction_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "faction_id")]
    public int? FactionId { get; set; }

    /// <summary>
    /// is_unique boolean
    /// </summary>
    /// <value>is_unique boolean</value>
    [DataMember(Name="is_unique", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_unique")]
    public bool? IsUnique { get; set; }

    /// <summary>
    /// militia_corporation_id integer
    /// </summary>
    /// <value>militia_corporation_id integer</value>
    [DataMember(Name="militia_corporation_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "militia_corporation_id")]
    public int? MilitiaCorporationId { get; set; }

    /// <summary>
    /// name string
    /// </summary>
    /// <value>name string</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// size_factor number
    /// </summary>
    /// <value>size_factor number</value>
    [DataMember(Name="size_factor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "size_factor")]
    public float? SizeFactor { get; set; }

    /// <summary>
    /// solar_system_id integer
    /// </summary>
    /// <value>solar_system_id integer</value>
    [DataMember(Name="solar_system_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "solar_system_id")]
    public int? SolarSystemId { get; set; }

    /// <summary>
    /// station_count integer
    /// </summary>
    /// <value>station_count integer</value>
    [DataMember(Name="station_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "station_count")]
    public int? StationCount { get; set; }

    /// <summary>
    /// station_system_count integer
    /// </summary>
    /// <value>station_system_count integer</value>
    [DataMember(Name="station_system_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "station_system_count")]
    public int? StationSystemCount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetUniverseFactions200Ok {\n");
      sb.Append("  CorporationId: ").Append(CorporationId).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  FactionId: ").Append(FactionId).Append("\n");
      sb.Append("  IsUnique: ").Append(IsUnique).Append("\n");
      sb.Append("  MilitiaCorporationId: ").Append(MilitiaCorporationId).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  SizeFactor: ").Append(SizeFactor).Append("\n");
      sb.Append("  SolarSystemId: ").Append(SolarSystemId).Append("\n");
      sb.Append("  StationCount: ").Append(StationCount).Append("\n");
      sb.Append("  StationSystemCount: ").Append(StationSystemCount).Append("\n");
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
