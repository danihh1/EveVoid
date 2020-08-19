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
  public class GetStatusOk {
    /// <summary>
    /// Current online player count
    /// </summary>
    /// <value>Current online player count</value>
    [DataMember(Name="players", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "players")]
    public int? Players { get; set; }

    /// <summary>
    /// Running version as string
    /// </summary>
    /// <value>Running version as string</value>
    [DataMember(Name="server_version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "server_version")]
    public string ServerVersion { get; set; }

    /// <summary>
    /// Server start timestamp
    /// </summary>
    /// <value>Server start timestamp</value>
    [DataMember(Name="start_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "start_time")]
    public DateTime? StartTime { get; set; }

    /// <summary>
    /// If the server is in VIP mode
    /// </summary>
    /// <value>If the server is in VIP mode</value>
    [DataMember(Name="vip", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vip")]
    public bool? Vip { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetStatusOk {\n");
      sb.Append("  Players: ").Append(Players).Append("\n");
      sb.Append("  ServerVersion: ").Append(ServerVersion).Append("\n");
      sb.Append("  StartTime: ").Append(StartTime).Append("\n");
      sb.Append("  Vip: ").Append(Vip).Append("\n");
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
