using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// route object
  /// </summary>
  [DataContract]
  public class GetCharactersCharacterIdPlanetsPlanetIdRoute {
    /// <summary>
    /// content_type_id integer
    /// </summary>
    /// <value>content_type_id integer</value>
    [DataMember(Name="content_type_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "content_type_id")]
    public int? ContentTypeId { get; set; }

    /// <summary>
    /// destination_pin_id integer
    /// </summary>
    /// <value>destination_pin_id integer</value>
    [DataMember(Name="destination_pin_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "destination_pin_id")]
    public long? DestinationPinId { get; set; }

    /// <summary>
    /// quantity number
    /// </summary>
    /// <value>quantity number</value>
    [DataMember(Name="quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quantity")]
    public float? Quantity { get; set; }

    /// <summary>
    /// route_id integer
    /// </summary>
    /// <value>route_id integer</value>
    [DataMember(Name="route_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "route_id")]
    public long? RouteId { get; set; }

    /// <summary>
    /// source_pin_id integer
    /// </summary>
    /// <value>source_pin_id integer</value>
    [DataMember(Name="source_pin_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "source_pin_id")]
    public long? SourcePinId { get; set; }

    /// <summary>
    /// list of pin ID waypoints
    /// </summary>
    /// <value>list of pin ID waypoints</value>
    [DataMember(Name="waypoints", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "waypoints")]
    public List<long?> Waypoints { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCharactersCharacterIdPlanetsPlanetIdRoute {\n");
      sb.Append("  ContentTypeId: ").Append(ContentTypeId).Append("\n");
      sb.Append("  DestinationPinId: ").Append(DestinationPinId).Append("\n");
      sb.Append("  Quantity: ").Append(Quantity).Append("\n");
      sb.Append("  RouteId: ").Append(RouteId).Append("\n");
      sb.Append("  SourcePinId: ").Append(SourcePinId).Append("\n");
      sb.Append("  Waypoints: ").Append(Waypoints).Append("\n");
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
