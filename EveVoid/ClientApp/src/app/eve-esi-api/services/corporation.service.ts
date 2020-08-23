/* tslint:disable */
import { Injectable } from '@angular/core';
import { HttpClient, HttpRequest, HttpResponse, HttpHeaders } from '@angular/common/http';
import { BaseService as __BaseService } from '../base-service';
import { ApiConfiguration as __Configuration } from '../api-configuration';
import { StrictHttpResponse as __StrictHttpResponse } from '../strict-http-response';
import { Observable as __Observable } from 'rxjs';
import { map as __map, filter as __filter } from 'rxjs/operators';

@Injectable({
  providedIn: 'root',
})
class CorporationService extends __BaseService {
  static readonly getCorporationsNpccorpsPath = '/corporations/npccorps/';
  static readonly getCorporationsCorporationIdPath = '/corporations/{corporation_id}/';
  static readonly getCorporationsCorporationIdAlliancehistoryPath = '/corporations/{corporation_id}/alliancehistory/';
  static readonly getCorporationsCorporationIdBlueprintsPath = '/corporations/{corporation_id}/blueprints/';
  static readonly getCorporationsCorporationIdContainersLogsPath = '/corporations/{corporation_id}/containers/logs/';
  static readonly getCorporationsCorporationIdDivisionsPath = '/corporations/{corporation_id}/divisions/';
  static readonly getCorporationsCorporationIdFacilitiesPath = '/corporations/{corporation_id}/facilities/';
  static readonly getCorporationsCorporationIdIconsPath = '/corporations/{corporation_id}/icons/';
  static readonly getCorporationsCorporationIdMedalsPath = '/corporations/{corporation_id}/medals/';
  static readonly getCorporationsCorporationIdMedalsIssuedPath = '/corporations/{corporation_id}/medals/issued/';
  static readonly getCorporationsCorporationIdMembersPath = '/corporations/{corporation_id}/members/';
  static readonly getCorporationsCorporationIdMembersLimitPath = '/corporations/{corporation_id}/members/limit/';
  static readonly getCorporationsCorporationIdMembersTitlesPath = '/corporations/{corporation_id}/members/titles/';
  static readonly getCorporationsCorporationIdMembertrackingPath = '/corporations/{corporation_id}/membertracking/';
  static readonly getCorporationsCorporationIdRolesPath = '/corporations/{corporation_id}/roles/';
  static readonly getCorporationsCorporationIdRolesHistoryPath = '/corporations/{corporation_id}/roles/history/';
  static readonly getCorporationsCorporationIdShareholdersPath = '/corporations/{corporation_id}/shareholders/';
  static readonly getCorporationsCorporationIdStandingsPath = '/corporations/{corporation_id}/standings/';
  static readonly getCorporationsCorporationIdStarbasesPath = '/corporations/{corporation_id}/starbases/';
  static readonly getCorporationsCorporationIdStarbasesStarbaseIdPath = '/corporations/{corporation_id}/starbases/{starbase_id}/';
  static readonly getCorporationsCorporationIdStructuresPath = '/corporations/{corporation_id}/structures/';
  static readonly getCorporationsCorporationIdTitlesPath = '/corporations/{corporation_id}/titles/';

