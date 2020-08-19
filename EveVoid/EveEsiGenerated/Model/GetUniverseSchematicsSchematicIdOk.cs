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
  public class GetUniverseSchematicsSchematicIdOk {
    /// <summary>
    /// Time in seconds to process a run
    /// </summary>
    /// <value>Time in seconds to process a run</value>
    [DataMember(Name="cycle_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cycle_time")]
    public int? CycleTime { get; set; }

    /// <summary>
    /// schematic_name string
    /// </summary>
    /// <value>schematic_name string</value>
    [DataMember(Name="schematic_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "schematic_name")]
    public string SchematicName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetUniverseSchematicsSchematicIdOk {\n");
      sb.Append("  CycleTime: ").Append(CycleTime).Append("\n");
      sb.Append("  SchematicName: ").Append(SchematicName).Append("\n");
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
