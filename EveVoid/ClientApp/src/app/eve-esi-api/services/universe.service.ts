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
class UniverseService extends __BaseService {
  static readonly getUniverseAncestriesPath = '/universe/ancestries/';
  static readonly getUniverseAsteroidBeltsAsteroidBeltIdPath = '/universe/asteroid_belts/{asteroid_belt_id}/';
  static readonly getUniverseBloodlinesPath = '/universe/bloodlines/';
  static readonly getUniverseCategoriesPath = '/universe/categories/';
  static readonly getUniverseCategoriesCategoryIdPath = '/universe/categories/{category_id}/';
  static readonly getUniverseConstellationsPath = '/universe/constellations/';
  static readonly getUniverseConstellationsConstellationIdPath = '/universe/constellations/{constellation_id}/';
  static readonly getUniverseFactionsPath = '/universe/factions/';
  static readonly getUniverseGraphicsPath = '/universe/graphics/';
  static readonly getUniverseGraphicsGraphicIdPath = '/universe/graphics/{graphic_id}/';
  static readonly getUniverseGroupsPath = '/universe/groups/';
  static readonly getUniverseGroupsGroupIdPath = '/universe/groups/{group_id}/';
  static readonly postUniverseIdsPath = '/universe/ids/';
  static readonly getUniverseMoonsMoonIdPath = '/universe/moons/{moon_id}/';
  static readonly postUniverseNamesPath = '/universe/names/';
  static readonly getUniversePlanetsPlanetIdPath = '/universe/planets/{planet_id}/';
  static readonly getUniverseRacesPath = '/universe/races/';
  static readonly getUniverseRegionsPath = '/universe/regions/';
  static readonly getUniverseRegionsRegionIdPath = '/universe/regions/{region_id}/';
  static readonly getUniverseStargatesStargateIdPath = '/universe/stargates/{stargate_id}/';
  static readonly getUniverseStarsStarIdPath = '/universe/stars/{star_id}/';
  static readonly getUniverseStationsStationIdPath = '/universe/stations/{station_id}/';
  static readonly getUniverseStructuresPath = '/universe/structures/';
  static readonly getUniverseStructuresStructureIdPath = '/universe/structures/{structure_id}/';
  static readonly getUniverseSystemJumpsPath = '/universe/system_jumps/';
  static readonly getUniverseSystemKillsPath = '/universe/system_kills/';
  static readonly getUniverseSystemsPath = '/universe/systems/';
  static readonly getUniverseSystemsSystemIdPath = '/universe/systems/{system_id}/';
  static readonly getUniverseTypesPath = '/universe/types/';
  static readonly getUniverseTypesTypeIdPath = '/universe/types/{type_id}/';

