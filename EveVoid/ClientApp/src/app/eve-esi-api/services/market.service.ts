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
class MarketService extends __BaseService {
  static readonly getCharactersCharacterIdOrdersPath = '/characters/{character_id}/orders/';
  static readonly getCharactersCharacterIdOrdersHistoryPath = '/characters/{character_id}/orders/history/';
  static readonly getCorporationsCorporationIdOrdersPath = '/corporations/{corporation_id}/orders/';
  static readonly getCorporationsCorporationIdOrdersHistoryPath = '/corporations/{corporation_id}/orders/history/';
  static readonly getMarketsGroupsPath = '/markets/groups/';
  static readonly getMarketsGroupsMarketGroupIdPath = '/markets/groups/{market_group_id}/';
  static readonly getMarketsPricesPath = '/markets/prices/';
  static readonly getMarketsStructuresStructureIdPath = '/markets/structures/{structure_id}/';
  static readonly getMarketsRegionIdHistoryPath = '/markets/{region_id}/history/';
  static readonly getMarketsRegionIdOrdersPath = '/markets/{region_id}/orders/';
  static readonly getMarketsRegionIdTypesPath = '/markets/{region_id}/types/';

  constructor(
    config: __Configuration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * List open orders from a character
   *
   * List open market orders placed by a character
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/orders/`
   *
   * Alternate route: `/v2/characters/{character_id}/orders/`
   *
   * ---
   * This route is cached for up to 1200 seconds
   * @param params The `MarketService.GetCharactersCharacterIdOrdersParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Open market orders placed by a character
   */
  getCharactersCharacterIdOrdersResponse(params: MarketService.GetCharactersCharacterIdOrdersParams): __Observable<__StrictHttpResponse<Array<{duration: number, escrow?: number, is_buy_order?: boolean, is_corporation: boolean, issued: string, location_id: number, min_volume?: number, order_id: number, price: number, range: '1' | '10' | '2' | '20' | '3' | '30' | '4' | '40' | '5' | 'region' | 'solarsystem' | 'station', region_id: number, type_id: number, volume_remain: number, volume_total: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/orders/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{duration: number, escrow?: number, is_buy_order?: boolean, is_corporation: boolean, issued: string, location_id: number, min_volume?: number, order_id: number, price: number, range: '1' | '10' | '2' | '20' | '3' | '30' | '4' | '40' | '5' | 'region' | 'solarsystem' | 'station', region_id: number, type_id: number, volume_remain: number, volume_total: number}>>;
      })
    );
  }
  /**
   * List open orders from a character
   *
   * List open market orders placed by a character
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/orders/`
   *
   * Alternate route: `/v2/characters/{character_id}/orders/`
   *
   * ---
   * This route is cached for up to 1200 seconds
   * @param params The `MarketService.GetCharactersCharacterIdOrdersParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Open market orders placed by a character
   */
  getCharactersCharacterIdOrders(params: MarketService.GetCharactersCharacterIdOrdersParams): __Observable<Array<{duration: number, escrow?: number, is_buy_order?: boolean, is_corporation: boolean, issued: string, location_id: number, min_volume?: number, order_id: number, price: number, range: '1' | '10' | '2' | '20' | '3' | '30' | '4' | '40' | '5' | 'region' | 'solarsystem' | 'station', region_id: number, type_id: number, volume_remain: number, volume_total: number}>> {
    return this.getCharactersCharacterIdOrdersResponse(params).pipe(
      __map(_r => _r.body as Array<{duration: number, escrow?: number, is_buy_order?: boolean, is_corporation: boolean, issued: string, location_id: number, min_volume?: number, order_id: number, price: number, range: '1' | '10' | '2' | '20' | '3' | '30' | '4' | '40' | '5' | 'region' | 'solarsystem' | 'station', region_id: number, type_id: number, volume_remain: number, volume_total: number}>)
    );
  }

  /**
   * List historical orders by a character
   *
   * List cancelled and expired market orders placed by a character up to 90 days in the past.
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/orders/history/`
   *
   * Alternate route: `/legacy/characters/{character_id}/orders/history/`
   *
   * Alternate route: `/v1/characters/{character_id}/orders/history/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `MarketService.GetCharactersCharacterIdOrdersHistoryParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `page`: Which page of results to return
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Expired and cancelled market orders placed by a character
   */
  getCharactersCharacterIdOrdersHistoryResponse(params: MarketService.GetCharactersCharacterIdOrdersHistoryParams): __Observable<__StrictHttpResponse<Array<{duration: number, escrow?: number, is_buy_order?: boolean, is_corporation: boolean, issued: string, location_id: number, min_volume?: number, order_id: number, price: number, range: '1' | '10' | '2' | '20' | '3' | '30' | '4' | '40' | '5' | 'region' | 'solarsystem' | 'station', region_id: number, state: 'cancelled' | 'expired', type_id: number, volume_remain: number, volume_total: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.page != null) __params = __params.set('page', params.page.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/orders/history/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{duration: number, escrow?: number, is_buy_order?: boolean, is_corporation: boolean, issued: string, location_id: number, min_volume?: number, order_id: number, price: number, range: '1' | '10' | '2' | '20' | '3' | '30' | '4' | '40' | '5' | 'region' | 'solarsystem' | 'station', region_id: number, state: 'cancelled' | 'expired', type_id: number, volume_remain: number, volume_total: number}>>;
      })
    );
  }
  /**
   * List historical orders by a character
   *
   * List cancelled and expired market orders placed by a character up to 90 days in the past.
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/orders/history/`
   *
   * Alternate route: `/legacy/characters/{character_id}/orders/history/`
   *
   * Alternate route: `/v1/characters/{character_id}/orders/history/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `MarketService.GetCharactersCharacterIdOrdersHistoryParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `page`: Which page of results to return
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Expired and cancelled market orders placed by a character
   */
  getCharactersCharacterIdOrdersHistory(params: MarketService.GetCharactersCharacterIdOrdersHistoryParams): __Observable<Array<{duration: number, escrow?: number, is_buy_order?: boolean, is_corporation: boolean, issued: string, location_id: number, min_volume?: number, order_id: number, price: number, range: '1' | '10' | '2' | '20' | '3' | '30' | '4' | '40' | '5' | 'region' | 'solarsystem' | 'station', region_id: number, state: 'cancelled' | 'expired', type_id: number, volume_remain: number, volume_total: number}>> {
    return this.getCharactersCharacterIdOrdersHistoryResponse(params).pipe(
      __map(_r => _r.body as Array<{duration: number, escrow?: number, is_buy_order?: boolean, is_corporation: boolean, issued: string, location_id: number, min_volume?: number, order_id: number, price: number, range: '1' | '10' | '2' | '20' | '3' | '30' | '4' | '40' | '5' | 'region' | 'solarsystem' | 'station', region_id: number, state: 'cancelled' | 'expired', type_id: number, volume_remain: number, volume_total: number}>)
    );
  }

  /**
   * List open orders from a corporation
   *
   * List open market orders placed on behalf of a corporation
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/orders/`
   *
   * Alternate route: `/v3/corporations/{corporation_id}/orders/`
   *
   * ---
   * This route is cached for up to 1200 seconds
   *
   * ---
   * Requires one of the following EVE corporation role(s): Accountant, Trader
   * @param params The `MarketService.GetCorporationsCorporationIdOrdersParams` containing the following parameters:
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `page`: Which page of results to return
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of open market orders
   */
  getCorporationsCorporationIdOrdersResponse(params: MarketService.GetCorporationsCorporationIdOrdersParams): __Observable<__StrictHttpResponse<Array<{duration: number, escrow?: number, is_buy_order?: boolean, issued: string, issued_by: number, location_id: number, min_volume?: number, order_id: number, price: number, range: '1' | '10' | '2' | '20' | '3' | '30' | '4' | '40' | '5' | 'region' | 'solarsystem' | 'station', region_id: number, type_id: number, volume_remain: number, volume_total: number, wallet_division: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.page != null) __params = __params.set('page', params.page.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/corporations/${encodeURIComponent(params.corporationId)}/orders/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{duration: number, escrow?: number, is_buy_order?: boolean, issued: string, issued_by: number, location_id: number, min_volume?: number, order_id: number, price: number, range: '1' | '10' | '2' | '20' | '3' | '30' | '4' | '40' | '5' | 'region' | 'solarsystem' | 'station', region_id: number, type_id: number, volume_remain: number, volume_total: number, wallet_division: number}>>;
      })
    );
  }
  /**
   * List open orders from a corporation
   *
   * List open market orders placed on behalf of a corporation
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/orders/`
   *
   * Alternate route: `/v3/corporations/{corporation_id}/orders/`
   *
   * ---
   * This route is cached for up to 1200 seconds
   *
   * ---
   * Requires one of the following EVE corporation role(s): Accountant, Trader
   * @param params The `MarketService.GetCorporationsCorporationIdOrdersParams` containing the following parameters:
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `page`: Which page of results to return
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of open market orders
   */
  getCorporationsCorporationIdOrders(params: MarketService.GetCorporationsCorporationIdOrdersParams): __Observable<Array<{duration: number, escrow?: number, is_buy_order?: boolean, issued: string, issued_by: number, location_id: number, min_volume?: number, order_id: number, price: number, range: '1' | '10' | '2' | '20' | '3' | '30' | '4' | '40' | '5' | 'region' | 'solarsystem' | 'station', region_id: number, type_id: number, volume_remain: number, volume_total: number, wallet_division: number}>> {
    return this.getCorporationsCorporationIdOrdersResponse(params).pipe(
      __map(_r => _r.body as Array<{duration: number, escrow?: number, is_buy_order?: boolean, issued: string, issued_by: number, location_id: number, min_volume?: number, order_id: number, price: number, range: '1' | '10' | '2' | '20' | '3' | '30' | '4' | '40' | '5' | 'region' | 'solarsystem' | 'station', region_id: number, type_id: number, volume_remain: number, volume_total: number, wallet_division: number}>)
    );
  }

  /**
   * List historical orders from a corporation
   *
   * List cancelled and expired market orders placed on behalf of a corporation up to 90 days in the past.
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/orders/history/`
   *
   * Alternate route: `/v2/corporations/{corporation_id}/orders/history/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   *
   * ---
   * Requires one of the following EVE corporation role(s): Accountant, Trader
   * @param params The `MarketService.GetCorporationsCorporationIdOrdersHistoryParams` containing the following parameters:
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `page`: Which page of results to return
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Expired and cancelled market orders placed on behalf of a corporation
   */
  getCorporationsCorporationIdOrdersHistoryResponse(params: MarketService.GetCorporationsCorporationIdOrdersHistoryParams): __Observable<__StrictHttpResponse<Array<{duration: number, escrow?: number, is_buy_order?: boolean, issued: string, issued_by?: number, location_id: number, min_volume?: number, order_id: number, price: number, range: '1' | '10' | '2' | '20' | '3' | '30' | '4' | '40' | '5' | 'region' | 'solarsystem' | 'station', region_id: number, state: 'cancelled' | 'expired', type_id: number, volume_remain: number, volume_total: number, wallet_division: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.page != null) __params = __params.set('page', params.page.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/corporations/${encodeURIComponent(params.corporationId)}/orders/history/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{duration: number, escrow?: number, is_buy_order?: boolean, issued: string, issued_by?: number, location_id: number, min_volume?: number, order_id: number, price: number, range: '1' | '10' | '2' | '20' | '3' | '30' | '4' | '40' | '5' | 'region' | 'solarsystem' | 'station', region_id: number, state: 'cancelled' | 'expired', type_id: number, volume_remain: number, volume_total: number, wallet_division: number}>>;
      })
    );
  }
  /**
   * List historical orders from a corporation
   *
   * List cancelled and expired market orders placed on behalf of a corporation up to 90 days in the past.
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/orders/history/`
   *
   * Alternate route: `/v2/corporations/{corporation_id}/orders/history/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   *
   * ---
   * Requires one of the following EVE corporation role(s): Accountant, Trader
   * @param params The `MarketService.GetCorporationsCorporationIdOrdersHistoryParams` containing the following parameters:
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `page`: Which page of results to return
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Expired and cancelled market orders placed on behalf of a corporation
   */
  getCorporationsCorporationIdOrdersHistory(params: MarketService.GetCorporationsCorporationIdOrdersHistoryParams): __Observable<Array<{duration: number, escrow?: number, is_buy_order?: boolean, issued: string, issued_by?: number, location_id: number, min_volume?: number, order_id: number, price: number, range: '1' | '10' | '2' | '20' | '3' | '30' | '4' | '40' | '5' | 'region' | 'solarsystem' | 'station', region_id: number, state: 'cancelled' | 'expired', type_id: number, volume_remain: number, volume_total: number, wallet_division: number}>> {
    return this.getCorporationsCorporationIdOrdersHistoryResponse(params).pipe(
      __map(_r => _r.body as Array<{duration: number, escrow?: number, is_buy_order?: boolean, issued: string, issued_by?: number, location_id: number, min_volume?: number, order_id: number, price: number, range: '1' | '10' | '2' | '20' | '3' | '30' | '4' | '40' | '5' | 'region' | 'solarsystem' | 'station', region_id: number, state: 'cancelled' | 'expired', type_id: number, volume_remain: number, volume_total: number, wallet_division: number}>)
    );
  }

  /**
   * Get item groups
   *
   * Get a list of item groups
   *
   * ---
   * Alternate route: `/dev/markets/groups/`
   *
   * Alternate route: `/legacy/markets/groups/`
   *
   * Alternate route: `/v1/markets/groups/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `MarketService.GetMarketsGroupsParams` containing the following parameters:
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of item group ids
   */
  getMarketsGroupsResponse(params: MarketService.GetMarketsGroupsParams): __Observable<__StrictHttpResponse<Array<number>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/markets/groups/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<number>>;
      })
    );
  }
  /**
   * Get item groups
   *
   * Get a list of item groups
   *
   * ---
   * Alternate route: `/dev/markets/groups/`
   *
   * Alternate route: `/legacy/markets/groups/`
   *
   * Alternate route: `/v1/markets/groups/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `MarketService.GetMarketsGroupsParams` containing the following parameters:
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of item group ids
   */
  getMarketsGroups(params: MarketService.GetMarketsGroupsParams): __Observable<Array<number>> {
    return this.getMarketsGroupsResponse(params).pipe(
      __map(_r => _r.body as Array<number>)
    );
  }

  /**
   * Get item group information
   *
   * Get information on an item group
   *
   * ---
   * Alternate route: `/dev/markets/groups/{market_group_id}/`
   *
   * Alternate route: `/legacy/markets/groups/{market_group_id}/`
   *
   * Alternate route: `/v1/markets/groups/{market_group_id}/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `MarketService.GetMarketsGroupsMarketGroupIdParams` containing the following parameters:
   *
   * - `market_group_id`: An Eve item group ID
   *
   * - `language`: Language to use in the response, takes precedence over Accept-Language
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * - `Accept-Language`: Language to use in the response
   *
   * @return Information about an item group
   */
  getMarketsGroupsMarketGroupIdResponse(params: MarketService.GetMarketsGroupsMarketGroupIdParams): __Observable<__StrictHttpResponse<{description: string, market_group_id: number, name: string, parent_group_id?: number, types: Array<number>}>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.language != null) __params = __params.set('language', params.language.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    if (params.AcceptLanguage != null) __headers = __headers.set('Accept-Language', params.AcceptLanguage.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/markets/groups/${encodeURIComponent(params.marketGroupId)}/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<{description: string, market_group_id: number, name: string, parent_group_id?: number, types: Array<number>}>;
      })
    );
  }
  /**
   * Get item group information
   *
   * Get information on an item group
   *
   * ---
   * Alternate route: `/dev/markets/groups/{market_group_id}/`
   *
   * Alternate route: `/legacy/markets/groups/{market_group_id}/`
   *
   * Alternate route: `/v1/markets/groups/{market_group_id}/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `MarketService.GetMarketsGroupsMarketGroupIdParams` containing the following parameters:
   *
   * - `market_group_id`: An Eve item group ID
   *
   * - `language`: Language to use in the response, takes precedence over Accept-Language
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * - `Accept-Language`: Language to use in the response
   *
   * @return Information about an item group
   */
  getMarketsGroupsMarketGroupId(params: MarketService.GetMarketsGroupsMarketGroupIdParams): __Observable<{description: string, market_group_id: number, name: string, parent_group_id?: number, types: Array<number>}> {
    return this.getMarketsGroupsMarketGroupIdResponse(params).pipe(
      __map(_r => _r.body as {description: string, market_group_id: number, name: string, parent_group_id?: number, types: Array<number>})
    );
  }

  /**
   * List market prices
   *
   * Return a list of prices
   *
   * ---
   * Alternate route: `/dev/markets/prices/`
   *
   * Alternate route: `/legacy/markets/prices/`
   *
   * Alternate route: `/v1/markets/prices/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `MarketService.GetMarketsPricesParams` containing the following parameters:
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of prices
   */
  getMarketsPricesResponse(params: MarketService.GetMarketsPricesParams): __Observable<__StrictHttpResponse<Array<{adjusted_price?: number, average_price?: number, type_id: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/markets/prices/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{adjusted_price?: number, average_price?: number, type_id: number}>>;
      })
    );
  }
  /**
   * List market prices
   *
   * Return a list of prices
   *
   * ---
   * Alternate route: `/dev/markets/prices/`
   *
   * Alternate route: `/legacy/markets/prices/`
   *
   * Alternate route: `/v1/markets/prices/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `MarketService.GetMarketsPricesParams` containing the following parameters:
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of prices
   */
  getMarketsPrices(params: MarketService.GetMarketsPricesParams): __Observable<Array<{adjusted_price?: number, average_price?: number, type_id: number}>> {
    return this.getMarketsPricesResponse(params).pipe(
      __map(_r => _r.body as Array<{adjusted_price?: number, average_price?: number, type_id: number}>)
    );
  }

  /**
   * List orders in a structure
   *
   * Return all orders in a structure
   *
   * ---
   * Alternate route: `/dev/markets/structures/{structure_id}/`
   *
   * Alternate route: `/legacy/markets/structures/{structure_id}/`
   *
   * Alternate route: `/v1/markets/structures/{structure_id}/`
   *
   * ---
   * This route is cached for up to 300 seconds
   * @param params The `MarketService.GetMarketsStructuresStructureIdParams` containing the following parameters:
   *
   * - `structure_id`: Return orders in this structure
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `page`: Which page of results to return
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of orders
   */
  getMarketsStructuresStructureIdResponse(params: MarketService.GetMarketsStructuresStructureIdParams): __Observable<__StrictHttpResponse<Array<{duration: number, is_buy_order: boolean, issued: string, location_id: number, min_volume: number, order_id: number, price: number, range: 'station' | 'region' | 'solarsystem' | '1' | '2' | '3' | '4' | '5' | '10' | '20' | '30' | '40', type_id: number, volume_remain: number, volume_total: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.page != null) __params = __params.set('page', params.page.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/markets/structures/${encodeURIComponent(params.structureId)}/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{duration: number, is_buy_order: boolean, issued: string, location_id: number, min_volume: number, order_id: number, price: number, range: 'station' | 'region' | 'solarsystem' | '1' | '2' | '3' | '4' | '5' | '10' | '20' | '30' | '40', type_id: number, volume_remain: number, volume_total: number}>>;
      })
    );
  }
  /**
   * List orders in a structure
   *
   * Return all orders in a structure
   *
   * ---
   * Alternate route: `/dev/markets/structures/{structure_id}/`
   *
   * Alternate route: `/legacy/markets/structures/{structure_id}/`
   *
   * Alternate route: `/v1/markets/structures/{structure_id}/`
   *
   * ---
   * This route is cached for up to 300 seconds
   * @param params The `MarketService.GetMarketsStructuresStructureIdParams` containing the following parameters:
   *
   * - `structure_id`: Return orders in this structure
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `page`: Which page of results to return
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of orders
   */
  getMarketsStructuresStructureId(params: MarketService.GetMarketsStructuresStructureIdParams): __Observable<Array<{duration: number, is_buy_order: boolean, issued: string, location_id: number, min_volume: number, order_id: number, price: number, range: 'station' | 'region' | 'solarsystem' | '1' | '2' | '3' | '4' | '5' | '10' | '20' | '30' | '40', type_id: number, volume_remain: number, volume_total: number}>> {
    return this.getMarketsStructuresStructureIdResponse(params).pipe(
      __map(_r => _r.body as Array<{duration: number, is_buy_order: boolean, issued: string, location_id: number, min_volume: number, order_id: number, price: number, range: 'station' | 'region' | 'solarsystem' | '1' | '2' | '3' | '4' | '5' | '10' | '20' | '30' | '40', type_id: number, volume_remain: number, volume_total: number}>)
    );
  }

  /**
   * List historical market statistics in a region
   *
   * Return a list of historical market statistics for the specified type in a region
   *
   * ---
   * Alternate route: `/dev/markets/{region_id}/history/`
   *
   * Alternate route: `/legacy/markets/{region_id}/history/`
   *
   * Alternate route: `/v1/markets/{region_id}/history/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `MarketService.GetMarketsRegionIdHistoryParams` containing the following parameters:
   *
   * - `type_id`: Return statistics for this type
   *
   * - `region_id`: Return statistics in this region
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of historical market statistics
   */
  getMarketsRegionIdHistoryResponse(params: MarketService.GetMarketsRegionIdHistoryParams): __Observable<__StrictHttpResponse<Array<{average: number, date: string, highest: number, lowest: number, order_count: number, volume: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.typeId != null) __params = __params.set('type_id', params.typeId.toString());

    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/markets/${encodeURIComponent(params.regionId)}/history/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{average: number, date: string, highest: number, lowest: number, order_count: number, volume: number}>>;
      })
    );
  }
  /**
   * List historical market statistics in a region
   *
   * Return a list of historical market statistics for the specified type in a region
   *
   * ---
   * Alternate route: `/dev/markets/{region_id}/history/`
   *
   * Alternate route: `/legacy/markets/{region_id}/history/`
   *
   * Alternate route: `/v1/markets/{region_id}/history/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `MarketService.GetMarketsRegionIdHistoryParams` containing the following parameters:
   *
   * - `type_id`: Return statistics for this type
   *
   * - `region_id`: Return statistics in this region
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of historical market statistics
   */
  getMarketsRegionIdHistory(params: MarketService.GetMarketsRegionIdHistoryParams): __Observable<Array<{average: number, date: string, highest: number, lowest: number, order_count: number, volume: number}>> {
    return this.getMarketsRegionIdHistoryResponse(params).pipe(
      __map(_r => _r.body as Array<{average: number, date: string, highest: number, lowest: number, order_count: number, volume: number}>)
    );
  }

  /**
   * List orders in a region
   *
   * Return a list of orders in a region
   *
   * ---
   * Alternate route: `/dev/markets/{region_id}/orders/`
   *
   * Alternate route: `/legacy/markets/{region_id}/orders/`
   *
   * Alternate route: `/v1/markets/{region_id}/orders/`
   *
   * ---
   * This route is cached for up to 300 seconds
   * @param params The `MarketService.GetMarketsRegionIdOrdersParams` containing the following parameters:
   *
   * - `region_id`: Return orders in this region
   *
   * - `order_type`: Filter buy/sell orders, return all orders by default. If you query without type_id, we always return both buy and sell orders
   *
   * - `type_id`: Return orders only for this type
   *
   * - `page`: Which page of results to return
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of orders
   */
  getMarketsRegionIdOrdersResponse(params: MarketService.GetMarketsRegionIdOrdersParams): __Observable<__StrictHttpResponse<Array<{duration: number, is_buy_order: boolean, issued: string, location_id: number, min_volume: number, order_id: number, price: number, range: 'station' | 'region' | 'solarsystem' | '1' | '2' | '3' | '4' | '5' | '10' | '20' | '30' | '40', system_id: number, type_id: number, volume_remain: number, volume_total: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.orderType != null) __params = __params.set('order_type', params.orderType.toString());
    if (params.typeId != null) __params = __params.set('type_id', params.typeId.toString());
    if (params.page != null) __params = __params.set('page', params.page.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/markets/${encodeURIComponent(params.regionId)}/orders/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{duration: number, is_buy_order: boolean, issued: string, location_id: number, min_volume: number, order_id: number, price: number, range: 'station' | 'region' | 'solarsystem' | '1' | '2' | '3' | '4' | '5' | '10' | '20' | '30' | '40', system_id: number, type_id: number, volume_remain: number, volume_total: number}>>;
      })
    );
  }
  /**
   * List orders in a region
   *
   * Return a list of orders in a region
   *
   * ---
   * Alternate route: `/dev/markets/{region_id}/orders/`
   *
   * Alternate route: `/legacy/markets/{region_id}/orders/`
   *
   * Alternate route: `/v1/markets/{region_id}/orders/`
   *
   * ---
   * This route is cached for up to 300 seconds
   * @param params The `MarketService.GetMarketsRegionIdOrdersParams` containing the following parameters:
   *
   * - `region_id`: Return orders in this region
   *
   * - `order_type`: Filter buy/sell orders, return all orders by default. If you query without type_id, we always return both buy and sell orders
   *
   * - `type_id`: Return orders only for this type
   *
   * - `page`: Which page of results to return
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of orders
   */
  getMarketsRegionIdOrders(params: MarketService.GetMarketsRegionIdOrdersParams): __Observable<Array<{duration: number, is_buy_order: boolean, issued: string, location_id: number, min_volume: number, order_id: number, price: number, range: 'station' | 'region' | 'solarsystem' | '1' | '2' | '3' | '4' | '5' | '10' | '20' | '30' | '40', system_id: number, type_id: number, volume_remain: number, volume_total: number}>> {
    return this.getMarketsRegionIdOrdersResponse(params).pipe(
      __map(_r => _r.body as Array<{duration: number, is_buy_order: boolean, issued: string, location_id: number, min_volume: number, order_id: number, price: number, range: 'station' | 'region' | 'solarsystem' | '1' | '2' | '3' | '4' | '5' | '10' | '20' | '30' | '40', system_id: number, type_id: number, volume_remain: number, volume_total: number}>)
    );
  }

  /**
   * List type IDs relevant to a market
   *
   * Return a list of type IDs that have active orders in the region, for efficient market indexing.
   *
   * ---
   * Alternate route: `/dev/markets/{region_id}/types/`
   *
   * Alternate route: `/legacy/markets/{region_id}/types/`
   *
   * Alternate route: `/v1/markets/{region_id}/types/`
   *
   * ---
   * This route is cached for up to 600 seconds
   * @param params The `MarketService.GetMarketsRegionIdTypesParams` containing the following parameters:
   *
   * - `region_id`: Return statistics in this region
   *
   * - `page`: Which page of results to return
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of type IDs
   */
  getMarketsRegionIdTypesResponse(params: MarketService.GetMarketsRegionIdTypesParams): __Observable<__StrictHttpResponse<Array<number>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.page != null) __params = __params.set('page', params.page.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/markets/${encodeURIComponent(params.regionId)}/types/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<number>>;
      })
    );
  }
  /**
   * List type IDs relevant to a market
   *
   * Return a list of type IDs that have active orders in the region, for efficient market indexing.
   *
   * ---
   * Alternate route: `/dev/markets/{region_id}/types/`
   *
   * Alternate route: `/legacy/markets/{region_id}/types/`
   *
   * Alternate route: `/v1/markets/{region_id}/types/`
   *
   * ---
   * This route is cached for up to 600 seconds
   * @param params The `MarketService.GetMarketsRegionIdTypesParams` containing the following parameters:
   *
   * - `region_id`: Return statistics in this region
   *
   * - `page`: Which page of results to return
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of type IDs
   */
  getMarketsRegionIdTypes(params: MarketService.GetMarketsRegionIdTypesParams): __Observable<Array<number>> {
    return this.getMarketsRegionIdTypesResponse(params).pipe(
      __map(_r => _r.body as Array<number>)
    );
  }
}

