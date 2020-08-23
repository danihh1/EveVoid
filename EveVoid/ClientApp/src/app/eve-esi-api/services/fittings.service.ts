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
class FittingsService extends __BaseService {
  static readonly getCharactersCharacterIdFittingsPath = '/characters/{character_id}/fittings/';
  static readonly postCharactersCharacterIdFittingsPath = '/characters/{character_id}/fittings/';
  static readonly deleteCharactersCharacterIdFittingsFittingIdPath = '/characters/{character_id}/fittings/{fitting_id}/';

  constructor(
    config: __Configuration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * Get fittings
   *
   * Return fittings of a character
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/fittings/`
   *
   * Alternate route: `/v2/characters/{character_id}/fittings/`
   *
   * ---
   * This route is cached for up to 300 seconds
   * @param params The `FittingsService.GetCharactersCharacterIdFittingsParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of fittings
   */
  getCharactersCharacterIdFittingsResponse(params: FittingsService.GetCharactersCharacterIdFittingsParams): __Observable<__StrictHttpResponse<Array<{description: string, fitting_id: number, items: Array<{flag: 'Cargo' | 'DroneBay' | 'FighterBay' | 'HiSlot0' | 'HiSlot1' | 'HiSlot2' | 'HiSlot3' | 'HiSlot4' | 'HiSlot5' | 'HiSlot6' | 'HiSlot7' | 'Invalid' | 'LoSlot0' | 'LoSlot1' | 'LoSlot2' | 'LoSlot3' | 'LoSlot4' | 'LoSlot5' | 'LoSlot6' | 'LoSlot7' | 'MedSlot0' | 'MedSlot1' | 'MedSlot2' | 'MedSlot3' | 'MedSlot4' | 'MedSlot5' | 'MedSlot6' | 'MedSlot7' | 'RigSlot0' | 'RigSlot1' | 'RigSlot2' | 'ServiceSlot0' | 'ServiceSlot1' | 'ServiceSlot2' | 'ServiceSlot3' | 'ServiceSlot4' | 'ServiceSlot5' | 'ServiceSlot6' | 'ServiceSlot7' | 'SubSystemSlot0' | 'SubSystemSlot1' | 'SubSystemSlot2' | 'SubSystemSlot3', quantity: number, type_id: number}>, name: string, ship_type_id: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/fittings/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{description: string, fitting_id: number, items: Array<{flag: 'Cargo' | 'DroneBay' | 'FighterBay' | 'HiSlot0' | 'HiSlot1' | 'HiSlot2' | 'HiSlot3' | 'HiSlot4' | 'HiSlot5' | 'HiSlot6' | 'HiSlot7' | 'Invalid' | 'LoSlot0' | 'LoSlot1' | 'LoSlot2' | 'LoSlot3' | 'LoSlot4' | 'LoSlot5' | 'LoSlot6' | 'LoSlot7' | 'MedSlot0' | 'MedSlot1' | 'MedSlot2' | 'MedSlot3' | 'MedSlot4' | 'MedSlot5' | 'MedSlot6' | 'MedSlot7' | 'RigSlot0' | 'RigSlot1' | 'RigSlot2' | 'ServiceSlot0' | 'ServiceSlot1' | 'ServiceSlot2' | 'ServiceSlot3' | 'ServiceSlot4' | 'ServiceSlot5' | 'ServiceSlot6' | 'ServiceSlot7' | 'SubSystemSlot0' | 'SubSystemSlot1' | 'SubSystemSlot2' | 'SubSystemSlot3', quantity: number, type_id: number}>, name: string, ship_type_id: number}>>;
      })
    );
  }
  /**
   * Get fittings
   *
   * Return fittings of a character
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/fittings/`
   *
   * Alternate route: `/v2/characters/{character_id}/fittings/`
   *
   * ---
   * This route is cached for up to 300 seconds
   * @param params The `FittingsService.GetCharactersCharacterIdFittingsParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of fittings
   */
  getCharactersCharacterIdFittings(params: FittingsService.GetCharactersCharacterIdFittingsParams): __Observable<Array<{description: string, fitting_id: number, items: Array<{flag: 'Cargo' | 'DroneBay' | 'FighterBay' | 'HiSlot0' | 'HiSlot1' | 'HiSlot2' | 'HiSlot3' | 'HiSlot4' | 'HiSlot5' | 'HiSlot6' | 'HiSlot7' | 'Invalid' | 'LoSlot0' | 'LoSlot1' | 'LoSlot2' | 'LoSlot3' | 'LoSlot4' | 'LoSlot5' | 'LoSlot6' | 'LoSlot7' | 'MedSlot0' | 'MedSlot1' | 'MedSlot2' | 'MedSlot3' | 'MedSlot4' | 'MedSlot5' | 'MedSlot6' | 'MedSlot7' | 'RigSlot0' | 'RigSlot1' | 'RigSlot2' | 'ServiceSlot0' | 'ServiceSlot1' | 'ServiceSlot2' | 'ServiceSlot3' | 'ServiceSlot4' | 'ServiceSlot5' | 'ServiceSlot6' | 'ServiceSlot7' | 'SubSystemSlot0' | 'SubSystemSlot1' | 'SubSystemSlot2' | 'SubSystemSlot3', quantity: number, type_id: number}>, name: string, ship_type_id: number}>> {
    return this.getCharactersCharacterIdFittingsResponse(params).pipe(
      __map(_r => _r.body as Array<{description: string, fitting_id: number, items: Array<{flag: 'Cargo' | 'DroneBay' | 'FighterBay' | 'HiSlot0' | 'HiSlot1' | 'HiSlot2' | 'HiSlot3' | 'HiSlot4' | 'HiSlot5' | 'HiSlot6' | 'HiSlot7' | 'Invalid' | 'LoSlot0' | 'LoSlot1' | 'LoSlot2' | 'LoSlot3' | 'LoSlot4' | 'LoSlot5' | 'LoSlot6' | 'LoSlot7' | 'MedSlot0' | 'MedSlot1' | 'MedSlot2' | 'MedSlot3' | 'MedSlot4' | 'MedSlot5' | 'MedSlot6' | 'MedSlot7' | 'RigSlot0' | 'RigSlot1' | 'RigSlot2' | 'ServiceSlot0' | 'ServiceSlot1' | 'ServiceSlot2' | 'ServiceSlot3' | 'ServiceSlot4' | 'ServiceSlot5' | 'ServiceSlot6' | 'ServiceSlot7' | 'SubSystemSlot0' | 'SubSystemSlot1' | 'SubSystemSlot2' | 'SubSystemSlot3', quantity: number, type_id: number}>, name: string, ship_type_id: number}>)
    );
  }

  /**
   * Create fitting
   *
   * Save a new fitting for a character
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/fittings/`
   *
   * Alternate route: `/v2/characters/{character_id}/fittings/`
   * @param params The `FittingsService.PostCharactersCharacterIdFittingsParams` containing the following parameters:
   *
   * - `fitting`: Details about the new fitting
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * @return A list of fittings
   */
  postCharactersCharacterIdFittingsResponse(params: FittingsService.PostCharactersCharacterIdFittingsParams): __Observable<__StrictHttpResponse<{fitting_id: number}>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    __body = params.fitting;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    let req = new HttpRequest<any>(
      'POST',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/fittings/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<{fitting_id: number}>;
      })
    );
  }
  /**
   * Create fitting
   *
   * Save a new fitting for a character
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/fittings/`
   *
   * Alternate route: `/v2/characters/{character_id}/fittings/`
   * @param params The `FittingsService.PostCharactersCharacterIdFittingsParams` containing the following parameters:
   *
   * - `fitting`: Details about the new fitting
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * @return A list of fittings
   */
  postCharactersCharacterIdFittings(params: FittingsService.PostCharactersCharacterIdFittingsParams): __Observable<{fitting_id: number}> {
    return this.postCharactersCharacterIdFittingsResponse(params).pipe(
      __map(_r => _r.body as {fitting_id: number})
    );
  }

  /**
   * Delete fitting
   *
   * Delete a fitting from a character
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/fittings/{fitting_id}/`
   *
   * Alternate route: `/legacy/characters/{character_id}/fittings/{fitting_id}/`
   *
   * Alternate route: `/v1/characters/{character_id}/fittings/{fitting_id}/`
   * @param params The `FittingsService.DeleteCharactersCharacterIdFittingsFittingIdParams` containing the following parameters:
   *
   * - `fitting_id`: ID for a fitting of this character
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   */
  deleteCharactersCharacterIdFittingsFittingIdResponse(params: FittingsService.DeleteCharactersCharacterIdFittingsFittingIdParams): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;


    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    let req = new HttpRequest<any>(
      'DELETE',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/fittings/${encodeURIComponent(params.fittingId)}/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<null>;
      })
    );
  }
  /**
   * Delete fitting
   *
   * Delete a fitting from a character
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/fittings/{fitting_id}/`
   *
   * Alternate route: `/legacy/characters/{character_id}/fittings/{fitting_id}/`
   *
   * Alternate route: `/v1/characters/{character_id}/fittings/{fitting_id}/`
   * @param params The `FittingsService.DeleteCharactersCharacterIdFittingsFittingIdParams` containing the following parameters:
   *
   * - `fitting_id`: ID for a fitting of this character
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   */
  deleteCharactersCharacterIdFittingsFittingId(params: FittingsService.DeleteCharactersCharacterIdFittingsFittingIdParams): __Observable<null> {
    return this.deleteCharactersCharacterIdFittingsFittingIdResponse(params).pipe(
      __map(_r => _r.body as null)
    );
  }
}

