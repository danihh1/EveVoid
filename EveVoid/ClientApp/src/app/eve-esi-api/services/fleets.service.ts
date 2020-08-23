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
class FleetsService extends __BaseService {
  static readonly getCharactersCharacterIdFleetPath = '/characters/{character_id}/fleet/';
  static readonly getFleetsFleetIdPath = '/fleets/{fleet_id}/';
  static readonly putFleetsFleetIdPath = '/fleets/{fleet_id}/';
  static readonly getFleetsFleetIdMembersPath = '/fleets/{fleet_id}/members/';
  static readonly postFleetsFleetIdMembersPath = '/fleets/{fleet_id}/members/';
  static readonly deleteFleetsFleetIdMembersMemberIdPath = '/fleets/{fleet_id}/members/{member_id}/';
  static readonly putFleetsFleetIdMembersMemberIdPath = '/fleets/{fleet_id}/members/{member_id}/';
  static readonly deleteFleetsFleetIdSquadsSquadIdPath = '/fleets/{fleet_id}/squads/{squad_id}/';
  static readonly putFleetsFleetIdSquadsSquadIdPath = '/fleets/{fleet_id}/squads/{squad_id}/';
  static readonly getFleetsFleetIdWingsPath = '/fleets/{fleet_id}/wings/';
  static readonly postFleetsFleetIdWingsPath = '/fleets/{fleet_id}/wings/';
  static readonly deleteFleetsFleetIdWingsWingIdPath = '/fleets/{fleet_id}/wings/{wing_id}/';
  static readonly putFleetsFleetIdWingsWingIdPath = '/fleets/{fleet_id}/wings/{wing_id}/';
  static readonly postFleetsFleetIdWingsWingIdSquadsPath = '/fleets/{fleet_id}/wings/{wing_id}/squads/';

