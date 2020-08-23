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
class DogmaService extends __BaseService {
  static readonly getDogmaAttributesPath = '/dogma/attributes/';
  static readonly getDogmaAttributesAttributeIdPath = '/dogma/attributes/{attribute_id}/';
  static readonly getDogmaDynamicItemsTypeIdItemIdPath = '/dogma/dynamic/items/{type_id}/{item_id}/';
  static readonly getDogmaEffectsPath = '/dogma/effects/';
  static readonly getDogmaEffectsEffectIdPath = '/dogma/effects/{effect_id}/';

  constructor(
    config: __Configuration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * Get attributes
   *
   * Get a list of dogma attribute ids
   *
   * ---
   * Alternate route: `/dev/dogma/attributes/`
   *
   * Alternate route: `/legacy/dogma/attributes/`
   *
   * Alternate route: `/v1/dogma/attributes/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `DogmaService.GetDogmaAttributesParams` containing the following parameters:
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of dogma attribute ids
   */
  getDogmaAttributesResponse(params: DogmaService.GetDogmaAttributesParams): __Observable<__StrictHttpResponse<Array<number>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/dogma/attributes/`,
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
   * Get attributes
   *
   * Get a list of dogma attribute ids
   *
   * ---
   * Alternate route: `/dev/dogma/attributes/`
   *
   * Alternate route: `/legacy/dogma/attributes/`
   *
   * Alternate route: `/v1/dogma/attributes/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `DogmaService.GetDogmaAttributesParams` containing the following parameters:
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of dogma attribute ids
   */
  getDogmaAttributes(params: DogmaService.GetDogmaAttributesParams): __Observable<Array<number>> {
    return this.getDogmaAttributesResponse(params).pipe(
      __map(_r => _r.body as Array<number>)
    );
  }

  /**
   * Get attribute information
   *
   * Get information on a dogma attribute
   *
   * ---
   * Alternate route: `/dev/dogma/attributes/{attribute_id}/`
   *
   * Alternate route: `/legacy/dogma/attributes/{attribute_id}/`
   *
   * Alternate route: `/v1/dogma/attributes/{attribute_id}/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `DogmaService.GetDogmaAttributesAttributeIdParams` containing the following parameters:
   *
   * - `attribute_id`: A dogma attribute ID
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Information about a dogma attribute
   */
  getDogmaAttributesAttributeIdResponse(params: DogmaService.GetDogmaAttributesAttributeIdParams): __Observable<__StrictHttpResponse<{attribute_id: number, default_value?: number, description?: string, display_name?: string, high_is_good?: boolean, icon_id?: number, name?: string, published?: boolean, stackable?: boolean, unit_id?: number}>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/dogma/attributes/${encodeURIComponent(params.attributeId)}/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<{attribute_id: number, default_value?: number, description?: string, display_name?: string, high_is_good?: boolean, icon_id?: number, name?: string, published?: boolean, stackable?: boolean, unit_id?: number}>;
      })
    );
  }
  /**
   * Get attribute information
   *
   * Get information on a dogma attribute
   *
   * ---
   * Alternate route: `/dev/dogma/attributes/{attribute_id}/`
   *
   * Alternate route: `/legacy/dogma/attributes/{attribute_id}/`
   *
   * Alternate route: `/v1/dogma/attributes/{attribute_id}/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `DogmaService.GetDogmaAttributesAttributeIdParams` containing the following parameters:
   *
   * - `attribute_id`: A dogma attribute ID
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Information about a dogma attribute
   */
  getDogmaAttributesAttributeId(params: DogmaService.GetDogmaAttributesAttributeIdParams): __Observable<{attribute_id: number, default_value?: number, description?: string, display_name?: string, high_is_good?: boolean, icon_id?: number, name?: string, published?: boolean, stackable?: boolean, unit_id?: number}> {
    return this.getDogmaAttributesAttributeIdResponse(params).pipe(
      __map(_r => _r.body as {attribute_id: number, default_value?: number, description?: string, display_name?: string, high_is_good?: boolean, icon_id?: number, name?: string, published?: boolean, stackable?: boolean, unit_id?: number})
    );
  }

  /**
   * Get dynamic item information
   *
   * Returns info about a dynamic item resulting from mutation with a mutaplasmid.
   *
   * ---
   * Alternate route: `/dev/dogma/dynamic/items/{type_id}/{item_id}/`
   *
   * Alternate route: `/legacy/dogma/dynamic/items/{type_id}/{item_id}/`
   *
   * Alternate route: `/v1/dogma/dynamic/items/{type_id}/{item_id}/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `DogmaService.GetDogmaDynamicItemsTypeIdItemIdParams` containing the following parameters:
   *
   * - `type_id`: type_id integer
   *
   * - `item_id`: item_id integer
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Details about a dynamic item
   */
  getDogmaDynamicItemsTypeIdItemIdResponse(params: DogmaService.GetDogmaDynamicItemsTypeIdItemIdParams): __Observable<__StrictHttpResponse<{created_by: number, dogma_attributes: Array<{attribute_id: number, value: number}>, dogma_effects: Array<{effect_id: number, is_default: boolean}>, mutator_type_id: number, source_type_id: number}>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;


    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/dogma/dynamic/items/${encodeURIComponent(params.typeId)}/${encodeURIComponent(params.itemId)}/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<{created_by: number, dogma_attributes: Array<{attribute_id: number, value: number}>, dogma_effects: Array<{effect_id: number, is_default: boolean}>, mutator_type_id: number, source_type_id: number}>;
      })
    );
  }
  /**
   * Get dynamic item information
   *
   * Returns info about a dynamic item resulting from mutation with a mutaplasmid.
   *
   * ---
   * Alternate route: `/dev/dogma/dynamic/items/{type_id}/{item_id}/`
   *
   * Alternate route: `/legacy/dogma/dynamic/items/{type_id}/{item_id}/`
   *
   * Alternate route: `/v1/dogma/dynamic/items/{type_id}/{item_id}/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `DogmaService.GetDogmaDynamicItemsTypeIdItemIdParams` containing the following parameters:
   *
   * - `type_id`: type_id integer
   *
   * - `item_id`: item_id integer
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Details about a dynamic item
   */
  getDogmaDynamicItemsTypeIdItemId(params: DogmaService.GetDogmaDynamicItemsTypeIdItemIdParams): __Observable<{created_by: number, dogma_attributes: Array<{attribute_id: number, value: number}>, dogma_effects: Array<{effect_id: number, is_default: boolean}>, mutator_type_id: number, source_type_id: number}> {
    return this.getDogmaDynamicItemsTypeIdItemIdResponse(params).pipe(
      __map(_r => _r.body as {created_by: number, dogma_attributes: Array<{attribute_id: number, value: number}>, dogma_effects: Array<{effect_id: number, is_default: boolean}>, mutator_type_id: number, source_type_id: number})
    );
  }

  /**
   * Get effects
   *
   * Get a list of dogma effect ids
   *
   * ---
   * Alternate route: `/dev/dogma/effects/`
   *
   * Alternate route: `/legacy/dogma/effects/`
   *
   * Alternate route: `/v1/dogma/effects/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `DogmaService.GetDogmaEffectsParams` containing the following parameters:
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of dogma effect ids
   */
  getDogmaEffectsResponse(params: DogmaService.GetDogmaEffectsParams): __Observable<__StrictHttpResponse<Array<number>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/dogma/effects/`,
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
   * Get effects
   *
   * Get a list of dogma effect ids
   *
   * ---
   * Alternate route: `/dev/dogma/effects/`
   *
   * Alternate route: `/legacy/dogma/effects/`
   *
   * Alternate route: `/v1/dogma/effects/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `DogmaService.GetDogmaEffectsParams` containing the following parameters:
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return A list of dogma effect ids
   */
  getDogmaEffects(params: DogmaService.GetDogmaEffectsParams): __Observable<Array<number>> {
    return this.getDogmaEffectsResponse(params).pipe(
      __map(_r => _r.body as Array<number>)
    );
  }

  /**
   * Get effect information
   *
   * Get information on a dogma effect
   *
   * ---
   * Alternate route: `/dev/dogma/effects/{effect_id}/`
   *
   * Alternate route: `/v2/dogma/effects/{effect_id}/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `DogmaService.GetDogmaEffectsEffectIdParams` containing the following parameters:
   *
   * - `effect_id`: A dogma effect ID
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Information about a dogma effect
   */
  getDogmaEffectsEffectIdResponse(params: DogmaService.GetDogmaEffectsEffectIdParams): __Observable<__StrictHttpResponse<{description?: string, disallow_auto_repeat?: boolean, discharge_attribute_id?: number, display_name?: string, duration_attribute_id?: number, effect_category?: number, effect_id: number, electronic_chance?: boolean, falloff_attribute_id?: number, icon_id?: number, is_assistance?: boolean, is_offensive?: boolean, is_warp_safe?: boolean, modifiers?: Array<{domain?: string, effect_id?: number, func: string, modified_attribute_id?: number, modifying_attribute_id?: number, operator?: number}>, name?: string, post_expression?: number, pre_expression?: number, published?: boolean, range_attribute_id?: number, range_chance?: boolean, tracking_speed_attribute_id?: number}>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.datasource != null) __params = __params.set('datasource', params.datasource.toString());
    if (params.IfNoneMatch != null) __headers = __headers.set('If-None-Match', params.IfNoneMatch.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/dogma/effects/${encodeURIComponent(params.effectId)}/`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<{description?: string, disallow_auto_repeat?: boolean, discharge_attribute_id?: number, display_name?: string, duration_attribute_id?: number, effect_category?: number, effect_id: number, electronic_chance?: boolean, falloff_attribute_id?: number, icon_id?: number, is_assistance?: boolean, is_offensive?: boolean, is_warp_safe?: boolean, modifiers?: Array<{domain?: string, effect_id?: number, func: string, modified_attribute_id?: number, modifying_attribute_id?: number, operator?: number}>, name?: string, post_expression?: number, pre_expression?: number, published?: boolean, range_attribute_id?: number, range_chance?: boolean, tracking_speed_attribute_id?: number}>;
      })
    );
  }
  /**
   * Get effect information
   *
   * Get information on a dogma effect
   *
   * ---
   * Alternate route: `/dev/dogma/effects/{effect_id}/`
   *
   * Alternate route: `/v2/dogma/effects/{effect_id}/`
   *
   * ---
   * This route expires daily at 11:05
   * @param params The `DogmaService.GetDogmaEffectsEffectIdParams` containing the following parameters:
   *
   * - `effect_id`: A dogma effect ID
   *
   * - `datasource`: The server name you would like data from
   *
   * - `If-None-Match`: ETag from a previous request. A 304 will be returned if this matches the current ETag
   *
   * @return Information about a dogma effect
   */
  getDogmaEffectsEffectId(params: DogmaService.GetDogmaEffectsEffectIdParams): __Observable<{description?: string, disallow_auto_repeat?: boolean, discharge_attribute_id?: number, display_name?: string, duration_attribute_id?: number, effect_category?: number, effect_id: number, electronic_chance?: boolean, falloff_attribute_id?: number, icon_id?: number, is_assistance?: boolean, is_offensive?: boolean, is_warp_safe?: boolean, modifiers?: Array<{domain?: string, effect_id?: number, func: string, modified_attribute_id?: number, modifying_attribute_id?: number, operator?: number}>, name?: string, post_expression?: number, pre_expression?: number, published?: boolean, range_attribute_id?: number, range_chance?: boolean, tracking_speed_attribute_id?: number}> {
    return this.getDogmaEffectsEffectIdResponse(params).pipe(
      __map(_r => _r.body as {description?: string, disallow_auto_repeat?: boolean, discharge_attribute_id?: number, display_name?: string, duration_attribute_id?: number, effect_category?: number, effect_id: number, electronic_chance?: boolean, falloff_attribute_id?: number, icon_id?: number, is_assistance?: boolean, is_offensive?: boolean, is_warp_safe?: boolean, modifiers?: Array<{domain?: string, effect_id?: number, func: string, modified_attribute_id?: number, modifying_attribute_id?: number, operator?: number}>, name?: string, post_expression?: number, pre_expression?: number, published?: boolean, range_attribute_id?: number, range_chance?: boolean, tracking_speed_attribute_id?: number})
    );
  }
}

module DogmaService {

  /**
   * Parameters for getDogmaAttributes
   */
  export interface GetDogmaAttributesParams {

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
   * Parameters for getDogmaAttributesAttributeId
   */
  export interface GetDogmaAttributesAttributeIdParams {

    /**
     * A dogma attribute ID
     */
    attributeId: number;

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
   * Parameters for getDogmaDynamicItemsTypeIdItemId
   */
  export interface GetDogmaDynamicItemsTypeIdItemIdParams {

    /**
     * type_id integer
     */
    typeId: number;

    /**
     * item_id integer
     */
    itemId: number;

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
   * Parameters for getDogmaEffects
   */
  export interface GetDogmaEffectsParams {

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
   * Parameters for getDogmaEffectsEffectId
   */
  export interface GetDogmaEffectsEffectIdParams {

    /**
     * A dogma effect ID
     */
    effectId: number;

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

export { DogmaService }
