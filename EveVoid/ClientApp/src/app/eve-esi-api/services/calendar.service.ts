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
class CalendarService extends __BaseService {
  static readonly getCharactersCharacterIdCalendarPath = '/characters/{character_id}/calendar/';
  static readonly getCharactersCharacterIdCalendarEventIdPath = '/characters/{character_id}/calendar/{event_id}/';
  static readonly putCharactersCharacterIdCalendarEventIdPath = '/characters/{character_id}/calendar/{event_id}/';
  static readonly getCharactersCharacterIdCalendarEventIdAttendeesPath = '/characters/{character_id}/calendar/{event_id}/attendees/';

  constructor(
    config: __Configuration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * List calendar event summaries
   *
   * Get 50 event summaries from the calendar. If no from_event ID is given, the resource will return the next 50 chronological event summaries from now. If a from_event ID is specified, it will return the next 50 chronological event summaries from after that event
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/calendar/`
   *
   * Alternate route: `/legacy/characters/{character_id}/calendar/`
   *
   * Alternate route: `/v1/characters/{character_id}/calendar/`
   *
   * Alternate route: `/v2/characters/{character_id}/calendar/`
   *
   * ---
   * This route is cached for up to 5 seconds
   * @param params The `CalendarService.GetCharactersCharacterIdCalendarParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `from_event`: The event ID to retrieve events from
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A collection of event summaries
   */
  getCharactersCharacterIdCalendarResponse(params: CalendarService.GetCharactersCharacterIdCalendarParams): __Observable<__StrictHttpResponse<Array<{event_date?: string, event_id?: number, event_response?: 'declined' | 'not_responded' | 'accepted' | 'tentative', importance?: number, title?: string}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.fromEvent != null) __params = __params.set('from_event', params.fromEvent.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/calendar/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{event_date?: string, event_id?: number, event_response?: 'declined' | 'not_responded' | 'accepted' | 'tentative', importance?: number, title?: string}>>;
      })
    );
  }
  /**
   * List calendar event summaries
   *
   * Get 50 event summaries from the calendar. If no from_event ID is given, the resource will return the next 50 chronological event summaries from now. If a from_event ID is specified, it will return the next 50 chronological event summaries from after that event
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/calendar/`
   *
   * Alternate route: `/legacy/characters/{character_id}/calendar/`
   *
   * Alternate route: `/v1/characters/{character_id}/calendar/`
   *
   * Alternate route: `/v2/characters/{character_id}/calendar/`
   *
   * ---
   * This route is cached for up to 5 seconds
   * @param params The `CalendarService.GetCharactersCharacterIdCalendarParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `from_event`: The event ID to retrieve events from
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A collection of event summaries
   */
  getCharactersCharacterIdCalendar(params: CalendarService.GetCharactersCharacterIdCalendarParams): __Observable<Array<{event_date?: string, event_id?: number, event_response?: 'declined' | 'not_responded' | 'accepted' | 'tentative', importance?: number, title?: string}>> {
    return this.getCharactersCharacterIdCalendarResponse(params).pipe(
      __map(_r => _r.body as Array<{event_date?: string, event_id?: number, event_response?: 'declined' | 'not_responded' | 'accepted' | 'tentative', importance?: number, title?: string}>)
    );
  }

  /**
   * Get an event
   *
   * Get all the information for a specific event
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/calendar/{event_id}/`
   *
   * Alternate route: `/legacy/characters/{character_id}/calendar/{event_id}/`
   *
   * Alternate route: `/v3/characters/{character_id}/calendar/{event_id}/`
   *
   * Alternate route: `/v4/characters/{character_id}/calendar/{event_id}/`
   *
   * ---
   * This route is cached for up to 5 seconds
   * @param params The `CalendarService.GetCharactersCharacterIdCalendarEventIdParams` containing the following parameters:
   *
   * - `event_id`: The id of the event requested
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Full details of a specific event
   */
  getCharactersCharacterIdCalendarEventIdResponse(params: CalendarService.GetCharactersCharacterIdCalendarEventIdParams): __Observable<__StrictHttpResponse<{date: string, duration: number, event_id: number, importance: number, owner_id: number, owner_name: string, owner_type: 'eve_server' | 'corporation' | 'faction' | 'character' | 'alliance', response: string, text: string, title: string}>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;


    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/calendar/${encodeURIComponent(params.eventId)}/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<{date: string, duration: number, event_id: number, importance: number, owner_id: number, owner_name: string, owner_type: 'eve_server' | 'corporation' | 'faction' | 'character' | 'alliance', response: string, text: string, title: string}>;
      })
    );
  }
  /**
   * Get an event
   *
   * Get all the information for a specific event
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/calendar/{event_id}/`
   *
   * Alternate route: `/legacy/characters/{character_id}/calendar/{event_id}/`
   *
   * Alternate route: `/v3/characters/{character_id}/calendar/{event_id}/`
   *
   * Alternate route: `/v4/characters/{character_id}/calendar/{event_id}/`
   *
   * ---
   * This route is cached for up to 5 seconds
   * @param params The `CalendarService.GetCharactersCharacterIdCalendarEventIdParams` containing the following parameters:
   *
   * - `event_id`: The id of the event requested
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Full details of a specific event
   */
  getCharactersCharacterIdCalendarEventId(params: CalendarService.GetCharactersCharacterIdCalendarEventIdParams): __Observable<{date: string, duration: number, event_id: number, importance: number, owner_id: number, owner_name: string, owner_type: 'eve_server' | 'corporation' | 'faction' | 'character' | 'alliance', response: string, text: string, title: string}> {
    return this.getCharactersCharacterIdCalendarEventIdResponse(params).pipe(
      __map(_r => _r.body as {date: string, duration: number, event_id: number, importance: number, owner_id: number, owner_name: string, owner_type: 'eve_server' | 'corporation' | 'faction' | 'character' | 'alliance', response: string, text: string, title: string})
    );
  }

  /**
   * Respond to an event
   *
   * Set your response status to an event
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/calendar/{event_id}/`
   *
   * Alternate route: `/legacy/characters/{character_id}/calendar/{event_id}/`
   *
   * Alternate route: `/v3/characters/{character_id}/calendar/{event_id}/`
   *
   * Alternate route: `/v4/characters/{character_id}/calendar/{event_id}/`
   *
   * ---
   * This route is cached for up to 5 seconds
   * @param params The `CalendarService.PutCharactersCharacterIdCalendarEventIdParams` containing the following parameters:
   *
   * - `response`: The response value to set, overriding current value
   *
   * - `event_id`: The ID of the event requested
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   */
  putCharactersCharacterIdCalendarEventIdResponse(params: CalendarService.PutCharactersCharacterIdCalendarEventIdParams): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    __body = params.response;


    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    let req = new HttpRequest<any>(
      'PUT',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/calendar/${encodeURIComponent(params.eventId)}/`,
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
   * Respond to an event
   *
   * Set your response status to an event
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/calendar/{event_id}/`
   *
   * Alternate route: `/legacy/characters/{character_id}/calendar/{event_id}/`
   *
   * Alternate route: `/v3/characters/{character_id}/calendar/{event_id}/`
   *
   * Alternate route: `/v4/characters/{character_id}/calendar/{event_id}/`
   *
   * ---
   * This route is cached for up to 5 seconds
   * @param params The `CalendarService.PutCharactersCharacterIdCalendarEventIdParams` containing the following parameters:
   *
   * - `response`: The response value to set, overriding current value
   *
   * - `event_id`: The ID of the event requested
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   */
  putCharactersCharacterIdCalendarEventId(params: CalendarService.PutCharactersCharacterIdCalendarEventIdParams): __Observable<null> {
    return this.putCharactersCharacterIdCalendarEventIdResponse(params).pipe(
      __map(_r => _r.body as null)
    );
  }

  /**
   * Get attendees
   *
   * Get all invited attendees for a given event
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/calendar/{event_id}/attendees/`
   *
   * Alternate route: `/legacy/characters/{character_id}/calendar/{event_id}/attendees/`
   *
   * Alternate route: `/v1/characters/{character_id}/calendar/{event_id}/attendees/`
   *
   * Alternate route: `/v2/characters/{character_id}/calendar/{event_id}/attendees/`
   *
   * ---
   * This route is cached for up to 600 seconds
   * @param params The `CalendarService.GetCharactersCharacterIdCalendarEventIdAttendeesParams` containing the following parameters:
   *
   * - `event_id`: The id of the event requested
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return List of attendees
   */
  getCharactersCharacterIdCalendarEventIdAttendeesResponse(params: CalendarService.GetCharactersCharacterIdCalendarEventIdAttendeesParams): __Observable<__StrictHttpResponse<Array<{character_id?: number, event_response?: 'declined' | 'not_responded' | 'accepted' | 'tentative'}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;


    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/calendar/${encodeURIComponent(params.eventId)}/attendees/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{character_id?: number, event_response?: 'declined' | 'not_responded' | 'accepted' | 'tentative'}>>;
      })
    );
  }
  /**
   * Get attendees
   *
   * Get all invited attendees for a given event
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/calendar/{event_id}/attendees/`
   *
   * Alternate route: `/legacy/characters/{character_id}/calendar/{event_id}/attendees/`
   *
   * Alternate route: `/v1/characters/{character_id}/calendar/{event_id}/attendees/`
   *
   * Alternate route: `/v2/characters/{character_id}/calendar/{event_id}/attendees/`
   *
   * ---
   * This route is cached for up to 600 seconds
   * @param params The `CalendarService.GetCharactersCharacterIdCalendarEventIdAttendeesParams` containing the following parameters:
   *
   * - `event_id`: The id of the event requested
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return List of attendees
   */
  getCharactersCharacterIdCalendarEventIdAttendees(params: CalendarService.GetCharactersCharacterIdCalendarEventIdAttendeesParams): __Observable<Array<{character_id?: number, event_response?: 'declined' | 'not_responded' | 'accepted' | 'tentative'}>> {
    return this.getCharactersCharacterIdCalendarEventIdAttendeesResponse(params).pipe(
      __map(_r => _r.body as Array<{character_id?: number, event_response?: 'declined' | 'not_responded' | 'accepted' | 'tentative'}>)
    );
  }
}

module CalendarService {

  /**
   * Parameters for getCharactersCharacterIdCalendar
   */
  export interface GetCharactersCharacterIdCalendarParams {

    /**
     * An EVE character ID
     */
    characterId: number;

    /**
     * Access token to use if unable to set a header
     */
    token?: string;

    /**
     * The event ID to retrieve events from
     */
    fromEvent?: number;

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
   * Parameters for getCharactersCharacterIdCalendarEventId
   */
  export interface GetCharactersCharacterIdCalendarEventIdParams {

    /**
     * The id of the event requested
     */
    eventId: number;

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
   * Parameters for putCharactersCharacterIdCalendarEventId
   */
  export interface PutCharactersCharacterIdCalendarEventIdParams {

    /**
     * The response value to set, overriding current value
     */
    response: {response: 'accepted' | 'declined' | 'tentative'};

    /**
     * The ID of the event requested
     */
    eventId: number;

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
   * Parameters for getCharactersCharacterIdCalendarEventIdAttendees
   */
  export interface GetCharactersCharacterIdCalendarEventIdAttendeesParams {

    /**
     * The id of the event requested
     */
    eventId: number;

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
}

export { CalendarService }
