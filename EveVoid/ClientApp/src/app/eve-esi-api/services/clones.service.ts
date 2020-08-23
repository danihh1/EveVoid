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
class ClonesService extends __BaseService {
  static readonly getCharactersCharacterIdClonesPath = '/characters/{character_id}/clones/';
  static readonly getCharactersCharacterIdImplantsPath = '/characters/{character_id}/implants/';

  constructor(
    config: __Configuration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * Get clones
   *
   * A list of the character's clones
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/clones/`
   *
   * Alternate route: `/v3/characters/{character_id}/clones/`
   *
   * Alternate route: `/v4/characters/{character_id}/clones/`
   *
   * ---
   * This route is cached for up to 120 seconds
   * @param params The `ClonesService.GetCharactersCharacterIdClonesParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Clone information for the given character
   */
  getCharactersCharacterIdClonesResponse(params: ClonesService.GetCharactersCharacterIdClonesParams): __Observable<__StrictHttpResponse<{home_location?: {location_id?: number, location_type?: 'station' | 'structure'}, jump_clones: Array<{implants: Array<number>, jump_clone_id: number, location_id: number, location_type: 'station' | 'structure', name?: string}>, last_clone_jump_date?: string, last_station_change_date?: string}>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/clones/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<{home_location?: {location_id?: number, location_type?: 'station' | 'structure'}, jump_clones: Array<{implants: Array<number>, jump_clone_id: number, location_id: number, location_type: 'station' | 'structure', name?: string}>, last_clone_jump_date?: string, last_station_change_date?: string}>;
      })
    );
  }
  /**
   * Get clones
   *
   * A list of the character's clones
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/clones/`
   *
   * Alternate route: `/v3/characters/{character_id}/clones/`
   *
   * Alternate route: `/v4/characters/{character_id}/clones/`
   *
   * ---
   * This route is cached for up to 120 seconds
   * @param params The `ClonesService.GetCharactersCharacterIdClonesParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Clone information for the given character
   */
  getCharactersCharacterIdClones(params: ClonesService.GetCharactersCharacterIdClonesParams): __Observable<{home_location?: {location_id?: number, location_type?: 'station' | 'structure'}, jump_clones: Array<{implants: Array<number>, jump_clone_id: number, location_id: number, location_type: 'station' | 'structure', name?: string}>, last_clone_jump_date?: string, last_station_change_date?: string}> {
    return this.getCharactersCharacterIdClonesResponse(params).pipe(
      __map(_r => _r.body as {home_location?: {location_id?: number, location_type?: 'station' | 'structure'}, jump_clones: Array<{implants: Array<number>, jump_clone_id: number, location_id: number, location_type: 'station' | 'structure', name?: string}>, last_clone_jump_date?: string, last_station_change_date?: string})
    );
  }

  /**
   * Get active implants
   *
   * Return implants on the active clone of a character
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/implants/`
   *
   * Alternate route: `/legacy/characters/{character_id}/implants/`
   *
   * Alternate route: `/v1/characters/{character_id}/implants/`
   *
   * Alternate route: `/v2/characters/{character_id}/implants/`
   *
   * ---
   * This route is cached for up to 120 seconds
   * @param params The `ClonesService.GetCharactersCharacterIdImplantsParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of implant type ids
   */
  getCharactersCharacterIdImplantsResponse(params: ClonesService.GetCharactersCharacterIdImplantsParams): __Observable<__StrictHttpResponse<Array<number>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/implants/`,
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
   * Get active implants
   *
   * Return implants on the active clone of a character
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/implants/`
   *
   * Alternate route: `/legacy/characters/{character_id}/implants/`
   *
   * Alternate route: `/v1/characters/{character_id}/implants/`
   *
   * Alternate route: `/v2/characters/{character_id}/implants/`
   *
   * ---
   * This route is cached for up to 120 seconds
   * @param params The `ClonesService.GetCharactersCharacterIdImplantsParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of implant type ids
   */
  getCharactersCharacterIdImplants(params: ClonesService.GetCharactersCharacterIdImplantsParams): __Observable<Array<number>> {
    return this.getCharactersCharacterIdImplantsResponse(params).pipe(
      __map(_r => _r.body as Array<number>)
    );
  }
}

module ClonesService {

  /**
   * Parameters for getCharactersCharacterIdClones
   */
  export interface GetCharactersCharacterIdClonesParams {

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
   * Parameters for getCharactersCharacterIdImplants
   */
  export interface GetCharactersCharacterIdImplantsParams {

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

export { ClonesService }
