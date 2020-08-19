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
  public class GetWarsWarIdOk {
    /// <summary>
    /// Gets or Sets Aggressor
    /// </summary>
    [DataMember(Name="aggressor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "aggressor")]
    public GetWarsWarIdAggressor Aggressor { get; set; }

    /// <summary>
    /// allied corporations or alliances, each object contains either corporation_id or alliance_id
    /// </summary>
    /// <value>allied corporations or alliances, each object contains either corporation_id or alliance_id</value>
    [DataMember(Name="allies", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allies")]
    public List<GetWarsWarIdAlly> Allies { get; set; }

    /// <summary>
    /// Time that the war was declared
    /// </summary>
    /// <value>Time that the war was declared</value>
    [DataMember(Name="declared", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "declared")]
    public DateTime? Declared { get; set; }

    /// <summary>
    /// Gets or Sets Defender
    /// </summary>
    [DataMember(Name="defender", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defender")]
    public GetWarsWarIdDefender Defender { get; set; }

    /// <summary>
    /// Time the war ended and shooting was no longer allowed
    /// </summary>
    /// <value>Time the war ended and shooting was no longer allowed</value>
    [DataMember(Name="finished", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "finished")]
    public DateTime? Finished { get; set; }

    /// <summary>
    /// ID of the specified war
    /// </summary>
    /// <value>ID of the specified war</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Was the war declared mutual by both parties
    /// </summary>
    /// <value>Was the war declared mutual by both parties</value>
    [DataMember(Name="mutual", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mutual")]
    public bool? Mutual { get; set; }

    /// <summary>
    /// Is the war currently open for allies or not
    /// </summary>
    /// <value>Is the war currently open for allies or not</value>
    [DataMember(Name="open_for_allies", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "open_for_allies")]
    public bool? OpenForAllies { get; set; }

    /// <summary>
    /// Time the war was retracted but both sides could still shoot each other
    /// </summary>
    /// <value>Time the war was retracted but both sides could still shoot each other</value>
    [DataMember(Name="retracted", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "retracted")]
    public DateTime? Retracted { get; set; }

    /// <summary>
    /// Time when the war started and both sides could shoot each other
    /// </summary>
    /// <value>Time when the war started and both sides could shoot each other</value>
    [DataMember(Name="started", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "started")]
    public DateTime? Started { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetWarsWarIdOk {\n");
      sb.Append("  Aggressor: ").Append(Aggressor).Append("\n");
      sb.Append("  Allies: ").Append(Allies).Append("\n");
      sb.Append("  Declared: ").Append(Declared).Append("\n");
      sb.Append("  Defender: ").Append(Defender).Append("\n");
      sb.Append("  Finished: ").Append(Finished).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Mutual: ").Append(Mutual).Append("\n");
      sb.Append("  OpenForAllies: ").Append(OpenForAllies).Append("\n");
      sb.Append("  Retracted: ").Append(Retracted).Append("\n");
      sb.Append("  Started: ").Append(Started).Append("\n");
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
