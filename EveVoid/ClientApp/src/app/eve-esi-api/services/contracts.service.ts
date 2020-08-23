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
class ContractsService extends __BaseService {
  static readonly getCharactersCharacterIdContractsPath = '/characters/{character_id}/contracts/';
  static readonly getCharactersCharacterIdContractsContractIdBidsPath = '/characters/{character_id}/contracts/{contract_id}/bids/';
  static readonly getCharactersCharacterIdContractsContractIdItemsPath = '/characters/{character_id}/contracts/{contract_id}/items/';
  static readonly getContractsPublicBidsContractIdPath = '/contracts/public/bids/{contract_id}/';
  static readonly getContractsPublicItemsContractIdPath = '/contracts/public/items/{contract_id}/';
  static readonly getContractsPublicRegionIdPath = '/contracts/public/{region_id}/';
  static readonly getCorporationsCorporationIdContractsPath = '/corporations/{corporation_id}/contracts/';
  static readonly getCorporationsCorporationIdContractsContractIdBidsPath = '/corporations/{corporation_id}/contracts/{contract_id}/bids/';
  static readonly getCorporationsCorporationIdContractsContractIdItemsPath = '/corporations/{corporation_id}/contracts/{contract_id}/items/';

  constructor(
    config: __Configuration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * Get contracts
   *
   * Returns contracts available to a character, only if the character is issuer, acceptor or assignee. Only returns contracts no older than 30 days, or if the status is "in_progress".
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/contracts/`
   *
   * Alternate route: `/legacy/characters/{character_id}/contracts/`
   *
   * Alternate route: `/v1/characters/{character_id}/contracts/`
   *
   * ---
   * This route is cached for up to 300 seconds
   * @param params The `ContractsService.GetCharactersCharacterIdContractsParams` containing the following parameters:
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
   * @return A list of contracts
   */
  getCharactersCharacterIdContractsResponse(params: ContractsService.GetCharactersCharacterIdContractsParams): __Observable<__StrictHttpResponse<Array<{acceptor_id: number, assignee_id: number, availability: 'public' | 'personal' | 'corporation' | 'alliance', buyout?: number, collateral?: number, contract_id: number, date_accepted?: string, date_completed?: string, date_expired: string, date_issued: string, days_to_complete?: number, end_location_id?: number, for_corporation: boolean, issuer_corporation_id: number, issuer_id: number, price?: number, reward?: number, start_location_id?: number, status: 'outstanding' | 'in_progress' | 'finished_issuer' | 'finished_contractor' | 'finished' | 'cancelled' | 'rejected' | 'failed' | 'deleted' | 'reversed', title?: string, type: 'unknown' | 'item_exchange' | 'auction' | 'courier' | 'loan', volume?: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.page != null) __params = __params.set('page', params.page.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/contracts/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{acceptor_id: number, assignee_id: number, availability: 'public' | 'personal' | 'corporation' | 'alliance', buyout?: number, collateral?: number, contract_id: number, date_accepted?: string, date_completed?: string, date_expired: string, date_issued: string, days_to_complete?: number, end_location_id?: number, for_corporation: boolean, issuer_corporation_id: number, issuer_id: number, price?: number, reward?: number, start_location_id?: number, status: 'outstanding' | 'in_progress' | 'finished_issuer' | 'finished_contractor' | 'finished' | 'cancelled' | 'rejected' | 'failed' | 'deleted' | 'reversed', title?: string, type: 'unknown' | 'item_exchange' | 'auction' | 'courier' | 'loan', volume?: number}>>;
      })
    );
  }
  /**
   * Get contracts
   *
   * Returns contracts available to a character, only if the character is issuer, acceptor or assignee. Only returns contracts no older than 30 days, or if the status is "in_progress".
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/contracts/`
   *
   * Alternate route: `/legacy/characters/{character_id}/contracts/`
   *
   * Alternate route: `/v1/characters/{character_id}/contracts/`
   *
   * ---
   * This route is cached for up to 300 seconds
   * @param params The `ContractsService.GetCharactersCharacterIdContractsParams` containing the following parameters:
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
   * @return A list of contracts
   */
  getCharactersCharacterIdContracts(params: ContractsService.GetCharactersCharacterIdContractsParams): __Observable<Array<{acceptor_id: number, assignee_id: number, availability: 'public' | 'personal' | 'corporation' | 'alliance', buyout?: number, collateral?: number, contract_id: number, date_accepted?: string, date_completed?: string, date_expired: string, date_issued: string, days_to_complete?: number, end_location_id?: number, for_corporation: boolean, issuer_corporation_id: number, issuer_id: number, price?: number, reward?: number, start_location_id?: number, status: 'outstanding' | 'in_progress' | 'finished_issuer' | 'finished_contractor' | 'finished' | 'cancelled' | 'rejected' | 'failed' | 'deleted' | 'reversed', title?: string, type: 'unknown' | 'item_exchange' | 'auction' | 'courier' | 'loan', volume?: number}>> {
    return this.getCharactersCharacterIdContractsResponse(params).pipe(
      __map(_r => _r.body as Array<{acceptor_id: number, assignee_id: number, availability: 'public' | 'personal' | 'corporation' | 'alliance', buyout?: number, collateral?: number, contract_id: number, date_accepted?: string, date_completed?: string, date_expired: string, date_issued: string, days_to_complete?: number, end_location_id?: number, for_corporation: boolean, issuer_corporation_id: number, issuer_id: number, price?: number, reward?: number, start_location_id?: number, status: 'outstanding' | 'in_progress' | 'finished_issuer' | 'finished_contractor' | 'finished' | 'cancelled' | 'rejected' | 'failed' | 'deleted' | 'reversed', title?: string, type: 'unknown' | 'item_exchange' | 'auction' | 'courier' | 'loan', volume?: number}>)
    );
  }

  /**
   * Get contract bids
   *
   * Lists bids on a particular auction contract
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/contracts/{contract_id}/bids/`
   *
   * Alternate route: `/legacy/characters/{character_id}/contracts/{contract_id}/bids/`
   *
   * Alternate route: `/v1/characters/{character_id}/contracts/{contract_id}/bids/`
   *
   * ---
   * This route is cached for up to 300 seconds
   * @param params The `ContractsService.GetCharactersCharacterIdContractsContractIdBidsParams` containing the following parameters:
   *
   * - `contract_id`: ID of a contract
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of bids
   */
  getCharactersCharacterIdContractsContractIdBidsResponse(params: ContractsService.GetCharactersCharacterIdContractsContractIdBidsParams): __Observable<__StrictHttpResponse<Array<{amount: number, bid_id: number, bidder_id: number, date_bid: string}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;


    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/contracts/${encodeURIComponent(params.contractId)}/bids/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{amount: number, bid_id: number, bidder_id: number, date_bid: string}>>;
      })
    );
  }
  /**
   * Get contract bids
   *
   * Lists bids on a particular auction contract
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/contracts/{contract_id}/bids/`
   *
   * Alternate route: `/legacy/characters/{character_id}/contracts/{contract_id}/bids/`
   *
   * Alternate route: `/v1/characters/{character_id}/contracts/{contract_id}/bids/`
   *
   * ---
   * This route is cached for up to 300 seconds
   * @param params The `ContractsService.GetCharactersCharacterIdContractsContractIdBidsParams` containing the following parameters:
   *
   * - `contract_id`: ID of a contract
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of bids
   */
  getCharactersCharacterIdContractsContractIdBids(params: ContractsService.GetCharactersCharacterIdContractsContractIdBidsParams): __Observable<Array<{amount: number, bid_id: number, bidder_id: number, date_bid: string}>> {
    return this.getCharactersCharacterIdContractsContractIdBidsResponse(params).pipe(
      __map(_r => _r.body as Array<{amount: number, bid_id: number, bidder_id: number, date_bid: string}>)
    );
  }

  /**
   * Get contract items
   *
   * Lists items of a particular contract
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/contracts/{contract_id}/items/`
   *
   * Alternate route: `/legacy/characters/{character_id}/contracts/{contract_id}/items/`
   *
   * Alternate route: `/v1/characters/{character_id}/contracts/{contract_id}/items/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `ContractsService.GetCharactersCharacterIdContractsContractIdItemsParams` containing the following parameters:
   *
   * - `contract_id`: ID of a contract
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of items in this contract
   */
  getCharactersCharacterIdContractsContractIdItemsResponse(params: ContractsService.GetCharactersCharacterIdContractsContractIdItemsParams): __Observable<__StrictHttpResponse<Array<{is_included: boolean, is_singleton: boolean, quantity: number, raw_quantity?: number, record_id: number, type_id: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;


    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/contracts/${encodeURIComponent(params.contractId)}/items/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{is_included: boolean, is_singleton: boolean, quantity: number, raw_quantity?: number, record_id: number, type_id: number}>>;
      })
    );
  }
  /**
   * Get contract items
   *
   * Lists items of a particular contract
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/contracts/{contract_id}/items/`
   *
   * Alternate route: `/legacy/characters/{character_id}/contracts/{contract_id}/items/`
   *
   * Alternate route: `/v1/characters/{character_id}/contracts/{contract_id}/items/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `ContractsService.GetCharactersCharacterIdContractsContractIdItemsParams` containing the following parameters:
   *
   * - `contract_id`: ID of a contract
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of items in this contract
   */
  getCharactersCharacterIdContractsContractIdItems(params: ContractsService.GetCharactersCharacterIdContractsContractIdItemsParams): __Observable<Array<{is_included: boolean, is_singleton: boolean, quantity: number, raw_quantity?: number, record_id: number, type_id: number}>> {
    return this.getCharactersCharacterIdContractsContractIdItemsResponse(params).pipe(
      __map(_r => _r.body as Array<{is_included: boolean, is_singleton: boolean, quantity: number, raw_quantity?: number, record_id: number, type_id: number}>)
    );
  }

  /**
   * Get public contract bids
   *
   * Lists bids on a public auction contract
   *
   * ---
   * Alternate route: `/dev/contracts/public/bids/{contract_id}/`
   *
   * Alternate route: `/legacy/contracts/public/bids/{contract_id}/`
   *
   * Alternate route: `/v1/contracts/public/bids/{contract_id}/`
   *
   * ---
   * This route is cached for up to 300 seconds
   * @param params The `ContractsService.GetContractsPublicBidsContractIdParams` containing the following parameters:
   *
   * - `contract_id`: ID of a contract
   *
   * - `page`: Which page of results to return
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of bids
   */
  getContractsPublicBidsContractIdResponse(params: ContractsService.GetContractsPublicBidsContractIdParams): __Observable<__StrictHttpResponse<Array<{amount: number, bid_id: number, date_bid: string}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.page != null) __params = __params.set('page', params.page.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/contracts/public/bids/${encodeURIComponent(params.contractId)}/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{amount: number, bid_id: number, date_bid: string}>>;
      })
    );
  }
  /**
   * Get public contract bids
   *
   * Lists bids on a public auction contract
   *
   * ---
   * Alternate route: `/dev/contracts/public/bids/{contract_id}/`
   *
   * Alternate route: `/legacy/contracts/public/bids/{contract_id}/`
   *
   * Alternate route: `/v1/contracts/public/bids/{contract_id}/`
   *
   * ---
   * This route is cached for up to 300 seconds
   * @param params The `ContractsService.GetContractsPublicBidsContractIdParams` containing the following parameters:
   *
   * - `contract_id`: ID of a contract
   *
   * - `page`: Which page of results to return
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of bids
   */
  getContractsPublicBidsContractId(params: ContractsService.GetContractsPublicBidsContractIdParams): __Observable<Array<{amount: number, bid_id: number, date_bid: string}>> {
    return this.getContractsPublicBidsContractIdResponse(params).pipe(
      __map(_r => _r.body as Array<{amount: number, bid_id: number, date_bid: string}>)
    );
  }

  /**
   * Get public contract items
   *
   * Lists items of a public contract
   *
   * ---
   * Alternate route: `/dev/contracts/public/items/{contract_id}/`
   *
   * Alternate route: `/legacy/contracts/public/items/{contract_id}/`
   *
   * Alternate route: `/v1/contracts/public/items/{contract_id}/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `ContractsService.GetContractsPublicItemsContractIdParams` containing the following parameters:
   *
   * - `contract_id`: ID of a contract
   *
   * - `page`: Which page of results to return
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of items in this contract
   */
  getContractsPublicItemsContractIdResponse(params: ContractsService.GetContractsPublicItemsContractIdParams): __Observable<__StrictHttpResponse<Array<{is_blueprint_copy?: boolean, is_included: boolean, item_id?: number, material_efficiency?: number, quantity: number, record_id: number, runs?: number, time_efficiency?: number, type_id: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.page != null) __params = __params.set('page', params.page.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/contracts/public/items/${encodeURIComponent(params.contractId)}/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{is_blueprint_copy?: boolean, is_included: boolean, item_id?: number, material_efficiency?: number, quantity: number, record_id: number, runs?: number, time_efficiency?: number, type_id: number}>>;
      })
    );
  }
  /**
   * Get public contract items
   *
   * Lists items of a public contract
   *
   * ---
   * Alternate route: `/dev/contracts/public/items/{contract_id}/`
   *
   * Alternate route: `/legacy/contracts/public/items/{contract_id}/`
   *
   * Alternate route: `/v1/contracts/public/items/{contract_id}/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `ContractsService.GetContractsPublicItemsContractIdParams` containing the following parameters:
   *
   * - `contract_id`: ID of a contract
   *
   * - `page`: Which page of results to return
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of items in this contract
   */
  getContractsPublicItemsContractId(params: ContractsService.GetContractsPublicItemsContractIdParams): __Observable<Array<{is_blueprint_copy?: boolean, is_included: boolean, item_id?: number, material_efficiency?: number, quantity: number, record_id: number, runs?: number, time_efficiency?: number, type_id: number}>> {
    return this.getContractsPublicItemsContractIdResponse(params).pipe(
      __map(_r => _r.body as Array<{is_blueprint_copy?: boolean, is_included: boolean, item_id?: number, material_efficiency?: number, quantity: number, record_id: number, runs?: number, time_efficiency?: number, type_id: number}>)
    );
  }

  /**
   * Get public contracts
   *
   * Returns a paginated list of all public contracts in the given region
   *
   * ---
   * Alternate route: `/dev/contracts/public/{region_id}/`
   *
   * Alternate route: `/legacy/contracts/public/{region_id}/`
   *
   * Alternate route: `/v1/contracts/public/{region_id}/`
   *
   * ---
   * This route is cached for up to 1800 seconds
   * @param params The `ContractsService.GetContractsPublicRegionIdParams` containing the following parameters:
   *
   * - `region_id`: An EVE region id
   *
   * - `page`: Which page of results to return
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of contracts
   */
  getContractsPublicRegionIdResponse(params: ContractsService.GetContractsPublicRegionIdParams): __Observable<__StrictHttpResponse<Array<{buyout?: number, collateral?: number, contract_id: number, date_expired: string, date_issued: string, days_to_complete?: number, end_location_id?: number, for_corporation?: boolean, issuer_corporation_id: number, issuer_id: number, price?: number, reward?: number, start_location_id?: number, title?: string, type: 'unknown' | 'item_exchange' | 'auction' | 'courier' | 'loan', volume?: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.page != null) __params = __params.set('page', params.page.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/contracts/public/${encodeURIComponent(params.regionId)}/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{buyout?: number, collateral?: number, contract_id: number, date_expired: string, date_issued: string, days_to_complete?: number, end_location_id?: number, for_corporation?: boolean, issuer_corporation_id: number, issuer_id: number, price?: number, reward?: number, start_location_id?: number, title?: string, type: 'unknown' | 'item_exchange' | 'auction' | 'courier' | 'loan', volume?: number}>>;
      })
    );
  }
  /**
   * Get public contracts
   *
   * Returns a paginated list of all public contracts in the given region
   *
   * ---
   * Alternate route: `/dev/contracts/public/{region_id}/`
   *
   * Alternate route: `/legacy/contracts/public/{region_id}/`
   *
   * Alternate route: `/v1/contracts/public/{region_id}/`
   *
   * ---
   * This route is cached for up to 1800 seconds
   * @param params The `ContractsService.GetContractsPublicRegionIdParams` containing the following parameters:
   *
   * - `region_id`: An EVE region id
   *
   * - `page`: Which page of results to return
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of contracts
   */
  getContractsPublicRegionId(params: ContractsService.GetContractsPublicRegionIdParams): __Observable<Array<{buyout?: number, collateral?: number, contract_id: number, date_expired: string, date_issued: string, days_to_complete?: number, end_location_id?: number, for_corporation?: boolean, issuer_corporation_id: number, issuer_id: number, price?: number, reward?: number, start_location_id?: number, title?: string, type: 'unknown' | 'item_exchange' | 'auction' | 'courier' | 'loan', volume?: number}>> {
    return this.getContractsPublicRegionIdResponse(params).pipe(
      __map(_r => _r.body as Array<{buyout?: number, collateral?: number, contract_id: number, date_expired: string, date_issued: string, days_to_complete?: number, end_location_id?: number, for_corporation?: boolean, issuer_corporation_id: number, issuer_id: number, price?: number, reward?: number, start_location_id?: number, title?: string, type: 'unknown' | 'item_exchange' | 'auction' | 'courier' | 'loan', volume?: number}>)
    );
  }

  /**
   * Get corporation contracts
   *
   * Returns contracts available to a corporation, only if the corporation is issuer, acceptor or assignee. Only returns contracts no older than 30 days, or if the status is "in_progress".
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/contracts/`
   *
   * Alternate route: `/legacy/corporations/{corporation_id}/contracts/`
   *
   * Alternate route: `/v1/corporations/{corporation_id}/contracts/`
   *
   * ---
   * This route is cached for up to 300 seconds
   * @param params The `ContractsService.GetCorporationsCorporationIdContractsParams` containing the following parameters:
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
   * @return A list of contracts
   */
  getCorporationsCorporationIdContractsResponse(params: ContractsService.GetCorporationsCorporationIdContractsParams): __Observable<__StrictHttpResponse<Array<{acceptor_id: number, assignee_id: number, availability: 'public' | 'personal' | 'corporation' | 'alliance', buyout?: number, collateral?: number, contract_id: number, date_accepted?: string, date_completed?: string, date_expired: string, date_issued: string, days_to_complete?: number, end_location_id?: number, for_corporation: boolean, issuer_corporation_id: number, issuer_id: number, price?: number, reward?: number, start_location_id?: number, status: 'outstanding' | 'in_progress' | 'finished_issuer' | 'finished_contractor' | 'finished' | 'cancelled' | 'rejected' | 'failed' | 'deleted' | 'reversed', title?: string, type: 'unknown' | 'item_exchange' | 'auction' | 'courier' | 'loan', volume?: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.page != null) __params = __params.set('page', params.page.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/corporations/${encodeURIComponent(params.corporationId)}/contracts/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{acceptor_id: number, assignee_id: number, availability: 'public' | 'personal' | 'corporation' | 'alliance', buyout?: number, collateral?: number, contract_id: number, date_accepted?: string, date_completed?: string, date_expired: string, date_issued: string, days_to_complete?: number, end_location_id?: number, for_corporation: boolean, issuer_corporation_id: number, issuer_id: number, price?: number, reward?: number, start_location_id?: number, status: 'outstanding' | 'in_progress' | 'finished_issuer' | 'finished_contractor' | 'finished' | 'cancelled' | 'rejected' | 'failed' | 'deleted' | 'reversed', title?: string, type: 'unknown' | 'item_exchange' | 'auction' | 'courier' | 'loan', volume?: number}>>;
      })
    );
  }
  /**
   * Get corporation contracts
   *
   * Returns contracts available to a corporation, only if the corporation is issuer, acceptor or assignee. Only returns contracts no older than 30 days, or if the status is "in_progress".
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/contracts/`
   *
   * Alternate route: `/legacy/corporations/{corporation_id}/contracts/`
   *
   * Alternate route: `/v1/corporations/{corporation_id}/contracts/`
   *
   * ---
   * This route is cached for up to 300 seconds
   * @param params The `ContractsService.GetCorporationsCorporationIdContractsParams` containing the following parameters:
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
   * @return A list of contracts
   */
  getCorporationsCorporationIdContracts(params: ContractsService.GetCorporationsCorporationIdContractsParams): __Observable<Array<{acceptor_id: number, assignee_id: number, availability: 'public' | 'personal' | 'corporation' | 'alliance', buyout?: number, collateral?: number, contract_id: number, date_accepted?: string, date_completed?: string, date_expired: string, date_issued: string, days_to_complete?: number, end_location_id?: number, for_corporation: boolean, issuer_corporation_id: number, issuer_id: number, price?: number, reward?: number, start_location_id?: number, status: 'outstanding' | 'in_progress' | 'finished_issuer' | 'finished_contractor' | 'finished' | 'cancelled' | 'rejected' | 'failed' | 'deleted' | 'reversed', title?: string, type: 'unknown' | 'item_exchange' | 'auction' | 'courier' | 'loan', volume?: number}>> {
    return this.getCorporationsCorporationIdContractsResponse(params).pipe(
      __map(_r => _r.body as Array<{acceptor_id: number, assignee_id: number, availability: 'public' | 'personal' | 'corporation' | 'alliance', buyout?: number, collateral?: number, contract_id: number, date_accepted?: string, date_completed?: string, date_expired: string, date_issued: string, days_to_complete?: number, end_location_id?: number, for_corporation: boolean, issuer_corporation_id: number, issuer_id: number, price?: number, reward?: number, start_location_id?: number, status: 'outstanding' | 'in_progress' | 'finished_issuer' | 'finished_contractor' | 'finished' | 'cancelled' | 'rejected' | 'failed' | 'deleted' | 'reversed', title?: string, type: 'unknown' | 'item_exchange' | 'auction' | 'courier' | 'loan', volume?: number}>)
    );
  }

  /**
   * Get corporation contract bids
   *
   * Lists bids on a particular auction contract
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/contracts/{contract_id}/bids/`
   *
   * Alternate route: `/legacy/corporations/{corporation_id}/contracts/{contract_id}/bids/`
   *
   * Alternate route: `/v1/corporations/{corporation_id}/contracts/{contract_id}/bids/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `ContractsService.GetCorporationsCorporationIdContractsContractIdBidsParams` containing the following parameters:
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `contract_id`: ID of a contract
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `page`: Which page of results to return
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of bids
   */
  getCorporationsCorporationIdContractsContractIdBidsResponse(params: ContractsService.GetCorporationsCorporationIdContractsContractIdBidsParams): __Observable<__StrictHttpResponse<Array<{amount: number, bid_id: number, bidder_id: number, date_bid: string}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;


    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.page != null) __params = __params.set('page', params.page.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/corporations/${encodeURIComponent(params.corporationId)}/contracts/${encodeURIComponent(params.contractId)}/bids/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{amount: number, bid_id: number, bidder_id: number, date_bid: string}>>;
      })
    );
  }
  /**
   * Get corporation contract bids
   *
   * Lists bids on a particular auction contract
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/contracts/{contract_id}/bids/`
   *
   * Alternate route: `/legacy/corporations/{corporation_id}/contracts/{contract_id}/bids/`
   *
   * Alternate route: `/v1/corporations/{corporation_id}/contracts/{contract_id}/bids/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `ContractsService.GetCorporationsCorporationIdContractsContractIdBidsParams` containing the following parameters:
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `contract_id`: ID of a contract
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `page`: Which page of results to return
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of bids
   */
  getCorporationsCorporationIdContractsContractIdBids(params: ContractsService.GetCorporationsCorporationIdContractsContractIdBidsParams): __Observable<Array<{amount: number, bid_id: number, bidder_id: number, date_bid: string}>> {
    return this.getCorporationsCorporationIdContractsContractIdBidsResponse(params).pipe(
      __map(_r => _r.body as Array<{amount: number, bid_id: number, bidder_id: number, date_bid: string}>)
    );
  }

  /**
   * Get corporation contract items
   *
   * Lists items of a particular contract
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/contracts/{contract_id}/items/`
   *
   * Alternate route: `/legacy/corporations/{corporation_id}/contracts/{contract_id}/items/`
   *
   * Alternate route: `/v1/corporations/{corporation_id}/contracts/{contract_id}/items/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `ContractsService.GetCorporationsCorporationIdContractsContractIdItemsParams` containing the following parameters:
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `contract_id`: ID of a contract
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of items in this contract
   */
  getCorporationsCorporationIdContractsContractIdItemsResponse(params: ContractsService.GetCorporationsCorporationIdContractsContractIdItemsParams): __Observable<__StrictHttpResponse<Array<{is_included: boolean, is_singleton: boolean, quantity: number, raw_quantity?: number, record_id: number, type_id: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;


    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/corporations/${encodeURIComponent(params.corporationId)}/contracts/${encodeURIComponent(params.contractId)}/items/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{is_included: boolean, is_singleton: boolean, quantity: number, raw_quantity?: number, record_id: number, type_id: number}>>;
      })
    );
  }
  /**
   * Get corporation contract items
   *
   * Lists items of a particular contract
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/contracts/{contract_id}/items/`
   *
   * Alternate route: `/legacy/corporations/{corporation_id}/contracts/{contract_id}/items/`
   *
   * Alternate route: `/v1/corporations/{corporation_id}/contracts/{contract_id}/items/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `ContractsService.GetCorporationsCorporationIdContractsContractIdItemsParams` containing the following parameters:
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `contract_id`: ID of a contract
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of items in this contract
   */
  getCorporationsCorporationIdContractsContractIdItems(params: ContractsService.GetCorporationsCorporationIdContractsContractIdItemsParams): __Observable<Array<{is_included: boolean, is_singleton: boolean, quantity: number, raw_quantity?: number, record_id: number, type_id: number}>> {
    return this.getCorporationsCorporationIdContractsContractIdItemsResponse(params).pipe(
      __map(_r => _r.body as Array<{is_included: boolean, is_singleton: boolean, quantity: number, raw_quantity?: number, record_id: number, type_id: number}>)
    );
  }
}

