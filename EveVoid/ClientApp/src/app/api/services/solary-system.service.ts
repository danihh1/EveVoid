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
class SolarySystemService extends __BaseService {
  static readonly getApiSolarySystemGetSolarSystemByIdPath = '/api/SolarySystem/GetSolarSystemById';
  static readonly putApiSolarySystemUpdateSolarSystemSignaturesPath = '/api/SolarySystem/UpdateSolarSystemSignatures';
  static readonly getApiSolarySystemFindPath = '/api/SolarySystem/Find';

  constructor(
    config: __Configuration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * @param params The `SolarySystemService.GetApiSolarySystemGetSolarSystemByIdParams` containing the following parameters:
   *
   * - `systemId`:
   *
   * - `mainToken`:
   *
   * @return Success
   */
  getApiSolarySystemGetSolarSystemByIdResponse(params: SolarySystemService.GetApiSolarySystemGetSolarSystemByIdParams): __Observable<__StrictHttpResponse<SolarSystemDto>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.systemId != null) __params = __params.set('systemId', params.systemId.toString());
    if (params.mainToken != null) __params = __params.set('mainToken', params.mainToken.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/api/SolarySystem/GetSolarSystemById`,
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
   * @param params The `SolarySystemService.GetApiSolarySystemGetSolarSystemByIdParams` containing the following parameters:
   *
   * - `systemId`:
   *
   * - `mainToken`:
   *
   * @return Success
   */
  getApiSolarySystemGetSolarSystemById(params: SolarySystemService.GetApiSolarySystemGetSolarSystemByIdParams): __Observable<SolarSystemDto> {
    return this.getApiSolarySystemGetSolarSystemByIdResponse(params).pipe(
      __map(_r => _r.body as SolarSystemDto)
    );
  }

  /**
   * @param params The `SolarySystemService.PutApiSolarySystemUpdateSolarSystemSignaturesParams` containing the following parameters:
   *
   * - `mainToken`:
   *
   * - `body`:
   *
   * @return Success
   */
  putApiSolarySystemUpdateSolarSystemSignaturesResponse(params: SolarySystemService.PutApiSolarySystemUpdateSolarSystemSignaturesParams): __Observable<__StrictHttpResponse<SolarSystemDto>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.mainToken != null) __params = __params.set('mainToken', params.mainToken.toString());
    __body = params.body;
    let req = new HttpRequest<any>(
      'PUT',
      this.rootUrl + `/api/SolarySystem/UpdateSolarSystemSignatures`,
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
   * @param params The `SolarySystemService.PutApiSolarySystemUpdateSolarSystemSignaturesParams` containing the following parameters:
   *
   * - `mainToken`:
   *
   * - `body`:
   *
   * @return Success
   */
  putApiSolarySystemUpdateSolarSystemSignatures(params: SolarySystemService.PutApiSolarySystemUpdateSolarSystemSignaturesParams): __Observable<SolarSystemDto> {
    return this.putApiSolarySystemUpdateSolarSystemSignaturesResponse(params).pipe(
      __map(_r => _r.body as SolarSystemDto)
    );
  }

  /**
   * @param name undefined
   * @return Success
   */
  getApiSolarySystemFindResponse(name?: string): __Observable<__StrictHttpResponse<Array<SolarSystemDto>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (name != null) __params = __params.set('name', name.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/api/SolarySystem/Find`,
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
  getApiSolarySystemFind(name?: string): __Observable<Array<SolarSystemDto>> {
    return this.getApiSolarySystemFindResponse(name).pipe(
      __map(_r => _r.body as Array<SolarSystemDto>)
    );
  }
}

module SolarySystemService {

  /**
   * Parameters for getApiSolarySystemGetSolarSystemById
   */
  export interface GetApiSolarySystemGetSolarSystemByIdParams {
    systemId?: number;
    mainToken?: string;
  }

  /**
   * Parameters for putApiSolarySystemUpdateSolarSystemSignatures
   */
  export interface PutApiSolarySystemUpdateSolarSystemSignaturesParams {
    mainToken?: string;
    body?: SolarSystemDto;
  }
}

export { SolarySystemService }
