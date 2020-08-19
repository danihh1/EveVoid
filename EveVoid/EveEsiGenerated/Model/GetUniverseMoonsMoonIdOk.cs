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
  public class GetUniverseMoonsMoonIdOk {
    /// <summary>
    /// moon_id integer
    /// </summary>
    /// <value>moon_id integer</value>
    [DataMember(Name="moon_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "moon_id")]
    public int? MoonId { get; set; }

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
    public GetUniverseMoonsMoonIdPosition Position { get; set; }

    /// <summary>
    /// The solar system this moon is in
    /// </summary>
    /// <value>The solar system this moon is in</value>
    [DataMember(Name="system_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "system_id")]
    public int? SystemId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetUniverseMoonsMoonIdOk {\n");
      sb.Append("  MoonId: ").Append(MoonId).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Position: ").Append(Position).Append("\n");
      sb.Append("  SystemId: ").Append(SystemId).Append("\n");
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
