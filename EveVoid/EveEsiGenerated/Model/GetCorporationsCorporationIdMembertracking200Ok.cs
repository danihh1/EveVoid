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
  public class GetCorporationsCorporationIdMembertracking200Ok {
    /// <summary>
    /// base_id integer
    /// </summary>
    /// <value>base_id integer</value>
    [DataMember(Name="base_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "base_id")]
    public int? BaseId { get; set; }

    /// <summary>
    /// character_id integer
    /// </summary>
    /// <value>character_id integer</value>
    [DataMember(Name="character_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "character_id")]
    public int? CharacterId { get; set; }

    /// <summary>
    /// location_id integer
    /// </summary>
    /// <value>location_id integer</value>
    [DataMember(Name="location_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "location_id")]
    public long? LocationId { get; set; }

    /// <summary>
    /// logoff_date string
    /// </summary>
    /// <value>logoff_date string</value>
    [DataMember(Name="logoff_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "logoff_date")]
    public DateTime? LogoffDate { get; set; }

    /// <summary>
    /// logon_date string
    /// </summary>
    /// <value>logon_date string</value>
    [DataMember(Name="logon_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "logon_date")]
    public DateTime? LogonDate { get; set; }

    /// <summary>
    /// ship_type_id integer
    /// </summary>
    /// <value>ship_type_id integer</value>
    [DataMember(Name="ship_type_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ship_type_id")]
    public int? ShipTypeId { get; set; }

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
      sb.Append("class GetCorporationsCorporationIdMembertracking200Ok {\n");
      sb.Append("  BaseId: ").Append(BaseId).Append("\n");
      sb.Append("  CharacterId: ").Append(CharacterId).Append("\n");
      sb.Append("  LocationId: ").Append(LocationId).Append("\n");
      sb.Append("  LogoffDate: ").Append(LogoffDate).Append("\n");
      sb.Append("  LogonDate: ").Append(LogonDate).Append("\n");
      sb.Append("  ShipTypeId: ").Append(ShipTypeId).Append("\n");
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
