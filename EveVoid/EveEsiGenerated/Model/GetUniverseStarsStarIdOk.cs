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
  public class GetUniverseStarsStarIdOk {
    /// <summary>
    /// Age of star in years
    /// </summary>
    /// <value>Age of star in years</value>
    [DataMember(Name="age", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "age")]
    public long? Age { get; set; }

    /// <summary>
    /// luminosity number
    /// </summary>
    /// <value>luminosity number</value>
    [DataMember(Name="luminosity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "luminosity")]
    public float? Luminosity { get; set; }

    /// <summary>
    /// name string
    /// </summary>
    /// <value>name string</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// radius integer
    /// </summary>
    /// <value>radius integer</value>
    [DataMember(Name="radius", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "radius")]
    public long? Radius { get; set; }

    /// <summary>
    /// solar_system_id integer
    /// </summary>
    /// <value>solar_system_id integer</value>
    [DataMember(Name="solar_system_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "solar_system_id")]
    public int? SolarSystemId { get; set; }

    /// <summary>
    /// spectral_class string
    /// </summary>
    /// <value>spectral_class string</value>
    [DataMember(Name="spectral_class", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "spectral_class")]
    public string SpectralClass { get; set; }

    /// <summary>
    /// temperature integer
    /// </summary>
    /// <value>temperature integer</value>
    [DataMember(Name="temperature", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "temperature")]
    public int? Temperature { get; set; }

    /// <summary>
    /// type_id integer
    /// </summary>
    /// <value>type_id integer</value>
    [DataMember(Name="type_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type_id")]
    public int? TypeId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetUniverseStarsStarIdOk {\n");
      sb.Append("  Age: ").Append(Age).Append("\n");
      sb.Append("  Luminosity: ").Append(Luminosity).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Radius: ").Append(Radius).Append("\n");
      sb.Append("  SolarSystemId: ").Append(SolarSystemId).Append("\n");
      sb.Append("  SpectralClass: ").Append(SpectralClass).Append("\n");
      sb.Append("  Temperature: ").Append(Temperature).Append("\n");
      sb.Append("  TypeId: ").Append(TypeId).Append("\n");
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
