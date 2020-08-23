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
class BookmarksService extends __BaseService {
  static readonly getCharactersCharacterIdBookmarksPath = '/characters/{character_id}/bookmarks/';
  static readonly getCharactersCharacterIdBookmarksFoldersPath = '/characters/{character_id}/bookmarks/folders/';
  static readonly getCorporationsCorporationIdBookmarksPath = '/corporations/{corporation_id}/bookmarks/';
  static readonly getCorporationsCorporationIdBookmarksFoldersPath = '/corporations/{corporation_id}/bookmarks/folders/';

  constructor(
    config: __Configuration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * List bookmarks
   *
   * A list of your character's personal bookmarks
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/bookmarks/`
   *
   * Alternate route: `/v2/characters/{character_id}/bookmarks/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `BookmarksService.GetCharactersCharacterIdBookmarksParams` containing the following parameters:
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
   * @return A list of bookmarks
   */
  getCharactersCharacterIdBookmarksResponse(params: BookmarksService.GetCharactersCharacterIdBookmarksParams): __Observable<__StrictHttpResponse<Array<{bookmark_id: number, coordinates?: {x: number, y: number, z: number}, created: string, creator_id: number, folder_id?: number, item?: {item_id: number, type_id: number}, label: string, location_id: number, notes: string}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.page != null) __params = __params.set('page', params.page.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/bookmarks/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{bookmark_id: number, coordinates?: {x: number, y: number, z: number}, created: string, creator_id: number, folder_id?: number, item?: {item_id: number, type_id: number}, label: string, location_id: number, notes: string}>>;
      })
    );
  }
  /**
   * List bookmarks
   *
   * A list of your character's personal bookmarks
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/bookmarks/`
   *
   * Alternate route: `/v2/characters/{character_id}/bookmarks/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `BookmarksService.GetCharactersCharacterIdBookmarksParams` containing the following parameters:
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
   * @return A list of bookmarks
   */
  getCharactersCharacterIdBookmarks(params: BookmarksService.GetCharactersCharacterIdBookmarksParams): __Observable<Array<{bookmark_id: number, coordinates?: {x: number, y: number, z: number}, created: string, creator_id: number, folder_id?: number, item?: {item_id: number, type_id: number}, label: string, location_id: number, notes: string}>> {
    return this.getCharactersCharacterIdBookmarksResponse(params).pipe(
      __map(_r => _r.body as Array<{bookmark_id: number, coordinates?: {x: number, y: number, z: number}, created: string, creator_id: number, folder_id?: number, item?: {item_id: number, type_id: number}, label: string, location_id: number, notes: string}>)
    );
  }

  /**
   * List bookmark folders
   *
   * A list of your character's personal bookmark folders
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/bookmarks/folders/`
   *
   * Alternate route: `/v2/characters/{character_id}/bookmarks/folders/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `BookmarksService.GetCharactersCharacterIdBookmarksFoldersParams` containing the following parameters:
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
   * @return List of bookmark folders
   */
  getCharactersCharacterIdBookmarksFoldersResponse(params: BookmarksService.GetCharactersCharacterIdBookmarksFoldersParams): __Observable<__StrictHttpResponse<Array<{folder_id: number, name: string}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.page != null) __params = __params.set('page', params.page.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/bookmarks/folders/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{folder_id: number, name: string}>>;
      })
    );
  }
  /**
   * List bookmark folders
   *
   * A list of your character's personal bookmark folders
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/bookmarks/folders/`
   *
   * Alternate route: `/v2/characters/{character_id}/bookmarks/folders/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `BookmarksService.GetCharactersCharacterIdBookmarksFoldersParams` containing the following parameters:
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
   * @return List of bookmark folders
   */
  getCharactersCharacterIdBookmarksFolders(params: BookmarksService.GetCharactersCharacterIdBookmarksFoldersParams): __Observable<Array<{folder_id: number, name: string}>> {
    return this.getCharactersCharacterIdBookmarksFoldersResponse(params).pipe(
      __map(_r => _r.body as Array<{folder_id: number, name: string}>)
    );
  }

  /**
   * List corporation bookmarks
   *
   * A list of your corporation's bookmarks
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/bookmarks/`
   *
   * Alternate route: `/legacy/corporations/{corporation_id}/bookmarks/`
   *
   * Alternate route: `/v1/corporations/{corporation_id}/bookmarks/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `BookmarksService.GetCorporationsCorporationIdBookmarksParams` containing the following parameters:
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
   * @return List of corporation owned bookmarks
   */
  getCorporationsCorporationIdBookmarksResponse(params: BookmarksService.GetCorporationsCorporationIdBookmarksParams): __Observable<__StrictHttpResponse<Array<{bookmark_id: number, coordinates?: {x: number, y: number, z: number}, created: string, creator_id: number, folder_id?: number, item?: {item_id: number, type_id: number}, label: string, location_id: number, notes: string}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.page != null) __params = __params.set('page', params.page.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/corporations/${encodeURIComponent(params.corporationId)}/bookmarks/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{bookmark_id: number, coordinates?: {x: number, y: number, z: number}, created: string, creator_id: number, folder_id?: number, item?: {item_id: number, type_id: number}, label: string, location_id: number, notes: string}>>;
      })
    );
  }
  /**
   * List corporation bookmarks
   *
   * A list of your corporation's bookmarks
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/bookmarks/`
   *
   * Alternate route: `/legacy/corporations/{corporation_id}/bookmarks/`
   *
   * Alternate route: `/v1/corporations/{corporation_id}/bookmarks/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `BookmarksService.GetCorporationsCorporationIdBookmarksParams` containing the following parameters:
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
   * @return List of corporation owned bookmarks
   */
  getCorporationsCorporationIdBookmarks(params: BookmarksService.GetCorporationsCorporationIdBookmarksParams): __Observable<Array<{bookmark_id: number, coordinates?: {x: number, y: number, z: number}, created: string, creator_id: number, folder_id?: number, item?: {item_id: number, type_id: number}, label: string, location_id: number, notes: string}>> {
    return this.getCorporationsCorporationIdBookmarksResponse(params).pipe(
      __map(_r => _r.body as Array<{bookmark_id: number, coordinates?: {x: number, y: number, z: number}, created: string, creator_id: number, folder_id?: number, item?: {item_id: number, type_id: number}, label: string, location_id: number, notes: string}>)
    );
  }

  /**
   * List corporation bookmark folders
   *
   * A list of your corporation's bookmark folders
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/bookmarks/folders/`
   *
   * Alternate route: `/legacy/corporations/{corporation_id}/bookmarks/folders/`
   *
   * Alternate route: `/v1/corporations/{corporation_id}/bookmarks/folders/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `BookmarksService.GetCorporationsCorporationIdBookmarksFoldersParams` containing the following parameters:
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
   * @return List of corporation owned bookmark folders
   */
  getCorporationsCorporationIdBookmarksFoldersResponse(params: BookmarksService.GetCorporationsCorporationIdBookmarksFoldersParams): __Observable<__StrictHttpResponse<Array<{creator_id?: number, folder_id: number, name: string}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.page != null) __params = __params.set('page', params.page.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/corporations/${encodeURIComponent(params.corporationId)}/bookmarks/folders/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{creator_id?: number, folder_id: number, name: string}>>;
      })
    );
  }
  /**
   * List corporation bookmark folders
   *
   * A list of your corporation's bookmark folders
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/bookmarks/folders/`
   *
   * Alternate route: `/legacy/corporations/{corporation_id}/bookmarks/folders/`
   *
   * Alternate route: `/v1/corporations/{corporation_id}/bookmarks/folders/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `BookmarksService.GetCorporationsCorporationIdBookmarksFoldersParams` containing the following parameters:
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
   * @return List of corporation owned bookmark folders
   */
  getCorporationsCorporationIdBookmarksFolders(params: BookmarksService.GetCorporationsCorporationIdBookmarksFoldersParams): __Observable<Array<{creator_id?: number, folder_id: number, name: string}>> {
    return this.getCorporationsCorporationIdBookmarksFoldersResponse(params).pipe(
      __map(_r => _r.body as Array<{creator_id?: number, folder_id: number, name: string}>)
    );
  }
}

module BookmarksService {

  /**
   * Parameters for getCharactersCharacterIdBookmarks
   */
  export interface GetCharactersCharacterIdBookmarksParams {

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
   * Parameters for getCharactersCharacterIdBookmarksFolders
   */
  export interface GetCharactersCharacterIdBookmarksFoldersParams {

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
   * Parameters for getCorporationsCorporationIdBookmarks
   */
  export interface GetCorporationsCorporationIdBookmarksParams {

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
   * Parameters for getCorporationsCorporationIdBookmarksFolders
   */
  export interface GetCorporationsCorporationIdBookmarksFoldersParams {

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
}

export { BookmarksService }
