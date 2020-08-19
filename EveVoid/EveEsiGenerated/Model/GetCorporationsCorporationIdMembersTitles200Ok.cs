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
  public class GetCorporationsCorporationIdMembersTitles200Ok {
    /// <summary>
    /// character_id integer
    /// </summary>
    /// <value>character_id integer</value>
    [DataMember(Name="character_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "character_id")]
    public int? CharacterId { get; set; }

    /// <summary>
    /// A list of title_id
    /// </summary>
    /// <value>A list of title_id</value>
    [DataMember(Name="titles", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "titles")]
    public List<int?> Titles { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCorporationsCorporationIdMembersTitles200Ok {\n");
      sb.Append("  CharacterId: ").Append(CharacterId).Append("\n");
      sb.Append("  Titles: ").Append(Titles).Append("\n");
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
