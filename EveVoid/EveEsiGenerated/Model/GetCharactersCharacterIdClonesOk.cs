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
  public class GetCharactersCharacterIdClonesOk {
    /// <summary>
    /// Gets or Sets HomeLocation
    /// </summary>
    [DataMember(Name="home_location", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "home_location")]
    public GetCharactersCharacterIdClonesHomeLocation HomeLocation { get; set; }

    /// <summary>
    /// jump_clones array
    /// </summary>
    /// <value>jump_clones array</value>
    [DataMember(Name="jump_clones", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jump_clones")]
    public List<GetCharactersCharacterIdClonesJumpClone> JumpClones { get; set; }

    /// <summary>
    /// last_clone_jump_date string
    /// </summary>
    /// <value>last_clone_jump_date string</value>
    [DataMember(Name="last_clone_jump_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last_clone_jump_date")]
    public DateTime? LastCloneJumpDate { get; set; }

    /// <summary>
    /// last_station_change_date string
    /// </summary>
    /// <value>last_station_change_date string</value>
    [DataMember(Name="last_station_change_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last_station_change_date")]
    public DateTime? LastStationChangeDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCharactersCharacterIdClonesOk {\n");
      sb.Append("  HomeLocation: ").Append(HomeLocation).Append("\n");
      sb.Append("  JumpClones: ").Append(JumpClones).Append("\n");
      sb.Append("  LastCloneJumpDate: ").Append(LastCloneJumpDate).Append("\n");
      sb.Append("  LastStationChangeDate: ").Append(LastStationChangeDate).Append("\n");
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