  constructor(
    config: __Configuration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * Get character fleet info
   *
   * Return the fleet ID the character is in, if any.
   *
   * ---
   * Alternate route: `/legacy/characters/{character_id}/fleet/`
   *
   * Alternate route: `/v1/characters/{character_id}/fleet/`
   *
   * ---
   * This route is cached for up to 60 seconds
   *
   * ---
   * Warning: This route has an upgrade available
   *
   * ---
   * [Diff of the upcoming changes](https://esi.evetech.net/diff/latest/dev/#GET-/characters/{character_id}/fleet/)
   * @param params The `FleetsService.GetCharactersCharacterIdFleetParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Details about the character's fleet
   */
  getCharactersCharacterIdFleetResponse(params: FleetsService.GetCharactersCharacterIdFleetParams): __Observable<__StrictHttpResponse<{fleet_id: number, role: 'fleet_commander' | 'squad_commander' | 'squad_member' | 'wing_commander', squad_id: number, wing_id: number}>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/fleet/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<{fleet_id: number, role: 'fleet_commander' | 'squad_commander' | 'squad_member' | 'wing_commander', squad_id: number, wing_id: number}>;
      })
    );
  }
  /**
   * Get character fleet info
   *
   * Return the fleet ID the character is in, if any.
   *
   * ---
   * Alternate route: `/legacy/characters/{character_id}/fleet/`
   *
   * Alternate route: `/v1/characters/{character_id}/fleet/`
   *
   * ---
   * This route is cached for up to 60 seconds
   *
   * ---
   * Warning: This route has an upgrade available
   *
   * ---
   * [Diff of the upcoming changes](https://esi.evetech.net/diff/latest/dev/#GET-/characters/{character_id}/fleet/)
   * @param params The `FleetsService.GetCharactersCharacterIdFleetParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Details about the character's fleet
   */
  getCharactersCharacterIdFleet(params: FleetsService.GetCharactersCharacterIdFleetParams): __Observable<{fleet_id: number, role: 'fleet_commander' | 'squad_commander' | 'squad_member' | 'wing_commander', squad_id: number, wing_id: number}> {
    return this.getCharactersCharacterIdFleetResponse(params).pipe(
      __map(_r => _r.body as {fleet_id: number, role: 'fleet_commander' | 'squad_commander' | 'squad_member' | 'wing_commander', squad_id: number, wing_id: number})
    );
  }

  /**
   * Get fleet information
   *
   * Return details about a fleet
   *
   * ---
   * Alternate route: `/dev/fleets/{fleet_id}/`
   *
   * Alternate route: `/legacy/fleets/{fleet_id}/`
   *
   * Alternate route: `/v1/fleets/{fleet_id}/`
   *
   * ---
   * This route is cached for up to 5 seconds
   * @param params The `FleetsService.GetFleetsFleetIdParams` containing the following parameters:
   *
   * - `fleet_id`: ID for a fleet
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Details about a fleet
   */
  getFleetsFleetIdResponse(params: FleetsService.GetFleetsFleetIdParams): __Observable<__StrictHttpResponse<{is_free_move: boolean, is_registered: boolean, is_voice_enabled: boolean, motd: string}>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/fleets/${encodeURIComponent(params.fleetId)}/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<{is_free_move: boolean, is_registered: boolean, is_voice_enabled: boolean, motd: string}>;
      })
    );
  }
  /**
   * Get fleet information
   *
   * Return details about a fleet
   *
   * ---
   * Alternate route: `/dev/fleets/{fleet_id}/`
   *
   * Alternate route: `/legacy/fleets/{fleet_id}/`
   *
   * Alternate route: `/v1/fleets/{fleet_id}/`
   *
   * ---
   * This route is cached for up to 5 seconds
   * @param params The `FleetsService.GetFleetsFleetIdParams` containing the following parameters:
   *
   * - `fleet_id`: ID for a fleet
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Details about a fleet
   */
  getFleetsFleetId(params: FleetsService.GetFleetsFleetIdParams): __Observable<{is_free_move: boolean, is_registered: boolean, is_voice_enabled: boolean, motd: string}> {
    return this.getFleetsFleetIdResponse(params).pipe(
      __map(_r => _r.body as {is_free_move: boolean, is_registered: boolean, is_voice_enabled: boolean, motd: string})
    );
  }

  /**
   * Update fleet
   *
   * Update settings about a fleet
   *
   * ---
   * Alternate route: `/dev/fleets/{fleet_id}/`
   *
   * Alternate route: `/legacy/fleets/{fleet_id}/`
   *
   * Alternate route: `/v1/fleets/{fleet_id}/`
   * @param params The `FleetsService.PutFleetsFleetIdParams` containing the following parameters:
   *
   * - `new_settings`: What to update for this fleet
   *
   * - `fleet_id`: ID for a fleet
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   */
  putFleetsFleetIdResponse(params: FleetsService.PutFleetsFleetIdParams): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    __body = params.newSettings;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    let req = new HttpRequest<any>(
      'PUT',
      this.rootUrl + `/fleets/${encodeURIComponent(params.fleetId)}/`,
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
   * Update fleet
   *
   * Update settings about a fleet
   *
   * ---
   * Alternate route: `/dev/fleets/{fleet_id}/`
   *
   * Alternate route: `/legacy/fleets/{fleet_id}/`
   *
   * Alternate route: `/v1/fleets/{fleet_id}/`
   * @param params The `FleetsService.PutFleetsFleetIdParams` containing the following parameters:
   *
   * - `new_settings`: What to update for this fleet
   *
   * - `fleet_id`: ID for a fleet
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   */
  putFleetsFleetId(params: FleetsService.PutFleetsFleetIdParams): __Observable<null> {
    return this.putFleetsFleetIdResponse(params).pipe(
      __map(_r => _r.body as null)
    );
  }

  /**
   * Get fleet members
   *
   * Return information about fleet members
   *
   * ---
   * Alternate route: `/dev/fleets/{fleet_id}/members/`
   *
   * Alternate route: `/legacy/fleets/{fleet_id}/members/`
   *
   * Alternate route: `/v1/fleets/{fleet_id}/members/`
   *
   * ---
   * This route is cached for up to 5 seconds
   * @param params The `FleetsService.GetFleetsFleetIdMembersParams` containing the following parameters:
   *
   * - `fleet_id`: ID for a fleet
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `language`: Language to use in the response, takes precedence over Accept-Language
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * - `Accept-Language`: Language to use in the response
   *
   * @return A list of fleet members
   */
  getFleetsFleetIdMembersResponse(params: FleetsService.GetFleetsFleetIdMembersParams): __Observable<__StrictHttpResponse<Array<{character_id: number, join_time: string, role: 'fleet_commander' | 'wing_commander' | 'squad_commander' | 'squad_member', role_name: string, ship_type_id: number, solar_system_id: number, squad_id: number, station_id?: number, takes_fleet_warp: boolean, wing_id: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.language != null) __params = __params.set('language', params.language.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    if (params.AcceptLanguage != null) __headers = __headers.set('Accept-Language', params.AcceptLanguage.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/fleets/${encodeURIComponent(params.fleetId)}/members/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{character_id: number, join_time: string, role: 'fleet_commander' | 'wing_commander' | 'squad_commander' | 'squad_member', role_name: string, ship_type_id: number, solar_system_id: number, squad_id: number, station_id?: number, takes_fleet_warp: boolean, wing_id: number}>>;
      })
    );
  }
  /**
   * Get fleet members
   *
   * Return information about fleet members
   *
   * ---
   * Alternate route: `/dev/fleets/{fleet_id}/members/`
   *
   * Alternate route: `/legacy/fleets/{fleet_id}/members/`
   *
   * Alternate route: `/v1/fleets/{fleet_id}/members/`
   *
   * ---
   * This route is cached for up to 5 seconds
   * @param params The `FleetsService.GetFleetsFleetIdMembersParams` containing the following parameters:
   *
   * - `fleet_id`: ID for a fleet
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `language`: Language to use in the response, takes precedence over Accept-Language
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * - `Accept-Language`: Language to use in the response
   *
   * @return A list of fleet members
   */
  getFleetsFleetIdMembers(params: FleetsService.GetFleetsFleetIdMembersParams): __Observable<Array<{character_id: number, join_time: string, role: 'fleet_commander' | 'wing_commander' | 'squad_commander' | 'squad_member', role_name: string, ship_type_id: number, solar_system_id: number, squad_id: number, station_id?: number, takes_fleet_warp: boolean, wing_id: number}>> {
    return this.getFleetsFleetIdMembersResponse(params).pipe(
      __map(_r => _r.body as Array<{character_id: number, join_time: string, role: 'fleet_commander' | 'wing_commander' | 'squad_commander' | 'squad_member', role_name: string, ship_type_id: number, solar_system_id: number, squad_id: number, station_id?: number, takes_fleet_warp: boolean, wing_id: number}>)
    );
  }

  /**
   * Create fleet invitation
   *
   * Invite a character into the fleet. If a character has a CSPA charge set it is not possible to invite them to the fleet using ESI
   *
   * ---
   * Alternate route: `/dev/fleets/{fleet_id}/members/`
   *
   * Alternate route: `/legacy/fleets/{fleet_id}/members/`
   *
   * Alternate route: `/v1/fleets/{fleet_id}/members/`
   * @param params The `FleetsService.PostFleetsFleetIdMembersParams` containing the following parameters:
   *
   * - `invitation`: Details of the invitation
   *
   * - `fleet_id`: ID for a fleet
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   */
  postFleetsFleetIdMembersResponse(params: FleetsService.PostFleetsFleetIdMembersParams): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    __body = params.invitation;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    let req = new HttpRequest<any>(
      'POST',
      this.rootUrl + `/fleets/${encodeURIComponent(params.fleetId)}/members/`,
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
   * Create fleet invitation
   *
   * Invite a character into the fleet. If a character has a CSPA charge set it is not possible to invite them to the fleet using ESI
   *
   * ---
   * Alternate route: `/dev/fleets/{fleet_id}/members/`
   *
   * Alternate route: `/legacy/fleets/{fleet_id}/members/`
   *
   * Alternate route: `/v1/fleets/{fleet_id}/members/`
   * @param params The `FleetsService.PostFleetsFleetIdMembersParams` containing the following parameters:
   *
   * - `invitation`: Details of the invitation
   *
   * - `fleet_id`: ID for a fleet
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   */
  postFleetsFleetIdMembers(params: FleetsService.PostFleetsFleetIdMembersParams): __Observable<null> {
    return this.postFleetsFleetIdMembersResponse(params).pipe(
      __map(_r => _r.body as null)
    );
  }

  /**
   * Kick fleet member
   *
   * Kick a fleet member
   *
   * ---
   * Alternate route: `/dev/fleets/{fleet_id}/members/{member_id}/`
   *
   * Alternate route: `/legacy/fleets/{fleet_id}/members/{member_id}/`
   *
   * Alternate route: `/v1/fleets/{fleet_id}/members/{member_id}/`
   * @param params The `FleetsService.DeleteFleetsFleetIdMembersMemberIdParams` containing the following parameters:
   *
   * - `member_id`: The character ID of a member in this fleet
   *
   * - `fleet_id`: ID for a fleet
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   */
  deleteFleetsFleetIdMembersMemberIdResponse(params: FleetsService.DeleteFleetsFleetIdMembersMemberIdParams): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;


    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    let req = new HttpRequest<any>(
      'DELETE',
      this.rootUrl + `/fleets/${encodeURIComponent(params.fleetId)}/members/${encodeURIComponent(params.memberId)}/`,
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
   * Kick fleet member
   *
   * Kick a fleet member
   *
   * ---
   * Alternate route: `/dev/fleets/{fleet_id}/members/{member_id}/`
   *
   * Alternate route: `/legacy/fleets/{fleet_id}/members/{member_id}/`
   *
   * Alternate route: `/v1/fleets/{fleet_id}/members/{member_id}/`
   * @param params The `FleetsService.DeleteFleetsFleetIdMembersMemberIdParams` containing the following parameters:
   *
   * - `member_id`: The character ID of a member in this fleet
   *
   * - `fleet_id`: ID for a fleet
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   */
  deleteFleetsFleetIdMembersMemberId(params: FleetsService.DeleteFleetsFleetIdMembersMemberIdParams): __Observable<null> {
    return this.deleteFleetsFleetIdMembersMemberIdResponse(params).pipe(
      __map(_r => _r.body as null)
    );
  }

  /**
   * Move fleet member
   *
   * Move a fleet member around
   *
   * ---
   * Alternate route: `/dev/fleets/{fleet_id}/members/{member_id}/`
   *
   * Alternate route: `/legacy/fleets/{fleet_id}/members/{member_id}/`
   *
   * Alternate route: `/v1/fleets/{fleet_id}/members/{member_id}/`
   * @param params The `FleetsService.PutFleetsFleetIdMembersMemberIdParams` containing the following parameters:
   *
   * - `movement`: Details of the invitation
   *
   * - `member_id`: The character ID of a member in this fleet
   *
   * - `fleet_id`: ID for a fleet
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   */
  putFleetsFleetIdMembersMemberIdResponse(params: FleetsService.PutFleetsFleetIdMembersMemberIdParams): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    __body = params.movement;


    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    let req = new HttpRequest<any>(
      'PUT',
      this.rootUrl + `/fleets/${encodeURIComponent(params.fleetId)}/members/${encodeURIComponent(params.memberId)}/`,
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
   * Move fleet member
   *
   * Move a fleet member around
   *
   * ---
   * Alternate route: `/dev/fleets/{fleet_id}/members/{member_id}/`
   *
   * Alternate route: `/legacy/fleets/{fleet_id}/members/{member_id}/`
   *
   * Alternate route: `/v1/fleets/{fleet_id}/members/{member_id}/`
   * @param params The `FleetsService.PutFleetsFleetIdMembersMemberIdParams` containing the following parameters:
   *
   * - `movement`: Details of the invitation
   *
   * - `member_id`: The character ID of a member in this fleet
   *
   * - `fleet_id`: ID for a fleet
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   */
  putFleetsFleetIdMembersMemberId(params: FleetsService.PutFleetsFleetIdMembersMemberIdParams): __Observable<null> {
    return this.putFleetsFleetIdMembersMemberIdResponse(params).pipe(
      __map(_r => _r.body as null)
    );
  }

  /**
   * Delete fleet squad
   *
   * Delete a fleet squad, only empty squads can be deleted
   *
   * ---
   * Alternate route: `/dev/fleets/{fleet_id}/squads/{squad_id}/`
   *
   * Alternate route: `/legacy/fleets/{fleet_id}/squads/{squad_id}/`
   *
   * Alternate route: `/v1/fleets/{fleet_id}/squads/{squad_id}/`
   * @param params The `FleetsService.DeleteFleetsFleetIdSquadsSquadIdParams` containing the following parameters:
   *
   * - `squad_id`: The squad to delete
   *
   * - `fleet_id`: ID for a fleet
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   */
  deleteFleetsFleetIdSquadsSquadIdResponse(params: FleetsService.DeleteFleetsFleetIdSquadsSquadIdParams): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;


    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    let req = new HttpRequest<any>(
      'DELETE',
      this.rootUrl + `/fleets/${encodeURIComponent(params.fleetId)}/squads/${encodeURIComponent(params.squadId)}/`,
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
   * Delete fleet squad
   *
   * Delete a fleet squad, only empty squads can be deleted
   *
   * ---
   * Alternate route: `/dev/fleets/{fleet_id}/squads/{squad_id}/`
   *
   * Alternate route: `/legacy/fleets/{fleet_id}/squads/{squad_id}/`
   *
   * Alternate route: `/v1/fleets/{fleet_id}/squads/{squad_id}/`
   * @param params The `FleetsService.DeleteFleetsFleetIdSquadsSquadIdParams` containing the following parameters:
   *
   * - `squad_id`: The squad to delete
   *
   * - `fleet_id`: ID for a fleet
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   */
  deleteFleetsFleetIdSquadsSquadId(params: FleetsService.DeleteFleetsFleetIdSquadsSquadIdParams): __Observable<null> {
    return this.deleteFleetsFleetIdSquadsSquadIdResponse(params).pipe(
      __map(_r => _r.body as null)
    );
  }

  /**
   * Rename fleet squad
   *
   * Rename a fleet squad
   *
   * ---
   * Alternate route: `/dev/fleets/{fleet_id}/squads/{squad_id}/`
   *
   * Alternate route: `/legacy/fleets/{fleet_id}/squads/{squad_id}/`
   *
   * Alternate route: `/v1/fleets/{fleet_id}/squads/{squad_id}/`
   * @param params The `FleetsService.PutFleetsFleetIdSquadsSquadIdParams` containing the following parameters:
   *
   * - `squad_id`: The squad to rename
   *
   * - `naming`: New name of the squad
   *
   * - `fleet_id`: ID for a fleet
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   */
  putFleetsFleetIdSquadsSquadIdResponse(params: FleetsService.PutFleetsFleetIdSquadsSquadIdParams): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    __body = params.naming;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    let req = new HttpRequest<any>(
      'PUT',
      this.rootUrl + `/fleets/${encodeURIComponent(params.fleetId)}/squads/${encodeURIComponent(params.squadId)}/`,
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
   * Rename fleet squad
   *
   * Rename a fleet squad
   *
   * ---
   * Alternate route: `/dev/fleets/{fleet_id}/squads/{squad_id}/`
   *
   * Alternate route: `/legacy/fleets/{fleet_id}/squads/{squad_id}/`
   *
   * Alternate route: `/v1/fleets/{fleet_id}/squads/{squad_id}/`
   * @param params The `FleetsService.PutFleetsFleetIdSquadsSquadIdParams` containing the following parameters:
   *
   * - `squad_id`: The squad to rename
   *
   * - `naming`: New name of the squad
   *
   * - `fleet_id`: ID for a fleet
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   */
  putFleetsFleetIdSquadsSquadId(params: FleetsService.PutFleetsFleetIdSquadsSquadIdParams): __Observable<null> {
    return this.putFleetsFleetIdSquadsSquadIdResponse(params).pipe(
      __map(_r => _r.body as null)
    );
  }

  /**
   * Get fleet wings
   *
   * Return information about wings in a fleet
   *
   * ---
   * Alternate route: `/dev/fleets/{fleet_id}/wings/`
   *
   * Alternate route: `/legacy/fleets/{fleet_id}/wings/`
   *
   * Alternate route: `/v1/fleets/{fleet_id}/wings/`
   *
   * ---
   * This route is cached for up to 5 seconds
   * @param params The `FleetsService.GetFleetsFleetIdWingsParams` containing the following parameters:
   *
   * - `fleet_id`: ID for a fleet
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `language`: Language to use in the response, takes precedence over Accept-Language
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * - `Accept-Language`: Language to use in the response
   *
   * @return A list of fleet wings
   */
  getFleetsFleetIdWingsResponse(params: FleetsService.GetFleetsFleetIdWingsParams): __Observable<__StrictHttpResponse<Array<{id: number, name: string, squads: Array<{id: number, name: string}>}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.language != null) __params = __params.set('language', params.language.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    if (params.AcceptLanguage != null) __headers = __headers.set('Accept-Language', params.AcceptLanguage.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/fleets/${encodeURIComponent(params.fleetId)}/wings/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{id: number, name: string, squads: Array<{id: number, name: string}>}>>;
      })
    );
  }
  /**
   * Get fleet wings
   *
   * Return information about wings in a fleet
   *
   * ---
   * Alternate route: `/dev/fleets/{fleet_id}/wings/`
   *
   * Alternate route: `/legacy/fleets/{fleet_id}/wings/`
   *
   * Alternate route: `/v1/fleets/{fleet_id}/wings/`
   *
   * ---
   * This route is cached for up to 5 seconds
   * @param params The `FleetsService.GetFleetsFleetIdWingsParams` containing the following parameters:
   *
   * - `fleet_id`: ID for a fleet
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `language`: Language to use in the response, takes precedence over Accept-Language
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * - `Accept-Language`: Language to use in the response
   *
   * @return A list of fleet wings
   */
  getFleetsFleetIdWings(params: FleetsService.GetFleetsFleetIdWingsParams): __Observable<Array<{id: number, name: string, squads: Array<{id: number, name: string}>}>> {
    return this.getFleetsFleetIdWingsResponse(params).pipe(
      __map(_r => _r.body as Array<{id: number, name: string, squads: Array<{id: number, name: string}>}>)
    );
  }

  /**
   * Create fleet wing
   *
   * Create a new wing in a fleet
   *
   * ---
   * Alternate route: `/dev/fleets/{fleet_id}/wings/`
   *
   * Alternate route: `/legacy/fleets/{fleet_id}/wings/`
   *
   * Alternate route: `/v1/fleets/{fleet_id}/wings/`
   * @param params The `FleetsService.PostFleetsFleetIdWingsParams` containing the following parameters:
   *
   * - `fleet_id`: ID for a fleet
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * @return Wing created
   */
  postFleetsFleetIdWingsResponse(params: FleetsService.PostFleetsFleetIdWingsParams): __Observable<__StrictHttpResponse<{wing_id: number}>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    let req = new HttpRequest<any>(
      'POST',
      this.rootUrl + `/fleets/${encodeURIComponent(params.fleetId)}/wings/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<{wing_id: number}>;
      })
    );
  }
  /**
   * Create fleet wing
   *
   * Create a new wing in a fleet
   *
   * ---
   * Alternate route: `/dev/fleets/{fleet_id}/wings/`
   *
   * Alternate route: `/legacy/fleets/{fleet_id}/wings/`
   *
   * Alternate route: `/v1/fleets/{fleet_id}/wings/`
   * @param params The `FleetsService.PostFleetsFleetIdWingsParams` containing the following parameters:
   *
   * - `fleet_id`: ID for a fleet
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * @return Wing created
   */
  postFleetsFleetIdWings(params: FleetsService.PostFleetsFleetIdWingsParams): __Observable<{wing_id: number}> {
    return this.postFleetsFleetIdWingsResponse(params).pipe(
      __map(_r => _r.body as {wing_id: number})
    );
  }

  /**
   * Delete fleet wing
   *
   * Delete a fleet wing, only empty wings can be deleted. The wing may contain squads, but the squads must be empty
   *
   * ---
   * Alternate route: `/dev/fleets/{fleet_id}/wings/{wing_id}/`
   *
   * Alternate route: `/legacy/fleets/{fleet_id}/wings/{wing_id}/`
   *
   * Alternate route: `/v1/fleets/{fleet_id}/wings/{wing_id}/`
   * @param params The `FleetsService.DeleteFleetsFleetIdWingsWingIdParams` containing the following parameters:
   *
   * - `wing_id`: The wing to delete
   *
   * - `fleet_id`: ID for a fleet
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   */
  deleteFleetsFleetIdWingsWingIdResponse(params: FleetsService.DeleteFleetsFleetIdWingsWingIdParams): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;


    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    let req = new HttpRequest<any>(
      'DELETE',
      this.rootUrl + `/fleets/${encodeURIComponent(params.fleetId)}/wings/${encodeURIComponent(params.wingId)}/`,
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
   * Delete fleet wing
   *
   * Delete a fleet wing, only empty wings can be deleted. The wing may contain squads, but the squads must be empty
   *
   * ---
   * Alternate route: `/dev/fleets/{fleet_id}/wings/{wing_id}/`
   *
   * Alternate route: `/legacy/fleets/{fleet_id}/wings/{wing_id}/`
   *
   * Alternate route: `/v1/fleets/{fleet_id}/wings/{wing_id}/`
   * @param params The `FleetsService.DeleteFleetsFleetIdWingsWingIdParams` containing the following parameters:
   *
   * - `wing_id`: The wing to delete
   *
   * - `fleet_id`: ID for a fleet
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   */
  deleteFleetsFleetIdWingsWingId(params: FleetsService.DeleteFleetsFleetIdWingsWingIdParams): __Observable<null> {
    return this.deleteFleetsFleetIdWingsWingIdResponse(params).pipe(
      __map(_r => _r.body as null)
    );
  }

  /**
   * Rename fleet wing
   *
   * Rename a fleet wing
   *
   * ---
   * Alternate route: `/dev/fleets/{fleet_id}/wings/{wing_id}/`
   *
   * Alternate route: `/legacy/fleets/{fleet_id}/wings/{wing_id}/`
   *
   * Alternate route: `/v1/fleets/{fleet_id}/wings/{wing_id}/`
   * @param params The `FleetsService.PutFleetsFleetIdWingsWingIdParams` containing the following parameters:
   *
   * - `wing_id`: The wing to rename
   *
   * - `naming`: New name of the wing
   *
   * - `fleet_id`: ID for a fleet
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   */
  putFleetsFleetIdWingsWingIdResponse(params: FleetsService.PutFleetsFleetIdWingsWingIdParams): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    __body = params.naming;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    let req = new HttpRequest<any>(
      'PUT',
      this.rootUrl + `/fleets/${encodeURIComponent(params.fleetId)}/wings/${encodeURIComponent(params.wingId)}/`,
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
   * Rename fleet wing
   *
   * Rename a fleet wing
   *
   * ---
   * Alternate route: `/dev/fleets/{fleet_id}/wings/{wing_id}/`
   *
   * Alternate route: `/legacy/fleets/{fleet_id}/wings/{wing_id}/`
   *
   * Alternate route: `/v1/fleets/{fleet_id}/wings/{wing_id}/`
   * @param params The `FleetsService.PutFleetsFleetIdWingsWingIdParams` containing the following parameters:
   *
   * - `wing_id`: The wing to rename
   *
   * - `naming`: New name of the wing
   *
   * - `fleet_id`: ID for a fleet
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   */
  putFleetsFleetIdWingsWingId(params: FleetsService.PutFleetsFleetIdWingsWingIdParams): __Observable<null> {
    return this.putFleetsFleetIdWingsWingIdResponse(params).pipe(
      __map(_r => _r.body as null)
    );
  }

  /**
   * Create fleet squad
   *
   * Create a new squad in a fleet
   *
   * ---
   * Alternate route: `/dev/fleets/{fleet_id}/wings/{wing_id}/squads/`
   *
   * Alternate route: `/legacy/fleets/{fleet_id}/wings/{wing_id}/squads/`
   *
   * Alternate route: `/v1/fleets/{fleet_id}/wings/{wing_id}/squads/`
   * @param params The `FleetsService.PostFleetsFleetIdWingsWingIdSquadsParams` containing the following parameters:
   *
   * - `wing_id`: The wing_id to create squad in
   *
   * - `fleet_id`: ID for a fleet
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * @return Squad created
   */
  postFleetsFleetIdWingsWingIdSquadsResponse(params: FleetsService.PostFleetsFleetIdWingsWingIdSquadsParams): __Observable<__StrictHttpResponse<{squad_id: number}>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;


    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    let req = new HttpRequest<any>(
      'POST',
      this.rootUrl + `/fleets/${encodeURIComponent(params.fleetId)}/wings/${encodeURIComponent(params.wingId)}/squads/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<{squad_id: number}>;
      })
    );
  }
  /**
   * Create fleet squad
   *
   * Create a new squad in a fleet
   *
   * ---
   * Alternate route: `/dev/fleets/{fleet_id}/wings/{wing_id}/squads/`
   *
   * Alternate route: `/legacy/fleets/{fleet_id}/wings/{wing_id}/squads/`
   *
   * Alternate route: `/v1/fleets/{fleet_id}/wings/{wing_id}/squads/`
   * @param params The `FleetsService.PostFleetsFleetIdWingsWingIdSquadsParams` containing the following parameters:
   *
   * - `wing_id`: The wing_id to create squad in
   *
   * - `fleet_id`: ID for a fleet
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * @return Squad created
   */
  postFleetsFleetIdWingsWingIdSquads(params: FleetsService.PostFleetsFleetIdWingsWingIdSquadsParams): __Observable<{squad_id: number}> {
    return this.postFleetsFleetIdWingsWingIdSquadsResponse(params).pipe(
      __map(_r => _r.body as {squad_id: number})
    );
  }
}

