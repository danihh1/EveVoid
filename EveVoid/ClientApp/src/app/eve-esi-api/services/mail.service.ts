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
class MailService extends __BaseService {
  static readonly getCharactersCharacterIdMailPath = '/characters/{character_id}/mail/';
  static readonly postCharactersCharacterIdMailPath = '/characters/{character_id}/mail/';
  static readonly getCharactersCharacterIdMailLabelsPath = '/characters/{character_id}/mail/labels/';
  static readonly postCharactersCharacterIdMailLabelsPath = '/characters/{character_id}/mail/labels/';
  static readonly deleteCharactersCharacterIdMailLabelsLabelIdPath = '/characters/{character_id}/mail/labels/{label_id}/';
  static readonly getCharactersCharacterIdMailListsPath = '/characters/{character_id}/mail/lists/';
  static readonly deleteCharactersCharacterIdMailMailIdPath = '/characters/{character_id}/mail/{mail_id}/';
  static readonly getCharactersCharacterIdMailMailIdPath = '/characters/{character_id}/mail/{mail_id}/';
  static readonly putCharactersCharacterIdMailMailIdPath = '/characters/{character_id}/mail/{mail_id}/';

  constructor(
    config: __Configuration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * Return mail headers
   *
   * Return the 50 most recent mail headers belonging to the character that match the query criteria. Queries can be filtered by label, and last_mail_id can be used to paginate backwards
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/mail/`
   *
   * Alternate route: `/legacy/characters/{character_id}/mail/`
   *
   * Alternate route: `/v1/characters/{character_id}/mail/`
   *
   * ---
   * This route is cached for up to 30 seconds
   * @param params The `MailService.GetCharactersCharacterIdMailParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `last_mail_id`: List only mail with an ID lower than the given ID, if present
   *
   * - `labels`: Fetch only mails that match one or more of the given labels
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return The requested mail
   */
  getCharactersCharacterIdMailResponse(params: MailService.GetCharactersCharacterIdMailParams): __Observable<__StrictHttpResponse<Array<{from?: number, is_read?: boolean, labels?: Array<number>, mail_id?: number, recipients?: Array<{recipient_id: number, recipient_type: 'alliance' | 'character' | 'corporation' | 'mailing_list'}>, subject?: string, timestamp?: string}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.lastMailId != null) __params = __params.set('last_mail_id', params.lastMailId.toString());
    (params.labels || []).forEach(val => {if (val != null) __params = __params.append('labels', val.toString())});
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/mail/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{from?: number, is_read?: boolean, labels?: Array<number>, mail_id?: number, recipients?: Array<{recipient_id: number, recipient_type: 'alliance' | 'character' | 'corporation' | 'mailing_list'}>, subject?: string, timestamp?: string}>>;
      })
    );
  }
  /**
   * Return mail headers
   *
   * Return the 50 most recent mail headers belonging to the character that match the query criteria. Queries can be filtered by label, and last_mail_id can be used to paginate backwards
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/mail/`
   *
   * Alternate route: `/legacy/characters/{character_id}/mail/`
   *
   * Alternate route: `/v1/characters/{character_id}/mail/`
   *
   * ---
   * This route is cached for up to 30 seconds
   * @param params The `MailService.GetCharactersCharacterIdMailParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `last_mail_id`: List only mail with an ID lower than the given ID, if present
   *
   * - `labels`: Fetch only mails that match one or more of the given labels
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return The requested mail
   */
  getCharactersCharacterIdMail(params: MailService.GetCharactersCharacterIdMailParams): __Observable<Array<{from?: number, is_read?: boolean, labels?: Array<number>, mail_id?: number, recipients?: Array<{recipient_id: number, recipient_type: 'alliance' | 'character' | 'corporation' | 'mailing_list'}>, subject?: string, timestamp?: string}>> {
    return this.getCharactersCharacterIdMailResponse(params).pipe(
      __map(_r => _r.body as Array<{from?: number, is_read?: boolean, labels?: Array<number>, mail_id?: number, recipients?: Array<{recipient_id: number, recipient_type: 'alliance' | 'character' | 'corporation' | 'mailing_list'}>, subject?: string, timestamp?: string}>)
    );
  }

  /**
   * Send a new mail
   *
   * Create and send a new mail
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/mail/`
   *
   * Alternate route: `/legacy/characters/{character_id}/mail/`
   *
   * Alternate route: `/v1/characters/{character_id}/mail/`
   * @param params The `MailService.PostCharactersCharacterIdMailParams` containing the following parameters:
   *
   * - `mail`: The mail to send
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * @return Mail created
   */
  postCharactersCharacterIdMailResponse(params: MailService.PostCharactersCharacterIdMailParams): __Observable<__StrictHttpResponse<number>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    __body = params.mail;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    let req = new HttpRequest<any>(
      'POST',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/mail/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'text'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return (_r as HttpResponse<any>).clone({ body: parseFloat((_r as HttpResponse<any>).body as string) }) as __StrictHttpResponse<number>
      })
    );
  }
  /**
   * Send a new mail
   *
   * Create and send a new mail
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/mail/`
   *
   * Alternate route: `/legacy/characters/{character_id}/mail/`
   *
   * Alternate route: `/v1/characters/{character_id}/mail/`
   * @param params The `MailService.PostCharactersCharacterIdMailParams` containing the following parameters:
   *
   * - `mail`: The mail to send
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * @return Mail created
   */
  postCharactersCharacterIdMail(params: MailService.PostCharactersCharacterIdMailParams): __Observable<number> {
    return this.postCharactersCharacterIdMailResponse(params).pipe(
      __map(_r => _r.body as number)
    );
  }

  /**
   * Get mail labels and unread counts
   *
   * Return a list of the users mail labels, unread counts for each label and a total unread count.
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/mail/labels/`
   *
   * Alternate route: `/v3/characters/{character_id}/mail/labels/`
   *
   * ---
   * This route is cached for up to 30 seconds
   * @param params The `MailService.GetCharactersCharacterIdMailLabelsParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of mail labels and unread counts
   */
  getCharactersCharacterIdMailLabelsResponse(params: MailService.GetCharactersCharacterIdMailLabelsParams): __Observable<__StrictHttpResponse<{labels?: Array<{color?: '#0000fe' | '#006634' | '#0099ff' | '#00ff33' | '#01ffff' | '#349800' | '#660066' | '#666666' | '#999999' | '#99ffff' | '#9a0000' | '#ccff9a' | '#e6e6e6' | '#fe0000' | '#ff6600' | '#ffff01' | '#ffffcd' | '#ffffff', label_id?: number, name?: string, unread_count?: number}>, total_unread_count?: number}>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/mail/labels/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<{labels?: Array<{color?: '#0000fe' | '#006634' | '#0099ff' | '#00ff33' | '#01ffff' | '#349800' | '#660066' | '#666666' | '#999999' | '#99ffff' | '#9a0000' | '#ccff9a' | '#e6e6e6' | '#fe0000' | '#ff6600' | '#ffff01' | '#ffffcd' | '#ffffff', label_id?: number, name?: string, unread_count?: number}>, total_unread_count?: number}>;
      })
    );
  }
  /**
   * Get mail labels and unread counts
   *
   * Return a list of the users mail labels, unread counts for each label and a total unread count.
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/mail/labels/`
   *
   * Alternate route: `/v3/characters/{character_id}/mail/labels/`
   *
   * ---
   * This route is cached for up to 30 seconds
   * @param params The `MailService.GetCharactersCharacterIdMailLabelsParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of mail labels and unread counts
   */
  getCharactersCharacterIdMailLabels(params: MailService.GetCharactersCharacterIdMailLabelsParams): __Observable<{labels?: Array<{color?: '#0000fe' | '#006634' | '#0099ff' | '#00ff33' | '#01ffff' | '#349800' | '#660066' | '#666666' | '#999999' | '#99ffff' | '#9a0000' | '#ccff9a' | '#e6e6e6' | '#fe0000' | '#ff6600' | '#ffff01' | '#ffffcd' | '#ffffff', label_id?: number, name?: string, unread_count?: number}>, total_unread_count?: number}> {
    return this.getCharactersCharacterIdMailLabelsResponse(params).pipe(
      __map(_r => _r.body as {labels?: Array<{color?: '#0000fe' | '#006634' | '#0099ff' | '#00ff33' | '#01ffff' | '#349800' | '#660066' | '#666666' | '#999999' | '#99ffff' | '#9a0000' | '#ccff9a' | '#e6e6e6' | '#fe0000' | '#ff6600' | '#ffff01' | '#ffffcd' | '#ffffff', label_id?: number, name?: string, unread_count?: number}>, total_unread_count?: number})
    );
  }

  /**
   * Create a mail label
   *
   * Create a mail label
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/mail/labels/`
   *
   * Alternate route: `/legacy/characters/{character_id}/mail/labels/`
   *
   * Alternate route: `/v2/characters/{character_id}/mail/labels/`
   * @param params The `MailService.PostCharactersCharacterIdMailLabelsParams` containing the following parameters:
   *
   * - `label`: Label to create
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * @return Label created
   */
  postCharactersCharacterIdMailLabelsResponse(params: MailService.PostCharactersCharacterIdMailLabelsParams): __Observable<__StrictHttpResponse<number>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    __body = params.label;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    let req = new HttpRequest<any>(
      'POST',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/mail/labels/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'text'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return (_r as HttpResponse<any>).clone({ body: parseFloat((_r as HttpResponse<any>).body as string) }) as __StrictHttpResponse<number>
      })
    );
  }
  /**
   * Create a mail label
   *
   * Create a mail label
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/mail/labels/`
   *
   * Alternate route: `/legacy/characters/{character_id}/mail/labels/`
   *
   * Alternate route: `/v2/characters/{character_id}/mail/labels/`
   * @param params The `MailService.PostCharactersCharacterIdMailLabelsParams` containing the following parameters:
   *
   * - `label`: Label to create
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * @return Label created
   */
  postCharactersCharacterIdMailLabels(params: MailService.PostCharactersCharacterIdMailLabelsParams): __Observable<number> {
    return this.postCharactersCharacterIdMailLabelsResponse(params).pipe(
      __map(_r => _r.body as number)
    );
  }

  /**
   * Delete a mail label
   *
   * Delete a mail label
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/mail/labels/{label_id}/`
   *
   * Alternate route: `/legacy/characters/{character_id}/mail/labels/{label_id}/`
   *
   * Alternate route: `/v1/characters/{character_id}/mail/labels/{label_id}/`
   * @param params The `MailService.DeleteCharactersCharacterIdMailLabelsLabelIdParams` containing the following parameters:
   *
   * - `label_id`: An EVE label id
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   */
  deleteCharactersCharacterIdMailLabelsLabelIdResponse(params: MailService.DeleteCharactersCharacterIdMailLabelsLabelIdParams): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;


    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    let req = new HttpRequest<any>(
      'DELETE',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/mail/labels/${encodeURIComponent(params.labelId)}/`,
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
   * Delete a mail label
   *
   * Delete a mail label
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/mail/labels/{label_id}/`
   *
   * Alternate route: `/legacy/characters/{character_id}/mail/labels/{label_id}/`
   *
   * Alternate route: `/v1/characters/{character_id}/mail/labels/{label_id}/`
   * @param params The `MailService.DeleteCharactersCharacterIdMailLabelsLabelIdParams` containing the following parameters:
   *
   * - `label_id`: An EVE label id
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   */
  deleteCharactersCharacterIdMailLabelsLabelId(params: MailService.DeleteCharactersCharacterIdMailLabelsLabelIdParams): __Observable<null> {
    return this.deleteCharactersCharacterIdMailLabelsLabelIdResponse(params).pipe(
      __map(_r => _r.body as null)
    );
  }

  /**
   * Return mailing list subscriptions
   *
   * Return all mailing lists that the character is subscribed to
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/mail/lists/`
   *
   * Alternate route: `/legacy/characters/{character_id}/mail/lists/`
   *
   * Alternate route: `/v1/characters/{character_id}/mail/lists/`
   *
   * ---
   * This route is cached for up to 120 seconds
   * @param params The `MailService.GetCharactersCharacterIdMailListsParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Mailing lists
   */
  getCharactersCharacterIdMailListsResponse(params: MailService.GetCharactersCharacterIdMailListsParams): __Observable<__StrictHttpResponse<Array<{mailing_list_id: number, name: string}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/mail/lists/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{mailing_list_id: number, name: string}>>;
      })
    );
  }
  /**
   * Return mailing list subscriptions
   *
   * Return all mailing lists that the character is subscribed to
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/mail/lists/`
   *
   * Alternate route: `/legacy/characters/{character_id}/mail/lists/`
   *
   * Alternate route: `/v1/characters/{character_id}/mail/lists/`
   *
   * ---
   * This route is cached for up to 120 seconds
   * @param params The `MailService.GetCharactersCharacterIdMailListsParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Mailing lists
   */
  getCharactersCharacterIdMailLists(params: MailService.GetCharactersCharacterIdMailListsParams): __Observable<Array<{mailing_list_id: number, name: string}>> {
    return this.getCharactersCharacterIdMailListsResponse(params).pipe(
      __map(_r => _r.body as Array<{mailing_list_id: number, name: string}>)
    );
  }

  /**
   * Delete a mail
   *
   * Delete a mail
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/mail/{mail_id}/`
   *
   * Alternate route: `/legacy/characters/{character_id}/mail/{mail_id}/`
   *
   * Alternate route: `/v1/characters/{character_id}/mail/{mail_id}/`
   * @param params The `MailService.DeleteCharactersCharacterIdMailMailIdParams` containing the following parameters:
   *
   * - `mail_id`: An EVE mail ID
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   */
  deleteCharactersCharacterIdMailMailIdResponse(params: MailService.DeleteCharactersCharacterIdMailMailIdParams): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;


    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    let req = new HttpRequest<any>(
      'DELETE',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/mail/${encodeURIComponent(params.mailId)}/`,
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
   * Delete a mail
   *
   * Delete a mail
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/mail/{mail_id}/`
   *
   * Alternate route: `/legacy/characters/{character_id}/mail/{mail_id}/`
   *
   * Alternate route: `/v1/characters/{character_id}/mail/{mail_id}/`
   * @param params The `MailService.DeleteCharactersCharacterIdMailMailIdParams` containing the following parameters:
   *
   * - `mail_id`: An EVE mail ID
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   */
  deleteCharactersCharacterIdMailMailId(params: MailService.DeleteCharactersCharacterIdMailMailIdParams): __Observable<null> {
    return this.deleteCharactersCharacterIdMailMailIdResponse(params).pipe(
      __map(_r => _r.body as null)
    );
  }

  /**
   * Return a mail
   *
   * Return the contents of an EVE mail
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/mail/{mail_id}/`
   *
   * Alternate route: `/legacy/characters/{character_id}/mail/{mail_id}/`
   *
   * Alternate route: `/v1/characters/{character_id}/mail/{mail_id}/`
   *
   * ---
   * This route is cached for up to 30 seconds
   * @param params The `MailService.GetCharactersCharacterIdMailMailIdParams` containing the following parameters:
   *
   * - `mail_id`: An EVE mail ID
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Contents of a mail
   */
  getCharactersCharacterIdMailMailIdResponse(params: MailService.GetCharactersCharacterIdMailMailIdParams): __Observable<__StrictHttpResponse<{body?: string, from?: number, labels?: Array<number>, read?: boolean, recipients?: Array<{recipient_id: number, recipient_type: 'alliance' | 'character' | 'corporation' | 'mailing_list'}>, subject?: string, timestamp?: string}>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;


    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/mail/${encodeURIComponent(params.mailId)}/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<{body?: string, from?: number, labels?: Array<number>, read?: boolean, recipients?: Array<{recipient_id: number, recipient_type: 'alliance' | 'character' | 'corporation' | 'mailing_list'}>, subject?: string, timestamp?: string}>;
      })
    );
  }
  /**
   * Return a mail
   *
   * Return the contents of an EVE mail
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/mail/{mail_id}/`
   *
   * Alternate route: `/legacy/characters/{character_id}/mail/{mail_id}/`
   *
   * Alternate route: `/v1/characters/{character_id}/mail/{mail_id}/`
   *
   * ---
   * This route is cached for up to 30 seconds
   * @param params The `MailService.GetCharactersCharacterIdMailMailIdParams` containing the following parameters:
   *
   * - `mail_id`: An EVE mail ID
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Contents of a mail
   */
  getCharactersCharacterIdMailMailId(params: MailService.GetCharactersCharacterIdMailMailIdParams): __Observable<{body?: string, from?: number, labels?: Array<number>, read?: boolean, recipients?: Array<{recipient_id: number, recipient_type: 'alliance' | 'character' | 'corporation' | 'mailing_list'}>, subject?: string, timestamp?: string}> {
    return this.getCharactersCharacterIdMailMailIdResponse(params).pipe(
      __map(_r => _r.body as {body?: string, from?: number, labels?: Array<number>, read?: boolean, recipients?: Array<{recipient_id: number, recipient_type: 'alliance' | 'character' | 'corporation' | 'mailing_list'}>, subject?: string, timestamp?: string})
    );
  }

  /**
   * Update metadata about a mail
   *
   * Update metadata about a mail
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/mail/{mail_id}/`
   *
   * Alternate route: `/legacy/characters/{character_id}/mail/{mail_id}/`
   *
   * Alternate route: `/v1/characters/{character_id}/mail/{mail_id}/`
   * @param params The `MailService.PutCharactersCharacterIdMailMailIdParams` containing the following parameters:
   *
   * - `mail_id`: An EVE mail ID
   *
   * - `contents`: Data used to update the mail
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   */
  putCharactersCharacterIdMailMailIdResponse(params: MailService.PutCharactersCharacterIdMailMailIdParams): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    __body = params.contents;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    let req = new HttpRequest<any>(
      'PUT',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/mail/${encodeURIComponent(params.mailId)}/`,
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
   * Update metadata about a mail
   *
   * Update metadata about a mail
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/mail/{mail_id}/`
   *
   * Alternate route: `/legacy/characters/{character_id}/mail/{mail_id}/`
   *
   * Alternate route: `/v1/characters/{character_id}/mail/{mail_id}/`
   * @param params The `MailService.PutCharactersCharacterIdMailMailIdParams` containing the following parameters:
   *
   * - `mail_id`: An EVE mail ID
   *
   * - `contents`: Data used to update the mail
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   */
  putCharactersCharacterIdMailMailId(params: MailService.PutCharactersCharacterIdMailMailIdParams): __Observable<null> {
    return this.putCharactersCharacterIdMailMailIdResponse(params).pipe(
      __map(_r => _r.body as null)
    );
  }
}