  constructor(
    config: __Configuration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * Get npc corporations
   *
   * Get a list of npc corporations
   *
   * ---
   * Alternate route: `/dev/corporations/npccorps/`
   *
   * Alternate route: `/legacy/corporations/npccorps/`
   *
   * Alternate route: `/v1/corporations/npccorps/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `CorporationService.GetCorporationsNpccorpsParams` containing the following parameters:
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of npc corporation ids
   */
  getCorporationsNpccorpsResponse(params: CorporationService.GetCorporationsNpccorpsParams): __Observable<__StrictHttpResponse<Array<number>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/corporations/npccorps/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<number>>;
      })
    );
  }
  /**
   * Get npc corporations
   *
   * Get a list of npc corporations
   *
   * ---
   * Alternate route: `/dev/corporations/npccorps/`
   *
   * Alternate route: `/legacy/corporations/npccorps/`
   *
   * Alternate route: `/v1/corporations/npccorps/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `CorporationService.GetCorporationsNpccorpsParams` containing the following parameters:
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of npc corporation ids
   */
  getCorporationsNpccorps(params: CorporationService.GetCorporationsNpccorpsParams): __Observable<Array<number>> {
    return this.getCorporationsNpccorpsResponse(params).pipe(
      __map(_r => _r.body as Array<number>)
    );
  }

  /**
   * Get corporation information
   *
   * Public information about a corporation
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/`
   *
   * Alternate route: `/v4/corporations/{corporation_id}/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `CorporationService.GetCorporationsCorporationIdParams` containing the following parameters:
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Public information about a corporation
   */
  getCorporationsCorporationIdResponse(params: CorporationService.GetCorporationsCorporationIdParams): __Observable<__StrictHttpResponse<{alliance_id?: number, ceo_id: number, creator_id: number, date_founded?: string, description?: string, faction_id?: number, home_station_id?: number, member_count: number, name: string, shares?: number, tax_rate: number, ticker: string, url?: string, war_eligible?: boolean}>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/corporations/${encodeURIComponent(params.corporationId)}/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<{alliance_id?: number, ceo_id: number, creator_id: number, date_founded?: string, description?: string, faction_id?: number, home_station_id?: number, member_count: number, name: string, shares?: number, tax_rate: number, ticker: string, url?: string, war_eligible?: boolean}>;
      })
    );
  }
  /**
   * Get corporation information
   *
   * Public information about a corporation
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/`
   *
   * Alternate route: `/v4/corporations/{corporation_id}/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `CorporationService.GetCorporationsCorporationIdParams` containing the following parameters:
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Public information about a corporation
   */
  getCorporationsCorporationId(params: CorporationService.GetCorporationsCorporationIdParams): __Observable<{alliance_id?: number, ceo_id: number, creator_id: number, date_founded?: string, description?: string, faction_id?: number, home_station_id?: number, member_count: number, name: string, shares?: number, tax_rate: number, ticker: string, url?: string, war_eligible?: boolean}> {
    return this.getCorporationsCorporationIdResponse(params).pipe(
      __map(_r => _r.body as {alliance_id?: number, ceo_id: number, creator_id: number, date_founded?: string, description?: string, faction_id?: number, home_station_id?: number, member_count: number, name: string, shares?: number, tax_rate: number, ticker: string, url?: string, war_eligible?: boolean})
    );
  }

  /**
   * Get alliance history
   *
   * Get a list of all the alliances a corporation has been a member of
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/alliancehistory/`
   *
   * Alternate route: `/v2/corporations/{corporation_id}/alliancehistory/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `CorporationService.GetCorporationsCorporationIdAlliancehistoryParams` containing the following parameters:
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Alliance history for the given corporation
   */
  getCorporationsCorporationIdAlliancehistoryResponse(params: CorporationService.GetCorporationsCorporationIdAlliancehistoryParams): __Observable<__StrictHttpResponse<Array<{alliance_id?: number, is_deleted?: boolean, record_id: number, start_date: string}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/corporations/${encodeURIComponent(params.corporationId)}/alliancehistory/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{alliance_id?: number, is_deleted?: boolean, record_id: number, start_date: string}>>;
      })
    );
  }
  /**
   * Get alliance history
   *
   * Get a list of all the alliances a corporation has been a member of
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/alliancehistory/`
   *
   * Alternate route: `/v2/corporations/{corporation_id}/alliancehistory/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `CorporationService.GetCorporationsCorporationIdAlliancehistoryParams` containing the following parameters:
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Alliance history for the given corporation
   */
  getCorporationsCorporationIdAlliancehistory(params: CorporationService.GetCorporationsCorporationIdAlliancehistoryParams): __Observable<Array<{alliance_id?: number, is_deleted?: boolean, record_id: number, start_date: string}>> {
    return this.getCorporationsCorporationIdAlliancehistoryResponse(params).pipe(
      __map(_r => _r.body as Array<{alliance_id?: number, is_deleted?: boolean, record_id: number, start_date: string}>)
    );
  }

  /**
   * Get corporation blueprints
   *
   * Returns a list of blueprints the corporation owns
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/blueprints/`
   *
   * Alternate route: `/v2/corporations/{corporation_id}/blueprints/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   *
   * ---
   * Requires one of the following EVE corporation role(s): Director
   * @param params The `CorporationService.GetCorporationsCorporationIdBlueprintsParams` containing the following parameters:
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `page`: Which page of results to return
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return List of corporation blueprints
   */
  getCorporationsCorporationIdBlueprintsResponse(params: CorporationService.GetCorporationsCorporationIdBlueprintsParams): __Observable<__StrictHttpResponse<Array<{item_id: number, location_flag: 'AssetSafety' | 'AutoFit' | 'Bonus' | 'Booster' | 'BoosterBay' | 'Capsule' | 'Cargo' | 'CorpDeliveries' | 'CorpSAG1' | 'CorpSAG2' | 'CorpSAG3' | 'CorpSAG4' | 'CorpSAG5' | 'CorpSAG6' | 'CorpSAG7' | 'CrateLoot' | 'Deliveries' | 'DroneBay' | 'DustBattle' | 'DustDatabank' | 'FighterBay' | 'FighterTube0' | 'FighterTube1' | 'FighterTube2' | 'FighterTube3' | 'FighterTube4' | 'FleetHangar' | 'FrigateEscapeBay' | 'Hangar' | 'HangarAll' | 'HiSlot0' | 'HiSlot1' | 'HiSlot2' | 'HiSlot3' | 'HiSlot4' | 'HiSlot5' | 'HiSlot6' | 'HiSlot7' | 'HiddenModifiers' | 'Implant' | 'Impounded' | 'JunkyardReprocessed' | 'JunkyardTrashed' | 'LoSlot0' | 'LoSlot1' | 'LoSlot2' | 'LoSlot3' | 'LoSlot4' | 'LoSlot5' | 'LoSlot6' | 'LoSlot7' | 'Locked' | 'MedSlot0' | 'MedSlot1' | 'MedSlot2' | 'MedSlot3' | 'MedSlot4' | 'MedSlot5' | 'MedSlot6' | 'MedSlot7' | 'OfficeFolder' | 'Pilot' | 'PlanetSurface' | 'QuafeBay' | 'Reward' | 'RigSlot0' | 'RigSlot1' | 'RigSlot2' | 'RigSlot3' | 'RigSlot4' | 'RigSlot5' | 'RigSlot6' | 'RigSlot7' | 'SecondaryStorage' | 'ServiceSlot0' | 'ServiceSlot1' | 'ServiceSlot2' | 'ServiceSlot3' | 'ServiceSlot4' | 'ServiceSlot5' | 'ServiceSlot6' | 'ServiceSlot7' | 'ShipHangar' | 'ShipOffline' | 'Skill' | 'SkillInTraining' | 'SpecializedAmmoHold' | 'SpecializedCommandCenterHold' | 'SpecializedFuelBay' | 'SpecializedGasHold' | 'SpecializedIndustrialShipHold' | 'SpecializedLargeShipHold' | 'SpecializedMaterialBay' | 'SpecializedMediumShipHold' | 'SpecializedMineralHold' | 'SpecializedOreHold' | 'SpecializedPlanetaryCommoditiesHold' | 'SpecializedSalvageHold' | 'SpecializedShipHold' | 'SpecializedSmallShipHold' | 'StructureActive' | 'StructureFuel' | 'StructureInactive' | 'StructureOffline' | 'SubSystemBay' | 'SubSystemSlot0' | 'SubSystemSlot1' | 'SubSystemSlot2' | 'SubSystemSlot3' | 'SubSystemSlot4' | 'SubSystemSlot5' | 'SubSystemSlot6' | 'SubSystemSlot7' | 'Unlocked' | 'Wallet' | 'Wardrobe', location_id: number, material_efficiency: number, quantity: number, runs: number, time_efficiency: number, type_id: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.page != null) __params = __params.set('page', params.page.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/corporations/${encodeURIComponent(params.corporationId)}/blueprints/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{item_id: number, location_flag: 'AssetSafety' | 'AutoFit' | 'Bonus' | 'Booster' | 'BoosterBay' | 'Capsule' | 'Cargo' | 'CorpDeliveries' | 'CorpSAG1' | 'CorpSAG2' | 'CorpSAG3' | 'CorpSAG4' | 'CorpSAG5' | 'CorpSAG6' | 'CorpSAG7' | 'CrateLoot' | 'Deliveries' | 'DroneBay' | 'DustBattle' | 'DustDatabank' | 'FighterBay' | 'FighterTube0' | 'FighterTube1' | 'FighterTube2' | 'FighterTube3' | 'FighterTube4' | 'FleetHangar' | 'FrigateEscapeBay' | 'Hangar' | 'HangarAll' | 'HiSlot0' | 'HiSlot1' | 'HiSlot2' | 'HiSlot3' | 'HiSlot4' | 'HiSlot5' | 'HiSlot6' | 'HiSlot7' | 'HiddenModifiers' | 'Implant' | 'Impounded' | 'JunkyardReprocessed' | 'JunkyardTrashed' | 'LoSlot0' | 'LoSlot1' | 'LoSlot2' | 'LoSlot3' | 'LoSlot4' | 'LoSlot5' | 'LoSlot6' | 'LoSlot7' | 'Locked' | 'MedSlot0' | 'MedSlot1' | 'MedSlot2' | 'MedSlot3' | 'MedSlot4' | 'MedSlot5' | 'MedSlot6' | 'MedSlot7' | 'OfficeFolder' | 'Pilot' | 'PlanetSurface' | 'QuafeBay' | 'Reward' | 'RigSlot0' | 'RigSlot1' | 'RigSlot2' | 'RigSlot3' | 'RigSlot4' | 'RigSlot5' | 'RigSlot6' | 'RigSlot7' | 'SecondaryStorage' | 'ServiceSlot0' | 'ServiceSlot1' | 'ServiceSlot2' | 'ServiceSlot3' | 'ServiceSlot4' | 'ServiceSlot5' | 'ServiceSlot6' | 'ServiceSlot7' | 'ShipHangar' | 'ShipOffline' | 'Skill' | 'SkillInTraining' | 'SpecializedAmmoHold' | 'SpecializedCommandCenterHold' | 'SpecializedFuelBay' | 'SpecializedGasHold' | 'SpecializedIndustrialShipHold' | 'SpecializedLargeShipHold' | 'SpecializedMaterialBay' | 'SpecializedMediumShipHold' | 'SpecializedMineralHold' | 'SpecializedOreHold' | 'SpecializedPlanetaryCommoditiesHold' | 'SpecializedSalvageHold' | 'SpecializedShipHold' | 'SpecializedSmallShipHold' | 'StructureActive' | 'StructureFuel' | 'StructureInactive' | 'StructureOffline' | 'SubSystemBay' | 'SubSystemSlot0' | 'SubSystemSlot1' | 'SubSystemSlot2' | 'SubSystemSlot3' | 'SubSystemSlot4' | 'SubSystemSlot5' | 'SubSystemSlot6' | 'SubSystemSlot7' | 'Unlocked' | 'Wallet' | 'Wardrobe', location_id: number, material_efficiency: number, quantity: number, runs: number, time_efficiency: number, type_id: number}>>;
      })
    );
  }
  /**
   * Get corporation blueprints
   *
   * Returns a list of blueprints the corporation owns
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/blueprints/`
   *
   * Alternate route: `/v2/corporations/{corporation_id}/blueprints/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   *
   * ---
   * Requires one of the following EVE corporation role(s): Director
   * @param params The `CorporationService.GetCorporationsCorporationIdBlueprintsParams` containing the following parameters:
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `page`: Which page of results to return
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return List of corporation blueprints
   */
  getCorporationsCorporationIdBlueprints(params: CorporationService.GetCorporationsCorporationIdBlueprintsParams): __Observable<Array<{item_id: number, location_flag: 'AssetSafety' | 'AutoFit' | 'Bonus' | 'Booster' | 'BoosterBay' | 'Capsule' | 'Cargo' | 'CorpDeliveries' | 'CorpSAG1' | 'CorpSAG2' | 'CorpSAG3' | 'CorpSAG4' | 'CorpSAG5' | 'CorpSAG6' | 'CorpSAG7' | 'CrateLoot' | 'Deliveries' | 'DroneBay' | 'DustBattle' | 'DustDatabank' | 'FighterBay' | 'FighterTube0' | 'FighterTube1' | 'FighterTube2' | 'FighterTube3' | 'FighterTube4' | 'FleetHangar' | 'FrigateEscapeBay' | 'Hangar' | 'HangarAll' | 'HiSlot0' | 'HiSlot1' | 'HiSlot2' | 'HiSlot3' | 'HiSlot4' | 'HiSlot5' | 'HiSlot6' | 'HiSlot7' | 'HiddenModifiers' | 'Implant' | 'Impounded' | 'JunkyardReprocessed' | 'JunkyardTrashed' | 'LoSlot0' | 'LoSlot1' | 'LoSlot2' | 'LoSlot3' | 'LoSlot4' | 'LoSlot5' | 'LoSlot6' | 'LoSlot7' | 'Locked' | 'MedSlot0' | 'MedSlot1' | 'MedSlot2' | 'MedSlot3' | 'MedSlot4' | 'MedSlot5' | 'MedSlot6' | 'MedSlot7' | 'OfficeFolder' | 'Pilot' | 'PlanetSurface' | 'QuafeBay' | 'Reward' | 'RigSlot0' | 'RigSlot1' | 'RigSlot2' | 'RigSlot3' | 'RigSlot4' | 'RigSlot5' | 'RigSlot6' | 'RigSlot7' | 'SecondaryStorage' | 'ServiceSlot0' | 'ServiceSlot1' | 'ServiceSlot2' | 'ServiceSlot3' | 'ServiceSlot4' | 'ServiceSlot5' | 'ServiceSlot6' | 'ServiceSlot7' | 'ShipHangar' | 'ShipOffline' | 'Skill' | 'SkillInTraining' | 'SpecializedAmmoHold' | 'SpecializedCommandCenterHold' | 'SpecializedFuelBay' | 'SpecializedGasHold' | 'SpecializedIndustrialShipHold' | 'SpecializedLargeShipHold' | 'SpecializedMaterialBay' | 'SpecializedMediumShipHold' | 'SpecializedMineralHold' | 'SpecializedOreHold' | 'SpecializedPlanetaryCommoditiesHold' | 'SpecializedSalvageHold' | 'SpecializedShipHold' | 'SpecializedSmallShipHold' | 'StructureActive' | 'StructureFuel' | 'StructureInactive' | 'StructureOffline' | 'SubSystemBay' | 'SubSystemSlot0' | 'SubSystemSlot1' | 'SubSystemSlot2' | 'SubSystemSlot3' | 'SubSystemSlot4' | 'SubSystemSlot5' | 'SubSystemSlot6' | 'SubSystemSlot7' | 'Unlocked' | 'Wallet' | 'Wardrobe', location_id: number, material_efficiency: number, quantity: number, runs: number, time_efficiency: number, type_id: number}>> {
    return this.getCorporationsCorporationIdBlueprintsResponse(params).pipe(
      __map(_r => _r.body as Array<{item_id: number, location_flag: 'AssetSafety' | 'AutoFit' | 'Bonus' | 'Booster' | 'BoosterBay' | 'Capsule' | 'Cargo' | 'CorpDeliveries' | 'CorpSAG1' | 'CorpSAG2' | 'CorpSAG3' | 'CorpSAG4' | 'CorpSAG5' | 'CorpSAG6' | 'CorpSAG7' | 'CrateLoot' | 'Deliveries' | 'DroneBay' | 'DustBattle' | 'DustDatabank' | 'FighterBay' | 'FighterTube0' | 'FighterTube1' | 'FighterTube2' | 'FighterTube3' | 'FighterTube4' | 'FleetHangar' | 'FrigateEscapeBay' | 'Hangar' | 'HangarAll' | 'HiSlot0' | 'HiSlot1' | 'HiSlot2' | 'HiSlot3' | 'HiSlot4' | 'HiSlot5' | 'HiSlot6' | 'HiSlot7' | 'HiddenModifiers' | 'Implant' | 'Impounded' | 'JunkyardReprocessed' | 'JunkyardTrashed' | 'LoSlot0' | 'LoSlot1' | 'LoSlot2' | 'LoSlot3' | 'LoSlot4' | 'LoSlot5' | 'LoSlot6' | 'LoSlot7' | 'Locked' | 'MedSlot0' | 'MedSlot1' | 'MedSlot2' | 'MedSlot3' | 'MedSlot4' | 'MedSlot5' | 'MedSlot6' | 'MedSlot7' | 'OfficeFolder' | 'Pilot' | 'PlanetSurface' | 'QuafeBay' | 'Reward' | 'RigSlot0' | 'RigSlot1' | 'RigSlot2' | 'RigSlot3' | 'RigSlot4' | 'RigSlot5' | 'RigSlot6' | 'RigSlot7' | 'SecondaryStorage' | 'ServiceSlot0' | 'ServiceSlot1' | 'ServiceSlot2' | 'ServiceSlot3' | 'ServiceSlot4' | 'ServiceSlot5' | 'ServiceSlot6' | 'ServiceSlot7' | 'ShipHangar' | 'ShipOffline' | 'Skill' | 'SkillInTraining' | 'SpecializedAmmoHold' | 'SpecializedCommandCenterHold' | 'SpecializedFuelBay' | 'SpecializedGasHold' | 'SpecializedIndustrialShipHold' | 'SpecializedLargeShipHold' | 'SpecializedMaterialBay' | 'SpecializedMediumShipHold' | 'SpecializedMineralHold' | 'SpecializedOreHold' | 'SpecializedPlanetaryCommoditiesHold' | 'SpecializedSalvageHold' | 'SpecializedShipHold' | 'SpecializedSmallShipHold' | 'StructureActive' | 'StructureFuel' | 'StructureInactive' | 'StructureOffline' | 'SubSystemBay' | 'SubSystemSlot0' | 'SubSystemSlot1' | 'SubSystemSlot2' | 'SubSystemSlot3' | 'SubSystemSlot4' | 'SubSystemSlot5' | 'SubSystemSlot6' | 'SubSystemSlot7' | 'Unlocked' | 'Wallet' | 'Wardrobe', location_id: number, material_efficiency: number, quantity: number, runs: number, time_efficiency: number, type_id: number}>)
    );
  }

  /**
   * Get all corporation ALSC logs
   *
   * Returns logs recorded in the past seven days from all audit log secure containers (ALSC) owned by a given corporation
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/containers/logs/`
   *
   * Alternate route: `/v2/corporations/{corporation_id}/containers/logs/`
   *
   * ---
   * This route is cached for up to 600 seconds
   *
   * ---
   * Requires one of the following EVE corporation role(s): Director
   * @param params The `CorporationService.GetCorporationsCorporationIdContainersLogsParams` containing the following parameters:
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `page`: Which page of results to return
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return List of corporation ALSC logs
   */
  getCorporationsCorporationIdContainersLogsResponse(params: CorporationService.GetCorporationsCorporationIdContainersLogsParams): __Observable<__StrictHttpResponse<Array<{action: 'add' | 'assemble' | 'configure' | 'enter_password' | 'lock' | 'move' | 'repackage' | 'set_name' | 'set_password' | 'unlock', character_id: number, container_id: number, container_type_id: number, location_flag: 'AssetSafety' | 'AutoFit' | 'Bonus' | 'Booster' | 'BoosterBay' | 'Capsule' | 'Cargo' | 'CorpDeliveries' | 'CorpSAG1' | 'CorpSAG2' | 'CorpSAG3' | 'CorpSAG4' | 'CorpSAG5' | 'CorpSAG6' | 'CorpSAG7' | 'CrateLoot' | 'Deliveries' | 'DroneBay' | 'DustBattle' | 'DustDatabank' | 'FighterBay' | 'FighterTube0' | 'FighterTube1' | 'FighterTube2' | 'FighterTube3' | 'FighterTube4' | 'FleetHangar' | 'FrigateEscapeBay' | 'Hangar' | 'HangarAll' | 'HiSlot0' | 'HiSlot1' | 'HiSlot2' | 'HiSlot3' | 'HiSlot4' | 'HiSlot5' | 'HiSlot6' | 'HiSlot7' | 'HiddenModifiers' | 'Implant' | 'Impounded' | 'JunkyardReprocessed' | 'JunkyardTrashed' | 'LoSlot0' | 'LoSlot1' | 'LoSlot2' | 'LoSlot3' | 'LoSlot4' | 'LoSlot5' | 'LoSlot6' | 'LoSlot7' | 'Locked' | 'MedSlot0' | 'MedSlot1' | 'MedSlot2' | 'MedSlot3' | 'MedSlot4' | 'MedSlot5' | 'MedSlot6' | 'MedSlot7' | 'OfficeFolder' | 'Pilot' | 'PlanetSurface' | 'QuafeBay' | 'Reward' | 'RigSlot0' | 'RigSlot1' | 'RigSlot2' | 'RigSlot3' | 'RigSlot4' | 'RigSlot5' | 'RigSlot6' | 'RigSlot7' | 'SecondaryStorage' | 'ServiceSlot0' | 'ServiceSlot1' | 'ServiceSlot2' | 'ServiceSlot3' | 'ServiceSlot4' | 'ServiceSlot5' | 'ServiceSlot6' | 'ServiceSlot7' | 'ShipHangar' | 'ShipOffline' | 'Skill' | 'SkillInTraining' | 'SpecializedAmmoHold' | 'SpecializedCommandCenterHold' | 'SpecializedFuelBay' | 'SpecializedGasHold' | 'SpecializedIndustrialShipHold' | 'SpecializedLargeShipHold' | 'SpecializedMaterialBay' | 'SpecializedMediumShipHold' | 'SpecializedMineralHold' | 'SpecializedOreHold' | 'SpecializedPlanetaryCommoditiesHold' | 'SpecializedSalvageHold' | 'SpecializedShipHold' | 'SpecializedSmallShipHold' | 'StructureActive' | 'StructureFuel' | 'StructureInactive' | 'StructureOffline' | 'SubSystemBay' | 'SubSystemSlot0' | 'SubSystemSlot1' | 'SubSystemSlot2' | 'SubSystemSlot3' | 'SubSystemSlot4' | 'SubSystemSlot5' | 'SubSystemSlot6' | 'SubSystemSlot7' | 'Unlocked' | 'Wallet' | 'Wardrobe', location_id: number, logged_at: string, new_config_bitmask?: number, old_config_bitmask?: number, password_type?: 'config' | 'general', quantity?: number, type_id?: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.page != null) __params = __params.set('page', params.page.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/corporations/${encodeURIComponent(params.corporationId)}/containers/logs/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{action: 'add' | 'assemble' | 'configure' | 'enter_password' | 'lock' | 'move' | 'repackage' | 'set_name' | 'set_password' | 'unlock', character_id: number, container_id: number, container_type_id: number, location_flag: 'AssetSafety' | 'AutoFit' | 'Bonus' | 'Booster' | 'BoosterBay' | 'Capsule' | 'Cargo' | 'CorpDeliveries' | 'CorpSAG1' | 'CorpSAG2' | 'CorpSAG3' | 'CorpSAG4' | 'CorpSAG5' | 'CorpSAG6' | 'CorpSAG7' | 'CrateLoot' | 'Deliveries' | 'DroneBay' | 'DustBattle' | 'DustDatabank' | 'FighterBay' | 'FighterTube0' | 'FighterTube1' | 'FighterTube2' | 'FighterTube3' | 'FighterTube4' | 'FleetHangar' | 'FrigateEscapeBay' | 'Hangar' | 'HangarAll' | 'HiSlot0' | 'HiSlot1' | 'HiSlot2' | 'HiSlot3' | 'HiSlot4' | 'HiSlot5' | 'HiSlot6' | 'HiSlot7' | 'HiddenModifiers' | 'Implant' | 'Impounded' | 'JunkyardReprocessed' | 'JunkyardTrashed' | 'LoSlot0' | 'LoSlot1' | 'LoSlot2' | 'LoSlot3' | 'LoSlot4' | 'LoSlot5' | 'LoSlot6' | 'LoSlot7' | 'Locked' | 'MedSlot0' | 'MedSlot1' | 'MedSlot2' | 'MedSlot3' | 'MedSlot4' | 'MedSlot5' | 'MedSlot6' | 'MedSlot7' | 'OfficeFolder' | 'Pilot' | 'PlanetSurface' | 'QuafeBay' | 'Reward' | 'RigSlot0' | 'RigSlot1' | 'RigSlot2' | 'RigSlot3' | 'RigSlot4' | 'RigSlot5' | 'RigSlot6' | 'RigSlot7' | 'SecondaryStorage' | 'ServiceSlot0' | 'ServiceSlot1' | 'ServiceSlot2' | 'ServiceSlot3' | 'ServiceSlot4' | 'ServiceSlot5' | 'ServiceSlot6' | 'ServiceSlot7' | 'ShipHangar' | 'ShipOffline' | 'Skill' | 'SkillInTraining' | 'SpecializedAmmoHold' | 'SpecializedCommandCenterHold' | 'SpecializedFuelBay' | 'SpecializedGasHold' | 'SpecializedIndustrialShipHold' | 'SpecializedLargeShipHold' | 'SpecializedMaterialBay' | 'SpecializedMediumShipHold' | 'SpecializedMineralHold' | 'SpecializedOreHold' | 'SpecializedPlanetaryCommoditiesHold' | 'SpecializedSalvageHold' | 'SpecializedShipHold' | 'SpecializedSmallShipHold' | 'StructureActive' | 'StructureFuel' | 'StructureInactive' | 'StructureOffline' | 'SubSystemBay' | 'SubSystemSlot0' | 'SubSystemSlot1' | 'SubSystemSlot2' | 'SubSystemSlot3' | 'SubSystemSlot4' | 'SubSystemSlot5' | 'SubSystemSlot6' | 'SubSystemSlot7' | 'Unlocked' | 'Wallet' | 'Wardrobe', location_id: number, logged_at: string, new_config_bitmask?: number, old_config_bitmask?: number, password_type?: 'config' | 'general', quantity?: number, type_id?: number}>>;
      })
    );
  }
  /**
   * Get all corporation ALSC logs
   *
   * Returns logs recorded in the past seven days from all audit log secure containers (ALSC) owned by a given corporation
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/containers/logs/`
   *
   * Alternate route: `/v2/corporations/{corporation_id}/containers/logs/`
   *
   * ---
   * This route is cached for up to 600 seconds
   *
   * ---
   * Requires one of the following EVE corporation role(s): Director
   * @param params The `CorporationService.GetCorporationsCorporationIdContainersLogsParams` containing the following parameters:
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `page`: Which page of results to return
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return List of corporation ALSC logs
   */
  getCorporationsCorporationIdContainersLogs(params: CorporationService.GetCorporationsCorporationIdContainersLogsParams): __Observable<Array<{action: 'add' | 'assemble' | 'configure' | 'enter_password' | 'lock' | 'move' | 'repackage' | 'set_name' | 'set_password' | 'unlock', character_id: number, container_id: number, container_type_id: number, location_flag: 'AssetSafety' | 'AutoFit' | 'Bonus' | 'Booster' | 'BoosterBay' | 'Capsule' | 'Cargo' | 'CorpDeliveries' | 'CorpSAG1' | 'CorpSAG2' | 'CorpSAG3' | 'CorpSAG4' | 'CorpSAG5' | 'CorpSAG6' | 'CorpSAG7' | 'CrateLoot' | 'Deliveries' | 'DroneBay' | 'DustBattle' | 'DustDatabank' | 'FighterBay' | 'FighterTube0' | 'FighterTube1' | 'FighterTube2' | 'FighterTube3' | 'FighterTube4' | 'FleetHangar' | 'FrigateEscapeBay' | 'Hangar' | 'HangarAll' | 'HiSlot0' | 'HiSlot1' | 'HiSlot2' | 'HiSlot3' | 'HiSlot4' | 'HiSlot5' | 'HiSlot6' | 'HiSlot7' | 'HiddenModifiers' | 'Implant' | 'Impounded' | 'JunkyardReprocessed' | 'JunkyardTrashed' | 'LoSlot0' | 'LoSlot1' | 'LoSlot2' | 'LoSlot3' | 'LoSlot4' | 'LoSlot5' | 'LoSlot6' | 'LoSlot7' | 'Locked' | 'MedSlot0' | 'MedSlot1' | 'MedSlot2' | 'MedSlot3' | 'MedSlot4' | 'MedSlot5' | 'MedSlot6' | 'MedSlot7' | 'OfficeFolder' | 'Pilot' | 'PlanetSurface' | 'QuafeBay' | 'Reward' | 'RigSlot0' | 'RigSlot1' | 'RigSlot2' | 'RigSlot3' | 'RigSlot4' | 'RigSlot5' | 'RigSlot6' | 'RigSlot7' | 'SecondaryStorage' | 'ServiceSlot0' | 'ServiceSlot1' | 'ServiceSlot2' | 'ServiceSlot3' | 'ServiceSlot4' | 'ServiceSlot5' | 'ServiceSlot6' | 'ServiceSlot7' | 'ShipHangar' | 'ShipOffline' | 'Skill' | 'SkillInTraining' | 'SpecializedAmmoHold' | 'SpecializedCommandCenterHold' | 'SpecializedFuelBay' | 'SpecializedGasHold' | 'SpecializedIndustrialShipHold' | 'SpecializedLargeShipHold' | 'SpecializedMaterialBay' | 'SpecializedMediumShipHold' | 'SpecializedMineralHold' | 'SpecializedOreHold' | 'SpecializedPlanetaryCommoditiesHold' | 'SpecializedSalvageHold' | 'SpecializedShipHold' | 'SpecializedSmallShipHold' | 'StructureActive' | 'StructureFuel' | 'StructureInactive' | 'StructureOffline' | 'SubSystemBay' | 'SubSystemSlot0' | 'SubSystemSlot1' | 'SubSystemSlot2' | 'SubSystemSlot3' | 'SubSystemSlot4' | 'SubSystemSlot5' | 'SubSystemSlot6' | 'SubSystemSlot7' | 'Unlocked' | 'Wallet' | 'Wardrobe', location_id: number, logged_at: string, new_config_bitmask?: number, old_config_bitmask?: number, password_type?: 'config' | 'general', quantity?: number, type_id?: number}>> {
    return this.getCorporationsCorporationIdContainersLogsResponse(params).pipe(
      __map(_r => _r.body as Array<{action: 'add' | 'assemble' | 'configure' | 'enter_password' | 'lock' | 'move' | 'repackage' | 'set_name' | 'set_password' | 'unlock', character_id: number, container_id: number, container_type_id: number, location_flag: 'AssetSafety' | 'AutoFit' | 'Bonus' | 'Booster' | 'BoosterBay' | 'Capsule' | 'Cargo' | 'CorpDeliveries' | 'CorpSAG1' | 'CorpSAG2' | 'CorpSAG3' | 'CorpSAG4' | 'CorpSAG5' | 'CorpSAG6' | 'CorpSAG7' | 'CrateLoot' | 'Deliveries' | 'DroneBay' | 'DustBattle' | 'DustDatabank' | 'FighterBay' | 'FighterTube0' | 'FighterTube1' | 'FighterTube2' | 'FighterTube3' | 'FighterTube4' | 'FleetHangar' | 'FrigateEscapeBay' | 'Hangar' | 'HangarAll' | 'HiSlot0' | 'HiSlot1' | 'HiSlot2' | 'HiSlot3' | 'HiSlot4' | 'HiSlot5' | 'HiSlot6' | 'HiSlot7' | 'HiddenModifiers' | 'Implant' | 'Impounded' | 'JunkyardReprocessed' | 'JunkyardTrashed' | 'LoSlot0' | 'LoSlot1' | 'LoSlot2' | 'LoSlot3' | 'LoSlot4' | 'LoSlot5' | 'LoSlot6' | 'LoSlot7' | 'Locked' | 'MedSlot0' | 'MedSlot1' | 'MedSlot2' | 'MedSlot3' | 'MedSlot4' | 'MedSlot5' | 'MedSlot6' | 'MedSlot7' | 'OfficeFolder' | 'Pilot' | 'PlanetSurface' | 'QuafeBay' | 'Reward' | 'RigSlot0' | 'RigSlot1' | 'RigSlot2' | 'RigSlot3' | 'RigSlot4' | 'RigSlot5' | 'RigSlot6' | 'RigSlot7' | 'SecondaryStorage' | 'ServiceSlot0' | 'ServiceSlot1' | 'ServiceSlot2' | 'ServiceSlot3' | 'ServiceSlot4' | 'ServiceSlot5' | 'ServiceSlot6' | 'ServiceSlot7' | 'ShipHangar' | 'ShipOffline' | 'Skill' | 'SkillInTraining' | 'SpecializedAmmoHold' | 'SpecializedCommandCenterHold' | 'SpecializedFuelBay' | 'SpecializedGasHold' | 'SpecializedIndustrialShipHold' | 'SpecializedLargeShipHold' | 'SpecializedMaterialBay' | 'SpecializedMediumShipHold' | 'SpecializedMineralHold' | 'SpecializedOreHold' | 'SpecializedPlanetaryCommoditiesHold' | 'SpecializedSalvageHold' | 'SpecializedShipHold' | 'SpecializedSmallShipHold' | 'StructureActive' | 'StructureFuel' | 'StructureInactive' | 'StructureOffline' | 'SubSystemBay' | 'SubSystemSlot0' | 'SubSystemSlot1' | 'SubSystemSlot2' | 'SubSystemSlot3' | 'SubSystemSlot4' | 'SubSystemSlot5' | 'SubSystemSlot6' | 'SubSystemSlot7' | 'Unlocked' | 'Wallet' | 'Wardrobe', location_id: number, logged_at: string, new_config_bitmask?: number, old_config_bitmask?: number, password_type?: 'config' | 'general', quantity?: number, type_id?: number}>)
    );
  }

  /**
   * Get corporation divisions
   *
   * Return corporation hangar and wallet division names, only show if a division is not using the default name
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/divisions/`
   *
   * Alternate route: `/legacy/corporations/{corporation_id}/divisions/`
   *
   * Alternate route: `/v1/corporations/{corporation_id}/divisions/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   *
   * ---
   * Requires one of the following EVE corporation role(s): Director
   * @param params The `CorporationService.GetCorporationsCorporationIdDivisionsParams` containing the following parameters:
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return List of corporation division names
   */
  getCorporationsCorporationIdDivisionsResponse(params: CorporationService.GetCorporationsCorporationIdDivisionsParams): __Observable<__StrictHttpResponse<{hangar?: Array<{division?: number, name?: string}>, wallet?: Array<{division?: number, name?: string}>}>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/corporations/${encodeURIComponent(params.corporationId)}/divisions/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<{hangar?: Array<{division?: number, name?: string}>, wallet?: Array<{division?: number, name?: string}>}>;
      })
    );
  }
  /**
   * Get corporation divisions
   *
   * Return corporation hangar and wallet division names, only show if a division is not using the default name
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/divisions/`
   *
   * Alternate route: `/legacy/corporations/{corporation_id}/divisions/`
   *
   * Alternate route: `/v1/corporations/{corporation_id}/divisions/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   *
   * ---
   * Requires one of the following EVE corporation role(s): Director
   * @param params The `CorporationService.GetCorporationsCorporationIdDivisionsParams` containing the following parameters:
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return List of corporation division names
   */
  getCorporationsCorporationIdDivisions(params: CorporationService.GetCorporationsCorporationIdDivisionsParams): __Observable<{hangar?: Array<{division?: number, name?: string}>, wallet?: Array<{division?: number, name?: string}>}> {
    return this.getCorporationsCorporationIdDivisionsResponse(params).pipe(
      __map(_r => _r.body as {hangar?: Array<{division?: number, name?: string}>, wallet?: Array<{division?: number, name?: string}>})
    );
  }

  /**
   * Get corporation facilities
   *
   * Return a corporation's facilities
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/facilities/`
   *
   * Alternate route: `/legacy/corporations/{corporation_id}/facilities/`
   *
   * Alternate route: `/v1/corporations/{corporation_id}/facilities/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   *
   * ---
   * Requires one of the following EVE corporation role(s): Factory_Manager
   * @param params The `CorporationService.GetCorporationsCorporationIdFacilitiesParams` containing the following parameters:
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return List of corporation facilities
   */
  getCorporationsCorporationIdFacilitiesResponse(params: CorporationService.GetCorporationsCorporationIdFacilitiesParams): __Observable<__StrictHttpResponse<Array<{facility_id: number, system_id: number, type_id: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/corporations/${encodeURIComponent(params.corporationId)}/facilities/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{facility_id: number, system_id: number, type_id: number}>>;
      })
    );
  }
  /**
   * Get corporation facilities
   *
   * Return a corporation's facilities
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/facilities/`
   *
   * Alternate route: `/legacy/corporations/{corporation_id}/facilities/`
   *
   * Alternate route: `/v1/corporations/{corporation_id}/facilities/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   *
   * ---
   * Requires one of the following EVE corporation role(s): Factory_Manager
   * @param params The `CorporationService.GetCorporationsCorporationIdFacilitiesParams` containing the following parameters:
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return List of corporation facilities
   */
  getCorporationsCorporationIdFacilities(params: CorporationService.GetCorporationsCorporationIdFacilitiesParams): __Observable<Array<{facility_id: number, system_id: number, type_id: number}>> {
    return this.getCorporationsCorporationIdFacilitiesResponse(params).pipe(
      __map(_r => _r.body as Array<{facility_id: number, system_id: number, type_id: number}>)
    );
  }

  /**
   * Get corporation icon
   *
   * Get the icon urls for a corporation
   *
   * ---
   * Alternate route: `/legacy/corporations/{corporation_id}/icons/`
   *
   * Alternate route: `/v1/corporations/{corporation_id}/icons/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   *
   * ---
   * [Diff of the upcoming changes](https://esi.evetech.net/diff/latest/dev/#GET-/corporations/{corporation_id}/icons/)
   * @param params The `CorporationService.GetCorporationsCorporationIdIconsParams` containing the following parameters:
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Urls for icons for the given corporation id and server
   */
  getCorporationsCorporationIdIconsResponse(params: CorporationService.GetCorporationsCorporationIdIconsParams): __Observable<__StrictHttpResponse<{px128x128?: string, px256x256?: string, px64x64?: string}>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/corporations/${encodeURIComponent(params.corporationId)}/icons/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<{px128x128?: string, px256x256?: string, px64x64?: string}>;
      })
    );
  }
  /**
   * Get corporation icon
   *
   * Get the icon urls for a corporation
   *
   * ---
   * Alternate route: `/legacy/corporations/{corporation_id}/icons/`
   *
   * Alternate route: `/v1/corporations/{corporation_id}/icons/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   *
   * ---
   * [Diff of the upcoming changes](https://esi.evetech.net/diff/latest/dev/#GET-/corporations/{corporation_id}/icons/)
   * @param params The `CorporationService.GetCorporationsCorporationIdIconsParams` containing the following parameters:
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Urls for icons for the given corporation id and server
   */
  getCorporationsCorporationIdIcons(params: CorporationService.GetCorporationsCorporationIdIconsParams): __Observable<{px128x128?: string, px256x256?: string, px64x64?: string}> {
    return this.getCorporationsCorporationIdIconsResponse(params).pipe(
      __map(_r => _r.body as {px128x128?: string, px256x256?: string, px64x64?: string})
    );
  }

  /**
   * Get corporation medals
   *
   * Returns a corporation's medals
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/medals/`
   *
   * Alternate route: `/legacy/corporations/{corporation_id}/medals/`
   *
   * Alternate route: `/v1/corporations/{corporation_id}/medals/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `CorporationService.GetCorporationsCorporationIdMedalsParams` containing the following parameters:
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `page`: Which page of results to return
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of medals
   */
  getCorporationsCorporationIdMedalsResponse(params: CorporationService.GetCorporationsCorporationIdMedalsParams): __Observable<__StrictHttpResponse<Array<{created_at: string, creator_id: number, description: string, medal_id: number, title: string}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.page != null) __params = __params.set('page', params.page.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/corporations/${encodeURIComponent(params.corporationId)}/medals/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{created_at: string, creator_id: number, description: string, medal_id: number, title: string}>>;
      })
    );
  }
  /**
   * Get corporation medals
   *
   * Returns a corporation's medals
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/medals/`
   *
   * Alternate route: `/legacy/corporations/{corporation_id}/medals/`
   *
   * Alternate route: `/v1/corporations/{corporation_id}/medals/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `CorporationService.GetCorporationsCorporationIdMedalsParams` containing the following parameters:
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `page`: Which page of results to return
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of medals
   */
  getCorporationsCorporationIdMedals(params: CorporationService.GetCorporationsCorporationIdMedalsParams): __Observable<Array<{created_at: string, creator_id: number, description: string, medal_id: number, title: string}>> {
    return this.getCorporationsCorporationIdMedalsResponse(params).pipe(
      __map(_r => _r.body as Array<{created_at: string, creator_id: number, description: string, medal_id: number, title: string}>)
    );
  }

  /**
   * Get corporation issued medals
   *
   * Returns medals issued by a corporation
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/medals/issued/`
   *
   * Alternate route: `/legacy/corporations/{corporation_id}/medals/issued/`
   *
   * Alternate route: `/v1/corporations/{corporation_id}/medals/issued/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   *
   * ---
   * Requires one of the following EVE corporation role(s): Director
   * @param params The `CorporationService.GetCorporationsCorporationIdMedalsIssuedParams` containing the following parameters:
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `page`: Which page of results to return
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of issued medals
   */
  getCorporationsCorporationIdMedalsIssuedResponse(params: CorporationService.GetCorporationsCorporationIdMedalsIssuedParams): __Observable<__StrictHttpResponse<Array<{character_id: number, issued_at: string, issuer_id: number, medal_id: number, reason: string, status: 'private' | 'public'}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.page != null) __params = __params.set('page', params.page.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/corporations/${encodeURIComponent(params.corporationId)}/medals/issued/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{character_id: number, issued_at: string, issuer_id: number, medal_id: number, reason: string, status: 'private' | 'public'}>>;
      })
    );
  }
  /**
   * Get corporation issued medals
   *
   * Returns medals issued by a corporation
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/medals/issued/`
   *
   * Alternate route: `/legacy/corporations/{corporation_id}/medals/issued/`
   *
   * Alternate route: `/v1/corporations/{corporation_id}/medals/issued/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   *
   * ---
   * Requires one of the following EVE corporation role(s): Director
   * @param params The `CorporationService.GetCorporationsCorporationIdMedalsIssuedParams` containing the following parameters:
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `page`: Which page of results to return
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of issued medals
   */
  getCorporationsCorporationIdMedalsIssued(params: CorporationService.GetCorporationsCorporationIdMedalsIssuedParams): __Observable<Array<{character_id: number, issued_at: string, issuer_id: number, medal_id: number, reason: string, status: 'private' | 'public'}>> {
    return this.getCorporationsCorporationIdMedalsIssuedResponse(params).pipe(
      __map(_r => _r.body as Array<{character_id: number, issued_at: string, issuer_id: number, medal_id: number, reason: string, status: 'private' | 'public'}>)
    );
  }

  /**
   * Get corporation members
   *
   * Return the current member list of a corporation, the token's character need to be a member of the corporation.
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/members/`
   *
   * Alternate route: `/v3/corporations/{corporation_id}/members/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `CorporationService.GetCorporationsCorporationIdMembersParams` containing the following parameters:
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return List of member character IDs
   */
  getCorporationsCorporationIdMembersResponse(params: CorporationService.GetCorporationsCorporationIdMembersParams): __Observable<__StrictHttpResponse<Array<number>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/corporations/${encodeURIComponent(params.corporationId)}/members/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<number>>;
      })
    );
  }
  /**
   * Get corporation members
   *
   * Return the current member list of a corporation, the token's character need to be a member of the corporation.
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/members/`
   *
   * Alternate route: `/v3/corporations/{corporation_id}/members/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `CorporationService.GetCorporationsCorporationIdMembersParams` containing the following parameters:
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return List of member character IDs
   */
  getCorporationsCorporationIdMembers(params: CorporationService.GetCorporationsCorporationIdMembersParams): __Observable<Array<number>> {
    return this.getCorporationsCorporationIdMembersResponse(params).pipe(
      __map(_r => _r.body as Array<number>)
    );
  }

  /**
   * Get corporation member limit
   *
   * Return a corporation's member limit, not including CEO himself
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/members/limit/`
   *
   * Alternate route: `/legacy/corporations/{corporation_id}/members/limit/`
   *
   * Alternate route: `/v1/corporations/{corporation_id}/members/limit/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   *
   * ---
   * Requires one of the following EVE corporation role(s): Director
   * @param params The `CorporationService.GetCorporationsCorporationIdMembersLimitParams` containing the following parameters:
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return The corporation's member limit
   */
  getCorporationsCorporationIdMembersLimitResponse(params: CorporationService.GetCorporationsCorporationIdMembersLimitParams): __Observable<__StrictHttpResponse<number>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/corporations/${encodeURIComponent(params.corporationId)}/members/limit/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'text'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return (_r as HttpResponse<any>).clone({ body: parseFloat((_r as HttpResponse<any>).body as string) }) as __StrictHttpResponse<number>
      })
    );
  }
  /**
   * Get corporation member limit
   *
   * Return a corporation's member limit, not including CEO himself
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/members/limit/`
   *
   * Alternate route: `/legacy/corporations/{corporation_id}/members/limit/`
   *
   * Alternate route: `/v1/corporations/{corporation_id}/members/limit/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   *
   * ---
   * Requires one of the following EVE corporation role(s): Director
   * @param params The `CorporationService.GetCorporationsCorporationIdMembersLimitParams` containing the following parameters:
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return The corporation's member limit
   */
  getCorporationsCorporationIdMembersLimit(params: CorporationService.GetCorporationsCorporationIdMembersLimitParams): __Observable<number> {
    return this.getCorporationsCorporationIdMembersLimitResponse(params).pipe(
      __map(_r => _r.body as number)
    );
  }

  /**
   * Get corporation's members' titles
   *
   * Returns a corporation's members' titles
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/members/titles/`
   *
   * Alternate route: `/legacy/corporations/{corporation_id}/members/titles/`
   *
   * Alternate route: `/v1/corporations/{corporation_id}/members/titles/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   *
   * ---
   * Requires one of the following EVE corporation role(s): Director
   * @param params The `CorporationService.GetCorporationsCorporationIdMembersTitlesParams` containing the following parameters:
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of members and theirs titles
   */
  getCorporationsCorporationIdMembersTitlesResponse(params: CorporationService.GetCorporationsCorporationIdMembersTitlesParams): __Observable<__StrictHttpResponse<Array<{character_id: number, titles: Array<number>}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/corporations/${encodeURIComponent(params.corporationId)}/members/titles/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{character_id: number, titles: Array<number>}>>;
      })
    );
  }
  /**
   * Get corporation's members' titles
   *
   * Returns a corporation's members' titles
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/members/titles/`
   *
   * Alternate route: `/legacy/corporations/{corporation_id}/members/titles/`
   *
   * Alternate route: `/v1/corporations/{corporation_id}/members/titles/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   *
   * ---
   * Requires one of the following EVE corporation role(s): Director
   * @param params The `CorporationService.GetCorporationsCorporationIdMembersTitlesParams` containing the following parameters:
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of members and theirs titles
   */
  getCorporationsCorporationIdMembersTitles(params: CorporationService.GetCorporationsCorporationIdMembersTitlesParams): __Observable<Array<{character_id: number, titles: Array<number>}>> {
    return this.getCorporationsCorporationIdMembersTitlesResponse(params).pipe(
      __map(_r => _r.body as Array<{character_id: number, titles: Array<number>}>)
    );
  }

  /**
   * Track corporation members
   *
   * Returns additional information about a corporation's members which helps tracking their activities
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/membertracking/`
   *
   * Alternate route: `/legacy/corporations/{corporation_id}/membertracking/`
   *
   * Alternate route: `/v1/corporations/{corporation_id}/membertracking/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   *
   * ---
   * Requires one of the following EVE corporation role(s): Director
   * @param params The `CorporationService.GetCorporationsCorporationIdMembertrackingParams` containing the following parameters:
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return List of member character IDs
   */
  getCorporationsCorporationIdMembertrackingResponse(params: CorporationService.GetCorporationsCorporationIdMembertrackingParams): __Observable<__StrictHttpResponse<Array<{base_id?: number, character_id: number, location_id?: number, logoff_date?: string, logon_date?: string, ship_type_id?: number, start_date?: string}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/corporations/${encodeURIComponent(params.corporationId)}/membertracking/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{base_id?: number, character_id: number, location_id?: number, logoff_date?: string, logon_date?: string, ship_type_id?: number, start_date?: string}>>;
      })
    );
  }
  /**
   * Track corporation members
   *
   * Returns additional information about a corporation's members which helps tracking their activities
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/membertracking/`
   *
   * Alternate route: `/legacy/corporations/{corporation_id}/membertracking/`
   *
   * Alternate route: `/v1/corporations/{corporation_id}/membertracking/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   *
   * ---
   * Requires one of the following EVE corporation role(s): Director
   * @param params The `CorporationService.GetCorporationsCorporationIdMembertrackingParams` containing the following parameters:
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return List of member character IDs
   */
  getCorporationsCorporationIdMembertracking(params: CorporationService.GetCorporationsCorporationIdMembertrackingParams): __Observable<Array<{base_id?: number, character_id: number, location_id?: number, logoff_date?: string, logon_date?: string, ship_type_id?: number, start_date?: string}>> {
    return this.getCorporationsCorporationIdMembertrackingResponse(params).pipe(
      __map(_r => _r.body as Array<{base_id?: number, character_id: number, location_id?: number, logoff_date?: string, logon_date?: string, ship_type_id?: number, start_date?: string}>)
    );
  }

  /**
   * Get corporation member roles
   *
   * Return the roles of all members if the character has the personnel manager role or any grantable role.
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/roles/`
   *
   * Alternate route: `/legacy/corporations/{corporation_id}/roles/`
   *
   * Alternate route: `/v1/corporations/{corporation_id}/roles/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `CorporationService.GetCorporationsCorporationIdRolesParams` containing the following parameters:
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return List of member character ID's and roles
   */
  getCorporationsCorporationIdRolesResponse(params: CorporationService.GetCorporationsCorporationIdRolesParams): __Observable<__StrictHttpResponse<Array<{character_id: number, grantable_roles?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, grantable_roles_at_base?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, grantable_roles_at_hq?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, grantable_roles_at_other?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, roles?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, roles_at_base?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, roles_at_hq?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, roles_at_other?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/corporations/${encodeURIComponent(params.corporationId)}/roles/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{character_id: number, grantable_roles?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, grantable_roles_at_base?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, grantable_roles_at_hq?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, grantable_roles_at_other?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, roles?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, roles_at_base?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, roles_at_hq?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, roles_at_other?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>}>>;
      })
    );
  }
  /**
   * Get corporation member roles
   *
   * Return the roles of all members if the character has the personnel manager role or any grantable role.
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/roles/`
   *
   * Alternate route: `/legacy/corporations/{corporation_id}/roles/`
   *
   * Alternate route: `/v1/corporations/{corporation_id}/roles/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `CorporationService.GetCorporationsCorporationIdRolesParams` containing the following parameters:
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return List of member character ID's and roles
   */
  getCorporationsCorporationIdRoles(params: CorporationService.GetCorporationsCorporationIdRolesParams): __Observable<Array<{character_id: number, grantable_roles?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, grantable_roles_at_base?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, grantable_roles_at_hq?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, grantable_roles_at_other?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, roles?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, roles_at_base?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, roles_at_hq?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, roles_at_other?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>}>> {
    return this.getCorporationsCorporationIdRolesResponse(params).pipe(
      __map(_r => _r.body as Array<{character_id: number, grantable_roles?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, grantable_roles_at_base?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, grantable_roles_at_hq?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, grantable_roles_at_other?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, roles?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, roles_at_base?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, roles_at_hq?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, roles_at_other?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>}>)
    );
  }

  /**
   * Get corporation member roles history
   *
   * Return how roles have changed for a coporation's members, up to a month
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/roles/history/`
   *
   * Alternate route: `/legacy/corporations/{corporation_id}/roles/history/`
   *
   * Alternate route: `/v1/corporations/{corporation_id}/roles/history/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   *
   * ---
   * Requires one of the following EVE corporation role(s): Director
   * @param params The `CorporationService.GetCorporationsCorporationIdRolesHistoryParams` containing the following parameters:
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `page`: Which page of results to return
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return List of role changes
   */
  getCorporationsCorporationIdRolesHistoryResponse(params: CorporationService.GetCorporationsCorporationIdRolesHistoryParams): __Observable<__StrictHttpResponse<Array<{changed_at: string, character_id: number, issuer_id: number, new_roles: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, old_roles: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, role_type: 'grantable_roles' | 'grantable_roles_at_base' | 'grantable_roles_at_hq' | 'grantable_roles_at_other' | 'roles' | 'roles_at_base' | 'roles_at_hq' | 'roles_at_other'}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.page != null) __params = __params.set('page', params.page.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/corporations/${encodeURIComponent(params.corporationId)}/roles/history/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{changed_at: string, character_id: number, issuer_id: number, new_roles: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, old_roles: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, role_type: 'grantable_roles' | 'grantable_roles_at_base' | 'grantable_roles_at_hq' | 'grantable_roles_at_other' | 'roles' | 'roles_at_base' | 'roles_at_hq' | 'roles_at_other'}>>;
      })
    );
  }
  /**
   * Get corporation member roles history
   *
   * Return how roles have changed for a coporation's members, up to a month
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/roles/history/`
   *
   * Alternate route: `/legacy/corporations/{corporation_id}/roles/history/`
   *
   * Alternate route: `/v1/corporations/{corporation_id}/roles/history/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   *
   * ---
   * Requires one of the following EVE corporation role(s): Director
   * @param params The `CorporationService.GetCorporationsCorporationIdRolesHistoryParams` containing the following parameters:
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `page`: Which page of results to return
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return List of role changes
   */
  getCorporationsCorporationIdRolesHistory(params: CorporationService.GetCorporationsCorporationIdRolesHistoryParams): __Observable<Array<{changed_at: string, character_id: number, issuer_id: number, new_roles: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, old_roles: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, role_type: 'grantable_roles' | 'grantable_roles_at_base' | 'grantable_roles_at_hq' | 'grantable_roles_at_other' | 'roles' | 'roles_at_base' | 'roles_at_hq' | 'roles_at_other'}>> {
    return this.getCorporationsCorporationIdRolesHistoryResponse(params).pipe(
      __map(_r => _r.body as Array<{changed_at: string, character_id: number, issuer_id: number, new_roles: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, old_roles: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, role_type: 'grantable_roles' | 'grantable_roles_at_base' | 'grantable_roles_at_hq' | 'grantable_roles_at_other' | 'roles' | 'roles_at_base' | 'roles_at_hq' | 'roles_at_other'}>)
    );
  }

  /**
   * Get corporation shareholders
   *
   * Return the current shareholders of a corporation.
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/shareholders/`
   *
   * Alternate route: `/legacy/corporations/{corporation_id}/shareholders/`
   *
   * Alternate route: `/v1/corporations/{corporation_id}/shareholders/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   *
   * ---
   * Requires one of the following EVE corporation role(s): Director
   * @param params The `CorporationService.GetCorporationsCorporationIdShareholdersParams` containing the following parameters:
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `page`: Which page of results to return
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return List of shareholders
   */
  getCorporationsCorporationIdShareholdersResponse(params: CorporationService.GetCorporationsCorporationIdShareholdersParams): __Observable<__StrictHttpResponse<Array<{share_count: number, shareholder_id: number, shareholder_type: 'character' | 'corporation'}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.page != null) __params = __params.set('page', params.page.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/corporations/${encodeURIComponent(params.corporationId)}/shareholders/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{share_count: number, shareholder_id: number, shareholder_type: 'character' | 'corporation'}>>;
      })
    );
  }
  /**
   * Get corporation shareholders
   *
   * Return the current shareholders of a corporation.
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/shareholders/`
   *
   * Alternate route: `/legacy/corporations/{corporation_id}/shareholders/`
   *
   * Alternate route: `/v1/corporations/{corporation_id}/shareholders/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   *
   * ---
   * Requires one of the following EVE corporation role(s): Director
   * @param params The `CorporationService.GetCorporationsCorporationIdShareholdersParams` containing the following parameters:
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `page`: Which page of results to return
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return List of shareholders
   */
  getCorporationsCorporationIdShareholders(params: CorporationService.GetCorporationsCorporationIdShareholdersParams): __Observable<Array<{share_count: number, shareholder_id: number, shareholder_type: 'character' | 'corporation'}>> {
    return this.getCorporationsCorporationIdShareholdersResponse(params).pipe(
      __map(_r => _r.body as Array<{share_count: number, shareholder_id: number, shareholder_type: 'character' | 'corporation'}>)
    );
  }

  /**
   * Get corporation standings
   *
   * Return corporation standings from agents, NPC corporations, and factions
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/standings/`
   *
   * Alternate route: `/legacy/corporations/{corporation_id}/standings/`
   *
   * Alternate route: `/v1/corporations/{corporation_id}/standings/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `CorporationService.GetCorporationsCorporationIdStandingsParams` containing the following parameters:
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `page`: Which page of results to return
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of standings
   */
  getCorporationsCorporationIdStandingsResponse(params: CorporationService.GetCorporationsCorporationIdStandingsParams): __Observable<__StrictHttpResponse<Array<{from_id: number, from_type: 'agent' | 'npc_corp' | 'faction', standing: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.page != null) __params = __params.set('page', params.page.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/corporations/${encodeURIComponent(params.corporationId)}/standings/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{from_id: number, from_type: 'agent' | 'npc_corp' | 'faction', standing: number}>>;
      })
    );
  }
  /**
   * Get corporation standings
   *
   * Return corporation standings from agents, NPC corporations, and factions
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/standings/`
   *
   * Alternate route: `/legacy/corporations/{corporation_id}/standings/`
   *
   * Alternate route: `/v1/corporations/{corporation_id}/standings/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `CorporationService.GetCorporationsCorporationIdStandingsParams` containing the following parameters:
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `page`: Which page of results to return
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of standings
   */
  getCorporationsCorporationIdStandings(params: CorporationService.GetCorporationsCorporationIdStandingsParams): __Observable<Array<{from_id: number, from_type: 'agent' | 'npc_corp' | 'faction', standing: number}>> {
    return this.getCorporationsCorporationIdStandingsResponse(params).pipe(
      __map(_r => _r.body as Array<{from_id: number, from_type: 'agent' | 'npc_corp' | 'faction', standing: number}>)
    );
  }

  /**
   * Get corporation starbases (POSes)
   *
   * Returns list of corporation starbases (POSes)
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/starbases/`
   *
   * Alternate route: `/legacy/corporations/{corporation_id}/starbases/`
   *
   * Alternate route: `/v1/corporations/{corporation_id}/starbases/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   *
   * ---
   * Requires one of the following EVE corporation role(s): Director
   * @param params The `CorporationService.GetCorporationsCorporationIdStarbasesParams` containing the following parameters:
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `page`: Which page of results to return
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return List of starbases (POSes)
   */
  getCorporationsCorporationIdStarbasesResponse(params: CorporationService.GetCorporationsCorporationIdStarbasesParams): __Observable<__StrictHttpResponse<Array<{moon_id?: number, onlined_since?: string, reinforced_until?: string, starbase_id: number, state?: 'offline' | 'online' | 'onlining' | 'reinforced' | 'unanchoring', system_id: number, type_id: number, unanchor_at?: string}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.page != null) __params = __params.set('page', params.page.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/corporations/${encodeURIComponent(params.corporationId)}/starbases/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{moon_id?: number, onlined_since?: string, reinforced_until?: string, starbase_id: number, state?: 'offline' | 'online' | 'onlining' | 'reinforced' | 'unanchoring', system_id: number, type_id: number, unanchor_at?: string}>>;
      })
    );
  }
  /**
   * Get corporation starbases (POSes)
   *
   * Returns list of corporation starbases (POSes)
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/starbases/`
   *
   * Alternate route: `/legacy/corporations/{corporation_id}/starbases/`
   *
   * Alternate route: `/v1/corporations/{corporation_id}/starbases/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   *
   * ---
   * Requires one of the following EVE corporation role(s): Director
   * @param params The `CorporationService.GetCorporationsCorporationIdStarbasesParams` containing the following parameters:
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `page`: Which page of results to return
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return List of starbases (POSes)
   */
  getCorporationsCorporationIdStarbases(params: CorporationService.GetCorporationsCorporationIdStarbasesParams): __Observable<Array<{moon_id?: number, onlined_since?: string, reinforced_until?: string, starbase_id: number, state?: 'offline' | 'online' | 'onlining' | 'reinforced' | 'unanchoring', system_id: number, type_id: number, unanchor_at?: string}>> {
    return this.getCorporationsCorporationIdStarbasesResponse(params).pipe(
      __map(_r => _r.body as Array<{moon_id?: number, onlined_since?: string, reinforced_until?: string, starbase_id: number, state?: 'offline' | 'online' | 'onlining' | 'reinforced' | 'unanchoring', system_id: number, type_id: number, unanchor_at?: string}>)
    );
  }

  /**
   * Get starbase (POS) detail
   *
   * Returns various settings and fuels of a starbase (POS)
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/starbases/{starbase_id}/`
   *
   * Alternate route: `/legacy/corporations/{corporation_id}/starbases/{starbase_id}/`
   *
   * Alternate route: `/v1/corporations/{corporation_id}/starbases/{starbase_id}/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   *
   * ---
   * Requires one of the following EVE corporation role(s): Director
   * @param params The `CorporationService.GetCorporationsCorporationIdStarbasesStarbaseIdParams` containing the following parameters:
   *
   * - `system_id`: The solar system this starbase (POS) is located in,
   *
   * - `starbase_id`: An EVE starbase (POS) ID
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return List of starbases (POSes)
   */
  getCorporationsCorporationIdStarbasesStarbaseIdResponse(params: CorporationService.GetCorporationsCorporationIdStarbasesStarbaseIdParams): __Observable<__StrictHttpResponse<{allow_alliance_members: boolean, allow_corporation_members: boolean, anchor: 'alliance_member' | 'config_starbase_equipment_role' | 'corporation_member' | 'starbase_fuel_technician_role', attack_if_at_war: boolean, attack_if_other_security_status_dropping: boolean, attack_security_status_threshold?: number, attack_standing_threshold?: number, fuel_bay_take: 'alliance_member' | 'config_starbase_equipment_role' | 'corporation_member' | 'starbase_fuel_technician_role', fuel_bay_view: 'alliance_member' | 'config_starbase_equipment_role' | 'corporation_member' | 'starbase_fuel_technician_role', fuels?: Array<{quantity: number, type_id: number}>, offline: 'alliance_member' | 'config_starbase_equipment_role' | 'corporation_member' | 'starbase_fuel_technician_role', online: 'alliance_member' | 'config_starbase_equipment_role' | 'corporation_member' | 'starbase_fuel_technician_role', unanchor: 'alliance_member' | 'config_starbase_equipment_role' | 'corporation_member' | 'starbase_fuel_technician_role', use_alliance_standings: boolean}>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.systemId != null) __params = __params.set('system_id', params.systemId.toString());


    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/corporations/${encodeURIComponent(params.corporationId)}/starbases/${encodeURIComponent(params.starbaseId)}/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<{allow_alliance_members: boolean, allow_corporation_members: boolean, anchor: 'alliance_member' | 'config_starbase_equipment_role' | 'corporation_member' | 'starbase_fuel_technician_role', attack_if_at_war: boolean, attack_if_other_security_status_dropping: boolean, attack_security_status_threshold?: number, attack_standing_threshold?: number, fuel_bay_take: 'alliance_member' | 'config_starbase_equipment_role' | 'corporation_member' | 'starbase_fuel_technician_role', fuel_bay_view: 'alliance_member' | 'config_starbase_equipment_role' | 'corporation_member' | 'starbase_fuel_technician_role', fuels?: Array<{quantity: number, type_id: number}>, offline: 'alliance_member' | 'config_starbase_equipment_role' | 'corporation_member' | 'starbase_fuel_technician_role', online: 'alliance_member' | 'config_starbase_equipment_role' | 'corporation_member' | 'starbase_fuel_technician_role', unanchor: 'alliance_member' | 'config_starbase_equipment_role' | 'corporation_member' | 'starbase_fuel_technician_role', use_alliance_standings: boolean}>;
      })
    );
  }
  /**
   * Get starbase (POS) detail
   *
   * Returns various settings and fuels of a starbase (POS)
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/starbases/{starbase_id}/`
   *
   * Alternate route: `/legacy/corporations/{corporation_id}/starbases/{starbase_id}/`
   *
   * Alternate route: `/v1/corporations/{corporation_id}/starbases/{starbase_id}/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   *
   * ---
   * Requires one of the following EVE corporation role(s): Director
   * @param params The `CorporationService.GetCorporationsCorporationIdStarbasesStarbaseIdParams` containing the following parameters:
   *
   * - `system_id`: The solar system this starbase (POS) is located in,
   *
   * - `starbase_id`: An EVE starbase (POS) ID
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return List of starbases (POSes)
   */
  getCorporationsCorporationIdStarbasesStarbaseId(params: CorporationService.GetCorporationsCorporationIdStarbasesStarbaseIdParams): __Observable<{allow_alliance_members: boolean, allow_corporation_members: boolean, anchor: 'alliance_member' | 'config_starbase_equipment_role' | 'corporation_member' | 'starbase_fuel_technician_role', attack_if_at_war: boolean, attack_if_other_security_status_dropping: boolean, attack_security_status_threshold?: number, attack_standing_threshold?: number, fuel_bay_take: 'alliance_member' | 'config_starbase_equipment_role' | 'corporation_member' | 'starbase_fuel_technician_role', fuel_bay_view: 'alliance_member' | 'config_starbase_equipment_role' | 'corporation_member' | 'starbase_fuel_technician_role', fuels?: Array<{quantity: number, type_id: number}>, offline: 'alliance_member' | 'config_starbase_equipment_role' | 'corporation_member' | 'starbase_fuel_technician_role', online: 'alliance_member' | 'config_starbase_equipment_role' | 'corporation_member' | 'starbase_fuel_technician_role', unanchor: 'alliance_member' | 'config_starbase_equipment_role' | 'corporation_member' | 'starbase_fuel_technician_role', use_alliance_standings: boolean}> {
    return this.getCorporationsCorporationIdStarbasesStarbaseIdResponse(params).pipe(
      __map(_r => _r.body as {allow_alliance_members: boolean, allow_corporation_members: boolean, anchor: 'alliance_member' | 'config_starbase_equipment_role' | 'corporation_member' | 'starbase_fuel_technician_role', attack_if_at_war: boolean, attack_if_other_security_status_dropping: boolean, attack_security_status_threshold?: number, attack_standing_threshold?: number, fuel_bay_take: 'alliance_member' | 'config_starbase_equipment_role' | 'corporation_member' | 'starbase_fuel_technician_role', fuel_bay_view: 'alliance_member' | 'config_starbase_equipment_role' | 'corporation_member' | 'starbase_fuel_technician_role', fuels?: Array<{quantity: number, type_id: number}>, offline: 'alliance_member' | 'config_starbase_equipment_role' | 'corporation_member' | 'starbase_fuel_technician_role', online: 'alliance_member' | 'config_starbase_equipment_role' | 'corporation_member' | 'starbase_fuel_technician_role', unanchor: 'alliance_member' | 'config_starbase_equipment_role' | 'corporation_member' | 'starbase_fuel_technician_role', use_alliance_standings: boolean})
    );
  }

  /**
   * Get corporation structures
   *
   * Get a list of corporation structures. This route's version includes the changes to structures detailed in this blog: https://www.eveonline.com/article/upwell-2.0-structures-changes-coming-on-february-13th
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/structures/`
   *
   * Alternate route: `/v3/corporations/{corporation_id}/structures/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   *
   * ---
   * Requires one of the following EVE corporation role(s): Station_Manager
   * @param params The `CorporationService.GetCorporationsCorporationIdStructuresParams` containing the following parameters:
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `page`: Which page of results to return
   *
   * - `language`: Language to use in the response, takes precedence over Accept-Language
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * - `Accept-Language`: Language to use in the response
   *
   * @return List of corporation structures' information
   */
  getCorporationsCorporationIdStructuresResponse(params: CorporationService.GetCorporationsCorporationIdStructuresParams): __Observable<__StrictHttpResponse<Array<{corporation_id: number, fuel_expires?: string, next_reinforce_apply?: string, next_reinforce_hour?: number, next_reinforce_weekday?: number, profile_id: number, reinforce_hour: number, reinforce_weekday?: number, services?: Array<{name: string, state: 'online' | 'offline' | 'cleanup'}>, state: 'anchor_vulnerable' | 'anchoring' | 'armor_reinforce' | 'armor_vulnerable' | 'deploy_vulnerable' | 'fitting_invulnerable' | 'hull_reinforce' | 'hull_vulnerable' | 'online_deprecated' | 'onlining_vulnerable' | 'shield_vulnerable' | 'unanchored' | 'unknown', state_timer_end?: string, state_timer_start?: string, structure_id: number, system_id: number, type_id: number, unanchors_at?: string}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.page != null) __params = __params.set('page', params.page.toString());
    if (params.language != null) __params = __params.set('language', params.language.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    if (params.AcceptLanguage != null) __headers = __headers.set('Accept-Language', params.AcceptLanguage.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/corporations/${encodeURIComponent(params.corporationId)}/structures/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{corporation_id: number, fuel_expires?: string, next_reinforce_apply?: string, next_reinforce_hour?: number, next_reinforce_weekday?: number, profile_id: number, reinforce_hour: number, reinforce_weekday?: number, services?: Array<{name: string, state: 'online' | 'offline' | 'cleanup'}>, state: 'anchor_vulnerable' | 'anchoring' | 'armor_reinforce' | 'armor_vulnerable' | 'deploy_vulnerable' | 'fitting_invulnerable' | 'hull_reinforce' | 'hull_vulnerable' | 'online_deprecated' | 'onlining_vulnerable' | 'shield_vulnerable' | 'unanchored' | 'unknown', state_timer_end?: string, state_timer_start?: string, structure_id: number, system_id: number, type_id: number, unanchors_at?: string}>>;
      })
    );
  }
  /**
   * Get corporation structures
   *
   * Get a list of corporation structures. This route's version includes the changes to structures detailed in this blog: https://www.eveonline.com/article/upwell-2.0-structures-changes-coming-on-february-13th
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/structures/`
   *
   * Alternate route: `/v3/corporations/{corporation_id}/structures/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   *
   * ---
   * Requires one of the following EVE corporation role(s): Station_Manager
   * @param params The `CorporationService.GetCorporationsCorporationIdStructuresParams` containing the following parameters:
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `page`: Which page of results to return
   *
   * - `language`: Language to use in the response, takes precedence over Accept-Language
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * - `Accept-Language`: Language to use in the response
   *
   * @return List of corporation structures' information
   */
  getCorporationsCorporationIdStructures(params: CorporationService.GetCorporationsCorporationIdStructuresParams): __Observable<Array<{corporation_id: number, fuel_expires?: string, next_reinforce_apply?: string, next_reinforce_hour?: number, next_reinforce_weekday?: number, profile_id: number, reinforce_hour: number, reinforce_weekday?: number, services?: Array<{name: string, state: 'online' | 'offline' | 'cleanup'}>, state: 'anchor_vulnerable' | 'anchoring' | 'armor_reinforce' | 'armor_vulnerable' | 'deploy_vulnerable' | 'fitting_invulnerable' | 'hull_reinforce' | 'hull_vulnerable' | 'online_deprecated' | 'onlining_vulnerable' | 'shield_vulnerable' | 'unanchored' | 'unknown', state_timer_end?: string, state_timer_start?: string, structure_id: number, system_id: number, type_id: number, unanchors_at?: string}>> {
    return this.getCorporationsCorporationIdStructuresResponse(params).pipe(
      __map(_r => _r.body as Array<{corporation_id: number, fuel_expires?: string, next_reinforce_apply?: string, next_reinforce_hour?: number, next_reinforce_weekday?: number, profile_id: number, reinforce_hour: number, reinforce_weekday?: number, services?: Array<{name: string, state: 'online' | 'offline' | 'cleanup'}>, state: 'anchor_vulnerable' | 'anchoring' | 'armor_reinforce' | 'armor_vulnerable' | 'deploy_vulnerable' | 'fitting_invulnerable' | 'hull_reinforce' | 'hull_vulnerable' | 'online_deprecated' | 'onlining_vulnerable' | 'shield_vulnerable' | 'unanchored' | 'unknown', state_timer_end?: string, state_timer_start?: string, structure_id: number, system_id: number, type_id: number, unanchors_at?: string}>)
    );
  }

  /**
   * Get corporation titles
   *
   * Returns a corporation's titles
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/titles/`
   *
   * Alternate route: `/legacy/corporations/{corporation_id}/titles/`
   *
   * Alternate route: `/v1/corporations/{corporation_id}/titles/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   *
   * ---
   * Requires one of the following EVE corporation role(s): Director
   * @param params The `CorporationService.GetCorporationsCorporationIdTitlesParams` containing the following parameters:
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of titles
   */
  getCorporationsCorporationIdTitlesResponse(params: CorporationService.GetCorporationsCorporationIdTitlesParams): __Observable<__StrictHttpResponse<Array<{grantable_roles?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, grantable_roles_at_base?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, grantable_roles_at_hq?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, grantable_roles_at_other?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, name?: string, roles?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, roles_at_base?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, roles_at_hq?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, roles_at_other?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, title_id?: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/corporations/${encodeURIComponent(params.corporationId)}/titles/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{grantable_roles?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, grantable_roles_at_base?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, grantable_roles_at_hq?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, grantable_roles_at_other?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, name?: string, roles?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, roles_at_base?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, roles_at_hq?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, roles_at_other?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, title_id?: number}>>;
      })
    );
  }
  /**
   * Get corporation titles
   *
   * Returns a corporation's titles
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/titles/`
   *
   * Alternate route: `/legacy/corporations/{corporation_id}/titles/`
   *
   * Alternate route: `/v1/corporations/{corporation_id}/titles/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   *
   * ---
   * Requires one of the following EVE corporation role(s): Director
   * @param params The `CorporationService.GetCorporationsCorporationIdTitlesParams` containing the following parameters:
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of titles
   */
  getCorporationsCorporationIdTitles(params: CorporationService.GetCorporationsCorporationIdTitlesParams): __Observable<Array<{grantable_roles?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, grantable_roles_at_base?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, grantable_roles_at_hq?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, grantable_roles_at_other?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, name?: string, roles?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, roles_at_base?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, roles_at_hq?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, roles_at_other?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, title_id?: number}>> {
    return this.getCorporationsCorporationIdTitlesResponse(params).pipe(
      __map(_r => _r.body as Array<{grantable_roles?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, grantable_roles_at_base?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, grantable_roles_at_hq?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, grantable_roles_at_other?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, name?: string, roles?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, roles_at_base?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, roles_at_hq?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, roles_at_other?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, title_id?: number}>)
    );
  }
}

