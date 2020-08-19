using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// inventory object
  /// </summary>
  [DataContract]
  public class GetCharactersCharacterIdStatsInventory {
    /// <summary>
    /// abandon_loot_quantity integer
    /// </summary>
    /// <value>abandon_loot_quantity integer</value>
    [DataMember(Name="abandon_loot_quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "abandon_loot_quantity")]
    public long? AbandonLootQuantity { get; set; }

    /// <summary>
    /// trash_item_quantity integer
    /// </summary>
    /// <value>trash_item_quantity integer</value>
    [DataMember(Name="trash_item_quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "trash_item_quantity")]
    public long? TrashItemQuantity { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCharactersCharacterIdStatsInventory {\n");
      sb.Append("  AbandonLootQuantity: ").Append(AbandonLootQuantity).Append("\n");
      sb.Append("  TrashItemQuantity: ").Append(TrashItemQuantity).Append("\n");
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