module FittingsService {

  /**
   * Parameters for getCharactersCharacterIdFittings
   */
  export interface GetCharactersCharacterIdFittingsParams {

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
   * Parameters for postCharactersCharacterIdFittings
   */
  export interface PostCharactersCharacterIdFittingsParams {

    /**
     * Details about the new fitting
     */
    fitting: {description: string, items: Array<{flag: 'Cargo' | 'DroneBay' | 'FighterBay' | 'HiSlot0' | 'HiSlot1' | 'HiSlot2' | 'HiSlot3' | 'HiSlot4' | 'HiSlot5' | 'HiSlot6' | 'HiSlot7' | 'Invalid' | 'LoSlot0' | 'LoSlot1' | 'LoSlot2' | 'LoSlot3' | 'LoSlot4' | 'LoSlot5' | 'LoSlot6' | 'LoSlot7' | 'MedSlot0' | 'MedSlot1' | 'MedSlot2' | 'MedSlot3' | 'MedSlot4' | 'MedSlot5' | 'MedSlot6' | 'MedSlot7' | 'RigSlot0' | 'RigSlot1' | 'RigSlot2' | 'ServiceSlot0' | 'ServiceSlot1' | 'ServiceSlot2' | 'ServiceSlot3' | 'ServiceSlot4' | 'ServiceSlot5' | 'ServiceSlot6' | 'ServiceSlot7' | 'SubSystemSlot0' | 'SubSystemSlot1' | 'SubSystemSlot2' | 'SubSystemSlot3', quantity: number, type_id: number}>, name: string, ship_type_id: number};

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
   * Parameters for deleteCharactersCharacterIdFittingsFittingId
   */
  export interface DeleteCharactersCharacterIdFittingsFittingIdParams {

    /**
     * ID for a fitting of this character
     */
    fittingId: number;

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
}

export { FittingsService }
