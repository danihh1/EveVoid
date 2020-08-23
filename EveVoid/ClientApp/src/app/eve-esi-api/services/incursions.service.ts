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
class IncursionsService extends __BaseService {
  static readonly getIncursionsPath = '/incursions/';

  constructor(
    config: __Configuration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * List incursions
   *
   * Return a list of current incursions
   *
   * ---
   * Alternate route: `/dev/incursions/`
   *
   * Alternate route: `/legacy/incursions/`
   *
   * Alternate route: `/v1/incursions/`
   *
   * ---
   * This route is cached for up to 300 seconds
   * @param params The `IncursionsService.GetIncursionsParams` containing the following parameters:
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of incursions
   */
  getIncursionsResponse(params: IncursionsService.GetIncursionsParams): __Observable<__StrictHttpResponse<Array<{constellation_id: number, faction_id: number, has_boss: boolean, infested_solar_systems: Array<number>, influence: number, staging_solar_system_id: number, state: 'withdrawing' | 'mobilizing' | 'established', type: string}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/incursions/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{constellation_id: number, faction_id: number, has_boss: boolean, infested_solar_systems: Array<number>, influence: number, staging_solar_system_id: number, state: 'withdrawing' | 'mobilizing' | 'established', type: string}>>;
      })
    );
  }
  /**
   * List incursions
   *
   * Return a list of current incursions
   *
   * ---
   * Alternate route: `/dev/incursions/`
   *
   * Alternate route: `/legacy/incursions/`
   *
   * Alternate route: `/v1/incursions/`
   *
   * ---
   * This route is cached for up to 300 seconds
   * @param params The `IncursionsService.GetIncursionsParams` containing the following parameters:
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of incursions
   */
  getIncursions(params: IncursionsService.GetIncursionsParams): __Observable<Array<{constellation_id: number, faction_id: number, has_boss: boolean, infested_solar_systems: Array<number>, influence: number, staging_solar_system_id: number, state: 'withdrawing' | 'mobilizing' | 'established', type: string}>> {
    return this.getIncursionsResponse(params).pipe(
      __map(_r => _r.body as Array<{constellation_id: number, faction_id: number, has_boss: boolean, infested_solar_systems: Array<number>, influence: number, staging_solar_system_id: number, state: 'withdrawing' | 'mobilizing' | 'established', type: string}>)
    );
  }
}

module IncursionsService {

  /**
   * Parameters for getIncursions
   */
  export interface GetIncursionsParams {

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

export { IncursionsService }