module CorporationService {

  /**
   * Parameters for getCorporationsNpccorps
   */
  export interface GetCorporationsNpccorpsParams {

    /**
     * The server name you would like data from
     */
    datasource?: 'tranquility' | 'singularity';

    /**
     * ETag from a previous request. A 304 will be returned if this matches the current ETag
     */
    IfNoneMatch?: string;
  }

  /**
   * Parameters for getCorporationsCorporationId
   */
  export interface GetCorporationsCorporationIdParams {

    /**
     * An EVE corporation ID
     */
    corporationId: number;

    /**
     * The server name you would like data from
     */
    datasource?: 'tranquility' | 'singularity';

    /**
     * ETag from a previous request. A 304 will be returned if this matches the current ETag
     */
    IfNoneMatch?: string;
  }

  /**
   * Parameters for getCorporationsCorporationIdAlliancehistory
   */
  export interface GetCorporationsCorporationIdAlliancehistoryParams {

    /**
     * An EVE corporation ID
     */
    corporationId: number;

    /**
     * The server name you would like data from
     */
    datasource?: 'tranquility' | 'singularity';

    /**
     * ETag from a previous request. A 304 will be returned if this matches the current ETag
     */
    IfNoneMatch?: string;
  }

  /**
   * Parameters for getCorporationsCorporationIdBlueprints
   */
  export interface GetCorporationsCorporationIdBlueprintsParams {

