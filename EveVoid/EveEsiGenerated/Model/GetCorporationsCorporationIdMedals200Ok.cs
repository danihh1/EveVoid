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
  public class GetCorporationsCorporationIdMedals200Ok {
    /// <summary>
    /// created_at string
    /// </summary>
    /// <value>created_at string</value>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// ID of the character who created this medal
    /// </summary>
    /// <value>ID of the character who created this medal</value>
    [DataMember(Name="creator_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creator_id")]
    public int? CreatorId { get; set; }

    /// <summary>
    /// description string
    /// </summary>
    /// <value>description string</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// medal_id integer
    /// </summary>
    /// <value>medal_id integer</value>
    [DataMember(Name="medal_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "medal_id")]
    public int? MedalId { get; set; }

    /// <summary>
    /// title string
    /// </summary>
    /// <value>title string</value>
    [DataMember(Name="title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title")]
    public string Title { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCorporationsCorporationIdMedals200Ok {\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  CreatorId: ").Append(CreatorId).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  MedalId: ").Append(MedalId).Append("\n");
      sb.Append("  Title: ").Append(Title).Append("\n");
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
