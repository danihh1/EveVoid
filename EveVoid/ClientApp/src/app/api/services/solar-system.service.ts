/* tslint:disable */
import { Injectable } from '@angular/core';
import { HttpClient, HttpRequest, HttpResponse, HttpHeaders } from '@angular/common/http';
import { BaseService as __BaseService } from '../base-service';
import { ApiConfiguration as __Configuration } from '../api-configuration';
import { StrictHttpResponse as __StrictHttpResponse } from '../strict-http-response';
import { Observable as __Observable } from 'rxjs';
import { map as __map, filter as __filter } from 'rxjs/operators';

import { SolarSystemDto } from '../models/solar-system-dto';
@Injectable({
  providedIn: 'root',
})
class SolarSystemService extends __BaseService {
  static readonly getApiSolarSystemGetSolarSystemByIdPath = '/api/SolarSystem/GetSolarSystemById';
  static readonly putApiSolarSystemUpdateSolarSystemSignaturesPath = '/api/SolarSystem/UpdateSolarSystemSignatures';
  static readonly getApiSolarSystemFindPath = '/api/SolarSystem/Find';

  constructor(
    config: __Configuration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * @param params The `SolarSystemService.GetApiSolarSystemGetSolarSystemByIdParams` containing the following parameters:
   *
   * - `systemId`:
   *
   * - `mainToken`:
   *
   * @return Success
   */
  getApiSolarSystemGetSolarSystemByIdResponse(params: SolarSystemService.GetApiSolarSystemGetSolarSystemByIdParams): __Observable<__StrictHttpResponse<SolarSystemDto>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.systemId != null) __params = __params.set('systemId', params.systemId.toString());
    if (params.mainToken != null) __params = __params.set('mainToken', params.mainToken.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/api/SolarSystem/GetSolarSystemById`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<SolarSystemDto>;
      })
    );
  }
  /**
   * @param params The `SolarSystemService.GetApiSolarSystemGetSolarSystemByIdParams` containing the following parameters:
   *
   * - `systemId`:
   *
   * - `mainToken`:
   *
   * @return Success
   */
  getApiSolarSystemGetSolarSystemById(params: SolarSystemService.GetApiSolarSystemGetSolarSystemByIdParams): __Observable<SolarSystemDto> {
    return this.getApiSolarSystemGetSolarSystemByIdResponse(params).pipe(
      __map(_r => _r.body as SolarSystemDto)
    );
  }

  /**
   * @param params The `SolarSystemService.PutApiSolarSystemUpdateSolarSystemSignaturesParams` containing the following parameters:
   *
   * - `mainToken`:
   *
   * - `body`:
   *
   * @return Success
   */
  putApiSolarSystemUpdateSolarSystemSignaturesResponse(params: SolarSystemService.PutApiSolarSystemUpdateSolarSystemSignaturesParams): __Observable<__StrictHttpResponse<SolarSystemDto>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.mainToken != null) __params = __params.set('mainToken', params.mainToken.toString());
    __body = params.body;
    let req = new HttpRequest<any>(
      'PUT',
      this.rootUrl + `/api/SolarSystem/UpdateSolarSystemSignatures`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<SolarSystemDto>;
      })
    );
  }
  /**
   * @param params The `SolarSystemService.PutApiSolarSystemUpdateSolarSystemSignaturesParams` containing the following parameters:
   *
   * - `mainToken`:
   *
   * - `body`:
   *
   * @return Success
   */
  putApiSolarSystemUpdateSolarSystemSignatures(params: SolarSystemService.PutApiSolarSystemUpdateSolarSystemSignaturesParams): __Observable<SolarSystemDto> {
    return this.putApiSolarSystemUpdateSolarSystemSignaturesResponse(params).pipe(
      __map(_r => _r.body as SolarSystemDto)
    );
  }

  /**
   * @param name undefined
   * @return Success
   */
  getApiSolarSystemFindResponse(name?: string): __Observable<__StrictHttpResponse<Array<SolarSystemDto>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (name != null) __params = __params.set('name', name.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/api/SolarSystem/Find`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<SolarSystemDto>>;
      })
    );
  }
  /**
   * @param name undefined
   * @return Success
   */
  getApiSolarSystemFind(name?: string): __Observable<Array<SolarSystemDto>> {
    return this.getApiSolarSystemFindResponse(name).pipe(
      __map(_r => _r.body as Array<SolarSystemDto>)
    );
  }
}

module SolarSystemService {

  /**
   * Parameters for getApiSolarSystemGetSolarSystemById
   */
  export interface GetApiSolarSystemGetSolarSystemByIdParams {
    systemId?: number;
    mainToken?: string;
  }

  /**
   * Parameters for putApiSolarSystemUpdateSolarSystemSignatures
   */
  export interface PutApiSolarSystemUpdateSolarSystemSignaturesParams {
    mainToken?: string;
    body?: SolarSystemDto;
  }
}

export { SolarSystemService }
