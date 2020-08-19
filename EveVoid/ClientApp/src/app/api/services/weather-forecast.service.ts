/* tslint:disable */
import { Injectable } from '@angular/core';
import { HttpClient, HttpRequest, HttpResponse, HttpHeaders } from '@angular/common/http';
import { BaseService as __BaseService } from '../base-service';
import { ApiConfiguration as __Configuration } from '../api-configuration';
import { StrictHttpResponse as __StrictHttpResponse } from '../strict-http-response';
import { Observable as __Observable } from 'rxjs';
import { map as __map, filter as __filter } from 'rxjs/operators';

import { WeatherForecast } from '../models/weather-forecast';
@Injectable({
  providedIn: 'root',
})
class WeatherForecastService extends __BaseService {
  static readonly getWeatherForecastPath = '/WeatherForecast';

  constructor(
    config: __Configuration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * @return Success
   */
  getWeatherForecastResponse(): __Observable<__StrictHttpResponse<Array<WeatherForecast>>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/WeatherForecast`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<Array<WeatherForecast>>;
      })
    );
  }
  /**
   * @return Success
   */
  getWeatherForecast(): __Observable<Array<WeatherForecast>> {
    return this.getWeatherForecastResponse().pipe(
      __map(_r => _r.body as Array<WeatherForecast>)
    );
  }
}

module WeatherForecastService {
}

export { WeatherForecastService }
