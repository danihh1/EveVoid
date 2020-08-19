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
  public class PostCharactersCharacterIdAssetsLocations200Ok {
    /// <summary>
    /// item_id integer
    /// </summary>
    /// <value>item_id integer</value>
    [DataMember(Name="item_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "item_id")]
    public long? ItemId { get; set; }

    /// <summary>
    /// Gets or Sets Position
    /// </summary>
    [DataMember(Name="position", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "position")]
    public PostCharactersCharacterIdAssetsLocationsPosition Position { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PostCharactersCharacterIdAssetsLocations200Ok {\n");
      sb.Append("  ItemId: ").Append(ItemId).Append("\n");
      sb.Append("  Position: ").Append(Position).Append("\n");
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