    /**
     * An EVE corporation ID
     */
    corporationId: number;

    /**
     * Access token to use if unable to set a header
     */
    token?: string;

    /**
     * Which page of results to return
     */
    page?: number;

    /**
     * The server name you would like data from
     */
    datasource?: 'tranquility' | 'singularity';

    /**
     * ETag from a previous request. A 304 will be returned if this matches the current ETag
     */
    IfNoneMatch?: string;
  }

  /**
   * Parameters for getCorporationsCorporationIdContainersLogs
   */
  export interface GetCorporationsCorporationIdContainersLogsParams {

    /**
     * An EVE corporation ID
     */
    corporationId: number;

    /**
     * Access token to use if unable to set a header
     */
    token?: string;

    /**
     * Which page of results to return
     */
    page?: number;

    /**
     * The server name you would like data from
     */
    datasource?: 'tranquility' | 'singularity';

    /**
     * ETag from a previous request. A 304 will be returned if this matches the current ETag
     */
    IfNoneMatch?: string;
  }

  /**
   * Parameters for getCorporationsCorporationIdDivisions
   */
  export interface GetCorporationsCorporationIdDivisionsParams {

    /**
     * An EVE corporation ID
     */
    corporationId: number;

    /**
     * Access token to use if unable to set a header
     */
    token?: string;

