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
  public class GetCorporationsCorporationIdDivisionsOk {
    /// <summary>
    /// hangar array
    /// </summary>
    /// <value>hangar array</value>
    [DataMember(Name="hangar", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hangar")]
    public List<GetCorporationsCorporationIdDivisionsHangarHangar> Hangar { get; set; }

    /// <summary>
    /// wallet array
    /// </summary>
    /// <value>wallet array</value>
    [DataMember(Name="wallet", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "wallet")]
    public List<GetCorporationsCorporationIdDivisionsWalletWallet> Wallet { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCorporationsCorporationIdDivisionsOk {\n");
      sb.Append("  Hangar: ").Append(Hangar).Append("\n");
      sb.Append("  Wallet: ").Append(Wallet).Append("\n");
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
