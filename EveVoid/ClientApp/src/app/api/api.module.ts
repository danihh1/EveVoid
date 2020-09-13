/* tslint:disable */
import { NgModule, ModuleWithProviders } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { ApiConfiguration, ApiConfigurationInterface } from './api-configuration';

import { AppDataService } from './services/app-data.service';
import { CharacterService } from './services/character.service';
import { MapService } from './services/map.service';
import { SignatureService } from './services/signature.service';
import { SolarSystemStructureService } from './services/solar-system-structure.service';
import { SolarySystemService } from './services/solary-system.service';
import { SSOService } from './services/sso.service';
import { TagService } from './services/tag.service';

/**
 * Provider for all Api services, plus ApiConfiguration
 */
@NgModule({
  imports: [
    HttpClientModule
  ],
  exports: [
    HttpClientModule
  ],
  declarations: [],
  providers: [
    ApiConfiguration,
    AppDataService,
    CharacterService,
    MapService,
    SignatureService,
    SolarSystemStructureService,
    SolarySystemService,
    SSOService,
    TagService
  ],
})
export class ApiModule {
  static forRoot(customParams: ApiConfigurationInterface): ModuleWithProviders<ApiModule> {
    return {
      ngModule: ApiModule,
      providers: [
        {
          provide: ApiConfiguration,
          useValue: {rootUrl: customParams.rootUrl}
        }
      ]
    }
  }
}
