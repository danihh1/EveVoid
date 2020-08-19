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
  public class GetCorporationsCorporationIdAlliancehistory200Ok {
    /// <summary>
    /// alliance_id integer
    /// </summary>
    /// <value>alliance_id integer</value>
    [DataMember(Name="alliance_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "alliance_id")]
    public int? AllianceId { get; set; }

    /// <summary>
    /// True if the alliance has been closed
    /// </summary>
    /// <value>True if the alliance has been closed</value>
    [DataMember(Name="is_deleted", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_deleted")]
    public bool? IsDeleted { get; set; }

    /// <summary>
    /// An incrementing ID that can be used to canonically establish order of records in cases where dates may be ambiguous
    /// </summary>
    /// <value>An incrementing ID that can be used to canonically establish order of records in cases where dates may be ambiguous</value>
    [DataMember(Name="record_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "record_id")]
    public int? RecordId { get; set; }

    /// <summary>
    /// start_date string
    /// </summary>
    /// <value>start_date string</value>
    [DataMember(Name="start_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "start_date")]
    public DateTime? StartDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCorporationsCorporationIdAlliancehistory200Ok {\n");
      sb.Append("  AllianceId: ").Append(AllianceId).Append("\n");
      sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
      sb.Append("  RecordId: ").Append(RecordId).Append("\n");
      sb.Append("  StartDate: ").Append(StartDate).Append("\n");
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
