/* tslint:disable */
import { Injectable } from '@angular/core';
import { HttpClient, HttpRequest, HttpResponse, HttpHeaders } from '@angular/common/http';
import { BaseService as __BaseService } from '../base-service';
import { ApiConfiguration as __Configuration } from '../api-configuration';
import { StrictHttpResponse as __StrictHttpResponse } from '../strict-http-response';
import { Observable as __Observable } from 'rxjs';
import { map as __map, filter as __filter } from 'rxjs/operators';

import { MainCharacterDto } from '../models/main-character-dto';
import { EsiCharacterDto } from '../models/esi-character-dto';
import { MapLayoutDto } from '../models/map-layout-dto';
@Injectable({
  providedIn: 'root',
})
class CharacterService extends __BaseService {
  static readonly getApiCharacterGetMainCharacterPath = '/api/Character/GetMainCharacter';
  static readonly postApiCharacterGetEsiCharacterPath = '/api/Character/GetEsiCharacter';
  static readonly postApiCharacterUpdateEsiCharacterPath = '/api/Character/UpdateEsiCharacter';
  static readonly postApiCharacterUpdateMaskTypePath = '/api/Character/UpdateMaskType';
  static readonly postApiCharacterUpdateFavoriteSystemPath = '/api/Character/UpdateFavoriteSystem';
  static readonly postApiCharacterUpdateMapLayoutsPath = '/api/Character/UpdateMapLayouts';

