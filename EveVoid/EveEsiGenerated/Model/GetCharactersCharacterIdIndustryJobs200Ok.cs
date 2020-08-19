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
  public class GetCharactersCharacterIdIndustryJobs200Ok {
    /// <summary>
    /// Job activity ID
    /// </summary>
    /// <value>Job activity ID</value>
    [DataMember(Name="activity_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activity_id")]
    public int? ActivityId { get; set; }

    /// <summary>
    /// blueprint_id integer
    /// </summary>
    /// <value>blueprint_id integer</value>
    [DataMember(Name="blueprint_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "blueprint_id")]
    public long? BlueprintId { get; set; }

    /// <summary>
    /// Location ID of the location from which the blueprint was installed. Normally a station ID, but can also be an asset (e.g. container) or corporation facility
    /// </summary>
    /// <value>Location ID of the location from which the blueprint was installed. Normally a station ID, but can also be an asset (e.g. container) or corporation facility</value>
    [DataMember(Name="blueprint_location_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "blueprint_location_id")]
    public long? BlueprintLocationId { get; set; }

    /// <summary>
    /// blueprint_type_id integer
    /// </summary>
    /// <value>blueprint_type_id integer</value>
    [DataMember(Name="blueprint_type_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "blueprint_type_id")]
    public int? BlueprintTypeId { get; set; }

    /// <summary>
    /// ID of the character which completed this job
    /// </summary>
    /// <value>ID of the character which completed this job</value>
    [DataMember(Name="completed_character_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "completed_character_id")]
    public int? CompletedCharacterId { get; set; }

    /// <summary>
    /// Date and time when this job was completed
    /// </summary>
    /// <value>Date and time when this job was completed</value>
    [DataMember(Name="completed_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "completed_date")]
    public DateTime? CompletedDate { get; set; }

    /// <summary>
    /// The sume of job installation fee and industry facility tax
    /// </summary>
    /// <value>The sume of job installation fee and industry facility tax</value>
    [DataMember(Name="cost", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cost")]
    public double? Cost { get; set; }

    /// <summary>
    /// Job duration in seconds
    /// </summary>
    /// <value>Job duration in seconds</value>
    [DataMember(Name="duration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "duration")]
    public int? Duration { get; set; }

    /// <summary>
    /// Date and time when this job finished
    /// </summary>
    /// <value>Date and time when this job finished</value>
    [DataMember(Name="end_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "end_date")]
    public DateTime? EndDate { get; set; }

    /// <summary>
    /// ID of the facility where this job is running
    /// </summary>
    /// <value>ID of the facility where this job is running</value>
    [DataMember(Name="facility_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "facility_id")]
    public long? FacilityId { get; set; }

    /// <summary>
    /// ID of the character which installed this job
    /// </summary>
    /// <value>ID of the character which installed this job</value>
    [DataMember(Name="installer_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "installer_id")]
    public int? InstallerId { get; set; }

    /// <summary>
    /// Unique job ID
    /// </summary>
    /// <value>Unique job ID</value>
    [DataMember(Name="job_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "job_id")]
    public int? JobId { get; set; }

    /// <summary>
    /// Number of runs blueprint is licensed for
    /// </summary>
    /// <value>Number of runs blueprint is licensed for</value>
    [DataMember(Name="licensed_runs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "licensed_runs")]
    public int? LicensedRuns { get; set; }

    /// <summary>
    /// Location ID of the location to which the output of the job will be delivered. Normally a station ID, but can also be a corporation facility
    /// </summary>
    /// <value>Location ID of the location to which the output of the job will be delivered. Normally a station ID, but can also be a corporation facility</value>
    [DataMember(Name="output_location_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "output_location_id")]
    public long? OutputLocationId { get; set; }

    /// <summary>
    /// Date and time when this job was paused (i.e. time when the facility where this job was installed went offline)
    /// </summary>
    /// <value>Date and time when this job was paused (i.e. time when the facility where this job was installed went offline)</value>
    [DataMember(Name="pause_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pause_date")]
    public DateTime? PauseDate { get; set; }

    /// <summary>
    /// Chance of success for invention
    /// </summary>
    /// <value>Chance of success for invention</value>
    [DataMember(Name="probability", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "probability")]
    public float? Probability { get; set; }

    /// <summary>
    /// Type ID of product (manufactured, copied or invented)
    /// </summary>
    /// <value>Type ID of product (manufactured, copied or invented)</value>
    [DataMember(Name="product_type_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "product_type_id")]
    public int? ProductTypeId { get; set; }

    /// <summary>
    /// Number of runs for a manufacturing job, or number of copies to make for a blueprint copy
    /// </summary>
    /// <value>Number of runs for a manufacturing job, or number of copies to make for a blueprint copy</value>
    [DataMember(Name="runs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "runs")]
    public int? Runs { get; set; }

    /// <summary>
    /// Date and time when this job started
    /// </summary>
    /// <value>Date and time when this job started</value>
    [DataMember(Name="start_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "start_date")]
    public DateTime? StartDate { get; set; }

    /// <summary>
    /// ID of the station where industry facility is located
    /// </summary>
    /// <value>ID of the station where industry facility is located</value>
    [DataMember(Name="station_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "station_id")]
    public long? StationId { get; set; }

    /// <summary>
    /// status string
    /// </summary>
    /// <value>status string</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Number of successful runs for this job. Equal to runs unless this is an invention job
    /// </summary>
    /// <value>Number of successful runs for this job. Equal to runs unless this is an invention job</value>
    [DataMember(Name="successful_runs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "successful_runs")]
    public int? SuccessfulRuns { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCharactersCharacterIdIndustryJobs200Ok {\n");
      sb.Append("  ActivityId: ").Append(ActivityId).Append("\n");
      sb.Append("  BlueprintId: ").Append(BlueprintId).Append("\n");
      sb.Append("  BlueprintLocationId: ").Append(BlueprintLocationId).Append("\n");
      sb.Append("  BlueprintTypeId: ").Append(BlueprintTypeId).Append("\n");
      sb.Append("  CompletedCharacterId: ").Append(CompletedCharacterId).Append("\n");
      sb.Append("  CompletedDate: ").Append(CompletedDate).Append("\n");
      sb.Append("  Cost: ").Append(Cost).Append("\n");
      sb.Append("  Duration: ").Append(Duration).Append("\n");
      sb.Append("  EndDate: ").Append(EndDate).Append("\n");
      sb.Append("  FacilityId: ").Append(FacilityId).Append("\n");
      sb.Append("  InstallerId: ").Append(InstallerId).Append("\n");
      sb.Append("  JobId: ").Append(JobId).Append("\n");
      sb.Append("  LicensedRuns: ").Append(LicensedRuns).Append("\n");
      sb.Append("  OutputLocationId: ").Append(OutputLocationId).Append("\n");
      sb.Append("  PauseDate: ").Append(PauseDate).Append("\n");
      sb.Append("  Probability: ").Append(Probability).Append("\n");
      sb.Append("  ProductTypeId: ").Append(ProductTypeId).Append("\n");
      sb.Append("  Runs: ").Append(Runs).Append("\n");
      sb.Append("  StartDate: ").Append(StartDate).Append("\n");
      sb.Append("  StationId: ").Append(StationId).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  SuccessfulRuns: ").Append(SuccessfulRuns).Append("\n");
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