  constructor(
    config: __Configuration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * Get ancestries
   *
   * Get all character ancestries
   *
   * ---
   * Alternate route: `/dev/universe/ancestries/`
   *
   * Alternate route: `/legacy/universe/ancestries/`
   *
   * Alternate route: `/v1/universe/ancestries/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `UniverseService.GetUniverseAncestriesParams` containing the following parameters:
   *
   * - `language`: Language to use in the response, takes precedence over Accept-Language
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * - `Accept-Language`: Language to use in the response
   *
   * @return A list of ancestries
   */
  getUniverseAncestriesResponse(params: UniverseService.GetUniverseAncestriesParams): __Observable<__StrictHttpResponse<Array<{bloodline_id: number, description: string, icon_id?: number, id: number, name: string, short_description?: string}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.language != null) __params = __params.set('language', params.language.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    if (params.AcceptLanguage != null) __headers = __headers.set('Accept-Language', params.AcceptLanguage.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/universe/ancestries/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{bloodline_id: number, description: string, icon_id?: number, id: number, name: string, short_description?: string}>>;
      })
    );
  }
  /**
   * Get ancestries
   *
   * Get all character ancestries
   *
   * ---
   * Alternate route: `/dev/universe/ancestries/`
   *
   * Alternate route: `/legacy/universe/ancestries/`
   *
   * Alternate route: `/v1/universe/ancestries/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `UniverseService.GetUniverseAncestriesParams` containing the following parameters:
   *
   * - `language`: Language to use in the response, takes precedence over Accept-Language
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * - `Accept-Language`: Language to use in the response
   *
   * @return A list of ancestries
   */
  getUniverseAncestries(params: UniverseService.GetUniverseAncestriesParams): __Observable<Array<{bloodline_id: number, description: string, icon_id?: number, id: number, name: string, short_description?: string}>> {
    return this.getUniverseAncestriesResponse(params).pipe(
      __map(_r => _r.body as Array<{bloodline_id: number, description: string, icon_id?: number, id: number, name: string, short_description?: string}>)
    );
  }

  /**
   * Get asteroid belt information
   *
   * Get information on an asteroid belt
   *
   * ---
   * Alternate route: `/dev/universe/asteroid_belts/{asteroid_belt_id}/`
   *
   * Alternate route: `/legacy/universe/asteroid_belts/{asteroid_belt_id}/`
   *
   * Alternate route: `/v1/universe/asteroid_belts/{asteroid_belt_id}/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `UniverseService.GetUniverseAsteroidBeltsAsteroidBeltIdParams` containing the following parameters:
   *
   * - `asteroid_belt_id`: asteroid_belt_id integer
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Information about an asteroid belt
   */
  getUniverseAsteroidBeltsAsteroidBeltIdResponse(params: UniverseService.GetUniverseAsteroidBeltsAsteroidBeltIdParams): __Observable<__StrictHttpResponse<{name: string, position: {x: number, y: number, z: number}, system_id: number}>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/universe/asteroid_belts/${encodeURIComponent(params.asteroidBeltId)}/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<{name: string, position: {x: number, y: number, z: number}, system_id: number}>;
      })
    );
  }
  /**
   * Get asteroid belt information
   *
   * Get information on an asteroid belt
   *
   * ---
   * Alternate route: `/dev/universe/asteroid_belts/{asteroid_belt_id}/`
   *
   * Alternate route: `/legacy/universe/asteroid_belts/{asteroid_belt_id}/`
   *
   * Alternate route: `/v1/universe/asteroid_belts/{asteroid_belt_id}/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `UniverseService.GetUniverseAsteroidBeltsAsteroidBeltIdParams` containing the following parameters:
   *
   * - `asteroid_belt_id`: asteroid_belt_id integer
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Information about an asteroid belt
   */
  getUniverseAsteroidBeltsAsteroidBeltId(params: UniverseService.GetUniverseAsteroidBeltsAsteroidBeltIdParams): __Observable<{name: string, position: {x: number, y: number, z: number}, system_id: number}> {
    return this.getUniverseAsteroidBeltsAsteroidBeltIdResponse(params).pipe(
      __map(_r => _r.body as {name: string, position: {x: number, y: number, z: number}, system_id: number})
    );
  }

  /**
   * Get bloodlines
   *
   * Get a list of bloodlines
   *
   * ---
   * Alternate route: `/dev/universe/bloodlines/`
   *
   * Alternate route: `/legacy/universe/bloodlines/`
   *
   * Alternate route: `/v1/universe/bloodlines/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `UniverseService.GetUniverseBloodlinesParams` containing the following parameters:
   *
   * - `language`: Language to use in the response, takes precedence over Accept-Language
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * - `Accept-Language`: Language to use in the response
   *
   * @return A list of bloodlines
   */
  getUniverseBloodlinesResponse(params: UniverseService.GetUniverseBloodlinesParams): __Observable<__StrictHttpResponse<Array<{bloodline_id: number, charisma: number, corporation_id: number, description: string, intelligence: number, memory: number, name: string, perception: number, race_id: number, ship_type_id: number, willpower: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.language != null) __params = __params.set('language', params.language.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    if (params.AcceptLanguage != null) __headers = __headers.set('Accept-Language', params.AcceptLanguage.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/universe/bloodlines/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{bloodline_id: number, charisma: number, corporation_id: number, description: string, intelligence: number, memory: number, name: string, perception: number, race_id: number, ship_type_id: number, willpower: number}>>;
      })
    );
  }
  /**
   * Get bloodlines
   *
   * Get a list of bloodlines
   *
   * ---
   * Alternate route: `/dev/universe/bloodlines/`
   *
   * Alternate route: `/legacy/universe/bloodlines/`
   *
   * Alternate route: `/v1/universe/bloodlines/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `UniverseService.GetUniverseBloodlinesParams` containing the following parameters:
   *
   * - `language`: Language to use in the response, takes precedence over Accept-Language
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * - `Accept-Language`: Language to use in the response
   *
   * @return A list of bloodlines
   */
  getUniverseBloodlines(params: UniverseService.GetUniverseBloodlinesParams): __Observable<Array<{bloodline_id: number, charisma: number, corporation_id: number, description: string, intelligence: number, memory: number, name: string, perception: number, race_id: number, ship_type_id: number, willpower: number}>> {
    return this.getUniverseBloodlinesResponse(params).pipe(
      __map(_r => _r.body as Array<{bloodline_id: number, charisma: number, corporation_id: number, description: string, intelligence: number, memory: number, name: string, perception: number, race_id: number, ship_type_id: number, willpower: number}>)
    );
  }

  /**
   * Get item categories
   *
   * Get a list of item categories
   *
   * ---
   * Alternate route: `/dev/universe/categories/`
   *
   * Alternate route: `/legacy/universe/categories/`
   *
   * Alternate route: `/v1/universe/categories/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `UniverseService.GetUniverseCategoriesParams` containing the following parameters:
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of item category ids
   */
  getUniverseCategoriesResponse(params: UniverseService.GetUniverseCategoriesParams): __Observable<__StrictHttpResponse<Array<number>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/universe/categories/`,
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
   * Get item categories
   *
   * Get a list of item categories
   *
   * ---
   * Alternate route: `/dev/universe/categories/`
   *
   * Alternate route: `/legacy/universe/categories/`
   *
   * Alternate route: `/v1/universe/categories/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `UniverseService.GetUniverseCategoriesParams` containing the following parameters:
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of item category ids
   */
  getUniverseCategories(params: UniverseService.GetUniverseCategoriesParams): __Observable<Array<number>> {
    return this.getUniverseCategoriesResponse(params).pipe(
      __map(_r => _r.body as Array<number>)
    );
  }

  /**
   * Get item category information
   *
   * Get information of an item category
   *
   * ---
   * Alternate route: `/dev/universe/categories/{category_id}/`
   *
   * Alternate route: `/legacy/universe/categories/{category_id}/`
   *
   * Alternate route: `/v1/universe/categories/{category_id}/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `UniverseService.GetUniverseCategoriesCategoryIdParams` containing the following parameters:
   *
   * - `category_id`: An Eve item category ID
   *
   * - `language`: Language to use in the response, takes precedence over Accept-Language
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * - `Accept-Language`: Language to use in the response
   *
   * @return Information about an item category
   */
  getUniverseCategoriesCategoryIdResponse(params: UniverseService.GetUniverseCategoriesCategoryIdParams): __Observable<__StrictHttpResponse<{category_id: number, groups: Array<number>, name: string, published: boolean}>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.language != null) __params = __params.set('language', params.language.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    if (params.AcceptLanguage != null) __headers = __headers.set('Accept-Language', params.AcceptLanguage.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/universe/categories/${encodeURIComponent(params.categoryId)}/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<{category_id: number, groups: Array<number>, name: string, published: boolean}>;
      })
    );
  }
  /**
   * Get item category information
   *
   * Get information of an item category
   *
   * ---
   * Alternate route: `/dev/universe/categories/{category_id}/`
   *
   * Alternate route: `/legacy/universe/categories/{category_id}/`
   *
   * Alternate route: `/v1/universe/categories/{category_id}/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `UniverseService.GetUniverseCategoriesCategoryIdParams` containing the following parameters:
   *
   * - `category_id`: An Eve item category ID
   *
   * - `language`: Language to use in the response, takes precedence over Accept-Language
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * - `Accept-Language`: Language to use in the response
   *
   * @return Information about an item category
   */
  getUniverseCategoriesCategoryId(params: UniverseService.GetUniverseCategoriesCategoryIdParams): __Observable<{category_id: number, groups: Array<number>, name: string, published: boolean}> {
    return this.getUniverseCategoriesCategoryIdResponse(params).pipe(
      __map(_r => _r.body as {category_id: number, groups: Array<number>, name: string, published: boolean})
    );
  }

  /**
   * Get constellations
   *
   * Get a list of constellations
   *
   * ---
   * Alternate route: `/dev/universe/constellations/`
   *
   * Alternate route: `/legacy/universe/constellations/`
   *
   * Alternate route: `/v1/universe/constellations/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `UniverseService.GetUniverseConstellationsParams` containing the following parameters:
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of constellation ids
   */
  getUniverseConstellationsResponse(params: UniverseService.GetUniverseConstellationsParams): __Observable<__StrictHttpResponse<Array<number>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/universe/constellations/`,
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
   * Get constellations
   *
   * Get a list of constellations
   *
   * ---
   * Alternate route: `/dev/universe/constellations/`
   *
   * Alternate route: `/legacy/universe/constellations/`
   *
   * Alternate route: `/v1/universe/constellations/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `UniverseService.GetUniverseConstellationsParams` containing the following parameters:
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of constellation ids
   */
  getUniverseConstellations(params: UniverseService.GetUniverseConstellationsParams): __Observable<Array<number>> {
    return this.getUniverseConstellationsResponse(params).pipe(
      __map(_r => _r.body as Array<number>)
    );
  }

  /**
   * Get constellation information
   *
   * Get information on a constellation
   *
   * ---
   * Alternate route: `/dev/universe/constellations/{constellation_id}/`
   *
   * Alternate route: `/legacy/universe/constellations/{constellation_id}/`
   *
   * Alternate route: `/v1/universe/constellations/{constellation_id}/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `UniverseService.GetUniverseConstellationsConstellationIdParams` containing the following parameters:
   *
   * - `constellation_id`: constellation_id integer
   *
   * - `language`: Language to use in the response, takes precedence over Accept-Language
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * - `Accept-Language`: Language to use in the response
   *
   * @return Information about a constellation
   */
  getUniverseConstellationsConstellationIdResponse(params: UniverseService.GetUniverseConstellationsConstellationIdParams): __Observable<__StrictHttpResponse<{constellation_id: number, name: string, position: {x: number, y: number, z: number}, region_id: number, systems: Array<number>}>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.language != null) __params = __params.set('language', params.language.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    if (params.AcceptLanguage != null) __headers = __headers.set('Accept-Language', params.AcceptLanguage.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/universe/constellations/${encodeURIComponent(params.constellationId)}/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<{constellation_id: number, name: string, position: {x: number, y: number, z: number}, region_id: number, systems: Array<number>}>;
      })
    );
  }
  /**
   * Get constellation information
   *
   * Get information on a constellation
   *
   * ---
   * Alternate route: `/dev/universe/constellations/{constellation_id}/`
   *
   * Alternate route: `/legacy/universe/constellations/{constellation_id}/`
   *
   * Alternate route: `/v1/universe/constellations/{constellation_id}/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `UniverseService.GetUniverseConstellationsConstellationIdParams` containing the following parameters:
   *
   * - `constellation_id`: constellation_id integer
   *
   * - `language`: Language to use in the response, takes precedence over Accept-Language
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * - `Accept-Language`: Language to use in the response
   *
   * @return Information about a constellation
   */
  getUniverseConstellationsConstellationId(params: UniverseService.GetUniverseConstellationsConstellationIdParams): __Observable<{constellation_id: number, name: string, position: {x: number, y: number, z: number}, region_id: number, systems: Array<number>}> {
    return this.getUniverseConstellationsConstellationIdResponse(params).pipe(
      __map(_r => _r.body as {constellation_id: number, name: string, position: {x: number, y: number, z: number}, region_id: number, systems: Array<number>})
    );
  }

  /**
   * Get factions
   *
   * Get a list of factions
   *
   * ---
   * Alternate route: `/dev/universe/factions/`
   *
   * Alternate route: `/v2/universe/factions/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `UniverseService.GetUniverseFactionsParams` containing the following parameters:
   *
   * - `language`: Language to use in the response, takes precedence over Accept-Language
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * - `Accept-Language`: Language to use in the response
   *
   * @return A list of factions
   */
  getUniverseFactionsResponse(params: UniverseService.GetUniverseFactionsParams): __Observable<__StrictHttpResponse<Array<{corporation_id?: number, description: string, faction_id: number, is_unique: boolean, militia_corporation_id?: number, name: string, size_factor: number, solar_system_id?: number, station_count: number, station_system_count: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.language != null) __params = __params.set('language', params.language.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    if (params.AcceptLanguage != null) __headers = __headers.set('Accept-Language', params.AcceptLanguage.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/universe/factions/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{corporation_id?: number, description: string, faction_id: number, is_unique: boolean, militia_corporation_id?: number, name: string, size_factor: number, solar_system_id?: number, station_count: number, station_system_count: number}>>;
      })
    );
  }
  /**
   * Get factions
   *
   * Get a list of factions
   *
   * ---
   * Alternate route: `/dev/universe/factions/`
   *
   * Alternate route: `/v2/universe/factions/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `UniverseService.GetUniverseFactionsParams` containing the following parameters:
   *
   * - `language`: Language to use in the response, takes precedence over Accept-Language
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * - `Accept-Language`: Language to use in the response
   *
   * @return A list of factions
   */
  getUniverseFactions(params: UniverseService.GetUniverseFactionsParams): __Observable<Array<{corporation_id?: number, description: string, faction_id: number, is_unique: boolean, militia_corporation_id?: number, name: string, size_factor: number, solar_system_id?: number, station_count: number, station_system_count: number}>> {
    return this.getUniverseFactionsResponse(params).pipe(
      __map(_r => _r.body as Array<{corporation_id?: number, description: string, faction_id: number, is_unique: boolean, militia_corporation_id?: number, name: string, size_factor: number, solar_system_id?: number, station_count: number, station_system_count: number}>)
    );
  }

  /**
   * Get graphics
   *
   * Get a list of graphics
   *
   * ---
   * Alternate route: `/dev/universe/graphics/`
   *
   * Alternate route: `/legacy/universe/graphics/`
   *
   * Alternate route: `/v1/universe/graphics/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `UniverseService.GetUniverseGraphicsParams` containing the following parameters:
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of graphic ids
   */
  getUniverseGraphicsResponse(params: UniverseService.GetUniverseGraphicsParams): __Observable<__StrictHttpResponse<Array<number>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/universe/graphics/`,
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
   * Get graphics
   *
   * Get a list of graphics
   *
   * ---
   * Alternate route: `/dev/universe/graphics/`
   *
   * Alternate route: `/legacy/universe/graphics/`
   *
   * Alternate route: `/v1/universe/graphics/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `UniverseService.GetUniverseGraphicsParams` containing the following parameters:
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of graphic ids
   */
  getUniverseGraphics(params: UniverseService.GetUniverseGraphicsParams): __Observable<Array<number>> {
    return this.getUniverseGraphicsResponse(params).pipe(
      __map(_r => _r.body as Array<number>)
    );
  }

  /**
   * Get graphic information
   *
   * Get information on a graphic
   *
   * ---
   * Alternate route: `/dev/universe/graphics/{graphic_id}/`
   *
   * Alternate route: `/legacy/universe/graphics/{graphic_id}/`
   *
   * Alternate route: `/v1/universe/graphics/{graphic_id}/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `UniverseService.GetUniverseGraphicsGraphicIdParams` containing the following parameters:
   *
   * - `graphic_id`: graphic_id integer
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Information about a graphic
   */
  getUniverseGraphicsGraphicIdResponse(params: UniverseService.GetUniverseGraphicsGraphicIdParams): __Observable<__StrictHttpResponse<{collision_file?: string, graphic_file?: string, graphic_id: number, icon_folder?: string, sof_dna?: string, sof_fation_name?: string, sof_hull_name?: string, sof_race_name?: string}>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/universe/graphics/${encodeURIComponent(params.graphicId)}/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<{collision_file?: string, graphic_file?: string, graphic_id: number, icon_folder?: string, sof_dna?: string, sof_fation_name?: string, sof_hull_name?: string, sof_race_name?: string}>;
      })
    );
  }
  /**
   * Get graphic information
   *
   * Get information on a graphic
   *
   * ---
   * Alternate route: `/dev/universe/graphics/{graphic_id}/`
   *
   * Alternate route: `/legacy/universe/graphics/{graphic_id}/`
   *
   * Alternate route: `/v1/universe/graphics/{graphic_id}/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `UniverseService.GetUniverseGraphicsGraphicIdParams` containing the following parameters:
   *
   * - `graphic_id`: graphic_id integer
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Information about a graphic
   */
  getUniverseGraphicsGraphicId(params: UniverseService.GetUniverseGraphicsGraphicIdParams): __Observable<{collision_file?: string, graphic_file?: string, graphic_id: number, icon_folder?: string, sof_dna?: string, sof_fation_name?: string, sof_hull_name?: string, sof_race_name?: string}> {
    return this.getUniverseGraphicsGraphicIdResponse(params).pipe(
      __map(_r => _r.body as {collision_file?: string, graphic_file?: string, graphic_id: number, icon_folder?: string, sof_dna?: string, sof_fation_name?: string, sof_hull_name?: string, sof_race_name?: string})
    );
  }

  /**
   * Get item groups
   *
   * Get a list of item groups
   *
   * ---
   * Alternate route: `/dev/universe/groups/`
   *
   * Alternate route: `/legacy/universe/groups/`
   *
   * Alternate route: `/v1/universe/groups/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `UniverseService.GetUniverseGroupsParams` containing the following parameters:
   *
   * - `page`: Which page of results to return
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of item group ids
   */
  getUniverseGroupsResponse(params: UniverseService.GetUniverseGroupsParams): __Observable<__StrictHttpResponse<Array<number>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.page != null) __params = __params.set('page', params.page.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/universe/groups/`,
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
   * Get item groups
   *
   * Get a list of item groups
   *
   * ---
   * Alternate route: `/dev/universe/groups/`
   *
   * Alternate route: `/legacy/universe/groups/`
   *
   * Alternate route: `/v1/universe/groups/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `UniverseService.GetUniverseGroupsParams` containing the following parameters:
   *
   * - `page`: Which page of results to return
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of item group ids
   */
  getUniverseGroups(params: UniverseService.GetUniverseGroupsParams): __Observable<Array<number>> {
    return this.getUniverseGroupsResponse(params).pipe(
      __map(_r => _r.body as Array<number>)
    );
  }

  /**
   * Get item group information
   *
   * Get information on an item group
   *
   * ---
   * Alternate route: `/dev/universe/groups/{group_id}/`
   *
   * Alternate route: `/legacy/universe/groups/{group_id}/`
   *
   * Alternate route: `/v1/universe/groups/{group_id}/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `UniverseService.GetUniverseGroupsGroupIdParams` containing the following parameters:
   *
   * - `group_id`: An Eve item group ID
   *
   * - `language`: Language to use in the response, takes precedence over Accept-Language
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * - `Accept-Language`: Language to use in the response
   *
   * @return Information about an item group
   */
  getUniverseGroupsGroupIdResponse(params: UniverseService.GetUniverseGroupsGroupIdParams): __Observable<__StrictHttpResponse<{category_id: number, group_id: number, name: string, published: boolean, types: Array<number>}>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.language != null) __params = __params.set('language', params.language.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    if (params.AcceptLanguage != null) __headers = __headers.set('Accept-Language', params.AcceptLanguage.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/universe/groups/${encodeURIComponent(params.groupId)}/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<{category_id: number, group_id: number, name: string, published: boolean, types: Array<number>}>;
      })
    );
  }
  /**
   * Get item group information
   *
   * Get information on an item group
   *
   * ---
   * Alternate route: `/dev/universe/groups/{group_id}/`
   *
   * Alternate route: `/legacy/universe/groups/{group_id}/`
   *
   * Alternate route: `/v1/universe/groups/{group_id}/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `UniverseService.GetUniverseGroupsGroupIdParams` containing the following parameters:
   *
   * - `group_id`: An Eve item group ID
   *
   * - `language`: Language to use in the response, takes precedence over Accept-Language
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * - `Accept-Language`: Language to use in the response
   *
   * @return Information about an item group
   */
  getUniverseGroupsGroupId(params: UniverseService.GetUniverseGroupsGroupIdParams): __Observable<{category_id: number, group_id: number, name: string, published: boolean, types: Array<number>}> {
    return this.getUniverseGroupsGroupIdResponse(params).pipe(
      __map(_r => _r.body as {category_id: number, group_id: number, name: string, published: boolean, types: Array<number>})
    );
  }

  /**
   * Bulk names to IDs
   *
   * Resolve a set of names to IDs in the following categories: agents, alliances, characters, constellations, corporations factions, inventory_types, regions, stations, and systems. Only exact matches will be returned. All names searched for are cached for 12 hours
   *
   * ---
   * Alternate route: `/dev/universe/ids/`
   *
   * Alternate route: `/legacy/universe/ids/`
   *
   * Alternate route: `/v1/universe/ids/`
   * @param params The `UniverseService.PostUniverseIdsParams` containing the following parameters:
   *
   * - `names`: The names to resolve
   *
   * - `language`: Language to use in the response, takes precedence over Accept-Language
   *
   * - `datasource`: The server name you would like data from
   *
   * - `Accept-Language`: Language to use in the response
   *
   * @return List of id/name associations for a set of names divided by category. Any name passed in that did not have a match will be ommitted
   */
  postUniverseIdsResponse(params: UniverseService.PostUniverseIdsParams): __Observable<__StrictHttpResponse<{agents?: Array<{id?: number, name?: string}>, alliances?: Array<{id?: number, name?: string}>, characters?: Array<{id?: number, name?: string}>, constellations?: Array<{id?: number, name?: string}>, corporations?: Array<{id?: number, name?: string}>, factions?: Array<{id?: number, name?: string}>, inventory_types?: Array<{id?: number, name?: string}>, regions?: Array<{id?: number, name?: string}>, stations?: Array<{id?: number, name?: string}>, systems?: Array<{id?: number, name?: string}>}>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    __body = params.names;
    if (params.language != null) __params = __params.set('language', params.language.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.AcceptLanguage != null) __headers = __headers.set('Accept-Language', params.AcceptLanguage.toString());
    let req = new HttpRequest<any>(
      'POST',
      this.rootUrl + `/universe/ids/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<{agents?: Array<{id?: number, name?: string}>, alliances?: Array<{id?: number, name?: string}>, characters?: Array<{id?: number, name?: string}>, constellations?: Array<{id?: number, name?: string}>, corporations?: Array<{id?: number, name?: string}>, factions?: Array<{id?: number, name?: string}>, inventory_types?: Array<{id?: number, name?: string}>, regions?: Array<{id?: number, name?: string}>, stations?: Array<{id?: number, name?: string}>, systems?: Array<{id?: number, name?: string}>}>;
      })
    );
  }
  /**
   * Bulk names to IDs
   *
   * Resolve a set of names to IDs in the following categories: agents, alliances, characters, constellations, corporations factions, inventory_types, regions, stations, and systems. Only exact matches will be returned. All names searched for are cached for 12 hours
   *
   * ---
   * Alternate route: `/dev/universe/ids/`
   *
   * Alternate route: `/legacy/universe/ids/`
   *
   * Alternate route: `/v1/universe/ids/`
   * @param params The `UniverseService.PostUniverseIdsParams` containing the following parameters:
   *
   * - `names`: The names to resolve
   *
   * - `language`: Language to use in the response, takes precedence over Accept-Language
   *
   * - `datasource`: The server name you would like data from
   *
   * - `Accept-Language`: Language to use in the response
   *
   * @return List of id/name associations for a set of names divided by category. Any name passed in that did not have a match will be ommitted
   */
  postUniverseIds(params: UniverseService.PostUniverseIdsParams): __Observable<{agents?: Array<{id?: number, name?: string}>, alliances?: Array<{id?: number, name?: string}>, characters?: Array<{id?: number, name?: string}>, constellations?: Array<{id?: number, name?: string}>, corporations?: Array<{id?: number, name?: string}>, factions?: Array<{id?: number, name?: string}>, inventory_types?: Array<{id?: number, name?: string}>, regions?: Array<{id?: number, name?: string}>, stations?: Array<{id?: number, name?: string}>, systems?: Array<{id?: number, name?: string}>}> {
    return this.postUniverseIdsResponse(params).pipe(
      __map(_r => _r.body as {agents?: Array<{id?: number, name?: string}>, alliances?: Array<{id?: number, name?: string}>, characters?: Array<{id?: number, name?: string}>, constellations?: Array<{id?: number, name?: string}>, corporations?: Array<{id?: number, name?: string}>, factions?: Array<{id?: number, name?: string}>, inventory_types?: Array<{id?: number, name?: string}>, regions?: Array<{id?: number, name?: string}>, stations?: Array<{id?: number, name?: string}>, systems?: Array<{id?: number, name?: string}>})
    );
  }

  /**
   * Get moon information
   *
   * Get information on a moon
   *
   * ---
   * Alternate route: `/dev/universe/moons/{moon_id}/`
   *
   * Alternate route: `/legacy/universe/moons/{moon_id}/`
   *
   * Alternate route: `/v1/universe/moons/{moon_id}/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `UniverseService.GetUniverseMoonsMoonIdParams` containing the following parameters:
   *
   * - `moon_id`: moon_id integer
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Information about a moon
   */
  getUniverseMoonsMoonIdResponse(params: UniverseService.GetUniverseMoonsMoonIdParams): __Observable<__StrictHttpResponse<{moon_id: number, name: string, position: {x: number, y: number, z: number}, system_id: number}>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/universe/moons/${encodeURIComponent(params.moonId)}/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<{moon_id: number, name: string, position: {x: number, y: number, z: number}, system_id: number}>;
      })
    );
  }
  /**
   * Get moon information
   *
   * Get information on a moon
   *
   * ---
   * Alternate route: `/dev/universe/moons/{moon_id}/`
   *
   * Alternate route: `/legacy/universe/moons/{moon_id}/`
   *
   * Alternate route: `/v1/universe/moons/{moon_id}/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `UniverseService.GetUniverseMoonsMoonIdParams` containing the following parameters:
   *
   * - `moon_id`: moon_id integer
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Information about a moon
   */
  getUniverseMoonsMoonId(params: UniverseService.GetUniverseMoonsMoonIdParams): __Observable<{moon_id: number, name: string, position: {x: number, y: number, z: number}, system_id: number}> {
    return this.getUniverseMoonsMoonIdResponse(params).pipe(
      __map(_r => _r.body as {moon_id: number, name: string, position: {x: number, y: number, z: number}, system_id: number})
    );
  }

  /**
   * Get names and categories for a set of IDs
   *
   * Resolve a set of IDs to names and categories. Supported ID's for resolving are: Characters, Corporations, Alliances, Stations, Solar Systems, Constellations, Regions, Types, Factions
   *
   * ---
   * Alternate route: `/dev/universe/names/`
   *
   * Alternate route: `/v3/universe/names/`
   * @param params The `UniverseService.PostUniverseNamesParams` containing the following parameters:
   *
   * - `ids`: The ids to resolve
   *
   * - `datasource`: The server name you would like data from
   *
   * @return List of id/name associations for a set of IDs. All IDs must resolve to a name, or nothing will be returned
   */
  postUniverseNamesResponse(params: UniverseService.PostUniverseNamesParams): __Observable<__StrictHttpResponse<Array<{category: 'alliance' | 'character' | 'constellation' | 'corporation' | 'inventory_type' | 'region' | 'solar_system' | 'station' | 'faction', id: number, name: string}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    __body = params.ids;
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    let req = new HttpRequest<any>(
      'POST',
      this.rootUrl + `/universe/names/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{category: 'alliance' | 'character' | 'constellation' | 'corporation' | 'inventory_type' | 'region' | 'solar_system' | 'station' | 'faction', id: number, name: string}>>;
      })
    );
  }
  /**
   * Get names and categories for a set of IDs
   *
   * Resolve a set of IDs to names and categories. Supported ID's for resolving are: Characters, Corporations, Alliances, Stations, Solar Systems, Constellations, Regions, Types, Factions
   *
   * ---
   * Alternate route: `/dev/universe/names/`
   *
   * Alternate route: `/v3/universe/names/`
   * @param params The `UniverseService.PostUniverseNamesParams` containing the following parameters:
   *
   * - `ids`: The ids to resolve
   *
   * - `datasource`: The server name you would like data from
   *
   * @return List of id/name associations for a set of IDs. All IDs must resolve to a name, or nothing will be returned
   */
  postUniverseNames(params: UniverseService.PostUniverseNamesParams): __Observable<Array<{category: 'alliance' | 'character' | 'constellation' | 'corporation' | 'inventory_type' | 'region' | 'solar_system' | 'station' | 'faction', id: number, name: string}>> {
    return this.postUniverseNamesResponse(params).pipe(
      __map(_r => _r.body as Array<{category: 'alliance' | 'character' | 'constellation' | 'corporation' | 'inventory_type' | 'region' | 'solar_system' | 'station' | 'faction', id: number, name: string}>)
    );
  }

  /**
   * Get planet information
   *
   * Get information on a planet
   *
   * ---
   * Alternate route: `/dev/universe/planets/{planet_id}/`
   *
   * Alternate route: `/legacy/universe/planets/{planet_id}/`
   *
   * Alternate route: `/v1/universe/planets/{planet_id}/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `UniverseService.GetUniversePlanetsPlanetIdParams` containing the following parameters:
   *
   * - `planet_id`: planet_id integer
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Information about a planet
   */
  getUniversePlanetsPlanetIdResponse(params: UniverseService.GetUniversePlanetsPlanetIdParams): __Observable<__StrictHttpResponse<{name: string, planet_id: number, position: {x: number, y: number, z: number}, system_id: number, type_id: number}>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/universe/planets/${encodeURIComponent(params.planetId)}/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<{name: string, planet_id: number, position: {x: number, y: number, z: number}, system_id: number, type_id: number}>;
      })
    );
  }
  /**
   * Get planet information
   *
   * Get information on a planet
   *
   * ---
   * Alternate route: `/dev/universe/planets/{planet_id}/`
   *
   * Alternate route: `/legacy/universe/planets/{planet_id}/`
   *
   * Alternate route: `/v1/universe/planets/{planet_id}/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `UniverseService.GetUniversePlanetsPlanetIdParams` containing the following parameters:
   *
   * - `planet_id`: planet_id integer
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Information about a planet
   */
  getUniversePlanetsPlanetId(params: UniverseService.GetUniversePlanetsPlanetIdParams): __Observable<{name: string, planet_id: number, position: {x: number, y: number, z: number}, system_id: number, type_id: number}> {
    return this.getUniversePlanetsPlanetIdResponse(params).pipe(
      __map(_r => _r.body as {name: string, planet_id: number, position: {x: number, y: number, z: number}, system_id: number, type_id: number})
    );
  }

  /**
   * Get character races
   *
   * Get a list of character races
   *
   * ---
   * Alternate route: `/dev/universe/races/`
   *
   * Alternate route: `/legacy/universe/races/`
   *
   * Alternate route: `/v1/universe/races/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `UniverseService.GetUniverseRacesParams` containing the following parameters:
   *
   * - `language`: Language to use in the response, takes precedence over Accept-Language
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * - `Accept-Language`: Language to use in the response
   *
   * @return A list of character races
   */
  getUniverseRacesResponse(params: UniverseService.GetUniverseRacesParams): __Observable<__StrictHttpResponse<Array<{alliance_id: number, description: string, name: string, race_id: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.language != null) __params = __params.set('language', params.language.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    if (params.AcceptLanguage != null) __headers = __headers.set('Accept-Language', params.AcceptLanguage.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/universe/races/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{alliance_id: number, description: string, name: string, race_id: number}>>;
      })
    );
  }
  /**
   * Get character races
   *
   * Get a list of character races
   *
   * ---
   * Alternate route: `/dev/universe/races/`
   *
   * Alternate route: `/legacy/universe/races/`
   *
   * Alternate route: `/v1/universe/races/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `UniverseService.GetUniverseRacesParams` containing the following parameters:
   *
   * - `language`: Language to use in the response, takes precedence over Accept-Language
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * - `Accept-Language`: Language to use in the response
   *
   * @return A list of character races
   */
  getUniverseRaces(params: UniverseService.GetUniverseRacesParams): __Observable<Array<{alliance_id: number, description: string, name: string, race_id: number}>> {
    return this.getUniverseRacesResponse(params).pipe(
      __map(_r => _r.body as Array<{alliance_id: number, description: string, name: string, race_id: number}>)
    );
  }

  /**
   * Get regions
   *
   * Get a list of regions
   *
   * ---
   * Alternate route: `/dev/universe/regions/`
   *
   * Alternate route: `/legacy/universe/regions/`
   *
   * Alternate route: `/v1/universe/regions/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `UniverseService.GetUniverseRegionsParams` containing the following parameters:
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of region ids
   */
  getUniverseRegionsResponse(params: UniverseService.GetUniverseRegionsParams): __Observable<__StrictHttpResponse<Array<number>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/universe/regions/`,
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
   * Get regions
   *
   * Get a list of regions
   *
   * ---
   * Alternate route: `/dev/universe/regions/`
   *
   * Alternate route: `/legacy/universe/regions/`
   *
   * Alternate route: `/v1/universe/regions/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `UniverseService.GetUniverseRegionsParams` containing the following parameters:
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of region ids
   */
  getUniverseRegions(params: UniverseService.GetUniverseRegionsParams): __Observable<Array<number>> {
    return this.getUniverseRegionsResponse(params).pipe(
      __map(_r => _r.body as Array<number>)
    );
  }

  /**
   * Get region information
   *
   * Get information on a region
   *
   * ---
   * Alternate route: `/dev/universe/regions/{region_id}/`
   *
   * Alternate route: `/legacy/universe/regions/{region_id}/`
   *
   * Alternate route: `/v1/universe/regions/{region_id}/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `UniverseService.GetUniverseRegionsRegionIdParams` containing the following parameters:
   *
   * - `region_id`: region_id integer
   *
   * - `language`: Language to use in the response, takes precedence over Accept-Language
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * - `Accept-Language`: Language to use in the response
   *
   * @return Information about a region
   */
  getUniverseRegionsRegionIdResponse(params: UniverseService.GetUniverseRegionsRegionIdParams): __Observable<__StrictHttpResponse<{constellations: Array<number>, description?: string, name: string, region_id: number}>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.language != null) __params = __params.set('language', params.language.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    if (params.AcceptLanguage != null) __headers = __headers.set('Accept-Language', params.AcceptLanguage.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/universe/regions/${encodeURIComponent(params.regionId)}/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<{constellations: Array<number>, description?: string, name: string, region_id: number}>;
      })
    );
  }
  /**
   * Get region information
   *
   * Get information on a region
   *
   * ---
   * Alternate route: `/dev/universe/regions/{region_id}/`
   *
   * Alternate route: `/legacy/universe/regions/{region_id}/`
   *
   * Alternate route: `/v1/universe/regions/{region_id}/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `UniverseService.GetUniverseRegionsRegionIdParams` containing the following parameters:
   *
   * - `region_id`: region_id integer
   *
   * - `language`: Language to use in the response, takes precedence over Accept-Language
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * - `Accept-Language`: Language to use in the response
   *
   * @return Information about a region
   */
  getUniverseRegionsRegionId(params: UniverseService.GetUniverseRegionsRegionIdParams): __Observable<{constellations: Array<number>, description?: string, name: string, region_id: number}> {
    return this.getUniverseRegionsRegionIdResponse(params).pipe(
      __map(_r => _r.body as {constellations: Array<number>, description?: string, name: string, region_id: number})
    );
  }

  /**
   * Get stargate information
   *
   * Get information on a stargate
   *
   * ---
   * Alternate route: `/dev/universe/stargates/{stargate_id}/`
   *
   * Alternate route: `/legacy/universe/stargates/{stargate_id}/`
   *
   * Alternate route: `/v1/universe/stargates/{stargate_id}/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `UniverseService.GetUniverseStargatesStargateIdParams` containing the following parameters:
   *
   * - `stargate_id`: stargate_id integer
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Information about a stargate
   */
  getUniverseStargatesStargateIdResponse(params: UniverseService.GetUniverseStargatesStargateIdParams): __Observable<__StrictHttpResponse<{destination: {stargate_id: number, system_id: number}, name: string, position: {x: number, y: number, z: number}, stargate_id: number, system_id: number, type_id: number}>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/universe/stargates/${encodeURIComponent(params.stargateId)}/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<{destination: {stargate_id: number, system_id: number}, name: string, position: {x: number, y: number, z: number}, stargate_id: number, system_id: number, type_id: number}>;
      })
    );
  }
  /**
   * Get stargate information
   *
   * Get information on a stargate
   *
   * ---
   * Alternate route: `/dev/universe/stargates/{stargate_id}/`
   *
   * Alternate route: `/legacy/universe/stargates/{stargate_id}/`
   *
   * Alternate route: `/v1/universe/stargates/{stargate_id}/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `UniverseService.GetUniverseStargatesStargateIdParams` containing the following parameters:
   *
   * - `stargate_id`: stargate_id integer
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Information about a stargate
   */
  getUniverseStargatesStargateId(params: UniverseService.GetUniverseStargatesStargateIdParams): __Observable<{destination: {stargate_id: number, system_id: number}, name: string, position: {x: number, y: number, z: number}, stargate_id: number, system_id: number, type_id: number}> {
    return this.getUniverseStargatesStargateIdResponse(params).pipe(
      __map(_r => _r.body as {destination: {stargate_id: number, system_id: number}, name: string, position: {x: number, y: number, z: number}, stargate_id: number, system_id: number, type_id: number})
    );
  }

  /**
   * Get star information
   *
   * Get information on a star
   *
   * ---
   * Alternate route: `/dev/universe/stars/{star_id}/`
   *
   * Alternate route: `/legacy/universe/stars/{star_id}/`
   *
   * Alternate route: `/v1/universe/stars/{star_id}/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `UniverseService.GetUniverseStarsStarIdParams` containing the following parameters:
   *
   * - `star_id`: star_id integer
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Information about a star
   */
  getUniverseStarsStarIdResponse(params: UniverseService.GetUniverseStarsStarIdParams): __Observable<__StrictHttpResponse<{age: number, luminosity: number, name: string, radius: number, solar_system_id: number, spectral_class: 'K2 V' | 'K4 V' | 'G2 V' | 'G8 V' | 'M7 V' | 'K7 V' | 'M2 V' | 'K5 V' | 'M3 V' | 'G0 V' | 'G7 V' | 'G3 V' | 'F9 V' | 'G5 V' | 'F6 V' | 'K8 V' | 'K9 V' | 'K6 V' | 'G9 V' | 'G6 V' | 'G4 VI' | 'G4 V' | 'F8 V' | 'F2 V' | 'F1 V' | 'K3 V' | 'F0 VI' | 'G1 VI' | 'G0 VI' | 'K1 V' | 'M4 V' | 'M1 V' | 'M6 V' | 'M0 V' | 'K2 IV' | 'G2 VI' | 'K0 V' | 'K5 IV' | 'F5 VI' | 'G6 VI' | 'F6 VI' | 'F2 IV' | 'G3 VI' | 'M8 V' | 'F1 VI' | 'K1 IV' | 'F7 V' | 'G5 VI' | 'M5 V' | 'G7 VI' | 'F5 V' | 'F4 VI' | 'F8 VI' | 'K3 IV' | 'F4 IV' | 'F0 V' | 'G7 IV' | 'G8 VI' | 'F2 VI' | 'F4 V' | 'F7 VI' | 'F3 V' | 'G1 V' | 'G9 VI' | 'F3 IV' | 'F9 VI' | 'M9 V' | 'K0 IV' | 'F1 IV' | 'G4 IV' | 'F3 VI' | 'K4 IV' | 'G5 IV' | 'G3 IV' | 'G1 IV' | 'K7 IV' | 'G0 IV' | 'K6 IV' | 'K9 IV' | 'G2 IV' | 'F9 IV' | 'F0 IV' | 'K8 IV' | 'G8 IV' | 'F6 IV' | 'F5 IV' | 'A0' | 'A0IV' | 'A0IV2', temperature: number, type_id: number}>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/universe/stars/${encodeURIComponent(params.starId)}/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<{age: number, luminosity: number, name: string, radius: number, solar_system_id: number, spectral_class: 'K2 V' | 'K4 V' | 'G2 V' | 'G8 V' | 'M7 V' | 'K7 V' | 'M2 V' | 'K5 V' | 'M3 V' | 'G0 V' | 'G7 V' | 'G3 V' | 'F9 V' | 'G5 V' | 'F6 V' | 'K8 V' | 'K9 V' | 'K6 V' | 'G9 V' | 'G6 V' | 'G4 VI' | 'G4 V' | 'F8 V' | 'F2 V' | 'F1 V' | 'K3 V' | 'F0 VI' | 'G1 VI' | 'G0 VI' | 'K1 V' | 'M4 V' | 'M1 V' | 'M6 V' | 'M0 V' | 'K2 IV' | 'G2 VI' | 'K0 V' | 'K5 IV' | 'F5 VI' | 'G6 VI' | 'F6 VI' | 'F2 IV' | 'G3 VI' | 'M8 V' | 'F1 VI' | 'K1 IV' | 'F7 V' | 'G5 VI' | 'M5 V' | 'G7 VI' | 'F5 V' | 'F4 VI' | 'F8 VI' | 'K3 IV' | 'F4 IV' | 'F0 V' | 'G7 IV' | 'G8 VI' | 'F2 VI' | 'F4 V' | 'F7 VI' | 'F3 V' | 'G1 V' | 'G9 VI' | 'F3 IV' | 'F9 VI' | 'M9 V' | 'K0 IV' | 'F1 IV' | 'G4 IV' | 'F3 VI' | 'K4 IV' | 'G5 IV' | 'G3 IV' | 'G1 IV' | 'K7 IV' | 'G0 IV' | 'K6 IV' | 'K9 IV' | 'G2 IV' | 'F9 IV' | 'F0 IV' | 'K8 IV' | 'G8 IV' | 'F6 IV' | 'F5 IV' | 'A0' | 'A0IV' | 'A0IV2', temperature: number, type_id: number}>;
      })
    );
  }
  /**
   * Get star information
   *
   * Get information on a star
   *
   * ---
   * Alternate route: `/dev/universe/stars/{star_id}/`
   *
   * Alternate route: `/legacy/universe/stars/{star_id}/`
   *
   * Alternate route: `/v1/universe/stars/{star_id}/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `UniverseService.GetUniverseStarsStarIdParams` containing the following parameters:
   *
   * - `star_id`: star_id integer
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Information about a star
   */
  getUniverseStarsStarId(params: UniverseService.GetUniverseStarsStarIdParams): __Observable<{age: number, luminosity: number, name: string, radius: number, solar_system_id: number, spectral_class: 'K2 V' | 'K4 V' | 'G2 V' | 'G8 V' | 'M7 V' | 'K7 V' | 'M2 V' | 'K5 V' | 'M3 V' | 'G0 V' | 'G7 V' | 'G3 V' | 'F9 V' | 'G5 V' | 'F6 V' | 'K8 V' | 'K9 V' | 'K6 V' | 'G9 V' | 'G6 V' | 'G4 VI' | 'G4 V' | 'F8 V' | 'F2 V' | 'F1 V' | 'K3 V' | 'F0 VI' | 'G1 VI' | 'G0 VI' | 'K1 V' | 'M4 V' | 'M1 V' | 'M6 V' | 'M0 V' | 'K2 IV' | 'G2 VI' | 'K0 V' | 'K5 IV' | 'F5 VI' | 'G6 VI' | 'F6 VI' | 'F2 IV' | 'G3 VI' | 'M8 V' | 'F1 VI' | 'K1 IV' | 'F7 V' | 'G5 VI' | 'M5 V' | 'G7 VI' | 'F5 V' | 'F4 VI' | 'F8 VI' | 'K3 IV' | 'F4 IV' | 'F0 V' | 'G7 IV' | 'G8 VI' | 'F2 VI' | 'F4 V' | 'F7 VI' | 'F3 V' | 'G1 V' | 'G9 VI' | 'F3 IV' | 'F9 VI' | 'M9 V' | 'K0 IV' | 'F1 IV' | 'G4 IV' | 'F3 VI' | 'K4 IV' | 'G5 IV' | 'G3 IV' | 'G1 IV' | 'K7 IV' | 'G0 IV' | 'K6 IV' | 'K9 IV' | 'G2 IV' | 'F9 IV' | 'F0 IV' | 'K8 IV' | 'G8 IV' | 'F6 IV' | 'F5 IV' | 'A0' | 'A0IV' | 'A0IV2', temperature: number, type_id: number}> {
    return this.getUniverseStarsStarIdResponse(params).pipe(
      __map(_r => _r.body as {age: number, luminosity: number, name: string, radius: number, solar_system_id: number, spectral_class: 'K2 V' | 'K4 V' | 'G2 V' | 'G8 V' | 'M7 V' | 'K7 V' | 'M2 V' | 'K5 V' | 'M3 V' | 'G0 V' | 'G7 V' | 'G3 V' | 'F9 V' | 'G5 V' | 'F6 V' | 'K8 V' | 'K9 V' | 'K6 V' | 'G9 V' | 'G6 V' | 'G4 VI' | 'G4 V' | 'F8 V' | 'F2 V' | 'F1 V' | 'K3 V' | 'F0 VI' | 'G1 VI' | 'G0 VI' | 'K1 V' | 'M4 V' | 'M1 V' | 'M6 V' | 'M0 V' | 'K2 IV' | 'G2 VI' | 'K0 V' | 'K5 IV' | 'F5 VI' | 'G6 VI' | 'F6 VI' | 'F2 IV' | 'G3 VI' | 'M8 V' | 'F1 VI' | 'K1 IV' | 'F7 V' | 'G5 VI' | 'M5 V' | 'G7 VI' | 'F5 V' | 'F4 VI' | 'F8 VI' | 'K3 IV' | 'F4 IV' | 'F0 V' | 'G7 IV' | 'G8 VI' | 'F2 VI' | 'F4 V' | 'F7 VI' | 'F3 V' | 'G1 V' | 'G9 VI' | 'F3 IV' | 'F9 VI' | 'M9 V' | 'K0 IV' | 'F1 IV' | 'G4 IV' | 'F3 VI' | 'K4 IV' | 'G5 IV' | 'G3 IV' | 'G1 IV' | 'K7 IV' | 'G0 IV' | 'K6 IV' | 'K9 IV' | 'G2 IV' | 'F9 IV' | 'F0 IV' | 'K8 IV' | 'G8 IV' | 'F6 IV' | 'F5 IV' | 'A0' | 'A0IV' | 'A0IV2', temperature: number, type_id: number})
    );
  }

  /**
   * Get station information
   *
   * Get information on a station
   *
   * ---
   * Alternate route: `/dev/universe/stations/{station_id}/`
   *
   * Alternate route: `/v2/universe/stations/{station_id}/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `UniverseService.GetUniverseStationsStationIdParams` containing the following parameters:
   *
   * - `station_id`: station_id integer
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Information about a station
   */
  getUniverseStationsStationIdResponse(params: UniverseService.GetUniverseStationsStationIdParams): __Observable<__StrictHttpResponse<{max_dockable_ship_volume: number, name: string, office_rental_cost: number, owner?: number, position: {x: number, y: number, z: number}, race_id?: number, reprocessing_efficiency: number, reprocessing_stations_take: number, services: Array<'bounty-missions' | 'assasination-missions' | 'courier-missions' | 'interbus' | 'reprocessing-plant' | 'refinery' | 'market' | 'black-market' | 'stock-exchange' | 'cloning' | 'surgery' | 'dna-therapy' | 'repair-facilities' | 'factory' | 'labratory' | 'gambling' | 'fitting' | 'paintshop' | 'news' | 'storage' | 'insurance' | 'docking' | 'office-rental' | 'jump-clone-facility' | 'loyalty-point-store' | 'navy-offices' | 'security-offices'>, station_id: number, system_id: number, type_id: number}>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/universe/stations/${encodeURIComponent(params.stationId)}/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<{max_dockable_ship_volume: number, name: string, office_rental_cost: number, owner?: number, position: {x: number, y: number, z: number}, race_id?: number, reprocessing_efficiency: number, reprocessing_stations_take: number, services: Array<'bounty-missions' | 'assasination-missions' | 'courier-missions' | 'interbus' | 'reprocessing-plant' | 'refinery' | 'market' | 'black-market' | 'stock-exchange' | 'cloning' | 'surgery' | 'dna-therapy' | 'repair-facilities' | 'factory' | 'labratory' | 'gambling' | 'fitting' | 'paintshop' | 'news' | 'storage' | 'insurance' | 'docking' | 'office-rental' | 'jump-clone-facility' | 'loyalty-point-store' | 'navy-offices' | 'security-offices'>, station_id: number, system_id: number, type_id: number}>;
      })
    );
  }
  /**
   * Get station information
   *
   * Get information on a station
   *
   * ---
   * Alternate route: `/dev/universe/stations/{station_id}/`
   *
   * Alternate route: `/v2/universe/stations/{station_id}/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `UniverseService.GetUniverseStationsStationIdParams` containing the following parameters:
   *
   * - `station_id`: station_id integer
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Information about a station
   */
  getUniverseStationsStationId(params: UniverseService.GetUniverseStationsStationIdParams): __Observable<{max_dockable_ship_volume: number, name: string, office_rental_cost: number, owner?: number, position: {x: number, y: number, z: number}, race_id?: number, reprocessing_efficiency: number, reprocessing_stations_take: number, services: Array<'bounty-missions' | 'assasination-missions' | 'courier-missions' | 'interbus' | 'reprocessing-plant' | 'refinery' | 'market' | 'black-market' | 'stock-exchange' | 'cloning' | 'surgery' | 'dna-therapy' | 'repair-facilities' | 'factory' | 'labratory' | 'gambling' | 'fitting' | 'paintshop' | 'news' | 'storage' | 'insurance' | 'docking' | 'office-rental' | 'jump-clone-facility' | 'loyalty-point-store' | 'navy-offices' | 'security-offices'>, station_id: number, system_id: number, type_id: number}> {
    return this.getUniverseStationsStationIdResponse(params).pipe(
      __map(_r => _r.body as {max_dockable_ship_volume: number, name: string, office_rental_cost: number, owner?: number, position: {x: number, y: number, z: number}, race_id?: number, reprocessing_efficiency: number, reprocessing_stations_take: number, services: Array<'bounty-missions' | 'assasination-missions' | 'courier-missions' | 'interbus' | 'reprocessing-plant' | 'refinery' | 'market' | 'black-market' | 'stock-exchange' | 'cloning' | 'surgery' | 'dna-therapy' | 'repair-facilities' | 'factory' | 'labratory' | 'gambling' | 'fitting' | 'paintshop' | 'news' | 'storage' | 'insurance' | 'docking' | 'office-rental' | 'jump-clone-facility' | 'loyalty-point-store' | 'navy-offices' | 'security-offices'>, station_id: number, system_id: number, type_id: number})
    );
  }

  /**
   * List all public structures
   *
   * List all public structures
   *
   * ---
   * Alternate route: `/dev/universe/structures/`
   *
   * Alternate route: `/legacy/universe/structures/`
   *
   * Alternate route: `/v1/universe/structures/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `UniverseService.GetUniverseStructuresParams` containing the following parameters:
   *
   * - `filter`: Only list public structures that have this service online
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return List of public structure IDs
   */
  getUniverseStructuresResponse(params: UniverseService.GetUniverseStructuresParams): __Observable<__StrictHttpResponse<Array<number>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.filter != null) __params = __params.set('filter', params.filter.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/universe/structures/`,
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
   * List all public structures
   *
   * List all public structures
   *
   * ---
   * Alternate route: `/dev/universe/structures/`
   *
   * Alternate route: `/legacy/universe/structures/`
   *
   * Alternate route: `/v1/universe/structures/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `UniverseService.GetUniverseStructuresParams` containing the following parameters:
   *
   * - `filter`: Only list public structures that have this service online
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return List of public structure IDs
   */
  getUniverseStructures(params: UniverseService.GetUniverseStructuresParams): __Observable<Array<number>> {
    return this.getUniverseStructuresResponse(params).pipe(
      __map(_r => _r.body as Array<number>)
    );
  }

  /**
   * Get structure information
   *
   * Returns information on requested structure if you are on the ACL. Otherwise, returns "Forbidden" for all inputs.
   *
   * ---
   * Alternate route: `/dev/universe/structures/{structure_id}/`
   *
   * Alternate route: `/v2/universe/structures/{structure_id}/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `UniverseService.GetUniverseStructuresStructureIdParams` containing the following parameters:
   *
   * - `structure_id`: An Eve structure ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Data about a structure
   */
  getUniverseStructuresStructureIdResponse(params: UniverseService.GetUniverseStructuresStructureIdParams): __Observable<__StrictHttpResponse<{name: string, owner_id: number, position?: {x: number, y: number, z: number}, solar_system_id: number, type_id?: number}>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/universe/structures/${encodeURIComponent(params.structureId)}/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<{name: string, owner_id: number, position?: {x: number, y: number, z: number}, solar_system_id: number, type_id?: number}>;
      })
    );
  }
  /**
   * Get structure information
   *
   * Returns information on requested structure if you are on the ACL. Otherwise, returns "Forbidden" for all inputs.
   *
   * ---
   * Alternate route: `/dev/universe/structures/{structure_id}/`
   *
   * Alternate route: `/v2/universe/structures/{structure_id}/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `UniverseService.GetUniverseStructuresStructureIdParams` containing the following parameters:
   *
   * - `structure_id`: An Eve structure ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Data about a structure
   */
  getUniverseStructuresStructureId(params: UniverseService.GetUniverseStructuresStructureIdParams): __Observable<{name: string, owner_id: number, position?: {x: number, y: number, z: number}, solar_system_id: number, type_id?: number}> {
    return this.getUniverseStructuresStructureIdResponse(params).pipe(
      __map(_r => _r.body as {name: string, owner_id: number, position?: {x: number, y: number, z: number}, solar_system_id: number, type_id?: number})
    );
  }

  /**
   * Get system jumps
   *
   * Get the number of jumps in solar systems within the last hour ending at the timestamp of the Last-Modified header, excluding wormhole space. Only systems with jumps will be listed
   *
   * ---
   * Alternate route: `/dev/universe/system_jumps/`
   *
   * Alternate route: `/legacy/universe/system_jumps/`
   *
   * Alternate route: `/v1/universe/system_jumps/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `UniverseService.GetUniverseSystemJumpsParams` containing the following parameters:
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of systems and number of jumps
   */
  getUniverseSystemJumpsResponse(params: UniverseService.GetUniverseSystemJumpsParams): __Observable<__StrictHttpResponse<Array<{ship_jumps: number, system_id: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/universe/system_jumps/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{ship_jumps: number, system_id: number}>>;
      })
    );
  }
  /**
   * Get system jumps
   *
   * Get the number of jumps in solar systems within the last hour ending at the timestamp of the Last-Modified header, excluding wormhole space. Only systems with jumps will be listed
   *
   * ---
   * Alternate route: `/dev/universe/system_jumps/`
   *
   * Alternate route: `/legacy/universe/system_jumps/`
   *
   * Alternate route: `/v1/universe/system_jumps/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `UniverseService.GetUniverseSystemJumpsParams` containing the following parameters:
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of systems and number of jumps
   */
  getUniverseSystemJumps(params: UniverseService.GetUniverseSystemJumpsParams): __Observable<Array<{ship_jumps: number, system_id: number}>> {
    return this.getUniverseSystemJumpsResponse(params).pipe(
      __map(_r => _r.body as Array<{ship_jumps: number, system_id: number}>)
    );
  }

  /**
   * Get system kills
   *
   * Get the number of ship, pod and NPC kills per solar system within the last hour ending at the timestamp of the Last-Modified header, excluding wormhole space. Only systems with kills will be listed
   *
   * ---
   * Alternate route: `/dev/universe/system_kills/`
   *
   * Alternate route: `/v2/universe/system_kills/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `UniverseService.GetUniverseSystemKillsParams` containing the following parameters:
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of systems and number of ship, pod and NPC kills
   */
  getUniverseSystemKillsResponse(params: UniverseService.GetUniverseSystemKillsParams): __Observable<__StrictHttpResponse<Array<{npc_kills: number, pod_kills: number, ship_kills: number, system_id: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/universe/system_kills/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{npc_kills: number, pod_kills: number, ship_kills: number, system_id: number}>>;
      })
    );
  }
  /**
   * Get system kills
   *
   * Get the number of ship, pod and NPC kills per solar system within the last hour ending at the timestamp of the Last-Modified header, excluding wormhole space. Only systems with kills will be listed
   *
   * ---
   * Alternate route: `/dev/universe/system_kills/`
   *
   * Alternate route: `/v2/universe/system_kills/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `UniverseService.GetUniverseSystemKillsParams` containing the following parameters:
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of systems and number of ship, pod and NPC kills
   */
  getUniverseSystemKills(params: UniverseService.GetUniverseSystemKillsParams): __Observable<Array<{npc_kills: number, pod_kills: number, ship_kills: number, system_id: number}>> {
    return this.getUniverseSystemKillsResponse(params).pipe(
      __map(_r => _r.body as Array<{npc_kills: number, pod_kills: number, ship_kills: number, system_id: number}>)
    );
  }

  /**
   * Get solar systems
   *
   * Get a list of solar systems
   *
   * ---
   * Alternate route: `/dev/universe/systems/`
   *
   * Alternate route: `/legacy/universe/systems/`
   *
   * Alternate route: `/v1/universe/systems/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `UniverseService.GetUniverseSystemsParams` containing the following parameters:
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of solar system ids
   */
  getUniverseSystemsResponse(params: UniverseService.GetUniverseSystemsParams): __Observable<__StrictHttpResponse<Array<number>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/universe/systems/`,
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
   * Get solar systems
   *
   * Get a list of solar systems
   *
   * ---
   * Alternate route: `/dev/universe/systems/`
   *
   * Alternate route: `/legacy/universe/systems/`
   *
   * Alternate route: `/v1/universe/systems/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `UniverseService.GetUniverseSystemsParams` containing the following parameters:
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of solar system ids
   */
  getUniverseSystems(params: UniverseService.GetUniverseSystemsParams): __Observable<Array<number>> {
    return this.getUniverseSystemsResponse(params).pipe(
      __map(_r => _r.body as Array<number>)
    );
  }

  /**
   * Get solar system information
   *
   * Get information on a solar system.
   *
   * ---
   * Alternate route: `/dev/universe/systems/{system_id}/`
   *
   * Alternate route: `/v4/universe/systems/{system_id}/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `UniverseService.GetUniverseSystemsSystemIdParams` containing the following parameters:
   *
   * - `system_id`: system_id integer
   *
   * - `language`: Language to use in the response, takes precedence over Accept-Language
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * - `Accept-Language`: Language to use in the response
   *
   * @return Information about a solar system
   */
  getUniverseSystemsSystemIdResponse(params: UniverseService.GetUniverseSystemsSystemIdParams): __Observable<__StrictHttpResponse<{constellation_id: number, name: string, planets?: Array<{asteroid_belts?: Array<number>, moons?: Array<number>, planet_id: number}>, position: {x: number, y: number, z: number}, security_class?: string, security_status: number, star_id?: number, stargates?: Array<number>, stations?: Array<number>, system_id: number}>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.language != null) __params = __params.set('language', params.language.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    if (params.AcceptLanguage != null) __headers = __headers.set('Accept-Language', params.AcceptLanguage.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/universe/systems/${encodeURIComponent(params.systemId)}/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<{constellation_id: number, name: string, planets?: Array<{asteroid_belts?: Array<number>, moons?: Array<number>, planet_id: number}>, position: {x: number, y: number, z: number}, security_class?: string, security_status: number, star_id?: number, stargates?: Array<number>, stations?: Array<number>, system_id: number}>;
      })
    );
  }
  /**
   * Get solar system information
   *
   * Get information on a solar system.
   *
   * ---
   * Alternate route: `/dev/universe/systems/{system_id}/`
   *
   * Alternate route: `/v4/universe/systems/{system_id}/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `UniverseService.GetUniverseSystemsSystemIdParams` containing the following parameters:
   *
   * - `system_id`: system_id integer
   *
   * - `language`: Language to use in the response, takes precedence over Accept-Language
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * - `Accept-Language`: Language to use in the response
   *
   * @return Information about a solar system
   */
  getUniverseSystemsSystemId(params: UniverseService.GetUniverseSystemsSystemIdParams): __Observable<{constellation_id: number, name: string, planets?: Array<{asteroid_belts?: Array<number>, moons?: Array<number>, planet_id: number}>, position: {x: number, y: number, z: number}, security_class?: string, security_status: number, star_id?: number, stargates?: Array<number>, stations?: Array<number>, system_id: number}> {
    return this.getUniverseSystemsSystemIdResponse(params).pipe(
      __map(_r => _r.body as {constellation_id: number, name: string, planets?: Array<{asteroid_belts?: Array<number>, moons?: Array<number>, planet_id: number}>, position: {x: number, y: number, z: number}, security_class?: string, security_status: number, star_id?: number, stargates?: Array<number>, stations?: Array<number>, system_id: number})
    );
  }

  /**
   * Get types
   *
   * Get a list of type ids
   *
   * ---
   * Alternate route: `/dev/universe/types/`
   *
   * Alternate route: `/legacy/universe/types/`
   *
   * Alternate route: `/v1/universe/types/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `UniverseService.GetUniverseTypesParams` containing the following parameters:
   *
   * - `page`: Which page of results to return
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of type ids
   */
  getUniverseTypesResponse(params: UniverseService.GetUniverseTypesParams): __Observable<__StrictHttpResponse<Array<number>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.page != null) __params = __params.set('page', params.page.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/universe/types/`,
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
   * Get types
   *
   * Get a list of type ids
   *
   * ---
   * Alternate route: `/dev/universe/types/`
   *
   * Alternate route: `/legacy/universe/types/`
   *
   * Alternate route: `/v1/universe/types/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `UniverseService.GetUniverseTypesParams` containing the following parameters:
   *
   * - `page`: Which page of results to return
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of type ids
   */
  getUniverseTypes(params: UniverseService.GetUniverseTypesParams): __Observable<Array<number>> {
    return this.getUniverseTypesResponse(params).pipe(
      __map(_r => _r.body as Array<number>)
    );
  }

  /**
   * Get type information
   *
   * Get information on a type
   *
   * ---
   * Alternate route: `/dev/universe/types/{type_id}/`
   *
   * Alternate route: `/v3/universe/types/{type_id}/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `UniverseService.GetUniverseTypesTypeIdParams` containing the following parameters:
   *
   * - `type_id`: An Eve item type ID
   *
   * - `language`: Language to use in the response, takes precedence over Accept-Language
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * - `Accept-Language`: Language to use in the response
   *
   * @return Information about a type
   */
  getUniverseTypesTypeIdResponse(params: UniverseService.GetUniverseTypesTypeIdParams): __Observable<__StrictHttpResponse<{capacity?: number, description: string, dogma_attributes?: Array<{attribute_id: number, value: number}>, dogma_effects?: Array<{effect_id: number, is_default: boolean}>, graphic_id?: number, group_id: number, icon_id?: number, market_group_id?: number, mass?: number, name: string, packaged_volume?: number, portion_size?: number, published: boolean, radius?: number, type_id: number, volume?: number}>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.language != null) __params = __params.set('language', params.language.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    if (params.AcceptLanguage != null) __headers = __headers.set('Accept-Language', params.AcceptLanguage.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/universe/types/${encodeURIComponent(params.typeId)}/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<{capacity?: number, description: string, dogma_attributes?: Array<{attribute_id: number, value: number}>, dogma_effects?: Array<{effect_id: number, is_default: boolean}>, graphic_id?: number, group_id: number, icon_id?: number, market_group_id?: number, mass?: number, name: string, packaged_volume?: number, portion_size?: number, published: boolean, radius?: number, type_id: number, volume?: number}>;
      })
    );
  }
  /**
   * Get type information
   *
   * Get information on a type
   *
   * ---
   * Alternate route: `/dev/universe/types/{type_id}/`
   *
   * Alternate route: `/v3/universe/types/{type_id}/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `UniverseService.GetUniverseTypesTypeIdParams` containing the following parameters:
   *
   * - `type_id`: An Eve item type ID
   *
   * - `language`: Language to use in the response, takes precedence over Accept-Language
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * - `Accept-Language`: Language to use in the response
   *
   * @return Information about a type
   */
  getUniverseTypesTypeId(params: UniverseService.GetUniverseTypesTypeIdParams): __Observable<{capacity?: number, description: string, dogma_attributes?: Array<{attribute_id: number, value: number}>, dogma_effects?: Array<{effect_id: number, is_default: boolean}>, graphic_id?: number, group_id: number, icon_id?: number, market_group_id?: number, mass?: number, name: string, packaged_volume?: number, portion_size?: number, published: boolean, radius?: number, type_id: number, volume?: number}> {
    return this.getUniverseTypesTypeIdResponse(params).pipe(
      __map(_r => _r.body as {capacity?: number, description: string, dogma_attributes?: Array<{attribute_id: number, value: number}>, dogma_effects?: Array<{effect_id: number, is_default: boolean}>, graphic_id?: number, group_id: number, icon_id?: number, market_group_id?: number, mass?: number, name: string, packaged_volume?: number, portion_size?: number, published: boolean, radius?: number, type_id: number, volume?: number})
    );
  }
}

