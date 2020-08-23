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
class InsuranceService extends __BaseService {
  static readonly getInsurancePricesPath = '/insurance/prices/';

  constructor(
    config: __Configuration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * List insurance levels
   *
   * Return available insurance levels for all ship types
   *
   * ---
   * Alternate route: `/dev/insurance/prices/`
   *
   * Alternate route: `/legacy/insurance/prices/`
   *
   * Alternate route: `/v1/insurance/prices/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `InsuranceService.GetInsurancePricesParams` containing the following parameters:
   *
   * - `language`: Language to use in the response, takes precedence over Accept-Language
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * - `Accept-Language`: Language to use in the response
   *
   * @return A list of insurance levels for all ship types
   */
  getInsurancePricesResponse(params: InsuranceService.GetInsurancePricesParams): __Observable<__StrictHttpResponse<Array<{levels: Array<{cost: number, name: string, payout: number}>, type_id: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.language != null) __params = __params.set('language', params.language.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    if (params.AcceptLanguage != null) __headers = __headers.set('Accept-Language', params.AcceptLanguage.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/insurance/prices/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{levels: Array<{cost: number, name: string, payout: number}>, type_id: number}>>;
      })
    );
  }
  /**
   * List insurance levels
   *
   * Return available insurance levels for all ship types
   *
   * ---
   * Alternate route: `/dev/insurance/prices/`
   *
   * Alternate route: `/legacy/insurance/prices/`
   *
   * Alternate route: `/v1/insurance/prices/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `InsuranceService.GetInsurancePricesParams` containing the following parameters:
   *
   * - `language`: Language to use in the response, takes precedence over Accept-Language
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * - `Accept-Language`: Language to use in the response
   *
   * @return A list of insurance levels for all ship types
   */
  getInsurancePrices(params: InsuranceService.GetInsurancePricesParams): __Observable<Array<{levels: Array<{cost: number, name: string, payout: number}>, type_id: number}>> {
    return this.getInsurancePricesResponse(params).pipe(
      __map(_r => _r.body as Array<{levels: Array<{cost: number, name: string, payout: number}>, type_id: number}>)
    );
  }
}

module InsuranceService {

  /**
   * Parameters for getInsurancePrices
   */
  export interface GetInsurancePricesParams {

    /**
     * Language to use in the response, takes precedence over Accept-Language
     */
    language?: 'de' | 'en-us' | 'fr' | 'ja' | 'ru' | 'zh' | 'ko';

    /**
     * The server name you would like data from
     */
    datasource?: 'tranquility' | 'singularity';

    /**
     * ETag from a previous request. A 304 will be returned if this matches the current ETag
     */
    IfNoneMatch?: string;

    /**
     * Language to use in the response
     */
    AcceptLanguage?: 'de' | 'en-us' | 'fr' | 'ja' | 'ru' | 'zh' | 'ko';
  }
}

export { InsuranceService }
