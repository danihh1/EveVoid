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
class WarsService extends __BaseService {
  static readonly getWarsPath = '/wars/';
  static readonly getWarsWarIdPath = '/wars/{war_id}/';
  static readonly getWarsWarIdKillmailsPath = '/wars/{war_id}/killmails/';

  constructor(
    config: __Configuration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * List wars
   *
   * Return a list of wars
   *
   * ---
   * Alternate route: `/dev/wars/`
   *
   * Alternate route: `/legacy/wars/`
   *
   * Alternate route: `/v1/wars/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `WarsService.GetWarsParams` containing the following parameters:
   *
   * - `max_war_id`: Only return wars with ID smaller than this
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of war IDs, in descending order by war_id
   */
  getWarsResponse(params: WarsService.GetWarsParams): __Observable<__StrictHttpResponse<Array<number>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.maxWarId != null) __params = __params.set('max_war_id', params.maxWarId.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/wars/`,
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
   * List wars
   *
   * Return a list of wars
   *
   * ---
   * Alternate route: `/dev/wars/`
   *
   * Alternate route: `/legacy/wars/`
   *
   * Alternate route: `/v1/wars/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `WarsService.GetWarsParams` containing the following parameters:
   *
   * - `max_war_id`: Only return wars with ID smaller than this
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of war IDs, in descending order by war_id
   */
  getWars(params: WarsService.GetWarsParams): __Observable<Array<number>> {
    return this.getWarsResponse(params).pipe(
      __map(_r => _r.body as Array<number>)
    );
  }

  /**
   * Get war information
   *
   * Return details about a war
   *
   * ---
   * Alternate route: `/dev/wars/{war_id}/`
   *
   * Alternate route: `/legacy/wars/{war_id}/`
   *
   * Alternate route: `/v1/wars/{war_id}/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `WarsService.GetWarsWarIdParams` containing the following parameters:
   *
   * - `war_id`: ID for a war
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Details about a war
   */
  getWarsWarIdResponse(params: WarsService.GetWarsWarIdParams): __Observable<__StrictHttpResponse<{aggressor: {alliance_id?: number, corporation_id?: number, isk_destroyed: number, ships_killed: number}, allies?: Array<{alliance_id?: number, corporation_id?: number}>, declared: string, defender: {alliance_id?: number, corporation_id?: number, isk_destroyed: number, ships_killed: number}, finished?: string, id: number, mutual: boolean, open_for_allies: boolean, retracted?: string, started?: string}>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/wars/${encodeURIComponent(params.warId)}/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<{aggressor: {alliance_id?: number, corporation_id?: number, isk_destroyed: number, ships_killed: number}, allies?: Array<{alliance_id?: number, corporation_id?: number}>, declared: string, defender: {alliance_id?: number, corporation_id?: number, isk_destroyed: number, ships_killed: number}, finished?: string, id: number, mutual: boolean, open_for_allies: boolean, retracted?: string, started?: string}>;
      })
    );
  }
  /**
   * Get war information
   *
   * Return details about a war
   *
   * ---
   * Alternate route: `/dev/wars/{war_id}/`
   *
   * Alternate route: `/legacy/wars/{war_id}/`
   *
   * Alternate route: `/v1/wars/{war_id}/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `WarsService.GetWarsWarIdParams` containing the following parameters:
   *
   * - `war_id`: ID for a war
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Details about a war
   */
  getWarsWarId(params: WarsService.GetWarsWarIdParams): __Observable<{aggressor: {alliance_id?: number, corporation_id?: number, isk_destroyed: number, ships_killed: number}, allies?: Array<{alliance_id?: number, corporation_id?: number}>, declared: string, defender: {alliance_id?: number, corporation_id?: number, isk_destroyed: number, ships_killed: number}, finished?: string, id: number, mutual: boolean, open_for_allies: boolean, retracted?: string, started?: string}> {
    return this.getWarsWarIdResponse(params).pipe(
      __map(_r => _r.body as {aggressor: {alliance_id?: number, corporation_id?: number, isk_destroyed: number, ships_killed: number}, allies?: Array<{alliance_id?: number, corporation_id?: number}>, declared: string, defender: {alliance_id?: number, corporation_id?: number, isk_destroyed: number, ships_killed: number}, finished?: string, id: number, mutual: boolean, open_for_allies: boolean, retracted?: string, started?: string})
    );
  }

  /**
   * List kills for a war
   *
   * Return a list of kills related to a war
   *
   * ---
   * Alternate route: `/dev/wars/{war_id}/killmails/`
   *
   * Alternate route: `/legacy/wars/{war_id}/killmails/`
   *
   * Alternate route: `/v1/wars/{war_id}/killmails/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `WarsService.GetWarsWarIdKillmailsParams` containing the following parameters:
   *
   * - `war_id`: A valid war ID
   *
   * - `page`: Which page of results to return
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of killmail IDs and hashes
   */
  getWarsWarIdKillmailsResponse(params: WarsService.GetWarsWarIdKillmailsParams): __Observable<__StrictHttpResponse<Array<{killmail_hash: string, killmail_id: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.page != null) __params = __params.set('page', params.page.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/wars/${encodeURIComponent(params.warId)}/killmails/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{killmail_hash: string, killmail_id: number}>>;
      })
    );
  }
  /**
   * List kills for a war
   *
   * Return a list of kills related to a war
   *
   * ---
   * Alternate route: `/dev/wars/{war_id}/killmails/`
   *
   * Alternate route: `/legacy/wars/{war_id}/killmails/`
   *
   * Alternate route: `/v1/wars/{war_id}/killmails/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `WarsService.GetWarsWarIdKillmailsParams` containing the following parameters:
   *
   * - `war_id`: A valid war ID
   *
   * - `page`: Which page of results to return
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of killmail IDs and hashes
   */
  getWarsWarIdKillmails(params: WarsService.GetWarsWarIdKillmailsParams): __Observable<Array<{killmail_hash: string, killmail_id: number}>> {
    return this.getWarsWarIdKillmailsResponse(params).pipe(
      __map(_r => _r.body as Array<{killmail_hash: string, killmail_id: number}>)
    );
  }
}

module WarsService {

  /**
   * Parameters for getWars
   */
  export interface GetWarsParams {

    /**
     * Only return wars with ID smaller than this
     */
    maxWarId?: number;

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
   * Parameters for getWarsWarId
   */
  export interface GetWarsWarIdParams {

    /**
     * ID for a war
     */
    warId: number;

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
   * Parameters for getWarsWarIdKillmails
   */
  export interface GetWarsWarIdKillmailsParams {

    /**
     * A valid war ID
     */
    warId: number;

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
}

export { WarsService }
