/* tslint:disable */
import { Injectable } from '@angular/core';

/**
 * Global configuration for Api services
 */
@Injectable({
  providedIn: 'root',
})
export class ApiConfiguration {
  rootUrl: string = 'https://esi.evetech.net/latest';
}

export interface ApiConfigurationInterface {
  rootUrl?: string;
}
