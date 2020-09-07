/* tslint:disable */
import { Injectable } from '@angular/core';
import { HttpClient, HttpRequest, HttpResponse, HttpHeaders } from '@angular/common/http';
import { BaseService as __BaseService } from '../base-service';
import { ApiConfiguration as __Configuration } from '../api-configuration';
import { StrictHttpResponse as __StrictHttpResponse } from '../strict-http-response';
import { Observable as __Observable } from 'rxjs';
import { map as __map, filter as __filter } from 'rxjs/operators';

import { SignatureDto } from '../models/signature-dto';
import { WormholeTypeDto } from '../models/wormhole-type-dto';
@Injectable({
  providedIn: 'root',
})
class SignatureService extends __BaseService {
  static readonly postApiSignatureInsertSignaturePath = '/api/Signature/InsertSignature';
  static readonly putApiSignatureUpdateSignaturePath = '/api/Signature/UpdateSignature';
  static readonly deleteApiSignaturePath = '/api/Signature';
  static readonly getApiSignatureGetSignatureByIdPath = '/api/Signature/GetSignatureById';
  static readonly getApiSignatureGetPossibleJumpSignaturesPath = '/api/Signature/GetPossibleJumpSignatures';
  static readonly getApiSignatureGetWormholeTypesPath = '/api/Signature/GetWormholeTypes';

  constructor(
    config: __Configuration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * @param params The `SignatureService.PostApiSignatureInsertSignatureParams` containing the following parameters:
   *
   * - `mainToken`:
   *
   * - `body`:
   */
  postApiSignatureInsertSignatureResponse(params: SignatureService.PostApiSignatureInsertSignatureParams): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.mainToken != null) __params = __params.set('mainToken', params.mainToken.toString());
    __body = params.body;
    let req = new HttpRequest<any>(
      'POST',
      this.rootUrl + `/api/Signature/InsertSignature`,
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
   * @param params The `SignatureService.PostApiSignatureInsertSignatureParams` containing the following parameters:
   *
   * - `mainToken`:
   *
   * - `body`:
   */
  postApiSignatureInsertSignature(params: SignatureService.PostApiSignatureInsertSignatureParams): __Observable<null> {
    return this.postApiSignatureInsertSignatureResponse(params).pipe(
      __map(_r => _r.body as null)
    );
  }

  /**
   * @param params The `SignatureService.PutApiSignatureUpdateSignatureParams` containing the following parameters:
   *
   * - `mainToken`:
   *
   * - `body`:
   */
  putApiSignatureUpdateSignatureResponse(params: SignatureService.PutApiSignatureUpdateSignatureParams): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.mainToken != null) __params = __params.set('mainToken', params.mainToken.toString());
    __body = params.body;
    let req = new HttpRequest<any>(
      'PUT',
      this.rootUrl + `/api/Signature/UpdateSignature`,
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
   * @param params The `SignatureService.PutApiSignatureUpdateSignatureParams` containing the following parameters:
   *
   * - `mainToken`:
   *
   * - `body`:
   */
  putApiSignatureUpdateSignature(params: SignatureService.PutApiSignatureUpdateSignatureParams): __Observable<null> {
    return this.putApiSignatureUpdateSignatureResponse(params).pipe(
      __map(_r => _r.body as null)
    );
  }

  /**
   * @param sigId undefined
   */
  deleteApiSignatureResponse(sigId?: number): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (sigId != null) __params = __params.set('sigId', sigId.toString());
    let req = new HttpRequest<any>(
      'DELETE',
      this.rootUrl + `/api/Signature`,
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
   * @param sigId undefined
   */
  deleteApiSignature(sigId?: number): __Observable<null> {
    return this.deleteApiSignatureResponse(sigId).pipe(
      __map(_r => _r.body as null)
    );
  }

  /**
   * @param id undefined
   * @return Success
   */
  getApiSignatureGetSignatureByIdResponse(id?: number): __Observable<__StrictHttpResponse<SignatureDto>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (id != null) __params = __params.set('id', id.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/api/Signature/GetSignatureById`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<SignatureDto>;
      })
    );
  }
  /**
   * @param id undefined
   * @return Success
   */
  getApiSignatureGetSignatureById(id?: number): __Observable<SignatureDto> {
    return this.getApiSignatureGetSignatureByIdResponse(id).pipe(
      __map(_r => _r.body as SignatureDto)
    );
  }

  /**
   * @param params The `SignatureService.GetApiSignatureGetPossibleJumpSignaturesParams` containing the following parameters:
   *
   * - `originId`:
   *
   * - `mainToken`:
   *
   * - `destoId`:
   *
   * @return Success
   */
  getApiSignatureGetPossibleJumpSignaturesResponse(params: SignatureService.GetApiSignatureGetPossibleJumpSignaturesParams): __Observable<__StrictHttpResponse<Array<SignatureDto>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.originId != null) __params = __params.set('originId', params.originId.toString());
    if (params.mainToken != null) __params = __params.set('mainToken', params.mainToken.toString());
    if (params.destoId != null) __params = __params.set('destoId', params.destoId.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/api/Signature/GetPossibleJumpSignatures`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<SignatureDto>>;
      })
    );
  }
  /**
   * @param params The `SignatureService.GetApiSignatureGetPossibleJumpSignaturesParams` containing the following parameters:
   *
   * - `originId`:
   *
   * - `mainToken`:
   *
   * - `destoId`:
   *
   * @return Success
   */
  getApiSignatureGetPossibleJumpSignatures(params: SignatureService.GetApiSignatureGetPossibleJumpSignaturesParams): __Observable<Array<SignatureDto>> {
    return this.getApiSignatureGetPossibleJumpSignaturesResponse(params).pipe(
      __map(_r => _r.body as Array<SignatureDto>)
    );
  }

  /**
   * @return Success
   */
  getApiSignatureGetWormholeTypesResponse(): __Observable<__StrictHttpResponse<Array<WormholeTypeDto>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/api/Signature/GetWormholeTypes`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<WormholeTypeDto>>;
      })
    );
  }
  /**
   * @return Success
   */
  getApiSignatureGetWormholeTypes(): __Observable<Array<WormholeTypeDto>> {
    return this.getApiSignatureGetWormholeTypesResponse().pipe(
      __map(_r => _r.body as Array<WormholeTypeDto>)
    );
  }
}

module SignatureService {

  /**
   * Parameters for postApiSignatureInsertSignature
   */
  export interface PostApiSignatureInsertSignatureParams {
    mainToken?: string;
    body?: SignatureDto;
  }

  /**
   * Parameters for putApiSignatureUpdateSignature
   */
  export interface PutApiSignatureUpdateSignatureParams {
    mainToken?: string;
    body?: SignatureDto;
  }

  /**
   * Parameters for getApiSignatureGetPossibleJumpSignatures
   */
  export interface GetApiSignatureGetPossibleJumpSignaturesParams {
    originId?: number;
    mainToken?: string;
    destoId?: number;
  }
}

export { SignatureService }
