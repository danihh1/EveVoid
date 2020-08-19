using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// graphic object
  /// </summary>
  [DataContract]
  public class GetCharactersCharacterIdMedalsGraphic {
    /// <summary>
    /// color integer
    /// </summary>
    /// <value>color integer</value>
    [DataMember(Name="color", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "color")]
    public int? Color { get; set; }

    /// <summary>
    /// graphic string
    /// </summary>
    /// <value>graphic string</value>
    [DataMember(Name="graphic", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "graphic")]
    public string Graphic { get; set; }

    /// <summary>
    /// layer integer
    /// </summary>
    /// <value>layer integer</value>
    [DataMember(Name="layer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "layer")]
    public int? Layer { get; set; }

    /// <summary>
    /// part integer
    /// </summary>
    /// <value>part integer</value>
    [DataMember(Name="part", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "part")]
    public int? Part { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCharactersCharacterIdMedalsGraphic {\n");
      sb.Append("  Color: ").Append(Color).Append("\n");
      sb.Append("  Graphic: ").Append(Graphic).Append("\n");
      sb.Append("  Layer: ").Append(Layer).Append("\n");
      sb.Append("  Part: ").Append(Part).Append("\n");
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