module MailService {

  /**
   * Parameters for getCharactersCharacterIdMail
   */
  export interface GetCharactersCharacterIdMailParams {

    /**
     * An EVE character ID
     */
    characterId: number;

    /**
     * Access token to use if unable to set a header
     */
    token?: string;

    /**
     * List only mail with an ID lower than the given ID, if present
     */
    lastMailId?: number;

    /**
     * Fetch only mails that match one or more of the given labels
     */
    labels?: Array<number>;

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
   * Parameters for postCharactersCharacterIdMail
   */
  export interface PostCharactersCharacterIdMailParams {

    /**
     * The mail to send
     */
    mail: {approved_cost?: number, body: string, recipients: Array<{recipient_id: number, recipient_type: 'alliance' | 'character' | 'corporation' | 'mailing_list'}>, subject: string};

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
   * Parameters for getCharactersCharacterIdMailLabels
   */
  export interface GetCharactersCharacterIdMailLabelsParams {

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
   * Parameters for postCharactersCharacterIdMailLabels
   */
  export interface PostCharactersCharacterIdMailLabelsParams {

    /**
     * Label to create
     */
    label: {color?: '#0000fe' | '#006634' | '#0099ff' | '#00ff33' | '#01ffff' | '#349800' | '#660066' | '#666666' | '#999999' | '#99ffff' | '#9a0000' | '#ccff9a' | '#e6e6e6' | '#fe0000' | '#ff6600' | '#ffff01' | '#ffffcd' | '#ffffff', name: string};

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
   * Parameters for deleteCharactersCharacterIdMailLabelsLabelId
   */
  export interface DeleteCharactersCharacterIdMailLabelsLabelIdParams {

    /**
     * An EVE label id
     */
    labelId: number;

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
   * Parameters for getCharactersCharacterIdMailLists
   */
  export interface GetCharactersCharacterIdMailListsParams {

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
   * Parameters for deleteCharactersCharacterIdMailMailId
   */
  export interface DeleteCharactersCharacterIdMailMailIdParams {

    /**
     * An EVE mail ID
     */
    mailId: number;

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
   * Parameters for getCharactersCharacterIdMailMailId
   */
  export interface GetCharactersCharacterIdMailMailIdParams {

    /**
     * An EVE mail ID
     */
    mailId: number;

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
   * Parameters for putCharactersCharacterIdMailMailId
   */
  export interface PutCharactersCharacterIdMailMailIdParams {

    /**
     * An EVE mail ID
     */
    mailId: number;

    /**
     * Data used to update the mail
     */
    contents: {labels?: Array<number>, read?: boolean};

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
}

export { MailService }