module UniverseService {

  /**
   * Parameters for getUniverseAncestries
   */
  export interface GetUniverseAncestriesParams {

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
   * Parameters for getUniverseAsteroidBeltsAsteroidBeltId
   */
  export interface GetUniverseAsteroidBeltsAsteroidBeltIdParams {

    /**
     * asteroid_belt_id integer
     */
    asteroidBeltId: number;

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
   * Parameters for getUniverseBloodlines
   */
  export interface GetUniverseBloodlinesParams {

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
   * Parameters for getUniverseCategories
   */
  export interface GetUniverseCategoriesParams {

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
   * Parameters for getUniverseCategoriesCategoryId
   */
  export interface GetUniverseCategoriesCategoryIdParams {

    /**
     * An Eve item category ID
     */
    categoryId: number;

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
   * Parameters for getUniverseConstellations
   */
  export interface GetUniverseConstellationsParams {

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
   * Parameters for getUniverseConstellationsConstellationId
   */
  export interface GetUniverseConstellationsConstellationIdParams {

    /**
     * constellation_id integer
     */
    constellationId: number;

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
   * Parameters for getUniverseFactions
   */
  export interface GetUniverseFactionsParams {

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
   * Parameters for getUniverseGraphics
   */
  export interface GetUniverseGraphicsParams {

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
   * Parameters for getUniverseGraphicsGraphicId
   */
  export interface GetUniverseGraphicsGraphicIdParams {