    /**
     * The server name you would like data from
     */
    datasource?: 'tranquility' | 'singularity';

    /**
     * ETag from a previous request. A 304 will be returned if this matches the current ETag
     */
    IfNoneMatch?: string;
  }

  /**
   * Parameters for getCorporationsCorporationIdFacilities
   */
  export interface GetCorporationsCorporationIdFacilitiesParams {

    /**
     * An EVE corporation ID
     */
    corporationId: number;

    /**
     * Access token to use if unable to set a header
     */
    token?: string;

    /**
     * The server name you would like data from
     */
    datasource?: 'tranquility' | 'singularity';

    /**
     * ETag from a previous request. A 304 will be returned if this matches the current ETag
     */
    IfNoneMatch?: string;
  }

  /**
   * Parameters for getCorporationsCorporationIdIcons
   */
  export interface GetCorporationsCorporationIdIconsParams {

    /**
     * An EVE corporation ID
     */
    corporationId: number;

    /**
     * The server name you would like data from
     */
    datasource?: 'tranquility' | 'singularity';

    /**
     * ETag from a previous request. A 304 will be returned if this matches the current ETag
     */
    IfNoneMatch?: string;
  }

  /**
   * Parameters for getCorporationsCorporationIdMedals
   */
  export interface GetCorporationsCorporationIdMedalsParams {

