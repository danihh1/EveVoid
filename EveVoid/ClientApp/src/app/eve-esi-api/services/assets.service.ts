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
class AssetsService extends __BaseService {
  static readonly getCharactersCharacterIdAssetsPath = '/characters/{character_id}/assets/';
  static readonly postCharactersCharacterIdAssetsLocationsPath = '/characters/{character_id}/assets/locations/';
  static readonly postCharactersCharacterIdAssetsNamesPath = '/characters/{character_id}/assets/names/';
  static readonly getCorporationsCorporationIdAssetsPath = '/corporations/{corporation_id}/assets/';
  static readonly postCorporationsCorporationIdAssetsLocationsPath = '/corporations/{corporation_id}/assets/locations/';
  static readonly postCorporationsCorporationIdAssetsNamesPath = '/corporations/{corporation_id}/assets/names/';

  constructor(
    config: __Configuration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * Get character assets
   *
   * Return a list of the characters assets
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/assets/`
   *
   * Alternate route: `/v5/characters/{character_id}/assets/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `AssetsService.GetCharactersCharacterIdAssetsParams` containing the following parameters:
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
   * @return A flat list of the users assets
   */
  getCharactersCharacterIdAssetsResponse(params: AssetsService.GetCharactersCharacterIdAssetsParams): __Observable<__StrictHttpResponse<Array<{is_blueprint_copy?: boolean, is_singleton: boolean, item_id: number, location_flag: 'AssetSafety' | 'AutoFit' | 'BoosterBay' | 'Cargo' | 'CorpseBay' | 'Deliveries' | 'DroneBay' | 'FighterBay' | 'FighterTube0' | 'FighterTube1' | 'FighterTube2' | 'FighterTube3' | 'FighterTube4' | 'FleetHangar' | 'FrigateEscapeBay' | 'Hangar' | 'HangarAll' | 'HiSlot0' | 'HiSlot1' | 'HiSlot2' | 'HiSlot3' | 'HiSlot4' | 'HiSlot5' | 'HiSlot6' | 'HiSlot7' | 'HiddenModifiers' | 'Implant' | 'LoSlot0' | 'LoSlot1' | 'LoSlot2' | 'LoSlot3' | 'LoSlot4' | 'LoSlot5' | 'LoSlot6' | 'LoSlot7' | 'Locked' | 'MedSlot0' | 'MedSlot1' | 'MedSlot2' | 'MedSlot3' | 'MedSlot4' | 'MedSlot5' | 'MedSlot6' | 'MedSlot7' | 'QuafeBay' | 'RigSlot0' | 'RigSlot1' | 'RigSlot2' | 'RigSlot3' | 'RigSlot4' | 'RigSlot5' | 'RigSlot6' | 'RigSlot7' | 'ShipHangar' | 'Skill' | 'SpecializedAmmoHold' | 'SpecializedCommandCenterHold' | 'SpecializedFuelBay' | 'SpecializedGasHold' | 'SpecializedIndustrialShipHold' | 'SpecializedLargeShipHold' | 'SpecializedMaterialBay' | 'SpecializedMediumShipHold' | 'SpecializedMineralHold' | 'SpecializedOreHold' | 'SpecializedPlanetaryCommoditiesHold' | 'SpecializedSalvageHold' | 'SpecializedShipHold' | 'SpecializedSmallShipHold' | 'SubSystemBay' | 'SubSystemSlot0' | 'SubSystemSlot1' | 'SubSystemSlot2' | 'SubSystemSlot3' | 'SubSystemSlot4' | 'SubSystemSlot5' | 'SubSystemSlot6' | 'SubSystemSlot7' | 'Unlocked' | 'Wardrobe', location_id: number, location_type: 'station' | 'solar_system' | 'item' | 'other', quantity: number, type_id: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.page != null) __params = __params.set('page', params.page.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/assets/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{is_blueprint_copy?: boolean, is_singleton: boolean, item_id: number, location_flag: 'AssetSafety' | 'AutoFit' | 'BoosterBay' | 'Cargo' | 'CorpseBay' | 'Deliveries' | 'DroneBay' | 'FighterBay' | 'FighterTube0' | 'FighterTube1' | 'FighterTube2' | 'FighterTube3' | 'FighterTube4' | 'FleetHangar' | 'FrigateEscapeBay' | 'Hangar' | 'HangarAll' | 'HiSlot0' | 'HiSlot1' | 'HiSlot2' | 'HiSlot3' | 'HiSlot4' | 'HiSlot5' | 'HiSlot6' | 'HiSlot7' | 'HiddenModifiers' | 'Implant' | 'LoSlot0' | 'LoSlot1' | 'LoSlot2' | 'LoSlot3' | 'LoSlot4' | 'LoSlot5' | 'LoSlot6' | 'LoSlot7' | 'Locked' | 'MedSlot0' | 'MedSlot1' | 'MedSlot2' | 'MedSlot3' | 'MedSlot4' | 'MedSlot5' | 'MedSlot6' | 'MedSlot7' | 'QuafeBay' | 'RigSlot0' | 'RigSlot1' | 'RigSlot2' | 'RigSlot3' | 'RigSlot4' | 'RigSlot5' | 'RigSlot6' | 'RigSlot7' | 'ShipHangar' | 'Skill' | 'SpecializedAmmoHold' | 'SpecializedCommandCenterHold' | 'SpecializedFuelBay' | 'SpecializedGasHold' | 'SpecializedIndustrialShipHold' | 'SpecializedLargeShipHold' | 'SpecializedMaterialBay' | 'SpecializedMediumShipHold' | 'SpecializedMineralHold' | 'SpecializedOreHold' | 'SpecializedPlanetaryCommoditiesHold' | 'SpecializedSalvageHold' | 'SpecializedShipHold' | 'SpecializedSmallShipHold' | 'SubSystemBay' | 'SubSystemSlot0' | 'SubSystemSlot1' | 'SubSystemSlot2' | 'SubSystemSlot3' | 'SubSystemSlot4' | 'SubSystemSlot5' | 'SubSystemSlot6' | 'SubSystemSlot7' | 'Unlocked' | 'Wardrobe', location_id: number, location_type: 'station' | 'solar_system' | 'item' | 'other', quantity: number, type_id: number}>>;
      })
    );
  }
  /**
   * Get character assets
   *
   * Return a list of the characters assets
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/assets/`
   *
   * Alternate route: `/v5/characters/{character_id}/assets/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `AssetsService.GetCharactersCharacterIdAssetsParams` containing the following parameters:
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
   * @return A flat list of the users assets
   */
  getCharactersCharacterIdAssets(params: AssetsService.GetCharactersCharacterIdAssetsParams): __Observable<Array<{is_blueprint_copy?: boolean, is_singleton: boolean, item_id: number, location_flag: 'AssetSafety' | 'AutoFit' | 'BoosterBay' | 'Cargo' | 'CorpseBay' | 'Deliveries' | 'DroneBay' | 'FighterBay' | 'FighterTube0' | 'FighterTube1' | 'FighterTube2' | 'FighterTube3' | 'FighterTube4' | 'FleetHangar' | 'FrigateEscapeBay' | 'Hangar' | 'HangarAll' | 'HiSlot0' | 'HiSlot1' | 'HiSlot2' | 'HiSlot3' | 'HiSlot4' | 'HiSlot5' | 'HiSlot6' | 'HiSlot7' | 'HiddenModifiers' | 'Implant' | 'LoSlot0' | 'LoSlot1' | 'LoSlot2' | 'LoSlot3' | 'LoSlot4' | 'LoSlot5' | 'LoSlot6' | 'LoSlot7' | 'Locked' | 'MedSlot0' | 'MedSlot1' | 'MedSlot2' | 'MedSlot3' | 'MedSlot4' | 'MedSlot5' | 'MedSlot6' | 'MedSlot7' | 'QuafeBay' | 'RigSlot0' | 'RigSlot1' | 'RigSlot2' | 'RigSlot3' | 'RigSlot4' | 'RigSlot5' | 'RigSlot6' | 'RigSlot7' | 'ShipHangar' | 'Skill' | 'SpecializedAmmoHold' | 'SpecializedCommandCenterHold' | 'SpecializedFuelBay' | 'SpecializedGasHold' | 'SpecializedIndustrialShipHold' | 'SpecializedLargeShipHold' | 'SpecializedMaterialBay' | 'SpecializedMediumShipHold' | 'SpecializedMineralHold' | 'SpecializedOreHold' | 'SpecializedPlanetaryCommoditiesHold' | 'SpecializedSalvageHold' | 'SpecializedShipHold' | 'SpecializedSmallShipHold' | 'SubSystemBay' | 'SubSystemSlot0' | 'SubSystemSlot1' | 'SubSystemSlot2' | 'SubSystemSlot3' | 'SubSystemSlot4' | 'SubSystemSlot5' | 'SubSystemSlot6' | 'SubSystemSlot7' | 'Unlocked' | 'Wardrobe', location_id: number, location_type: 'station' | 'solar_system' | 'item' | 'other', quantity: number, type_id: number}>> {
    return this.getCharactersCharacterIdAssetsResponse(params).pipe(
      __map(_r => _r.body as Array<{is_blueprint_copy?: boolean, is_singleton: boolean, item_id: number, location_flag: 'AssetSafety' | 'AutoFit' | 'BoosterBay' | 'Cargo' | 'CorpseBay' | 'Deliveries' | 'DroneBay' | 'FighterBay' | 'FighterTube0' | 'FighterTube1' | 'FighterTube2' | 'FighterTube3' | 'FighterTube4' | 'FleetHangar' | 'FrigateEscapeBay' | 'Hangar' | 'HangarAll' | 'HiSlot0' | 'HiSlot1' | 'HiSlot2' | 'HiSlot3' | 'HiSlot4' | 'HiSlot5' | 'HiSlot6' | 'HiSlot7' | 'HiddenModifiers' | 'Implant' | 'LoSlot0' | 'LoSlot1' | 'LoSlot2' | 'LoSlot3' | 'LoSlot4' | 'LoSlot5' | 'LoSlot6' | 'LoSlot7' | 'Locked' | 'MedSlot0' | 'MedSlot1' | 'MedSlot2' | 'MedSlot3' | 'MedSlot4' | 'MedSlot5' | 'MedSlot6' | 'MedSlot7' | 'QuafeBay' | 'RigSlot0' | 'RigSlot1' | 'RigSlot2' | 'RigSlot3' | 'RigSlot4' | 'RigSlot5' | 'RigSlot6' | 'RigSlot7' | 'ShipHangar' | 'Skill' | 'SpecializedAmmoHold' | 'SpecializedCommandCenterHold' | 'SpecializedFuelBay' | 'SpecializedGasHold' | 'SpecializedIndustrialShipHold' | 'SpecializedLargeShipHold' | 'SpecializedMaterialBay' | 'SpecializedMediumShipHold' | 'SpecializedMineralHold' | 'SpecializedOreHold' | 'SpecializedPlanetaryCommoditiesHold' | 'SpecializedSalvageHold' | 'SpecializedShipHold' | 'SpecializedSmallShipHold' | 'SubSystemBay' | 'SubSystemSlot0' | 'SubSystemSlot1' | 'SubSystemSlot2' | 'SubSystemSlot3' | 'SubSystemSlot4' | 'SubSystemSlot5' | 'SubSystemSlot6' | 'SubSystemSlot7' | 'Unlocked' | 'Wardrobe', location_id: number, location_type: 'station' | 'solar_system' | 'item' | 'other', quantity: number, type_id: number}>)
    );
  }

  /**
   * Get character asset locations
   *
   * Return locations for a set of item ids, which you can get from character assets endpoint. Coordinates for items in hangars or stations are set to (0,0,0)
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/assets/locations/`
   *
   * Alternate route: `/v2/characters/{character_id}/assets/locations/`
   * @param params The `AssetsService.PostCharactersCharacterIdAssetsLocationsParams` containing the following parameters:
   *
   * - `item_ids`: A list of item ids
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * @return List of asset locations
   */
  postCharactersCharacterIdAssetsLocationsResponse(params: AssetsService.PostCharactersCharacterIdAssetsLocationsParams): __Observable<__StrictHttpResponse<Array<{item_id: number, position: {x: number, y: number, z: number}}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    __body = params.itemIds;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    let req = new HttpRequest<any>(
      'POST',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/assets/locations/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{item_id: number, position: {x: number, y: number, z: number}}>>;
      })
    );
  }
  /**
   * Get character asset locations
   *
   * Return locations for a set of item ids, which you can get from character assets endpoint. Coordinates for items in hangars or stations are set to (0,0,0)
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/assets/locations/`
   *
   * Alternate route: `/v2/characters/{character_id}/assets/locations/`
   * @param params The `AssetsService.PostCharactersCharacterIdAssetsLocationsParams` containing the following parameters:
   *
   * - `item_ids`: A list of item ids
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * @return List of asset locations
   */
  postCharactersCharacterIdAssetsLocations(params: AssetsService.PostCharactersCharacterIdAssetsLocationsParams): __Observable<Array<{item_id: number, position: {x: number, y: number, z: number}}>> {
    return this.postCharactersCharacterIdAssetsLocationsResponse(params).pipe(
      __map(_r => _r.body as Array<{item_id: number, position: {x: number, y: number, z: number}}>)
    );
  }

  /**
   * Get character asset names
   *
   * Return names for a set of item ids, which you can get from character assets endpoint. Typically used for items that can customize names, like containers or ships.
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/assets/names/`
   *
   * Alternate route: `/legacy/characters/{character_id}/assets/names/`
   *
   * Alternate route: `/v1/characters/{character_id}/assets/names/`
   * @param params The `AssetsService.PostCharactersCharacterIdAssetsNamesParams` containing the following parameters:
   *
   * - `item_ids`: A list of item ids
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * @return List of asset names
   */
  postCharactersCharacterIdAssetsNamesResponse(params: AssetsService.PostCharactersCharacterIdAssetsNamesParams): __Observable<__StrictHttpResponse<Array<{item_id: number, name: string}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    __body = params.itemIds;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    let req = new HttpRequest<any>(
      'POST',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/assets/names/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{item_id: number, name: string}>>;
      })
    );
  }
  /**
   * Get character asset names
   *
   * Return names for a set of item ids, which you can get from character assets endpoint. Typically used for items that can customize names, like containers or ships.
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/assets/names/`
   *
   * Alternate route: `/legacy/characters/{character_id}/assets/names/`
   *
   * Alternate route: `/v1/characters/{character_id}/assets/names/`
   * @param params The `AssetsService.PostCharactersCharacterIdAssetsNamesParams` containing the following parameters:
   *
   * - `item_ids`: A list of item ids
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * @return List of asset names
   */
  postCharactersCharacterIdAssetsNames(params: AssetsService.PostCharactersCharacterIdAssetsNamesParams): __Observable<Array<{item_id: number, name: string}>> {
    return this.postCharactersCharacterIdAssetsNamesResponse(params).pipe(
      __map(_r => _r.body as Array<{item_id: number, name: string}>)
    );
  }

  /**
   * Get corporation assets
   *
   * Return a list of the corporation assets
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/assets/`
   *
   * Alternate route: `/v5/corporations/{corporation_id}/assets/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   *
   * ---
   * Requires one of the following EVE corporation role(s): Director
   * @param params The `AssetsService.GetCorporationsCorporationIdAssetsParams` containing the following parameters:
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
   * @return A list of assets
   */
  getCorporationsCorporationIdAssetsResponse(params: AssetsService.GetCorporationsCorporationIdAssetsParams): __Observable<__StrictHttpResponse<Array<{is_blueprint_copy?: boolean, is_singleton: boolean, item_id: number, location_flag: 'AssetSafety' | 'AutoFit' | 'Bonus' | 'Booster' | 'BoosterBay' | 'Capsule' | 'Cargo' | 'CorpDeliveries' | 'CorpSAG1' | 'CorpSAG2' | 'CorpSAG3' | 'CorpSAG4' | 'CorpSAG5' | 'CorpSAG6' | 'CorpSAG7' | 'CrateLoot' | 'Deliveries' | 'DroneBay' | 'DustBattle' | 'DustDatabank' | 'FighterBay' | 'FighterTube0' | 'FighterTube1' | 'FighterTube2' | 'FighterTube3' | 'FighterTube4' | 'FleetHangar' | 'FrigateEscapeBay' | 'Hangar' | 'HangarAll' | 'HiSlot0' | 'HiSlot1' | 'HiSlot2' | 'HiSlot3' | 'HiSlot4' | 'HiSlot5' | 'HiSlot6' | 'HiSlot7' | 'HiddenModifiers' | 'Implant' | 'Impounded' | 'JunkyardReprocessed' | 'JunkyardTrashed' | 'LoSlot0' | 'LoSlot1' | 'LoSlot2' | 'LoSlot3' | 'LoSlot4' | 'LoSlot5' | 'LoSlot6' | 'LoSlot7' | 'Locked' | 'MedSlot0' | 'MedSlot1' | 'MedSlot2' | 'MedSlot3' | 'MedSlot4' | 'MedSlot5' | 'MedSlot6' | 'MedSlot7' | 'OfficeFolder' | 'Pilot' | 'PlanetSurface' | 'QuafeBay' | 'Reward' | 'RigSlot0' | 'RigSlot1' | 'RigSlot2' | 'RigSlot3' | 'RigSlot4' | 'RigSlot5' | 'RigSlot6' | 'RigSlot7' | 'SecondaryStorage' | 'ServiceSlot0' | 'ServiceSlot1' | 'ServiceSlot2' | 'ServiceSlot3' | 'ServiceSlot4' | 'ServiceSlot5' | 'ServiceSlot6' | 'ServiceSlot7' | 'ShipHangar' | 'ShipOffline' | 'Skill' | 'SkillInTraining' | 'SpecializedAmmoHold' | 'SpecializedCommandCenterHold' | 'SpecializedFuelBay' | 'SpecializedGasHold' | 'SpecializedIndustrialShipHold' | 'SpecializedLargeShipHold' | 'SpecializedMaterialBay' | 'SpecializedMediumShipHold' | 'SpecializedMineralHold' | 'SpecializedOreHold' | 'SpecializedPlanetaryCommoditiesHold' | 'SpecializedSalvageHold' | 'SpecializedShipHold' | 'SpecializedSmallShipHold' | 'StructureActive' | 'StructureFuel' | 'StructureInactive' | 'StructureOffline' | 'SubSystemBay' | 'SubSystemSlot0' | 'SubSystemSlot1' | 'SubSystemSlot2' | 'SubSystemSlot3' | 'SubSystemSlot4' | 'SubSystemSlot5' | 'SubSystemSlot6' | 'SubSystemSlot7' | 'Unlocked' | 'Wallet' | 'Wardrobe', location_id: number, location_type: 'station' | 'solar_system' | 'item' | 'other', quantity: number, type_id: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.page != null) __params = __params.set('page', params.page.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/corporations/${encodeURIComponent(params.corporationId)}/assets/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{is_blueprint_copy?: boolean, is_singleton: boolean, item_id: number, location_flag: 'AssetSafety' | 'AutoFit' | 'Bonus' | 'Booster' | 'BoosterBay' | 'Capsule' | 'Cargo' | 'CorpDeliveries' | 'CorpSAG1' | 'CorpSAG2' | 'CorpSAG3' | 'CorpSAG4' | 'CorpSAG5' | 'CorpSAG6' | 'CorpSAG7' | 'CrateLoot' | 'Deliveries' | 'DroneBay' | 'DustBattle' | 'DustDatabank' | 'FighterBay' | 'FighterTube0' | 'FighterTube1' | 'FighterTube2' | 'FighterTube3' | 'FighterTube4' | 'FleetHangar' | 'FrigateEscapeBay' | 'Hangar' | 'HangarAll' | 'HiSlot0' | 'HiSlot1' | 'HiSlot2' | 'HiSlot3' | 'HiSlot4' | 'HiSlot5' | 'HiSlot6' | 'HiSlot7' | 'HiddenModifiers' | 'Implant' | 'Impounded' | 'JunkyardReprocessed' | 'JunkyardTrashed' | 'LoSlot0' | 'LoSlot1' | 'LoSlot2' | 'LoSlot3' | 'LoSlot4' | 'LoSlot5' | 'LoSlot6' | 'LoSlot7' | 'Locked' | 'MedSlot0' | 'MedSlot1' | 'MedSlot2' | 'MedSlot3' | 'MedSlot4' | 'MedSlot5' | 'MedSlot6' | 'MedSlot7' | 'OfficeFolder' | 'Pilot' | 'PlanetSurface' | 'QuafeBay' | 'Reward' | 'RigSlot0' | 'RigSlot1' | 'RigSlot2' | 'RigSlot3' | 'RigSlot4' | 'RigSlot5' | 'RigSlot6' | 'RigSlot7' | 'SecondaryStorage' | 'ServiceSlot0' | 'ServiceSlot1' | 'ServiceSlot2' | 'ServiceSlot3' | 'ServiceSlot4' | 'ServiceSlot5' | 'ServiceSlot6' | 'ServiceSlot7' | 'ShipHangar' | 'ShipOffline' | 'Skill' | 'SkillInTraining' | 'SpecializedAmmoHold' | 'SpecializedCommandCenterHold' | 'SpecializedFuelBay' | 'SpecializedGasHold' | 'SpecializedIndustrialShipHold' | 'SpecializedLargeShipHold' | 'SpecializedMaterialBay' | 'SpecializedMediumShipHold' | 'SpecializedMineralHold' | 'SpecializedOreHold' | 'SpecializedPlanetaryCommoditiesHold' | 'SpecializedSalvageHold' | 'SpecializedShipHold' | 'SpecializedSmallShipHold' | 'StructureActive' | 'StructureFuel' | 'StructureInactive' | 'StructureOffline' | 'SubSystemBay' | 'SubSystemSlot0' | 'SubSystemSlot1' | 'SubSystemSlot2' | 'SubSystemSlot3' | 'SubSystemSlot4' | 'SubSystemSlot5' | 'SubSystemSlot6' | 'SubSystemSlot7' | 'Unlocked' | 'Wallet' | 'Wardrobe', location_id: number, location_type: 'station' | 'solar_system' | 'item' | 'other', quantity: number, type_id: number}>>;
      })
    );
  }
  /**
   * Get corporation assets
   *
   * Return a list of the corporation assets
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/assets/`
   *
   * Alternate route: `/v5/corporations/{corporation_id}/assets/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   *
   * ---
   * Requires one of the following EVE corporation role(s): Director
   * @param params The `AssetsService.GetCorporationsCorporationIdAssetsParams` containing the following parameters:
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
   * @return A list of assets
   */
  getCorporationsCorporationIdAssets(params: AssetsService.GetCorporationsCorporationIdAssetsParams): __Observable<Array<{is_blueprint_copy?: boolean, is_singleton: boolean, item_id: number, location_flag: 'AssetSafety' | 'AutoFit' | 'Bonus' | 'Booster' | 'BoosterBay' | 'Capsule' | 'Cargo' | 'CorpDeliveries' | 'CorpSAG1' | 'CorpSAG2' | 'CorpSAG3' | 'CorpSAG4' | 'CorpSAG5' | 'CorpSAG6' | 'CorpSAG7' | 'CrateLoot' | 'Deliveries' | 'DroneBay' | 'DustBattle' | 'DustDatabank' | 'FighterBay' | 'FighterTube0' | 'FighterTube1' | 'FighterTube2' | 'FighterTube3' | 'FighterTube4' | 'FleetHangar' | 'FrigateEscapeBay' | 'Hangar' | 'HangarAll' | 'HiSlot0' | 'HiSlot1' | 'HiSlot2' | 'HiSlot3' | 'HiSlot4' | 'HiSlot5' | 'HiSlot6' | 'HiSlot7' | 'HiddenModifiers' | 'Implant' | 'Impounded' | 'JunkyardReprocessed' | 'JunkyardTrashed' | 'LoSlot0' | 'LoSlot1' | 'LoSlot2' | 'LoSlot3' | 'LoSlot4' | 'LoSlot5' | 'LoSlot6' | 'LoSlot7' | 'Locked' | 'MedSlot0' | 'MedSlot1' | 'MedSlot2' | 'MedSlot3' | 'MedSlot4' | 'MedSlot5' | 'MedSlot6' | 'MedSlot7' | 'OfficeFolder' | 'Pilot' | 'PlanetSurface' | 'QuafeBay' | 'Reward' | 'RigSlot0' | 'RigSlot1' | 'RigSlot2' | 'RigSlot3' | 'RigSlot4' | 'RigSlot5' | 'RigSlot6' | 'RigSlot7' | 'SecondaryStorage' | 'ServiceSlot0' | 'ServiceSlot1' | 'ServiceSlot2' | 'ServiceSlot3' | 'ServiceSlot4' | 'ServiceSlot5' | 'ServiceSlot6' | 'ServiceSlot7' | 'ShipHangar' | 'ShipOffline' | 'Skill' | 'SkillInTraining' | 'SpecializedAmmoHold' | 'SpecializedCommandCenterHold' | 'SpecializedFuelBay' | 'SpecializedGasHold' | 'SpecializedIndustrialShipHold' | 'SpecializedLargeShipHold' | 'SpecializedMaterialBay' | 'SpecializedMediumShipHold' | 'SpecializedMineralHold' | 'SpecializedOreHold' | 'SpecializedPlanetaryCommoditiesHold' | 'SpecializedSalvageHold' | 'SpecializedShipHold' | 'SpecializedSmallShipHold' | 'StructureActive' | 'StructureFuel' | 'StructureInactive' | 'StructureOffline' | 'SubSystemBay' | 'SubSystemSlot0' | 'SubSystemSlot1' | 'SubSystemSlot2' | 'SubSystemSlot3' | 'SubSystemSlot4' | 'SubSystemSlot5' | 'SubSystemSlot6' | 'SubSystemSlot7' | 'Unlocked' | 'Wallet' | 'Wardrobe', location_id: number, location_type: 'station' | 'solar_system' | 'item' | 'other', quantity: number, type_id: number}>> {
    return this.getCorporationsCorporationIdAssetsResponse(params).pipe(
      __map(_r => _r.body as Array<{is_blueprint_copy?: boolean, is_singleton: boolean, item_id: number, location_flag: 'AssetSafety' | 'AutoFit' | 'Bonus' | 'Booster' | 'BoosterBay' | 'Capsule' | 'Cargo' | 'CorpDeliveries' | 'CorpSAG1' | 'CorpSAG2' | 'CorpSAG3' | 'CorpSAG4' | 'CorpSAG5' | 'CorpSAG6' | 'CorpSAG7' | 'CrateLoot' | 'Deliveries' | 'DroneBay' | 'DustBattle' | 'DustDatabank' | 'FighterBay' | 'FighterTube0' | 'FighterTube1' | 'FighterTube2' | 'FighterTube3' | 'FighterTube4' | 'FleetHangar' | 'FrigateEscapeBay' | 'Hangar' | 'HangarAll' | 'HiSlot0' | 'HiSlot1' | 'HiSlot2' | 'HiSlot3' | 'HiSlot4' | 'HiSlot5' | 'HiSlot6' | 'HiSlot7' | 'HiddenModifiers' | 'Implant' | 'Impounded' | 'JunkyardReprocessed' | 'JunkyardTrashed' | 'LoSlot0' | 'LoSlot1' | 'LoSlot2' | 'LoSlot3' | 'LoSlot4' | 'LoSlot5' | 'LoSlot6' | 'LoSlot7' | 'Locked' | 'MedSlot0' | 'MedSlot1' | 'MedSlot2' | 'MedSlot3' | 'MedSlot4' | 'MedSlot5' | 'MedSlot6' | 'MedSlot7' | 'OfficeFolder' | 'Pilot' | 'PlanetSurface' | 'QuafeBay' | 'Reward' | 'RigSlot0' | 'RigSlot1' | 'RigSlot2' | 'RigSlot3' | 'RigSlot4' | 'RigSlot5' | 'RigSlot6' | 'RigSlot7' | 'SecondaryStorage' | 'ServiceSlot0' | 'ServiceSlot1' | 'ServiceSlot2' | 'ServiceSlot3' | 'ServiceSlot4' | 'ServiceSlot5' | 'ServiceSlot6' | 'ServiceSlot7' | 'ShipHangar' | 'ShipOffline' | 'Skill' | 'SkillInTraining' | 'SpecializedAmmoHold' | 'SpecializedCommandCenterHold' | 'SpecializedFuelBay' | 'SpecializedGasHold' | 'SpecializedIndustrialShipHold' | 'SpecializedLargeShipHold' | 'SpecializedMaterialBay' | 'SpecializedMediumShipHold' | 'SpecializedMineralHold' | 'SpecializedOreHold' | 'SpecializedPlanetaryCommoditiesHold' | 'SpecializedSalvageHold' | 'SpecializedShipHold' | 'SpecializedSmallShipHold' | 'StructureActive' | 'StructureFuel' | 'StructureInactive' | 'StructureOffline' | 'SubSystemBay' | 'SubSystemSlot0' | 'SubSystemSlot1' | 'SubSystemSlot2' | 'SubSystemSlot3' | 'SubSystemSlot4' | 'SubSystemSlot5' | 'SubSystemSlot6' | 'SubSystemSlot7' | 'Unlocked' | 'Wallet' | 'Wardrobe', location_id: number, location_type: 'station' | 'solar_system' | 'item' | 'other', quantity: number, type_id: number}>)
    );
  }

  /**
   * Get corporation asset locations
   *
   * Return locations for a set of item ids, which you can get from corporation assets endpoint. Coordinates for items in hangars or stations are set to (0,0,0)
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/assets/locations/`
   *
   * Alternate route: `/v2/corporations/{corporation_id}/assets/locations/`
   *
   *
   * ---
   * Requires one of the following EVE corporation role(s): Director
   * @param params The `AssetsService.PostCorporationsCorporationIdAssetsLocationsParams` containing the following parameters:
   *
   * - `item_ids`: A list of item ids
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * @return List of asset locations
   */
  postCorporationsCorporationIdAssetsLocationsResponse(params: AssetsService.PostCorporationsCorporationIdAssetsLocationsParams): __Observable<__StrictHttpResponse<Array<{item_id: number, position: {x: number, y: number, z: number}}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    __body = params.itemIds;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    let req = new HttpRequest<any>(
      'POST',
      this.rootUrl + `/corporations/${encodeURIComponent(params.corporationId)}/assets/locations/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{item_id: number, position: {x: number, y: number, z: number}}>>;
      })
    );
  }
  /**
   * Get corporation asset locations
   *
   * Return locations for a set of item ids, which you can get from corporation assets endpoint. Coordinates for items in hangars or stations are set to (0,0,0)
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/assets/locations/`
   *
   * Alternate route: `/v2/corporations/{corporation_id}/assets/locations/`
   *
   *
   * ---
   * Requires one of the following EVE corporation role(s): Director
   * @param params The `AssetsService.PostCorporationsCorporationIdAssetsLocationsParams` containing the following parameters:
   *
   * - `item_ids`: A list of item ids
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * @return List of asset locations
   */
  postCorporationsCorporationIdAssetsLocations(params: AssetsService.PostCorporationsCorporationIdAssetsLocationsParams): __Observable<Array<{item_id: number, position: {x: number, y: number, z: number}}>> {
    return this.postCorporationsCorporationIdAssetsLocationsResponse(params).pipe(
      __map(_r => _r.body as Array<{item_id: number, position: {x: number, y: number, z: number}}>)
    );
  }

  /**
   * Get corporation asset names
   *
   * Return names for a set of item ids, which you can get from corporation assets endpoint. Only valid for items that can customize names, like containers or ships
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/assets/names/`
   *
   * Alternate route: `/legacy/corporations/{corporation_id}/assets/names/`
   *
   * Alternate route: `/v1/corporations/{corporation_id}/assets/names/`
   *
   *
   * ---
   * Requires one of the following EVE corporation role(s): Director
   * @param params The `AssetsService.PostCorporationsCorporationIdAssetsNamesParams` containing the following parameters:
   *
   * - `item_ids`: A list of item ids
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * @return List of asset names
   */
  postCorporationsCorporationIdAssetsNamesResponse(params: AssetsService.PostCorporationsCorporationIdAssetsNamesParams): __Observable<__StrictHttpResponse<Array<{item_id: number, name: string}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    __body = params.itemIds;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    let req = new HttpRequest<any>(
      'POST',
      this.rootUrl + `/corporations/${encodeURIComponent(params.corporationId)}/assets/names/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{item_id: number, name: string}>>;
      })
    );
  }
  /**
   * Get corporation asset names
   *
   * Return names for a set of item ids, which you can get from corporation assets endpoint. Only valid for items that can customize names, like containers or ships
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/assets/names/`
   *
   * Alternate route: `/legacy/corporations/{corporation_id}/assets/names/`
   *
   * Alternate route: `/v1/corporations/{corporation_id}/assets/names/`
   *
   *
   * ---
   * Requires one of the following EVE corporation role(s): Director
   * @param params The `AssetsService.PostCorporationsCorporationIdAssetsNamesParams` containing the following parameters:
   *
   * - `item_ids`: A list of item ids
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * @return List of asset names
   */
  postCorporationsCorporationIdAssetsNames(params: AssetsService.PostCorporationsCorporationIdAssetsNamesParams): __Observable<Array<{item_id: number, name: string}>> {
    return this.postCorporationsCorporationIdAssetsNamesResponse(params).pipe(
      __map(_r => _r.body as Array<{item_id: number, name: string}>)
    );
  }
}

module AssetsService {

  /**
   * Parameters for getCharactersCharacterIdAssets
   */
  export interface GetCharactersCharacterIdAssetsParams {

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
   * Parameters for postCharactersCharacterIdAssetsLocations
   */
  export interface PostCharactersCharacterIdAssetsLocationsParams {

    /**
     * A list of item ids
     */
    itemIds: Array<number>;

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
   * Parameters for postCharactersCharacterIdAssetsNames
   */
  export interface PostCharactersCharacterIdAssetsNamesParams {

    /**
     * A list of item ids
     */
    itemIds: Array<number>;

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
   * Parameters for getCorporationsCorporationIdAssets
   */
  export interface GetCorporationsCorporationIdAssetsParams {

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
   * Parameters for postCorporationsCorporationIdAssetsLocations
   */
  export interface PostCorporationsCorporationIdAssetsLocationsParams {

    /**
     * A list of item ids
     */
    itemIds: Array<number>;

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
  }

  /**
   * Parameters for postCorporationsCorporationIdAssetsNames
   */
  export interface PostCorporationsCorporationIdAssetsNamesParams {

    /**
     * A list of item ids
     */
    itemIds: Array<number>;

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
  }
}

export { AssetsService }
