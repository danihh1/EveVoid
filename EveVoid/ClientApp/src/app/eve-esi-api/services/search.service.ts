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
class SearchService extends __BaseService {
  static readonly getCharactersCharacterIdSearchPath = '/characters/{character_id}/search/';
  static readonly getSearchPath = '/search/';

  constructor(
    config: __Configuration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * Search on a string
   *
   * Search for entities that match a given sub-string.
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/search/`
   *
   * Alternate route: `/legacy/characters/{character_id}/search/`
   *
   * Alternate route: `/v3/characters/{character_id}/search/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `SearchService.GetCharactersCharacterIdSearchParams` containing the following parameters:
   *
   * - `search`: The string to search on
   *
   * - `character_id`: An EVE character ID
   *
   * - `categories`: Type of entities to search for
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `strict`: Whether the search should be a strict match
   *
   * - `language`: Language to use in the response, takes precedence over Accept-Language
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * - `Accept-Language`: Language to use in the response
   *
   * @return A list of search results
   */
  getCharactersCharacterIdSearchResponse(params: SearchService.GetCharactersCharacterIdSearchParams): __Observable<__StrictHttpResponse<{agent?: Array<number>, alliance?: Array<number>, character?: Array<number>, constellation?: Array<number>, corporation?: Array<number>, faction?: Array<number>, inventory_type?: Array<number>, region?: Array<number>, solar_system?: Array<number>, station?: Array<number>, structure?: Array<number>}>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.search != null) __params = __params.set('search', params.search.toString());

