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
class KillmailsService extends __BaseService {
  static readonly getCharactersCharacterIdKillmailsRecentPath = '/characters/{character_id}/killmails/recent/';
  static readonly getCorporationsCorporationIdKillmailsRecentPath = '/corporations/{corporation_id}/killmails/recent/';
  static readonly getKillmailsKillmailIdKillmailHashPath = '/killmails/{killmail_id}/{killmail_hash}/';

  constructor(
    config: __Configuration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * Get a character's recent kills and losses
   *
   * Return a list of a character's kills and losses going back 90 days
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/killmails/recent/`
   *
   * Alternate route: `/legacy/characters/{character_id}/killmails/recent/`
   *
   * Alternate route: `/v1/characters/{character_id}/killmails/recent/`
   *
   * ---
   * This route is cached for up to 300 seconds
   * @param params The `KillmailsService.GetCharactersCharacterIdKillmailsRecentParams` containing the following parameters:
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
   * @return A list of killmail IDs and hashes
   */
  getCharactersCharacterIdKillmailsRecentResponse(params: KillmailsService.GetCharactersCharacterIdKillmailsRecentParams): __Observable<__StrictHttpResponse<Array<{killmail_hash: string, killmail_id: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.page != null) __params = __params.set('page', params.page.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/killmails/recent/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{killmail_hash: string, killmail_id: number}>>;
      })
    );
  }
  /**
   * Get a character's recent kills and losses
   *
   * Return a list of a character's kills and losses going back 90 days
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/killmails/recent/`
   *
   * Alternate route: `/legacy/characters/{character_id}/killmails/recent/`
   *
   * Alternate route: `/v1/characters/{character_id}/killmails/recent/`
   *
   * ---
   * This route is cached for up to 300 seconds
   * @param params The `KillmailsService.GetCharactersCharacterIdKillmailsRecentParams` containing the following parameters:
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
   * @return A list of killmail IDs and hashes
   */
  getCharactersCharacterIdKillmailsRecent(params: KillmailsService.GetCharactersCharacterIdKillmailsRecentParams): __Observable<Array<{killmail_hash: string, killmail_id: number}>> {
    return this.getCharactersCharacterIdKillmailsRecentResponse(params).pipe(
      __map(_r => _r.body as Array<{killmail_hash: string, killmail_id: number}>)
    );
  }

  /**
   * Get a corporation's recent kills and losses
   *
   * Get a list of a corporation's kills and losses going back 90 days
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/killmails/recent/`
   *
   * Alternate route: `/legacy/corporations/{corporation_id}/killmails/recent/`
   *
   * Alternate route: `/v1/corporations/{corporation_id}/killmails/recent/`
   *
   * ---
   * This route is cached for up to 300 seconds
   *
   * ---
   * Requires one of the following EVE corporation role(s): Director
   * @param params The `KillmailsService.GetCorporationsCorporationIdKillmailsRecentParams` containing the following parameters:
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
   * @return A list of killmail IDs and hashes
   */
  getCorporationsCorporationIdKillmailsRecentResponse(params: KillmailsService.GetCorporationsCorporationIdKillmailsRecentParams): __Observable<__StrictHttpResponse<Array<{killmail_hash: string, killmail_id: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.page != null) __params = __params.set('page', params.page.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/corporations/${encodeURIComponent(params.corporationId)}/killmails/recent/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{killmail_hash: string, killmail_id: number}>>;
      })
    );
  }
  /**
   * Get a corporation's recent kills and losses
   *
   * Get a list of a corporation's kills and losses going back 90 days
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/killmails/recent/`
   *
   * Alternate route: `/legacy/corporations/{corporation_id}/killmails/recent/`
   *
   * Alternate route: `/v1/corporations/{corporation_id}/killmails/recent/`
   *
   * ---
   * This route is cached for up to 300 seconds
   *
   * ---
   * Requires one of the following EVE corporation role(s): Director
   * @param params The `KillmailsService.GetCorporationsCorporationIdKillmailsRecentParams` containing the following parameters:
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
   * @return A list of killmail IDs and hashes
   */
  getCorporationsCorporationIdKillmailsRecent(params: KillmailsService.GetCorporationsCorporationIdKillmailsRecentParams): __Observable<Array<{killmail_hash: string, killmail_id: number}>> {
    return this.getCorporationsCorporationIdKillmailsRecentResponse(params).pipe(
      __map(_r => _r.body as Array<{killmail_hash: string, killmail_id: number}>)
    );
  }

  /**
   * Get a single killmail
   *
   * Return a single killmail from its ID and hash
   *
   * ---
   * Alternate route: `/dev/killmails/{killmail_id}/{killmail_hash}/`
   *
   * Alternate route: `/legacy/killmails/{killmail_id}/{killmail_hash}/`
   *
   * Alternate route: `/v1/killmails/{killmail_id}/{killmail_hash}/`
   *
   * ---
   * This route is cached for up to 30758400 seconds
   * @param params The `KillmailsService.GetKillmailsKillmailIdKillmailHashParams` containing the following parameters:
   *
   * - `killmail_id`: The killmail ID to be queried
   *
   * - `killmail_hash`: The killmail hash for verification
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A killmail
   */
  getKillmailsKillmailIdKillmailHashResponse(params: KillmailsService.GetKillmailsKillmailIdKillmailHashParams): __Observable<__StrictHttpResponse<{attackers: Array<{alliance_id?: number, character_id?: number, corporation_id?: number, damage_done: number, faction_id?: number, final_blow: boolean, security_status: number, ship_type_id?: number, weapon_type_id?: number}>, killmail_id: number, killmail_time: string, moon_id?: number, solar_system_id: number, victim: {alliance_id?: number, character_id?: number, corporation_id?: number, damage_taken: number, faction_id?: number, items?: Array<{flag: number, item_type_id: number, items?: Array<{flag: number, item_type_id: number, quantity_destroyed?: number, quantity_dropped?: number, singleton: number}>, quantity_destroyed?: number, quantity_dropped?: number, singleton: number}>, position?: {x: number, y: number, z: number}, ship_type_id: number}, war_id?: number}>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;


    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/killmails/${encodeURIComponent(params.killmailId)}/${encodeURIComponent(params.killmailHash)}/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<{attackers: Array<{alliance_id?: number, character_id?: number, corporation_id?: number, damage_done: number, faction_id?: number, final_blow: boolean, security_status: number, ship_type_id?: number, weapon_type_id?: number}>, killmail_id: number, killmail_time: string, moon_id?: number, solar_system_id: number, victim: {alliance_id?: number, character_id?: number, corporation_id?: number, damage_taken: number, faction_id?: number, items?: Array<{flag: number, item_type_id: number, items?: Array<{flag: number, item_type_id: number, quantity_destroyed?: number, quantity_dropped?: number, singleton: number}>, quantity_destroyed?: number, quantity_dropped?: number, singleton: number}>, position?: {x: number, y: number, z: number}, ship_type_id: number}, war_id?: number}>;
      })
    );
  }
  /**
   * Get a single killmail
   *
   * Return a single killmail from its ID and hash
   *
   * ---
   * Alternate route: `/dev/killmails/{killmail_id}/{killmail_hash}/`
   *
   * Alternate route: `/legacy/killmails/{killmail_id}/{killmail_hash}/`
   *
   * Alternate route: `/v1/killmails/{killmail_id}/{killmail_hash}/`
   *
   * ---
   * This route is cached for up to 30758400 seconds
   * @param params The `KillmailsService.GetKillmailsKillmailIdKillmailHashParams` containing the following parameters:
   *
   * - `killmail_id`: The killmail ID to be queried
   *
   * - `killmail_hash`: The killmail hash for verification
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A killmail
   */
  getKillmailsKillmailIdKillmailHash(params: KillmailsService.GetKillmailsKillmailIdKillmailHashParams): __Observable<{attackers: Array<{alliance_id?: number, character_id?: number, corporation_id?: number, damage_done: number, faction_id?: number, final_blow: boolean, security_status: number, ship_type_id?: number, weapon_type_id?: number}>, killmail_id: number, killmail_time: string, moon_id?: number, solar_system_id: number, victim: {alliance_id?: number, character_id?: number, corporation_id?: number, damage_taken: number, faction_id?: number, items?: Array<{flag: number, item_type_id: number, items?: Array<{flag: number, item_type_id: number, quantity_destroyed?: number, quantity_dropped?: number, singleton: number}>, quantity_destroyed?: number, quantity_dropped?: number, singleton: number}>, position?: {x: number, y: number, z: number}, ship_type_id: number}, war_id?: number}> {
    return this.getKillmailsKillmailIdKillmailHashResponse(params).pipe(
      __map(_r => _r.body as {attackers: Array<{alliance_id?: number, character_id?: number, corporation_id?: number, damage_done: number, faction_id?: number, final_blow: boolean, security_status: number, ship_type_id?: number, weapon_type_id?: number}>, killmail_id: number, killmail_time: string, moon_id?: number, solar_system_id: number, victim: {alliance_id?: number, character_id?: number, corporation_id?: number, damage_taken: number, faction_id?: number, items?: Array<{flag: number, item_type_id: number, items?: Array<{flag: number, item_type_id: number, quantity_destroyed?: number, quantity_dropped?: number, singleton: number}>, quantity_destroyed?: number, quantity_dropped?: number, singleton: number}>, position?: {x: number, y: number, z: number}, ship_type_id: number}, war_id?: number})
    );
  }
}

module KillmailsService {

  /**
   * Parameters for getCharactersCharacterIdKillmailsRecent
   */
  export interface GetCharactersCharacterIdKillmailsRecentParams {

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
   * Parameters for getCorporationsCorporationIdKillmailsRecent
   */
  export interface GetCorporationsCorporationIdKillmailsRecentParams {

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
   * Parameters for getKillmailsKillmailIdKillmailHash
   */
  export interface GetKillmailsKillmailIdKillmailHashParams {

    /**
     * The killmail ID to be queried
     */
    killmailId: number;

    /**
     * The killmail hash for verification
     */
    killmailHash: string;

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

export { KillmailsService }
