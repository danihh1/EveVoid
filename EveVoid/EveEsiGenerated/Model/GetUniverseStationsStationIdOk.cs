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
  public class GetUniverseStationsStationIdOk {
    /// <summary>
    /// max_dockable_ship_volume number
    /// </summary>
    /// <value>max_dockable_ship_volume number</value>
    [DataMember(Name="max_dockable_ship_volume", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "max_dockable_ship_volume")]
    public float? MaxDockableShipVolume { get; set; }

    /// <summary>
    /// name string
    /// </summary>
    /// <value>name string</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// office_rental_cost number
    /// </summary>
    /// <value>office_rental_cost number</value>
    [DataMember(Name="office_rental_cost", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "office_rental_cost")]
    public float? OfficeRentalCost { get; set; }

    /// <summary>
    /// ID of the corporation that controls this station
    /// </summary>
    /// <value>ID of the corporation that controls this station</value>
    [DataMember(Name="owner", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "owner")]
    public int? Owner { get; set; }

    /// <summary>
    /// Gets or Sets Position
    /// </summary>
    [DataMember(Name="position", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "position")]
    public GetUniverseStationsStationIdPosition Position { get; set; }

    /// <summary>
    /// race_id integer
    /// </summary>
    /// <value>race_id integer</value>
    [DataMember(Name="race_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "race_id")]
    public int? RaceId { get; set; }

    /// <summary>
    /// reprocessing_efficiency number
    /// </summary>
    /// <value>reprocessing_efficiency number</value>
    [DataMember(Name="reprocessing_efficiency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reprocessing_efficiency")]
    public float? ReprocessingEfficiency { get; set; }

    /// <summary>
    /// reprocessing_stations_take number
    /// </summary>
    /// <value>reprocessing_stations_take number</value>
    [DataMember(Name="reprocessing_stations_take", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reprocessing_stations_take")]
    public float? ReprocessingStationsTake { get; set; }

    /// <summary>
    /// services array
    /// </summary>
    /// <value>services array</value>
    [DataMember(Name="services", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "services")]
    public List<string> Services { get; set; }

    /// <summary>
    /// station_id integer
    /// </summary>
    /// <value>station_id integer</value>
    [DataMember(Name="station_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "station_id")]
    public int? StationId { get; set; }

    /// <summary>
    /// The solar system this station is in
    /// </summary>
    /// <value>The solar system this station is in</value>
    [DataMember(Name="system_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "system_id")]
    public int? SystemId { get; set; }

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
      sb.Append("class GetUniverseStationsStationIdOk {\n");
      sb.Append("  MaxDockableShipVolume: ").Append(MaxDockableShipVolume).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  OfficeRentalCost: ").Append(OfficeRentalCost).Append("\n");
      sb.Append("  Owner: ").Append(Owner).Append("\n");
      sb.Append("  Position: ").Append(Position).Append("\n");
      sb.Append("  RaceId: ").Append(RaceId).Append("\n");
      sb.Append("  ReprocessingEfficiency: ").Append(ReprocessingEfficiency).Append("\n");
      sb.Append("  ReprocessingStationsTake: ").Append(ReprocessingStationsTake).Append("\n");
      sb.Append("  Services: ").Append(Services).Append("\n");
      sb.Append("  StationId: ").Append(StationId).Append("\n");
      sb.Append("  SystemId: ").Append(SystemId).Append("\n");
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