module FleetsService {

  /**
   * Parameters for getCharactersCharacterIdFleet
   */
  export interface GetCharactersCharacterIdFleetParams {

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
   * Parameters for getFleetsFleetId
   */
  export interface GetFleetsFleetIdParams {

    /**
     * ID for a fleet
     */
    fleetId: number;

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
   * Parameters for putFleetsFleetId
   */
  export interface PutFleetsFleetIdParams {

    /**
     * What to update for this fleet
     */
    newSettings: {is_free_move?: boolean, motd?: string};

    /**
     * ID for a fleet
     */
    fleetId: number;

    /**
     * Access token to use if unable to set a header
     */
    token?: string;

    /**
     * The server name you would like data from
     */
    datasource?: 'tranquility' | 'singularity';
  }

  /**
   * Parameters for getFleetsFleetIdMembers
   */
  export interface GetFleetsFleetIdMembersParams {

    /**
     * ID for a fleet
     */
    fleetId: number;

    /**
     * Access token to use if unable to set a header
     */
    token?: string;

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
   * Parameters for postFleetsFleetIdMembers
   */
  export interface PostFleetsFleetIdMembersParams {

    /**
     * Details of the invitation
     */
    invitation: {character_id: number, role: 'fleet_commander' | 'wing_commander' | 'squad_commander' | 'squad_member', squad_id?: number, wing_id?: number};

