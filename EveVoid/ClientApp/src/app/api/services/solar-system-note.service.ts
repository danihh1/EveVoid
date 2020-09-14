/* tslint:disable */
import { Injectable } from '@angular/core';
import { HttpClient, HttpRequest, HttpResponse, HttpHeaders } from '@angular/common/http';
import { BaseService as __BaseService } from '../base-service';
import { ApiConfiguration as __Configuration } from '../api-configuration';
import { StrictHttpResponse as __StrictHttpResponse } from '../strict-http-response';
import { Observable as __Observable } from 'rxjs';
import { map as __map, filter as __filter } from 'rxjs/operators';

import { SolarSystemNoteDto } from '../models/solar-system-note-dto';
@Injectable({
  providedIn: 'root',
})
class SolarSystemNoteService extends __BaseService {
  static readonly postApiSolarSystemNoteInsertPath = '/api/SolarSystemNote/Insert';
  static readonly putApiSolarSystemNoteUpdatePath = '/api/SolarSystemNote/Update';
  static readonly deleteApiSolarSystemNotePath = '/api/SolarSystemNote';
  static readonly getApiSolarSystemNoteGetByIdPath = '/api/SolarSystemNote/GetById';

  constructor(
    config: __Configuration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * @param params The `SolarSystemNoteService.PostApiSolarSystemNoteInsertParams` containing the following parameters:
   *
   * - `mainToken`:
   *
   * - `body`:
   */
  postApiSolarSystemNoteInsertResponse(params: SolarSystemNoteService.PostApiSolarSystemNoteInsertParams): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.mainToken != null) __params = __params.set('mainToken', params.mainToken.toString());
    __body = params.body;
    let req = new HttpRequest<any>(
      'POST',
      this.rootUrl + `/api/SolarSystemNote/Insert`,
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
   * @param params The `SolarSystemNoteService.PostApiSolarSystemNoteInsertParams` containing the following parameters:
   *
   * - `mainToken`:
   *
   * - `body`:
   */
  postApiSolarSystemNoteInsert(params: SolarSystemNoteService.PostApiSolarSystemNoteInsertParams): __Observable<null> {
    return this.postApiSolarSystemNoteInsertResponse(params).pipe(
      __map(_r => _r.body as null)
    );
  }

  /**
   * @param params The `SolarSystemNoteService.PutApiSolarSystemNoteUpdateParams` containing the following parameters:
   *
   * - `mainToken`:
   *
   * - `body`:
   */
  putApiSolarSystemNoteUpdateResponse(params: SolarSystemNoteService.PutApiSolarSystemNoteUpdateParams): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.mainToken != null) __params = __params.set('mainToken', params.mainToken.toString());
    __body = params.body;
    let req = new HttpRequest<any>(
      'PUT',
      this.rootUrl + `/api/SolarSystemNote/Update`,
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
   * @param params The `SolarSystemNoteService.PutApiSolarSystemNoteUpdateParams` containing the following parameters:
   *
   * - `mainToken`:
   *
   * - `body`:
   */
  putApiSolarSystemNoteUpdate(params: SolarSystemNoteService.PutApiSolarSystemNoteUpdateParams): __Observable<null> {
    return this.putApiSolarSystemNoteUpdateResponse(params).pipe(
      __map(_r => _r.body as null)
    );
  }

  /**
   * @param solarSystemNoteId undefined
   */
  deleteApiSolarSystemNoteResponse(solarSystemNoteId?: number): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (solarSystemNoteId != null) __params = __params.set('solarSystemNoteId', solarSystemNoteId.toString());
    let req = new HttpRequest<any>(
      'DELETE',
      this.rootUrl + `/api/SolarSystemNote`,
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
   * @param solarSystemNoteId undefined
   */
  deleteApiSolarSystemNote(solarSystemNoteId?: number): __Observable<null> {
    return this.deleteApiSolarSystemNoteResponse(solarSystemNoteId).pipe(
      __map(_r => _r.body as null)
    );
  }

  /**
   * @param id undefined
   * @return Success
   */
  getApiSolarSystemNoteGetByIdResponse(id?: number): __Observable<__StrictHttpResponse<SolarSystemNoteDto>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (id != null) __params = __params.set('id', id.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/api/SolarSystemNote/GetById`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<SolarSystemNoteDto>;
      })
    );
  }
  /**
   * @param id undefined
   * @return Success
   */
  getApiSolarSystemNoteGetById(id?: number): __Observable<SolarSystemNoteDto> {
    return this.getApiSolarSystemNoteGetByIdResponse(id).pipe(
      __map(_r => _r.body as SolarSystemNoteDto)
    );
  }
}

module SolarSystemNoteService {

  /**
   * Parameters for postApiSolarSystemNoteInsert
   */
  export interface PostApiSolarSystemNoteInsertParams {
    mainToken?: string;
    body?: SolarSystemNoteDto;
  }

  /**
   * Parameters for putApiSolarSystemNoteUpdate
   */
  export interface PutApiSolarSystemNoteUpdateParams {
    mainToken?: string;
    body?: SolarSystemNoteDto;
  }
}

export { SolarSystemNoteService }