    /**
     * An EVE corporation ID
     */
    corporationId: number;

    /**
     * Access token to use if unable to set a header
     */
    token?: string;

    /**
     * Which page of results to return
     */
    page?: number;

    /**
     * The server name you would like data from
     */
    datasource?: 'tranquility' | 'singularity';

    /**
     * ETag from a previous request. A 304 will be returned if this matches the current ETag
     */
    IfNoneMatch?: string;
  }

  /**
   * Parameters for getCorporationsCorporationIdMedalsIssued
   */
  export interface GetCorporationsCorporationIdMedalsIssuedParams {

    /**
     * An EVE corporation ID
     */
    corporationId: number;

    /**
     * Access token to use if unable to set a header
     */
    token?: string;

    /**
     * Which page of results to return
     */
    page?: number;

    /**
     * The server name you would like data from
     */
    datasource?: 'tranquility' | 'singularity';

    /**
     * ETag from a previous request. A 304 will be returned if this matches the current ETag
     */
    IfNoneMatch?: string;
  }

  /**
   * Parameters for getCorporationsCorporationIdMembers
   */
  export interface GetCorporationsCorporationIdMembersParams {

    /**
     * An EVE corporation ID
     */
    corporationId: number;

    /**
     * Access token to use if unable to set a header
     */
    token?: string;

