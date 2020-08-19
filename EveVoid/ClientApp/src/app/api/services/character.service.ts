/* tslint:disable */
import { Injectable } from '@angular/core';
import { HttpClient, HttpRequest, HttpResponse, HttpHeaders } from '@angular/common/http';
import { BaseService as __BaseService } from '../base-service';
import { ApiConfiguration as __Configuration } from '../api-configuration';
import { StrictHttpResponse as __StrictHttpResponse } from '../strict-http-response';
import { Observable as __Observable } from 'rxjs';
import { map as __map, filter as __filter } from 'rxjs/operators';

import { MainCharacterDto } from '../models/main-character-dto';
@Injectable({
  providedIn: 'root',
})
class CharacterService extends __BaseService {
  static readonly getApiCharacterGetMainCharacterPath = '/api/Character/GetMainCharacter';

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
}

module CharacterService {
}

export { CharacterService }