    /**
     * ID for a fleet
     */
    fleetId: number;

    /**
     * Access token to use if unable to set a header
     */
    token?: string;

    /**
     * The server name you would like data from
     */
    datasource?: 'tranquility' | 'singularity';
  }

  /**
   * Parameters for deleteFleetsFleetIdMembersMemberId
   */
  export interface DeleteFleetsFleetIdMembersMemberIdParams {

    /**
     * The character ID of a member in this fleet
     */
    memberId: number;

    /**
     * ID for a fleet
     */
    fleetId: number;

    /**
     * Access token to use if unable to set a header
     */
    token?: string;

    /**
     * The server name you would like data from
     */
    datasource?: 'tranquility' | 'singularity';
  }

  /**
   * Parameters for putFleetsFleetIdMembersMemberId
   */
  export interface PutFleetsFleetIdMembersMemberIdParams {

    /**
     * Details of the invitation
     */
    movement: {role: 'fleet_commander' | 'wing_commander' | 'squad_commander' | 'squad_member', squad_id?: number, wing_id?: number};

    /**
     * The character ID of a member in this fleet
     */
    memberId: number;

    /**
     * ID for a fleet
     */
    fleetId: number;

    /**
     * Access token to use if unable to set a header
     */
    token?: string;

    /**
     * The server name you would like data from
     */
    datasource?: 'tranquility' | 'singularity';
  }

