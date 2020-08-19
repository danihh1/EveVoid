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
  public class GetCharactersCharacterIdMining200Ok {
    /// <summary>
    /// date string
    /// </summary>
    /// <value>date string</value>
    [DataMember(Name="date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date")]
    public DateTime? Date { get; set; }

    /// <summary>
    /// quantity integer
    /// </summary>
    /// <value>quantity integer</value>
    [DataMember(Name="quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quantity")]
    public long? Quantity { get; set; }

    /// <summary>
    /// solar_system_id integer
    /// </summary>
    /// <value>solar_system_id integer</value>
    [DataMember(Name="solar_system_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "solar_system_id")]
    public int? SolarSystemId { get; set; }

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
      sb.Append("class GetCharactersCharacterIdMining200Ok {\n");
      sb.Append("  Date: ").Append(Date).Append("\n");
      sb.Append("  Quantity: ").Append(Quantity).Append("\n");
      sb.Append("  SolarSystemId: ").Append(SolarSystemId).Append("\n");
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