module MarketService {

  /**
   * Parameters for getCharactersCharacterIdOrders
   */
  export interface GetCharactersCharacterIdOrdersParams {

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
   * Parameters for getCharactersCharacterIdOrdersHistory
   */
  export interface GetCharactersCharacterIdOrdersHistoryParams {

    /**
     * An EVE character ID
     */
    characterId: number;

    /**
     * Access token to use if unable to set a header
     */
    token?: string;

    /**
     * Which page of results to return
     */
    page?: number;

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
   * Parameters for getCorporationsCorporationIdOrders
   */
  export interface GetCorporationsCorporationIdOrdersParams {

    /**
     * An EVE corporation ID
     */
    corporationId: number;

    /**
     * Access token to use if unable to set a header
     */
    token?: string;

    /**
     * Which page of results to return
     */
    page?: number;

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
   * Parameters for getCorporationsCorporationIdOrdersHistory
   */
  export interface GetCorporationsCorporationIdOrdersHistoryParams {

    /**
     * An EVE corporation ID
     */
    corporationId: number;

    /**
     * Access token to use if unable to set a header
     */
    token?: string;

    /**
     * Which page of results to return
     */
    page?: number;

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
   * Parameters for getMarketsGroups
   */
  export interface GetMarketsGroupsParams {

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
   * Parameters for getMarketsGroupsMarketGroupId
   */
  export interface GetMarketsGroupsMarketGroupIdParams {