    /**
     * graphic_id integer
     */
    graphicId: number;

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
   * Parameters for getUniverseGroups
   */
  export interface GetUniverseGroupsParams {

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
   * Parameters for getUniverseGroupsGroupId
   */
  export interface GetUniverseGroupsGroupIdParams {

    /**
     * An Eve item group ID
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
   * Parameters for postUniverseIds
   */
  export interface PostUniverseIdsParams {

    /**
     * The names to resolve
     */
    names: Array<string>;

    /**
     * Language to use in the response, takes precedence over Accept-Language
     */
    language?: 'de' | 'en-us' | 'fr' | 'ja' | 'ru' | 'zh' | 'ko';

    /**
     * The server name you would like data from
     */
    datasource?: 'tranquility' | 'singularity';

    /**
     * Language to use in the response
     */
    AcceptLanguage?: 'de' | 'en-us' | 'fr' | 'ja' | 'ru' | 'zh' | 'ko';
  }

  /**
   * Parameters for getUniverseMoonsMoonId
   */
  export interface GetUniverseMoonsMoonIdParams {

    /**
     * moon_id integer
     */
    moonId: number;

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
   * Parameters for postUniverseNames
   */
  export interface PostUniverseNamesParams {

    /**
     * The ids to resolve
     */
    ids: Array<number>;

