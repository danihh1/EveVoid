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
class ContactsService extends __BaseService {
  static readonly getAlliancesAllianceIdContactsPath = '/alliances/{alliance_id}/contacts/';
  static readonly getAlliancesAllianceIdContactsLabelsPath = '/alliances/{alliance_id}/contacts/labels/';
  static readonly deleteCharactersCharacterIdContactsPath = '/characters/{character_id}/contacts/';
  static readonly getCharactersCharacterIdContactsPath = '/characters/{character_id}/contacts/';
  static readonly postCharactersCharacterIdContactsPath = '/characters/{character_id}/contacts/';
  static readonly putCharactersCharacterIdContactsPath = '/characters/{character_id}/contacts/';
  static readonly getCharactersCharacterIdContactsLabelsPath = '/characters/{character_id}/contacts/labels/';
  static readonly getCorporationsCorporationIdContactsPath = '/corporations/{corporation_id}/contacts/';
  static readonly getCorporationsCorporationIdContactsLabelsPath = '/corporations/{corporation_id}/contacts/labels/';

  constructor(
    config: __Configuration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * Get alliance contacts
   *
   * Return contacts of an alliance
   *
   * ---
   * Alternate route: `/dev/alliances/{alliance_id}/contacts/`
   *
   * Alternate route: `/v2/alliances/{alliance_id}/contacts/`
   *
   * ---
   * This route is cached for up to 300 seconds
   * @param params The `ContactsService.GetAlliancesAllianceIdContactsParams` containing the following parameters:
   *
   * - `alliance_id`: An EVE alliance ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `page`: Which page of results to return
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of contacts
   */
  getAlliancesAllianceIdContactsResponse(params: ContactsService.GetAlliancesAllianceIdContactsParams): __Observable<__StrictHttpResponse<Array<{contact_id: number, contact_type: 'character' | 'corporation' | 'alliance' | 'faction', label_ids?: Array<number>, standing: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.page != null) __params = __params.set('page', params.page.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/alliances/${encodeURIComponent(params.allianceId)}/contacts/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{contact_id: number, contact_type: 'character' | 'corporation' | 'alliance' | 'faction', label_ids?: Array<number>, standing: number}>>;
      })
    );
  }
  /**
   * Get alliance contacts
   *
   * Return contacts of an alliance
   *
   * ---
   * Alternate route: `/dev/alliances/{alliance_id}/contacts/`
   *
   * Alternate route: `/v2/alliances/{alliance_id}/contacts/`
   *
   * ---
   * This route is cached for up to 300 seconds
   * @param params The `ContactsService.GetAlliancesAllianceIdContactsParams` containing the following parameters:
   *
   * - `alliance_id`: An EVE alliance ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `page`: Which page of results to return
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of contacts
   */
  getAlliancesAllianceIdContacts(params: ContactsService.GetAlliancesAllianceIdContactsParams): __Observable<Array<{contact_id: number, contact_type: 'character' | 'corporation' | 'alliance' | 'faction', label_ids?: Array<number>, standing: number}>> {
    return this.getAlliancesAllianceIdContactsResponse(params).pipe(
      __map(_r => _r.body as Array<{contact_id: number, contact_type: 'character' | 'corporation' | 'alliance' | 'faction', label_ids?: Array<number>, standing: number}>)
    );
  }

  /**
   * Get alliance contact labels
   *
   * Return custom labels for an alliance's contacts
   *
   * ---
   * Alternate route: `/dev/alliances/{alliance_id}/contacts/labels/`
   *
   * Alternate route: `/legacy/alliances/{alliance_id}/contacts/labels/`
   *
   * Alternate route: `/v1/alliances/{alliance_id}/contacts/labels/`
   *
   * ---
   * This route is cached for up to 300 seconds
   * @param params The `ContactsService.GetAlliancesAllianceIdContactsLabelsParams` containing the following parameters:
   *
   * - `alliance_id`: An EVE alliance ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of alliance contact labels
   */
  getAlliancesAllianceIdContactsLabelsResponse(params: ContactsService.GetAlliancesAllianceIdContactsLabelsParams): __Observable<__StrictHttpResponse<Array<{label_id: number, label_name: string}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/alliances/${encodeURIComponent(params.allianceId)}/contacts/labels/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{label_id: number, label_name: string}>>;
      })
    );
  }
  /**
   * Get alliance contact labels
   *
   * Return custom labels for an alliance's contacts
   *
   * ---
   * Alternate route: `/dev/alliances/{alliance_id}/contacts/labels/`
   *
   * Alternate route: `/legacy/alliances/{alliance_id}/contacts/labels/`
   *
   * Alternate route: `/v1/alliances/{alliance_id}/contacts/labels/`
   *
   * ---
   * This route is cached for up to 300 seconds
   * @param params The `ContactsService.GetAlliancesAllianceIdContactsLabelsParams` containing the following parameters:
   *
   * - `alliance_id`: An EVE alliance ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of alliance contact labels
   */
  getAlliancesAllianceIdContactsLabels(params: ContactsService.GetAlliancesAllianceIdContactsLabelsParams): __Observable<Array<{label_id: number, label_name: string}>> {
    return this.getAlliancesAllianceIdContactsLabelsResponse(params).pipe(
      __map(_r => _r.body as Array<{label_id: number, label_name: string}>)
    );
  }

  /**
   * Delete contacts
   *
   * Bulk delete contacts
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/contacts/`
   *
   * Alternate route: `/v2/characters/{character_id}/contacts/`
   * @param params The `ContactsService.DeleteCharactersCharacterIdContactsParams` containing the following parameters:
   *
   * - `contact_ids`: A list of contacts to delete
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   */
  deleteCharactersCharacterIdContactsResponse(params: ContactsService.DeleteCharactersCharacterIdContactsParams): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    (params.contactIds || []).forEach(val => {if (val != null) __params = __params.append('contact_ids', val.toString())});

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    let req = new HttpRequest<any>(
      'DELETE',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/contacts/`,
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
   * Delete contacts
   *
   * Bulk delete contacts
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/contacts/`
   *
   * Alternate route: `/v2/characters/{character_id}/contacts/`
   * @param params The `ContactsService.DeleteCharactersCharacterIdContactsParams` containing the following parameters:
   *
   * - `contact_ids`: A list of contacts to delete
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   */
  deleteCharactersCharacterIdContacts(params: ContactsService.DeleteCharactersCharacterIdContactsParams): __Observable<null> {
    return this.deleteCharactersCharacterIdContactsResponse(params).pipe(
      __map(_r => _r.body as null)
    );
  }

  /**
   * Get contacts
   *
   * Return contacts of a character
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/contacts/`
   *
   * Alternate route: `/v2/characters/{character_id}/contacts/`
   *
   * ---
   * This route is cached for up to 300 seconds
   * @param params The `ContactsService.GetCharactersCharacterIdContactsParams` containing the following parameters:
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
   * @return A list of contacts
   */
  getCharactersCharacterIdContactsResponse(params: ContactsService.GetCharactersCharacterIdContactsParams): __Observable<__StrictHttpResponse<Array<{contact_id: number, contact_type: 'character' | 'corporation' | 'alliance' | 'faction', is_blocked?: boolean, is_watched?: boolean, label_ids?: Array<number>, standing: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.page != null) __params = __params.set('page', params.page.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/contacts/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{contact_id: number, contact_type: 'character' | 'corporation' | 'alliance' | 'faction', is_blocked?: boolean, is_watched?: boolean, label_ids?: Array<number>, standing: number}>>;
      })
    );
  }
  /**
   * Get contacts
   *
   * Return contacts of a character
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/contacts/`
   *
   * Alternate route: `/v2/characters/{character_id}/contacts/`
   *
   * ---
   * This route is cached for up to 300 seconds
   * @param params The `ContactsService.GetCharactersCharacterIdContactsParams` containing the following parameters:
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
   * @return A list of contacts
   */
  getCharactersCharacterIdContacts(params: ContactsService.GetCharactersCharacterIdContactsParams): __Observable<Array<{contact_id: number, contact_type: 'character' | 'corporation' | 'alliance' | 'faction', is_blocked?: boolean, is_watched?: boolean, label_ids?: Array<number>, standing: number}>> {
    return this.getCharactersCharacterIdContactsResponse(params).pipe(
      __map(_r => _r.body as Array<{contact_id: number, contact_type: 'character' | 'corporation' | 'alliance' | 'faction', is_blocked?: boolean, is_watched?: boolean, label_ids?: Array<number>, standing: number}>)
    );
  }

  /**
   * Add contacts
   *
   * Bulk add contacts with same settings
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/contacts/`
   *
   * Alternate route: `/v2/characters/{character_id}/contacts/`
   * @param params The `ContactsService.PostCharactersCharacterIdContactsParams` containing the following parameters:
   *
   * - `standing`: Standing for the contact
   *
   * - `contact_ids`: A list of contacts
   *
   * - `character_id`: An EVE character ID
   *
   * - `watched`: Whether the contact should be watched, note this is only effective on characters
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `label_ids`: Add custom labels to the new contact
   *
   * - `datasource`: The server name you would like data from
   *
   * @return A list of contact ids that successfully created
   */
  postCharactersCharacterIdContactsResponse(params: ContactsService.PostCharactersCharacterIdContactsParams): __Observable<__StrictHttpResponse<Array<number>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.standing != null) __params = __params.set('standing', params.standing.toString());
    __body = params.contactIds;

    if (params.watched != null) __params = __params.set('watched', params.watched.toString());
    if (params.token != null) __params = __params.set('token', params.token.toString());
    (params.labelIds || []).forEach(val => {if (val != null) __params = __params.append('label_ids', val.toString())});
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    let req = new HttpRequest<any>(
      'POST',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/contacts/`,
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
   * Add contacts
   *
   * Bulk add contacts with same settings
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/contacts/`
   *
   * Alternate route: `/v2/characters/{character_id}/contacts/`
   * @param params The `ContactsService.PostCharactersCharacterIdContactsParams` containing the following parameters:
   *
   * - `standing`: Standing for the contact
   *
   * - `contact_ids`: A list of contacts
   *
   * - `character_id`: An EVE character ID
   *
   * - `watched`: Whether the contact should be watched, note this is only effective on characters
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `label_ids`: Add custom labels to the new contact
   *
   * - `datasource`: The server name you would like data from
   *
   * @return A list of contact ids that successfully created
   */
  postCharactersCharacterIdContacts(params: ContactsService.PostCharactersCharacterIdContactsParams): __Observable<Array<number>> {
    return this.postCharactersCharacterIdContactsResponse(params).pipe(
      __map(_r => _r.body as Array<number>)
    );
  }

  /**
   * Edit contacts
   *
   * Bulk edit contacts with same settings
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/contacts/`
   *
   * Alternate route: `/v2/characters/{character_id}/contacts/`
   * @param params The `ContactsService.PutCharactersCharacterIdContactsParams` containing the following parameters:
   *
   * - `standing`: Standing for the contact
   *
   * - `contact_ids`: A list of contacts
   *
   * - `character_id`: An EVE character ID
   *
   * - `watched`: Whether the contact should be watched, note this is only effective on characters
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `label_ids`: Add custom labels to the contact
   *
   * - `datasource`: The server name you would like data from
   */
  putCharactersCharacterIdContactsResponse(params: ContactsService.PutCharactersCharacterIdContactsParams): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.standing != null) __params = __params.set('standing', params.standing.toString());
    __body = params.contactIds;

    if (params.watched != null) __params = __params.set('watched', params.watched.toString());
    if (params.token != null) __params = __params.set('token', params.token.toString());
    (params.labelIds || []).forEach(val => {if (val != null) __params = __params.append('label_ids', val.toString())});
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    let req = new HttpRequest<any>(
      'PUT',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/contacts/`,
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
   * Edit contacts
   *
   * Bulk edit contacts with same settings
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/contacts/`
   *
   * Alternate route: `/v2/characters/{character_id}/contacts/`
   * @param params The `ContactsService.PutCharactersCharacterIdContactsParams` containing the following parameters:
   *
   * - `standing`: Standing for the contact
   *
   * - `contact_ids`: A list of contacts
   *
   * - `character_id`: An EVE character ID
   *
   * - `watched`: Whether the contact should be watched, note this is only effective on characters
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `label_ids`: Add custom labels to the contact
   *
   * - `datasource`: The server name you would like data from
   */
  putCharactersCharacterIdContacts(params: ContactsService.PutCharactersCharacterIdContactsParams): __Observable<null> {
    return this.putCharactersCharacterIdContactsResponse(params).pipe(
      __map(_r => _r.body as null)
    );
  }

  /**
   * Get contact labels
   *
   * Return custom labels for a character's contacts
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/contacts/labels/`
   *
   * Alternate route: `/legacy/characters/{character_id}/contacts/labels/`
   *
   * Alternate route: `/v1/characters/{character_id}/contacts/labels/`
   *
   * ---
   * This route is cached for up to 300 seconds
   * @param params The `ContactsService.GetCharactersCharacterIdContactsLabelsParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of contact labels
   */
  getCharactersCharacterIdContactsLabelsResponse(params: ContactsService.GetCharactersCharacterIdContactsLabelsParams): __Observable<__StrictHttpResponse<Array<{label_id: number, label_name: string}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/contacts/labels/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{label_id: number, label_name: string}>>;
      })
    );
  }
  /**
   * Get contact labels
   *
   * Return custom labels for a character's contacts
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/contacts/labels/`
   *
   * Alternate route: `/legacy/characters/{character_id}/contacts/labels/`
   *
   * Alternate route: `/v1/characters/{character_id}/contacts/labels/`
   *
   * ---
   * This route is cached for up to 300 seconds
   * @param params The `ContactsService.GetCharactersCharacterIdContactsLabelsParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of contact labels
   */
  getCharactersCharacterIdContactsLabels(params: ContactsService.GetCharactersCharacterIdContactsLabelsParams): __Observable<Array<{label_id: number, label_name: string}>> {
    return this.getCharactersCharacterIdContactsLabelsResponse(params).pipe(
      __map(_r => _r.body as Array<{label_id: number, label_name: string}>)
    );
  }

  /**
   * Get corporation contacts
   *
   * Return contacts of a corporation
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/contacts/`
   *
   * Alternate route: `/v2/corporations/{corporation_id}/contacts/`
   *
   * ---
   * This route is cached for up to 300 seconds
   * @param params The `ContactsService.GetCorporationsCorporationIdContactsParams` containing the following parameters:
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
   * @return A list of contacts
   */
  getCorporationsCorporationIdContactsResponse(params: ContactsService.GetCorporationsCorporationIdContactsParams): __Observable<__StrictHttpResponse<Array<{contact_id: number, contact_type: 'character' | 'corporation' | 'alliance' | 'faction', is_watched?: boolean, label_ids?: Array<number>, standing: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.page != null) __params = __params.set('page', params.page.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/corporations/${encodeURIComponent(params.corporationId)}/contacts/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{contact_id: number, contact_type: 'character' | 'corporation' | 'alliance' | 'faction', is_watched?: boolean, label_ids?: Array<number>, standing: number}>>;
      })
    );
  }
  /**
   * Get corporation contacts
   *
   * Return contacts of a corporation
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/contacts/`
   *
   * Alternate route: `/v2/corporations/{corporation_id}/contacts/`
   *
   * ---
   * This route is cached for up to 300 seconds
   * @param params The `ContactsService.GetCorporationsCorporationIdContactsParams` containing the following parameters:
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
   * @return A list of contacts
   */
  getCorporationsCorporationIdContacts(params: ContactsService.GetCorporationsCorporationIdContactsParams): __Observable<Array<{contact_id: number, contact_type: 'character' | 'corporation' | 'alliance' | 'faction', is_watched?: boolean, label_ids?: Array<number>, standing: number}>> {
    return this.getCorporationsCorporationIdContactsResponse(params).pipe(
      __map(_r => _r.body as Array<{contact_id: number, contact_type: 'character' | 'corporation' | 'alliance' | 'faction', is_watched?: boolean, label_ids?: Array<number>, standing: number}>)
    );
  }

  /**
   * Get corporation contact labels
   *
   * Return custom labels for a corporation's contacts
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/contacts/labels/`
   *
   * Alternate route: `/legacy/corporations/{corporation_id}/contacts/labels/`
   *
   * Alternate route: `/v1/corporations/{corporation_id}/contacts/labels/`
   *
   * ---
   * This route is cached for up to 300 seconds
   * @param params The `ContactsService.GetCorporationsCorporationIdContactsLabelsParams` containing the following parameters:
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of corporation contact labels
   */
  getCorporationsCorporationIdContactsLabelsResponse(params: ContactsService.GetCorporationsCorporationIdContactsLabelsParams): __Observable<__StrictHttpResponse<Array<{label_id: number, label_name: string}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/corporations/${encodeURIComponent(params.corporationId)}/contacts/labels/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{label_id: number, label_name: string}>>;
      })
    );
  }
  /**
   * Get corporation contact labels
   *
   * Return custom labels for a corporation's contacts
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/contacts/labels/`
   *
   * Alternate route: `/legacy/corporations/{corporation_id}/contacts/labels/`
   *
   * Alternate route: `/v1/corporations/{corporation_id}/contacts/labels/`
   *
   * ---
   * This route is cached for up to 300 seconds
   * @param params The `ContactsService.GetCorporationsCorporationIdContactsLabelsParams` containing the following parameters:
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of corporation contact labels
   */
  getCorporationsCorporationIdContactsLabels(params: ContactsService.GetCorporationsCorporationIdContactsLabelsParams): __Observable<Array<{label_id: number, label_name: string}>> {
    return this.getCorporationsCorporationIdContactsLabelsResponse(params).pipe(
      __map(_r => _r.body as Array<{label_id: number, label_name: string}>)
    );
  }
}

