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
  public class GetCharactersCharacterIdFittings200Ok {
    /// <summary>
    /// description string
    /// </summary>
    /// <value>description string</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// fitting_id integer
    /// </summary>
    /// <value>fitting_id integer</value>
    [DataMember(Name="fitting_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fitting_id")]
    public int? FittingId { get; set; }

    /// <summary>
    /// items array
    /// </summary>
    /// <value>items array</value>
    [DataMember(Name="items", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "items")]
    public List<GetCharactersCharacterIdFittingsItem> Items { get; set; }

    /// <summary>
    /// name string
    /// </summary>
    /// <value>name string</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// ship_type_id integer
    /// </summary>
    /// <value>ship_type_id integer</value>
    [DataMember(Name="ship_type_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ship_type_id")]
    public int? ShipTypeId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCharactersCharacterIdFittings200Ok {\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  FittingId: ").Append(FittingId).Append("\n");
      sb.Append("  Items: ").Append(Items).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  ShipTypeId: ").Append(ShipTypeId).Append("\n");
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
