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
class IndustryService extends __BaseService {
  static readonly getCharactersCharacterIdIndustryJobsPath = '/characters/{character_id}/industry/jobs/';
  static readonly getCharactersCharacterIdMiningPath = '/characters/{character_id}/mining/';
  static readonly getCorporationCorporationIdMiningExtractionsPath = '/corporation/{corporation_id}/mining/extractions/';
  static readonly getCorporationCorporationIdMiningObserversPath = '/corporation/{corporation_id}/mining/observers/';
  static readonly getCorporationCorporationIdMiningObserversObserverIdPath = '/corporation/{corporation_id}/mining/observers/{observer_id}/';
  static readonly getCorporationsCorporationIdIndustryJobsPath = '/corporations/{corporation_id}/industry/jobs/';
  static readonly getIndustryFacilitiesPath = '/industry/facilities/';
  static readonly getIndustrySystemsPath = '/industry/systems/';

  constructor(
    config: __Configuration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * List character industry jobs
   *
   * List industry jobs placed by a character
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/industry/jobs/`
   *
   * Alternate route: `/legacy/characters/{character_id}/industry/jobs/`
   *
   * Alternate route: `/v1/characters/{character_id}/industry/jobs/`
   *
   * ---
   * This route is cached for up to 300 seconds
   * @param params The `IndustryService.GetCharactersCharacterIdIndustryJobsParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `include_completed`: Whether to retrieve completed character industry jobs. Only includes jobs from the past 90 days
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Industry jobs placed by a character
   */
  getCharactersCharacterIdIndustryJobsResponse(params: IndustryService.GetCharactersCharacterIdIndustryJobsParams): __Observable<__StrictHttpResponse<Array<{activity_id: number, blueprint_id: number, blueprint_location_id: number, blueprint_type_id: number, completed_character_id?: number, completed_date?: string, cost?: number, duration: number, end_date: string, facility_id: number, installer_id: number, job_id: number, licensed_runs?: number, output_location_id: number, pause_date?: string, probability?: number, product_type_id?: number, runs: number, start_date: string, station_id: number, status: 'active' | 'cancelled' | 'delivered' | 'paused' | 'ready' | 'reverted', successful_runs?: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.includeCompleted != null) __params = __params.set('include_completed', params.includeCompleted.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/industry/jobs/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{activity_id: number, blueprint_id: number, blueprint_location_id: number, blueprint_type_id: number, completed_character_id?: number, completed_date?: string, cost?: number, duration: number, end_date: string, facility_id: number, installer_id: number, job_id: number, licensed_runs?: number, output_location_id: number, pause_date?: string, probability?: number, product_type_id?: number, runs: number, start_date: string, station_id: number, status: 'active' | 'cancelled' | 'delivered' | 'paused' | 'ready' | 'reverted', successful_runs?: number}>>;
      })
    );
  }
  /**
   * List character industry jobs
   *
   * List industry jobs placed by a character
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/industry/jobs/`
   *
   * Alternate route: `/legacy/characters/{character_id}/industry/jobs/`
   *
   * Alternate route: `/v1/characters/{character_id}/industry/jobs/`
   *
   * ---
   * This route is cached for up to 300 seconds
   * @param params The `IndustryService.GetCharactersCharacterIdIndustryJobsParams` containing the following parameters:
   *
   * - `character_id`: An EVE character ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `include_completed`: Whether to retrieve completed character industry jobs. Only includes jobs from the past 90 days
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Industry jobs placed by a character
   */
  getCharactersCharacterIdIndustryJobs(params: IndustryService.GetCharactersCharacterIdIndustryJobsParams): __Observable<Array<{activity_id: number, blueprint_id: number, blueprint_location_id: number, blueprint_type_id: number, completed_character_id?: number, completed_date?: string, cost?: number, duration: number, end_date: string, facility_id: number, installer_id: number, job_id: number, licensed_runs?: number, output_location_id: number, pause_date?: string, probability?: number, product_type_id?: number, runs: number, start_date: string, station_id: number, status: 'active' | 'cancelled' | 'delivered' | 'paused' | 'ready' | 'reverted', successful_runs?: number}>> {
    return this.getCharactersCharacterIdIndustryJobsResponse(params).pipe(
      __map(_r => _r.body as Array<{activity_id: number, blueprint_id: number, blueprint_location_id: number, blueprint_type_id: number, completed_character_id?: number, completed_date?: string, cost?: number, duration: number, end_date: string, facility_id: number, installer_id: number, job_id: number, licensed_runs?: number, output_location_id: number, pause_date?: string, probability?: number, product_type_id?: number, runs: number, start_date: string, station_id: number, status: 'active' | 'cancelled' | 'delivered' | 'paused' | 'ready' | 'reverted', successful_runs?: number}>)
    );
  }

  /**
   * Character mining ledger
   *
   * Paginated record of all mining done by a character for the past 30 days
   *
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/mining/`
   *
   * Alternate route: `/legacy/characters/{character_id}/mining/`
   *
   * Alternate route: `/v1/characters/{character_id}/mining/`
   *
   * ---
   * This route is cached for up to 600 seconds
   * @param params The `IndustryService.GetCharactersCharacterIdMiningParams` containing the following parameters:
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
   * @return Mining ledger of a character
   */
  getCharactersCharacterIdMiningResponse(params: IndustryService.GetCharactersCharacterIdMiningParams): __Observable<__StrictHttpResponse<Array<{date: string, quantity: number, solar_system_id: number, type_id: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.page != null) __params = __params.set('page', params.page.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/characters/${encodeURIComponent(params.characterId)}/mining/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{date: string, quantity: number, solar_system_id: number, type_id: number}>>;
      })
    );
  }
  /**
   * Character mining ledger
   *
   * Paginated record of all mining done by a character for the past 30 days
   *
   *
   * ---
   * Alternate route: `/dev/characters/{character_id}/mining/`
   *
   * Alternate route: `/legacy/characters/{character_id}/mining/`
   *
   * Alternate route: `/v1/characters/{character_id}/mining/`
   *
   * ---
   * This route is cached for up to 600 seconds
   * @param params The `IndustryService.GetCharactersCharacterIdMiningParams` containing the following parameters:
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
   * @return Mining ledger of a character
   */
  getCharactersCharacterIdMining(params: IndustryService.GetCharactersCharacterIdMiningParams): __Observable<Array<{date: string, quantity: number, solar_system_id: number, type_id: number}>> {
    return this.getCharactersCharacterIdMiningResponse(params).pipe(
      __map(_r => _r.body as Array<{date: string, quantity: number, solar_system_id: number, type_id: number}>)
    );
  }

  /**
   * Moon extraction timers
   *
   * Extraction timers for all moon chunks being extracted by refineries belonging to a corporation.
   *
   *
   * ---
   * Alternate route: `/dev/corporation/{corporation_id}/mining/extractions/`
   *
   * Alternate route: `/legacy/corporation/{corporation_id}/mining/extractions/`
   *
   * Alternate route: `/v1/corporation/{corporation_id}/mining/extractions/`
   *
   * ---
   * This route is cached for up to 1800 seconds
   *
   * ---
   * Requires one of the following EVE corporation role(s): Station_Manager
   * @param params The `IndustryService.GetCorporationCorporationIdMiningExtractionsParams` containing the following parameters:
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
   * @return A list of chunk timers
   */
  getCorporationCorporationIdMiningExtractionsResponse(params: IndustryService.GetCorporationCorporationIdMiningExtractionsParams): __Observable<__StrictHttpResponse<Array<{chunk_arrival_time: string, extraction_start_time: string, moon_id: number, natural_decay_time: string, structure_id: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.page != null) __params = __params.set('page', params.page.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/corporation/${encodeURIComponent(params.corporationId)}/mining/extractions/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{chunk_arrival_time: string, extraction_start_time: string, moon_id: number, natural_decay_time: string, structure_id: number}>>;
      })
    );
  }
  /**
   * Moon extraction timers
   *
   * Extraction timers for all moon chunks being extracted by refineries belonging to a corporation.
   *
   *
   * ---
   * Alternate route: `/dev/corporation/{corporation_id}/mining/extractions/`
   *
   * Alternate route: `/legacy/corporation/{corporation_id}/mining/extractions/`
   *
   * Alternate route: `/v1/corporation/{corporation_id}/mining/extractions/`
   *
   * ---
   * This route is cached for up to 1800 seconds
   *
   * ---
   * Requires one of the following EVE corporation role(s): Station_Manager
   * @param params The `IndustryService.GetCorporationCorporationIdMiningExtractionsParams` containing the following parameters:
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
   * @return A list of chunk timers
   */
  getCorporationCorporationIdMiningExtractions(params: IndustryService.GetCorporationCorporationIdMiningExtractionsParams): __Observable<Array<{chunk_arrival_time: string, extraction_start_time: string, moon_id: number, natural_decay_time: string, structure_id: number}>> {
    return this.getCorporationCorporationIdMiningExtractionsResponse(params).pipe(
      __map(_r => _r.body as Array<{chunk_arrival_time: string, extraction_start_time: string, moon_id: number, natural_decay_time: string, structure_id: number}>)
    );
  }

  /**
   * Corporation mining observers
   *
   * Paginated list of all entities capable of observing and recording mining for a corporation
   *
   *
   * ---
   * Alternate route: `/dev/corporation/{corporation_id}/mining/observers/`
   *
   * Alternate route: `/legacy/corporation/{corporation_id}/mining/observers/`
   *
   * Alternate route: `/v1/corporation/{corporation_id}/mining/observers/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   *
   * ---
   * Requires one of the following EVE corporation role(s): Accountant
   * @param params The `IndustryService.GetCorporationCorporationIdMiningObserversParams` containing the following parameters:
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
   * @return Observer list of a corporation
   */
  getCorporationCorporationIdMiningObserversResponse(params: IndustryService.GetCorporationCorporationIdMiningObserversParams): __Observable<__StrictHttpResponse<Array<{last_updated: string, observer_id: number, observer_type: 'structure'}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.page != null) __params = __params.set('page', params.page.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/corporation/${encodeURIComponent(params.corporationId)}/mining/observers/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{last_updated: string, observer_id: number, observer_type: 'structure'}>>;
      })
    );
  }
  /**
   * Corporation mining observers
   *
   * Paginated list of all entities capable of observing and recording mining for a corporation
   *
   *
   * ---
   * Alternate route: `/dev/corporation/{corporation_id}/mining/observers/`
   *
   * Alternate route: `/legacy/corporation/{corporation_id}/mining/observers/`
   *
   * Alternate route: `/v1/corporation/{corporation_id}/mining/observers/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   *
   * ---
   * Requires one of the following EVE corporation role(s): Accountant
   * @param params The `IndustryService.GetCorporationCorporationIdMiningObserversParams` containing the following parameters:
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
   * @return Observer list of a corporation
   */
  getCorporationCorporationIdMiningObservers(params: IndustryService.GetCorporationCorporationIdMiningObserversParams): __Observable<Array<{last_updated: string, observer_id: number, observer_type: 'structure'}>> {
    return this.getCorporationCorporationIdMiningObserversResponse(params).pipe(
      __map(_r => _r.body as Array<{last_updated: string, observer_id: number, observer_type: 'structure'}>)
    );
  }

  /**
   * Observed corporation mining
   *
   * Paginated record of all mining seen by an observer
   *
   *
   * ---
   * Alternate route: `/dev/corporation/{corporation_id}/mining/observers/{observer_id}/`
   *
   * Alternate route: `/legacy/corporation/{corporation_id}/mining/observers/{observer_id}/`
   *
   * Alternate route: `/v1/corporation/{corporation_id}/mining/observers/{observer_id}/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   *
   * ---
   * Requires one of the following EVE corporation role(s): Accountant
   * @param params The `IndustryService.GetCorporationCorporationIdMiningObserversObserverIdParams` containing the following parameters:
   *
   * - `observer_id`: A mining observer id
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
   * @return Mining ledger of an observer
   */
  getCorporationCorporationIdMiningObserversObserverIdResponse(params: IndustryService.GetCorporationCorporationIdMiningObserversObserverIdParams): __Observable<__StrictHttpResponse<Array<{character_id: number, last_updated: string, quantity: number, recorded_corporation_id: number, type_id: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;


    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.page != null) __params = __params.set('page', params.page.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/corporation/${encodeURIComponent(params.corporationId)}/mining/observers/${encodeURIComponent(params.observerId)}/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{character_id: number, last_updated: string, quantity: number, recorded_corporation_id: number, type_id: number}>>;
      })
    );
  }
  /**
   * Observed corporation mining
   *
   * Paginated record of all mining seen by an observer
   *
   *
   * ---
   * Alternate route: `/dev/corporation/{corporation_id}/mining/observers/{observer_id}/`
   *
   * Alternate route: `/legacy/corporation/{corporation_id}/mining/observers/{observer_id}/`
   *
   * Alternate route: `/v1/corporation/{corporation_id}/mining/observers/{observer_id}/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   *
   * ---
   * Requires one of the following EVE corporation role(s): Accountant
   * @param params The `IndustryService.GetCorporationCorporationIdMiningObserversObserverIdParams` containing the following parameters:
   *
   * - `observer_id`: A mining observer id
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
   * @return Mining ledger of an observer
   */
  getCorporationCorporationIdMiningObserversObserverId(params: IndustryService.GetCorporationCorporationIdMiningObserversObserverIdParams): __Observable<Array<{character_id: number, last_updated: string, quantity: number, recorded_corporation_id: number, type_id: number}>> {
    return this.getCorporationCorporationIdMiningObserversObserverIdResponse(params).pipe(
      __map(_r => _r.body as Array<{character_id: number, last_updated: string, quantity: number, recorded_corporation_id: number, type_id: number}>)
    );
  }

  /**
   * List corporation industry jobs
   *
   * List industry jobs run by a corporation
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/industry/jobs/`
   *
   * Alternate route: `/legacy/corporations/{corporation_id}/industry/jobs/`
   *
   * Alternate route: `/v1/corporations/{corporation_id}/industry/jobs/`
   *
   * ---
   * This route is cached for up to 300 seconds
   *
   * ---
   * Requires one of the following EVE corporation role(s): Factory_Manager
   * @param params The `IndustryService.GetCorporationsCorporationIdIndustryJobsParams` containing the following parameters:
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `page`: Which page of results to return
   *
   * - `include_completed`: Whether to retrieve completed corporation industry jobs. Only includes jobs from the past 90 days
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of corporation industry jobs
   */
  getCorporationsCorporationIdIndustryJobsResponse(params: IndustryService.GetCorporationsCorporationIdIndustryJobsParams): __Observable<__StrictHttpResponse<Array<{activity_id: number, blueprint_id: number, blueprint_location_id: number, blueprint_type_id: number, completed_character_id?: number, completed_date?: string, cost?: number, duration: number, end_date: string, facility_id: number, installer_id: number, job_id: number, licensed_runs?: number, location_id: number, output_location_id: number, pause_date?: string, probability?: number, product_type_id?: number, runs: number, start_date: string, status: 'active' | 'cancelled' | 'delivered' | 'paused' | 'ready' | 'reverted', successful_runs?: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.token != null) __params = __params.set('token', params.token.toString());
    if (params.page != null) __params = __params.set('page', params.page.toString());
    if (params.includeCompleted != null) __params = __params.set('include_completed', params.includeCompleted.toString());
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/corporations/${encodeURIComponent(params.corporationId)}/industry/jobs/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{activity_id: number, blueprint_id: number, blueprint_location_id: number, blueprint_type_id: number, completed_character_id?: number, completed_date?: string, cost?: number, duration: number, end_date: string, facility_id: number, installer_id: number, job_id: number, licensed_runs?: number, location_id: number, output_location_id: number, pause_date?: string, probability?: number, product_type_id?: number, runs: number, start_date: string, status: 'active' | 'cancelled' | 'delivered' | 'paused' | 'ready' | 'reverted', successful_runs?: number}>>;
      })
    );
  }
  /**
   * List corporation industry jobs
   *
   * List industry jobs run by a corporation
   *
   * ---
   * Alternate route: `/dev/corporations/{corporation_id}/industry/jobs/`
   *
   * Alternate route: `/legacy/corporations/{corporation_id}/industry/jobs/`
   *
   * Alternate route: `/v1/corporations/{corporation_id}/industry/jobs/`
   *
   * ---
   * This route is cached for up to 300 seconds
   *
   * ---
   * Requires one of the following EVE corporation role(s): Factory_Manager
   * @param params The `IndustryService.GetCorporationsCorporationIdIndustryJobsParams` containing the following parameters:
   *
   * - `corporation_id`: An EVE corporation ID
   *
   * - `token`: Access token to use if unable to set a header
   *
   * - `page`: Which page of results to return
   *
   * - `include_completed`: Whether to retrieve completed corporation industry jobs. Only includes jobs from the past 90 days
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of corporation industry jobs
   */
  getCorporationsCorporationIdIndustryJobs(params: IndustryService.GetCorporationsCorporationIdIndustryJobsParams): __Observable<Array<{activity_id: number, blueprint_id: number, blueprint_location_id: number, blueprint_type_id: number, completed_character_id?: number, completed_date?: string, cost?: number, duration: number, end_date: string, facility_id: number, installer_id: number, job_id: number, licensed_runs?: number, location_id: number, output_location_id: number, pause_date?: string, probability?: number, product_type_id?: number, runs: number, start_date: string, status: 'active' | 'cancelled' | 'delivered' | 'paused' | 'ready' | 'reverted', successful_runs?: number}>> {
    return this.getCorporationsCorporationIdIndustryJobsResponse(params).pipe(
      __map(_r => _r.body as Array<{activity_id: number, blueprint_id: number, blueprint_location_id: number, blueprint_type_id: number, completed_character_id?: number, completed_date?: string, cost?: number, duration: number, end_date: string, facility_id: number, installer_id: number, job_id: number, licensed_runs?: number, location_id: number, output_location_id: number, pause_date?: string, probability?: number, product_type_id?: number, runs: number, start_date: string, status: 'active' | 'cancelled' | 'delivered' | 'paused' | 'ready' | 'reverted', successful_runs?: number}>)
    );
  }

  /**
   * List industry facilities
   *
   * Return a list of industry facilities
   *
   * ---
   * Alternate route: `/dev/industry/facilities/`
   *
   * Alternate route: `/legacy/industry/facilities/`
   *
   * Alternate route: `/v1/industry/facilities/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `IndustryService.GetIndustryFacilitiesParams` containing the following parameters:
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of facilities
   */
  getIndustryFacilitiesResponse(params: IndustryService.GetIndustryFacilitiesParams): __Observable<__StrictHttpResponse<Array<{facility_id: number, owner_id: number, region_id: number, solar_system_id: number, tax?: number, type_id: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/industry/facilities/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{facility_id: number, owner_id: number, region_id: number, solar_system_id: number, tax?: number, type_id: number}>>;
      })
    );
  }
  /**
   * List industry facilities
   *
   * Return a list of industry facilities
   *
   * ---
   * Alternate route: `/dev/industry/facilities/`
   *
   * Alternate route: `/legacy/industry/facilities/`
   *
   * Alternate route: `/v1/industry/facilities/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `IndustryService.GetIndustryFacilitiesParams` containing the following parameters:
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of facilities
   */
  getIndustryFacilities(params: IndustryService.GetIndustryFacilitiesParams): __Observable<Array<{facility_id: number, owner_id: number, region_id: number, solar_system_id: number, tax?: number, type_id: number}>> {
    return this.getIndustryFacilitiesResponse(params).pipe(
      __map(_r => _r.body as Array<{facility_id: number, owner_id: number, region_id: number, solar_system_id: number, tax?: number, type_id: number}>)
    );
  }

  /**
   * List solar system cost indices
   *
   * Return cost indices for solar systems
   *
   * ---
   * Alternate route: `/dev/industry/systems/`
   *
   * Alternate route: `/legacy/industry/systems/`
   *
   * Alternate route: `/v1/industry/systems/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `IndustryService.GetIndustrySystemsParams` containing the following parameters:
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of cost indicies
   */
  getIndustrySystemsResponse(params: IndustryService.GetIndustrySystemsParams): __Observable<__StrictHttpResponse<Array<{cost_indices: Array<{activity: 'copying' | 'duplicating' | 'invention' | 'manufacturing' | 'none' | 'reaction' | 'researching_material_efficiency' | 'researching_technology' | 'researching_time_efficiency' | 'reverse_engineering', cost_index: number}>, solar_system_id: number}>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/industry/systems/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<{cost_indices: Array<{activity: 'copying' | 'duplicating' | 'invention' | 'manufacturing' | 'none' | 'reaction' | 'researching_material_efficiency' | 'researching_technology' | 'researching_time_efficiency' | 'reverse_engineering', cost_index: number}>, solar_system_id: number}>>;
      })
    );
  }
  /**
   * List solar system cost indices
   *
   * Return cost indices for solar systems
   *
   * ---
   * Alternate route: `/dev/industry/systems/`
   *
   * Alternate route: `/legacy/industry/systems/`
   *
   * Alternate route: `/v1/industry/systems/`
   *
   * ---
   * This route is cached for up to 3600 seconds
   * @param params The `IndustryService.GetIndustrySystemsParams` containing the following parameters:
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of cost indicies
   */
  getIndustrySystems(params: IndustryService.GetIndustrySystemsParams): __Observable<Array<{cost_indices: Array<{activity: 'copying' | 'duplicating' | 'invention' | 'manufacturing' | 'none' | 'reaction' | 'researching_material_efficiency' | 'researching_technology' | 'researching_time_efficiency' | 'reverse_engineering', cost_index: number}>, solar_system_id: number}>> {
    return this.getIndustrySystemsResponse(params).pipe(
      __map(_r => _r.body as Array<{cost_indices: Array<{activity: 'copying' | 'duplicating' | 'invention' | 'manufacturing' | 'none' | 'reaction' | 'researching_material_efficiency' | 'researching_technology' | 'researching_time_efficiency' | 'reverse_engineering', cost_index: number}>, solar_system_id: number}>)
    );
  }
}

