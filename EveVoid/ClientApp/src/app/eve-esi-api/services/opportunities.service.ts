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
class OpportunitiesService extends __BaseService {
  static readonly getCharactersCharacterIdOpportunitiesPath = '/characters/{character_id}/opportunities/';
  static readonly getOpportunitiesGroupsPath = '/opportunities/groups/';
  static readonly getOpportunitiesGroupsGroupIdPath = '/opportunities/groups/{group_id}/';
  static readonly getOpportunitiesTasksPath = '/opportunities/tasks/';
  static readonly getOpportunitiesTasksTaskIdPath = '/opportunities/tasks/{task_id}/';

  constructor(
    config: __Configuration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * Get a character's completed tasks
   *
   * Return a list of tasks finished by a character
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/opportunities/`
   *
   * Alternate route: `/legacy/characters/{character_id}/opportunities/`
   *
   * Alternate route: `/v1/characters/{character_id}/opportunities/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `OpportunitiesService.GetCharactersCharacterIdOpportunitiesParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of opportunities task ids
   */
  getCharactersCharacterIdOpportunitiesResponse(params: OpportunitiesService.GetCharactersCharacterIdOpportunitiesParams): __Observable<__StrictHttpResponse<Array<{completed_at: string, task_id: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/opportunities/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{completed_at: string, task_id: number}>>;
      })
    );
  }
  /**
   * Get a character's completed tasks
   *
   * Return a list of tasks finished by a character
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/opportunities/`
   *
   * Alternate route: `/legacy/characters/{character_id}/opportunities/`
   *
   * Alternate route: `/v1/characters/{character_id}/opportunities/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `OpportunitiesService.GetCharactersCharacterIdOpportunitiesParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of opportunities task ids
   */
  getCharactersCharacterIdOpportunities(params: OpportunitiesService.GetCharactersCharacterIdOpportunitiesParams): __Observable<Array<{completed_at: string, task_id: number}>> {
    return this.getCharactersCharacterIdOpportunitiesResponse(params).pipe(
      __map(_r => _r.body as Array<{completed_at: string, task_id: number}>)
    );
  }

  /**
   * Get opportunities groups
   *
   * Return a list of opportunities groups
   *
   * ---
   * Alternate route: `/dev/opportunities/groups/`
   *
   * Alternate route: `/legacy/opportunities/groups/`
   *
   * Alternate route: `/v1/opportunities/groups/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `OpportunitiesService.GetOpportunitiesGroupsParams` containing the following parameters:
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of opportunities group ids
   */
  getOpportunitiesGroupsResponse(params: OpportunitiesService.GetOpportunitiesGroupsParams): __Observable<__StrictHttpResponse<Array<number>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/opportunities/groups/`,
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
   * Get opportunities groups
   *
   * Return a list of opportunities groups
   *
   * ---
   * Alternate route: `/dev/opportunities/groups/`
   *
   * Alternate route: `/legacy/opportunities/groups/`
   *
   * Alternate route: `/v1/opportunities/groups/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `OpportunitiesService.GetOpportunitiesGroupsParams` containing the following parameters:
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of opportunities group ids
   */
  getOpportunitiesGroups(params: OpportunitiesService.GetOpportunitiesGroupsParams): __Observable<Array<number>> {
    return this.getOpportunitiesGroupsResponse(params).pipe(
      __map(_r => _r.body as Array<number>)
    );
  }

  /**
   * Get opportunities group
   *
   * Return information of an opportunities group
   *
   * ---
   * Alternate route: `/dev/opportunities/groups/{group_id}/`
   *
   * Alternate route: `/legacy/opportunities/groups/{group_id}/`
   *
   * Alternate route: `/v1/opportunities/groups/{group_id}/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `OpportunitiesService.GetOpportunitiesGroupsGroupIdParams` containing the following parameters:
   *
   * - `group_id`: ID of an opportunities group
   *
   * - `language`: Language to use in the response, takes precedence over Accept-Language
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * - `Accept-Language`: Language to use in the response
   *
   * @return Details of an opportunities group
   */
  getOpportunitiesGroupsGroupIdResponse(params: OpportunitiesService.GetOpportunitiesGroupsGroupIdParams): __Observable<__StrictHttpResponse<{connected_groups: Array<number>, description: string, group_id: number, name: string, notification: string, required_tasks: Array<number>}>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.language != null) __params = __params.set('language', params.language.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    if (params.AcceptLanguage != null) __headers = __headers.set('Accept-Language', params.AcceptLanguage.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/opportunities/groups/${encodeURIComponent(params.groupId)}/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<{connected_groups: Array<number>, description: string, group_id: number, name: string, notification: string, required_tasks: Array<number>}>;
      })
    );
  }
  /**
   * Get opportunities group
   *
   * Return information of an opportunities group
   *
   * ---
   * Alternate route: `/dev/opportunities/groups/{group_id}/`
   *
   * Alternate route: `/legacy/opportunities/groups/{group_id}/`
   *
   * Alternate route: `/v1/opportunities/groups/{group_id}/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `OpportunitiesService.GetOpportunitiesGroupsGroupIdParams` containing the following parameters:
   *
   * - `group_id`: ID of an opportunities group
   *
   * - `language`: Language to use in the response, takes precedence over Accept-Language
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * - `Accept-Language`: Language to use in the response
   *
   * @return Details of an opportunities group
   */
  getOpportunitiesGroupsGroupId(params: OpportunitiesService.GetOpportunitiesGroupsGroupIdParams): __Observable<{connected_groups: Array<number>, description: string, group_id: number, name: string, notification: string, required_tasks: Array<number>}> {
    return this.getOpportunitiesGroupsGroupIdResponse(params).pipe(
      __map(_r => _r.body as {connected_groups: Array<number>, description: string, group_id: number, name: string, notification: string, required_tasks: Array<number>})
    );
  }

  /**
   * Get opportunities tasks
   *
   * Return a list of opportunities tasks
   *
   * ---
   * Alternate route: `/dev/opportunities/tasks/`
   *
   * Alternate route: `/legacy/opportunities/tasks/`
   *
   * Alternate route: `/v1/opportunities/tasks/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `OpportunitiesService.GetOpportunitiesTasksParams` containing the following parameters:
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of opportunities task ids
   */
  getOpportunitiesTasksResponse(params: OpportunitiesService.GetOpportunitiesTasksParams): __Observable<__StrictHttpResponse<Array<number>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/opportunities/tasks/`,
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
   * Get opportunities tasks
   *
   * Return a list of opportunities tasks
   *
   * ---
   * Alternate route: `/dev/opportunities/tasks/`
   *
   * Alternate route: `/legacy/opportunities/tasks/`
   *
   * Alternate route: `/v1/opportunities/tasks/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `OpportunitiesService.GetOpportunitiesTasksParams` containing the following parameters:
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of opportunities task ids
   */
  getOpportunitiesTasks(params: OpportunitiesService.GetOpportunitiesTasksParams): __Observable<Array<number>> {
    return this.getOpportunitiesTasksResponse(params).pipe(
      __map(_r => _r.body as Array<number>)
    );
  }

  /**
   * Get opportunities task
   *
   * Return information of an opportunities task
   *
   * ---
   * Alternate route: `/dev/opportunities/tasks/{task_id}/`
   *
   * Alternate route: `/legacy/opportunities/tasks/{task_id}/`
   *
   * Alternate route: `/v1/opportunities/tasks/{task_id}/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `OpportunitiesService.GetOpportunitiesTasksTaskIdParams` containing the following parameters:
   *
   * - `task_id`: ID of an opportunities task
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Details of an opportunities task
   */
  getOpportunitiesTasksTaskIdResponse(params: OpportunitiesService.GetOpportunitiesTasksTaskIdParams): __Observable<__StrictHttpResponse<{description: string, name: string, notification: string, task_id: number}>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/opportunities/tasks/${encodeURIComponent(params.taskId)}/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<{description: string, name: string, notification: string, task_id: number}>;
      })
    );
  }
  /**
   * Get opportunities task
   *
   * Return information of an opportunities task
   *
   * ---
   * Alternate route: `/dev/opportunities/tasks/{task_id}/`
   *
   * Alternate route: `/legacy/opportunities/tasks/{task_id}/`
   *
   * Alternate route: `/v1/opportunities/tasks/{task_id}/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `OpportunitiesService.GetOpportunitiesTasksTaskIdParams` containing the following parameters:
   *
   * - `task_id`: ID of an opportunities task
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Details of an opportunities task
   */
  getOpportunitiesTasksTaskId(params: OpportunitiesService.GetOpportunitiesTasksTaskIdParams): __Observable<{description: string, name: string, notification: string, task_id: number}> {
    return this.getOpportunitiesTasksTaskIdResponse(params).pipe(
      __map(_r => _r.body as {description: string, name: string, notification: string, task_id: number})
    );
  }
}

module OpportunitiesService {

  /**
   * Parameters for getCharactersCharacterIdOpportunities
   */
  export interface GetCharactersCharacterIdOpportunitiesParams {

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
   * Parameters for getOpportunitiesGroups
   */
  export interface GetOpportunitiesGroupsParams {

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
   * Parameters for getOpportunitiesGroupsGroupId
   */
  export interface GetOpportunitiesGroupsGroupIdParams {

    /**
     * ID of an opportunities group
     */
    groupId: number;

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
   * Parameters for getOpportunitiesTasks
   */
  export interface GetOpportunitiesTasksParams {

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
   * Parameters for getOpportunitiesTasksTaskId
   */
  export interface GetOpportunitiesTasksTaskIdParams {

    /**
     * ID of an opportunities task
     */
    taskId: number;

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

export { OpportunitiesService }
