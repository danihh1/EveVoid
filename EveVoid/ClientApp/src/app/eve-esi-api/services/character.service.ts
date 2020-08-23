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
class CharacterService extends __BaseService {
  static readonly postCharactersAffiliationPath = '/characters/affiliation/';
  static readonly getCharactersCharacterIdPath = '/characters/{character_id}/';
  static readonly getCharactersCharacterIdAgentsResearchPath = '/characters/{character_id}/agents_research/';
  static readonly getCharactersCharacterIdBlueprintsPath = '/characters/{character_id}/blueprints/';
  static readonly getCharactersCharacterIdCorporationhistoryPath = '/characters/{character_id}/corporationhistory/';
  static readonly postCharactersCharacterIdCspaPath = '/characters/{character_id}/cspa/';
  static readonly getCharactersCharacterIdFatiguePath = '/characters/{character_id}/fatigue/';
  static readonly getCharactersCharacterIdMedalsPath = '/characters/{character_id}/medals/';
  static readonly getCharactersCharacterIdNotificationsPath = '/characters/{character_id}/notifications/';
  static readonly getCharactersCharacterIdNotificationsContactsPath = '/characters/{character_id}/notifications/contacts/';
  static readonly getCharactersCharacterIdPortraitPath = '/characters/{character_id}/portrait/';
  static readonly getCharactersCharacterIdRolesPath = '/characters/{character_id}/roles/';
  static readonly getCharactersCharacterIdStandingsPath = '/characters/{character_id}/standings/';
  static readonly getCharactersCharacterIdStatsPath = '/characters/{character_id}/stats/';
  static readonly getCharactersCharacterIdTitlesPath = '/characters/{character_id}/titles/';

