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
  public class GetCharactersCharacterIdBookmarks200Ok {
    /// <summary>
    /// bookmark_id integer
    /// </summary>
    /// <value>bookmark_id integer</value>
    [DataMember(Name="bookmark_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bookmark_id")]
    public int? BookmarkId { get; set; }

    /// <summary>
    /// Gets or Sets Coordinates
    /// </summary>
    [DataMember(Name="coordinates", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "coordinates")]
    public GetCharactersCharacterIdBookmarksCoordinates Coordinates { get; set; }

    /// <summary>
    /// created string
    /// </summary>
    /// <value>created string</value>
    [DataMember(Name="created", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created")]
    public DateTime? Created { get; set; }

    /// <summary>
    /// creator_id integer
    /// </summary>
    /// <value>creator_id integer</value>
    [DataMember(Name="creator_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creator_id")]
    public int? CreatorId { get; set; }

    /// <summary>
    /// folder_id integer
    /// </summary>
    /// <value>folder_id integer</value>
    [DataMember(Name="folder_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "folder_id")]
    public int? FolderId { get; set; }

    /// <summary>
    /// Gets or Sets Item
    /// </summary>
    [DataMember(Name="item", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "item")]
    public GetCharactersCharacterIdBookmarksItem Item { get; set; }

    /// <summary>
    /// label string
    /// </summary>
    /// <value>label string</value>
    [DataMember(Name="label", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "label")]
    public string Label { get; set; }

    /// <summary>
    /// location_id integer
    /// </summary>
    /// <value>location_id integer</value>
    [DataMember(Name="location_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "location_id")]
    public int? LocationId { get; set; }

    /// <summary>
    /// notes string
    /// </summary>
    /// <value>notes string</value>
    [DataMember(Name="notes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notes")]
    public string Notes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCharactersCharacterIdBookmarks200Ok {\n");
      sb.Append("  BookmarkId: ").Append(BookmarkId).Append("\n");
      sb.Append("  Coordinates: ").Append(Coordinates).Append("\n");
      sb.Append("  Created: ").Append(Created).Append("\n");
      sb.Append("  CreatorId: ").Append(CreatorId).Append("\n");
      sb.Append("  FolderId: ").Append(FolderId).Append("\n");
      sb.Append("  Item: ").Append(Item).Append("\n");
      sb.Append("  Label: ").Append(Label).Append("\n");
      sb.Append("  LocationId: ").Append(LocationId).Append("\n");
      sb.Append("  Notes: ").Append(Notes).Append("\n");
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