    /**
     * The server name you would like data from
     */
    datasource?: 'tranquility' | 'singularity';

    /**
     * ETag from a previous request. A 304 will be returned if this matches the current ETag
     */
    IfNoneMatch?: string;
  }

  /**
   * Parameters for getCorporationsCorporationIdMembersLimit
   */
  export interface GetCorporationsCorporationIdMembersLimitParams {

    /**
     * An EVE corporation ID
     */
    corporationId: number;

    /**
     * Access token to use if unable to set a header
     */
    token?: string;

    /**
     * The server name you would like data from
     */
    datasource?: 'tranquility' | 'singularity';

    /**
     * ETag from a previous request. A 304 will be returned if this matches the current ETag
     */
    IfNoneMatch?: string;
  }

  /**
   * Parameters for getCorporationsCorporationIdMembersTitles
   */
  export interface GetCorporationsCorporationIdMembersTitlesParams {

    /**
     * An EVE corporation ID
     */
    corporationId: number;

    /**
     * Access token to use if unable to set a header
     */
    token?: string;

    /**
     * The server name you would like data from
     */
    datasource?: 'tranquility' | 'singularity';

    /**
     * ETag from a previous request. A 304 will be returned if this matches the current ETag
     */
    IfNoneMatch?: string;
  }

  /**
   * Parameters for getCorporationsCorporationIdMembertracking
   */
  export interface GetCorporationsCorporationIdMembertrackingParams {