  /**
   * Parameters for deleteFleetsFleetIdSquadsSquadId
   */
  export interface DeleteFleetsFleetIdSquadsSquadIdParams {

    /**
     * The squad to delete
     */
    squadId: number;

    /**
     * ID for a fleet
     */
    fleetId: number;

    /**
     * Access token to use if unable to set a header
     */
    token?: string;

    /**
     * The server name you would like data from
     */
    datasource?: 'tranquility' | 'singularity';
  }

  /**
   * Parameters for putFleetsFleetIdSquadsSquadId
   */
  export interface PutFleetsFleetIdSquadsSquadIdParams {

    /**
     * The squad to rename
     */
    squadId: number;

    /**
     * New name of the squad
     */
    naming: {name: string};

    /**
     * ID for a fleet
     */
    fleetId: number;

    /**
     * Access token to use if unable to set a header
     */
    token?: string;

    /**
     * The server name you would like data from
     */
    datasource?: 'tranquility' | 'singularity';
  }

  /**
   * Parameters for getFleetsFleetIdWings
   */
  export interface GetFleetsFleetIdWingsParams {

    /**
     * ID for a fleet
     */
    fleetId: number;

    /**
     * Access token to use if unable to set a header
     */
    token?: string;

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
   * Parameters for postFleetsFleetIdWings
   */
  export interface PostFleetsFleetIdWingsParams {