  constructor(
    config: __Configuration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * Character affiliation
   *
   * Bulk lookup of character IDs to corporation, alliance and faction
   *
   * ---
   * Alternate route: `/legacy/characters/affiliation/`
   *
   * Alternate route: `/v1/characters/affiliation/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   *
   * ---
   * [Diff of the upcoming changes](https://esi.evetech.net/diff/latest/dev/#POST-/characters/affiliation/)
   * @param params The `CharacterService.PostCharactersAffiliationParams` containing the following parameters:
   *
   * - `characters`: The character IDs to fetch affiliations for. All characters must exist, or none will be returned
   *
   * - `datasource`: The server name you would like data from
   *
   * @return Character corporation, alliance and faction IDs
   */
  postCharactersAffiliationResponse(params: CharacterService.PostCharactersAffiliationParams): __Observable<__StrictHttpResponse<Array<{alliance_id?: number, character_id: number, corporation_id: number, faction_id?: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    __body = params.characters;
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    let req = new HttpRequest<any>(
      'POST',
      this.rootUrl + `/characters/affiliation/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{alliance_id?: number, character_id: number, corporation_id: number, faction_id?: number}>>;
      })
    );
  }
  /**
   * Character affiliation
   *
   * Bulk lookup of character IDs to corporation, alliance and faction
   *
   * ---
   * Alternate route: `/legacy/characters/affiliation/`
   *
   * Alternate route: `/v1/characters/affiliation/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   *
   * ---
   * [Diff of the upcoming changes](https://esi.evetech.net/diff/latest/dev/#POST-/characters/affiliation/)
   * @param params The `CharacterService.PostCharactersAffiliationParams` containing the following parameters:
   *
   * - `characters`: The character IDs to fetch affiliations for. All characters must exist, or none will be returned
   *
   * - `datasource`: The server name you would like data from
   *
   * @return Character corporation, alliance and faction IDs
   */
  postCharactersAffiliation(params: CharacterService.PostCharactersAffiliationParams): __Observable<Array<{alliance_id?: number, character_id: number, corporation_id: number, faction_id?: number}>> {
    return this.postCharactersAffiliationResponse(params).pipe(
      __map(_r => _r.body as Array<{alliance_id?: number, character_id: number, corporation_id: number, faction_id?: number}>)
    );
  }

  /**
   * Get character's public information
   *
   * Public information about a character
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/`
   *
   * Alternate route: `/v4/characters/{character_id}/`
   *
   * ---
   * This route is cached for up to 86400 seconds
   * @param params The `CharacterService.GetCharactersCharacterIdParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Public data for the given character
   */
  getCharactersCharacterIdResponse(params: CharacterService.GetCharactersCharacterIdParams): __Observable<__StrictHttpResponse<{alliance_id?: number, ancestry_id?: number, birthday: string, bloodline_id: number, corporation_id: number, description?: string, faction_id?: number, gender: 'female' | 'male', name: string, race_id: number, security_status?: number, title?: string}>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<{alliance_id?: number, ancestry_id?: number, birthday: string, bloodline_id: number, corporation_id: number, description?: string, faction_id?: number, gender: 'female' | 'male', name: string, race_id: number, security_status?: number, title?: string}>;
      })
    );
  }
  /**
   * Get character's public information
   *
   * Public information about a character
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/`
   *
   * Alternate route: `/v4/characters/{character_id}/`
   *
   * ---
   * This route is cached for up to 86400 seconds
   * @param params The `CharacterService.GetCharactersCharacterIdParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Public data for the given character
   */
  getCharactersCharacterId(params: CharacterService.GetCharactersCharacterIdParams): __Observable<{alliance_id?: number, ancestry_id?: number, birthday: string, bloodline_id: number, corporation_id: number, description?: string, faction_id?: number, gender: 'female' | 'male', name: string, race_id: number, security_status?: number, title?: string}> {
    return this.getCharactersCharacterIdResponse(params).pipe(
      __map(_r => _r.body as {alliance_id?: number, ancestry_id?: number, birthday: string, bloodline_id: number, corporation_id: number, description?: string, faction_id?: number, gender: 'female' | 'male', name: string, race_id: number, security_status?: number, title?: string})
    );
  }

  /**
   * Get agents research
   *
   * Return a list of agents research information for a character. The formula for finding the current research points with an agent is: currentPoints = remainderPoints + pointsPerDay * days(currentTime - researchStartDate)
   *
   * ---
   * Alternate route: `/legacy/characters/{character_id}/agents_research/`
   *
   * Alternate route: `/v1/characters/{character_id}/agents_research/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `CharacterService.GetCharactersCharacterIdAgentsResearchParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of agents research information
   */
  getCharactersCharacterIdAgentsResearchResponse(params: CharacterService.GetCharactersCharacterIdAgentsResearchParams): __Observable<__StrictHttpResponse<Array<{agent_id: number, points_per_day: number, remainder_points: number, skill_type_id: number, started_at: string}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/agents_research/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{agent_id: number, points_per_day: number, remainder_points: number, skill_type_id: number, started_at: string}>>;
      })
    );
  }
  /**
   * Get agents research
   *
   * Return a list of agents research information for a character. The formula for finding the current research points with an agent is: currentPoints = remainderPoints + pointsPerDay * days(currentTime - researchStartDate)
   *
   * ---
   * Alternate route: `/legacy/characters/{character_id}/agents_research/`
   *
   * Alternate route: `/v1/characters/{character_id}/agents_research/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `CharacterService.GetCharactersCharacterIdAgentsResearchParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of agents research information
   */
  getCharactersCharacterIdAgentsResearch(params: CharacterService.GetCharactersCharacterIdAgentsResearchParams): __Observable<Array<{agent_id: number, points_per_day: number, remainder_points: number, skill_type_id: number, started_at: string}>> {
    return this.getCharactersCharacterIdAgentsResearchResponse(params).pipe(
      __map(_r => _r.body as Array<{agent_id: number, points_per_day: number, remainder_points: number, skill_type_id: number, started_at: string}>)
    );
  }

  /**
   * Get blueprints
   *
   * Return a list of blueprints the character owns
   *
   * ---
   * Alternate route: `/v2/characters/{character_id}/blueprints/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `CharacterService.GetCharactersCharacterIdBlueprintsParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `page`: Which page of results to return
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of blueprints
   */
  getCharactersCharacterIdBlueprintsResponse(params: CharacterService.GetCharactersCharacterIdBlueprintsParams): __Observable<__StrictHttpResponse<Array<{item_id: number, location_flag: 'AutoFit' | 'Cargo' | 'CorpseBay' | 'DroneBay' | 'FleetHangar' | 'Deliveries' | 'HiddenModifiers' | 'Hangar' | 'HangarAll' | 'LoSlot0' | 'LoSlot1' | 'LoSlot2' | 'LoSlot3' | 'LoSlot4' | 'LoSlot5' | 'LoSlot6' | 'LoSlot7' | 'MedSlot0' | 'MedSlot1' | 'MedSlot2' | 'MedSlot3' | 'MedSlot4' | 'MedSlot5' | 'MedSlot6' | 'MedSlot7' | 'HiSlot0' | 'HiSlot1' | 'HiSlot2' | 'HiSlot3' | 'HiSlot4' | 'HiSlot5' | 'HiSlot6' | 'HiSlot7' | 'AssetSafety' | 'Locked' | 'Unlocked' | 'Implant' | 'QuafeBay' | 'RigSlot0' | 'RigSlot1' | 'RigSlot2' | 'RigSlot3' | 'RigSlot4' | 'RigSlot5' | 'RigSlot6' | 'RigSlot7' | 'ShipHangar' | 'SpecializedFuelBay' | 'SpecializedOreHold' | 'SpecializedGasHold' | 'SpecializedMineralHold' | 'SpecializedSalvageHold' | 'SpecializedShipHold' | 'SpecializedSmallShipHold' | 'SpecializedMediumShipHold' | 'SpecializedLargeShipHold' | 'SpecializedIndustrialShipHold' | 'SpecializedAmmoHold' | 'SpecializedCommandCenterHold' | 'SpecializedPlanetaryCommoditiesHold' | 'SpecializedMaterialBay' | 'SubSystemSlot0' | 'SubSystemSlot1' | 'SubSystemSlot2' | 'SubSystemSlot3' | 'SubSystemSlot4' | 'SubSystemSlot5' | 'SubSystemSlot6' | 'SubSystemSlot7' | 'FighterBay' | 'FighterTube0' | 'FighterTube1' | 'FighterTube2' | 'FighterTube3' | 'FighterTube4' | 'Module', location_id: number, material_efficiency: number, quantity: number, runs: number, time_efficiency: number, type_id: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.page != null) __params = __params.set('page', params.page.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/blueprints/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{item_id: number, location_flag: 'AutoFit' | 'Cargo' | 'CorpseBay' | 'DroneBay' | 'FleetHangar' | 'Deliveries' | 'HiddenModifiers' | 'Hangar' | 'HangarAll' | 'LoSlot0' | 'LoSlot1' | 'LoSlot2' | 'LoSlot3' | 'LoSlot4' | 'LoSlot5' | 'LoSlot6' | 'LoSlot7' | 'MedSlot0' | 'MedSlot1' | 'MedSlot2' | 'MedSlot3' | 'MedSlot4' | 'MedSlot5' | 'MedSlot6' | 'MedSlot7' | 'HiSlot0' | 'HiSlot1' | 'HiSlot2' | 'HiSlot3' | 'HiSlot4' | 'HiSlot5' | 'HiSlot6' | 'HiSlot7' | 'AssetSafety' | 'Locked' | 'Unlocked' | 'Implant' | 'QuafeBay' | 'RigSlot0' | 'RigSlot1' | 'RigSlot2' | 'RigSlot3' | 'RigSlot4' | 'RigSlot5' | 'RigSlot6' | 'RigSlot7' | 'ShipHangar' | 'SpecializedFuelBay' | 'SpecializedOreHold' | 'SpecializedGasHold' | 'SpecializedMineralHold' | 'SpecializedSalvageHold' | 'SpecializedShipHold' | 'SpecializedSmallShipHold' | 'SpecializedMediumShipHold' | 'SpecializedLargeShipHold' | 'SpecializedIndustrialShipHold' | 'SpecializedAmmoHold' | 'SpecializedCommandCenterHold' | 'SpecializedPlanetaryCommoditiesHold' | 'SpecializedMaterialBay' | 'SubSystemSlot0' | 'SubSystemSlot1' | 'SubSystemSlot2' | 'SubSystemSlot3' | 'SubSystemSlot4' | 'SubSystemSlot5' | 'SubSystemSlot6' | 'SubSystemSlot7' | 'FighterBay' | 'FighterTube0' | 'FighterTube1' | 'FighterTube2' | 'FighterTube3' | 'FighterTube4' | 'Module', location_id: number, material_efficiency: number, quantity: number, runs: number, time_efficiency: number, type_id: number}>>;
      })
    );
  }
  /**
   * Get blueprints
   *
   * Return a list of blueprints the character owns
   *
   * ---
   * Alternate route: `/v2/characters/{character_id}/blueprints/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `CharacterService.GetCharactersCharacterIdBlueprintsParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `page`: Which page of results to return
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of blueprints
   */
  getCharactersCharacterIdBlueprints(params: CharacterService.GetCharactersCharacterIdBlueprintsParams): __Observable<Array<{item_id: number, location_flag: 'AutoFit' | 'Cargo' | 'CorpseBay' | 'DroneBay' | 'FleetHangar' | 'Deliveries' | 'HiddenModifiers' | 'Hangar' | 'HangarAll' | 'LoSlot0' | 'LoSlot1' | 'LoSlot2' | 'LoSlot3' | 'LoSlot4' | 'LoSlot5' | 'LoSlot6' | 'LoSlot7' | 'MedSlot0' | 'MedSlot1' | 'MedSlot2' | 'MedSlot3' | 'MedSlot4' | 'MedSlot5' | 'MedSlot6' | 'MedSlot7' | 'HiSlot0' | 'HiSlot1' | 'HiSlot2' | 'HiSlot3' | 'HiSlot4' | 'HiSlot5' | 'HiSlot6' | 'HiSlot7' | 'AssetSafety' | 'Locked' | 'Unlocked' | 'Implant' | 'QuafeBay' | 'RigSlot0' | 'RigSlot1' | 'RigSlot2' | 'RigSlot3' | 'RigSlot4' | 'RigSlot5' | 'RigSlot6' | 'RigSlot7' | 'ShipHangar' | 'SpecializedFuelBay' | 'SpecializedOreHold' | 'SpecializedGasHold' | 'SpecializedMineralHold' | 'SpecializedSalvageHold' | 'SpecializedShipHold' | 'SpecializedSmallShipHold' | 'SpecializedMediumShipHold' | 'SpecializedLargeShipHold' | 'SpecializedIndustrialShipHold' | 'SpecializedAmmoHold' | 'SpecializedCommandCenterHold' | 'SpecializedPlanetaryCommoditiesHold' | 'SpecializedMaterialBay' | 'SubSystemSlot0' | 'SubSystemSlot1' | 'SubSystemSlot2' | 'SubSystemSlot3' | 'SubSystemSlot4' | 'SubSystemSlot5' | 'SubSystemSlot6' | 'SubSystemSlot7' | 'FighterBay' | 'FighterTube0' | 'FighterTube1' | 'FighterTube2' | 'FighterTube3' | 'FighterTube4' | 'Module', location_id: number, material_efficiency: number, quantity: number, runs: number, time_efficiency: number, type_id: number}>> {
    return this.getCharactersCharacterIdBlueprintsResponse(params).pipe(
      __map(_r => _r.body as Array<{item_id: number, location_flag: 'AutoFit' | 'Cargo' | 'CorpseBay' | 'DroneBay' | 'FleetHangar' | 'Deliveries' | 'HiddenModifiers' | 'Hangar' | 'HangarAll' | 'LoSlot0' | 'LoSlot1' | 'LoSlot2' | 'LoSlot3' | 'LoSlot4' | 'LoSlot5' | 'LoSlot6' | 'LoSlot7' | 'MedSlot0' | 'MedSlot1' | 'MedSlot2' | 'MedSlot3' | 'MedSlot4' | 'MedSlot5' | 'MedSlot6' | 'MedSlot7' | 'HiSlot0' | 'HiSlot1' | 'HiSlot2' | 'HiSlot3' | 'HiSlot4' | 'HiSlot5' | 'HiSlot6' | 'HiSlot7' | 'AssetSafety' | 'Locked' | 'Unlocked' | 'Implant' | 'QuafeBay' | 'RigSlot0' | 'RigSlot1' | 'RigSlot2' | 'RigSlot3' | 'RigSlot4' | 'RigSlot5' | 'RigSlot6' | 'RigSlot7' | 'ShipHangar' | 'SpecializedFuelBay' | 'SpecializedOreHold' | 'SpecializedGasHold' | 'SpecializedMineralHold' | 'SpecializedSalvageHold' | 'SpecializedShipHold' | 'SpecializedSmallShipHold' | 'SpecializedMediumShipHold' | 'SpecializedLargeShipHold' | 'SpecializedIndustrialShipHold' | 'SpecializedAmmoHold' | 'SpecializedCommandCenterHold' | 'SpecializedPlanetaryCommoditiesHold' | 'SpecializedMaterialBay' | 'SubSystemSlot0' | 'SubSystemSlot1' | 'SubSystemSlot2' | 'SubSystemSlot3' | 'SubSystemSlot4' | 'SubSystemSlot5' | 'SubSystemSlot6' | 'SubSystemSlot7' | 'FighterBay' | 'FighterTube0' | 'FighterTube1' | 'FighterTube2' | 'FighterTube3' | 'FighterTube4' | 'Module', location_id: number, material_efficiency: number, quantity: number, runs: number, time_efficiency: number, type_id: number}>)
    );
  }

  /**
   * Get corporation history
   *
   * Get a list of all the corporations a character has been a member of
   *
   * ---
   * Alternate route: `/legacy/characters/{character_id}/corporationhistory/`
   *
   * Alternate route: `/v1/characters/{character_id}/corporationhistory/`
   *
   * ---
   * This route is cached for up to 86400 seconds
   * @param params The `CharacterService.GetCharactersCharacterIdCorporationhistoryParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Corporation history for the given character
   */
  getCharactersCharacterIdCorporationhistoryResponse(params: CharacterService.GetCharactersCharacterIdCorporationhistoryParams): __Observable<__StrictHttpResponse<Array<{corporation_id: number, is_deleted?: boolean, record_id: number, start_date: string}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/corporationhistory/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{corporation_id: number, is_deleted?: boolean, record_id: number, start_date: string}>>;
      })
    );
  }
  /**
   * Get corporation history
   *
   * Get a list of all the corporations a character has been a member of
   *
   * ---
   * Alternate route: `/legacy/characters/{character_id}/corporationhistory/`
   *
   * Alternate route: `/v1/characters/{character_id}/corporationhistory/`
   *
   * ---
   * This route is cached for up to 86400 seconds
   * @param params The `CharacterService.GetCharactersCharacterIdCorporationhistoryParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Corporation history for the given character
   */
  getCharactersCharacterIdCorporationhistory(params: CharacterService.GetCharactersCharacterIdCorporationhistoryParams): __Observable<Array<{corporation_id: number, is_deleted?: boolean, record_id: number, start_date: string}>> {
    return this.getCharactersCharacterIdCorporationhistoryResponse(params).pipe(
      __map(_r => _r.body as Array<{corporation_id: number, is_deleted?: boolean, record_id: number, start_date: string}>)
    );
  }

  /**
   * Calculate a CSPA charge cost
   *
   * Takes a source character ID in the url and a set of target character ID's in the body, returns a CSPA charge cost
   *
   * ---
   * Alternate route: `/v4/characters/{character_id}/cspa/`
   * @param params The `CharacterService.PostCharactersCharacterIdCspaParams` containing the following parameters:
   *
   * - `characters`: The target characters to calculate the charge for
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * @return Aggregate cost of sending a mail from the source character to the target characters, in ISK
   */
  postCharactersCharacterIdCspaResponse(params: CharacterService.PostCharactersCharacterIdCspaParams): __Observable<__StrictHttpResponse<number>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    __body = params.characters;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    let req = new HttpRequest<any>(
      'POST',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/cspa/`,
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
   * Calculate a CSPA charge cost
   *
   * Takes a source character ID in the url and a set of target character ID's in the body, returns a CSPA charge cost
   *
   * ---
   * Alternate route: `/v4/characters/{character_id}/cspa/`
   * @param params The `CharacterService.PostCharactersCharacterIdCspaParams` containing the following parameters:
   *
   * - `characters`: The target characters to calculate the charge for
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * @return Aggregate cost of sending a mail from the source character to the target characters, in ISK
   */
  postCharactersCharacterIdCspa(params: CharacterService.PostCharactersCharacterIdCspaParams): __Observable<number> {
    return this.postCharactersCharacterIdCspaResponse(params).pipe(
      __map(_r => _r.body as number)
    );
  }

  /**
   * Get jump fatigue
   *
   * Return a character's jump activation and fatigue information
   *
   * ---
   * Alternate route: `/legacy/characters/{character_id}/fatigue/`
   *
   * Alternate route: `/v1/characters/{character_id}/fatigue/`
   *
   * ---
   * This route is cached for up to 300 seconds
   * @param params The `CharacterService.GetCharactersCharacterIdFatigueParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Jump activation and fatigue information
   */
  getCharactersCharacterIdFatigueResponse(params: CharacterService.GetCharactersCharacterIdFatigueParams): __Observable<__StrictHttpResponse<{jump_fatigue_expire_date?: string, last_jump_date?: string, last_update_date?: string}>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/fatigue/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<{jump_fatigue_expire_date?: string, last_jump_date?: string, last_update_date?: string}>;
      })
    );
  }
  /**
   * Get jump fatigue
   *
   * Return a character's jump activation and fatigue information
   *
   * ---
   * Alternate route: `/legacy/characters/{character_id}/fatigue/`
   *
   * Alternate route: `/v1/characters/{character_id}/fatigue/`
   *
   * ---
   * This route is cached for up to 300 seconds
   * @param params The `CharacterService.GetCharactersCharacterIdFatigueParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Jump activation and fatigue information
   */
  getCharactersCharacterIdFatigue(params: CharacterService.GetCharactersCharacterIdFatigueParams): __Observable<{jump_fatigue_expire_date?: string, last_jump_date?: string, last_update_date?: string}> {
    return this.getCharactersCharacterIdFatigueResponse(params).pipe(
      __map(_r => _r.body as {jump_fatigue_expire_date?: string, last_jump_date?: string, last_update_date?: string})
    );
  }

  /**
   * Get medals
   *
   * Return a list of medals the character has
   *
   * ---
   * Alternate route: `/legacy/characters/{character_id}/medals/`
   *
   * Alternate route: `/v1/characters/{character_id}/medals/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `CharacterService.GetCharactersCharacterIdMedalsParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of medals
   */
  getCharactersCharacterIdMedalsResponse(params: CharacterService.GetCharactersCharacterIdMedalsParams): __Observable<__StrictHttpResponse<Array<{corporation_id: number, date: string, description: string, graphics: Array<{color?: number, graphic: string, layer: number, part: number}>, issuer_id: number, medal_id: number, reason: string, status: 'public' | 'private', title: string}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/medals/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{corporation_id: number, date: string, description: string, graphics: Array<{color?: number, graphic: string, layer: number, part: number}>, issuer_id: number, medal_id: number, reason: string, status: 'public' | 'private', title: string}>>;
      })
    );
  }
  /**
   * Get medals
   *
   * Return a list of medals the character has
   *
   * ---
   * Alternate route: `/legacy/characters/{character_id}/medals/`
   *
   * Alternate route: `/v1/characters/{character_id}/medals/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `CharacterService.GetCharactersCharacterIdMedalsParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of medals
   */
  getCharactersCharacterIdMedals(params: CharacterService.GetCharactersCharacterIdMedalsParams): __Observable<Array<{corporation_id: number, date: string, description: string, graphics: Array<{color?: number, graphic: string, layer: number, part: number}>, issuer_id: number, medal_id: number, reason: string, status: 'public' | 'private', title: string}>> {
    return this.getCharactersCharacterIdMedalsResponse(params).pipe(
      __map(_r => _r.body as Array<{corporation_id: number, date: string, description: string, graphics: Array<{color?: number, graphic: string, layer: number, part: number}>, issuer_id: number, medal_id: number, reason: string, status: 'public' | 'private', title: string}>)
    );
  }

  /**
   * Get character notifications
   *
   * Return character notifications
   *
   * ---
   * Alternate route: `/v5/characters/{character_id}/notifications/`
   *
   * ---
   * This route is cached for up to 600 seconds
   * @param params The `CharacterService.GetCharactersCharacterIdNotificationsParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Returns your recent notifications
   */
  getCharactersCharacterIdNotificationsResponse(params: CharacterService.GetCharactersCharacterIdNotificationsParams): __Observable<__StrictHttpResponse<Array<{is_read?: boolean, notification_id: number, sender_id: number, sender_type: 'character' | 'corporation' | 'alliance' | 'faction' | 'other', text?: string, timestamp: string, type: 'AcceptedAlly' | 'AcceptedSurrender' | 'AllAnchoringMsg' | 'AllMaintenanceBillMsg' | 'AllStrucInvulnerableMsg' | 'AllStructVulnerableMsg' | 'AllWarCorpJoinedAllianceMsg' | 'AllWarDeclaredMsg' | 'AllWarInvalidatedMsg' | 'AllWarRetractedMsg' | 'AllWarSurrenderMsg' | 'AllianceCapitalChanged' | 'AllianceWarDeclaredV2' | 'AllyContractCancelled' | 'AllyJoinedWarAggressorMsg' | 'AllyJoinedWarAllyMsg' | 'AllyJoinedWarDefenderMsg' | 'BattlePunishFriendlyFire' | 'BillOutOfMoneyMsg' | 'BillPaidCorpAllMsg' | 'BountyClaimMsg' | 'BountyESSShared' | 'BountyESSTaken' | 'BountyPlacedAlliance' | 'BountyPlacedChar' | 'BountyPlacedCorp' | 'BountyYourBountyClaimed' | 'BuddyConnectContactAdd' | 'CharAppAcceptMsg' | 'CharAppRejectMsg' | 'CharAppWithdrawMsg' | 'CharLeftCorpMsg' | 'CharMedalMsg' | 'CharTerminationMsg' | 'CloneActivationMsg' | 'CloneActivationMsg2' | 'CloneMovedMsg' | 'CloneRevokedMsg1' | 'CloneRevokedMsg2' | 'CombatOperationFinished' | 'ContactAdd' | 'ContactEdit' | 'ContainerPasswordMsg' | 'CorpAllBillMsg' | 'CorpAppAcceptMsg' | 'CorpAppInvitedMsg' | 'CorpAppNewMsg' | 'CorpAppRejectCustomMsg' | 'CorpAppRejectMsg' | 'CorpBecameWarEligible' | 'CorpDividendMsg' | 'CorpFriendlyFireDisableTimerCompleted' | 'CorpFriendlyFireDisableTimerStarted' | 'CorpFriendlyFireEnableTimerCompleted' | 'CorpFriendlyFireEnableTimerStarted' | 'CorpKicked' | 'CorpLiquidationMsg' | 'CorpNewCEOMsg' | 'CorpNewsMsg' | 'CorpNoLongerWarEligible' | 'CorpOfficeExpirationMsg' | 'CorpStructLostMsg' | 'CorpTaxChangeMsg' | 'CorpVoteCEORevokedMsg' | 'CorpVoteMsg' | 'CorpWarDeclaredMsg' | 'CorpWarDeclaredV2' | 'CorpWarFightingLegalMsg' | 'CorpWarInvalidatedMsg' | 'CorpWarRetractedMsg' | 'CorpWarSurrenderMsg' | 'CustomsMsg' | 'DeclareWar' | 'DistrictAttacked' | 'DustAppAcceptedMsg' | 'EntosisCaptureStarted' | 'FWAllianceKickMsg' | 'FWAllianceWarningMsg' | 'FWCharKickMsg' | 'FWCharRankGainMsg' | 'FWCharRankLossMsg' | 'FWCharWarningMsg' | 'FWCorpJoinMsg' | 'FWCorpKickMsg' | 'FWCorpLeaveMsg' | 'FWCorpWarningMsg' | 'FacWarCorpJoinRequestMsg' | 'FacWarCorpJoinWithdrawMsg' | 'FacWarCorpLeaveRequestMsg' | 'FacWarCorpLeaveWithdrawMsg' | 'FacWarLPDisqualifiedEvent' | 'FacWarLPDisqualifiedKill' | 'FacWarLPPayoutEvent' | 'FacWarLPPayoutKill' | 'GameTimeAdded' | 'GameTimeReceived' | 'GameTimeSent' | 'GiftReceived' | 'IHubDestroyedByBillFailure' | 'IncursionCompletedMsg' | 'IndustryOperationFinished' | 'IndustryTeamAuctionLost' | 'IndustryTeamAuctionWon' | 'InfrastructureHubBillAboutToExpire' | 'InsuranceExpirationMsg' | 'InsuranceFirstShipMsg' | 'InsuranceInvalidatedMsg' | 'InsuranceIssuedMsg' | 'InsurancePayoutMsg' | 'InvasionSystemLogin' | 'JumpCloneDeletedMsg1' | 'JumpCloneDeletedMsg2' | 'KillReportFinalBlow' | 'KillReportVictim' | 'KillRightAvailable' | 'KillRightAvailableOpen' | 'KillRightEarned' | 'KillRightUnavailable' | 'KillRightUnavailableOpen' | 'KillRightUsed' | 'LocateCharMsg' | 'MadeWarMutual' | 'MercOfferRetractedMsg' | 'MercOfferedNegotiationMsg' | 'MissionOfferExpirationMsg' | 'MissionTimeoutMsg' | 'MoonminingAutomaticFracture' | 'MoonminingExtractionCancelled' | 'MoonminingExtractionFinished' | 'MoonminingExtractionStarted' | 'MoonminingLaserFired' | 'MutualWarExpired' | 'MutualWarInviteAccepted' | 'MutualWarInviteRejected' | 'MutualWarInviteSent' | 'NPCStandingsGained' | 'NPCStandingsLost' | 'OfferToAllyRetracted' | 'OfferedSurrender' | 'OfferedToAlly' | 'OldLscMessages' | 'OperationFinished' | 'OrbitalAttacked' | 'OrbitalReinforced' | 'OwnershipTransferred' | 'RaffleCreated' | 'RaffleExpired' | 'RaffleFinished' | 'ReimbursementMsg' | 'ResearchMissionAvailableMsg' | 'RetractsWar' | 'SeasonalChallengeCompleted' | 'SovAllClaimAquiredMsg' | 'SovAllClaimLostMsg' | 'SovCommandNodeEventStarted' | 'SovCorpBillLateMsg' | 'SovCorpClaimFailMsg' | 'SovDisruptorMsg' | 'SovStationEnteredFreeport' | 'SovStructureDestroyed' | 'SovStructureReinforced' | 'SovStructureSelfDestructCancel' | 'SovStructureSelfDestructFinished' | 'SovStructureSelfDestructRequested' | 'SovereigntyIHDamageMsg' | 'SovereigntySBUDamageMsg' | 'SovereigntyTCUDamageMsg' | 'StationAggressionMsg1' | 'StationAggressionMsg2' | 'StationConquerMsg' | 'StationServiceDisabled' | 'StationServiceEnabled' | 'StationStateChangeMsg' | 'StoryLineMissionAvailableMsg' | 'StructureAnchoring' | 'StructureCourierContractChanged' | 'StructureDestroyed' | 'StructureFuelAlert' | 'StructureImpendingAbandonmentAssetsAtRisk' | 'StructureItemsDelivered' | 'StructureItemsMovedToSafety' | 'StructureLostArmor' | 'StructureLostShields' | 'StructureOnline' | 'StructureServicesOffline' | 'StructureUnanchoring' | 'StructureUnderAttack' | 'StructureWentHighPower' | 'StructureWentLowPower' | 'StructuresJobsCancelled' | 'StructuresJobsPaused' | 'StructuresReinforcementChanged' | 'TowerAlertMsg' | 'TowerResourceAlertMsg' | 'TransactionReversalMsg' | 'TutorialMsg' | 'WarAdopted ' | 'WarAllyInherited' | 'WarAllyOfferDeclinedMsg' | 'WarConcordInvalidates' | 'WarDeclared' | 'WarEndedHqSecurityDrop' | 'WarHQRemovedFromSpace' | 'WarInherited' | 'WarInvalid' | 'WarRetracted' | 'WarRetractedByConcord' | 'WarSurrenderDeclinedMsg' | 'WarSurrenderOfferMsg'}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/notifications/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{is_read?: boolean, notification_id: number, sender_id: number, sender_type: 'character' | 'corporation' | 'alliance' | 'faction' | 'other', text?: string, timestamp: string, type: 'AcceptedAlly' | 'AcceptedSurrender' | 'AllAnchoringMsg' | 'AllMaintenanceBillMsg' | 'AllStrucInvulnerableMsg' | 'AllStructVulnerableMsg' | 'AllWarCorpJoinedAllianceMsg' | 'AllWarDeclaredMsg' | 'AllWarInvalidatedMsg' | 'AllWarRetractedMsg' | 'AllWarSurrenderMsg' | 'AllianceCapitalChanged' | 'AllianceWarDeclaredV2' | 'AllyContractCancelled' | 'AllyJoinedWarAggressorMsg' | 'AllyJoinedWarAllyMsg' | 'AllyJoinedWarDefenderMsg' | 'BattlePunishFriendlyFire' | 'BillOutOfMoneyMsg' | 'BillPaidCorpAllMsg' | 'BountyClaimMsg' | 'BountyESSShared' | 'BountyESSTaken' | 'BountyPlacedAlliance' | 'BountyPlacedChar' | 'BountyPlacedCorp' | 'BountyYourBountyClaimed' | 'BuddyConnectContactAdd' | 'CharAppAcceptMsg' | 'CharAppRejectMsg' | 'CharAppWithdrawMsg' | 'CharLeftCorpMsg' | 'CharMedalMsg' | 'CharTerminationMsg' | 'CloneActivationMsg' | 'CloneActivationMsg2' | 'CloneMovedMsg' | 'CloneRevokedMsg1' | 'CloneRevokedMsg2' | 'CombatOperationFinished' | 'ContactAdd' | 'ContactEdit' | 'ContainerPasswordMsg' | 'CorpAllBillMsg' | 'CorpAppAcceptMsg' | 'CorpAppInvitedMsg' | 'CorpAppNewMsg' | 'CorpAppRejectCustomMsg' | 'CorpAppRejectMsg' | 'CorpBecameWarEligible' | 'CorpDividendMsg' | 'CorpFriendlyFireDisableTimerCompleted' | 'CorpFriendlyFireDisableTimerStarted' | 'CorpFriendlyFireEnableTimerCompleted' | 'CorpFriendlyFireEnableTimerStarted' | 'CorpKicked' | 'CorpLiquidationMsg' | 'CorpNewCEOMsg' | 'CorpNewsMsg' | 'CorpNoLongerWarEligible' | 'CorpOfficeExpirationMsg' | 'CorpStructLostMsg' | 'CorpTaxChangeMsg' | 'CorpVoteCEORevokedMsg' | 'CorpVoteMsg' | 'CorpWarDeclaredMsg' | 'CorpWarDeclaredV2' | 'CorpWarFightingLegalMsg' | 'CorpWarInvalidatedMsg' | 'CorpWarRetractedMsg' | 'CorpWarSurrenderMsg' | 'CustomsMsg' | 'DeclareWar' | 'DistrictAttacked' | 'DustAppAcceptedMsg' | 'EntosisCaptureStarted' | 'FWAllianceKickMsg' | 'FWAllianceWarningMsg' | 'FWCharKickMsg' | 'FWCharRankGainMsg' | 'FWCharRankLossMsg' | 'FWCharWarningMsg' | 'FWCorpJoinMsg' | 'FWCorpKickMsg' | 'FWCorpLeaveMsg' | 'FWCorpWarningMsg' | 'FacWarCorpJoinRequestMsg' | 'FacWarCorpJoinWithdrawMsg' | 'FacWarCorpLeaveRequestMsg' | 'FacWarCorpLeaveWithdrawMsg' | 'FacWarLPDisqualifiedEvent' | 'FacWarLPDisqualifiedKill' | 'FacWarLPPayoutEvent' | 'FacWarLPPayoutKill' | 'GameTimeAdded' | 'GameTimeReceived' | 'GameTimeSent' | 'GiftReceived' | 'IHubDestroyedByBillFailure' | 'IncursionCompletedMsg' | 'IndustryOperationFinished' | 'IndustryTeamAuctionLost' | 'IndustryTeamAuctionWon' | 'InfrastructureHubBillAboutToExpire' | 'InsuranceExpirationMsg' | 'InsuranceFirstShipMsg' | 'InsuranceInvalidatedMsg' | 'InsuranceIssuedMsg' | 'InsurancePayoutMsg' | 'InvasionSystemLogin' | 'JumpCloneDeletedMsg1' | 'JumpCloneDeletedMsg2' | 'KillReportFinalBlow' | 'KillReportVictim' | 'KillRightAvailable' | 'KillRightAvailableOpen' | 'KillRightEarned' | 'KillRightUnavailable' | 'KillRightUnavailableOpen' | 'KillRightUsed' | 'LocateCharMsg' | 'MadeWarMutual' | 'MercOfferRetractedMsg' | 'MercOfferedNegotiationMsg' | 'MissionOfferExpirationMsg' | 'MissionTimeoutMsg' | 'MoonminingAutomaticFracture' | 'MoonminingExtractionCancelled' | 'MoonminingExtractionFinished' | 'MoonminingExtractionStarted' | 'MoonminingLaserFired' | 'MutualWarExpired' | 'MutualWarInviteAccepted' | 'MutualWarInviteRejected' | 'MutualWarInviteSent' | 'NPCStandingsGained' | 'NPCStandingsLost' | 'OfferToAllyRetracted' | 'OfferedSurrender' | 'OfferedToAlly' | 'OldLscMessages' | 'OperationFinished' | 'OrbitalAttacked' | 'OrbitalReinforced' | 'OwnershipTransferred' | 'RaffleCreated' | 'RaffleExpired' | 'RaffleFinished' | 'ReimbursementMsg' | 'ResearchMissionAvailableMsg' | 'RetractsWar' | 'SeasonalChallengeCompleted' | 'SovAllClaimAquiredMsg' | 'SovAllClaimLostMsg' | 'SovCommandNodeEventStarted' | 'SovCorpBillLateMsg' | 'SovCorpClaimFailMsg' | 'SovDisruptorMsg' | 'SovStationEnteredFreeport' | 'SovStructureDestroyed' | 'SovStructureReinforced' | 'SovStructureSelfDestructCancel' | 'SovStructureSelfDestructFinished' | 'SovStructureSelfDestructRequested' | 'SovereigntyIHDamageMsg' | 'SovereigntySBUDamageMsg' | 'SovereigntyTCUDamageMsg' | 'StationAggressionMsg1' | 'StationAggressionMsg2' | 'StationConquerMsg' | 'StationServiceDisabled' | 'StationServiceEnabled' | 'StationStateChangeMsg' | 'StoryLineMissionAvailableMsg' | 'StructureAnchoring' | 'StructureCourierContractChanged' | 'StructureDestroyed' | 'StructureFuelAlert' | 'StructureImpendingAbandonmentAssetsAtRisk' | 'StructureItemsDelivered' | 'StructureItemsMovedToSafety' | 'StructureLostArmor' | 'StructureLostShields' | 'StructureOnline' | 'StructureServicesOffline' | 'StructureUnanchoring' | 'StructureUnderAttack' | 'StructureWentHighPower' | 'StructureWentLowPower' | 'StructuresJobsCancelled' | 'StructuresJobsPaused' | 'StructuresReinforcementChanged' | 'TowerAlertMsg' | 'TowerResourceAlertMsg' | 'TransactionReversalMsg' | 'TutorialMsg' | 'WarAdopted ' | 'WarAllyInherited' | 'WarAllyOfferDeclinedMsg' | 'WarConcordInvalidates' | 'WarDeclared' | 'WarEndedHqSecurityDrop' | 'WarHQRemovedFromSpace' | 'WarInherited' | 'WarInvalid' | 'WarRetracted' | 'WarRetractedByConcord' | 'WarSurrenderDeclinedMsg' | 'WarSurrenderOfferMsg'}>>;
      })
    );
  }
  /**
   * Get character notifications
   *
   * Return character notifications
   *
   * ---
   * Alternate route: `/v5/characters/{character_id}/notifications/`
   *
   * ---
   * This route is cached for up to 600 seconds
   * @param params The `CharacterService.GetCharactersCharacterIdNotificationsParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Returns your recent notifications
   */
  getCharactersCharacterIdNotifications(params: CharacterService.GetCharactersCharacterIdNotificationsParams): __Observable<Array<{is_read?: boolean, notification_id: number, sender_id: number, sender_type: 'character' | 'corporation' | 'alliance' | 'faction' | 'other', text?: string, timestamp: string, type: 'AcceptedAlly' | 'AcceptedSurrender' | 'AllAnchoringMsg' | 'AllMaintenanceBillMsg' | 'AllStrucInvulnerableMsg' | 'AllStructVulnerableMsg' | 'AllWarCorpJoinedAllianceMsg' | 'AllWarDeclaredMsg' | 'AllWarInvalidatedMsg' | 'AllWarRetractedMsg' | 'AllWarSurrenderMsg' | 'AllianceCapitalChanged' | 'AllianceWarDeclaredV2' | 'AllyContractCancelled' | 'AllyJoinedWarAggressorMsg' | 'AllyJoinedWarAllyMsg' | 'AllyJoinedWarDefenderMsg' | 'BattlePunishFriendlyFire' | 'BillOutOfMoneyMsg' | 'BillPaidCorpAllMsg' | 'BountyClaimMsg' | 'BountyESSShared' | 'BountyESSTaken' | 'BountyPlacedAlliance' | 'BountyPlacedChar' | 'BountyPlacedCorp' | 'BountyYourBountyClaimed' | 'BuddyConnectContactAdd' | 'CharAppAcceptMsg' | 'CharAppRejectMsg' | 'CharAppWithdrawMsg' | 'CharLeftCorpMsg' | 'CharMedalMsg' | 'CharTerminationMsg' | 'CloneActivationMsg' | 'CloneActivationMsg2' | 'CloneMovedMsg' | 'CloneRevokedMsg1' | 'CloneRevokedMsg2' | 'CombatOperationFinished' | 'ContactAdd' | 'ContactEdit' | 'ContainerPasswordMsg' | 'CorpAllBillMsg' | 'CorpAppAcceptMsg' | 'CorpAppInvitedMsg' | 'CorpAppNewMsg' | 'CorpAppRejectCustomMsg' | 'CorpAppRejectMsg' | 'CorpBecameWarEligible' | 'CorpDividendMsg' | 'CorpFriendlyFireDisableTimerCompleted' | 'CorpFriendlyFireDisableTimerStarted' | 'CorpFriendlyFireEnableTimerCompleted' | 'CorpFriendlyFireEnableTimerStarted' | 'CorpKicked' | 'CorpLiquidationMsg' | 'CorpNewCEOMsg' | 'CorpNewsMsg' | 'CorpNoLongerWarEligible' | 'CorpOfficeExpirationMsg' | 'CorpStructLostMsg' | 'CorpTaxChangeMsg' | 'CorpVoteCEORevokedMsg' | 'CorpVoteMsg' | 'CorpWarDeclaredMsg' | 'CorpWarDeclaredV2' | 'CorpWarFightingLegalMsg' | 'CorpWarInvalidatedMsg' | 'CorpWarRetractedMsg' | 'CorpWarSurrenderMsg' | 'CustomsMsg' | 'DeclareWar' | 'DistrictAttacked' | 'DustAppAcceptedMsg' | 'EntosisCaptureStarted' | 'FWAllianceKickMsg' | 'FWAllianceWarningMsg' | 'FWCharKickMsg' | 'FWCharRankGainMsg' | 'FWCharRankLossMsg' | 'FWCharWarningMsg' | 'FWCorpJoinMsg' | 'FWCorpKickMsg' | 'FWCorpLeaveMsg' | 'FWCorpWarningMsg' | 'FacWarCorpJoinRequestMsg' | 'FacWarCorpJoinWithdrawMsg' | 'FacWarCorpLeaveRequestMsg' | 'FacWarCorpLeaveWithdrawMsg' | 'FacWarLPDisqualifiedEvent' | 'FacWarLPDisqualifiedKill' | 'FacWarLPPayoutEvent' | 'FacWarLPPayoutKill' | 'GameTimeAdded' | 'GameTimeReceived' | 'GameTimeSent' | 'GiftReceived' | 'IHubDestroyedByBillFailure' | 'IncursionCompletedMsg' | 'IndustryOperationFinished' | 'IndustryTeamAuctionLost' | 'IndustryTeamAuctionWon' | 'InfrastructureHubBillAboutToExpire' | 'InsuranceExpirationMsg' | 'InsuranceFirstShipMsg' | 'InsuranceInvalidatedMsg' | 'InsuranceIssuedMsg' | 'InsurancePayoutMsg' | 'InvasionSystemLogin' | 'JumpCloneDeletedMsg1' | 'JumpCloneDeletedMsg2' | 'KillReportFinalBlow' | 'KillReportVictim' | 'KillRightAvailable' | 'KillRightAvailableOpen' | 'KillRightEarned' | 'KillRightUnavailable' | 'KillRightUnavailableOpen' | 'KillRightUsed' | 'LocateCharMsg' | 'MadeWarMutual' | 'MercOfferRetractedMsg' | 'MercOfferedNegotiationMsg' | 'MissionOfferExpirationMsg' | 'MissionTimeoutMsg' | 'MoonminingAutomaticFracture' | 'MoonminingExtractionCancelled' | 'MoonminingExtractionFinished' | 'MoonminingExtractionStarted' | 'MoonminingLaserFired' | 'MutualWarExpired' | 'MutualWarInviteAccepted' | 'MutualWarInviteRejected' | 'MutualWarInviteSent' | 'NPCStandingsGained' | 'NPCStandingsLost' | 'OfferToAllyRetracted' | 'OfferedSurrender' | 'OfferedToAlly' | 'OldLscMessages' | 'OperationFinished' | 'OrbitalAttacked' | 'OrbitalReinforced' | 'OwnershipTransferred' | 'RaffleCreated' | 'RaffleExpired' | 'RaffleFinished' | 'ReimbursementMsg' | 'ResearchMissionAvailableMsg' | 'RetractsWar' | 'SeasonalChallengeCompleted' | 'SovAllClaimAquiredMsg' | 'SovAllClaimLostMsg' | 'SovCommandNodeEventStarted' | 'SovCorpBillLateMsg' | 'SovCorpClaimFailMsg' | 'SovDisruptorMsg' | 'SovStationEnteredFreeport' | 'SovStructureDestroyed' | 'SovStructureReinforced' | 'SovStructureSelfDestructCancel' | 'SovStructureSelfDestructFinished' | 'SovStructureSelfDestructRequested' | 'SovereigntyIHDamageMsg' | 'SovereigntySBUDamageMsg' | 'SovereigntyTCUDamageMsg' | 'StationAggressionMsg1' | 'StationAggressionMsg2' | 'StationConquerMsg' | 'StationServiceDisabled' | 'StationServiceEnabled' | 'StationStateChangeMsg' | 'StoryLineMissionAvailableMsg' | 'StructureAnchoring' | 'StructureCourierContractChanged' | 'StructureDestroyed' | 'StructureFuelAlert' | 'StructureImpendingAbandonmentAssetsAtRisk' | 'StructureItemsDelivered' | 'StructureItemsMovedToSafety' | 'StructureLostArmor' | 'StructureLostShields' | 'StructureOnline' | 'StructureServicesOffline' | 'StructureUnanchoring' | 'StructureUnderAttack' | 'StructureWentHighPower' | 'StructureWentLowPower' | 'StructuresJobsCancelled' | 'StructuresJobsPaused' | 'StructuresReinforcementChanged' | 'TowerAlertMsg' | 'TowerResourceAlertMsg' | 'TransactionReversalMsg' | 'TutorialMsg' | 'WarAdopted ' | 'WarAllyInherited' | 'WarAllyOfferDeclinedMsg' | 'WarConcordInvalidates' | 'WarDeclared' | 'WarEndedHqSecurityDrop' | 'WarHQRemovedFromSpace' | 'WarInherited' | 'WarInvalid' | 'WarRetracted' | 'WarRetractedByConcord' | 'WarSurrenderDeclinedMsg' | 'WarSurrenderOfferMsg'}>> {
    return this.getCharactersCharacterIdNotificationsResponse(params).pipe(
      __map(_r => _r.body as Array<{is_read?: boolean, notification_id: number, sender_id: number, sender_type: 'character' | 'corporation' | 'alliance' | 'faction' | 'other', text?: string, timestamp: string, type: 'AcceptedAlly' | 'AcceptedSurrender' | 'AllAnchoringMsg' | 'AllMaintenanceBillMsg' | 'AllStrucInvulnerableMsg' | 'AllStructVulnerableMsg' | 'AllWarCorpJoinedAllianceMsg' | 'AllWarDeclaredMsg' | 'AllWarInvalidatedMsg' | 'AllWarRetractedMsg' | 'AllWarSurrenderMsg' | 'AllianceCapitalChanged' | 'AllianceWarDeclaredV2' | 'AllyContractCancelled' | 'AllyJoinedWarAggressorMsg' | 'AllyJoinedWarAllyMsg' | 'AllyJoinedWarDefenderMsg' | 'BattlePunishFriendlyFire' | 'BillOutOfMoneyMsg' | 'BillPaidCorpAllMsg' | 'BountyClaimMsg' | 'BountyESSShared' | 'BountyESSTaken' | 'BountyPlacedAlliance' | 'BountyPlacedChar' | 'BountyPlacedCorp' | 'BountyYourBountyClaimed' | 'BuddyConnectContactAdd' | 'CharAppAcceptMsg' | 'CharAppRejectMsg' | 'CharAppWithdrawMsg' | 'CharLeftCorpMsg' | 'CharMedalMsg' | 'CharTerminationMsg' | 'CloneActivationMsg' | 'CloneActivationMsg2' | 'CloneMovedMsg' | 'CloneRevokedMsg1' | 'CloneRevokedMsg2' | 'CombatOperationFinished' | 'ContactAdd' | 'ContactEdit' | 'ContainerPasswordMsg' | 'CorpAllBillMsg' | 'CorpAppAcceptMsg' | 'CorpAppInvitedMsg' | 'CorpAppNewMsg' | 'CorpAppRejectCustomMsg' | 'CorpAppRejectMsg' | 'CorpBecameWarEligible' | 'CorpDividendMsg' | 'CorpFriendlyFireDisableTimerCompleted' | 'CorpFriendlyFireDisableTimerStarted' | 'CorpFriendlyFireEnableTimerCompleted' | 'CorpFriendlyFireEnableTimerStarted' | 'CorpKicked' | 'CorpLiquidationMsg' | 'CorpNewCEOMsg' | 'CorpNewsMsg' | 'CorpNoLongerWarEligible' | 'CorpOfficeExpirationMsg' | 'CorpStructLostMsg' | 'CorpTaxChangeMsg' | 'CorpVoteCEORevokedMsg' | 'CorpVoteMsg' | 'CorpWarDeclaredMsg' | 'CorpWarDeclaredV2' | 'CorpWarFightingLegalMsg' | 'CorpWarInvalidatedMsg' | 'CorpWarRetractedMsg' | 'CorpWarSurrenderMsg' | 'CustomsMsg' | 'DeclareWar' | 'DistrictAttacked' | 'DustAppAcceptedMsg' | 'EntosisCaptureStarted' | 'FWAllianceKickMsg' | 'FWAllianceWarningMsg' | 'FWCharKickMsg' | 'FWCharRankGainMsg' | 'FWCharRankLossMsg' | 'FWCharWarningMsg' | 'FWCorpJoinMsg' | 'FWCorpKickMsg' | 'FWCorpLeaveMsg' | 'FWCorpWarningMsg' | 'FacWarCorpJoinRequestMsg' | 'FacWarCorpJoinWithdrawMsg' | 'FacWarCorpLeaveRequestMsg' | 'FacWarCorpLeaveWithdrawMsg' | 'FacWarLPDisqualifiedEvent' | 'FacWarLPDisqualifiedKill' | 'FacWarLPPayoutEvent' | 'FacWarLPPayoutKill' | 'GameTimeAdded' | 'GameTimeReceived' | 'GameTimeSent' | 'GiftReceived' | 'IHubDestroyedByBillFailure' | 'IncursionCompletedMsg' | 'IndustryOperationFinished' | 'IndustryTeamAuctionLost' | 'IndustryTeamAuctionWon' | 'InfrastructureHubBillAboutToExpire' | 'InsuranceExpirationMsg' | 'InsuranceFirstShipMsg' | 'InsuranceInvalidatedMsg' | 'InsuranceIssuedMsg' | 'InsurancePayoutMsg' | 'InvasionSystemLogin' | 'JumpCloneDeletedMsg1' | 'JumpCloneDeletedMsg2' | 'KillReportFinalBlow' | 'KillReportVictim' | 'KillRightAvailable' | 'KillRightAvailableOpen' | 'KillRightEarned' | 'KillRightUnavailable' | 'KillRightUnavailableOpen' | 'KillRightUsed' | 'LocateCharMsg' | 'MadeWarMutual' | 'MercOfferRetractedMsg' | 'MercOfferedNegotiationMsg' | 'MissionOfferExpirationMsg' | 'MissionTimeoutMsg' | 'MoonminingAutomaticFracture' | 'MoonminingExtractionCancelled' | 'MoonminingExtractionFinished' | 'MoonminingExtractionStarted' | 'MoonminingLaserFired' | 'MutualWarExpired' | 'MutualWarInviteAccepted' | 'MutualWarInviteRejected' | 'MutualWarInviteSent' | 'NPCStandingsGained' | 'NPCStandingsLost' | 'OfferToAllyRetracted' | 'OfferedSurrender' | 'OfferedToAlly' | 'OldLscMessages' | 'OperationFinished' | 'OrbitalAttacked' | 'OrbitalReinforced' | 'OwnershipTransferred' | 'RaffleCreated' | 'RaffleExpired' | 'RaffleFinished' | 'ReimbursementMsg' | 'ResearchMissionAvailableMsg' | 'RetractsWar' | 'SeasonalChallengeCompleted' | 'SovAllClaimAquiredMsg' | 'SovAllClaimLostMsg' | 'SovCommandNodeEventStarted' | 'SovCorpBillLateMsg' | 'SovCorpClaimFailMsg' | 'SovDisruptorMsg' | 'SovStationEnteredFreeport' | 'SovStructureDestroyed' | 'SovStructureReinforced' | 'SovStructureSelfDestructCancel' | 'SovStructureSelfDestructFinished' | 'SovStructureSelfDestructRequested' | 'SovereigntyIHDamageMsg' | 'SovereigntySBUDamageMsg' | 'SovereigntyTCUDamageMsg' | 'StationAggressionMsg1' | 'StationAggressionMsg2' | 'StationConquerMsg' | 'StationServiceDisabled' | 'StationServiceEnabled' | 'StationStateChangeMsg' | 'StoryLineMissionAvailableMsg' | 'StructureAnchoring' | 'StructureCourierContractChanged' | 'StructureDestroyed' | 'StructureFuelAlert' | 'StructureImpendingAbandonmentAssetsAtRisk' | 'StructureItemsDelivered' | 'StructureItemsMovedToSafety' | 'StructureLostArmor' | 'StructureLostShields' | 'StructureOnline' | 'StructureServicesOffline' | 'StructureUnanchoring' | 'StructureUnderAttack' | 'StructureWentHighPower' | 'StructureWentLowPower' | 'StructuresJobsCancelled' | 'StructuresJobsPaused' | 'StructuresReinforcementChanged' | 'TowerAlertMsg' | 'TowerResourceAlertMsg' | 'TransactionReversalMsg' | 'TutorialMsg' | 'WarAdopted ' | 'WarAllyInherited' | 'WarAllyOfferDeclinedMsg' | 'WarConcordInvalidates' | 'WarDeclared' | 'WarEndedHqSecurityDrop' | 'WarHQRemovedFromSpace' | 'WarInherited' | 'WarInvalid' | 'WarRetracted' | 'WarRetractedByConcord' | 'WarSurrenderDeclinedMsg' | 'WarSurrenderOfferMsg'}>)
    );
  }

  /**
   * Get new contact notifications
   *
   * Return notifications about having been added to someone's contact list
   *
   * ---
   * Alternate route: `/legacy/characters/{character_id}/notifications/contacts/`
   *
   * Alternate route: `/v1/characters/{character_id}/notifications/contacts/`
   *
   * ---
   * This route is cached for up to 600 seconds
   * @param params The `CharacterService.GetCharactersCharacterIdNotificationsContactsParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of contact notifications
   */
  getCharactersCharacterIdNotificationsContactsResponse(params: CharacterService.GetCharactersCharacterIdNotificationsContactsParams): __Observable<__StrictHttpResponse<Array<{message: string, notification_id: number, send_date: string, sender_character_id: number, standing_level: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/notifications/contacts/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{message: string, notification_id: number, send_date: string, sender_character_id: number, standing_level: number}>>;
      })
    );
  }
  /**
   * Get new contact notifications
   *
   * Return notifications about having been added to someone's contact list
   *
   * ---
   * Alternate route: `/legacy/characters/{character_id}/notifications/contacts/`
   *
   * Alternate route: `/v1/characters/{character_id}/notifications/contacts/`
   *
   * ---
   * This route is cached for up to 600 seconds
   * @param params The `CharacterService.GetCharactersCharacterIdNotificationsContactsParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of contact notifications
   */
  getCharactersCharacterIdNotificationsContacts(params: CharacterService.GetCharactersCharacterIdNotificationsContactsParams): __Observable<Array<{message: string, notification_id: number, send_date: string, sender_character_id: number, standing_level: number}>> {
    return this.getCharactersCharacterIdNotificationsContactsResponse(params).pipe(
      __map(_r => _r.body as Array<{message: string, notification_id: number, send_date: string, sender_character_id: number, standing_level: number}>)
    );
  }

  /**
   * Get character portraits
   *
   * Get portrait urls for a character
   *
   * ---
   * Alternate route: `/v2/characters/{character_id}/portrait/`
   *
   * ---
   * This route expires daily at 11:05
   *
   * ---
   * [Diff of the upcoming changes](https://esi.evetech.net/diff/latest/dev/#GET-/characters/{character_id}/portrait/)
   * @param params The `CharacterService.GetCharactersCharacterIdPortraitParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Public data for the given character
   */
  getCharactersCharacterIdPortraitResponse(params: CharacterService.GetCharactersCharacterIdPortraitParams): __Observable<__StrictHttpResponse<{px128x128?: string, px256x256?: string, px512x512?: string, px64x64?: string}>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/portrait/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<{px128x128?: string, px256x256?: string, px512x512?: string, px64x64?: string}>;
      })
    );
  }
  /**
   * Get character portraits
   *
   * Get portrait urls for a character
   *
   * ---
   * Alternate route: `/v2/characters/{character_id}/portrait/`
   *
   * ---
   * This route expires daily at 11:05
   *
   * ---
   * [Diff of the upcoming changes](https://esi.evetech.net/diff/latest/dev/#GET-/characters/{character_id}/portrait/)
   * @param params The `CharacterService.GetCharactersCharacterIdPortraitParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Public data for the given character
   */
  getCharactersCharacterIdPortrait(params: CharacterService.GetCharactersCharacterIdPortraitParams): __Observable<{px128x128?: string, px256x256?: string, px512x512?: string, px64x64?: string}> {
    return this.getCharactersCharacterIdPortraitResponse(params).pipe(
      __map(_r => _r.body as {px128x128?: string, px256x256?: string, px512x512?: string, px64x64?: string})
    );
  }

  /**
   * Get character corporation roles
   *
   * Returns a character's corporation roles
   *
   * ---
   * Alternate route: `/v2/characters/{character_id}/roles/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `CharacterService.GetCharactersCharacterIdRolesParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return The character's roles in thier corporation
   */
  getCharactersCharacterIdRolesResponse(params: CharacterService.GetCharactersCharacterIdRolesParams): __Observable<__StrictHttpResponse<{roles?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, roles_at_base?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, roles_at_hq?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, roles_at_other?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>}>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/roles/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<{roles?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, roles_at_base?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, roles_at_hq?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, roles_at_other?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>}>;
      })
    );
  }
  /**
   * Get character corporation roles
   *
   * Returns a character's corporation roles
   *
   * ---
   * Alternate route: `/v2/characters/{character_id}/roles/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `CharacterService.GetCharactersCharacterIdRolesParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return The character's roles in thier corporation
   */
  getCharactersCharacterIdRoles(params: CharacterService.GetCharactersCharacterIdRolesParams): __Observable<{roles?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, roles_at_base?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, roles_at_hq?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, roles_at_other?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>}> {
    return this.getCharactersCharacterIdRolesResponse(params).pipe(
      __map(_r => _r.body as {roles?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, roles_at_base?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, roles_at_hq?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>, roles_at_other?: Array<'Account_Take_1' | 'Account_Take_2' | 'Account_Take_3' | 'Account_Take_4' | 'Account_Take_5' | 'Account_Take_6' | 'Account_Take_7' | 'Accountant' | 'Auditor' | 'Communications_Officer' | 'Config_Equipment' | 'Config_Starbase_Equipment' | 'Container_Take_1' | 'Container_Take_2' | 'Container_Take_3' | 'Container_Take_4' | 'Container_Take_5' | 'Container_Take_6' | 'Container_Take_7' | 'Contract_Manager' | 'Diplomat' | 'Director' | 'Factory_Manager' | 'Fitting_Manager' | 'Hangar_Query_1' | 'Hangar_Query_2' | 'Hangar_Query_3' | 'Hangar_Query_4' | 'Hangar_Query_5' | 'Hangar_Query_6' | 'Hangar_Query_7' | 'Hangar_Take_1' | 'Hangar_Take_2' | 'Hangar_Take_3' | 'Hangar_Take_4' | 'Hangar_Take_5' | 'Hangar_Take_6' | 'Hangar_Take_7' | 'Junior_Accountant' | 'Personnel_Manager' | 'Rent_Factory_Facility' | 'Rent_Office' | 'Rent_Research_Facility' | 'Security_Officer' | 'Starbase_Defense_Operator' | 'Starbase_Fuel_Technician' | 'Station_Manager' | 'Trader'>})
    );
  }

  /**
   * Get standings
   *
   * Return character standings from agents, NPC corporations, and factions
   *
   * ---
   * Alternate route: `/legacy/characters/{character_id}/standings/`
   *
   * Alternate route: `/v1/characters/{character_id}/standings/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `CharacterService.GetCharactersCharacterIdStandingsParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of standings
   */
  getCharactersCharacterIdStandingsResponse(params: CharacterService.GetCharactersCharacterIdStandingsParams): __Observable<__StrictHttpResponse<Array<{from_id: number, from_type: 'agent' | 'npc_corp' | 'faction', standing: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/standings/`,
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
   * Get standings
   *
   * Return character standings from agents, NPC corporations, and factions
   *
   * ---
   * Alternate route: `/legacy/characters/{character_id}/standings/`
   *
   * Alternate route: `/v1/characters/{character_id}/standings/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `CharacterService.GetCharactersCharacterIdStandingsParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of standings
   */
  getCharactersCharacterIdStandings(params: CharacterService.GetCharactersCharacterIdStandingsParams): __Observable<Array<{from_id: number, from_type: 'agent' | 'npc_corp' | 'faction', standing: number}>> {
    return this.getCharactersCharacterIdStandingsResponse(params).pipe(
      __map(_r => _r.body as Array<{from_id: number, from_type: 'agent' | 'npc_corp' | 'faction', standing: number}>)
    );
  }

  /**
   * Yearly aggregate stats
   *
   * Returns aggregate yearly stats for a character
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/stats/`
   *
   * Alternate route: `/v2/characters/{character_id}/stats/`
   *
   * ---
   * This route is cached for up to 86400 seconds
   * @param params The `CharacterService.GetCharactersCharacterIdStatsParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Character stats
   */
  getCharactersCharacterIdStatsResponse(params: CharacterService.GetCharactersCharacterIdStatsParams): __Observable<__StrictHttpResponse<Array<{character?: {days_of_activity?: number, minutes?: number, sessions_started?: number}, combat?: {cap_drainedby_npc?: number, cap_drainedby_pc?: number, cap_draining_pc?: number, criminal_flag_set?: number, damage_from_np_cs_amount?: number, damage_from_np_cs_num_shots?: number, damage_from_players_bomb_amount?: number, damage_from_players_bomb_num_shots?: number, damage_from_players_combat_drone_amount?: number, damage_from_players_combat_drone_num_shots?: number, damage_from_players_energy_amount?: number, damage_from_players_energy_num_shots?: number, damage_from_players_fighter_bomber_amount?: number, damage_from_players_fighter_bomber_num_shots?: number, damage_from_players_fighter_drone_amount?: number, damage_from_players_fighter_drone_num_shots?: number, damage_from_players_hybrid_amount?: number, damage_from_players_hybrid_num_shots?: number, damage_from_players_missile_amount?: number, damage_from_players_missile_num_shots?: number, damage_from_players_projectile_amount?: number, damage_from_players_projectile_num_shots?: number, damage_from_players_smart_bomb_amount?: number, damage_from_players_smart_bomb_num_shots?: number, damage_from_players_super_amount?: number, damage_from_players_super_num_shots?: number, damage_from_structures_total_amount?: number, damage_from_structures_total_num_shots?: number, damage_to_players_bomb_amount?: number, damage_to_players_bomb_num_shots?: number, damage_to_players_combat_drone_amount?: number, damage_to_players_combat_drone_num_shots?: number, damage_to_players_energy_amount?: number, damage_to_players_energy_num_shots?: number, damage_to_players_fighter_bomber_amount?: number, damage_to_players_fighter_bomber_num_shots?: number, damage_to_players_fighter_drone_amount?: number, damage_to_players_fighter_drone_num_shots?: number, damage_to_players_hybrid_amount?: number, damage_to_players_hybrid_num_shots?: number, damage_to_players_missile_amount?: number, damage_to_players_missile_num_shots?: number, damage_to_players_projectile_amount?: number, damage_to_players_projectile_num_shots?: number, damage_to_players_smart_bomb_amount?: number, damage_to_players_smart_bomb_num_shots?: number, damage_to_players_super_amount?: number, damage_to_players_super_num_shots?: number, damage_to_structures_total_amount?: number, damage_to_structures_total_num_shots?: number, deaths_high_sec?: number, deaths_low_sec?: number, deaths_null_sec?: number, deaths_pod_high_sec?: number, deaths_pod_low_sec?: number, deaths_pod_null_sec?: number, deaths_pod_wormhole?: number, deaths_wormhole?: number, drone_engage?: number, dscans?: number, duel_requested?: number, engagement_register?: number, kills_assists?: number, kills_high_sec?: number, kills_low_sec?: number, kills_null_sec?: number, kills_pod_high_sec?: number, kills_pod_low_sec?: number, kills_pod_null_sec?: number, kills_pod_wormhole?: number, kills_wormhole?: number, npc_flag_set?: number, probe_scans?: number, pvp_flag_set?: number, repair_armor_by_remote_amount?: number, repair_armor_remote_amount?: number, repair_armor_self_amount?: number, repair_capacitor_by_remote_amount?: number, repair_capacitor_remote_amount?: number, repair_capacitor_self_amount?: number, repair_hull_by_remote_amount?: number, repair_hull_remote_amount?: number, repair_hull_self_amount?: number, repair_shield_by_remote_amount?: number, repair_shield_remote_amount?: number, repair_shield_self_amount?: number, self_destructs?: number, warp_scramble_pc?: number, warp_scrambledby_npc?: number, warp_scrambledby_pc?: number, weapon_flag_set?: number, webifiedby_npc?: number, webifiedby_pc?: number, webifying_pc?: number}, industry?: {hacking_successes?: number, jobs_cancelled?: number, jobs_completed_copy_blueprint?: number, jobs_completed_invention?: number, jobs_completed_manufacture?: number, jobs_completed_manufacture_asteroid?: number, jobs_completed_manufacture_asteroid_quantity?: number, jobs_completed_manufacture_charge?: number, jobs_completed_manufacture_charge_quantity?: number, jobs_completed_manufacture_commodity?: number, jobs_completed_manufacture_commodity_quantity?: number, jobs_completed_manufacture_deployable?: number, jobs_completed_manufacture_deployable_quantity?: number, jobs_completed_manufacture_drone?: number, jobs_completed_manufacture_drone_quantity?: number, jobs_completed_manufacture_implant?: number, jobs_completed_manufacture_implant_quantity?: number, jobs_completed_manufacture_module?: number, jobs_completed_manufacture_module_quantity?: number, jobs_completed_manufacture_other?: number, jobs_completed_manufacture_other_quantity?: number, jobs_completed_manufacture_ship?: number, jobs_completed_manufacture_ship_quantity?: number, jobs_completed_manufacture_structure?: number, jobs_completed_manufacture_structure_quantity?: number, jobs_completed_manufacture_subsystem?: number, jobs_completed_manufacture_subsystem_quantity?: number, jobs_completed_material_productivity?: number, jobs_completed_time_productivity?: number, jobs_started_copy_blueprint?: number, jobs_started_invention?: number, jobs_started_manufacture?: number, jobs_started_material_productivity?: number, jobs_started_time_productivity?: number, reprocess_item?: number, reprocess_item_quantity?: number}, inventory?: {abandon_loot_quantity?: number, trash_item_quantity?: number}, isk?: {in?: number, out?: number}, market?: {accept_contracts_courier?: number, accept_contracts_item_exchange?: number, buy_orders_placed?: number, cancel_market_order?: number, create_contracts_auction?: number, create_contracts_courier?: number, create_contracts_item_exchange?: number, deliver_courier_contract?: number, isk_gained?: number, isk_spent?: number, modify_market_order?: number, search_contracts?: number, sell_orders_placed?: number}, mining?: {drone_mine?: number, ore_arkonor?: number, ore_bistot?: number, ore_crokite?: number, ore_dark_ochre?: number, ore_gneiss?: number, ore_harvestable_cloud?: number, ore_hedbergite?: number, ore_hemorphite?: number, ore_ice?: number, ore_jaspet?: number, ore_kernite?: number, ore_mercoxit?: number, ore_omber?: number, ore_plagioclase?: number, ore_pyroxeres?: number, ore_scordite?: number, ore_spodumain?: number, ore_veldspar?: number}, module?: {activations_armor_hardener?: number, activations_armor_repair_unit?: number, activations_armor_resistance_shift_hardener?: number, activations_automated_targeting_system?: number, activations_bastion?: number, activations_bomb_launcher?: number, activations_capacitor_booster?: number, activations_cargo_scanner?: number, activations_cloaking_device?: number, activations_clone_vat_bay?: number, activations_cynosural_field?: number, activations_damage_control?: number, activations_data_miners?: number, activations_drone_control_unit?: number, activations_drone_tracking_modules?: number, activations_eccm?: number, activations_ecm?: number, activations_ecm_burst?: number, activations_energy_destabilizer?: number, activations_energy_vampire?: number, activations_energy_weapon?: number, activations_festival_launcher?: number, activations_frequency_mining_laser?: number, activations_fueled_armor_repairer?: number, activations_fueled_shield_booster?: number, activations_gang_coordinator?: number, activations_gas_cloud_harvester?: number, activations_hull_repair_unit?: number, activations_hybrid_weapon?: number, activations_industrial_core?: number, activations_interdiction_sphere_launcher?: number, activations_micro_jump_drive?: number, activations_mining_laser?: number, activations_missile_launcher?: number, activations_passive_targeting_system?: number, activations_probe_launcher?: number, activations_projected_eccm?: number, activations_projectile_weapon?: number, activations_propulsion_module?: number, activations_remote_armor_repairer?: number, activations_remote_capacitor_transmitter?: number, activations_remote_ecm_burst?: number, activations_remote_hull_repairer?: number, activations_remote_sensor_booster?: number, activations_remote_sensor_damper?: number, activations_remote_shield_booster?: number, activations_remote_tracking_computer?: number, activations_salvager?: number, activations_sensor_booster?: number, activations_shield_booster?: number, activations_shield_hardener?: number, activations_ship_scanner?: number, activations_siege?: number, activations_smart_bomb?: number, activations_stasis_web?: number, activations_strip_miner?: number, activations_super_weapon?: number, activations_survey_scanner?: number, activations_target_breaker?: number, activations_target_painter?: number, activations_tracking_computer?: number, activations_tracking_disruptor?: number, activations_tractor_beam?: number, activations_triage?: number, activations_warp_disrupt_field_generator?: number, activations_warp_scrambler?: number, link_weapons?: number, overload?: number, repairs?: number}, orbital?: {strike_characters_killed?: number, strike_damage_to_players_armor_amount?: number, strike_damage_to_players_shield_amount?: number}, pve?: {dungeons_completed_agent?: number, dungeons_completed_distribution?: number, missions_succeeded?: number, missions_succeeded_epic_arc?: number}, social?: {add_contact_bad?: number, add_contact_good?: number, add_contact_high?: number, add_contact_horrible?: number, add_contact_neutral?: number, add_note?: number, added_as_contact_bad?: number, added_as_contact_good?: number, added_as_contact_high?: number, added_as_contact_horrible?: number, added_as_contact_neutral?: number, calendar_event_created?: number, chat_messages_alliance?: number, chat_messages_constellation?: number, chat_messages_corporation?: number, chat_messages_fleet?: number, chat_messages_region?: number, chat_messages_solarsystem?: number, chat_messages_warfaction?: number, chat_total_message_length?: number, direct_trades?: number, fleet_broadcasts?: number, fleet_joins?: number, mails_received?: number, mails_sent?: number}, travel?: {acceleration_gate_activations?: number, align_to?: number, distance_warped_high_sec?: number, distance_warped_low_sec?: number, distance_warped_null_sec?: number, distance_warped_wormhole?: number, docks_high_sec?: number, docks_low_sec?: number, docks_null_sec?: number, jumps_stargate_high_sec?: number, jumps_stargate_low_sec?: number, jumps_stargate_null_sec?: number, jumps_wormhole?: number, warps_high_sec?: number, warps_low_sec?: number, warps_null_sec?: number, warps_to_bookmark?: number, warps_to_celestial?: number, warps_to_fleet_member?: number, warps_to_scan_result?: number, warps_wormhole?: number}, year: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/stats/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{character?: {days_of_activity?: number, minutes?: number, sessions_started?: number}, combat?: {cap_drainedby_npc?: number, cap_drainedby_pc?: number, cap_draining_pc?: number, criminal_flag_set?: number, damage_from_np_cs_amount?: number, damage_from_np_cs_num_shots?: number, damage_from_players_bomb_amount?: number, damage_from_players_bomb_num_shots?: number, damage_from_players_combat_drone_amount?: number, damage_from_players_combat_drone_num_shots?: number, damage_from_players_energy_amount?: number, damage_from_players_energy_num_shots?: number, damage_from_players_fighter_bomber_amount?: number, damage_from_players_fighter_bomber_num_shots?: number, damage_from_players_fighter_drone_amount?: number, damage_from_players_fighter_drone_num_shots?: number, damage_from_players_hybrid_amount?: number, damage_from_players_hybrid_num_shots?: number, damage_from_players_missile_amount?: number, damage_from_players_missile_num_shots?: number, damage_from_players_projectile_amount?: number, damage_from_players_projectile_num_shots?: number, damage_from_players_smart_bomb_amount?: number, damage_from_players_smart_bomb_num_shots?: number, damage_from_players_super_amount?: number, damage_from_players_super_num_shots?: number, damage_from_structures_total_amount?: number, damage_from_structures_total_num_shots?: number, damage_to_players_bomb_amount?: number, damage_to_players_bomb_num_shots?: number, damage_to_players_combat_drone_amount?: number, damage_to_players_combat_drone_num_shots?: number, damage_to_players_energy_amount?: number, damage_to_players_energy_num_shots?: number, damage_to_players_fighter_bomber_amount?: number, damage_to_players_fighter_bomber_num_shots?: number, damage_to_players_fighter_drone_amount?: number, damage_to_players_fighter_drone_num_shots?: number, damage_to_players_hybrid_amount?: number, damage_to_players_hybrid_num_shots?: number, damage_to_players_missile_amount?: number, damage_to_players_missile_num_shots?: number, damage_to_players_projectile_amount?: number, damage_to_players_projectile_num_shots?: number, damage_to_players_smart_bomb_amount?: number, damage_to_players_smart_bomb_num_shots?: number, damage_to_players_super_amount?: number, damage_to_players_super_num_shots?: number, damage_to_structures_total_amount?: number, damage_to_structures_total_num_shots?: number, deaths_high_sec?: number, deaths_low_sec?: number, deaths_null_sec?: number, deaths_pod_high_sec?: number, deaths_pod_low_sec?: number, deaths_pod_null_sec?: number, deaths_pod_wormhole?: number, deaths_wormhole?: number, drone_engage?: number, dscans?: number, duel_requested?: number, engagement_register?: number, kills_assists?: number, kills_high_sec?: number, kills_low_sec?: number, kills_null_sec?: number, kills_pod_high_sec?: number, kills_pod_low_sec?: number, kills_pod_null_sec?: number, kills_pod_wormhole?: number, kills_wormhole?: number, npc_flag_set?: number, probe_scans?: number, pvp_flag_set?: number, repair_armor_by_remote_amount?: number, repair_armor_remote_amount?: number, repair_armor_self_amount?: number, repair_capacitor_by_remote_amount?: number, repair_capacitor_remote_amount?: number, repair_capacitor_self_amount?: number, repair_hull_by_remote_amount?: number, repair_hull_remote_amount?: number, repair_hull_self_amount?: number, repair_shield_by_remote_amount?: number, repair_shield_remote_amount?: number, repair_shield_self_amount?: number, self_destructs?: number, warp_scramble_pc?: number, warp_scrambledby_npc?: number, warp_scrambledby_pc?: number, weapon_flag_set?: number, webifiedby_npc?: number, webifiedby_pc?: number, webifying_pc?: number}, industry?: {hacking_successes?: number, jobs_cancelled?: number, jobs_completed_copy_blueprint?: number, jobs_completed_invention?: number, jobs_completed_manufacture?: number, jobs_completed_manufacture_asteroid?: number, jobs_completed_manufacture_asteroid_quantity?: number, jobs_completed_manufacture_charge?: number, jobs_completed_manufacture_charge_quantity?: number, jobs_completed_manufacture_commodity?: number, jobs_completed_manufacture_commodity_quantity?: number, jobs_completed_manufacture_deployable?: number, jobs_completed_manufacture_deployable_quantity?: number, jobs_completed_manufacture_drone?: number, jobs_completed_manufacture_drone_quantity?: number, jobs_completed_manufacture_implant?: number, jobs_completed_manufacture_implant_quantity?: number, jobs_completed_manufacture_module?: number, jobs_completed_manufacture_module_quantity?: number, jobs_completed_manufacture_other?: number, jobs_completed_manufacture_other_quantity?: number, jobs_completed_manufacture_ship?: number, jobs_completed_manufacture_ship_quantity?: number, jobs_completed_manufacture_structure?: number, jobs_completed_manufacture_structure_quantity?: number, jobs_completed_manufacture_subsystem?: number, jobs_completed_manufacture_subsystem_quantity?: number, jobs_completed_material_productivity?: number, jobs_completed_time_productivity?: number, jobs_started_copy_blueprint?: number, jobs_started_invention?: number, jobs_started_manufacture?: number, jobs_started_material_productivity?: number, jobs_started_time_productivity?: number, reprocess_item?: number, reprocess_item_quantity?: number}, inventory?: {abandon_loot_quantity?: number, trash_item_quantity?: number}, isk?: {in?: number, out?: number}, market?: {accept_contracts_courier?: number, accept_contracts_item_exchange?: number, buy_orders_placed?: number, cancel_market_order?: number, create_contracts_auction?: number, create_contracts_courier?: number, create_contracts_item_exchange?: number, deliver_courier_contract?: number, isk_gained?: number, isk_spent?: number, modify_market_order?: number, search_contracts?: number, sell_orders_placed?: number}, mining?: {drone_mine?: number, ore_arkonor?: number, ore_bistot?: number, ore_crokite?: number, ore_dark_ochre?: number, ore_gneiss?: number, ore_harvestable_cloud?: number, ore_hedbergite?: number, ore_hemorphite?: number, ore_ice?: number, ore_jaspet?: number, ore_kernite?: number, ore_mercoxit?: number, ore_omber?: number, ore_plagioclase?: number, ore_pyroxeres?: number, ore_scordite?: number, ore_spodumain?: number, ore_veldspar?: number}, module?: {activations_armor_hardener?: number, activations_armor_repair_unit?: number, activations_armor_resistance_shift_hardener?: number, activations_automated_targeting_system?: number, activations_bastion?: number, activations_bomb_launcher?: number, activations_capacitor_booster?: number, activations_cargo_scanner?: number, activations_cloaking_device?: number, activations_clone_vat_bay?: number, activations_cynosural_field?: number, activations_damage_control?: number, activations_data_miners?: number, activations_drone_control_unit?: number, activations_drone_tracking_modules?: number, activations_eccm?: number, activations_ecm?: number, activations_ecm_burst?: number, activations_energy_destabilizer?: number, activations_energy_vampire?: number, activations_energy_weapon?: number, activations_festival_launcher?: number, activations_frequency_mining_laser?: number, activations_fueled_armor_repairer?: number, activations_fueled_shield_booster?: number, activations_gang_coordinator?: number, activations_gas_cloud_harvester?: number, activations_hull_repair_unit?: number, activations_hybrid_weapon?: number, activations_industrial_core?: number, activations_interdiction_sphere_launcher?: number, activations_micro_jump_drive?: number, activations_mining_laser?: number, activations_missile_launcher?: number, activations_passive_targeting_system?: number, activations_probe_launcher?: number, activations_projected_eccm?: number, activations_projectile_weapon?: number, activations_propulsion_module?: number, activations_remote_armor_repairer?: number, activations_remote_capacitor_transmitter?: number, activations_remote_ecm_burst?: number, activations_remote_hull_repairer?: number, activations_remote_sensor_booster?: number, activations_remote_sensor_damper?: number, activations_remote_shield_booster?: number, activations_remote_tracking_computer?: number, activations_salvager?: number, activations_sensor_booster?: number, activations_shield_booster?: number, activations_shield_hardener?: number, activations_ship_scanner?: number, activations_siege?: number, activations_smart_bomb?: number, activations_stasis_web?: number, activations_strip_miner?: number, activations_super_weapon?: number, activations_survey_scanner?: number, activations_target_breaker?: number, activations_target_painter?: number, activations_tracking_computer?: number, activations_tracking_disruptor?: number, activations_tractor_beam?: number, activations_triage?: number, activations_warp_disrupt_field_generator?: number, activations_warp_scrambler?: number, link_weapons?: number, overload?: number, repairs?: number}, orbital?: {strike_characters_killed?: number, strike_damage_to_players_armor_amount?: number, strike_damage_to_players_shield_amount?: number}, pve?: {dungeons_completed_agent?: number, dungeons_completed_distribution?: number, missions_succeeded?: number, missions_succeeded_epic_arc?: number}, social?: {add_contact_bad?: number, add_contact_good?: number, add_contact_high?: number, add_contact_horrible?: number, add_contact_neutral?: number, add_note?: number, added_as_contact_bad?: number, added_as_contact_good?: number, added_as_contact_high?: number, added_as_contact_horrible?: number, added_as_contact_neutral?: number, calendar_event_created?: number, chat_messages_alliance?: number, chat_messages_constellation?: number, chat_messages_corporation?: number, chat_messages_fleet?: number, chat_messages_region?: number, chat_messages_solarsystem?: number, chat_messages_warfaction?: number, chat_total_message_length?: number, direct_trades?: number, fleet_broadcasts?: number, fleet_joins?: number, mails_received?: number, mails_sent?: number}, travel?: {acceleration_gate_activations?: number, align_to?: number, distance_warped_high_sec?: number, distance_warped_low_sec?: number, distance_warped_null_sec?: number, distance_warped_wormhole?: number, docks_high_sec?: number, docks_low_sec?: number, docks_null_sec?: number, jumps_stargate_high_sec?: number, jumps_stargate_low_sec?: number, jumps_stargate_null_sec?: number, jumps_wormhole?: number, warps_high_sec?: number, warps_low_sec?: number, warps_null_sec?: number, warps_to_bookmark?: number, warps_to_celestial?: number, warps_to_fleet_member?: number, warps_to_scan_result?: number, warps_wormhole?: number}, year: number}>>;
      })
    );
  }
  /**
   * Yearly aggregate stats
   *
   * Returns aggregate yearly stats for a character
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/stats/`
   *
   * Alternate route: `/v2/characters/{character_id}/stats/`
   *
   * ---
   * This route is cached for up to 86400 seconds
   * @param params The `CharacterService.GetCharactersCharacterIdStatsParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Character stats
   */
  getCharactersCharacterIdStats(params: CharacterService.GetCharactersCharacterIdStatsParams): __Observable<Array<{character?: {days_of_activity?: number, minutes?: number, sessions_started?: number}, combat?: {cap_drainedby_npc?: number, cap_drainedby_pc?: number, cap_draining_pc?: number, criminal_flag_set?: number, damage_from_np_cs_amount?: number, damage_from_np_cs_num_shots?: number, damage_from_players_bomb_amount?: number, damage_from_players_bomb_num_shots?: number, damage_from_players_combat_drone_amount?: number, damage_from_players_combat_drone_num_shots?: number, damage_from_players_energy_amount?: number, damage_from_players_energy_num_shots?: number, damage_from_players_fighter_bomber_amount?: number, damage_from_players_fighter_bomber_num_shots?: number, damage_from_players_fighter_drone_amount?: number, damage_from_players_fighter_drone_num_shots?: number, damage_from_players_hybrid_amount?: number, damage_from_players_hybrid_num_shots?: number, damage_from_players_missile_amount?: number, damage_from_players_missile_num_shots?: number, damage_from_players_projectile_amount?: number, damage_from_players_projectile_num_shots?: number, damage_from_players_smart_bomb_amount?: number, damage_from_players_smart_bomb_num_shots?: number, damage_from_players_super_amount?: number, damage_from_players_super_num_shots?: number, damage_from_structures_total_amount?: number, damage_from_structures_total_num_shots?: number, damage_to_players_bomb_amount?: number, damage_to_players_bomb_num_shots?: number, damage_to_players_combat_drone_amount?: number, damage_to_players_combat_drone_num_shots?: number, damage_to_players_energy_amount?: number, damage_to_players_energy_num_shots?: number, damage_to_players_fighter_bomber_amount?: number, damage_to_players_fighter_bomber_num_shots?: number, damage_to_players_fighter_drone_amount?: number, damage_to_players_fighter_drone_num_shots?: number, damage_to_players_hybrid_amount?: number, damage_to_players_hybrid_num_shots?: number, damage_to_players_missile_amount?: number, damage_to_players_missile_num_shots?: number, damage_to_players_projectile_amount?: number, damage_to_players_projectile_num_shots?: number, damage_to_players_smart_bomb_amount?: number, damage_to_players_smart_bomb_num_shots?: number, damage_to_players_super_amount?: number, damage_to_players_super_num_shots?: number, damage_to_structures_total_amount?: number, damage_to_structures_total_num_shots?: number, deaths_high_sec?: number, deaths_low_sec?: number, deaths_null_sec?: number, deaths_pod_high_sec?: number, deaths_pod_low_sec?: number, deaths_pod_null_sec?: number, deaths_pod_wormhole?: number, deaths_wormhole?: number, drone_engage?: number, dscans?: number, duel_requested?: number, engagement_register?: number, kills_assists?: number, kills_high_sec?: number, kills_low_sec?: number, kills_null_sec?: number, kills_pod_high_sec?: number, kills_pod_low_sec?: number, kills_pod_null_sec?: number, kills_pod_wormhole?: number, kills_wormhole?: number, npc_flag_set?: number, probe_scans?: number, pvp_flag_set?: number, repair_armor_by_remote_amount?: number, repair_armor_remote_amount?: number, repair_armor_self_amount?: number, repair_capacitor_by_remote_amount?: number, repair_capacitor_remote_amount?: number, repair_capacitor_self_amount?: number, repair_hull_by_remote_amount?: number, repair_hull_remote_amount?: number, repair_hull_self_amount?: number, repair_shield_by_remote_amount?: number, repair_shield_remote_amount?: number, repair_shield_self_amount?: number, self_destructs?: number, warp_scramble_pc?: number, warp_scrambledby_npc?: number, warp_scrambledby_pc?: number, weapon_flag_set?: number, webifiedby_npc?: number, webifiedby_pc?: number, webifying_pc?: number}, industry?: {hacking_successes?: number, jobs_cancelled?: number, jobs_completed_copy_blueprint?: number, jobs_completed_invention?: number, jobs_completed_manufacture?: number, jobs_completed_manufacture_asteroid?: number, jobs_completed_manufacture_asteroid_quantity?: number, jobs_completed_manufacture_charge?: number, jobs_completed_manufacture_charge_quantity?: number, jobs_completed_manufacture_commodity?: number, jobs_completed_manufacture_commodity_quantity?: number, jobs_completed_manufacture_deployable?: number, jobs_completed_manufacture_deployable_quantity?: number, jobs_completed_manufacture_drone?: number, jobs_completed_manufacture_drone_quantity?: number, jobs_completed_manufacture_implant?: number, jobs_completed_manufacture_implant_quantity?: number, jobs_completed_manufacture_module?: number, jobs_completed_manufacture_module_quantity?: number, jobs_completed_manufacture_other?: number, jobs_completed_manufacture_other_quantity?: number, jobs_completed_manufacture_ship?: number, jobs_completed_manufacture_ship_quantity?: number, jobs_completed_manufacture_structure?: number, jobs_completed_manufacture_structure_quantity?: number, jobs_completed_manufacture_subsystem?: number, jobs_completed_manufacture_subsystem_quantity?: number, jobs_completed_material_productivity?: number, jobs_completed_time_productivity?: number, jobs_started_copy_blueprint?: number, jobs_started_invention?: number, jobs_started_manufacture?: number, jobs_started_material_productivity?: number, jobs_started_time_productivity?: number, reprocess_item?: number, reprocess_item_quantity?: number}, inventory?: {abandon_loot_quantity?: number, trash_item_quantity?: number}, isk?: {in?: number, out?: number}, market?: {accept_contracts_courier?: number, accept_contracts_item_exchange?: number, buy_orders_placed?: number, cancel_market_order?: number, create_contracts_auction?: number, create_contracts_courier?: number, create_contracts_item_exchange?: number, deliver_courier_contract?: number, isk_gained?: number, isk_spent?: number, modify_market_order?: number, search_contracts?: number, sell_orders_placed?: number}, mining?: {drone_mine?: number, ore_arkonor?: number, ore_bistot?: number, ore_crokite?: number, ore_dark_ochre?: number, ore_gneiss?: number, ore_harvestable_cloud?: number, ore_hedbergite?: number, ore_hemorphite?: number, ore_ice?: number, ore_jaspet?: number, ore_kernite?: number, ore_mercoxit?: number, ore_omber?: number, ore_plagioclase?: number, ore_pyroxeres?: number, ore_scordite?: number, ore_spodumain?: number, ore_veldspar?: number}, module?: {activations_armor_hardener?: number, activations_armor_repair_unit?: number, activations_armor_resistance_shift_hardener?: number, activations_automated_targeting_system?: number, activations_bastion?: number, activations_bomb_launcher?: number, activations_capacitor_booster?: number, activations_cargo_scanner?: number, activations_cloaking_device?: number, activations_clone_vat_bay?: number, activations_cynosural_field?: number, activations_damage_control?: number, activations_data_miners?: number, activations_drone_control_unit?: number, activations_drone_tracking_modules?: number, activations_eccm?: number, activations_ecm?: number, activations_ecm_burst?: number, activations_energy_destabilizer?: number, activations_energy_vampire?: number, activations_energy_weapon?: number, activations_festival_launcher?: number, activations_frequency_mining_laser?: number, activations_fueled_armor_repairer?: number, activations_fueled_shield_booster?: number, activations_gang_coordinator?: number, activations_gas_cloud_harvester?: number, activations_hull_repair_unit?: number, activations_hybrid_weapon?: number, activations_industrial_core?: number, activations_interdiction_sphere_launcher?: number, activations_micro_jump_drive?: number, activations_mining_laser?: number, activations_missile_launcher?: number, activations_passive_targeting_system?: number, activations_probe_launcher?: number, activations_projected_eccm?: number, activations_projectile_weapon?: number, activations_propulsion_module?: number, activations_remote_armor_repairer?: number, activations_remote_capacitor_transmitter?: number, activations_remote_ecm_burst?: number, activations_remote_hull_repairer?: number, activations_remote_sensor_booster?: number, activations_remote_sensor_damper?: number, activations_remote_shield_booster?: number, activations_remote_tracking_computer?: number, activations_salvager?: number, activations_sensor_booster?: number, activations_shield_booster?: number, activations_shield_hardener?: number, activations_ship_scanner?: number, activations_siege?: number, activations_smart_bomb?: number, activations_stasis_web?: number, activations_strip_miner?: number, activations_super_weapon?: number, activations_survey_scanner?: number, activations_target_breaker?: number, activations_target_painter?: number, activations_tracking_computer?: number, activations_tracking_disruptor?: number, activations_tractor_beam?: number, activations_triage?: number, activations_warp_disrupt_field_generator?: number, activations_warp_scrambler?: number, link_weapons?: number, overload?: number, repairs?: number}, orbital?: {strike_characters_killed?: number, strike_damage_to_players_armor_amount?: number, strike_damage_to_players_shield_amount?: number}, pve?: {dungeons_completed_agent?: number, dungeons_completed_distribution?: number, missions_succeeded?: number, missions_succeeded_epic_arc?: number}, social?: {add_contact_bad?: number, add_contact_good?: number, add_contact_high?: number, add_contact_horrible?: number, add_contact_neutral?: number, add_note?: number, added_as_contact_bad?: number, added_as_contact_good?: number, added_as_contact_high?: number, added_as_contact_horrible?: number, added_as_contact_neutral?: number, calendar_event_created?: number, chat_messages_alliance?: number, chat_messages_constellation?: number, chat_messages_corporation?: number, chat_messages_fleet?: number, chat_messages_region?: number, chat_messages_solarsystem?: number, chat_messages_warfaction?: number, chat_total_message_length?: number, direct_trades?: number, fleet_broadcasts?: number, fleet_joins?: number, mails_received?: number, mails_sent?: number}, travel?: {acceleration_gate_activations?: number, align_to?: number, distance_warped_high_sec?: number, distance_warped_low_sec?: number, distance_warped_null_sec?: number, distance_warped_wormhole?: number, docks_high_sec?: number, docks_low_sec?: number, docks_null_sec?: number, jumps_stargate_high_sec?: number, jumps_stargate_low_sec?: number, jumps_stargate_null_sec?: number, jumps_wormhole?: number, warps_high_sec?: number, warps_low_sec?: number, warps_null_sec?: number, warps_to_bookmark?: number, warps_to_celestial?: number, warps_to_fleet_member?: number, warps_to_scan_result?: number, warps_wormhole?: number}, year: number}>> {
    return this.getCharactersCharacterIdStatsResponse(params).pipe(
      __map(_r => _r.body as Array<{character?: {days_of_activity?: number, minutes?: number, sessions_started?: number}, combat?: {cap_drainedby_npc?: number, cap_drainedby_pc?: number, cap_draining_pc?: number, criminal_flag_set?: number, damage_from_np_cs_amount?: number, damage_from_np_cs_num_shots?: number, damage_from_players_bomb_amount?: number, damage_from_players_bomb_num_shots?: number, damage_from_players_combat_drone_amount?: number, damage_from_players_combat_drone_num_shots?: number, damage_from_players_energy_amount?: number, damage_from_players_energy_num_shots?: number, damage_from_players_fighter_bomber_amount?: number, damage_from_players_fighter_bomber_num_shots?: number, damage_from_players_fighter_drone_amount?: number, damage_from_players_fighter_drone_num_shots?: number, damage_from_players_hybrid_amount?: number, damage_from_players_hybrid_num_shots?: number, damage_from_players_missile_amount?: number, damage_from_players_missile_num_shots?: number, damage_from_players_projectile_amount?: number, damage_from_players_projectile_num_shots?: number, damage_from_players_smart_bomb_amount?: number, damage_from_players_smart_bomb_num_shots?: number, damage_from_players_super_amount?: number, damage_from_players_super_num_shots?: number, damage_from_structures_total_amount?: number, damage_from_structures_total_num_shots?: number, damage_to_players_bomb_amount?: number, damage_to_players_bomb_num_shots?: number, damage_to_players_combat_drone_amount?: number, damage_to_players_combat_drone_num_shots?: number, damage_to_players_energy_amount?: number, damage_to_players_energy_num_shots?: number, damage_to_players_fighter_bomber_amount?: number, damage_to_players_fighter_bomber_num_shots?: number, damage_to_players_fighter_drone_amount?: number, damage_to_players_fighter_drone_num_shots?: number, damage_to_players_hybrid_amount?: number, damage_to_players_hybrid_num_shots?: number, damage_to_players_missile_amount?: number, damage_to_players_missile_num_shots?: number, damage_to_players_projectile_amount?: number, damage_to_players_projectile_num_shots?: number, damage_to_players_smart_bomb_amount?: number, damage_to_players_smart_bomb_num_shots?: number, damage_to_players_super_amount?: number, damage_to_players_super_num_shots?: number, damage_to_structures_total_amount?: number, damage_to_structures_total_num_shots?: number, deaths_high_sec?: number, deaths_low_sec?: number, deaths_null_sec?: number, deaths_pod_high_sec?: number, deaths_pod_low_sec?: number, deaths_pod_null_sec?: number, deaths_pod_wormhole?: number, deaths_wormhole?: number, drone_engage?: number, dscans?: number, duel_requested?: number, engagement_register?: number, kills_assists?: number, kills_high_sec?: number, kills_low_sec?: number, kills_null_sec?: number, kills_pod_high_sec?: number, kills_pod_low_sec?: number, kills_pod_null_sec?: number, kills_pod_wormhole?: number, kills_wormhole?: number, npc_flag_set?: number, probe_scans?: number, pvp_flag_set?: number, repair_armor_by_remote_amount?: number, repair_armor_remote_amount?: number, repair_armor_self_amount?: number, repair_capacitor_by_remote_amount?: number, repair_capacitor_remote_amount?: number, repair_capacitor_self_amount?: number, repair_hull_by_remote_amount?: number, repair_hull_remote_amount?: number, repair_hull_self_amount?: number, repair_shield_by_remote_amount?: number, repair_shield_remote_amount?: number, repair_shield_self_amount?: number, self_destructs?: number, warp_scramble_pc?: number, warp_scrambledby_npc?: number, warp_scrambledby_pc?: number, weapon_flag_set?: number, webifiedby_npc?: number, webifiedby_pc?: number, webifying_pc?: number}, industry?: {hacking_successes?: number, jobs_cancelled?: number, jobs_completed_copy_blueprint?: number, jobs_completed_invention?: number, jobs_completed_manufacture?: number, jobs_completed_manufacture_asteroid?: number, jobs_completed_manufacture_asteroid_quantity?: number, jobs_completed_manufacture_charge?: number, jobs_completed_manufacture_charge_quantity?: number, jobs_completed_manufacture_commodity?: number, jobs_completed_manufacture_commodity_quantity?: number, jobs_completed_manufacture_deployable?: number, jobs_completed_manufacture_deployable_quantity?: number, jobs_completed_manufacture_drone?: number, jobs_completed_manufacture_drone_quantity?: number, jobs_completed_manufacture_implant?: number, jobs_completed_manufacture_implant_quantity?: number, jobs_completed_manufacture_module?: number, jobs_completed_manufacture_module_quantity?: number, jobs_completed_manufacture_other?: number, jobs_completed_manufacture_other_quantity?: number, jobs_completed_manufacture_ship?: number, jobs_completed_manufacture_ship_quantity?: number, jobs_completed_manufacture_structure?: number, jobs_completed_manufacture_structure_quantity?: number, jobs_completed_manufacture_subsystem?: number, jobs_completed_manufacture_subsystem_quantity?: number, jobs_completed_material_productivity?: number, jobs_completed_time_productivity?: number, jobs_started_copy_blueprint?: number, jobs_started_invention?: number, jobs_started_manufacture?: number, jobs_started_material_productivity?: number, jobs_started_time_productivity?: number, reprocess_item?: number, reprocess_item_quantity?: number}, inventory?: {abandon_loot_quantity?: number, trash_item_quantity?: number}, isk?: {in?: number, out?: number}, market?: {accept_contracts_courier?: number, accept_contracts_item_exchange?: number, buy_orders_placed?: number, cancel_market_order?: number, create_contracts_auction?: number, create_contracts_courier?: number, create_contracts_item_exchange?: number, deliver_courier_contract?: number, isk_gained?: number, isk_spent?: number, modify_market_order?: number, search_contracts?: number, sell_orders_placed?: number}, mining?: {drone_mine?: number, ore_arkonor?: number, ore_bistot?: number, ore_crokite?: number, ore_dark_ochre?: number, ore_gneiss?: number, ore_harvestable_cloud?: number, ore_hedbergite?: number, ore_hemorphite?: number, ore_ice?: number, ore_jaspet?: number, ore_kernite?: number, ore_mercoxit?: number, ore_omber?: number, ore_plagioclase?: number, ore_pyroxeres?: number, ore_scordite?: number, ore_spodumain?: number, ore_veldspar?: number}, module?: {activations_armor_hardener?: number, activations_armor_repair_unit?: number, activations_armor_resistance_shift_hardener?: number, activations_automated_targeting_system?: number, activations_bastion?: number, activations_bomb_launcher?: number, activations_capacitor_booster?: number, activations_cargo_scanner?: number, activations_cloaking_device?: number, activations_clone_vat_bay?: number, activations_cynosural_field?: number, activations_damage_control?: number, activations_data_miners?: number, activations_drone_control_unit?: number, activations_drone_tracking_modules?: number, activations_eccm?: number, activations_ecm?: number, activations_ecm_burst?: number, activations_energy_destabilizer?: number, activations_energy_vampire?: number, activations_energy_weapon?: number, activations_festival_launcher?: number, activations_frequency_mining_laser?: number, activations_fueled_armor_repairer?: number, activations_fueled_shield_booster?: number, activations_gang_coordinator?: number, activations_gas_cloud_harvester?: number, activations_hull_repair_unit?: number, activations_hybrid_weapon?: number, activations_industrial_core?: number, activations_interdiction_sphere_launcher?: number, activations_micro_jump_drive?: number, activations_mining_laser?: number, activations_missile_launcher?: number, activations_passive_targeting_system?: number, activations_probe_launcher?: number, activations_projected_eccm?: number, activations_projectile_weapon?: number, activations_propulsion_module?: number, activations_remote_armor_repairer?: number, activations_remote_capacitor_transmitter?: number, activations_remote_ecm_burst?: number, activations_remote_hull_repairer?: number, activations_remote_sensor_booster?: number, activations_remote_sensor_damper?: number, activations_remote_shield_booster?: number, activations_remote_tracking_computer?: number, activations_salvager?: number, activations_sensor_booster?: number, activations_shield_booster?: number, activations_shield_hardener?: number, activations_ship_scanner?: number, activations_siege?: number, activations_smart_bomb?: number, activations_stasis_web?: number, activations_strip_miner?: number, activations_super_weapon?: number, activations_survey_scanner?: number, activations_target_breaker?: number, activations_target_painter?: number, activations_tracking_computer?: number, activations_tracking_disruptor?: number, activations_tractor_beam?: number, activations_triage?: number, activations_warp_disrupt_field_generator?: number, activations_warp_scrambler?: number, link_weapons?: number, overload?: number, repairs?: number}, orbital?: {strike_characters_killed?: number, strike_damage_to_players_armor_amount?: number, strike_damage_to_players_shield_amount?: number}, pve?: {dungeons_completed_agent?: number, dungeons_completed_distribution?: number, missions_succeeded?: number, missions_succeeded_epic_arc?: number}, social?: {add_contact_bad?: number, add_contact_good?: number, add_contact_high?: number, add_contact_horrible?: number, add_contact_neutral?: number, add_note?: number, added_as_contact_bad?: number, added_as_contact_good?: number, added_as_contact_high?: number, added_as_contact_horrible?: number, added_as_contact_neutral?: number, calendar_event_created?: number, chat_messages_alliance?: number, chat_messages_constellation?: number, chat_messages_corporation?: number, chat_messages_fleet?: number, chat_messages_region?: number, chat_messages_solarsystem?: number, chat_messages_warfaction?: number, chat_total_message_length?: number, direct_trades?: number, fleet_broadcasts?: number, fleet_joins?: number, mails_received?: number, mails_sent?: number}, travel?: {acceleration_gate_activations?: number, align_to?: number, distance_warped_high_sec?: number, distance_warped_low_sec?: number, distance_warped_null_sec?: number, distance_warped_wormhole?: number, docks_high_sec?: number, docks_low_sec?: number, docks_null_sec?: number, jumps_stargate_high_sec?: number, jumps_stargate_low_sec?: number, jumps_stargate_null_sec?: number, jumps_wormhole?: number, warps_high_sec?: number, warps_low_sec?: number, warps_null_sec?: number, warps_to_bookmark?: number, warps_to_celestial?: number, warps_to_fleet_member?: number, warps_to_scan_result?: number, warps_wormhole?: number}, year: number}>)
    );
  }

  /**
   * Get character corporation titles
   *
   * Returns a character's titles
   *
   * ---
   * Alternate route: `/legacy/characters/{character_id}/titles/`
   *
   * Alternate route: `/v1/characters/{character_id}/titles/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `CharacterService.GetCharactersCharacterIdTitlesParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of titles
   */
  getCharactersCharacterIdTitlesResponse(params: CharacterService.GetCharactersCharacterIdTitlesParams): __Observable<__StrictHttpResponse<Array<{name?: string, title_id?: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/titles/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{name?: string, title_id?: number}>>;
      })
    );
  }
  /**
   * Get character corporation titles
   *
   * Returns a character's titles
   *
   * ---
   * Alternate route: `/legacy/characters/{character_id}/titles/`
   *
   * Alternate route: `/v1/characters/{character_id}/titles/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `CharacterService.GetCharactersCharacterIdTitlesParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of titles
   */
  getCharactersCharacterIdTitles(params: CharacterService.GetCharactersCharacterIdTitlesParams): __Observable<Array<{name?: string, title_id?: number}>> {
    return this.getCharactersCharacterIdTitlesResponse(params).pipe(
      __map(_r => _r.body as Array<{name?: string, title_id?: number}>)
    );
  }
}

module CharacterService {

  /**
   * Parameters for postCharactersAffiliation
   */
  export interface PostCharactersAffiliationParams {

    /**
     * The character IDs to fetch affiliations for. All characters must exist, or none will be returned
     */
    characters: Array<number>;

    /**
     * The server name you would like data from
     */
    datasource?: 'tranquility' | 'singularity';
  }

  /**
   * Parameters for getCharactersCharacterId
   */
  export interface GetCharactersCharacterIdParams {

    /**
     * An EVE character ID
     */
    characterId: number;

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
   * Parameters for getCharactersCharacterIdAgentsResearch
   */
  export interface GetCharactersCharacterIdAgentsResearchParams {

    /**
     * An EVE character ID
     */
    characterId: number;

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
   * Parameters for getCharactersCharacterIdBlueprints
   */
  export interface GetCharactersCharacterIdBlueprintsParams {

    /**
     * An EVE character ID
     */
    characterId: number;

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
   * Parameters for getCharactersCharacterIdCorporationhistory
   */
  export interface GetCharactersCharacterIdCorporationhistoryParams {

    /**
     * An EVE character ID
     */
    characterId: number;

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
   * Parameters for postCharactersCharacterIdCspa
   */
  export interface PostCharactersCharacterIdCspaParams {

    /**
     * The target characters to calculate the charge for
     */
    characters: Array<number>;

    /**
     * An EVE character ID
     */
    characterId: number;

    /**
     * Access token to use if unable to set a header
     */
    token?: string;

    /**
     * The server name you would like data from
     */
    datasource?: 'tranquility' | 'singularity';
  }

  /**
   * Parameters for getCharactersCharacterIdFatigue
   */
  export interface GetCharactersCharacterIdFatigueParams {

    /**
     * An EVE character ID
     */
    characterId: number;

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
   * Parameters for getCharactersCharacterIdMedals
   */
  export interface GetCharactersCharacterIdMedalsParams {

    /**
     * An EVE character ID
     */
    characterId: number;

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
   * Parameters for getCharactersCharacterIdNotifications
   */
  export interface GetCharactersCharacterIdNotificationsParams {

    /**
     * An EVE character ID
     */
    characterId: number;

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
   * Parameters for getCharactersCharacterIdNotificationsContacts
   */
  export interface GetCharactersCharacterIdNotificationsContactsParams {

    /**
     * An EVE character ID
     */
    characterId: number;

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
   * Parameters for getCharactersCharacterIdPortrait
   */
  export interface GetCharactersCharacterIdPortraitParams {

    /**
     * An EVE character ID
     */
    characterId: number;

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
   * Parameters for getCharactersCharacterIdRoles
   */
  export interface GetCharactersCharacterIdRolesParams {

    /**
     * An EVE character ID
     */
    characterId: number;

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
   * Parameters for getCharactersCharacterIdStandings
   */
  export interface GetCharactersCharacterIdStandingsParams {

    /**
     * An EVE character ID
     */
    characterId: number;

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
   * Parameters for getCharactersCharacterIdStats
   */
  export interface GetCharactersCharacterIdStatsParams {

    /**
     * An EVE character ID
     */
    characterId: number;

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
   * Parameters for getCharactersCharacterIdTitles
   */
  export interface GetCharactersCharacterIdTitlesParams {

    /**
     * An EVE character ID
     */
    characterId: number;

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

export { CharacterService }
