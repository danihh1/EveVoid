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
class SkillsService extends __BaseService {
  static readonly getCharactersCharacterIdAttributesPath = '/characters/{character_id}/attributes/';
  static readonly getCharactersCharacterIdSkillqueuePath = '/characters/{character_id}/skillqueue/';
  static readonly getCharactersCharacterIdSkillsPath = '/characters/{character_id}/skills/';

  constructor(
    config: __Configuration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * Get character attributes
   *
   * Return attributes of a character
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/attributes/`
   *
   * Alternate route: `/legacy/characters/{character_id}/attributes/`
   *
   * Alternate route: `/v1/characters/{character_id}/attributes/`
   *
   * ---
   * This route is cached for up to 120 seconds
   * @param params The `SkillsService.GetCharactersCharacterIdAttributesParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Attributes of a character
   */
  getCharactersCharacterIdAttributesResponse(params: SkillsService.GetCharactersCharacterIdAttributesParams): __Observable<__StrictHttpResponse<{accrued_remap_cooldown_date?: string, bonus_remaps?: number, charisma: number, intelligence: number, last_remap_date?: string, memory: number, perception: number, willpower: number}>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/attributes/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<{accrued_remap_cooldown_date?: string, bonus_remaps?: number, charisma: number, intelligence: number, last_remap_date?: string, memory: number, perception: number, willpower: number}>;
      })
    );
  }
  /**
   * Get character attributes
   *
   * Return attributes of a character
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/attributes/`
   *
   * Alternate route: `/legacy/characters/{character_id}/attributes/`
   *
   * Alternate route: `/v1/characters/{character_id}/attributes/`
   *
   * ---
   * This route is cached for up to 120 seconds
   * @param params The `SkillsService.GetCharactersCharacterIdAttributesParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Attributes of a character
   */
  getCharactersCharacterIdAttributes(params: SkillsService.GetCharactersCharacterIdAttributesParams): __Observable<{accrued_remap_cooldown_date?: string, bonus_remaps?: number, charisma: number, intelligence: number, last_remap_date?: string, memory: number, perception: number, willpower: number}> {
    return this.getCharactersCharacterIdAttributesResponse(params).pipe(
      __map(_r => _r.body as {accrued_remap_cooldown_date?: string, bonus_remaps?: number, charisma: number, intelligence: number, last_remap_date?: string, memory: number, perception: number, willpower: number})
    );
  }

  /**
   * Get character's skill queue
   *
   * List the configured skill queue for the given character
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/skillqueue/`
   *
   * Alternate route: `/legacy/characters/{character_id}/skillqueue/`
   *
   * Alternate route: `/v2/characters/{character_id}/skillqueue/`
   *
   * ---
   * This route is cached for up to 120 seconds
   * @param params The `SkillsService.GetCharactersCharacterIdSkillqueueParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return The current skill queue, sorted ascending by finishing time
   */
  getCharactersCharacterIdSkillqueueResponse(params: SkillsService.GetCharactersCharacterIdSkillqueueParams): __Observable<__StrictHttpResponse<Array<{finish_date?: string, finished_level: number, level_end_sp?: number, level_start_sp?: number, queue_position: number, skill_id: number, start_date?: string, training_start_sp?: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/skillqueue/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{finish_date?: string, finished_level: number, level_end_sp?: number, level_start_sp?: number, queue_position: number, skill_id: number, start_date?: string, training_start_sp?: number}>>;
      })
    );
  }
  /**
   * Get character's skill queue
   *
   * List the configured skill queue for the given character
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/skillqueue/`
   *
   * Alternate route: `/legacy/characters/{character_id}/skillqueue/`
   *
   * Alternate route: `/v2/characters/{character_id}/skillqueue/`
   *
   * ---
   * This route is cached for up to 120 seconds
   * @param params The `SkillsService.GetCharactersCharacterIdSkillqueueParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return The current skill queue, sorted ascending by finishing time
   */
  getCharactersCharacterIdSkillqueue(params: SkillsService.GetCharactersCharacterIdSkillqueueParams): __Observable<Array<{finish_date?: string, finished_level: number, level_end_sp?: number, level_start_sp?: number, queue_position: number, skill_id: number, start_date?: string, training_start_sp?: number}>> {
    return this.getCharactersCharacterIdSkillqueueResponse(params).pipe(
      __map(_r => _r.body as Array<{finish_date?: string, finished_level: number, level_end_sp?: number, level_start_sp?: number, queue_position: number, skill_id: number, start_date?: string, training_start_sp?: number}>)
    );
  }

  /**
   * Get character skills
   *
   * List all trained skills for the given character
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/skills/`
   *
   * Alternate route: `/v4/characters/{character_id}/skills/`
   *
   * ---
   * This route is cached for up to 120 seconds
   * @param params The `SkillsService.GetCharactersCharacterIdSkillsParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Known skills for the character
   */
  getCharactersCharacterIdSkillsResponse(params: SkillsService.GetCharactersCharacterIdSkillsParams): __Observable<__StrictHttpResponse<{skills: Array<{active_skill_level: number, skill_id: number, skillpoints_in_skill: number, trained_skill_level: number}>, total_sp: number, unallocated_sp?: number}>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/skills/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<{skills: Array<{active_skill_level: number, skill_id: number, skillpoints_in_skill: number, trained_skill_level: number}>, total_sp: number, unallocated_sp?: number}>;
      })
    );
  }
  /**
   * Get character skills
   *
   * List all trained skills for the given character
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/skills/`
   *
   * Alternate route: `/v4/characters/{character_id}/skills/`
   *
   * ---
   * This route is cached for up to 120 seconds
   * @param params The `SkillsService.GetCharactersCharacterIdSkillsParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Known skills for the character
   */
  getCharactersCharacterIdSkills(params: SkillsService.GetCharactersCharacterIdSkillsParams): __Observable<{skills: Array<{active_skill_level: number, skill_id: number, skillpoints_in_skill: number, trained_skill_level: number}>, total_sp: number, unallocated_sp?: number}> {
    return this.getCharactersCharacterIdSkillsResponse(params).pipe(
      __map(_r => _r.body as {skills: Array<{active_skill_level: number, skill_id: number, skillpoints_in_skill: number, trained_skill_level: number}>, total_sp: number, unallocated_sp?: number})
    );
  }
}

module SkillsService {

  /**
   * Parameters for getCharactersCharacterIdAttributes
   */
  export interface GetCharactersCharacterIdAttributesParams {

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
   * Parameters for getCharactersCharacterIdSkillqueue
   */
  export interface GetCharactersCharacterIdSkillqueueParams {

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
   * Parameters for getCharactersCharacterIdSkills
   */
  export interface GetCharactersCharacterIdSkillsParams {

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

export { SkillsService }