  constructor(
    config: __Configuration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * @param token undefined
   * @return Success
   */
  getApiCharacterGetMainCharacterResponse(token?: string): __Observable<__StrictHttpResponse<MainCharacterDto>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (token != null) __params = __params.set('token', token.toString());
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/api/Character/GetMainCharacter`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<MainCharacterDto>;
      })
    );
  }
  /**
   * @param token undefined
   * @return Success
   */
  getApiCharacterGetMainCharacter(token?: string): __Observable<MainCharacterDto> {
    return this.getApiCharacterGetMainCharacterResponse(token).pipe(
      __map(_r => _r.body as MainCharacterDto)
    );
  }

  /**
   * @param params The `CharacterService.PostApiCharacterGetEsiCharacterParams` containing the following parameters:
   *
   * - `mainToken`:
   *
   * - `esiCharId`:
   *
   * @return Success
   */
  postApiCharacterGetEsiCharacterResponse(params: CharacterService.PostApiCharacterGetEsiCharacterParams): __Observable<__StrictHttpResponse<EsiCharacterDto>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.mainToken != null) __params = __params.set('mainToken', params.mainToken.toString());
    if (params.esiCharId != null) __params = __params.set('esiCharId', params.esiCharId.toString());
    let req = new HttpRequest<any>(
      'POST',
      this.rootUrl + `/api/Character/GetEsiCharacter`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<EsiCharacterDto>;
      })
    );
  }
  /**
   * @param params The `CharacterService.PostApiCharacterGetEsiCharacterParams` containing the following parameters:
   *
   * - `mainToken`:
   *
   * - `esiCharId`:
   *
   * @return Success
   */
  postApiCharacterGetEsiCharacter(params: CharacterService.PostApiCharacterGetEsiCharacterParams): __Observable<EsiCharacterDto> {
    return this.postApiCharacterGetEsiCharacterResponse(params).pipe(
      __map(_r => _r.body as EsiCharacterDto)
    );
  }

  /**
   * @param params The `CharacterService.PostApiCharacterUpdateEsiCharacterParams` containing the following parameters:
   *
   * - `sigId`:
   *
   * - `mainToken`:
   *
   * - `body`:
   *
   * @return Success
   */
  postApiCharacterUpdateEsiCharacterResponse(params: CharacterService.PostApiCharacterUpdateEsiCharacterParams): __Observable<__StrictHttpResponse<EsiCharacterDto>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.sigId != null) __params = __params.set('sigId', params.sigId.toString());
    if (params.mainToken != null) __params = __params.set('mainToken', params.mainToken.toString());
    __body = params.body;
    let req = new HttpRequest<any>(
      'POST',
      this.rootUrl + `/api/Character/UpdateEsiCharacter`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<EsiCharacterDto>;
      })
    );
  }
  /**
   * @param params The `CharacterService.PostApiCharacterUpdateEsiCharacterParams` containing the following parameters:
   *
   * - `sigId`:
   *
   * - `mainToken`:
   *
   * - `body`:
   *
   * @return Success
   */
  postApiCharacterUpdateEsiCharacter(params: CharacterService.PostApiCharacterUpdateEsiCharacterParams): __Observable<EsiCharacterDto> {
    return this.postApiCharacterUpdateEsiCharacterResponse(params).pipe(
      __map(_r => _r.body as EsiCharacterDto)
    );
  }

  /**
   * @param params The `CharacterService.PostApiCharacterUpdateMaskTypeParams` containing the following parameters:
   *
   * - `maskType`:
   *
   * - `mainToken`:
   */
  postApiCharacterUpdateMaskTypeResponse(params: CharacterService.PostApiCharacterUpdateMaskTypeParams): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.maskType != null) __params = __params.set('maskType', params.maskType.toString());
    if (params.mainToken != null) __params = __params.set('mainToken', params.mainToken.toString());
    let req = new HttpRequest<any>(
      'POST',
      this.rootUrl + `/api/Character/UpdateMaskType`,
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
   * @param params The `CharacterService.PostApiCharacterUpdateMaskTypeParams` containing the following parameters:
   *
   * - `maskType`:
   *
   * - `mainToken`:
   */
  postApiCharacterUpdateMaskType(params: CharacterService.PostApiCharacterUpdateMaskTypeParams): __Observable<null> {
    return this.postApiCharacterUpdateMaskTypeResponse(params).pipe(
      __map(_r => _r.body as null)
    );
  }

  /**
   * @param params The `CharacterService.PostApiCharacterUpdateFavoriteSystemParams` containing the following parameters:
   *
   * - `systemId`:
   *
   * - `mainToken`:
   *
   * - `favorite`:
   */
  postApiCharacterUpdateFavoriteSystemResponse(params: CharacterService.PostApiCharacterUpdateFavoriteSystemParams): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.systemId != null) __params = __params.set('systemId', params.systemId.toString());
    if (params.mainToken != null) __params = __params.set('mainToken', params.mainToken.toString());
    if (params.favorite != null) __params = __params.set('favorite', params.favorite.toString());
    let req = new HttpRequest<any>(
      'POST',
      this.rootUrl + `/api/Character/UpdateFavoriteSystem`,
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
   * @param params The `CharacterService.PostApiCharacterUpdateFavoriteSystemParams` containing the following parameters:
   *
   * - `systemId`:
   *
   * - `mainToken`:
   *
   * - `favorite`:
   */
  postApiCharacterUpdateFavoriteSystem(params: CharacterService.PostApiCharacterUpdateFavoriteSystemParams): __Observable<null> {
    return this.postApiCharacterUpdateFavoriteSystemResponse(params).pipe(
      __map(_r => _r.body as null)
    );
  }

  /**
   * @param params The `CharacterService.PostApiCharacterUpdateMapLayoutsParams` containing the following parameters:
   *
   * - `mainToken`:
   *
   * - `body`:
   *
   * @return Success
   */
  postApiCharacterUpdateMapLayoutsResponse(params: CharacterService.PostApiCharacterUpdateMapLayoutsParams): __Observable<__StrictHttpResponse<Array<MapLayoutDto>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    if (params.mainToken != null) __params = __params.set('mainToken', params.mainToken.toString());
    __body = params.body;
    let req = new HttpRequest<any>(
      'POST',
      this.rootUrl + `/api/Character/UpdateMapLayouts`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<MapLayoutDto>>;
      })
    );
  }
  /**
   * @param params The `CharacterService.PostApiCharacterUpdateMapLayoutsParams` containing the following parameters:
   *
   * - `mainToken`:
   *
   * - `body`:
   *
   * @return Success
   */
  postApiCharacterUpdateMapLayouts(params: CharacterService.PostApiCharacterUpdateMapLayoutsParams): __Observable<Array<MapLayoutDto>> {
    return this.postApiCharacterUpdateMapLayoutsResponse(params).pipe(
      __map(_r => _r.body as Array<MapLayoutDto>)
    );
  }
}

module CharacterService {

  /**
   * Parameters for postApiCharacterGetEsiCharacter
   */
  export interface PostApiCharacterGetEsiCharacterParams {
    mainToken?: string;
    esiCharId?: number;
  }

  /**
   * Parameters for postApiCharacterUpdateEsiCharacter
   */
  export interface PostApiCharacterUpdateEsiCharacterParams {
    sigId?: number;
    mainToken?: string;
    body?: EsiCharacterDto;
  }

  /**
   * Parameters for postApiCharacterUpdateMaskType
   */
  export interface PostApiCharacterUpdateMaskTypeParams {
    maskType?: any;
    mainToken?: string;
  }

  /**
   * Parameters for postApiCharacterUpdateFavoriteSystem
   */
  export interface PostApiCharacterUpdateFavoriteSystemParams {
    systemId?: number;
    mainToken?: string;
    favorite?: boolean;
  }

  /**
   * Parameters for postApiCharacterUpdateMapLayouts
   */
  export interface PostApiCharacterUpdateMapLayoutsParams {
    mainToken?: string;
    body?: Array<MapLayoutDto>;
  }
}

export { CharacterService }
