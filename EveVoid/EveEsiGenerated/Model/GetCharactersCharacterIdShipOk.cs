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
  public class GetCharactersCharacterIdShipOk {
    /// <summary>
    /// Item id's are unique to a ship and persist until it is repackaged. This value can be used to track repeated uses of a ship, or detect when a pilot changes into a different instance of the same ship type.
    /// </summary>
    /// <value>Item id's are unique to a ship and persist until it is repackaged. This value can be used to track repeated uses of a ship, or detect when a pilot changes into a different instance of the same ship type.</value>
    [DataMember(Name="ship_item_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ship_item_id")]
    public long? ShipItemId { get; set; }

    /// <summary>
    /// ship_name string
    /// </summary>
    /// <value>ship_name string</value>
    [DataMember(Name="ship_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ship_name")]
    public string ShipName { get; set; }

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
      sb.Append("class GetCharactersCharacterIdShipOk {\n");
      sb.Append("  ShipItemId: ").Append(ShipItemId).Append("\n");
      sb.Append("  ShipName: ").Append(ShipName).Append("\n");
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
