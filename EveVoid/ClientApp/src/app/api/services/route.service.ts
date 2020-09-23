/* tslint:disable */
import { Injectable } from '@angular/core';
import { HttpClient, HttpRequest, HttpResponse, HttpHeaders } from '@angular/common/http';
import { BaseService as __BaseService } from '../base-service';
import { ApiConfiguration as __Configuration } from '../api-configuration';
import { StrictHttpResponse as __StrictHttpResponse } from '../strict-http-response';
import { Observable as __Observable } from 'rxjs';
import { map as __map, filter as __filter } from 'rxjs/operators';

import { FavoriteDistanceDto } from '../models/favorite-distance-dto';
@Injectable({
  providedIn: 'root',
})
class RouteService extends __BaseService {
  static readonly getApiRoutePath = '/api/Route';

  constructor(
    config: __Configuration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * @param params The `RouteService.GetApiRouteParams` containing the following parameters:
   *
   * - `routeType`:
   *
   * - `originSystemId`:
   *
   * - `mainToken`:
   *
   * @return Success
   */
  getApiRouteResponse(params: RouteService.GetApiRouteParams): __Observable<__StrictHttpResponse<Array<FavoriteDistanceDto>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.routeType != null) __params = __params.set('routeType', params.routeType.toString());
    if (params.originSystemId != null) __params = __params.set('originSystemId', params.originSystemId.toString());
    if (params.mainToken != null) __params = __params.set('mainToken', params.mainToken.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/api/Route`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<FavoriteDistanceDto>>;
      })
    );
  }
  /**
   * @param params The `RouteService.GetApiRouteParams` containing the following parameters:
   *
   * - `routeType`:
   *
   * - `originSystemId`:
   *
   * - `mainToken`:
   *
   * @return Success
   */
  getApiRoute(params: RouteService.GetApiRouteParams): __Observable<Array<FavoriteDistanceDto>> {
    return this.getApiRouteResponse(params).pipe(
      __map(_r => _r.body as Array<FavoriteDistanceDto>)
    );
  }
}

module RouteService {

  /**
   * Parameters for getApiRoute
   */
  export interface GetApiRouteParams {
    routeType?: any;
    originSystemId?: number;
    mainToken?: string;
  }
}

export { RouteService }
