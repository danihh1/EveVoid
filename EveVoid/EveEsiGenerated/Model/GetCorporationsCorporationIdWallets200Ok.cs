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
  public class GetCorporationsCorporationIdWallets200Ok {
    /// <summary>
    /// balance number
    /// </summary>
    /// <value>balance number</value>
    [DataMember(Name="balance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "balance")]
    public double? Balance { get; set; }

    /// <summary>
    /// division integer
    /// </summary>
    /// <value>division integer</value>
    [DataMember(Name="division", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "division")]
    public int? Division { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCorporationsCorporationIdWallets200Ok {\n");
      sb.Append("  Balance: ").Append(Balance).Append("\n");
      sb.Append("  Division: ").Append(Division).Append("\n");
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
