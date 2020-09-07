/* tslint:disable */
import { Injectable } from '@angular/core';
import { HttpClient, HttpRequest, HttpResponse, HttpHeaders } from '@angular/common/http';
import { BaseService as __BaseService } from '../base-service';
import { ApiConfiguration as __Configuration } from '../api-configuration';
import { StrictHttpResponse as __StrictHttpResponse } from '../strict-http-response';
import { Observable as __Observable } from 'rxjs';
import { map as __map, filter as __filter } from 'rxjs/operators';

import { MapDto } from '../models/map-dto';
@Injectable({
  providedIn: 'root',
})
class MapService extends __BaseService {
  static readonly getApiMapGetMapForRootIdPath = '/api/Map/GetMapForRootId';

  constructor(
    config: __Configuration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * @param params The `MapService.GetApiMapGetMapForRootIdParams` containing the following parameters:
   *
   * - `systemId`:
   *
   * - `maxGateLevel`:
   *
   * - `mainToken`:
   *
   * - `customName`:
   *
   * @return Success
   */
  getApiMapGetMapForRootIdResponse(params: MapService.GetApiMapGetMapForRootIdParams): __Observable<__StrictHttpResponse<MapDto>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.systemId != null) __params = __params.set('systemId', params.systemId.toString());
    if (params.maxGateLevel != null) __params = __params.set('maxGateLevel', params.maxGateLevel.toString());
    if (params.mainToken != null) __params = __params.set('mainToken', params.mainToken.toString());
    if (params.customName != null) __params = __params.set('customName', params.customName.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/api/Map/GetMapForRootId`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<MapDto>;
      })
    );
  }
  /**
   * @param params The `MapService.GetApiMapGetMapForRootIdParams` containing the following parameters:
   *
   * - `systemId`:
   *
   * - `maxGateLevel`:
   *
   * - `mainToken`:
   *
   * - `customName`:
   *
   * @return Success
   */
  getApiMapGetMapForRootId(params: MapService.GetApiMapGetMapForRootIdParams): __Observable<MapDto> {
    return this.getApiMapGetMapForRootIdResponse(params).pipe(
      __map(_r => _r.body as MapDto)
    );
  }
}

module MapService {

  /**
   * Parameters for getApiMapGetMapForRootId
   */
  export interface GetApiMapGetMapForRootIdParams {
    systemId?: number;
    maxGateLevel?: number;
    mainToken?: string;
    customName?: string;
  }
}

export { MapService }
