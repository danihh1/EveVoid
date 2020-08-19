using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// item object
  /// </summary>
  [DataContract]
  public class GetKillmailsKillmailIdKillmailHashItemsItem {
    /// <summary>
    /// flag integer
    /// </summary>
    /// <value>flag integer</value>
    [DataMember(Name="flag", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "flag")]
    public int? Flag { get; set; }

    /// <summary>
    /// item_type_id integer
    /// </summary>
    /// <value>item_type_id integer</value>
    [DataMember(Name="item_type_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "item_type_id")]
    public int? ItemTypeId { get; set; }

    /// <summary>
    /// quantity_destroyed integer
    /// </summary>
    /// <value>quantity_destroyed integer</value>
    [DataMember(Name="quantity_destroyed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quantity_destroyed")]
    public long? QuantityDestroyed { get; set; }

    /// <summary>
    /// quantity_dropped integer
    /// </summary>
    /// <value>quantity_dropped integer</value>
    [DataMember(Name="quantity_dropped", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quantity_dropped")]
    public long? QuantityDropped { get; set; }

    /// <summary>
    /// singleton integer
    /// </summary>
    /// <value>singleton integer</value>
    [DataMember(Name="singleton", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "singleton")]
    public int? Singleton { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetKillmailsKillmailIdKillmailHashItemsItem {\n");
      sb.Append("  Flag: ").Append(Flag).Append("\n");
      sb.Append("  ItemTypeId: ").Append(ItemTypeId).Append("\n");
      sb.Append("  QuantityDestroyed: ").Append(QuantityDestroyed).Append("\n");
      sb.Append("  QuantityDropped: ").Append(QuantityDropped).Append("\n");
      sb.Append("  Singleton: ").Append(Singleton).Append("\n");
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
