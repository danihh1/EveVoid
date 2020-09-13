/* tslint:disable */
import { Injectable } from '@angular/core';
import { HttpClient, HttpRequest, HttpResponse, HttpHeaders } from '@angular/common/http';
import { BaseService as __BaseService } from '../base-service';
import { ApiConfiguration as __Configuration } from '../api-configuration';
import { StrictHttpResponse as __StrictHttpResponse } from '../strict-http-response';
import { Observable as __Observable } from 'rxjs';
import { map as __map, filter as __filter } from 'rxjs/operators';

import { SolarSystemStructureDto } from '../models/solar-system-structure-dto';
@Injectable({
  providedIn: 'root',
})
class SolarSystemStructureService extends __BaseService {
  static readonly postApiSolarSystemStructureInsertPath = '/api/SolarSystemStructure/Insert';
  static readonly putApiSolarSystemStructureUpdatePath = '/api/SolarSystemStructure/Update';
  static readonly deleteApiSolarSystemStructurePath = '/api/SolarSystemStructure';
  static readonly getApiSolarSystemStructureGetByIdPath = '/api/SolarSystemStructure/GetById';
  static readonly postApiSolarSystemStructureInsertBulkPath = '/api/SolarSystemStructure/InsertBulk';

  constructor(
    config: __Configuration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * @param params The `SolarSystemStructureService.PostApiSolarSystemStructureInsertParams` containing the following parameters:
   *
   * - `mainToken`:
   *
   * - `body`:
   */
  postApiSolarSystemStructureInsertResponse(params: SolarSystemStructureService.PostApiSolarSystemStructureInsertParams): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.mainToken != null) __params = __params.set('mainToken', params.mainToken.toString());
    __body = params.body;
    let req = new HttpRequest<any>(
      'POST',
      this.rootUrl + `/api/SolarSystemStructure/Insert`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<null>;
      })
    );
  }
  /**
   * @param params The `SolarSystemStructureService.PostApiSolarSystemStructureInsertParams` containing the following parameters:
   *
   * - `mainToken`:
   *
   * - `body`:
   */
  postApiSolarSystemStructureInsert(params: SolarSystemStructureService.PostApiSolarSystemStructureInsertParams): __Observable<null> {
    return this.postApiSolarSystemStructureInsertResponse(params).pipe(
      __map(_r => _r.body as null)
    );
  }

  /**
   * @param params The `SolarSystemStructureService.PutApiSolarSystemStructureUpdateParams` containing the following parameters:
   *
   * - `mainToken`:
   *
   * - `body`:
   */
  putApiSolarSystemStructureUpdateResponse(params: SolarSystemStructureService.PutApiSolarSystemStructureUpdateParams): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.mainToken != null) __params = __params.set('mainToken', params.mainToken.toString());
    __body = params.body;
    let req = new HttpRequest<any>(
      'PUT',
      this.rootUrl + `/api/SolarSystemStructure/Update`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<null>;
      })
    );
  }
  /**
   * @param params The `SolarSystemStructureService.PutApiSolarSystemStructureUpdateParams` containing the following parameters:
   *
   * - `mainToken`:
   *
   * - `body`:
   */
  putApiSolarSystemStructureUpdate(params: SolarSystemStructureService.PutApiSolarSystemStructureUpdateParams): __Observable<null> {
    return this.putApiSolarSystemStructureUpdateResponse(params).pipe(
      __map(_r => _r.body as null)
    );
  }

  /**
   * @param solarSystemStructureId undefined
   */
  deleteApiSolarSystemStructureResponse(solarSystemStructureId?: number): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (solarSystemStructureId != null) __params = __params.set('solarSystemStructureId', solarSystemStructureId.toString());
    let req = new HttpRequest<any>(
      'DELETE',
      this.rootUrl + `/api/SolarSystemStructure`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<null>;
      })
    );
  }
  /**
   * @param solarSystemStructureId undefined
   */
  deleteApiSolarSystemStructure(solarSystemStructureId?: number): __Observable<null> {
    return this.deleteApiSolarSystemStructureResponse(solarSystemStructureId).pipe(
      __map(_r => _r.body as null)
    );
  }

  /**
   * @param id undefined
   * @return Success
   */
  getApiSolarSystemStructureGetByIdResponse(id?: number): __Observable<__StrictHttpResponse<SolarSystemStructureDto>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (id != null) __params = __params.set('id', id.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/api/SolarSystemStructure/GetById`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<SolarSystemStructureDto>;
      })
    );
  }
  /**
   * @param id undefined
   * @return Success
   */
  getApiSolarSystemStructureGetById(id?: number): __Observable<SolarSystemStructureDto> {
    return this.getApiSolarSystemStructureGetByIdResponse(id).pipe(
      __map(_r => _r.body as SolarSystemStructureDto)
    );
  }

  /**
   * @param params The `SolarSystemStructureService.PostApiSolarSystemStructureInsertBulkParams` containing the following parameters:
   *
   * - `mainToken`:
   *
   * - `body`:
   */
  postApiSolarSystemStructureInsertBulkResponse(params: SolarSystemStructureService.PostApiSolarSystemStructureInsertBulkParams): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.mainToken != null) __params = __params.set('mainToken', params.mainToken.toString());
    __body = params.body;
    let req = new HttpRequest<any>(
      'POST',
      this.rootUrl + `/api/SolarSystemStructure/InsertBulk`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<null>;
      })
    );
  }
  /**
   * @param params The `SolarSystemStructureService.PostApiSolarSystemStructureInsertBulkParams` containing the following parameters:
   *
   * - `mainToken`:
   *
   * - `body`:
   */
  postApiSolarSystemStructureInsertBulk(params: SolarSystemStructureService.PostApiSolarSystemStructureInsertBulkParams): __Observable<null> {
    return this.postApiSolarSystemStructureInsertBulkResponse(params).pipe(
      __map(_r => _r.body as null)
    );
  }
}

module SolarSystemStructureService {

  /**
   * Parameters for postApiSolarSystemStructureInsert
   */
  export interface PostApiSolarSystemStructureInsertParams {
    mainToken?: string;
    body?: SolarSystemStructureDto;
  }

  /**
   * Parameters for putApiSolarSystemStructureUpdate
   */
  export interface PutApiSolarSystemStructureUpdateParams {
    mainToken?: string;
    body?: SolarSystemStructureDto;
  }

  /**
   * Parameters for postApiSolarSystemStructureInsertBulk
   */
  export interface PostApiSolarSystemStructureInsertBulkParams {
    mainToken?: string;
    body?: Array<SolarSystemStructureDto>;
  }
}

export { SolarSystemStructureService }
