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
class AllianceService extends __BaseService {
  static readonly getAlliancesPath = '/alliances/';
  static readonly getAlliancesAllianceIdPath = '/alliances/{alliance_id}/';
  static readonly getAlliancesAllianceIdCorporationsPath = '/alliances/{alliance_id}/corporations/';
  static readonly getAlliancesAllianceIdIconsPath = '/alliances/{alliance_id}/icons/';

  constructor(
    config: __Configuration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * List all alliances
   *
   * List all active player alliances
   *
   * ---
   * Alternate route: `/dev/alliances/`
   *
   * Alternate route: `/legacy/alliances/`
   *
   * Alternate route: `/v1/alliances/`
   *
   * Alternate route: `/v2/alliances/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `AllianceService.GetAlliancesParams` containing the following parameters:
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return List of Alliance IDs
   */
  getAlliancesResponse(params: AllianceService.GetAlliancesParams): __Observable<__StrictHttpResponse<Array<number>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/alliances/`,
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
   * List all alliances
   *
   * List all active player alliances
   *
   * ---
   * Alternate route: `/dev/alliances/`
   *
   * Alternate route: `/legacy/alliances/`
   *
   * Alternate route: `/v1/alliances/`
   *
   * Alternate route: `/v2/alliances/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `AllianceService.GetAlliancesParams` containing the following parameters:
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return List of Alliance IDs
   */
  getAlliances(params: AllianceService.GetAlliancesParams): __Observable<Array<number>> {
    return this.getAlliancesResponse(params).pipe(
      __map(_r => _r.body as Array<number>)
    );
  }

  /**
   * Get alliance information
   *
   * Public information about an alliance
   *
   * ---
   * Alternate route: `/dev/alliances/{alliance_id}/`
   *
   * Alternate route: `/legacy/alliances/{alliance_id}/`
   *
   * Alternate route: `/v3/alliances/{alliance_id}/`
   *
   * Alternate route: `/v4/alliances/{alliance_id}/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `AllianceService.GetAlliancesAllianceIdParams` containing the following parameters:
   *
   * - `alliance_id`: An EVE alliance ID
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Public data about an alliance
   */
  getAlliancesAllianceIdResponse(params: AllianceService.GetAlliancesAllianceIdParams): __Observable<__StrictHttpResponse<{creator_corporation_id: number, creator_id: number, date_founded: string, executor_corporation_id?: number, faction_id?: number, name: string, ticker: string}>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/alliances/${encodeURIComponent(params.allianceId)}/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<{creator_corporation_id: number, creator_id: number, date_founded: string, executor_corporation_id?: number, faction_id?: number, name: string, ticker: string}>;
      })
    );
  }
  /**
   * Get alliance information
   *
   * Public information about an alliance
   *
   * ---
   * Alternate route: `/dev/alliances/{alliance_id}/`
   *
   * Alternate route: `/legacy/alliances/{alliance_id}/`
   *
   * Alternate route: `/v3/alliances/{alliance_id}/`
   *
   * Alternate route: `/v4/alliances/{alliance_id}/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `AllianceService.GetAlliancesAllianceIdParams` containing the following parameters:
   *
   * - `alliance_id`: An EVE alliance ID
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Public data about an alliance
   */
  getAlliancesAllianceId(params: AllianceService.GetAlliancesAllianceIdParams): __Observable<{creator_corporation_id: number, creator_id: number, date_founded: string, executor_corporation_id?: number, faction_id?: number, name: string, ticker: string}> {
    return this.getAlliancesAllianceIdResponse(params).pipe(
      __map(_r => _r.body as {creator_corporation_id: number, creator_id: number, date_founded: string, executor_corporation_id?: number, faction_id?: number, name: string, ticker: string})
    );
  }

  /**
   * List alliance's corporations
   *
   * List all current member corporations of an alliance
   *
   * ---
   * Alternate route: `/dev/alliances/{alliance_id}/corporations/`
   *
   * Alternate route: `/legacy/alliances/{alliance_id}/corporations/`
   *
   * Alternate route: `/v1/alliances/{alliance_id}/corporations/`
   *
   * Alternate route: `/v2/alliances/{alliance_id}/corporations/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `AllianceService.GetAlliancesAllianceIdCorporationsParams` containing the following parameters:
   *
   * - `alliance_id`: An EVE alliance ID
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return List of corporation IDs
   */
  getAlliancesAllianceIdCorporationsResponse(params: AllianceService.GetAlliancesAllianceIdCorporationsParams): __Observable<__StrictHttpResponse<Array<number>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/alliances/${encodeURIComponent(params.allianceId)}/corporations/`,
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
   * List alliance's corporations
   *
   * List all current member corporations of an alliance
   *
   * ---
   * Alternate route: `/dev/alliances/{alliance_id}/corporations/`
   *
   * Alternate route: `/legacy/alliances/{alliance_id}/corporations/`
   *
   * Alternate route: `/v1/alliances/{alliance_id}/corporations/`
   *
   * Alternate route: `/v2/alliances/{alliance_id}/corporations/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `AllianceService.GetAlliancesAllianceIdCorporationsParams` containing the following parameters:
   *
   * - `alliance_id`: An EVE alliance ID
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return List of corporation IDs
   */
  getAlliancesAllianceIdCorporations(params: AllianceService.GetAlliancesAllianceIdCorporationsParams): __Observable<Array<number>> {
    return this.getAlliancesAllianceIdCorporationsResponse(params).pipe(
      __map(_r => _r.body as Array<number>)
    );
  }

  /**
   * Get alliance icon
   *
   * Get the icon urls for a alliance
   *
   * ---
   * Alternate route: `/legacy/alliances/{alliance_id}/icons/`
   *
   * Alternate route: `/v1/alliances/{alliance_id}/icons/`
   *
   * ---
   * This route expires daily at 11:05
   *
   * ---
   * [Diff of the upcoming changes](https://esi.evetech.net/diff/latest/dev/#GET-/alliances/{alliance_id}/icons/)
   * @param params The `AllianceService.GetAlliancesAllianceIdIconsParams` containing the following parameters:
   *
   * - `alliance_id`: An EVE alliance ID
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Icon URLs for the given alliance id and server
   */
  getAlliancesAllianceIdIconsResponse(params: AllianceService.GetAlliancesAllianceIdIconsParams): __Observable<__StrictHttpResponse<{px128x128?: string, px64x64?: string}>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/alliances/${encodeURIComponent(params.allianceId)}/icons/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<{px128x128?: string, px64x64?: string}>;
      })
    );
  }
  /**
   * Get alliance icon
   *
   * Get the icon urls for a alliance
   *
   * ---
   * Alternate route: `/legacy/alliances/{alliance_id}/icons/`
   *
   * Alternate route: `/v1/alliances/{alliance_id}/icons/`
   *
   * ---
   * This route expires daily at 11:05
   *
   * ---
   * [Diff of the upcoming changes](https://esi.evetech.net/diff/latest/dev/#GET-/alliances/{alliance_id}/icons/)
   * @param params The `AllianceService.GetAlliancesAllianceIdIconsParams` containing the following parameters:
   *
   * - `alliance_id`: An EVE alliance ID
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Icon URLs for the given alliance id and server
   */
  getAlliancesAllianceIdIcons(params: AllianceService.GetAlliancesAllianceIdIconsParams): __Observable<{px128x128?: string, px64x64?: string}> {
    return this.getAlliancesAllianceIdIconsResponse(params).pipe(
      __map(_r => _r.body as {px128x128?: string, px64x64?: string})
    );
  }
}

module AllianceService {

  /**
   * Parameters for getAlliances
   */
  export interface GetAlliancesParams {

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
   * Parameters for getAlliancesAllianceId
   */
  export interface GetAlliancesAllianceIdParams {

    /**
     * An EVE alliance ID
     */
    allianceId: number;

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
   * Parameters for getAlliancesAllianceIdCorporations
   */
  export interface GetAlliancesAllianceIdCorporationsParams {

    /**
     * An EVE alliance ID
     */
    allianceId: number;

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
   * Parameters for getAlliancesAllianceIdIcons
   */
  export interface GetAlliancesAllianceIdIconsParams {

    /**
     * An EVE alliance ID
     */
    allianceId: number;

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

export { AllianceService }
