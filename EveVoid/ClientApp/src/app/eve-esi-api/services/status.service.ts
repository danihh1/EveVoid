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
class StatusService extends __BaseService {
  static readonly getStatusPath = '/status/';

  constructor(
    config: __Configuration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * Retrieve the uptime and player counts
   *
   * EVE Server status
   *
   * ---
   * Alternate route: `/dev/status/`
   *
   * Alternate route: `/legacy/status/`
   *
   * Alternate route: `/v1/status/`
   *
   * Alternate route: `/v2/status/`
   *
   * ---
   * This route is cached for up to 30 seconds
   * @param params The `StatusService.GetStatusParams` containing the following parameters:
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Server status
   */
  getStatusResponse(params: StatusService.GetStatusParams): __Observable<__StrictHttpResponse<{players: number, server_version: string, start_time: string, vip?: boolean}>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/status/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<{players: number, server_version: string, start_time: string, vip?: boolean}>;
      })
    );
  }
  /**
   * Retrieve the uptime and player counts
   *
   * EVE Server status
   *
   * ---
   * Alternate route: `/dev/status/`
   *
   * Alternate route: `/legacy/status/`
   *
   * Alternate route: `/v1/status/`
   *
   * Alternate route: `/v2/status/`
   *
   * ---
   * This route is cached for up to 30 seconds
   * @param params The `StatusService.GetStatusParams` containing the following parameters:
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Server status
   */
  getStatus(params: StatusService.GetStatusParams): __Observable<{players: number, server_version: string, start_time: string, vip?: boolean}> {
    return this.getStatusResponse(params).pipe(
      __map(_r => _r.body as {players: number, server_version: string, start_time: string, vip?: boolean})
    );
  }
}

module StatusService {

  /**
   * Parameters for getStatus
   */
  export interface GetStatusParams {

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

export { StatusService }