module ContactsService {

  /**
   * Parameters for getAlliancesAllianceIdContacts
   */
  export interface GetAlliancesAllianceIdContactsParams {

    /**
     * An EVE alliance ID
     */
    allianceId: number;

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
   * Parameters for getAlliancesAllianceIdContactsLabels
   */
  export interface GetAlliancesAllianceIdContactsLabelsParams {

    /**
     * An EVE alliance ID
     */
    allianceId: number;

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
   * Parameters for deleteCharactersCharacterIdContacts
   */
  export interface DeleteCharactersCharacterIdContactsParams {

    /**
     * A list of contacts to delete
     */
    contactIds: Array<number>;

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
  }

  /**
   * Parameters for getCharactersCharacterIdContacts
   */
  export interface GetCharactersCharacterIdContactsParams {

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
   * Parameters for postCharactersCharacterIdContacts
   */
  export interface PostCharactersCharacterIdContactsParams {

    /**
     * Standing for the contact
     */
    standing: number;

    /**
     * A list of contacts
     */
    contactIds: Array<number>;

    /**
     * An EVE character ID
     */
    characterId: number;

    /**
     * Whether the contact should be watched, note this is only effective on characters
     */
    watched?: boolean;

    /**
     * Access token to use if unable to set a header
     */
    token?: string;

