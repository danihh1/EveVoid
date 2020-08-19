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
  public class GetMarketsGroupsMarketGroupIdOk {
    /// <summary>
    /// description string
    /// </summary>
    /// <value>description string</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// market_group_id integer
    /// </summary>
    /// <value>market_group_id integer</value>
    [DataMember(Name="market_group_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "market_group_id")]
    public int? MarketGroupId { get; set; }

    /// <summary>
    /// name string
    /// </summary>
    /// <value>name string</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// parent_group_id integer
    /// </summary>
    /// <value>parent_group_id integer</value>
    [DataMember(Name="parent_group_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parent_group_id")]
    public int? ParentGroupId { get; set; }

    /// <summary>
    /// types array
    /// </summary>
    /// <value>types array</value>
    [DataMember(Name="types", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "types")]
    public List<int?> Types { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetMarketsGroupsMarketGroupIdOk {\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  MarketGroupId: ").Append(MarketGroupId).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  ParentGroupId: ").Append(ParentGroupId).Append("\n");
      sb.Append("  Types: ").Append(Types).Append("\n");
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