    /**
     * ID for a fleet
     */
    fleetId: number;

    /**
     * Access token to use if unable to set a header
     */
    token?: string;

    /**
     * The server name you would like data from
     */
    datasource?: 'tranquility' | 'singularity';
  }

  /**
   * Parameters for deleteFleetsFleetIdWingsWingId
   */
  export interface DeleteFleetsFleetIdWingsWingIdParams {

    /**
     * The wing to delete
     */
    wingId: number;

    /**
     * ID for a fleet
     */
    fleetId: number;

    /**
     * Access token to use if unable to set a header
     */
    token?: string;

    /**
     * The server name you would like data from
     */
    datasource?: 'tranquility' | 'singularity';
  }

  /**
   * Parameters for putFleetsFleetIdWingsWingId
   */
  export interface PutFleetsFleetIdWingsWingIdParams {

    /**
     * The wing to rename
     */
    wingId: number;

    /**
     * New name of the wing
     */
    naming: {name: string};

    /**
     * ID for a fleet
     */
    fleetId: number;

    /**
     * Access token to use if unable to set a header
     */
    token?: string;

    /**
     * The server name you would like data from
     */
    datasource?: 'tranquility' | 'singularity';
  }

  /**
   * Parameters for postFleetsFleetIdWingsWingIdSquads
   */
  export interface PostFleetsFleetIdWingsWingIdSquadsParams {

    /**
     * The wing_id to create squad in
     */
    wingId: number;

    /**
     * ID for a fleet
     */
    fleetId: number;

    /**
     * Access token to use if unable to set a header
     */
    token?: string;

    /**
     * The server name you would like data from
     */
    datasource?: 'tranquility' | 'singularity';
  }
}

export { FleetsService }
