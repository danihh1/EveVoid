using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// combat object
  /// </summary>
  [DataContract]
  public class GetCharactersCharacterIdStatsCombat {
    /// <summary>
    /// cap_drainedby_npc integer
    /// </summary>
    /// <value>cap_drainedby_npc integer</value>
    [DataMember(Name="cap_drainedby_npc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cap_drainedby_npc")]
    public long? CapDrainedbyNpc { get; set; }

    /// <summary>
    /// cap_drainedby_pc integer
    /// </summary>
    /// <value>cap_drainedby_pc integer</value>
    [DataMember(Name="cap_drainedby_pc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cap_drainedby_pc")]
    public long? CapDrainedbyPc { get; set; }

    /// <summary>
    /// cap_draining_pc integer
    /// </summary>
    /// <value>cap_draining_pc integer</value>
    [DataMember(Name="cap_draining_pc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cap_draining_pc")]
    public long? CapDrainingPc { get; set; }

    /// <summary>
    /// criminal_flag_set integer
    /// </summary>
    /// <value>criminal_flag_set integer</value>
    [DataMember(Name="criminal_flag_set", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "criminal_flag_set")]
    public long? CriminalFlagSet { get; set; }

    /// <summary>
    /// damage_from_np_cs_amount integer
    /// </summary>
    /// <value>damage_from_np_cs_amount integer</value>
    [DataMember(Name="damage_from_np_cs_amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "damage_from_np_cs_amount")]
    public long? DamageFromNpCsAmount { get; set; }

    /// <summary>
    /// damage_from_np_cs_num_shots integer
    /// </summary>
    /// <value>damage_from_np_cs_num_shots integer</value>
    [DataMember(Name="damage_from_np_cs_num_shots", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "damage_from_np_cs_num_shots")]
    public long? DamageFromNpCsNumShots { get; set; }

    /// <summary>
    /// damage_from_players_bomb_amount integer
    /// </summary>
    /// <value>damage_from_players_bomb_amount integer</value>
    [DataMember(Name="damage_from_players_bomb_amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "damage_from_players_bomb_amount")]
    public long? DamageFromPlayersBombAmount { get; set; }

    /// <summary>
    /// damage_from_players_bomb_num_shots integer
    /// </summary>
    /// <value>damage_from_players_bomb_num_shots integer</value>
    [DataMember(Name="damage_from_players_bomb_num_shots", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "damage_from_players_bomb_num_shots")]
    public long? DamageFromPlayersBombNumShots { get; set; }

    /// <summary>
    /// damage_from_players_combat_drone_amount integer
    /// </summary>
    /// <value>damage_from_players_combat_drone_amount integer</value>
    [DataMember(Name="damage_from_players_combat_drone_amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "damage_from_players_combat_drone_amount")]
    public long? DamageFromPlayersCombatDroneAmount { get; set; }

    /// <summary>
    /// damage_from_players_combat_drone_num_shots integer
    /// </summary>
    /// <value>damage_from_players_combat_drone_num_shots integer</value>
    [DataMember(Name="damage_from_players_combat_drone_num_shots", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "damage_from_players_combat_drone_num_shots")]
    public long? DamageFromPlayersCombatDroneNumShots { get; set; }

    /// <summary>
    /// damage_from_players_energy_amount integer
    /// </summary>
    /// <value>damage_from_players_energy_amount integer</value>
    [DataMember(Name="damage_from_players_energy_amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "damage_from_players_energy_amount")]
    public long? DamageFromPlayersEnergyAmount { get; set; }

    /// <summary>
    /// damage_from_players_energy_num_shots integer
    /// </summary>
    /// <value>damage_from_players_energy_num_shots integer</value>
    [DataMember(Name="damage_from_players_energy_num_shots", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "damage_from_players_energy_num_shots")]
    public long? DamageFromPlayersEnergyNumShots { get; set; }

    /// <summary>
    /// damage_from_players_fighter_bomber_amount integer
    /// </summary>
    /// <value>damage_from_players_fighter_bomber_amount integer</value>
    [DataMember(Name="damage_from_players_fighter_bomber_amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "damage_from_players_fighter_bomber_amount")]
    public long? DamageFromPlayersFighterBomberAmount { get; set; }

    /// <summary>
    /// damage_from_players_fighter_bomber_num_shots integer
    /// </summary>
    /// <value>damage_from_players_fighter_bomber_num_shots integer</value>
    [DataMember(Name="damage_from_players_fighter_bomber_num_shots", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "damage_from_players_fighter_bomber_num_shots")]
    public long? DamageFromPlayersFighterBomberNumShots { get; set; }

    /// <summary>
    /// damage_from_players_fighter_drone_amount integer
    /// </summary>
    /// <value>damage_from_players_fighter_drone_amount integer</value>
    [DataMember(Name="damage_from_players_fighter_drone_amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "damage_from_players_fighter_drone_amount")]
    public long? DamageFromPlayersFighterDroneAmount { get; set; }

    /// <summary>
    /// damage_from_players_fighter_drone_num_shots integer
    /// </summary>
    /// <value>damage_from_players_fighter_drone_num_shots integer</value>
    [DataMember(Name="damage_from_players_fighter_drone_num_shots", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "damage_from_players_fighter_drone_num_shots")]
    public long? DamageFromPlayersFighterDroneNumShots { get; set; }

    /// <summary>
    /// damage_from_players_hybrid_amount integer
    /// </summary>
    /// <value>damage_from_players_hybrid_amount integer</value>
    [DataMember(Name="damage_from_players_hybrid_amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "damage_from_players_hybrid_amount")]
    public long? DamageFromPlayersHybridAmount { get; set; }

    /// <summary>
    /// damage_from_players_hybrid_num_shots integer
    /// </summary>
    /// <value>damage_from_players_hybrid_num_shots integer</value>
    [DataMember(Name="damage_from_players_hybrid_num_shots", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "damage_from_players_hybrid_num_shots")]
    public long? DamageFromPlayersHybridNumShots { get; set; }

    /// <summary>
    /// damage_from_players_missile_amount integer
    /// </summary>
    /// <value>damage_from_players_missile_amount integer</value>
    [DataMember(Name="damage_from_players_missile_amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "damage_from_players_missile_amount")]
    public long? DamageFromPlayersMissileAmount { get; set; }

    /// <summary>
    /// damage_from_players_missile_num_shots integer
    /// </summary>
    /// <value>damage_from_players_missile_num_shots integer</value>
    [DataMember(Name="damage_from_players_missile_num_shots", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "damage_from_players_missile_num_shots")]
    public long? DamageFromPlayersMissileNumShots { get; set; }

    /// <summary>
    /// damage_from_players_projectile_amount integer
    /// </summary>
    /// <value>damage_from_players_projectile_amount integer</value>
    [DataMember(Name="damage_from_players_projectile_amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "damage_from_players_projectile_amount")]
    public long? DamageFromPlayersProjectileAmount { get; set; }

    /// <summary>
    /// damage_from_players_projectile_num_shots integer
    /// </summary>
    /// <value>damage_from_players_projectile_num_shots integer</value>
    [DataMember(Name="damage_from_players_projectile_num_shots", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "damage_from_players_projectile_num_shots")]
    public long? DamageFromPlayersProjectileNumShots { get; set; }

    /// <summary>
    /// damage_from_players_smart_bomb_amount integer
    /// </summary>
    /// <value>damage_from_players_smart_bomb_amount integer</value>
    [DataMember(Name="damage_from_players_smart_bomb_amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "damage_from_players_smart_bomb_amount")]
    public long? DamageFromPlayersSmartBombAmount { get; set; }

    /// <summary>
    /// damage_from_players_smart_bomb_num_shots integer
    /// </summary>
    /// <value>damage_from_players_smart_bomb_num_shots integer</value>
    [DataMember(Name="damage_from_players_smart_bomb_num_shots", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "damage_from_players_smart_bomb_num_shots")]
    public long? DamageFromPlayersSmartBombNumShots { get; set; }

    /// <summary>
    /// damage_from_players_super_amount integer
    /// </summary>
    /// <value>damage_from_players_super_amount integer</value>
    [DataMember(Name="damage_from_players_super_amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "damage_from_players_super_amount")]
    public long? DamageFromPlayersSuperAmount { get; set; }

    /// <summary>
    /// damage_from_players_super_num_shots integer
    /// </summary>
    /// <value>damage_from_players_super_num_shots integer</value>
    [DataMember(Name="damage_from_players_super_num_shots", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "damage_from_players_super_num_shots")]
    public long? DamageFromPlayersSuperNumShots { get; set; }

    /// <summary>
    /// damage_from_structures_total_amount integer
    /// </summary>
    /// <value>damage_from_structures_total_amount integer</value>
    [DataMember(Name="damage_from_structures_total_amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "damage_from_structures_total_amount")]
    public long? DamageFromStructuresTotalAmount { get; set; }

    /// <summary>
    /// damage_from_structures_total_num_shots integer
    /// </summary>
    /// <value>damage_from_structures_total_num_shots integer</value>
    [DataMember(Name="damage_from_structures_total_num_shots", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "damage_from_structures_total_num_shots")]
    public long? DamageFromStructuresTotalNumShots { get; set; }

    /// <summary>
    /// damage_to_players_bomb_amount integer
    /// </summary>
    /// <value>damage_to_players_bomb_amount integer</value>
    [DataMember(Name="damage_to_players_bomb_amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "damage_to_players_bomb_amount")]
    public long? DamageToPlayersBombAmount { get; set; }

    /// <summary>
    /// damage_to_players_bomb_num_shots integer
    /// </summary>
    /// <value>damage_to_players_bomb_num_shots integer</value>
    [DataMember(Name="damage_to_players_bomb_num_shots", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "damage_to_players_bomb_num_shots")]
    public long? DamageToPlayersBombNumShots { get; set; }

    /// <summary>
    /// damage_to_players_combat_drone_amount integer
    /// </summary>
    /// <value>damage_to_players_combat_drone_amount integer</value>
    [DataMember(Name="damage_to_players_combat_drone_amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "damage_to_players_combat_drone_amount")]
    public long? DamageToPlayersCombatDroneAmount { get; set; }

    /// <summary>
    /// damage_to_players_combat_drone_num_shots integer
    /// </summary>
    /// <value>damage_to_players_combat_drone_num_shots integer</value>
    [DataMember(Name="damage_to_players_combat_drone_num_shots", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "damage_to_players_combat_drone_num_shots")]
    public long? DamageToPlayersCombatDroneNumShots { get; set; }

    /// <summary>
    /// damage_to_players_energy_amount integer
    /// </summary>
    /// <value>damage_to_players_energy_amount integer</value>
    [DataMember(Name="damage_to_players_energy_amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "damage_to_players_energy_amount")]
    public long? DamageToPlayersEnergyAmount { get; set; }

    /// <summary>
    /// damage_to_players_energy_num_shots integer
    /// </summary>
    /// <value>damage_to_players_energy_num_shots integer</value>
    [DataMember(Name="damage_to_players_energy_num_shots", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "damage_to_players_energy_num_shots")]
    public long? DamageToPlayersEnergyNumShots { get; set; }

    /// <summary>
    /// damage_to_players_fighter_bomber_amount integer
    /// </summary>
    /// <value>damage_to_players_fighter_bomber_amount integer</value>
    [DataMember(Name="damage_to_players_fighter_bomber_amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "damage_to_players_fighter_bomber_amount")]
    public long? DamageToPlayersFighterBomberAmount { get; set; }

    /// <summary>
    /// damage_to_players_fighter_bomber_num_shots integer
    /// </summary>
    /// <value>damage_to_players_fighter_bomber_num_shots integer</value>
    [DataMember(Name="damage_to_players_fighter_bomber_num_shots", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "damage_to_players_fighter_bomber_num_shots")]
    public long? DamageToPlayersFighterBomberNumShots { get; set; }

    /// <summary>
    /// damage_to_players_fighter_drone_amount integer
    /// </summary>
    /// <value>damage_to_players_fighter_drone_amount integer</value>
    [DataMember(Name="damage_to_players_fighter_drone_amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "damage_to_players_fighter_drone_amount")]
    public long? DamageToPlayersFighterDroneAmount { get; set; }

    /// <summary>
    /// damage_to_players_fighter_drone_num_shots integer
    /// </summary>
    /// <value>damage_to_players_fighter_drone_num_shots integer</value>
    [DataMember(Name="damage_to_players_fighter_drone_num_shots", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "damage_to_players_fighter_drone_num_shots")]
    public long? DamageToPlayersFighterDroneNumShots { get; set; }

    /// <summary>
    /// damage_to_players_hybrid_amount integer
    /// </summary>
    /// <value>damage_to_players_hybrid_amount integer</value>
    [DataMember(Name="damage_to_players_hybrid_amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "damage_to_players_hybrid_amount")]
    public long? DamageToPlayersHybridAmount { get; set; }

    /// <summary>
    /// damage_to_players_hybrid_num_shots integer
    /// </summary>
    /// <value>damage_to_players_hybrid_num_shots integer</value>
    [DataMember(Name="damage_to_players_hybrid_num_shots", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "damage_to_players_hybrid_num_shots")]
    public long? DamageToPlayersHybridNumShots { get; set; }

    /// <summary>
    /// damage_to_players_missile_amount integer
    /// </summary>
    /// <value>damage_to_players_missile_amount integer</value>
    [DataMember(Name="damage_to_players_missile_amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "damage_to_players_missile_amount")]
    public long? DamageToPlayersMissileAmount { get; set; }

    /// <summary>
    /// damage_to_players_missile_num_shots integer
    /// </summary>
    /// <value>damage_to_players_missile_num_shots integer</value>
    [DataMember(Name="damage_to_players_missile_num_shots", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "damage_to_players_missile_num_shots")]
    public long? DamageToPlayersMissileNumShots { get; set; }

    /// <summary>
    /// damage_to_players_projectile_amount integer
    /// </summary>
    /// <value>damage_to_players_projectile_amount integer</value>
    [DataMember(Name="damage_to_players_projectile_amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "damage_to_players_projectile_amount")]
    public long? DamageToPlayersProjectileAmount { get; set; }

    /// <summary>
    /// damage_to_players_projectile_num_shots integer
    /// </summary>
    /// <value>damage_to_players_projectile_num_shots integer</value>
    [DataMember(Name="damage_to_players_projectile_num_shots", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "damage_to_players_projectile_num_shots")]
    public long? DamageToPlayersProjectileNumShots { get; set; }

    /// <summary>
    /// damage_to_players_smart_bomb_amount integer
    /// </summary>
    /// <value>damage_to_players_smart_bomb_amount integer</value>
    [DataMember(Name="damage_to_players_smart_bomb_amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "damage_to_players_smart_bomb_amount")]
    public long? DamageToPlayersSmartBombAmount { get; set; }

    /// <summary>
    /// damage_to_players_smart_bomb_num_shots integer
    /// </summary>
    /// <value>damage_to_players_smart_bomb_num_shots integer</value>
    [DataMember(Name="damage_to_players_smart_bomb_num_shots", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "damage_to_players_smart_bomb_num_shots")]
    public long? DamageToPlayersSmartBombNumShots { get; set; }

    /// <summary>
    /// damage_to_players_super_amount integer
    /// </summary>
    /// <value>damage_to_players_super_amount integer</value>
    [DataMember(Name="damage_to_players_super_amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "damage_to_players_super_amount")]
    public long? DamageToPlayersSuperAmount { get; set; }

    /// <summary>
    /// damage_to_players_super_num_shots integer
    /// </summary>
    /// <value>damage_to_players_super_num_shots integer</value>
    [DataMember(Name="damage_to_players_super_num_shots", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "damage_to_players_super_num_shots")]
    public long? DamageToPlayersSuperNumShots { get; set; }

    /// <summary>
    /// damage_to_structures_total_amount integer
    /// </summary>
    /// <value>damage_to_structures_total_amount integer</value>
    [DataMember(Name="damage_to_structures_total_amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "damage_to_structures_total_amount")]
    public long? DamageToStructuresTotalAmount { get; set; }

    /// <summary>
    /// damage_to_structures_total_num_shots integer
    /// </summary>
    /// <value>damage_to_structures_total_num_shots integer</value>
    [DataMember(Name="damage_to_structures_total_num_shots", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "damage_to_structures_total_num_shots")]
    public long? DamageToStructuresTotalNumShots { get; set; }

    /// <summary>
    /// deaths_high_sec integer
    /// </summary>
    /// <value>deaths_high_sec integer</value>
    [DataMember(Name="deaths_high_sec", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deaths_high_sec")]
    public long? DeathsHighSec { get; set; }

    /// <summary>
    /// deaths_low_sec integer
    /// </summary>
    /// <value>deaths_low_sec integer</value>
    [DataMember(Name="deaths_low_sec", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deaths_low_sec")]
    public long? DeathsLowSec { get; set; }

    /// <summary>
    /// deaths_null_sec integer
    /// </summary>
    /// <value>deaths_null_sec integer</value>
    [DataMember(Name="deaths_null_sec", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deaths_null_sec")]
    public long? DeathsNullSec { get; set; }

    /// <summary>
    /// deaths_pod_high_sec integer
    /// </summary>
    /// <value>deaths_pod_high_sec integer</value>
    [DataMember(Name="deaths_pod_high_sec", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deaths_pod_high_sec")]
    public long? DeathsPodHighSec { get; set; }

    /// <summary>
    /// deaths_pod_low_sec integer
    /// </summary>
    /// <value>deaths_pod_low_sec integer</value>
    [DataMember(Name="deaths_pod_low_sec", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deaths_pod_low_sec")]
    public long? DeathsPodLowSec { get; set; }

    /// <summary>
    /// deaths_pod_null_sec integer
    /// </summary>
    /// <value>deaths_pod_null_sec integer</value>
    [DataMember(Name="deaths_pod_null_sec", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deaths_pod_null_sec")]
    public long? DeathsPodNullSec { get; set; }

    /// <summary>
    /// deaths_pod_wormhole integer
    /// </summary>
    /// <value>deaths_pod_wormhole integer</value>
    [DataMember(Name="deaths_pod_wormhole", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deaths_pod_wormhole")]
    public long? DeathsPodWormhole { get; set; }

    /// <summary>
    /// deaths_wormhole integer
    /// </summary>
    /// <value>deaths_wormhole integer</value>
    [DataMember(Name="deaths_wormhole", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deaths_wormhole")]
    public long? DeathsWormhole { get; set; }

    /// <summary>
    /// drone_engage integer
    /// </summary>
    /// <value>drone_engage integer</value>
    [DataMember(Name="drone_engage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "drone_engage")]
    public long? DroneEngage { get; set; }

    /// <summary>
    /// dscans integer
    /// </summary>
    /// <value>dscans integer</value>
    [DataMember(Name="dscans", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dscans")]
    public long? Dscans { get; set; }

    /// <summary>
    /// duel_requested integer
    /// </summary>
    /// <value>duel_requested integer</value>
    [DataMember(Name="duel_requested", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "duel_requested")]
    public long? DuelRequested { get; set; }

    /// <summary>
    /// engagement_register integer
    /// </summary>
    /// <value>engagement_register integer</value>
    [DataMember(Name="engagement_register", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "engagement_register")]
    public long? EngagementRegister { get; set; }

    /// <summary>
    /// kills_assists integer
    /// </summary>
    /// <value>kills_assists integer</value>
    [DataMember(Name="kills_assists", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kills_assists")]
    public long? KillsAssists { get; set; }

    /// <summary>
    /// kills_high_sec integer
    /// </summary>
    /// <value>kills_high_sec integer</value>
    [DataMember(Name="kills_high_sec", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kills_high_sec")]
    public long? KillsHighSec { get; set; }

    /// <summary>
    /// kills_low_sec integer
    /// </summary>
    /// <value>kills_low_sec integer</value>
    [DataMember(Name="kills_low_sec", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kills_low_sec")]
    public long? KillsLowSec { get; set; }

    /// <summary>
    /// kills_null_sec integer
    /// </summary>
    /// <value>kills_null_sec integer</value>
    [DataMember(Name="kills_null_sec", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kills_null_sec")]
    public long? KillsNullSec { get; set; }

    /// <summary>
    /// kills_pod_high_sec integer
    /// </summary>
    /// <value>kills_pod_high_sec integer</value>
    [DataMember(Name="kills_pod_high_sec", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kills_pod_high_sec")]
    public long? KillsPodHighSec { get; set; }

    /// <summary>
    /// kills_pod_low_sec integer
    /// </summary>
    /// <value>kills_pod_low_sec integer</value>
    [DataMember(Name="kills_pod_low_sec", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kills_pod_low_sec")]
    public long? KillsPodLowSec { get; set; }

    /// <summary>
    /// kills_pod_null_sec integer
    /// </summary>
    /// <value>kills_pod_null_sec integer</value>
    [DataMember(Name="kills_pod_null_sec", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kills_pod_null_sec")]
    public long? KillsPodNullSec { get; set; }

    /// <summary>
    /// kills_pod_wormhole integer
    /// </summary>
    /// <value>kills_pod_wormhole integer</value>
    [DataMember(Name="kills_pod_wormhole", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kills_pod_wormhole")]
    public long? KillsPodWormhole { get; set; }

    /// <summary>
    /// kills_wormhole integer
    /// </summary>
    /// <value>kills_wormhole integer</value>
    [DataMember(Name="kills_wormhole", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kills_wormhole")]
    public long? KillsWormhole { get; set; }

    /// <summary>
    /// npc_flag_set integer
    /// </summary>
    /// <value>npc_flag_set integer</value>
    [DataMember(Name="npc_flag_set", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "npc_flag_set")]
    public long? NpcFlagSet { get; set; }

    /// <summary>
    /// probe_scans integer
    /// </summary>
    /// <value>probe_scans integer</value>
    [DataMember(Name="probe_scans", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "probe_scans")]
    public long? ProbeScans { get; set; }

    /// <summary>
    /// pvp_flag_set integer
    /// </summary>
    /// <value>pvp_flag_set integer</value>
    [DataMember(Name="pvp_flag_set", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pvp_flag_set")]
    public long? PvpFlagSet { get; set; }

    /// <summary>
    /// repair_armor_by_remote_amount integer
    /// </summary>
    /// <value>repair_armor_by_remote_amount integer</value>
    [DataMember(Name="repair_armor_by_remote_amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repair_armor_by_remote_amount")]
    public long? RepairArmorByRemoteAmount { get; set; }

    /// <summary>
    /// repair_armor_remote_amount integer
    /// </summary>
    /// <value>repair_armor_remote_amount integer</value>
    [DataMember(Name="repair_armor_remote_amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repair_armor_remote_amount")]
    public long? RepairArmorRemoteAmount { get; set; }

    /// <summary>
    /// repair_armor_self_amount integer
    /// </summary>
    /// <value>repair_armor_self_amount integer</value>
    [DataMember(Name="repair_armor_self_amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repair_armor_self_amount")]
    public long? RepairArmorSelfAmount { get; set; }

    /// <summary>
    /// repair_capacitor_by_remote_amount integer
    /// </summary>
    /// <value>repair_capacitor_by_remote_amount integer</value>
    [DataMember(Name="repair_capacitor_by_remote_amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repair_capacitor_by_remote_amount")]
    public long? RepairCapacitorByRemoteAmount { get; set; }

    /// <summary>
    /// repair_capacitor_remote_amount integer
    /// </summary>
    /// <value>repair_capacitor_remote_amount integer</value>
    [DataMember(Name="repair_capacitor_remote_amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repair_capacitor_remote_amount")]
    public long? RepairCapacitorRemoteAmount { get; set; }

    /// <summary>
    /// repair_capacitor_self_amount integer
    /// </summary>
    /// <value>repair_capacitor_self_amount integer</value>
    [DataMember(Name="repair_capacitor_self_amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repair_capacitor_self_amount")]
    public long? RepairCapacitorSelfAmount { get; set; }

    /// <summary>
    /// repair_hull_by_remote_amount integer
    /// </summary>
    /// <value>repair_hull_by_remote_amount integer</value>
    [DataMember(Name="repair_hull_by_remote_amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repair_hull_by_remote_amount")]
    public long? RepairHullByRemoteAmount { get; set; }

    /// <summary>
    /// repair_hull_remote_amount integer
    /// </summary>
    /// <value>repair_hull_remote_amount integer</value>
    [DataMember(Name="repair_hull_remote_amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repair_hull_remote_amount")]
    public long? RepairHullRemoteAmount { get; set; }

    /// <summary>
    /// repair_hull_self_amount integer
    /// </summary>
    /// <value>repair_hull_self_amount integer</value>
    [DataMember(Name="repair_hull_self_amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repair_hull_self_amount")]
    public long? RepairHullSelfAmount { get; set; }

    /// <summary>
    /// repair_shield_by_remote_amount integer
    /// </summary>
    /// <value>repair_shield_by_remote_amount integer</value>
    [DataMember(Name="repair_shield_by_remote_amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repair_shield_by_remote_amount")]
    public long? RepairShieldByRemoteAmount { get; set; }

    /// <summary>
    /// repair_shield_remote_amount integer
    /// </summary>
    /// <value>repair_shield_remote_amount integer</value>
    [DataMember(Name="repair_shield_remote_amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repair_shield_remote_amount")]
    public long? RepairShieldRemoteAmount { get; set; }

    /// <summary>
    /// repair_shield_self_amount integer
    /// </summary>
    /// <value>repair_shield_self_amount integer</value>
    [DataMember(Name="repair_shield_self_amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repair_shield_self_amount")]
    public long? RepairShieldSelfAmount { get; set; }

    /// <summary>
    /// self_destructs integer
    /// </summary>
    /// <value>self_destructs integer</value>
    [DataMember(Name="self_destructs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "self_destructs")]
    public long? SelfDestructs { get; set; }

    /// <summary>
    /// warp_scramble_pc integer
    /// </summary>
    /// <value>warp_scramble_pc integer</value>
    [DataMember(Name="warp_scramble_pc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "warp_scramble_pc")]
    public long? WarpScramblePc { get; set; }

    /// <summary>
    /// warp_scrambledby_npc integer
    /// </summary>
    /// <value>warp_scrambledby_npc integer</value>
    [DataMember(Name="warp_scrambledby_npc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "warp_scrambledby_npc")]
    public long? WarpScrambledbyNpc { get; set; }

    /// <summary>
    /// warp_scrambledby_pc integer
    /// </summary>
    /// <value>warp_scrambledby_pc integer</value>
    [DataMember(Name="warp_scrambledby_pc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "warp_scrambledby_pc")]
    public long? WarpScrambledbyPc { get; set; }

    /// <summary>
    /// weapon_flag_set integer
    /// </summary>
    /// <value>weapon_flag_set integer</value>
    [DataMember(Name="weapon_flag_set", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "weapon_flag_set")]
    public long? WeaponFlagSet { get; set; }

    /// <summary>
    /// webifiedby_npc integer
    /// </summary>
    /// <value>webifiedby_npc integer</value>
    [DataMember(Name="webifiedby_npc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "webifiedby_npc")]
    public long? WebifiedbyNpc { get; set; }

    /// <summary>
    /// webifiedby_pc integer
    /// </summary>
    /// <value>webifiedby_pc integer</value>
    [DataMember(Name="webifiedby_pc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "webifiedby_pc")]
    public long? WebifiedbyPc { get; set; }

    /// <summary>
    /// webifying_pc integer
    /// </summary>
    /// <value>webifying_pc integer</value>
    [DataMember(Name="webifying_pc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "webifying_pc")]
    public long? WebifyingPc { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetCharactersCharacterIdStatsCombat {\n");
      sb.Append("  CapDrainedbyNpc: ").Append(CapDrainedbyNpc).Append("\n");
      sb.Append("  CapDrainedbyPc: ").Append(CapDrainedbyPc).Append("\n");
      sb.Append("  CapDrainingPc: ").Append(CapDrainingPc).Append("\n");
      sb.Append("  CriminalFlagSet: ").Append(CriminalFlagSet).Append("\n");
      sb.Append("  DamageFromNpCsAmount: ").Append(DamageFromNpCsAmount).Append("\n");
      sb.Append("  DamageFromNpCsNumShots: ").Append(DamageFromNpCsNumShots).Append("\n");
      sb.Append("  DamageFromPlayersBombAmount: ").Append(DamageFromPlayersBombAmount).Append("\n");
      sb.Append("  DamageFromPlayersBombNumShots: ").Append(DamageFromPlayersBombNumShots).Append("\n");
      sb.Append("  DamageFromPlayersCombatDroneAmount: ").Append(DamageFromPlayersCombatDroneAmount).Append("\n");
      sb.Append("  DamageFromPlayersCombatDroneNumShots: ").Append(DamageFromPlayersCombatDroneNumShots).Append("\n");
      sb.Append("  DamageFromPlayersEnergyAmount: ").Append(DamageFromPlayersEnergyAmount).Append("\n");
      sb.Append("  DamageFromPlayersEnergyNumShots: ").Append(DamageFromPlayersEnergyNumShots).Append("\n");
      sb.Append("  DamageFromPlayersFighterBomberAmount: ").Append(DamageFromPlayersFighterBomberAmount).Append("\n");
      sb.Append("  DamageFromPlayersFighterBomberNumShots: ").Append(DamageFromPlayersFighterBomberNumShots).Append("\n");
      sb.Append("  DamageFromPlayersFighterDroneAmount: ").Append(DamageFromPlayersFighterDroneAmount).Append("\n");
      sb.Append("  DamageFromPlayersFighterDroneNumShots: ").Append(DamageFromPlayersFighterDroneNumShots).Append("\n");
      sb.Append("  DamageFromPlayersHybridAmount: ").Append(DamageFromPlayersHybridAmount).Append("\n");
      sb.Append("  DamageFromPlayersHybridNumShots: ").Append(DamageFromPlayersHybridNumShots).Append("\n");
      sb.Append("  DamageFromPlayersMissileAmount: ").Append(DamageFromPlayersMissileAmount).Append("\n");
      sb.Append("  DamageFromPlayersMissileNumShots: ").Append(DamageFromPlayersMissileNumShots).Append("\n");
      sb.Append("  DamageFromPlayersProjectileAmount: ").Append(DamageFromPlayersProjectileAmount).Append("\n");
      sb.Append("  DamageFromPlayersProjectileNumShots: ").Append(DamageFromPlayersProjectileNumShots).Append("\n");
      sb.Append("  DamageFromPlayersSmartBombAmount: ").Append(DamageFromPlayersSmartBombAmount).Append("\n");
      sb.Append("  DamageFromPlayersSmartBombNumShots: ").Append(DamageFromPlayersSmartBombNumShots).Append("\n");
      sb.Append("  DamageFromPlayersSuperAmount: ").Append(DamageFromPlayersSuperAmount).Append("\n");
      sb.Append("  DamageFromPlayersSuperNumShots: ").Append(DamageFromPlayersSuperNumShots).Append("\n");
      sb.Append("  DamageFromStructuresTotalAmount: ").Append(DamageFromStructuresTotalAmount).Append("\n");
      sb.Append("  DamageFromStructuresTotalNumShots: ").Append(DamageFromStructuresTotalNumShots).Append("\n");
      sb.Append("  DamageToPlayersBombAmount: ").Append(DamageToPlayersBombAmount).Append("\n");
      sb.Append("  DamageToPlayersBombNumShots: ").Append(DamageToPlayersBombNumShots).Append("\n");
      sb.Append("  DamageToPlayersCombatDroneAmount: ").Append(DamageToPlayersCombatDroneAmount).Append("\n");
      sb.Append("  DamageToPlayersCombatDroneNumShots: ").Append(DamageToPlayersCombatDroneNumShots).Append("\n");
      sb.Append("  DamageToPlayersEnergyAmount: ").Append(DamageToPlayersEnergyAmount).Append("\n");
      sb.Append("  DamageToPlayersEnergyNumShots: ").Append(DamageToPlayersEnergyNumShots).Append("\n");
      sb.Append("  DamageToPlayersFighterBomberAmount: ").Append(DamageToPlayersFighterBomberAmount).Append("\n");
      sb.Append("  DamageToPlayersFighterBomberNumShots: ").Append(DamageToPlayersFighterBomberNumShots).Append("\n");
      sb.Append("  DamageToPlayersFighterDroneAmount: ").Append(DamageToPlayersFighterDroneAmount).Append("\n");
      sb.Append("  DamageToPlayersFighterDroneNumShots: ").Append(DamageToPlayersFighterDroneNumShots).Append("\n");
      sb.Append("  DamageToPlayersHybridAmount: ").Append(DamageToPlayersHybridAmount).Append("\n");
      sb.Append("  DamageToPlayersHybridNumShots: ").Append(DamageToPlayersHybridNumShots).Append("\n");
      sb.Append("  DamageToPlayersMissileAmount: ").Append(DamageToPlayersMissileAmount).Append("\n");
      sb.Append("  DamageToPlayersMissileNumShots: ").Append(DamageToPlayersMissileNumShots).Append("\n");
      sb.Append("  DamageToPlayersProjectileAmount: ").Append(DamageToPlayersProjectileAmount).Append("\n");
      sb.Append("  DamageToPlayersProjectileNumShots: ").Append(DamageToPlayersProjectileNumShots).Append("\n");
      sb.Append("  DamageToPlayersSmartBombAmount: ").Append(DamageToPlayersSmartBombAmount).Append("\n");
      sb.Append("  DamageToPlayersSmartBombNumShots: ").Append(DamageToPlayersSmartBombNumShots).Append("\n");
      sb.Append("  DamageToPlayersSuperAmount: ").Append(DamageToPlayersSuperAmount).Append("\n");
      sb.Append("  DamageToPlayersSuperNumShots: ").Append(DamageToPlayersSuperNumShots).Append("\n");
      sb.Append("  DamageToStructuresTotalAmount: ").Append(DamageToStructuresTotalAmount).Append("\n");
      sb.Append("  DamageToStructuresTotalNumShots: ").Append(DamageToStructuresTotalNumShots).Append("\n");
      sb.Append("  DeathsHighSec: ").Append(DeathsHighSec).Append("\n");
      sb.Append("  DeathsLowSec: ").Append(DeathsLowSec).Append("\n");
      sb.Append("  DeathsNullSec: ").Append(DeathsNullSec).Append("\n");
      sb.Append("  DeathsPodHighSec: ").Append(DeathsPodHighSec).Append("\n");
      sb.Append("  DeathsPodLowSec: ").Append(DeathsPodLowSec).Append("\n");
      sb.Append("  DeathsPodNullSec: ").Append(DeathsPodNullSec).Append("\n");
      sb.Append("  DeathsPodWormhole: ").Append(DeathsPodWormhole).Append("\n");
      sb.Append("  DeathsWormhole: ").Append(DeathsWormhole).Append("\n");
      sb.Append("  DroneEngage: ").Append(DroneEngage).Append("\n");
      sb.Append("  Dscans: ").Append(Dscans).Append("\n");
      sb.Append("  DuelRequested: ").Append(DuelRequested).Append("\n");
      sb.Append("  EngagementRegister: ").Append(EngagementRegister).Append("\n");
      sb.Append("  KillsAssists: ").Append(KillsAssists).Append("\n");
      sb.Append("  KillsHighSec: ").Append(KillsHighSec).Append("\n");
      sb.Append("  KillsLowSec: ").Append(KillsLowSec).Append("\n");
      sb.Append("  KillsNullSec: ").Append(KillsNullSec).Append("\n");
      sb.Append("  KillsPodHighSec: ").Append(KillsPodHighSec).Append("\n");
      sb.Append("  KillsPodLowSec: ").Append(KillsPodLowSec).Append("\n");
      sb.Append("  KillsPodNullSec: ").Append(KillsPodNullSec).Append("\n");
      sb.Append("  KillsPodWormhole: ").Append(KillsPodWormhole).Append("\n");
      sb.Append("  KillsWormhole: ").Append(KillsWormhole).Append("\n");
      sb.Append("  NpcFlagSet: ").Append(NpcFlagSet).Append("\n");
      sb.Append("  ProbeScans: ").Append(ProbeScans).Append("\n");
      sb.Append("  PvpFlagSet: ").Append(PvpFlagSet).Append("\n");
      sb.Append("  RepairArmorByRemoteAmount: ").Append(RepairArmorByRemoteAmount).Append("\n");
      sb.Append("  RepairArmorRemoteAmount: ").Append(RepairArmorRemoteAmount).Append("\n");
      sb.Append("  RepairArmorSelfAmount: ").Append(RepairArmorSelfAmount).Append("\n");
      sb.Append("  RepairCapacitorByRemoteAmount: ").Append(RepairCapacitorByRemoteAmount).Append("\n");
      sb.Append("  RepairCapacitorRemoteAmount: ").Append(RepairCapacitorRemoteAmount).Append("\n");
      sb.Append("  RepairCapacitorSelfAmount: ").Append(RepairCapacitorSelfAmount).Append("\n");
      sb.Append("  RepairHullByRemoteAmount: ").Append(RepairHullByRemoteAmount).Append("\n");
      sb.Append("  RepairHullRemoteAmount: ").Append(RepairHullRemoteAmount).Append("\n");
      sb.Append("  RepairHullSelfAmount: ").Append(RepairHullSelfAmount).Append("\n");
      sb.Append("  RepairShieldByRemoteAmount: ").Append(RepairShieldByRemoteAmount).Append("\n");
      sb.Append("  RepairShieldRemoteAmount: ").Append(RepairShieldRemoteAmount).Append("\n");
      sb.Append("  RepairShieldSelfAmount: ").Append(RepairShieldSelfAmount).Append("\n");
      sb.Append("  SelfDestructs: ").Append(SelfDestructs).Append("\n");
      sb.Append("  WarpScramblePc: ").Append(WarpScramblePc).Append("\n");
      sb.Append("  WarpScrambledbyNpc: ").Append(WarpScrambledbyNpc).Append("\n");
      sb.Append("  WarpScrambledbyPc: ").Append(WarpScrambledbyPc).Append("\n");
      sb.Append("  WeaponFlagSet: ").Append(WeaponFlagSet).Append("\n");
      sb.Append("  WebifiedbyNpc: ").Append(WebifiedbyNpc).Append("\n");
      sb.Append("  WebifiedbyPc: ").Append(WebifiedbyPc).Append("\n");
      sb.Append("  WebifyingPc: ").Append(WebifyingPc).Append("\n");
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