    /**
     * Add custom labels to the new contact
     */
    labelIds?: Array<number>;

    /**
     * The server name you would like data from
     */
    datasource?: 'tranquility' | 'singularity';
  }

  /**
   * Parameters for putCharactersCharacterIdContacts
   */
  export interface PutCharactersCharacterIdContactsParams {

    /**
     * Standing for the contact
     */
    standing: number;

    /**
     * A list of contacts
     */
    contactIds: Array<number>;

    /**
     * An EVE character ID
     */
    characterId: number;

    /**
     * Whether the contact should be watched, note this is only effective on characters
     */
    watched?: boolean;

    /**
     * Access token to use if unable to set a header
     */
    token?: string;

    /**
     * Add custom labels to the contact
     */
    labelIds?: Array<number>;

    /**
     * The server name you would like data from
     */
    datasource?: 'tranquility' | 'singularity';
  }

  /**
   * Parameters for getCharactersCharacterIdContactsLabels
   */
  export interface GetCharactersCharacterIdContactsLabelsParams {

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
   * Parameters for getCorporationsCorporationIdContacts
   */
  export interface GetCorporationsCorporationIdContactsParams {

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
   * Parameters for getCorporationsCorporationIdContactsLabels
   */
  export interface GetCorporationsCorporationIdContactsLabelsParams {

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
}

export { ContactsService }
