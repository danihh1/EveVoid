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
  public class GetUniverseStargatesStargateIdOk {
    /// <summary>
    /// Gets or Sets Destination
    /// </summary>
    [DataMember(Name="destination", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "destination")]
    public GetUniverseStargatesStargateIdDestination Destination { get; set; }

    /// <summary>
    /// name string
    /// </summary>
    /// <value>name string</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Position
    /// </summary>
    [DataMember(Name="position", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "position")]
    public GetUniverseStargatesStargateIdPosition Position { get; set; }

    /// <summary>
    /// stargate_id integer
    /// </summary>
    /// <value>stargate_id integer</value>
    [DataMember(Name="stargate_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stargate_id")]
    public int? StargateId { get; set; }

    /// <summary>
    /// The solar system this stargate is in
    /// </summary>
    /// <value>The solar system this stargate is in</value>
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
      sb.Append("class GetUniverseStargatesStargateIdOk {\n");
      sb.Append("  Destination: ").Append(Destination).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Position: ").Append(Position).Append("\n");
      sb.Append("  StargateId: ").Append(StargateId).Append("\n");
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
