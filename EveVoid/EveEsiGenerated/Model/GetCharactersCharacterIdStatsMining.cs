using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// mining object
  /// </summary>
  [DataContract]
  public class GetCharactersCharacterIdStatsMining {
    /// <summary>
    /// drone_mine integer
    /// </summary>
    /// <value>drone_mine integer</value>
    [DataMember(Name="drone_mine", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "drone_mine")]
    public long? DroneMine { get; set; }

    /// <summary>
    /// ore_arkonor integer
    /// </summary>
    /// <value>ore_arkonor integer</value>
    [DataMember(Name="ore_arkonor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ore_arkonor")]
    public long? OreArkonor { get; set; }

    /// <summary>
    /// ore_bistot integer
    /// </summary>
    /// <value>ore_bistot integer</value>
    [DataMember(Name="ore_bistot", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ore_bistot")]
    public long? OreBistot { get; set; }

    /// <summary>
    /// ore_crokite integer
    /// </summary>
    /// <value>ore_crokite integer</value>
    [DataMember(Name="ore_crokite", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ore_crokite")]
    public long? OreCrokite { get; set; }

    /// <summary>
    /// ore_dark_ochre integer
    /// </summary>
    /// <value>ore_dark_ochre integer</value>
    [DataMember(Name="ore_dark_ochre", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ore_dark_ochre")]
    public long? OreDarkOchre { get; set; }

    /// <summary>
    /// ore_gneiss integer
    /// </summary>
    /// <value>ore_gneiss integer</value>
    [DataMember(Name="ore_gneiss", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ore_gneiss")]
    public long? OreGneiss { get; set; }

    /// <summary>
    /// ore_harvestable_cloud integer
    /// </summary>
    /// <value>ore_harvestable_cloud integer</value>
    [DataMember(Name="ore_harvestable_cloud", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ore_harvestable_cloud")]
    public long? OreHarvestableCloud { get; set; }

    /// <summary>
    /// ore_hedbergite integer
    /// </summary>
    /// <value>ore_hedbergite integer</value>
    [DataMember(Name="ore_hedbergite", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ore_hedbergite")]
    public long? OreHedbergite { get; set; }

    /// <summary>
    /// ore_hemorphite integer
    /// </summary>
    /// <value>ore_hemorphite integer</value>
    [DataMember(Name="ore_hemorphite", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ore_hemorphite")]
    public long? OreHemorphite { get; set; }

    /// <summary>
    /// ore_ice integer
    /// </summary>
    /// <value>ore_ice integer</value>
    [DataMember(Name="ore_ice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ore_ice")]
    public long? OreIce { get; set; }

    /// <summary>
    /// ore_jaspet integer
    /// </summary>
    /// <value>ore_jaspet integer</value>
    [DataMember(Name="ore_jaspet", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ore_jaspet")]
    public long? OreJaspet { get; set; }

    /// <summary>
    /// ore_kernite integer
    /// </summary>
    /// <value>ore_kernite integer</value>
    [DataMember(Name="ore_kernite", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ore_kernite")]
    public long? OreKernite { get; set; }

    /// <summary>
    /// ore_mercoxit integer
    /// </summary>
    /// <value>ore_mercoxit integer</value>
    [DataMember(Name="ore_mercoxit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ore_mercoxit")]
    public long? OreMercoxit { get; set; }

    /// <summary>
    /// ore_omber integer
    /// </summary>
    /// <value>ore_omber integer</value>
    [DataMember(Name="ore_omber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ore_omber")]
    public long? OreOmber { get; set; }

    /// <summary>
    /// ore_plagioclase integer
    /// </summary>
    /// <value>ore_plagioclase integer</value>
    [DataMember(Name="ore_plagioclase", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ore_plagioclase")]
    public long? OrePlagioclase { get; set; }

    /// <summary>
    /// ore_pyroxeres integer
    /// </summary>
    /// <value>ore_pyroxeres integer</value>
    [DataMember(Name="ore_pyroxeres", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ore_pyroxeres")]
    public long? OrePyroxeres { get; set; }

    /// <summary>
    /// ore_scordite integer
    /// </summary>
    /// <value>ore_scordite integer</value>
    [DataMember(Name="ore_scordite", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ore_scordite")]
    public long? OreScordite { get; set; }

    /// <summary>
    /// ore_spodumain integer
    /// </summary>
    /// <value>ore_spodumain integer</value>
    [DataMember(Name="ore_spodumain", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ore_spodumain")]
    public long? OreSpodumain { get; set; }

    /// <summary>
    /// ore_veldspar integer
    /// </summary>
    /// <value>ore_veldspar integer</value>
    [DataMember(Name="ore_veldspar", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ore_veldspar")]
    public long? OreVeldspar { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCharactersCharacterIdStatsMining {\n");
      sb.Append("  DroneMine: ").Append(DroneMine).Append("\n");
      sb.Append("  OreArkonor: ").Append(OreArkonor).Append("\n");
      sb.Append("  OreBistot: ").Append(OreBistot).Append("\n");
      sb.Append("  OreCrokite: ").Append(OreCrokite).Append("\n");
      sb.Append("  OreDarkOchre: ").Append(OreDarkOchre).Append("\n");
      sb.Append("  OreGneiss: ").Append(OreGneiss).Append("\n");
      sb.Append("  OreHarvestableCloud: ").Append(OreHarvestableCloud).Append("\n");
      sb.Append("  OreHedbergite: ").Append(OreHedbergite).Append("\n");
      sb.Append("  OreHemorphite: ").Append(OreHemorphite).Append("\n");
      sb.Append("  OreIce: ").Append(OreIce).Append("\n");
      sb.Append("  OreJaspet: ").Append(OreJaspet).Append("\n");
      sb.Append("  OreKernite: ").Append(OreKernite).Append("\n");
      sb.Append("  OreMercoxit: ").Append(OreMercoxit).Append("\n");
      sb.Append("  OreOmber: ").Append(OreOmber).Append("\n");
      sb.Append("  OrePlagioclase: ").Append(OrePlagioclase).Append("\n");
      sb.Append("  OrePyroxeres: ").Append(OrePyroxeres).Append("\n");
      sb.Append("  OreScordite: ").Append(OreScordite).Append("\n");
      sb.Append("  OreSpodumain: ").Append(OreSpodumain).Append("\n");
      sb.Append("  OreVeldspar: ").Append(OreVeldspar).Append("\n");
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
