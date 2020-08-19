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
  public class GetContractsPublicBidsContractId200Ok {
    /// <summary>
    /// The amount bid, in ISK
    /// </summary>
    /// <value>The amount bid, in ISK</value>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public float? Amount { get; set; }

    /// <summary>
    /// Unique ID for the bid
    /// </summary>
    /// <value>Unique ID for the bid</value>
    [DataMember(Name="bid_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bid_id")]
    public int? BidId { get; set; }

    /// <summary>
    /// Datetime when the bid was placed
    /// </summary>
    /// <value>Datetime when the bid was placed</value>
    [DataMember(Name="date_bid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date_bid")]
    public DateTime? DateBid { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetContractsPublicBidsContractId200Ok {\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      sb.Append("  BidId: ").Append(BidId).Append("\n");
      sb.Append("  DateBid: ").Append(DateBid).Append("\n");
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
