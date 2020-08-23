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
class LoyaltyService extends __BaseService {
  static readonly getCharactersCharacterIdLoyaltyPointsPath = '/characters/{character_id}/loyalty/points/';
  static readonly getLoyaltyStoresCorporationIdOffersPath = '/loyalty/stores/{corporation_id}/offers/';

  constructor(
    config: __Configuration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * Get loyalty points
   *
   * Return a list of loyalty points for all corporations the character has worked for
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/loyalty/points/`
   *
   * Alternate route: `/legacy/characters/{character_id}/loyalty/points/`
   *
   * Alternate route: `/v1/characters/{character_id}/loyalty/points/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `LoyaltyService.GetCharactersCharacterIdLoyaltyPointsParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of loyalty points
   */
  getCharactersCharacterIdLoyaltyPointsResponse(params: LoyaltyService.GetCharactersCharacterIdLoyaltyPointsParams): __Observable<__StrictHttpResponse<Array<{corporation_id: number, loyalty_points: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/loyalty/points/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{corporation_id: number, loyalty_points: number}>>;
      })
    );
  }
  /**
   * Get loyalty points
   *
   * Return a list of loyalty points for all corporations the character has worked for
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/loyalty/points/`
   *
   * Alternate route: `/legacy/characters/{character_id}/loyalty/points/`
   *
   * Alternate route: `/v1/characters/{character_id}/loyalty/points/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `LoyaltyService.GetCharactersCharacterIdLoyaltyPointsParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of loyalty points
   */
  getCharactersCharacterIdLoyaltyPoints(params: LoyaltyService.GetCharactersCharacterIdLoyaltyPointsParams): __Observable<Array<{corporation_id: number, loyalty_points: number}>> {
    return this.getCharactersCharacterIdLoyaltyPointsResponse(params).pipe(
      __map(_r => _r.body as Array<{corporation_id: number, loyalty_points: number}>)
    );
  }

  /**
   * List loyalty store offers
   *
   * Return a list of offers from a specific corporation's loyalty store
   *
   * ---
   * Alternate route: `/dev/loyalty/stores/{corporation_id}/offers/`
   *
   * Alternate route: `/legacy/loyalty/stores/{corporation_id}/offers/`
   *
   * Alternate route: `/v1/loyalty/stores/{corporation_id}/offers/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `LoyaltyService.GetLoyaltyStoresCorporationIdOffersParams` containing the following parameters:
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of offers
   */
  getLoyaltyStoresCorporationIdOffersResponse(params: LoyaltyService.GetLoyaltyStoresCorporationIdOffersParams): __Observable<__StrictHttpResponse<Array<{ak_cost?: number, isk_cost: number, lp_cost: number, offer_id: number, quantity: number, required_items: Array<{quantity: number, type_id: number}>, type_id: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/loyalty/stores/${encodeURIComponent(params.corporationId)}/offers/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{ak_cost?: number, isk_cost: number, lp_cost: number, offer_id: number, quantity: number, required_items: Array<{quantity: number, type_id: number}>, type_id: number}>>;
      })
    );
  }
  /**
   * List loyalty store offers
   *
   * Return a list of offers from a specific corporation's loyalty store
   *
   * ---
   * Alternate route: `/dev/loyalty/stores/{corporation_id}/offers/`
   *
   * Alternate route: `/legacy/loyalty/stores/{corporation_id}/offers/`
   *
   * Alternate route: `/v1/loyalty/stores/{corporation_id}/offers/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `LoyaltyService.GetLoyaltyStoresCorporationIdOffersParams` containing the following parameters:
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of offers
   */
  getLoyaltyStoresCorporationIdOffers(params: LoyaltyService.GetLoyaltyStoresCorporationIdOffersParams): __Observable<Array<{ak_cost?: number, isk_cost: number, lp_cost: number, offer_id: number, quantity: number, required_items: Array<{quantity: number, type_id: number}>, type_id: number}>> {
    return this.getLoyaltyStoresCorporationIdOffersResponse(params).pipe(
      __map(_r => _r.body as Array<{ak_cost?: number, isk_cost: number, lp_cost: number, offer_id: number, quantity: number, required_items: Array<{quantity: number, type_id: number}>, type_id: number}>)
    );
  }
}

module LoyaltyService {

  /**
   * Parameters for getCharactersCharacterIdLoyaltyPoints
   */
  export interface GetCharactersCharacterIdLoyaltyPointsParams {

    /**
     * An EVE character ID
     */
    characterId: number;

    /**
     * Access token to use if unable to set a header
     */
    token?: string;

    /**
     * The server name you would like data from
     */
    datasource?: 'tranquility' | 'singularity';

    /**
     * ETag from a previous request. A 304 will be returned if this matches the current ETag
     */
    IfNoneMatch?: string;
  }

  /**
   * Parameters for getLoyaltyStoresCorporationIdOffers
   */
  export interface GetLoyaltyStoresCorporationIdOffersParams {

    /**
     * An EVE corporation ID
     */
    corporationId: number;

    /**
     * The server name you would like data from
     */
    datasource?: 'tranquility' | 'singularity';

    /**
     * ETag from a previous request. A 304 will be returned if this matches the current ETag
     */
    IfNoneMatch?: string;
  }
}

export { LoyaltyService }
