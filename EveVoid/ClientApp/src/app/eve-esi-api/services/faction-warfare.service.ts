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
class FactionWarfareService extends __BaseService {
  static readonly getCharactersCharacterIdFwStatsPath = '/characters/{character_id}/fw/stats/';
  static readonly getCorporationsCorporationIdFwStatsPath = '/corporations/{corporation_id}/fw/stats/';
  static readonly getFwLeaderboardsPath = '/fw/leaderboards/';
  static readonly getFwLeaderboardsCharactersPath = '/fw/leaderboards/characters/';
  static readonly getFwLeaderboardsCorporationsPath = '/fw/leaderboards/corporations/';
  static readonly getFwStatsPath = '/fw/stats/';
  static readonly getFwSystemsPath = '/fw/systems/';
  static readonly getFwWarsPath = '/fw/wars/';

  constructor(
    config: __Configuration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * Overview of a character involved in faction warfare
   *
   * Statistical overview of a character involved in faction warfare
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/fw/stats/`
   *
   * Alternate route: `/legacy/characters/{character_id}/fw/stats/`
   *
   * Alternate route: `/v1/characters/{character_id}/fw/stats/`
   *
   * Alternate route: `/v2/characters/{character_id}/fw/stats/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `FactionWarfareService.GetCharactersCharacterIdFwStatsParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Faction warfare statistics for a given character
   */
  getCharactersCharacterIdFwStatsResponse(params: FactionWarfareService.GetCharactersCharacterIdFwStatsParams): __Observable<__StrictHttpResponse<{current_rank?: number, enlisted_on?: string, faction_id?: number, highest_rank?: number, kills: {last_week: number, total: number, yesterday: number}, victory_points: {last_week: number, total: number, yesterday: number}}>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/fw/stats/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<{current_rank?: number, enlisted_on?: string, faction_id?: number, highest_rank?: number, kills: {last_week: number, total: number, yesterday: number}, victory_points: {last_week: number, total: number, yesterday: number}}>;
      })
    );
  }
  /**
   * Overview of a character involved in faction warfare
   *
   * Statistical overview of a character involved in faction warfare
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/fw/stats/`
   *
   * Alternate route: `/legacy/characters/{character_id}/fw/stats/`
   *
   * Alternate route: `/v1/characters/{character_id}/fw/stats/`
   *
   * Alternate route: `/v2/characters/{character_id}/fw/stats/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `FactionWarfareService.GetCharactersCharacterIdFwStatsParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Faction warfare statistics for a given character
   */
  getCharactersCharacterIdFwStats(params: FactionWarfareService.GetCharactersCharacterIdFwStatsParams): __Observable<{current_rank?: number, enlisted_on?: string, faction_id?: number, highest_rank?: number, kills: {last_week: number, total: number, yesterday: number}, victory_points: {last_week: number, total: number, yesterday: number}}> {
    return this.getCharactersCharacterIdFwStatsResponse(params).pipe(
      __map(_r => _r.body as {current_rank?: number, enlisted_on?: string, faction_id?: number, highest_rank?: number, kills: {last_week: number, total: number, yesterday: number}, victory_points: {last_week: number, total: number, yesterday: number}})
    );
  }

  /**
   * Overview of a corporation involved in faction warfare
   *
   * Statistics about a corporation involved in faction warfare
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/fw/stats/`
   *
   * Alternate route: `/legacy/corporations/{corporation_id}/fw/stats/`
   *
   * Alternate route: `/v1/corporations/{corporation_id}/fw/stats/`
   *
   * Alternate route: `/v2/corporations/{corporation_id}/fw/stats/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `FactionWarfareService.GetCorporationsCorporationIdFwStatsParams` containing the following parameters:
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Faction warfare statistics for a given corporation
   */
  getCorporationsCorporationIdFwStatsResponse(params: FactionWarfareService.GetCorporationsCorporationIdFwStatsParams): __Observable<__StrictHttpResponse<{enlisted_on?: string, faction_id?: number, kills: {last_week: number, total: number, yesterday: number}, pilots?: number, victory_points: {last_week: number, total: number, yesterday: number}}>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/corporations/${encodeURIComponent(params.corporationId)}/fw/stats/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<{enlisted_on?: string, faction_id?: number, kills: {last_week: number, total: number, yesterday: number}, pilots?: number, victory_points: {last_week: number, total: number, yesterday: number}}>;
      })
    );
  }
  /**
   * Overview of a corporation involved in faction warfare
   *
   * Statistics about a corporation involved in faction warfare
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/fw/stats/`
   *
   * Alternate route: `/legacy/corporations/{corporation_id}/fw/stats/`
   *
   * Alternate route: `/v1/corporations/{corporation_id}/fw/stats/`
   *
   * Alternate route: `/v2/corporations/{corporation_id}/fw/stats/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `FactionWarfareService.GetCorporationsCorporationIdFwStatsParams` containing the following parameters:
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Faction warfare statistics for a given corporation
   */
  getCorporationsCorporationIdFwStats(params: FactionWarfareService.GetCorporationsCorporationIdFwStatsParams): __Observable<{enlisted_on?: string, faction_id?: number, kills: {last_week: number, total: number, yesterday: number}, pilots?: number, victory_points: {last_week: number, total: number, yesterday: number}}> {
    return this.getCorporationsCorporationIdFwStatsResponse(params).pipe(
      __map(_r => _r.body as {enlisted_on?: string, faction_id?: number, kills: {last_week: number, total: number, yesterday: number}, pilots?: number, victory_points: {last_week: number, total: number, yesterday: number}})
    );
  }

  /**
   * List of the top factions in faction warfare
   *
   * Top 4 leaderboard of factions for kills and victory points separated by total, last week and yesterday
   *
   * ---
   * Alternate route: `/dev/fw/leaderboards/`
   *
   * Alternate route: `/legacy/fw/leaderboards/`
   *
   * Alternate route: `/v1/fw/leaderboards/`
   *
   * Alternate route: `/v2/fw/leaderboards/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `FactionWarfareService.GetFwLeaderboardsParams` containing the following parameters:
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Corporation leaderboard of kills and victory points within faction warfare
   */
  getFwLeaderboardsResponse(params: FactionWarfareService.GetFwLeaderboardsParams): __Observable<__StrictHttpResponse<{kills: {active_total: Array<{amount?: number, faction_id?: number}>, last_week: Array<{amount?: number, faction_id?: number}>, yesterday: Array<{amount?: number, faction_id?: number}>}, victory_points: {active_total: Array<{amount?: number, faction_id?: number}>, last_week: Array<{amount?: number, faction_id?: number}>, yesterday: Array<{amount?: number, faction_id?: number}>}}>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/fw/leaderboards/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<{kills: {active_total: Array<{amount?: number, faction_id?: number}>, last_week: Array<{amount?: number, faction_id?: number}>, yesterday: Array<{amount?: number, faction_id?: number}>}, victory_points: {active_total: Array<{amount?: number, faction_id?: number}>, last_week: Array<{amount?: number, faction_id?: number}>, yesterday: Array<{amount?: number, faction_id?: number}>}}>;
      })
    );
  }
  /**
   * List of the top factions in faction warfare
   *
   * Top 4 leaderboard of factions for kills and victory points separated by total, last week and yesterday
   *
   * ---
   * Alternate route: `/dev/fw/leaderboards/`
   *
   * Alternate route: `/legacy/fw/leaderboards/`
   *
   * Alternate route: `/v1/fw/leaderboards/`
   *
   * Alternate route: `/v2/fw/leaderboards/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `FactionWarfareService.GetFwLeaderboardsParams` containing the following parameters:
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Corporation leaderboard of kills and victory points within faction warfare
   */
  getFwLeaderboards(params: FactionWarfareService.GetFwLeaderboardsParams): __Observable<{kills: {active_total: Array<{amount?: number, faction_id?: number}>, last_week: Array<{amount?: number, faction_id?: number}>, yesterday: Array<{amount?: number, faction_id?: number}>}, victory_points: {active_total: Array<{amount?: number, faction_id?: number}>, last_week: Array<{amount?: number, faction_id?: number}>, yesterday: Array<{amount?: number, faction_id?: number}>}}> {
    return this.getFwLeaderboardsResponse(params).pipe(
      __map(_r => _r.body as {kills: {active_total: Array<{amount?: number, faction_id?: number}>, last_week: Array<{amount?: number, faction_id?: number}>, yesterday: Array<{amount?: number, faction_id?: number}>}, victory_points: {active_total: Array<{amount?: number, faction_id?: number}>, last_week: Array<{amount?: number, faction_id?: number}>, yesterday: Array<{amount?: number, faction_id?: number}>}})
    );
  }

  /**
   * List of the top pilots in faction warfare
   *
   * Top 100 leaderboard of pilots for kills and victory points separated by total, last week and yesterday
   *
   * ---
   * Alternate route: `/dev/fw/leaderboards/characters/`
   *
   * Alternate route: `/legacy/fw/leaderboards/characters/`
   *
   * Alternate route: `/v1/fw/leaderboards/characters/`
   *
   * Alternate route: `/v2/fw/leaderboards/characters/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `FactionWarfareService.GetFwLeaderboardsCharactersParams` containing the following parameters:
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Character leaderboard of kills and victory points within faction warfare
   */
  getFwLeaderboardsCharactersResponse(params: FactionWarfareService.GetFwLeaderboardsCharactersParams): __Observable<__StrictHttpResponse<{kills: {active_total: Array<{amount?: number, character_id?: number}>, last_week: Array<{amount?: number, character_id?: number}>, yesterday: Array<{amount?: number, character_id?: number}>}, victory_points: {active_total: Array<{amount?: number, character_id?: number}>, last_week: Array<{amount?: number, character_id?: number}>, yesterday: Array<{amount?: number, character_id?: number}>}}>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/fw/leaderboards/characters/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<{kills: {active_total: Array<{amount?: number, character_id?: number}>, last_week: Array<{amount?: number, character_id?: number}>, yesterday: Array<{amount?: number, character_id?: number}>}, victory_points: {active_total: Array<{amount?: number, character_id?: number}>, last_week: Array<{amount?: number, character_id?: number}>, yesterday: Array<{amount?: number, character_id?: number}>}}>;
      })
    );
  }
  /**
   * List of the top pilots in faction warfare
   *
   * Top 100 leaderboard of pilots for kills and victory points separated by total, last week and yesterday
   *
   * ---
   * Alternate route: `/dev/fw/leaderboards/characters/`
   *
   * Alternate route: `/legacy/fw/leaderboards/characters/`
   *
   * Alternate route: `/v1/fw/leaderboards/characters/`
   *
   * Alternate route: `/v2/fw/leaderboards/characters/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `FactionWarfareService.GetFwLeaderboardsCharactersParams` containing the following parameters:
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Character leaderboard of kills and victory points within faction warfare
   */
  getFwLeaderboardsCharacters(params: FactionWarfareService.GetFwLeaderboardsCharactersParams): __Observable<{kills: {active_total: Array<{amount?: number, character_id?: number}>, last_week: Array<{amount?: number, character_id?: number}>, yesterday: Array<{amount?: number, character_id?: number}>}, victory_points: {active_total: Array<{amount?: number, character_id?: number}>, last_week: Array<{amount?: number, character_id?: number}>, yesterday: Array<{amount?: number, character_id?: number}>}}> {
    return this.getFwLeaderboardsCharactersResponse(params).pipe(
      __map(_r => _r.body as {kills: {active_total: Array<{amount?: number, character_id?: number}>, last_week: Array<{amount?: number, character_id?: number}>, yesterday: Array<{amount?: number, character_id?: number}>}, victory_points: {active_total: Array<{amount?: number, character_id?: number}>, last_week: Array<{amount?: number, character_id?: number}>, yesterday: Array<{amount?: number, character_id?: number}>}})
    );
  }

  /**
   * List of the top corporations in faction warfare
   *
   * Top 10 leaderboard of corporations for kills and victory points separated by total, last week and yesterday
   *
   * ---
   * Alternate route: `/dev/fw/leaderboards/corporations/`
   *
   * Alternate route: `/legacy/fw/leaderboards/corporations/`
   *
   * Alternate route: `/v1/fw/leaderboards/corporations/`
   *
   * Alternate route: `/v2/fw/leaderboards/corporations/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `FactionWarfareService.GetFwLeaderboardsCorporationsParams` containing the following parameters:
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Corporation leaderboard of kills and victory points within faction warfare
   */
  getFwLeaderboardsCorporationsResponse(params: FactionWarfareService.GetFwLeaderboardsCorporationsParams): __Observable<__StrictHttpResponse<{kills: {active_total: Array<{amount?: number, corporation_id?: number}>, last_week: Array<{amount?: number, corporation_id?: number}>, yesterday: Array<{amount?: number, corporation_id?: number}>}, victory_points: {active_total: Array<{amount?: number, corporation_id?: number}>, last_week: Array<{amount?: number, corporation_id?: number}>, yesterday: Array<{amount?: number, corporation_id?: number}>}}>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/fw/leaderboards/corporations/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<{kills: {active_total: Array<{amount?: number, corporation_id?: number}>, last_week: Array<{amount?: number, corporation_id?: number}>, yesterday: Array<{amount?: number, corporation_id?: number}>}, victory_points: {active_total: Array<{amount?: number, corporation_id?: number}>, last_week: Array<{amount?: number, corporation_id?: number}>, yesterday: Array<{amount?: number, corporation_id?: number}>}}>;
      })
    );
  }
  /**
   * List of the top corporations in faction warfare
   *
   * Top 10 leaderboard of corporations for kills and victory points separated by total, last week and yesterday
   *
   * ---
   * Alternate route: `/dev/fw/leaderboards/corporations/`
   *
   * Alternate route: `/legacy/fw/leaderboards/corporations/`
   *
   * Alternate route: `/v1/fw/leaderboards/corporations/`
   *
   * Alternate route: `/v2/fw/leaderboards/corporations/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `FactionWarfareService.GetFwLeaderboardsCorporationsParams` containing the following parameters:
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Corporation leaderboard of kills and victory points within faction warfare
   */
  getFwLeaderboardsCorporations(params: FactionWarfareService.GetFwLeaderboardsCorporationsParams): __Observable<{kills: {active_total: Array<{amount?: number, corporation_id?: number}>, last_week: Array<{amount?: number, corporation_id?: number}>, yesterday: Array<{amount?: number, corporation_id?: number}>}, victory_points: {active_total: Array<{amount?: number, corporation_id?: number}>, last_week: Array<{amount?: number, corporation_id?: number}>, yesterday: Array<{amount?: number, corporation_id?: number}>}}> {
    return this.getFwLeaderboardsCorporationsResponse(params).pipe(
      __map(_r => _r.body as {kills: {active_total: Array<{amount?: number, corporation_id?: number}>, last_week: Array<{amount?: number, corporation_id?: number}>, yesterday: Array<{amount?: number, corporation_id?: number}>}, victory_points: {active_total: Array<{amount?: number, corporation_id?: number}>, last_week: Array<{amount?: number, corporation_id?: number}>, yesterday: Array<{amount?: number, corporation_id?: number}>}})
    );
  }

  /**
   * An overview of statistics about factions involved in faction warfare
   *
   * Statistical overviews of factions involved in faction warfare
   *
   * ---
   * Alternate route: `/dev/fw/stats/`
   *
   * Alternate route: `/legacy/fw/stats/`
   *
   * Alternate route: `/v1/fw/stats/`
   *
   * Alternate route: `/v2/fw/stats/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `FactionWarfareService.GetFwStatsParams` containing the following parameters:
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Per faction breakdown of faction warfare statistics
   */
  getFwStatsResponse(params: FactionWarfareService.GetFwStatsParams): __Observable<__StrictHttpResponse<Array<{faction_id: number, kills: {last_week: number, total: number, yesterday: number}, pilots: number, systems_controlled: number, victory_points: {last_week: number, total: number, yesterday: number}}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/fw/stats/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{faction_id: number, kills: {last_week: number, total: number, yesterday: number}, pilots: number, systems_controlled: number, victory_points: {last_week: number, total: number, yesterday: number}}>>;
      })
    );
  }
  /**
   * An overview of statistics about factions involved in faction warfare
   *
   * Statistical overviews of factions involved in faction warfare
   *
   * ---
   * Alternate route: `/dev/fw/stats/`
   *
   * Alternate route: `/legacy/fw/stats/`
   *
   * Alternate route: `/v1/fw/stats/`
   *
   * Alternate route: `/v2/fw/stats/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `FactionWarfareService.GetFwStatsParams` containing the following parameters:
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Per faction breakdown of faction warfare statistics
   */
  getFwStats(params: FactionWarfareService.GetFwStatsParams): __Observable<Array<{faction_id: number, kills: {last_week: number, total: number, yesterday: number}, pilots: number, systems_controlled: number, victory_points: {last_week: number, total: number, yesterday: number}}>> {
    return this.getFwStatsResponse(params).pipe(
      __map(_r => _r.body as Array<{faction_id: number, kills: {last_week: number, total: number, yesterday: number}, pilots: number, systems_controlled: number, victory_points: {last_week: number, total: number, yesterday: number}}>)
    );
  }

  /**
   * Ownership of faction warfare systems
   *
   * An overview of the current ownership of faction warfare solar systems
   *
   * ---
   * Alternate route: `/dev/fw/systems/`
   *
   * Alternate route: `/legacy/fw/systems/`
   *
   * Alternate route: `/v2/fw/systems/`
   *
   * Alternate route: `/v3/fw/systems/`
   *
   * ---
   * This route is cached for up to 1800 seconds
   * @param params The `FactionWarfareService.GetFwSystemsParams` containing the following parameters:
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return All faction warfare solar systems
   */
  getFwSystemsResponse(params: FactionWarfareService.GetFwSystemsParams): __Observable<__StrictHttpResponse<Array<{contested: 'captured' | 'contested' | 'uncontested' | 'vulnerable', occupier_faction_id: number, owner_faction_id: number, solar_system_id: number, victory_points: number, victory_points_threshold: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/fw/systems/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{contested: 'captured' | 'contested' | 'uncontested' | 'vulnerable', occupier_faction_id: number, owner_faction_id: number, solar_system_id: number, victory_points: number, victory_points_threshold: number}>>;
      })
    );
  }
  /**
   * Ownership of faction warfare systems
   *
   * An overview of the current ownership of faction warfare solar systems
   *
   * ---
   * Alternate route: `/dev/fw/systems/`
   *
   * Alternate route: `/legacy/fw/systems/`
   *
   * Alternate route: `/v2/fw/systems/`
   *
   * Alternate route: `/v3/fw/systems/`
   *
   * ---
   * This route is cached for up to 1800 seconds
   * @param params The `FactionWarfareService.GetFwSystemsParams` containing the following parameters:
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return All faction warfare solar systems
   */
  getFwSystems(params: FactionWarfareService.GetFwSystemsParams): __Observable<Array<{contested: 'captured' | 'contested' | 'uncontested' | 'vulnerable', occupier_faction_id: number, owner_faction_id: number, solar_system_id: number, victory_points: number, victory_points_threshold: number}>> {
    return this.getFwSystemsResponse(params).pipe(
      __map(_r => _r.body as Array<{contested: 'captured' | 'contested' | 'uncontested' | 'vulnerable', occupier_faction_id: number, owner_faction_id: number, solar_system_id: number, victory_points: number, victory_points_threshold: number}>)
    );
  }

  /**
   * Data about which NPC factions are at war
   *
   * Data about which NPC factions are at war
   *
   * ---
   * Alternate route: `/dev/fw/wars/`
   *
   * Alternate route: `/legacy/fw/wars/`
   *
   * Alternate route: `/v1/fw/wars/`
   *
   * Alternate route: `/v2/fw/wars/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `FactionWarfareService.GetFwWarsParams` containing the following parameters:
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of NPC factions at war
   */
  getFwWarsResponse(params: FactionWarfareService.GetFwWarsParams): __Observable<__StrictHttpResponse<Array<{against_id: number, faction_id: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/fw/wars/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{against_id: number, faction_id: number}>>;
      })
    );
  }
  /**
   * Data about which NPC factions are at war
   *
   * Data about which NPC factions are at war
   *
   * ---
   * Alternate route: `/dev/fw/wars/`
   *
   * Alternate route: `/legacy/fw/wars/`
   *
   * Alternate route: `/v1/fw/wars/`
   *
   * Alternate route: `/v2/fw/wars/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `FactionWarfareService.GetFwWarsParams` containing the following parameters:
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of NPC factions at war
   */
  getFwWars(params: FactionWarfareService.GetFwWarsParams): __Observable<Array<{against_id: number, faction_id: number}>> {
    return this.getFwWarsResponse(params).pipe(
      __map(_r => _r.body as Array<{against_id: number, faction_id: number}>)
    );
  }
}

module FactionWarfareService {

  /**
   * Parameters for getCharactersCharacterIdFwStats
   */
  export interface GetCharactersCharacterIdFwStatsParams {

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
   * Parameters for getCorporationsCorporationIdFwStats
   */
  export interface GetCorporationsCorporationIdFwStatsParams {

    /**
     * An EVE corporation ID
     */
    corporationId: number;

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
   * Parameters for getFwLeaderboards
   */
  export interface GetFwLeaderboardsParams {

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
   * Parameters for getFwLeaderboardsCharacters
   */
  export interface GetFwLeaderboardsCharactersParams {

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
   * Parameters for getFwLeaderboardsCorporations
   */
  export interface GetFwLeaderboardsCorporationsParams {

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
   * Parameters for getFwStats
   */
  export interface GetFwStatsParams {

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
   * Parameters for getFwSystems
   */
  export interface GetFwSystemsParams {

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
   * Parameters for getFwWars
   */
  export interface GetFwWarsParams {

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

export { FactionWarfareService }