    /**
     * An EVE corporation ID
     */
    corporationId: number;

    /**
     * Access token to use if unable to set a header
     */
    token?: string;

    /**
     * The server name you would like data from
     */
    datasource?: 'tranquility' | 'singularity';

    /**
     * ETag from a previous request. A 304 will be returned if this matches the current ETag
     */
    IfNoneMatch?: string;
  }

  /**
   * Parameters for getCorporationsCorporationIdRoles
   */
  export interface GetCorporationsCorporationIdRolesParams {

    /**
     * An EVE corporation ID
     */
    corporationId: number;

    /**
     * Access token to use if unable to set a header
     */
    token?: string;

    /**
     * The server name you would like data from
     */
    datasource?: 'tranquility' | 'singularity';

    /**
     * ETag from a previous request. A 304 will be returned if this matches the current ETag
     */
    IfNoneMatch?: string;
  }

  /**
   * Parameters for getCorporationsCorporationIdRolesHistory
   */
  export interface GetCorporationsCorporationIdRolesHistoryParams {

    /**
     * An EVE corporation ID
     */
    corporationId: number;

    /**
     * Access token to use if unable to set a header
     */
    token?: string;

    /**
     * Which page of results to return
     */
    page?: number;

    /**
     * The server name you would like data from
     */
    datasource?: 'tranquility' | 'singularity';

    /**
     * ETag from a previous request. A 304 will be returned if this matches the current ETag
     */
    IfNoneMatch?: string;
  }

  /**
   * Parameters for getCorporationsCorporationIdShareholders
   */
  export interface GetCorporationsCorporationIdShareholdersParams {

    /**
     * An EVE corporation ID
     */
    corporationId: number;

    /**
     * Access token to use if unable to set a header
     */
    token?: string;

    /**
     * Which page of results to return
     */
    page?: number;

    /**
     * The server name you would like data from
     */
    datasource?: 'tranquility' | 'singularity';

    /**
     * ETag from a previous request. A 304 will be returned if this matches the current ETag
     */
    IfNoneMatch?: string;
  }

  /**
   * Parameters for getCorporationsCorporationIdStandings
   */
  export interface GetCorporationsCorporationIdStandingsParams {

    /**
     * An EVE corporation ID
     */
    corporationId: number;

    /**
     * Access token to use if unable to set a header
     */
    token?: string;

    /**
     * Which page of results to return
     */
    page?: number;

    /**
     * The server name you would like data from
     */
    datasource?: 'tranquility' | 'singularity';

    /**
     * ETag from a previous request. A 304 will be returned if this matches the current ETag
     */
    IfNoneMatch?: string;
  }

  /**
   * Parameters for getCorporationsCorporationIdStarbases
   */
  export interface GetCorporationsCorporationIdStarbasesParams {

    /**
     * An EVE corporation ID
     */
    corporationId: number;

    /**
     * Access token to use if unable to set a header
     */
    token?: string;

    /**
     * Which page of results to return
     */
    page?: number;

    /**
     * The server name you would like data from
     */
    datasource?: 'tranquility' | 'singularity';

    /**
     * ETag from a previous request. A 304 will be returned if this matches the current ETag
     */
    IfNoneMatch?: string;
  }

  /**
   * Parameters for getCorporationsCorporationIdStarbasesStarbaseId
   */
  export interface GetCorporationsCorporationIdStarbasesStarbaseIdParams {

    /**
     * The solar system this starbase (POS) is located in,
     */
    systemId: number;

    /**
     * An EVE starbase (POS) ID
     */
    starbaseId: number;

    /**
     * An EVE corporation ID
     */
    corporationId: number;

    /**
     * Access token to use if unable to set a header
     */
    token?: string;

    /**
     * The server name you would like data from
     */
    datasource?: 'tranquility' | 'singularity';

    /**
     * ETag from a previous request. A 304 will be returned if this matches the current ETag
     */
    IfNoneMatch?: string;
  }

  /**
   * Parameters for getCorporationsCorporationIdStructures
   */
  export interface GetCorporationsCorporationIdStructuresParams {

    /**
     * An EVE corporation ID
     */
    corporationId: number;

    /**
     * Access token to use if unable to set a header
     */
    token?: string;

    /**
     * Which page of results to return
     */
    page?: number;

    /**
     * Language to use in the response, takes precedence over Accept-Language
     */
    language?: 'de' | 'en-us' | 'fr' | 'ja' | 'ru' | 'zh' | 'ko';

    /**
     * The server name you would like data from
     */
    datasource?: 'tranquility' | 'singularity';

    /**
     * ETag from a previous request. A 304 will be returned if this matches the current ETag
     */
    IfNoneMatch?: string;

    /**
     * Language to use in the response
     */
    AcceptLanguage?: 'de' | 'en-us' | 'fr' | 'ja' | 'ru' | 'zh' | 'ko';
  }

  /**
   * Parameters for getCorporationsCorporationIdTitles
   */
  export interface GetCorporationsCorporationIdTitlesParams {

    /**
     * An EVE corporation ID
     */
    corporationId: number;

    /**
     * Access token to use if unable to set a header
     */
    token?: string;

    /**
     * The server name you would like data from
     */
    datasource?: 'tranquility' | 'singularity';

    /**
     * ETag from a previous request. A 304 will be returned if this matches the current ETag
     */
    IfNoneMatch?: string;
  }
}

export { CorporationService }
