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
  public class GetUniverseBloodlines200Ok {
    /// <summary>
    /// bloodline_id integer
    /// </summary>
    /// <value>bloodline_id integer</value>
    [DataMember(Name="bloodline_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bloodline_id")]
    public int? BloodlineId { get; set; }

    /// <summary>
    /// charisma integer
    /// </summary>
    /// <value>charisma integer</value>
    [DataMember(Name="charisma", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "charisma")]
    public int? Charisma { get; set; }

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
    /// intelligence integer
    /// </summary>
    /// <value>intelligence integer</value>
    [DataMember(Name="intelligence", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "intelligence")]
    public int? Intelligence { get; set; }

    /// <summary>
    /// memory integer
    /// </summary>
    /// <value>memory integer</value>
    [DataMember(Name="memory", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "memory")]
    public int? Memory { get; set; }

    /// <summary>
    /// name string
    /// </summary>
    /// <value>name string</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// perception integer
    /// </summary>
    /// <value>perception integer</value>
    [DataMember(Name="perception", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "perception")]
    public int? Perception { get; set; }

    /// <summary>
    /// race_id integer
    /// </summary>
    /// <value>race_id integer</value>
    [DataMember(Name="race_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "race_id")]
    public int? RaceId { get; set; }

    /// <summary>
    /// ship_type_id integer
    /// </summary>
    /// <value>ship_type_id integer</value>
    [DataMember(Name="ship_type_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ship_type_id")]
    public int? ShipTypeId { get; set; }

    /// <summary>
    /// willpower integer
    /// </summary>
    /// <value>willpower integer</value>
    [DataMember(Name="willpower", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "willpower")]
    public int? Willpower { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetUniverseBloodlines200Ok {\n");
      sb.Append("  BloodlineId: ").Append(BloodlineId).Append("\n");
      sb.Append("  Charisma: ").Append(Charisma).Append("\n");
      sb.Append("  CorporationId: ").Append(CorporationId).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Intelligence: ").Append(Intelligence).Append("\n");
      sb.Append("  Memory: ").Append(Memory).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Perception: ").Append(Perception).Append("\n");
      sb.Append("  RaceId: ").Append(RaceId).Append("\n");
      sb.Append("  ShipTypeId: ").Append(ShipTypeId).Append("\n");
      sb.Append("  Willpower: ").Append(Willpower).Append("\n");
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
