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
class LocationService extends __BaseService {
  static readonly getCharactersCharacterIdLocationPath = '/characters/{character_id}/location/';
  static readonly getCharactersCharacterIdOnlinePath = '/characters/{character_id}/online/';
  static readonly getCharactersCharacterIdShipPath = '/characters/{character_id}/ship/';

  constructor(
    config: __Configuration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * Get character location
   *
   * Information about the characters current location. Returns the current solar system id, and also the current station or structure ID if applicable
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/location/`
   *
   * Alternate route: `/legacy/characters/{character_id}/location/`
   *
   * Alternate route: `/v1/characters/{character_id}/location/`
   *
   * Alternate route: `/v2/characters/{character_id}/location/`
   *
   * ---
   * This route is cached for up to 5 seconds
   * @param params The `LocationService.GetCharactersCharacterIdLocationParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Information about the characters current location. Returns the current solar system id, and also the current station or structure ID if applicable
   */
  getCharactersCharacterIdLocationResponse(params: LocationService.GetCharactersCharacterIdLocationParams): __Observable<__StrictHttpResponse<{solar_system_id: number, station_id?: number, structure_id?: number}>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/location/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<{solar_system_id: number, station_id?: number, structure_id?: number}>;
      })
    );
  }
  /**
   * Get character location
   *
   * Information about the characters current location. Returns the current solar system id, and also the current station or structure ID if applicable
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/location/`
   *
   * Alternate route: `/legacy/characters/{character_id}/location/`
   *
   * Alternate route: `/v1/characters/{character_id}/location/`
   *
   * Alternate route: `/v2/characters/{character_id}/location/`
   *
   * ---
   * This route is cached for up to 5 seconds
   * @param params The `LocationService.GetCharactersCharacterIdLocationParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Information about the characters current location. Returns the current solar system id, and also the current station or structure ID if applicable
   */
  getCharactersCharacterIdLocation(params: LocationService.GetCharactersCharacterIdLocationParams): __Observable<{solar_system_id: number, station_id?: number, structure_id?: number}> {
    return this.getCharactersCharacterIdLocationResponse(params).pipe(
      __map(_r => _r.body as {solar_system_id: number, station_id?: number, structure_id?: number})
    );
  }

  /**
   * Get character online
   *
   * Checks if the character is currently online
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/online/`
   *
   * Alternate route: `/v2/characters/{character_id}/online/`
   *
   * Alternate route: `/v3/characters/{character_id}/online/`
   *
   * ---
   * This route is cached for up to 60 seconds
   * @param params The `LocationService.GetCharactersCharacterIdOnlineParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Object describing the character's online status
   */
  getCharactersCharacterIdOnlineResponse(params: LocationService.GetCharactersCharacterIdOnlineParams): __Observable<__StrictHttpResponse<{last_login?: string, last_logout?: string, logins?: number, online: boolean}>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/online/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<{last_login?: string, last_logout?: string, logins?: number, online: boolean}>;
      })
    );
  }
  /**
   * Get character online
   *
   * Checks if the character is currently online
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/online/`
   *
   * Alternate route: `/v2/characters/{character_id}/online/`
   *
   * Alternate route: `/v3/characters/{character_id}/online/`
   *
   * ---
   * This route is cached for up to 60 seconds
   * @param params The `LocationService.GetCharactersCharacterIdOnlineParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Object describing the character's online status
   */
  getCharactersCharacterIdOnline(params: LocationService.GetCharactersCharacterIdOnlineParams): __Observable<{last_login?: string, last_logout?: string, logins?: number, online: boolean}> {
    return this.getCharactersCharacterIdOnlineResponse(params).pipe(
      __map(_r => _r.body as {last_login?: string, last_logout?: string, logins?: number, online: boolean})
    );
  }

  /**
   * Get current ship
   *
   * Get the current ship type, name and id
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/ship/`
   *
   * Alternate route: `/legacy/characters/{character_id}/ship/`
   *
   * Alternate route: `/v1/characters/{character_id}/ship/`
   *
   * Alternate route: `/v2/characters/{character_id}/ship/`
   *
   * ---
   * This route is cached for up to 5 seconds
   * @param params The `LocationService.GetCharactersCharacterIdShipParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Get the current ship type, name and id
   */
  getCharactersCharacterIdShipResponse(params: LocationService.GetCharactersCharacterIdShipParams): __Observable<__StrictHttpResponse<{ship_item_id: number, ship_name: string, ship_type_id: number}>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/ship/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<{ship_item_id: number, ship_name: string, ship_type_id: number}>;
      })
    );
  }
  /**
   * Get current ship
   *
   * Get the current ship type, name and id
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/ship/`
   *
   * Alternate route: `/legacy/characters/{character_id}/ship/`
   *
   * Alternate route: `/v1/characters/{character_id}/ship/`
   *
   * Alternate route: `/v2/characters/{character_id}/ship/`
   *
   * ---
   * This route is cached for up to 5 seconds
   * @param params The `LocationService.GetCharactersCharacterIdShipParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Get the current ship type, name and id
   */
  getCharactersCharacterIdShip(params: LocationService.GetCharactersCharacterIdShipParams): __Observable<{ship_item_id: number, ship_name: string, ship_type_id: number}> {
    return this.getCharactersCharacterIdShipResponse(params).pipe(
      __map(_r => _r.body as {ship_item_id: number, ship_name: string, ship_type_id: number})
    );
  }
}

module LocationService {

  /**
   * Parameters for getCharactersCharacterIdLocation
   */
  export interface GetCharactersCharacterIdLocationParams {

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
   * Parameters for getCharactersCharacterIdOnline
   */
  export interface GetCharactersCharacterIdOnlineParams {

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
   * Parameters for getCharactersCharacterIdShip
   */
  export interface GetCharactersCharacterIdShipParams {

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

export { LocationService }
