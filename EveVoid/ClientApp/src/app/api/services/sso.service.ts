/* tslint:disable */
import { Injectable } from '@angular/core';
import { HttpClient, HttpRequest, HttpResponse, HttpHeaders } from '@angular/common/http';
import { BaseService as __BaseService } from '../base-service';
import { ApiConfiguration as __Configuration } from '../api-configuration';
import { StrictHttpResponse as __StrictHttpResponse } from '../strict-http-response';
import { Observable as __Observable } from 'rxjs';
import { map as __map, filter as __filter } from 'rxjs/operators';

import { MainLoginDto } from '../models/main-login-dto';
import { EsiLoginDto } from '../models/esi-login-dto';
@Injectable({
  providedIn: 'root',
})
class SSOService extends __BaseService {
  static readonly getApiSSOExchangeCodeForTokenPath = '/api/SSO/ExchangeCodeForToken';
  static readonly postApiSSOConfirmAuthCharIdPath = '/api/SSO/ConfirmAuthCharId';
  static readonly postApiSSOExchangeCodeForTokenEsiPath = '/api/SSO/ExchangeCodeForTokenEsi';

  constructor(
    config: __Configuration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * @param code undefined
   * @return Success
   */
  getApiSSOExchangeCodeForTokenResponse(code?: string): __Observable<__StrictHttpResponse<MainLoginDto>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (code != null) __params = __params.set('code', code.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/api/SSO/ExchangeCodeForToken`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<MainLoginDto>;
      })
    );
  }
  /**
   * @param code undefined
   * @return Success
   */
  getApiSSOExchangeCodeForToken(code?: string): __Observable<MainLoginDto> {
    return this.getApiSSOExchangeCodeForTokenResponse(code).pipe(
      __map(_r => _r.body as MainLoginDto)
    );
  }

  /**
   * @param body undefined
   * @return Success
   */
  postApiSSOConfirmAuthCharIdResponse(body?: MainLoginDto): __Observable<__StrictHttpResponse<boolean>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    __body = body;
    let req = new HttpRequest<any>(
      'POST',
      this.rootUrl + `/api/SSO/ConfirmAuthCharId`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'text'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return (_r as HttpResponse<any>).clone({ body: (_r as HttpResponse<any>).body === 'true' }) as __StrictHttpResponse<boolean>
      })
    );
  }
  /**
   * @param body undefined
   * @return Success
   */
  postApiSSOConfirmAuthCharId(body?: MainLoginDto): __Observable<boolean> {
    return this.postApiSSOConfirmAuthCharIdResponse(body).pipe(
      __map(_r => _r.body as boolean)
    );
  }

  /**
   * @param body undefined
   * @return Success
   */
  postApiSSOExchangeCodeForTokenEsiResponse(body?: EsiLoginDto): __Observable<__StrictHttpResponse<boolean>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    __body = body;
    let req = new HttpRequest<any>(
      'POST',
      this.rootUrl + `/api/SSO/ExchangeCodeForTokenEsi`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'text'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return (_r as HttpResponse<any>).clone({ body: (_r as HttpResponse<any>).body === 'true' }) as __StrictHttpResponse<boolean>
      })
    );
  }
  /**
   * @param body undefined
   * @return Success
   */
  postApiSSOExchangeCodeForTokenEsi(body?: EsiLoginDto): __Observable<boolean> {
    return this.postApiSSOExchangeCodeForTokenEsiResponse(body).pipe(
      __map(_r => _r.body as boolean)
    );
  }
}

module SSOService {
}

export { SSOService }
