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
class PlanetaryInteractionService extends __BaseService {
  static readonly getCharactersCharacterIdPlanetsPath = '/characters/{character_id}/planets/';
  static readonly getCharactersCharacterIdPlanetsPlanetIdPath = '/characters/{character_id}/planets/{planet_id}/';
  static readonly getCorporationsCorporationIdCustomsOfficesPath = '/corporations/{corporation_id}/customs_offices/';
  static readonly getUniverseSchematicsSchematicIdPath = '/universe/schematics/{schematic_id}/';

  constructor(
    config: __Configuration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * Get colonies
   *
   * Returns a list of all planetary colonies owned by a character.
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/planets/`
   *
   * Alternate route: `/legacy/characters/{character_id}/planets/`
   *
   * Alternate route: `/v1/characters/{character_id}/planets/`
   *
   * ---
   * This route is cached for up to 600 seconds
   * @param params The `PlanetaryInteractionService.GetCharactersCharacterIdPlanetsParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return List of colonies
   */
  getCharactersCharacterIdPlanetsResponse(params: PlanetaryInteractionService.GetCharactersCharacterIdPlanetsParams): __Observable<__StrictHttpResponse<Array<{last_update: string, num_pins: number, owner_id: number, planet_id: number, planet_type: 'temperate' | 'barren' | 'oceanic' | 'ice' | 'gas' | 'lava' | 'storm' | 'plasma', solar_system_id: number, upgrade_level: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/planets/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{last_update: string, num_pins: number, owner_id: number, planet_id: number, planet_type: 'temperate' | 'barren' | 'oceanic' | 'ice' | 'gas' | 'lava' | 'storm' | 'plasma', solar_system_id: number, upgrade_level: number}>>;
      })
    );
  }
  /**
   * Get colonies
   *
   * Returns a list of all planetary colonies owned by a character.
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/planets/`
   *
   * Alternate route: `/legacy/characters/{character_id}/planets/`
   *
   * Alternate route: `/v1/characters/{character_id}/planets/`
   *
   * ---
   * This route is cached for up to 600 seconds
   * @param params The `PlanetaryInteractionService.GetCharactersCharacterIdPlanetsParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return List of colonies
   */
  getCharactersCharacterIdPlanets(params: PlanetaryInteractionService.GetCharactersCharacterIdPlanetsParams): __Observable<Array<{last_update: string, num_pins: number, owner_id: number, planet_id: number, planet_type: 'temperate' | 'barren' | 'oceanic' | 'ice' | 'gas' | 'lava' | 'storm' | 'plasma', solar_system_id: number, upgrade_level: number}>> {
    return this.getCharactersCharacterIdPlanetsResponse(params).pipe(
      __map(_r => _r.body as Array<{last_update: string, num_pins: number, owner_id: number, planet_id: number, planet_type: 'temperate' | 'barren' | 'oceanic' | 'ice' | 'gas' | 'lava' | 'storm' | 'plasma', solar_system_id: number, upgrade_level: number}>)
    );
  }

  /**
   * Get colony layout
   *
   * Returns full details on the layout of a single planetary colony, including links, pins and routes. Note: Planetary information is only recalculated when the colony is viewed through the client. Information will not update until this criteria is met.
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/planets/{planet_id}/`
   *
   * Alternate route: `/v3/characters/{character_id}/planets/{planet_id}/`
   * @param params The `PlanetaryInteractionService.GetCharactersCharacterIdPlanetsPlanetIdParams` containing the following parameters:
   *
   * - `planet_id`: Planet id of the target planet
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * @return Colony layout
   */
  getCharactersCharacterIdPlanetsPlanetIdResponse(params: PlanetaryInteractionService.GetCharactersCharacterIdPlanetsPlanetIdParams): __Observable<__StrictHttpResponse<{links: Array<{destination_pin_id: number, link_level: number, source_pin_id: number}>, pins: Array<{contents?: Array<{amount: number, type_id: number}>, expiry_time?: string, extractor_details?: {cycle_time?: number, head_radius?: number, heads: Array<{head_id: number, latitude: number, longitude: number}>, product_type_id?: number, qty_per_cycle?: number}, factory_details?: {schematic_id: number}, install_time?: string, last_cycle_start?: string, latitude: number, longitude: number, pin_id: number, schematic_id?: number, type_id: number}>, routes: Array<{content_type_id: number, destination_pin_id: number, quantity: number, route_id: number, source_pin_id: number, waypoints?: Array<number>}>}>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;


    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/planets/${encodeURIComponent(params.planetId)}/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<{links: Array<{destination_pin_id: number, link_level: number, source_pin_id: number}>, pins: Array<{contents?: Array<{amount: number, type_id: number}>, expiry_time?: string, extractor_details?: {cycle_time?: number, head_radius?: number, heads: Array<{head_id: number, latitude: number, longitude: number}>, product_type_id?: number, qty_per_cycle?: number}, factory_details?: {schematic_id: number}, install_time?: string, last_cycle_start?: string, latitude: number, longitude: number, pin_id: number, schematic_id?: number, type_id: number}>, routes: Array<{content_type_id: number, destination_pin_id: number, quantity: number, route_id: number, source_pin_id: number, waypoints?: Array<number>}>}>;
      })
    );
  }
  /**
   * Get colony layout
   *
   * Returns full details on the layout of a single planetary colony, including links, pins and routes. Note: Planetary information is only recalculated when the colony is viewed through the client. Information will not update until this criteria is met.
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/planets/{planet_id}/`
   *
   * Alternate route: `/v3/characters/{character_id}/planets/{planet_id}/`
   * @param params The `PlanetaryInteractionService.GetCharactersCharacterIdPlanetsPlanetIdParams` containing the following parameters:
   *
   * - `planet_id`: Planet id of the target planet
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * @return Colony layout
   */
  getCharactersCharacterIdPlanetsPlanetId(params: PlanetaryInteractionService.GetCharactersCharacterIdPlanetsPlanetIdParams): __Observable<{links: Array<{destination_pin_id: number, link_level: number, source_pin_id: number}>, pins: Array<{contents?: Array<{amount: number, type_id: number}>, expiry_time?: string, extractor_details?: {cycle_time?: number, head_radius?: number, heads: Array<{head_id: number, latitude: number, longitude: number}>, product_type_id?: number, qty_per_cycle?: number}, factory_details?: {schematic_id: number}, install_time?: string, last_cycle_start?: string, latitude: number, longitude: number, pin_id: number, schematic_id?: number, type_id: number}>, routes: Array<{content_type_id: number, destination_pin_id: number, quantity: number, route_id: number, source_pin_id: number, waypoints?: Array<number>}>}> {
    return this.getCharactersCharacterIdPlanetsPlanetIdResponse(params).pipe(
      __map(_r => _r.body as {links: Array<{destination_pin_id: number, link_level: number, source_pin_id: number}>, pins: Array<{contents?: Array<{amount: number, type_id: number}>, expiry_time?: string, extractor_details?: {cycle_time?: number, head_radius?: number, heads: Array<{head_id: number, latitude: number, longitude: number}>, product_type_id?: number, qty_per_cycle?: number}, factory_details?: {schematic_id: number}, install_time?: string, last_cycle_start?: string, latitude: number, longitude: number, pin_id: number, schematic_id?: number, type_id: number}>, routes: Array<{content_type_id: number, destination_pin_id: number, quantity: number, route_id: number, source_pin_id: number, waypoints?: Array<number>}>})
    );
  }

  /**
   * List corporation customs offices
   *
   * List customs offices owned by a corporation
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/customs_offices/`
   *
   * Alternate route: `/legacy/corporations/{corporation_id}/customs_offices/`
   *
   * Alternate route: `/v1/corporations/{corporation_id}/customs_offices/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   *
   * ---
   * Requires one of the following EVE corporation role(s): Director
   * @param params The `PlanetaryInteractionService.GetCorporationsCorporationIdCustomsOfficesParams` containing the following parameters:
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
   * @return A list of customs offices and their settings
   */
  getCorporationsCorporationIdCustomsOfficesResponse(params: PlanetaryInteractionService.GetCorporationsCorporationIdCustomsOfficesParams): __Observable<__StrictHttpResponse<Array<{alliance_tax_rate?: number, allow_access_with_standings: boolean, allow_alliance_access: boolean, bad_standing_tax_rate?: number, corporation_tax_rate?: number, excellent_standing_tax_rate?: number, good_standing_tax_rate?: number, neutral_standing_tax_rate?: number, office_id: number, reinforce_exit_end: number, reinforce_exit_start: number, standing_level?: 'bad' | 'excellent' | 'good' | 'neutral' | 'terrible', system_id: number, terrible_standing_tax_rate?: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.page != null) __params = __params.set('page', params.page.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/corporations/${encodeURIComponent(params.corporationId)}/customs_offices/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{alliance_tax_rate?: number, allow_access_with_standings: boolean, allow_alliance_access: boolean, bad_standing_tax_rate?: number, corporation_tax_rate?: number, excellent_standing_tax_rate?: number, good_standing_tax_rate?: number, neutral_standing_tax_rate?: number, office_id: number, reinforce_exit_end: number, reinforce_exit_start: number, standing_level?: 'bad' | 'excellent' | 'good' | 'neutral' | 'terrible', system_id: number, terrible_standing_tax_rate?: number}>>;
      })
    );
  }
  /**
   * List corporation customs offices
   *
   * List customs offices owned by a corporation
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/customs_offices/`
   *
   * Alternate route: `/legacy/corporations/{corporation_id}/customs_offices/`
   *
   * Alternate route: `/v1/corporations/{corporation_id}/customs_offices/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   *
   * ---
   * Requires one of the following EVE corporation role(s): Director
   * @param params The `PlanetaryInteractionService.GetCorporationsCorporationIdCustomsOfficesParams` containing the following parameters:
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
   * @return A list of customs offices and their settings
   */
  getCorporationsCorporationIdCustomsOffices(params: PlanetaryInteractionService.GetCorporationsCorporationIdCustomsOfficesParams): __Observable<Array<{alliance_tax_rate?: number, allow_access_with_standings: boolean, allow_alliance_access: boolean, bad_standing_tax_rate?: number, corporation_tax_rate?: number, excellent_standing_tax_rate?: number, good_standing_tax_rate?: number, neutral_standing_tax_rate?: number, office_id: number, reinforce_exit_end: number, reinforce_exit_start: number, standing_level?: 'bad' | 'excellent' | 'good' | 'neutral' | 'terrible', system_id: number, terrible_standing_tax_rate?: number}>> {
    return this.getCorporationsCorporationIdCustomsOfficesResponse(params).pipe(
      __map(_r => _r.body as Array<{alliance_tax_rate?: number, allow_access_with_standings: boolean, allow_alliance_access: boolean, bad_standing_tax_rate?: number, corporation_tax_rate?: number, excellent_standing_tax_rate?: number, good_standing_tax_rate?: number, neutral_standing_tax_rate?: number, office_id: number, reinforce_exit_end: number, reinforce_exit_start: number, standing_level?: 'bad' | 'excellent' | 'good' | 'neutral' | 'terrible', system_id: number, terrible_standing_tax_rate?: number}>)
    );
  }

  /**
   * Get schematic information
   *
   * Get information on a planetary factory schematic
   *
   * ---
   * Alternate route: `/dev/universe/schematics/{schematic_id}/`
   *
   * Alternate route: `/legacy/universe/schematics/{schematic_id}/`
   *
   * Alternate route: `/v1/universe/schematics/{schematic_id}/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `PlanetaryInteractionService.GetUniverseSchematicsSchematicIdParams` containing the following parameters:
   *
   * - `schematic_id`: A PI schematic ID
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Public data about a schematic
   */
  getUniverseSchematicsSchematicIdResponse(params: PlanetaryInteractionService.GetUniverseSchematicsSchematicIdParams): __Observable<__StrictHttpResponse<{cycle_time: number, schematic_name: string}>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/universe/schematics/${encodeURIComponent(params.schematicId)}/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<{cycle_time: number, schematic_name: string}>;
      })
    );
  }
  /**
   * Get schematic information
   *
   * Get information on a planetary factory schematic
   *
   * ---
   * Alternate route: `/dev/universe/schematics/{schematic_id}/`
   *
   * Alternate route: `/legacy/universe/schematics/{schematic_id}/`
   *
   * Alternate route: `/v1/universe/schematics/{schematic_id}/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `PlanetaryInteractionService.GetUniverseSchematicsSchematicIdParams` containing the following parameters:
   *
   * - `schematic_id`: A PI schematic ID
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Public data about a schematic
   */
  getUniverseSchematicsSchematicId(params: PlanetaryInteractionService.GetUniverseSchematicsSchematicIdParams): __Observable<{cycle_time: number, schematic_name: string}> {
    return this.getUniverseSchematicsSchematicIdResponse(params).pipe(
      __map(_r => _r.body as {cycle_time: number, schematic_name: string})
    );
  }
}

module PlanetaryInteractionService {

  /**
   * Parameters for getCharactersCharacterIdPlanets
   */
  export interface GetCharactersCharacterIdPlanetsParams {

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
   * Parameters for getCharactersCharacterIdPlanetsPlanetId
   */
  export interface GetCharactersCharacterIdPlanetsPlanetIdParams {

    /**
     * Planet id of the target planet
     */
    planetId: number;

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
   * Parameters for getCorporationsCorporationIdCustomsOffices
   */
  export interface GetCorporationsCorporationIdCustomsOfficesParams {

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
   * Parameters for getUniverseSchematicsSchematicId
   */
  export interface GetUniverseSchematicsSchematicIdParams {

    /**
     * A PI schematic ID
     */
    schematicId: number;

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

export { PlanetaryInteractionService }
