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
  public class GetCorporationsCorporationIdStructures200Ok {
    /// <summary>
    /// ID of the corporation that owns the structure
    /// </summary>
    /// <value>ID of the corporation that owns the structure</value>
    [DataMember(Name="corporation_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "corporation_id")]
    public int? CorporationId { get; set; }

    /// <summary>
    /// Date on which the structure will run out of fuel
    /// </summary>
    /// <value>Date on which the structure will run out of fuel</value>
    [DataMember(Name="fuel_expires", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fuel_expires")]
    public DateTime? FuelExpires { get; set; }

    /// <summary>
    /// The date and time when the structure's newly requested reinforcement times (e.g. next_reinforce_hour and next_reinforce_day) will take effect
    /// </summary>
    /// <value>The date and time when the structure's newly requested reinforcement times (e.g. next_reinforce_hour and next_reinforce_day) will take effect</value>
    [DataMember(Name="next_reinforce_apply", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "next_reinforce_apply")]
    public DateTime? NextReinforceApply { get; set; }

    /// <summary>
    /// The requested change to reinforce_hour that will take effect at the time shown by next_reinforce_apply
    /// </summary>
    /// <value>The requested change to reinforce_hour that will take effect at the time shown by next_reinforce_apply</value>
    [DataMember(Name="next_reinforce_hour", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "next_reinforce_hour")]
    public int? NextReinforceHour { get; set; }

    /// <summary>
    /// The requested change to reinforce_weekday that will take effect at the time shown by next_reinforce_apply
    /// </summary>
    /// <value>The requested change to reinforce_weekday that will take effect at the time shown by next_reinforce_apply</value>
    [DataMember(Name="next_reinforce_weekday", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "next_reinforce_weekday")]
    public int? NextReinforceWeekday { get; set; }

    /// <summary>
    /// The id of the ACL profile for this citadel
    /// </summary>
    /// <value>The id of the ACL profile for this citadel</value>
    [DataMember(Name="profile_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "profile_id")]
    public int? ProfileId { get; set; }

    /// <summary>
    /// The hour of day that determines the four hour window when the structure will randomly exit its reinforcement periods and become vulnerable to attack against its armor and/or hull. The structure will become vulnerable at a random time that is +/- 2 hours centered on the value of this property
    /// </summary>
    /// <value>The hour of day that determines the four hour window when the structure will randomly exit its reinforcement periods and become vulnerable to attack against its armor and/or hull. The structure will become vulnerable at a random time that is +/- 2 hours centered on the value of this property</value>
    [DataMember(Name="reinforce_hour", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reinforce_hour")]
    public int? ReinforceHour { get; set; }

    /// <summary>
    /// The day of the week when the structure exits its final reinforcement period and becomes vulnerable to attack against its hull. Monday is 0 and Sunday is 6
    /// </summary>
    /// <value>The day of the week when the structure exits its final reinforcement period and becomes vulnerable to attack against its hull. Monday is 0 and Sunday is 6</value>
    [DataMember(Name="reinforce_weekday", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reinforce_weekday")]
    public int? ReinforceWeekday { get; set; }

    /// <summary>
    /// Contains a list of service upgrades, and their state
    /// </summary>
    /// <value>Contains a list of service upgrades, and their state</value>
    [DataMember(Name="services", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "services")]
    public List<GetCorporationsCorporationIdStructuresService> Services { get; set; }

    /// <summary>
    /// state string
    /// </summary>
    /// <value>state string</value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// Date at which the structure will move to it's next state
    /// </summary>
    /// <value>Date at which the structure will move to it's next state</value>
    [DataMember(Name="state_timer_end", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state_timer_end")]
    public DateTime? StateTimerEnd { get; set; }

    /// <summary>
    /// Date at which the structure entered it's current state
    /// </summary>
    /// <value>Date at which the structure entered it's current state</value>
    [DataMember(Name="state_timer_start", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state_timer_start")]
    public DateTime? StateTimerStart { get; set; }

    /// <summary>
    /// The Item ID of the structure
    /// </summary>
    /// <value>The Item ID of the structure</value>
    [DataMember(Name="structure_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "structure_id")]
    public long? StructureId { get; set; }

    /// <summary>
    /// The solar system the structure is in
    /// </summary>
    /// <value>The solar system the structure is in</value>
    [DataMember(Name="system_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "system_id")]
    public int? SystemId { get; set; }

    /// <summary>
    /// The type id of the structure
    /// </summary>
    /// <value>The type id of the structure</value>
    [DataMember(Name="type_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type_id")]
    public int? TypeId { get; set; }

    /// <summary>
    /// Date at which the structure will unanchor
    /// </summary>
    /// <value>Date at which the structure will unanchor</value>
    [DataMember(Name="unanchors_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unanchors_at")]
    public DateTime? UnanchorsAt { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCorporationsCorporationIdStructures200Ok {\n");
      sb.Append("  CorporationId: ").Append(CorporationId).Append("\n");
      sb.Append("  FuelExpires: ").Append(FuelExpires).Append("\n");
      sb.Append("  NextReinforceApply: ").Append(NextReinforceApply).Append("\n");
      sb.Append("  NextReinforceHour: ").Append(NextReinforceHour).Append("\n");
      sb.Append("  NextReinforceWeekday: ").Append(NextReinforceWeekday).Append("\n");
      sb.Append("  ProfileId: ").Append(ProfileId).Append("\n");
      sb.Append("  ReinforceHour: ").Append(ReinforceHour).Append("\n");
      sb.Append("  ReinforceWeekday: ").Append(ReinforceWeekday).Append("\n");
      sb.Append("  Services: ").Append(Services).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  StateTimerEnd: ").Append(StateTimerEnd).Append("\n");
      sb.Append("  StateTimerStart: ").Append(StateTimerStart).Append("\n");
      sb.Append("  StructureId: ").Append(StructureId).Append("\n");
      sb.Append("  SystemId: ").Append(SystemId).Append("\n");
      sb.Append("  TypeId: ").Append(TypeId).Append("\n");
      sb.Append("  UnanchorsAt: ").Append(UnanchorsAt).Append("\n");
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