    /**
     * An Eve item group ID
     */
    marketGroupId: number;

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

  /**
   * Parameters for getMarketsPrices
   */
  export interface GetMarketsPricesParams {

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
   * Parameters for getMarketsStructuresStructureId
   */
  export interface GetMarketsStructuresStructureIdParams {

    /**
     * Return orders in this structure
     */
    structureId: number;

    /**
     * Access token to use if unable to set a header
     */
    token?: string;

    /**
     * Which page of results to return
     */
    page?: number;

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
   * Parameters for getMarketsRegionIdHistory
   */
  export interface GetMarketsRegionIdHistoryParams {

    /**
     * Return statistics for this type
     */
    typeId: number;

    /**
     * Return statistics in this region
     */
    regionId: number;

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
   * Parameters for getMarketsRegionIdOrders
   */
  export interface GetMarketsRegionIdOrdersParams {

    /**
     * Return orders in this region
     */
    regionId: number;

    /**
     * Filter buy/sell orders, return all orders by default. If you query without type_id, we always return both buy and sell orders
     */
    orderType: 'buy' | 'sell' | 'all';

    /**
     * Return orders only for this type
     */
    typeId?: number;

    /**
     * Which page of results to return
     */
    page?: number;

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
   * Parameters for getMarketsRegionIdTypes
   */
  export interface GetMarketsRegionIdTypesParams {

    /**
     * Return statistics in this region
     */
    regionId: number;

    /**
     * Which page of results to return
     */
    page?: number;

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

export { MarketService }