module ContractsService {

  /**
   * Parameters for getCharactersCharacterIdContracts
   */
  export interface GetCharactersCharacterIdContractsParams {

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
   * Parameters for getCharactersCharacterIdContractsContractIdBids
   */
  export interface GetCharactersCharacterIdContractsContractIdBidsParams {

    /**
     * ID of a contract
     */
    contractId: number;

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
   * Parameters for getCharactersCharacterIdContractsContractIdItems
   */
  export interface GetCharactersCharacterIdContractsContractIdItemsParams {

    /**
     * ID of a contract
     */
    contractId: number;

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
   * Parameters for getContractsPublicBidsContractId
   */
  export interface GetContractsPublicBidsContractIdParams {

    /**
     * ID of a contract
     */
    contractId: number;

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
   * Parameters for getContractsPublicItemsContractId
   */
  export interface GetContractsPublicItemsContractIdParams {

    /**
     * ID of a contract
     */
    contractId: number;

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
   * Parameters for getContractsPublicRegionId
   */
  export interface GetContractsPublicRegionIdParams {

    /**
     * An EVE region id
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

  /**
   * Parameters for getCorporationsCorporationIdContracts
   */
  export interface GetCorporationsCorporationIdContractsParams {

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
   * Parameters for getCorporationsCorporationIdContractsContractIdBids
   */
  export interface GetCorporationsCorporationIdContractsContractIdBidsParams {

    /**
     * An EVE corporation ID
     */
    corporationId: number;

    /**
     * ID of a contract
     */
    contractId: number;

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
   * Parameters for getCorporationsCorporationIdContractsContractIdItems
   */
  export interface GetCorporationsCorporationIdContractsContractIdItemsParams {

    /**
     * An EVE corporation ID
     */
    corporationId: number;

    /**
     * ID of a contract
     */
    contractId: number;

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
}

export { ContractsService }
