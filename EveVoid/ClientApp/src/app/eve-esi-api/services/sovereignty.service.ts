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
class SovereigntyService extends __BaseService {
  static readonly getSovereigntyCampaignsPath = '/sovereignty/campaigns/';
  static readonly getSovereigntyMapPath = '/sovereignty/map/';
  static readonly getSovereigntyStructuresPath = '/sovereignty/structures/';

  constructor(
    config: __Configuration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * List sovereignty campaigns
   *
   * Shows sovereignty data for campaigns.
   *
   * ---
   * Alternate route: `/dev/sovereignty/campaigns/`
   *
   * Alternate route: `/legacy/sovereignty/campaigns/`
   *
   * Alternate route: `/v1/sovereignty/campaigns/`
   *
   * ---
   * This route is cached for up to 5 seconds
   * @param params The `SovereigntyService.GetSovereigntyCampaignsParams` containing the following parameters:
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of sovereignty campaigns
   */
  getSovereigntyCampaignsResponse(params: SovereigntyService.GetSovereigntyCampaignsParams): __Observable<__StrictHttpResponse<Array<{attackers_score?: number, campaign_id: number, constellation_id: number, defender_id?: number, defender_score?: number, event_type: 'tcu_defense' | 'ihub_defense' | 'station_defense' | 'station_freeport', participants?: Array<{alliance_id: number, score: number}>, solar_system_id: number, start_time: string, structure_id: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/sovereignty/campaigns/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{attackers_score?: number, campaign_id: number, constellation_id: number, defender_id?: number, defender_score?: number, event_type: 'tcu_defense' | 'ihub_defense' | 'station_defense' | 'station_freeport', participants?: Array<{alliance_id: number, score: number}>, solar_system_id: number, start_time: string, structure_id: number}>>;
      })
    );
  }
  /**
   * List sovereignty campaigns
   *
   * Shows sovereignty data for campaigns.
   *
   * ---
   * Alternate route: `/dev/sovereignty/campaigns/`
   *
   * Alternate route: `/legacy/sovereignty/campaigns/`
   *
   * Alternate route: `/v1/sovereignty/campaigns/`
   *
   * ---
   * This route is cached for up to 5 seconds
   * @param params The `SovereigntyService.GetSovereigntyCampaignsParams` containing the following parameters:
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of sovereignty campaigns
   */
  getSovereigntyCampaigns(params: SovereigntyService.GetSovereigntyCampaignsParams): __Observable<Array<{attackers_score?: number, campaign_id: number, constellation_id: number, defender_id?: number, defender_score?: number, event_type: 'tcu_defense' | 'ihub_defense' | 'station_defense' | 'station_freeport', participants?: Array<{alliance_id: number, score: number}>, solar_system_id: number, start_time: string, structure_id: number}>> {
    return this.getSovereigntyCampaignsResponse(params).pipe(
      __map(_r => _r.body as Array<{attackers_score?: number, campaign_id: number, constellation_id: number, defender_id?: number, defender_score?: number, event_type: 'tcu_defense' | 'ihub_defense' | 'station_defense' | 'station_freeport', participants?: Array<{alliance_id: number, score: number}>, solar_system_id: number, start_time: string, structure_id: number}>)
    );
  }

  /**
   * List sovereignty of systems
   *
   * Shows sovereignty information for solar systems
   *
   * ---
   * Alternate route: `/dev/sovereignty/map/`
   *
   * Alternate route: `/legacy/sovereignty/map/`
   *
   * Alternate route: `/v1/sovereignty/map/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `SovereigntyService.GetSovereigntyMapParams` containing the following parameters:
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of sovereignty information for solar systems in New Eden
   */
  getSovereigntyMapResponse(params: SovereigntyService.GetSovereigntyMapParams): __Observable<__StrictHttpResponse<Array<{alliance_id?: number, corporation_id?: number, faction_id?: number, system_id: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/sovereignty/map/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{alliance_id?: number, corporation_id?: number, faction_id?: number, system_id: number}>>;
      })
    );
  }
  /**
   * List sovereignty of systems
   *
   * Shows sovereignty information for solar systems
   *
   * ---
   * Alternate route: `/dev/sovereignty/map/`
   *
   * Alternate route: `/legacy/sovereignty/map/`
   *
   * Alternate route: `/v1/sovereignty/map/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `SovereigntyService.GetSovereigntyMapParams` containing the following parameters:
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of sovereignty information for solar systems in New Eden
   */
  getSovereigntyMap(params: SovereigntyService.GetSovereigntyMapParams): __Observable<Array<{alliance_id?: number, corporation_id?: number, faction_id?: number, system_id: number}>> {
    return this.getSovereigntyMapResponse(params).pipe(
      __map(_r => _r.body as Array<{alliance_id?: number, corporation_id?: number, faction_id?: number, system_id: number}>)
    );
  }

  /**
   * List sovereignty structures
   *
   * Shows sovereignty data for structures.
   *
   * ---
   * Alternate route: `/dev/sovereignty/structures/`
   *
   * Alternate route: `/legacy/sovereignty/structures/`
   *
   * Alternate route: `/v1/sovereignty/structures/`
   *
   * ---
   * This route is cached for up to 120 seconds
   * @param params The `SovereigntyService.GetSovereigntyStructuresParams` containing the following parameters:
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of sovereignty structures
   */
  getSovereigntyStructuresResponse(params: SovereigntyService.GetSovereigntyStructuresParams): __Observable<__StrictHttpResponse<Array<{alliance_id: number, solar_system_id: number, structure_id: number, structure_type_id: number, vulnerability_occupancy_level?: number, vulnerable_end_time?: string, vulnerable_start_time?: string}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/sovereignty/structures/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{alliance_id: number, solar_system_id: number, structure_id: number, structure_type_id: number, vulnerability_occupancy_level?: number, vulnerable_end_time?: string, vulnerable_start_time?: string}>>;
      })
    );
  }
  /**
   * List sovereignty structures
   *
   * Shows sovereignty data for structures.
   *
   * ---
   * Alternate route: `/dev/sovereignty/structures/`
   *
   * Alternate route: `/legacy/sovereignty/structures/`
   *
   * Alternate route: `/v1/sovereignty/structures/`
   *
   * ---
   * This route is cached for up to 120 seconds
   * @param params The `SovereigntyService.GetSovereigntyStructuresParams` containing the following parameters:
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of sovereignty structures
   */
  getSovereigntyStructures(params: SovereigntyService.GetSovereigntyStructuresParams): __Observable<Array<{alliance_id: number, solar_system_id: number, structure_id: number, structure_type_id: number, vulnerability_occupancy_level?: number, vulnerable_end_time?: string, vulnerable_start_time?: string}>> {
    return this.getSovereigntyStructuresResponse(params).pipe(
      __map(_r => _r.body as Array<{alliance_id: number, solar_system_id: number, structure_id: number, structure_type_id: number, vulnerability_occupancy_level?: number, vulnerable_end_time?: string, vulnerable_start_time?: string}>)
    );
  }
}

module SovereigntyService {

  /**
   * Parameters for getSovereigntyCampaigns
   */
  export interface GetSovereigntyCampaignsParams {

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
   * Parameters for getSovereigntyMap
   */
  export interface GetSovereigntyMapParams {

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
   * Parameters for getSovereigntyStructures
   */
  export interface GetSovereigntyStructuresParams {

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

export { SovereigntyService }
