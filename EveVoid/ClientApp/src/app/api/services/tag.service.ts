/* tslint:disable */
import { Injectable } from '@angular/core';
import { HttpClient, HttpRequest, HttpResponse, HttpHeaders } from '@angular/common/http';
import { BaseService as __BaseService } from '../base-service';
import { ApiConfiguration as __Configuration } from '../api-configuration';
import { StrictHttpResponse as __StrictHttpResponse } from '../strict-http-response';
import { Observable as __Observable } from 'rxjs';
import { map as __map, filter as __filter } from 'rxjs/operators';

import { SolarSystemTagDto } from '../models/solar-system-tag-dto';
@Injectable({
  providedIn: 'root',
})
class TagService extends __BaseService {
  static readonly postApiTagInsertPath = '/api/Tag/Insert';
  static readonly putApiTagUpdatePath = '/api/Tag/Update';
  static readonly deleteApiTagPath = '/api/Tag';
  static readonly getApiTagGetByIdPath = '/api/Tag/GetById';

  constructor(
    config: __Configuration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * @param params The `TagService.PostApiTagInsertParams` containing the following parameters:
   *
   * - `mainToken`:
   *
   * - `body`:
   */
  postApiTagInsertResponse(params: TagService.PostApiTagInsertParams): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.mainToken != null) __params = __params.set('mainToken', params.mainToken.toString());
    __body = params.body;
    let req = new HttpRequest<any>(
      'POST',
      this.rootUrl + `/api/Tag/Insert`,
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
   * @param params The `TagService.PostApiTagInsertParams` containing the following parameters:
   *
   * - `mainToken`:
   *
   * - `body`:
   */
  postApiTagInsert(params: TagService.PostApiTagInsertParams): __Observable<null> {
    return this.postApiTagInsertResponse(params).pipe(
      __map(_r => _r.body as null)
    );
  }

  /**
   * @param params The `TagService.PutApiTagUpdateParams` containing the following parameters:
   *
   * - `mainToken`:
   *
   * - `body`:
   */
  putApiTagUpdateResponse(params: TagService.PutApiTagUpdateParams): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.mainToken != null) __params = __params.set('mainToken', params.mainToken.toString());
    __body = params.body;
    let req = new HttpRequest<any>(
      'PUT',
      this.rootUrl + `/api/Tag/Update`,
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
   * @param params The `TagService.PutApiTagUpdateParams` containing the following parameters:
   *
   * - `mainToken`:
   *
   * - `body`:
   */
  putApiTagUpdate(params: TagService.PutApiTagUpdateParams): __Observable<null> {
    return this.putApiTagUpdateResponse(params).pipe(
      __map(_r => _r.body as null)
    );
  }

  /**
   * @param tagId undefined
   */
  deleteApiTagResponse(tagId?: number): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (tagId != null) __params = __params.set('tagId', tagId.toString());
    let req = new HttpRequest<any>(
      'DELETE',
      this.rootUrl + `/api/Tag`,
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
   * @param tagId undefined
   */
  deleteApiTag(tagId?: number): __Observable<null> {
    return this.deleteApiTagResponse(tagId).pipe(
      __map(_r => _r.body as null)
    );
  }

  /**
   * @param id undefined
   * @return Success
   */
  getApiTagGetByIdResponse(id?: number): __Observable<__StrictHttpResponse<SolarSystemTagDto>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (id != null) __params = __params.set('id', id.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/api/Tag/GetById`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<SolarSystemTagDto>;
      })
    );
  }
  /**
   * @param id undefined
   * @return Success
   */
  getApiTagGetById(id?: number): __Observable<SolarSystemTagDto> {
    return this.getApiTagGetByIdResponse(id).pipe(
      __map(_r => _r.body as SolarSystemTagDto)
    );
  }
}

module TagService {

  /**
   * Parameters for postApiTagInsert
   */
  export interface PostApiTagInsertParams {
    mainToken?: string;
    body?: SolarSystemTagDto;
  }

  /**
   * Parameters for putApiTagUpdate
   */
  export interface PutApiTagUpdateParams {
    mainToken?: string;
    body?: SolarSystemTagDto;
  }
}

export { TagService }