module IndustryService {

  /**
   * Parameters for getCharactersCharacterIdIndustryJobs
   */
  export interface GetCharactersCharacterIdIndustryJobsParams {

    /**
     * An EVE character ID
     */
    characterId: number;

    /**
     * Access token to use if unable to set a header
     */
    token?: string;

    /**
     * Whether to retrieve completed character industry jobs. Only includes jobs from the past 90 days
     */
    includeCompleted?: boolean;

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
   * Parameters for getCharactersCharacterIdMining
   */
  export interface GetCharactersCharacterIdMiningParams {

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
   * Parameters for getCorporationCorporationIdMiningExtractions
   */
  export interface GetCorporationCorporationIdMiningExtractionsParams {

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
   * Parameters for getCorporationCorporationIdMiningObservers
   */
  export interface GetCorporationCorporationIdMiningObserversParams {

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
   * Parameters for getCorporationCorporationIdMiningObserversObserverId
   */
  export interface GetCorporationCorporationIdMiningObserversObserverIdParams {

    /**
     * A mining observer id
     */
    observerId: number;

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
   * Parameters for getCorporationsCorporationIdIndustryJobs
   */
  export interface GetCorporationsCorporationIdIndustryJobsParams {

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
     * Whether to retrieve completed corporation industry jobs. Only includes jobs from the past 90 days
     */
    includeCompleted?: boolean;

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
   * Parameters for getIndustryFacilities
   */
  export interface GetIndustryFacilitiesParams {

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
   * Parameters for getIndustrySystems
   */
  export interface GetIndustrySystemsParams {

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

export { IndustryService }