    /**
     * The server name you would like data from
     */
    datasource?: 'tranquility' | 'singularity';
  }

  /**
   * Parameters for getUniversePlanetsPlanetId
   */
  export interface GetUniversePlanetsPlanetIdParams {

    /**
     * planet_id integer
     */
    planetId: number;

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
   * Parameters for getUniverseRaces
   */
  export interface GetUniverseRacesParams {

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
   * Parameters for getUniverseRegions
   */
  export interface GetUniverseRegionsParams {

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
   * Parameters for getUniverseRegionsRegionId
   */
  export interface GetUniverseRegionsRegionIdParams {

    /**
     * region_id integer
     */
    regionId: number;

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
   * Parameters for getUniverseStargatesStargateId
   */
  export interface GetUniverseStargatesStargateIdParams {

    /**
     * stargate_id integer
     */
    stargateId: number;

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
   * Parameters for getUniverseStarsStarId
   */
  export interface GetUniverseStarsStarIdParams {

    /**
     * star_id integer
     */
    starId: number;

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
   * Parameters for getUniverseStationsStationId
   */
  export interface GetUniverseStationsStationIdParams {

    /**
     * station_id integer
     */
    stationId: number;

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
   * Parameters for getUniverseStructures
   */
  export interface GetUniverseStructuresParams {

    /**
     * Only list public structures that have this service online
     */
    filter?: 'market' | 'manufacturing_basic';

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
   * Parameters for getUniverseStructuresStructureId
   */
  export interface GetUniverseStructuresStructureIdParams {

    /**
     * An Eve structure ID
     */
    structureId: number;

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
   * Parameters for getUniverseSystemJumps
   */
  export interface GetUniverseSystemJumpsParams {

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
   * Parameters for getUniverseSystemKills
   */
  export interface GetUniverseSystemKillsParams {

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
   * Parameters for getUniverseSystems
   */
  export interface GetUniverseSystemsParams {

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
   * Parameters for getUniverseSystemsSystemId
   */
  export interface GetUniverseSystemsSystemIdParams {

    /**
     * system_id integer
     */
    systemId: number;

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
   * Parameters for getUniverseTypes
   */
  export interface GetUniverseTypesParams {

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
   * Parameters for getUniverseTypesTypeId
   */
  export interface GetUniverseTypesTypeIdParams {

    /**
     * An Eve item type ID
     */
    typeId: number;

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

export { UniverseService }