    (params.categories || []).forEach(val => {if (val != null) __params = __params.append('categories', val.toString())});
    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.strict != null) __params = __params.set('strict', params.strict.toString());
    if (params.language != null) __params = __params.set('language', params.language.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    if (params.AcceptLanguage != null) __headers = __headers.set('Accept-Language', params.AcceptLanguage.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/search/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<{agent?: Array<number>, alliance?: Array<number>, character?: Array<number>, constellation?: Array<number>, corporation?: Array<number>, faction?: Array<number>, inventory_type?: Array<number>, region?: Array<number>, solar_system?: Array<number>, station?: Array<number>, structure?: Array<number>}>;
      })
    );
  }
  /**
   * Search on a string
   *
   * Search for entities that match a given sub-string.
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/search/`
   *
   * Alternate route: `/legacy/characters/{character_id}/search/`
   *
   * Alternate route: `/v3/characters/{character_id}/search/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `SearchService.GetCharactersCharacterIdSearchParams` containing the following parameters:
   *
   * - `search`: The string to search on
   *
   * - `character_id`: An EVE character ID
   *
   * - `categories`: Type of entities to search for
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `strict`: Whether the search should be a strict match
   *
   * - `language`: Language to use in the response, takes precedence over Accept-Language
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * - `Accept-Language`: Language to use in the response
   *
   * @return A list of search results
   */
  getCharactersCharacterIdSearch(params: SearchService.GetCharactersCharacterIdSearchParams): __Observable<{agent?: Array<number>, alliance?: Array<number>, character?: Array<number>, constellation?: Array<number>, corporation?: Array<number>, faction?: Array<number>, inventory_type?: Array<number>, region?: Array<number>, solar_system?: Array<number>, station?: Array<number>, structure?: Array<number>}> {
    return this.getCharactersCharacterIdSearchResponse(params).pipe(
      __map(_r => _r.body as {agent?: Array<number>, alliance?: Array<number>, character?: Array<number>, constellation?: Array<number>, corporation?: Array<number>, faction?: Array<number>, inventory_type?: Array<number>, region?: Array<number>, solar_system?: Array<number>, station?: Array<number>, structure?: Array<number>})
    );
  }

  /**
   * Search on a string
   *
   * Search for entities that match a given sub-string.
   *
   * ---
   * Alternate route: `/dev/search/`
   *
   * Alternate route: `/legacy/search/`
   *
   * Alternate route: `/v2/search/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `SearchService.GetSearchParams` containing the following parameters:
   *
   * - `search`: The string to search on
   *
   * - `categories`: Type of entities to search for
   *
   * - `strict`: Whether the search should be a strict match
   *
   * - `language`: Language to use in the response, takes precedence over Accept-Language
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * - `Accept-Language`: Language to use in the response
   *
   * @return A list of search results
   */
  getSearchResponse(params: SearchService.GetSearchParams): __Observable<__StrictHttpResponse<{agent?: Array<number>, alliance?: Array<number>, character?: Array<number>, constellation?: Array<number>, corporation?: Array<number>, faction?: Array<number>, inventory_type?: Array<number>, region?: Array<number>, solar_system?: Array<number>, station?: Array<number>}>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.search != null) __params = __params.set('search', params.search.toString());
    (params.categories || []).forEach(val => {if (val != null) __params = __params.append('categories', val.toString())});
    if (params.strict != null) __params = __params.set('strict', params.strict.toString());
    if (params.language != null) __params = __params.set('language', params.language.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    if (params.AcceptLanguage != null) __headers = __headers.set('Accept-Language', params.AcceptLanguage.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/search/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<{agent?: Array<number>, alliance?: Array<number>, character?: Array<number>, constellation?: Array<number>, corporation?: Array<number>, faction?: Array<number>, inventory_type?: Array<number>, region?: Array<number>, solar_system?: Array<number>, station?: Array<number>}>;
      })
    );
  }
  /**
   * Search on a string
   *
   * Search for entities that match a given sub-string.
   *
   * ---
   * Alternate route: `/dev/search/`
   *
   * Alternate route: `/legacy/search/`
   *
   * Alternate route: `/v2/search/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `SearchService.GetSearchParams` containing the following parameters:
   *
   * - `search`: The string to search on
   *
   * - `categories`: Type of entities to search for
   *
   * - `strict`: Whether the search should be a strict match
   *
   * - `language`: Language to use in the response, takes precedence over Accept-Language
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * - `Accept-Language`: Language to use in the response
   *
   * @return A list of search results
   */
  getSearch(params: SearchService.GetSearchParams): __Observable<{agent?: Array<number>, alliance?: Array<number>, character?: Array<number>, constellation?: Array<number>, corporation?: Array<number>, faction?: Array<number>, inventory_type?: Array<number>, region?: Array<number>, solar_system?: Array<number>, station?: Array<number>}> {
    return this.getSearchResponse(params).pipe(
      __map(_r => _r.body as {agent?: Array<number>, alliance?: Array<number>, character?: Array<number>, constellation?: Array<number>, corporation?: Array<number>, faction?: Array<number>, inventory_type?: Array<number>, region?: Array<number>, solar_system?: Array<number>, station?: Array<number>})
    );
  }
}

module SearchService {

  /**
   * Parameters for getCharactersCharacterIdSearch
   */
  export interface GetCharactersCharacterIdSearchParams {

    /**
     * The string to search on
     */
    search: string;

    /**
     * An EVE character ID
     */
    characterId: number;

    /**
     * Type of entities to search for
     */
    categories: Array<'agent' | 'alliance' | 'character' | 'constellation' | 'corporation' | 'faction' | 'inventory_type' | 'region' | 'solar_system' | 'station' | 'structure'>;

    /**
     * Access token to use if unable to set a header
     */
    token?: string;

    /**
     * Whether the search should be a strict match
     */
    strict?: boolean;

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
   * Parameters for getSearch
   */
  export interface GetSearchParams {

    /**
     * The string to search on
     */
    search: string;

    /**
     * Type of entities to search for
     */
    categories: Array<'agent' | 'alliance' | 'character' | 'constellation' | 'corporation' | 'faction' | 'inventory_type' | 'region' | 'solar_system' | 'station'>;

    /**
     * Whether the search should be a strict match
     */
    strict?: boolean;

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
}

export { SearchService }
