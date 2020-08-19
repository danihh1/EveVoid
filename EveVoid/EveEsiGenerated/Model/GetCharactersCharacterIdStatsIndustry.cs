using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// industry object
  /// </summary>
  [DataContract]
  public class GetCharactersCharacterIdStatsIndustry {
    /// <summary>
    /// hacking_successes integer
    /// </summary>
    /// <value>hacking_successes integer</value>
    [DataMember(Name="hacking_successes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hacking_successes")]
    public long? HackingSuccesses { get; set; }

    /// <summary>
    /// jobs_cancelled integer
    /// </summary>
    /// <value>jobs_cancelled integer</value>
    [DataMember(Name="jobs_cancelled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jobs_cancelled")]
    public long? JobsCancelled { get; set; }

    /// <summary>
    /// jobs_completed_copy_blueprint integer
    /// </summary>
    /// <value>jobs_completed_copy_blueprint integer</value>
    [DataMember(Name="jobs_completed_copy_blueprint", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jobs_completed_copy_blueprint")]
    public long? JobsCompletedCopyBlueprint { get; set; }

    /// <summary>
    /// jobs_completed_invention integer
    /// </summary>
    /// <value>jobs_completed_invention integer</value>
    [DataMember(Name="jobs_completed_invention", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jobs_completed_invention")]
    public long? JobsCompletedInvention { get; set; }

    /// <summary>
    /// jobs_completed_manufacture integer
    /// </summary>
    /// <value>jobs_completed_manufacture integer</value>
    [DataMember(Name="jobs_completed_manufacture", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jobs_completed_manufacture")]
    public long? JobsCompletedManufacture { get; set; }

    /// <summary>
    /// jobs_completed_manufacture_asteroid integer
    /// </summary>
    /// <value>jobs_completed_manufacture_asteroid integer</value>
    [DataMember(Name="jobs_completed_manufacture_asteroid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jobs_completed_manufacture_asteroid")]
    public long? JobsCompletedManufactureAsteroid { get; set; }

    /// <summary>
    /// jobs_completed_manufacture_asteroid_quantity integer
    /// </summary>
    /// <value>jobs_completed_manufacture_asteroid_quantity integer</value>
    [DataMember(Name="jobs_completed_manufacture_asteroid_quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jobs_completed_manufacture_asteroid_quantity")]
    public long? JobsCompletedManufactureAsteroidQuantity { get; set; }

    /// <summary>
    /// jobs_completed_manufacture_charge integer
    /// </summary>
    /// <value>jobs_completed_manufacture_charge integer</value>
    [DataMember(Name="jobs_completed_manufacture_charge", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jobs_completed_manufacture_charge")]
    public long? JobsCompletedManufactureCharge { get; set; }

    /// <summary>
    /// jobs_completed_manufacture_charge_quantity integer
    /// </summary>
    /// <value>jobs_completed_manufacture_charge_quantity integer</value>
    [DataMember(Name="jobs_completed_manufacture_charge_quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jobs_completed_manufacture_charge_quantity")]
    public long? JobsCompletedManufactureChargeQuantity { get; set; }

    /// <summary>
    /// jobs_completed_manufacture_commodity integer
    /// </summary>
    /// <value>jobs_completed_manufacture_commodity integer</value>
    [DataMember(Name="jobs_completed_manufacture_commodity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jobs_completed_manufacture_commodity")]
    public long? JobsCompletedManufactureCommodity { get; set; }

    /// <summary>
    /// jobs_completed_manufacture_commodity_quantity integer
    /// </summary>
    /// <value>jobs_completed_manufacture_commodity_quantity integer</value>
    [DataMember(Name="jobs_completed_manufacture_commodity_quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jobs_completed_manufacture_commodity_quantity")]
    public long? JobsCompletedManufactureCommodityQuantity { get; set; }

    /// <summary>
    /// jobs_completed_manufacture_deployable integer
    /// </summary>
    /// <value>jobs_completed_manufacture_deployable integer</value>
    [DataMember(Name="jobs_completed_manufacture_deployable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jobs_completed_manufacture_deployable")]
    public long? JobsCompletedManufactureDeployable { get; set; }

    /// <summary>
    /// jobs_completed_manufacture_deployable_quantity integer
    /// </summary>
    /// <value>jobs_completed_manufacture_deployable_quantity integer</value>
    [DataMember(Name="jobs_completed_manufacture_deployable_quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jobs_completed_manufacture_deployable_quantity")]
    public long? JobsCompletedManufactureDeployableQuantity { get; set; }

    /// <summary>
    /// jobs_completed_manufacture_drone integer
    /// </summary>
    /// <value>jobs_completed_manufacture_drone integer</value>
    [DataMember(Name="jobs_completed_manufacture_drone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jobs_completed_manufacture_drone")]
    public long? JobsCompletedManufactureDrone { get; set; }

    /// <summary>
    /// jobs_completed_manufacture_drone_quantity integer
    /// </summary>
    /// <value>jobs_completed_manufacture_drone_quantity integer</value>
    [DataMember(Name="jobs_completed_manufacture_drone_quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jobs_completed_manufacture_drone_quantity")]
    public long? JobsCompletedManufactureDroneQuantity { get; set; }

    /// <summary>
    /// jobs_completed_manufacture_implant integer
    /// </summary>
    /// <value>jobs_completed_manufacture_implant integer</value>
    [DataMember(Name="jobs_completed_manufacture_implant", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jobs_completed_manufacture_implant")]
    public long? JobsCompletedManufactureImplant { get; set; }

    /// <summary>
    /// jobs_completed_manufacture_implant_quantity integer
    /// </summary>
    /// <value>jobs_completed_manufacture_implant_quantity integer</value>
    [DataMember(Name="jobs_completed_manufacture_implant_quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jobs_completed_manufacture_implant_quantity")]
    public long? JobsCompletedManufactureImplantQuantity { get; set; }

    /// <summary>
    /// jobs_completed_manufacture_module integer
    /// </summary>
    /// <value>jobs_completed_manufacture_module integer</value>
    [DataMember(Name="jobs_completed_manufacture_module", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jobs_completed_manufacture_module")]
    public long? JobsCompletedManufactureModule { get; set; }

    /// <summary>
    /// jobs_completed_manufacture_module_quantity integer
    /// </summary>
    /// <value>jobs_completed_manufacture_module_quantity integer</value>
    [DataMember(Name="jobs_completed_manufacture_module_quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jobs_completed_manufacture_module_quantity")]
    public long? JobsCompletedManufactureModuleQuantity { get; set; }

    /// <summary>
    /// jobs_completed_manufacture_other integer
    /// </summary>
    /// <value>jobs_completed_manufacture_other integer</value>
    [DataMember(Name="jobs_completed_manufacture_other", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jobs_completed_manufacture_other")]
    public long? JobsCompletedManufactureOther { get; set; }

    /// <summary>
    /// jobs_completed_manufacture_other_quantity integer
    /// </summary>
    /// <value>jobs_completed_manufacture_other_quantity integer</value>
    [DataMember(Name="jobs_completed_manufacture_other_quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jobs_completed_manufacture_other_quantity")]
    public long? JobsCompletedManufactureOtherQuantity { get; set; }

    /// <summary>
    /// jobs_completed_manufacture_ship integer
    /// </summary>
    /// <value>jobs_completed_manufacture_ship integer</value>
    [DataMember(Name="jobs_completed_manufacture_ship", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jobs_completed_manufacture_ship")]
    public long? JobsCompletedManufactureShip { get; set; }

    /// <summary>
    /// jobs_completed_manufacture_ship_quantity integer
    /// </summary>
    /// <value>jobs_completed_manufacture_ship_quantity integer</value>
    [DataMember(Name="jobs_completed_manufacture_ship_quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jobs_completed_manufacture_ship_quantity")]
    public long? JobsCompletedManufactureShipQuantity { get; set; }

    /// <summary>
    /// jobs_completed_manufacture_structure integer
    /// </summary>
    /// <value>jobs_completed_manufacture_structure integer</value>
    [DataMember(Name="jobs_completed_manufacture_structure", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jobs_completed_manufacture_structure")]
    public long? JobsCompletedManufactureStructure { get; set; }

    /// <summary>
    /// jobs_completed_manufacture_structure_quantity integer
    /// </summary>
    /// <value>jobs_completed_manufacture_structure_quantity integer</value>
    [DataMember(Name="jobs_completed_manufacture_structure_quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jobs_completed_manufacture_structure_quantity")]
    public long? JobsCompletedManufactureStructureQuantity { get; set; }

    /// <summary>
    /// jobs_completed_manufacture_subsystem integer
    /// </summary>
    /// <value>jobs_completed_manufacture_subsystem integer</value>
    [DataMember(Name="jobs_completed_manufacture_subsystem", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jobs_completed_manufacture_subsystem")]
    public long? JobsCompletedManufactureSubsystem { get; set; }

    /// <summary>
    /// jobs_completed_manufacture_subsystem_quantity integer
    /// </summary>
    /// <value>jobs_completed_manufacture_subsystem_quantity integer</value>
    [DataMember(Name="jobs_completed_manufacture_subsystem_quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jobs_completed_manufacture_subsystem_quantity")]
    public long? JobsCompletedManufactureSubsystemQuantity { get; set; }

    /// <summary>
    /// jobs_completed_material_productivity integer
    /// </summary>
    /// <value>jobs_completed_material_productivity integer</value>
    [DataMember(Name="jobs_completed_material_productivity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jobs_completed_material_productivity")]
    public long? JobsCompletedMaterialProductivity { get; set; }

    /// <summary>
    /// jobs_completed_time_productivity integer
    /// </summary>
    /// <value>jobs_completed_time_productivity integer</value>
    [DataMember(Name="jobs_completed_time_productivity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jobs_completed_time_productivity")]
    public long? JobsCompletedTimeProductivity { get; set; }

    /// <summary>
    /// jobs_started_copy_blueprint integer
    /// </summary>
    /// <value>jobs_started_copy_blueprint integer</value>
    [DataMember(Name="jobs_started_copy_blueprint", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jobs_started_copy_blueprint")]
    public long? JobsStartedCopyBlueprint { get; set; }

    /// <summary>
    /// jobs_started_invention integer
    /// </summary>
    /// <value>jobs_started_invention integer</value>
    [DataMember(Name="jobs_started_invention", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jobs_started_invention")]
    public long? JobsStartedInvention { get; set; }

    /// <summary>
    /// jobs_started_manufacture integer
    /// </summary>
    /// <value>jobs_started_manufacture integer</value>
    [DataMember(Name="jobs_started_manufacture", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jobs_started_manufacture")]
    public long? JobsStartedManufacture { get; set; }

    /// <summary>
    /// jobs_started_material_productivity integer
    /// </summary>
    /// <value>jobs_started_material_productivity integer</value>
    [DataMember(Name="jobs_started_material_productivity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jobs_started_material_productivity")]
    public long? JobsStartedMaterialProductivity { get; set; }

    /// <summary>
    /// jobs_started_time_productivity integer
    /// </summary>
    /// <value>jobs_started_time_productivity integer</value>
    [DataMember(Name="jobs_started_time_productivity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jobs_started_time_productivity")]
    public long? JobsStartedTimeProductivity { get; set; }

    /// <summary>
    /// reprocess_item integer
    /// </summary>
    /// <value>reprocess_item integer</value>
    [DataMember(Name="reprocess_item", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reprocess_item")]
    public long? ReprocessItem { get; set; }

    /// <summary>
    /// reprocess_item_quantity integer
    /// </summary>
    /// <value>reprocess_item_quantity integer</value>
    [DataMember(Name="reprocess_item_quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reprocess_item_quantity")]
    public long? ReprocessItemQuantity { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCharactersCharacterIdStatsIndustry {\n");
      sb.Append("  HackingSuccesses: ").Append(HackingSuccesses).Append("\n");
      sb.Append("  JobsCancelled: ").Append(JobsCancelled).Append("\n");
      sb.Append("  JobsCompletedCopyBlueprint: ").Append(JobsCompletedCopyBlueprint).Append("\n");
      sb.Append("  JobsCompletedInvention: ").Append(JobsCompletedInvention).Append("\n");
      sb.Append("  JobsCompletedManufacture: ").Append(JobsCompletedManufacture).Append("\n");
      sb.Append("  JobsCompletedManufactureAsteroid: ").Append(JobsCompletedManufactureAsteroid).Append("\n");
      sb.Append("  JobsCompletedManufactureAsteroidQuantity: ").Append(JobsCompletedManufactureAsteroidQuantity).Append("\n");
      sb.Append("  JobsCompletedManufactureCharge: ").Append(JobsCompletedManufactureCharge).Append("\n");
      sb.Append("  JobsCompletedManufactureChargeQuantity: ").Append(JobsCompletedManufactureChargeQuantity).Append("\n");
      sb.Append("  JobsCompletedManufactureCommodity: ").Append(JobsCompletedManufactureCommodity).Append("\n");
      sb.Append("  JobsCompletedManufactureCommodityQuantity: ").Append(JobsCompletedManufactureCommodityQuantity).Append("\n");
      sb.Append("  JobsCompletedManufactureDeployable: ").Append(JobsCompletedManufactureDeployable).Append("\n");
      sb.Append("  JobsCompletedManufactureDeployableQuantity: ").Append(JobsCompletedManufactureDeployableQuantity).Append("\n");
      sb.Append("  JobsCompletedManufactureDrone: ").Append(JobsCompletedManufactureDrone).Append("\n");
      sb.Append("  JobsCompletedManufactureDroneQuantity: ").Append(JobsCompletedManufactureDroneQuantity).Append("\n");
      sb.Append("  JobsCompletedManufactureImplant: ").Append(JobsCompletedManufactureImplant).Append("\n");
      sb.Append("  JobsCompletedManufactureImplantQuantity: ").Append(JobsCompletedManufactureImplantQuantity).Append("\n");
      sb.Append("  JobsCompletedManufactureModule: ").Append(JobsCompletedManufactureModule).Append("\n");
      sb.Append("  JobsCompletedManufactureModuleQuantity: ").Append(JobsCompletedManufactureModuleQuantity).Append("\n");
      sb.Append("  JobsCompletedManufactureOther: ").Append(JobsCompletedManufactureOther).Append("\n");
      sb.Append("  JobsCompletedManufactureOtherQuantity: ").Append(JobsCompletedManufactureOtherQuantity).Append("\n");
      sb.Append("  JobsCompletedManufactureShip: ").Append(JobsCompletedManufactureShip).Append("\n");
      sb.Append("  JobsCompletedManufactureShipQuantity: ").Append(JobsCompletedManufactureShipQuantity).Append("\n");
      sb.Append("  JobsCompletedManufactureStructure: ").Append(JobsCompletedManufactureStructure).Append("\n");
      sb.Append("  JobsCompletedManufactureStructureQuantity: ").Append(JobsCompletedManufactureStructureQuantity).Append("\n");
      sb.Append("  JobsCompletedManufactureSubsystem: ").Append(JobsCompletedManufactureSubsystem).Append("\n");
      sb.Append("  JobsCompletedManufactureSubsystemQuantity: ").Append(JobsCompletedManufactureSubsystemQuantity).Append("\n");
      sb.Append("  JobsCompletedMaterialProductivity: ").Append(JobsCompletedMaterialProductivity).Append("\n");
      sb.Append("  JobsCompletedTimeProductivity: ").Append(JobsCompletedTimeProductivity).Append("\n");
      sb.Append("  JobsStartedCopyBlueprint: ").Append(JobsStartedCopyBlueprint).Append("\n");
      sb.Append("  JobsStartedInvention: ").Append(JobsStartedInvention).Append("\n");
      sb.Append("  JobsStartedManufacture: ").Append(JobsStartedManufacture).Append("\n");
      sb.Append("  JobsStartedMaterialProductivity: ").Append(JobsStartedMaterialProductivity).Append("\n");
      sb.Append("  JobsStartedTimeProductivity: ").Append(JobsStartedTimeProductivity).Append("\n");
      sb.Append("  ReprocessItem: ").Append(ReprocessItem).Append("\n");
      sb.Append("  ReprocessItemQuantity: ").Append(ReprocessItemQuantity).Append("\n");
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
