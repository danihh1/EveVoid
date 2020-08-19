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
  public class GetContractsPublicRegionId200Ok {
    /// <summary>
    /// Buyout price (for Auctions only)
    /// </summary>
    /// <value>Buyout price (for Auctions only)</value>
    [DataMember(Name="buyout", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "buyout")]
    public double? Buyout { get; set; }

    /// <summary>
    /// Collateral price (for Couriers only)
    /// </summary>
    /// <value>Collateral price (for Couriers only)</value>
    [DataMember(Name="collateral", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "collateral")]
    public double? Collateral { get; set; }

    /// <summary>
    /// contract_id integer
    /// </summary>
    /// <value>contract_id integer</value>
    [DataMember(Name="contract_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contract_id")]
    public int? ContractId { get; set; }

    /// <summary>
    /// Expiration date of the contract
    /// </summary>
    /// <value>Expiration date of the contract</value>
    [DataMember(Name="date_expired", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date_expired")]
    public DateTime? DateExpired { get; set; }

    /// <summary>
    /// Сreation date of the contract
    /// </summary>
    /// <value>Сreation date of the contract</value>
    [DataMember(Name="date_issued", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date_issued")]
    public DateTime? DateIssued { get; set; }

    /// <summary>
    /// Number of days to perform the contract
    /// </summary>
    /// <value>Number of days to perform the contract</value>
    [DataMember(Name="days_to_complete", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "days_to_complete")]
    public int? DaysToComplete { get; set; }

    /// <summary>
    /// End location ID (for Couriers contract)
    /// </summary>
    /// <value>End location ID (for Couriers contract)</value>
    [DataMember(Name="end_location_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "end_location_id")]
    public long? EndLocationId { get; set; }

    /// <summary>
    /// true if the contract was issued on behalf of the issuer's corporation
    /// </summary>
    /// <value>true if the contract was issued on behalf of the issuer's corporation</value>
    [DataMember(Name="for_corporation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "for_corporation")]
    public bool? ForCorporation { get; set; }

    /// <summary>
    /// Character's corporation ID for the issuer
    /// </summary>
    /// <value>Character's corporation ID for the issuer</value>
    [DataMember(Name="issuer_corporation_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issuer_corporation_id")]
    public int? IssuerCorporationId { get; set; }

    /// <summary>
    /// Character ID for the issuer
    /// </summary>
    /// <value>Character ID for the issuer</value>
    [DataMember(Name="issuer_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issuer_id")]
    public int? IssuerId { get; set; }

    /// <summary>
    /// Price of contract (for ItemsExchange and Auctions)
    /// </summary>
    /// <value>Price of contract (for ItemsExchange and Auctions)</value>
    [DataMember(Name="price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "price")]
    public double? Price { get; set; }

    /// <summary>
    /// Remuneration for contract (for Couriers only)
    /// </summary>
    /// <value>Remuneration for contract (for Couriers only)</value>
    [DataMember(Name="reward", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reward")]
    public double? Reward { get; set; }

    /// <summary>
    /// Start location ID (for Couriers contract)
    /// </summary>
    /// <value>Start location ID (for Couriers contract)</value>
    [DataMember(Name="start_location_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "start_location_id")]
    public long? StartLocationId { get; set; }

    /// <summary>
    /// Title of the contract
    /// </summary>
    /// <value>Title of the contract</value>
    [DataMember(Name="title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title")]
    public string Title { get; set; }

    /// <summary>
    /// Type of the contract
    /// </summary>
    /// <value>Type of the contract</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Volume of items in the contract
    /// </summary>
    /// <value>Volume of items in the contract</value>
    [DataMember(Name="volume", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "volume")]
    public double? Volume { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetContractsPublicRegionId200Ok {\n");
      sb.Append("  Buyout: ").Append(Buyout).Append("\n");
      sb.Append("  Collateral: ").Append(Collateral).Append("\n");
      sb.Append("  ContractId: ").Append(ContractId).Append("\n");
      sb.Append("  DateExpired: ").Append(DateExpired).Append("\n");
      sb.Append("  DateIssued: ").Append(DateIssued).Append("\n");
      sb.Append("  DaysToComplete: ").Append(DaysToComplete).Append("\n");
      sb.Append("  EndLocationId: ").Append(EndLocationId).Append("\n");
      sb.Append("  ForCorporation: ").Append(ForCorporation).Append("\n");
      sb.Append("  IssuerCorporationId: ").Append(IssuerCorporationId).Append("\n");
      sb.Append("  IssuerId: ").Append(IssuerId).Append("\n");
      sb.Append("  Price: ").Append(Price).Append("\n");
      sb.Append("  Reward: ").Append(Reward).Append("\n");
      sb.Append("  StartLocationId: ").Append(StartLocationId).Append("\n");
      sb.Append("  Title: ").Append(Title).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Volume: ").Append(Volume).Append("\n");
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
