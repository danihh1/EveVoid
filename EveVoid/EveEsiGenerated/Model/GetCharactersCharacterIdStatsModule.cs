using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// module object
  /// </summary>
  [DataContract]
  public class GetCharactersCharacterIdStatsModule {
    /// <summary>
    /// activations_armor_hardener integer
    /// </summary>
    /// <value>activations_armor_hardener integer</value>
    [DataMember(Name="activations_armor_hardener", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_armor_hardener")]
    public long? ActivationsArmorHardener { get; set; }

    /// <summary>
    /// activations_armor_repair_unit integer
    /// </summary>
    /// <value>activations_armor_repair_unit integer</value>
    [DataMember(Name="activations_armor_repair_unit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_armor_repair_unit")]
    public long? ActivationsArmorRepairUnit { get; set; }

    /// <summary>
    /// activations_armor_resistance_shift_hardener integer
    /// </summary>
    /// <value>activations_armor_resistance_shift_hardener integer</value>
    [DataMember(Name="activations_armor_resistance_shift_hardener", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_armor_resistance_shift_hardener")]
    public long? ActivationsArmorResistanceShiftHardener { get; set; }

    /// <summary>
    /// activations_automated_targeting_system integer
    /// </summary>
    /// <value>activations_automated_targeting_system integer</value>
    [DataMember(Name="activations_automated_targeting_system", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_automated_targeting_system")]
    public long? ActivationsAutomatedTargetingSystem { get; set; }

    /// <summary>
    /// activations_bastion integer
    /// </summary>
    /// <value>activations_bastion integer</value>
    [DataMember(Name="activations_bastion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_bastion")]
    public long? ActivationsBastion { get; set; }

    /// <summary>
    /// activations_bomb_launcher integer
    /// </summary>
    /// <value>activations_bomb_launcher integer</value>
    [DataMember(Name="activations_bomb_launcher", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_bomb_launcher")]
    public long? ActivationsBombLauncher { get; set; }

    /// <summary>
    /// activations_capacitor_booster integer
    /// </summary>
    /// <value>activations_capacitor_booster integer</value>
    [DataMember(Name="activations_capacitor_booster", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_capacitor_booster")]
    public long? ActivationsCapacitorBooster { get; set; }

    /// <summary>
    /// activations_cargo_scanner integer
    /// </summary>
    /// <value>activations_cargo_scanner integer</value>
    [DataMember(Name="activations_cargo_scanner", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_cargo_scanner")]
    public long? ActivationsCargoScanner { get; set; }

    /// <summary>
    /// activations_cloaking_device integer
    /// </summary>
    /// <value>activations_cloaking_device integer</value>
    [DataMember(Name="activations_cloaking_device", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_cloaking_device")]
    public long? ActivationsCloakingDevice { get; set; }

    /// <summary>
    /// activations_clone_vat_bay integer
    /// </summary>
    /// <value>activations_clone_vat_bay integer</value>
    [DataMember(Name="activations_clone_vat_bay", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_clone_vat_bay")]
    public long? ActivationsCloneVatBay { get; set; }

    /// <summary>
    /// activations_cynosural_field integer
    /// </summary>
    /// <value>activations_cynosural_field integer</value>
    [DataMember(Name="activations_cynosural_field", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_cynosural_field")]
    public long? ActivationsCynosuralField { get; set; }

    /// <summary>
    /// activations_damage_control integer
    /// </summary>
    /// <value>activations_damage_control integer</value>
    [DataMember(Name="activations_damage_control", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_damage_control")]
    public long? ActivationsDamageControl { get; set; }

    /// <summary>
    /// activations_data_miners integer
    /// </summary>
    /// <value>activations_data_miners integer</value>
    [DataMember(Name="activations_data_miners", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_data_miners")]
    public long? ActivationsDataMiners { get; set; }

    /// <summary>
    /// activations_drone_control_unit integer
    /// </summary>
    /// <value>activations_drone_control_unit integer</value>
    [DataMember(Name="activations_drone_control_unit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_drone_control_unit")]
    public long? ActivationsDroneControlUnit { get; set; }

    /// <summary>
    /// activations_drone_tracking_modules integer
    /// </summary>
    /// <value>activations_drone_tracking_modules integer</value>
    [DataMember(Name="activations_drone_tracking_modules", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_drone_tracking_modules")]
    public long? ActivationsDroneTrackingModules { get; set; }

    /// <summary>
    /// activations_eccm integer
    /// </summary>
    /// <value>activations_eccm integer</value>
    [DataMember(Name="activations_eccm", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_eccm")]
    public long? ActivationsEccm { get; set; }

    /// <summary>
    /// activations_ecm integer
    /// </summary>
    /// <value>activations_ecm integer</value>
    [DataMember(Name="activations_ecm", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_ecm")]
    public long? ActivationsEcm { get; set; }

    /// <summary>
    /// activations_ecm_burst integer
    /// </summary>
    /// <value>activations_ecm_burst integer</value>
    [DataMember(Name="activations_ecm_burst", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_ecm_burst")]
    public long? ActivationsEcmBurst { get; set; }

    /// <summary>
    /// activations_energy_destabilizer integer
    /// </summary>
    /// <value>activations_energy_destabilizer integer</value>
    [DataMember(Name="activations_energy_destabilizer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_energy_destabilizer")]
    public long? ActivationsEnergyDestabilizer { get; set; }

    /// <summary>
    /// activations_energy_vampire integer
    /// </summary>
    /// <value>activations_energy_vampire integer</value>
    [DataMember(Name="activations_energy_vampire", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_energy_vampire")]
    public long? ActivationsEnergyVampire { get; set; }

    /// <summary>
    /// activations_energy_weapon integer
    /// </summary>
    /// <value>activations_energy_weapon integer</value>
    [DataMember(Name="activations_energy_weapon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_energy_weapon")]
    public long? ActivationsEnergyWeapon { get; set; }

    /// <summary>
    /// activations_festival_launcher integer
    /// </summary>
    /// <value>activations_festival_launcher integer</value>
    [DataMember(Name="activations_festival_launcher", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_festival_launcher")]
    public long? ActivationsFestivalLauncher { get; set; }

    /// <summary>
    /// activations_frequency_mining_laser integer
    /// </summary>
    /// <value>activations_frequency_mining_laser integer</value>
    [DataMember(Name="activations_frequency_mining_laser", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_frequency_mining_laser")]
    public long? ActivationsFrequencyMiningLaser { get; set; }

    /// <summary>
    /// activations_fueled_armor_repairer integer
    /// </summary>
    /// <value>activations_fueled_armor_repairer integer</value>
    [DataMember(Name="activations_fueled_armor_repairer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_fueled_armor_repairer")]
    public long? ActivationsFueledArmorRepairer { get; set; }

    /// <summary>
    /// activations_fueled_shield_booster integer
    /// </summary>
    /// <value>activations_fueled_shield_booster integer</value>
    [DataMember(Name="activations_fueled_shield_booster", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_fueled_shield_booster")]
    public long? ActivationsFueledShieldBooster { get; set; }

    /// <summary>
    /// activations_gang_coordinator integer
    /// </summary>
    /// <value>activations_gang_coordinator integer</value>
    [DataMember(Name="activations_gang_coordinator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_gang_coordinator")]
    public long? ActivationsGangCoordinator { get; set; }

    /// <summary>
    /// activations_gas_cloud_harvester integer
    /// </summary>
    /// <value>activations_gas_cloud_harvester integer</value>
    [DataMember(Name="activations_gas_cloud_harvester", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_gas_cloud_harvester")]
    public long? ActivationsGasCloudHarvester { get; set; }

    /// <summary>
    /// activations_hull_repair_unit integer
    /// </summary>
    /// <value>activations_hull_repair_unit integer</value>
    [DataMember(Name="activations_hull_repair_unit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_hull_repair_unit")]
    public long? ActivationsHullRepairUnit { get; set; }

    /// <summary>
    /// activations_hybrid_weapon integer
    /// </summary>
    /// <value>activations_hybrid_weapon integer</value>
    [DataMember(Name="activations_hybrid_weapon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_hybrid_weapon")]
    public long? ActivationsHybridWeapon { get; set; }

    /// <summary>
    /// activations_industrial_core integer
    /// </summary>
    /// <value>activations_industrial_core integer</value>
    [DataMember(Name="activations_industrial_core", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_industrial_core")]
    public long? ActivationsIndustrialCore { get; set; }

    /// <summary>
    /// activations_interdiction_sphere_launcher integer
    /// </summary>
    /// <value>activations_interdiction_sphere_launcher integer</value>
    [DataMember(Name="activations_interdiction_sphere_launcher", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_interdiction_sphere_launcher")]
    public long? ActivationsInterdictionSphereLauncher { get; set; }

    /// <summary>
    /// activations_micro_jump_drive integer
    /// </summary>
    /// <value>activations_micro_jump_drive integer</value>
    [DataMember(Name="activations_micro_jump_drive", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_micro_jump_drive")]
    public long? ActivationsMicroJumpDrive { get; set; }

    /// <summary>
    /// activations_mining_laser integer
    /// </summary>
    /// <value>activations_mining_laser integer</value>
    [DataMember(Name="activations_mining_laser", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_mining_laser")]
    public long? ActivationsMiningLaser { get; set; }

    /// <summary>
    /// activations_missile_launcher integer
    /// </summary>
    /// <value>activations_missile_launcher integer</value>
    [DataMember(Name="activations_missile_launcher", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_missile_launcher")]
    public long? ActivationsMissileLauncher { get; set; }

    /// <summary>
    /// activations_passive_targeting_system integer
    /// </summary>
    /// <value>activations_passive_targeting_system integer</value>
    [DataMember(Name="activations_passive_targeting_system", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_passive_targeting_system")]
    public long? ActivationsPassiveTargetingSystem { get; set; }

    /// <summary>
    /// activations_probe_launcher integer
    /// </summary>
    /// <value>activations_probe_launcher integer</value>
    [DataMember(Name="activations_probe_launcher", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_probe_launcher")]
    public long? ActivationsProbeLauncher { get; set; }

    /// <summary>
    /// activations_projected_eccm integer
    /// </summary>
    /// <value>activations_projected_eccm integer</value>
    [DataMember(Name="activations_projected_eccm", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_projected_eccm")]
    public long? ActivationsProjectedEccm { get; set; }

    /// <summary>
    /// activations_projectile_weapon integer
    /// </summary>
    /// <value>activations_projectile_weapon integer</value>
    [DataMember(Name="activations_projectile_weapon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_projectile_weapon")]
    public long? ActivationsProjectileWeapon { get; set; }

    /// <summary>
    /// activations_propulsion_module integer
    /// </summary>
    /// <value>activations_propulsion_module integer</value>
    [DataMember(Name="activations_propulsion_module", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_propulsion_module")]
    public long? ActivationsPropulsionModule { get; set; }

    /// <summary>
    /// activations_remote_armor_repairer integer
    /// </summary>
    /// <value>activations_remote_armor_repairer integer</value>
    [DataMember(Name="activations_remote_armor_repairer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_remote_armor_repairer")]
    public long? ActivationsRemoteArmorRepairer { get; set; }

    /// <summary>
    /// activations_remote_capacitor_transmitter integer
    /// </summary>
    /// <value>activations_remote_capacitor_transmitter integer</value>
    [DataMember(Name="activations_remote_capacitor_transmitter", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_remote_capacitor_transmitter")]
    public long? ActivationsRemoteCapacitorTransmitter { get; set; }

    /// <summary>
    /// activations_remote_ecm_burst integer
    /// </summary>
    /// <value>activations_remote_ecm_burst integer</value>
    [DataMember(Name="activations_remote_ecm_burst", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_remote_ecm_burst")]
    public long? ActivationsRemoteEcmBurst { get; set; }

    /// <summary>
    /// activations_remote_hull_repairer integer
    /// </summary>
    /// <value>activations_remote_hull_repairer integer</value>
    [DataMember(Name="activations_remote_hull_repairer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_remote_hull_repairer")]
    public long? ActivationsRemoteHullRepairer { get; set; }

    /// <summary>
    /// activations_remote_sensor_booster integer
    /// </summary>
    /// <value>activations_remote_sensor_booster integer</value>
    [DataMember(Name="activations_remote_sensor_booster", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_remote_sensor_booster")]
    public long? ActivationsRemoteSensorBooster { get; set; }

    /// <summary>
    /// activations_remote_sensor_damper integer
    /// </summary>
    /// <value>activations_remote_sensor_damper integer</value>
    [DataMember(Name="activations_remote_sensor_damper", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_remote_sensor_damper")]
    public long? ActivationsRemoteSensorDamper { get; set; }

    /// <summary>
    /// activations_remote_shield_booster integer
    /// </summary>
    /// <value>activations_remote_shield_booster integer</value>
    [DataMember(Name="activations_remote_shield_booster", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_remote_shield_booster")]
    public long? ActivationsRemoteShieldBooster { get; set; }

    /// <summary>
    /// activations_remote_tracking_computer integer
    /// </summary>
    /// <value>activations_remote_tracking_computer integer</value>
    [DataMember(Name="activations_remote_tracking_computer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_remote_tracking_computer")]
    public long? ActivationsRemoteTrackingComputer { get; set; }

    /// <summary>
    /// activations_salvager integer
    /// </summary>
    /// <value>activations_salvager integer</value>
    [DataMember(Name="activations_salvager", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_salvager")]
    public long? ActivationsSalvager { get; set; }

    /// <summary>
    /// activations_sensor_booster integer
    /// </summary>
    /// <value>activations_sensor_booster integer</value>
    [DataMember(Name="activations_sensor_booster", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_sensor_booster")]
    public long? ActivationsSensorBooster { get; set; }

    /// <summary>
    /// activations_shield_booster integer
    /// </summary>
    /// <value>activations_shield_booster integer</value>
    [DataMember(Name="activations_shield_booster", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_shield_booster")]
    public long? ActivationsShieldBooster { get; set; }

    /// <summary>
    /// activations_shield_hardener integer
    /// </summary>
    /// <value>activations_shield_hardener integer</value>
    [DataMember(Name="activations_shield_hardener", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_shield_hardener")]
    public long? ActivationsShieldHardener { get; set; }

    /// <summary>
    /// activations_ship_scanner integer
    /// </summary>
    /// <value>activations_ship_scanner integer</value>
    [DataMember(Name="activations_ship_scanner", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_ship_scanner")]
    public long? ActivationsShipScanner { get; set; }

    /// <summary>
    /// activations_siege integer
    /// </summary>
    /// <value>activations_siege integer</value>
    [DataMember(Name="activations_siege", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_siege")]
    public long? ActivationsSiege { get; set; }

    /// <summary>
    /// activations_smart_bomb integer
    /// </summary>
    /// <value>activations_smart_bomb integer</value>
    [DataMember(Name="activations_smart_bomb", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_smart_bomb")]
    public long? ActivationsSmartBomb { get; set; }

    /// <summary>
    /// activations_stasis_web integer
    /// </summary>
    /// <value>activations_stasis_web integer</value>
    [DataMember(Name="activations_stasis_web", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_stasis_web")]
    public long? ActivationsStasisWeb { get; set; }

    /// <summary>
    /// activations_strip_miner integer
    /// </summary>
    /// <value>activations_strip_miner integer</value>
    [DataMember(Name="activations_strip_miner", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_strip_miner")]
    public long? ActivationsStripMiner { get; set; }

    /// <summary>
    /// activations_super_weapon integer
    /// </summary>
    /// <value>activations_super_weapon integer</value>
    [DataMember(Name="activations_super_weapon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_super_weapon")]
    public long? ActivationsSuperWeapon { get; set; }

    /// <summary>
    /// activations_survey_scanner integer
    /// </summary>
    /// <value>activations_survey_scanner integer</value>
    [DataMember(Name="activations_survey_scanner", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_survey_scanner")]
    public long? ActivationsSurveyScanner { get; set; }

    /// <summary>
    /// activations_target_breaker integer
    /// </summary>
    /// <value>activations_target_breaker integer</value>
    [DataMember(Name="activations_target_breaker", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_target_breaker")]
    public long? ActivationsTargetBreaker { get; set; }

    /// <summary>
    /// activations_target_painter integer
    /// </summary>
    /// <value>activations_target_painter integer</value>
    [DataMember(Name="activations_target_painter", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_target_painter")]
    public long? ActivationsTargetPainter { get; set; }

    /// <summary>
    /// activations_tracking_computer integer
    /// </summary>
    /// <value>activations_tracking_computer integer</value>
    [DataMember(Name="activations_tracking_computer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_tracking_computer")]
    public long? ActivationsTrackingComputer { get; set; }

    /// <summary>
    /// activations_tracking_disruptor integer
    /// </summary>
    /// <value>activations_tracking_disruptor integer</value>
    [DataMember(Name="activations_tracking_disruptor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_tracking_disruptor")]
    public long? ActivationsTrackingDisruptor { get; set; }

    /// <summary>
    /// activations_tractor_beam integer
    /// </summary>
    /// <value>activations_tractor_beam integer</value>
    [DataMember(Name="activations_tractor_beam", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_tractor_beam")]
    public long? ActivationsTractorBeam { get; set; }

    /// <summary>
    /// activations_triage integer
    /// </summary>
    /// <value>activations_triage integer</value>
    [DataMember(Name="activations_triage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_triage")]
    public long? ActivationsTriage { get; set; }

    /// <summary>
    /// activations_warp_disrupt_field_generator integer
    /// </summary>
    /// <value>activations_warp_disrupt_field_generator integer</value>
    [DataMember(Name="activations_warp_disrupt_field_generator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_warp_disrupt_field_generator")]
    public long? ActivationsWarpDisruptFieldGenerator { get; set; }

    /// <summary>
    /// activations_warp_scrambler integer
    /// </summary>
    /// <value>activations_warp_scrambler integer</value>
    [DataMember(Name="activations_warp_scrambler", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activations_warp_scrambler")]
    public long? ActivationsWarpScrambler { get; set; }

    /// <summary>
    /// link_weapons integer
    /// </summary>
    /// <value>link_weapons integer</value>
    [DataMember(Name="link_weapons", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "link_weapons")]
    public long? LinkWeapons { get; set; }

    /// <summary>
    /// overload integer
    /// </summary>
    /// <value>overload integer</value>
    [DataMember(Name="overload", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "overload")]
    public long? Overload { get; set; }

    /// <summary>
    /// repairs integer
    /// </summary>
    /// <value>repairs integer</value>
    [DataMember(Name="repairs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repairs")]
    public long? Repairs { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCharactersCharacterIdStatsModule {\n");
      sb.Append("  ActivationsArmorHardener: ").Append(ActivationsArmorHardener).Append("\n");
      sb.Append("  ActivationsArmorRepairUnit: ").Append(ActivationsArmorRepairUnit).Append("\n");
      sb.Append("  ActivationsArmorResistanceShiftHardener: ").Append(ActivationsArmorResistanceShiftHardener).Append("\n");
      sb.Append("  ActivationsAutomatedTargetingSystem: ").Append(ActivationsAutomatedTargetingSystem).Append("\n");
      sb.Append("  ActivationsBastion: ").Append(ActivationsBastion).Append("\n");
      sb.Append("  ActivationsBombLauncher: ").Append(ActivationsBombLauncher).Append("\n");
      sb.Append("  ActivationsCapacitorBooster: ").Append(ActivationsCapacitorBooster).Append("\n");
      sb.Append("  ActivationsCargoScanner: ").Append(ActivationsCargoScanner).Append("\n");
      sb.Append("  ActivationsCloakingDevice: ").Append(ActivationsCloakingDevice).Append("\n");
      sb.Append("  ActivationsCloneVatBay: ").Append(ActivationsCloneVatBay).Append("\n");
      sb.Append("  ActivationsCynosuralField: ").Append(ActivationsCynosuralField).Append("\n");
      sb.Append("  ActivationsDamageControl: ").Append(ActivationsDamageControl).Append("\n");
      sb.Append("  ActivationsDataMiners: ").Append(ActivationsDataMiners).Append("\n");
      sb.Append("  ActivationsDroneControlUnit: ").Append(ActivationsDroneControlUnit).Append("\n");
      sb.Append("  ActivationsDroneTrackingModules: ").Append(ActivationsDroneTrackingModules).Append("\n");
      sb.Append("  ActivationsEccm: ").Append(ActivationsEccm).Append("\n");
      sb.Append("  ActivationsEcm: ").Append(ActivationsEcm).Append("\n");
      sb.Append("  ActivationsEcmBurst: ").Append(ActivationsEcmBurst).Append("\n");
      sb.Append("  ActivationsEnergyDestabilizer: ").Append(ActivationsEnergyDestabilizer).Append("\n");
      sb.Append("  ActivationsEnergyVampire: ").Append(ActivationsEnergyVampire).Append("\n");
      sb.Append("  ActivationsEnergyWeapon: ").Append(ActivationsEnergyWeapon).Append("\n");
      sb.Append("  ActivationsFestivalLauncher: ").Append(ActivationsFestivalLauncher).Append("\n");
      sb.Append("  ActivationsFrequencyMiningLaser: ").Append(ActivationsFrequencyMiningLaser).Append("\n");
      sb.Append("  ActivationsFueledArmorRepairer: ").Append(ActivationsFueledArmorRepairer).Append("\n");
      sb.Append("  ActivationsFueledShieldBooster: ").Append(ActivationsFueledShieldBooster).Append("\n");
      sb.Append("  ActivationsGangCoordinator: ").Append(ActivationsGangCoordinator).Append("\n");
      sb.Append("  ActivationsGasCloudHarvester: ").Append(ActivationsGasCloudHarvester).Append("\n");
      sb.Append("  ActivationsHullRepairUnit: ").Append(ActivationsHullRepairUnit).Append("\n");
      sb.Append("  ActivationsHybridWeapon: ").Append(ActivationsHybridWeapon).Append("\n");
      sb.Append("  ActivationsIndustrialCore: ").Append(ActivationsIndustrialCore).Append("\n");
      sb.Append("  ActivationsInterdictionSphereLauncher: ").Append(ActivationsInterdictionSphereLauncher).Append("\n");
      sb.Append("  ActivationsMicroJumpDrive: ").Append(ActivationsMicroJumpDrive).Append("\n");
      sb.Append("  ActivationsMiningLaser: ").Append(ActivationsMiningLaser).Append("\n");
      sb.Append("  ActivationsMissileLauncher: ").Append(ActivationsMissileLauncher).Append("\n");
      sb.Append("  ActivationsPassiveTargetingSystem: ").Append(ActivationsPassiveTargetingSystem).Append("\n");
      sb.Append("  ActivationsProbeLauncher: ").Append(ActivationsProbeLauncher).Append("\n");
      sb.Append("  ActivationsProjectedEccm: ").Append(ActivationsProjectedEccm).Append("\n");
      sb.Append("  ActivationsProjectileWeapon: ").Append(ActivationsProjectileWeapon).Append("\n");
      sb.Append("  ActivationsPropulsionModule: ").Append(ActivationsPropulsionModule).Append("\n");
      sb.Append("  ActivationsRemoteArmorRepairer: ").Append(ActivationsRemoteArmorRepairer).Append("\n");
      sb.Append("  ActivationsRemoteCapacitorTransmitter: ").Append(ActivationsRemoteCapacitorTransmitter).Append("\n");
      sb.Append("  ActivationsRemoteEcmBurst: ").Append(ActivationsRemoteEcmBurst).Append("\n");
      sb.Append("  ActivationsRemoteHullRepairer: ").Append(ActivationsRemoteHullRepairer).Append("\n");
      sb.Append("  ActivationsRemoteSensorBooster: ").Append(ActivationsRemoteSensorBooster).Append("\n");
      sb.Append("  ActivationsRemoteSensorDamper: ").Append(ActivationsRemoteSensorDamper).Append("\n");
      sb.Append("  ActivationsRemoteShieldBooster: ").Append(ActivationsRemoteShieldBooster).Append("\n");
      sb.Append("  ActivationsRemoteTrackingComputer: ").Append(ActivationsRemoteTrackingComputer).Append("\n");
      sb.Append("  ActivationsSalvager: ").Append(ActivationsSalvager).Append("\n");
      sb.Append("  ActivationsSensorBooster: ").Append(ActivationsSensorBooster).Append("\n");
      sb.Append("  ActivationsShieldBooster: ").Append(ActivationsShieldBooster).Append("\n");
      sb.Append("  ActivationsShieldHardener: ").Append(ActivationsShieldHardener).Append("\n");
      sb.Append("  ActivationsShipScanner: ").Append(ActivationsShipScanner).Append("\n");
      sb.Append("  ActivationsSiege: ").Append(ActivationsSiege).Append("\n");
      sb.Append("  ActivationsSmartBomb: ").Append(ActivationsSmartBomb).Append("\n");
      sb.Append("  ActivationsStasisWeb: ").Append(ActivationsStasisWeb).Append("\n");
      sb.Append("  ActivationsStripMiner: ").Append(ActivationsStripMiner).Append("\n");
      sb.Append("  ActivationsSuperWeapon: ").Append(ActivationsSuperWeapon).Append("\n");
      sb.Append("  ActivationsSurveyScanner: ").Append(ActivationsSurveyScanner).Append("\n");
      sb.Append("  ActivationsTargetBreaker: ").Append(ActivationsTargetBreaker).Append("\n");
      sb.Append("  ActivationsTargetPainter: ").Append(ActivationsTargetPainter).Append("\n");
      sb.Append("  ActivationsTrackingComputer: ").Append(ActivationsTrackingComputer).Append("\n");
      sb.Append("  ActivationsTrackingDisruptor: ").Append(ActivationsTrackingDisruptor).Append("\n");
      sb.Append("  ActivationsTractorBeam: ").Append(ActivationsTractorBeam).Append("\n");
      sb.Append("  ActivationsTriage: ").Append(ActivationsTriage).Append("\n");
      sb.Append("  ActivationsWarpDisruptFieldGenerator: ").Append(ActivationsWarpDisruptFieldGenerator).Append("\n");
      sb.Append("  ActivationsWarpScrambler: ").Append(ActivationsWarpScrambler).Append("\n");
      sb.Append("  LinkWeapons: ").Append(LinkWeapons).Append("\n");
      sb.Append("  Overload: ").Append(Overload).Append("\n");
      sb.Append("  Repairs: ").Append(Repairs).Append("\n");
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
