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
class RoutesService extends __BaseService {
  static readonly getRouteOriginDestinationPath = '/route/{origin}/{destination}/';

  constructor(
    config: __Configuration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * Get route
   *
   * Get the systems between origin and destination
   *
   * ---
   * Alternate route: `/dev/route/{origin}/{destination}/`
   *
   * Alternate route: `/legacy/route/{origin}/{destination}/`
   *
   * Alternate route: `/v1/route/{origin}/{destination}/`
   *
   * ---
   * This route is cached for up to 86400 seconds
   * @param params The `RoutesService.GetRouteOriginDestinationParams` containing the following parameters:
   *
   * - `origin`: origin solar system ID
   *
   * - `destination`: destination solar system ID
   *
   * - `flag`: route security preference
   *
   * - `datasource`: The server name you would like data from
   *
   * - `connections`: connected solar system pairs
   *
   * - `avoid`: avoid solar system ID(s)
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Solar systems in route from origin to destination
   */
  getRouteOriginDestinationResponse(params: RoutesService.GetRouteOriginDestinationParams): __Observable<__StrictHttpResponse<Array<number>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;


    if (params.flag != null) __params = __params.set('flag', params.flag.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    (params.connections || []).forEach(val => {if (val != null) __params = __params.append('connections', val.toString())});
    (params.avoid || []).forEach(val => {if (val != null) __params = __params.append('avoid', val.toString())});
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/route/${encodeURIComponent(params.origin)}/${encodeURIComponent(params.destination)}/`,
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
   * Get route
   *
   * Get the systems between origin and destination
   *
   * ---
   * Alternate route: `/dev/route/{origin}/{destination}/`
   *
   * Alternate route: `/legacy/route/{origin}/{destination}/`
   *
   * Alternate route: `/v1/route/{origin}/{destination}/`
   *
   * ---
   * This route is cached for up to 86400 seconds
   * @param params The `RoutesService.GetRouteOriginDestinationParams` containing the following parameters:
   *
   * - `origin`: origin solar system ID
   *
   * - `destination`: destination solar system ID
   *
   * - `flag`: route security preference
   *
   * - `datasource`: The server name you would like data from
   *
   * - `connections`: connected solar system pairs
   *
   * - `avoid`: avoid solar system ID(s)
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Solar systems in route from origin to destination
   */
  getRouteOriginDestination(params: RoutesService.GetRouteOriginDestinationParams): __Observable<Array<number>> {
    return this.getRouteOriginDestinationResponse(params).pipe(
      __map(_r => _r.body as Array<number>)
    );
  }
}

module RoutesService {

  /**
   * Parameters for getRouteOriginDestination
   */
  export interface GetRouteOriginDestinationParams {

    /**
     * origin solar system ID
     */
    origin: number;

    /**
     * destination solar system ID
     */
    destination: number;

    /**
     * route security preference
     */
    flag?: 'shortest' | 'secure' | 'insecure';

    /**
     * The server name you would like data from
     */
    datasource?: 'tranquility' | 'singularity';

    /**
     * connected solar system pairs
     */
    connections?: Array<Array<number>>;

    /**
     * avoid solar system ID(s)
     */
    avoid?: Array<number>;

    /**
     * ETag from a previous request. A 304 will be returned if this matches the current ETag
     */
    IfNoneMatch?: string;
  }
}

export { RoutesService }
