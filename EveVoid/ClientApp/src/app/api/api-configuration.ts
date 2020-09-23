import { environment } from './../../environments/environment';
/* tslint:disable */
import { Injectable } from '@angular/core';

/**
 * Global configuration for Api services
 */
@Injectable({
  providedIn: 'root',
})
export class ApiConfiguration {
  rootUrl: string = environment.api_url;
}

export interface ApiConfigurationInterface {
  rootUrl?: string;
}
