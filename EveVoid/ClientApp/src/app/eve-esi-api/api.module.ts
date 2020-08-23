/* tslint:disable */
import { NgModule, ModuleWithProviders } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { ApiConfiguration, ApiConfigurationInterface } from './api-configuration';

import { AllianceService } from './services/alliance.service';
import { ContactsService } from './services/contacts.service';
import { CharacterService } from './services/character.service';
import { AssetsService } from './services/assets.service';
import { SkillsService } from './services/skills.service';
import { BookmarksService } from './services/bookmarks.service';
import { CalendarService } from './services/calendar.service';
import { ClonesService } from './services/clones.service';
import { ContractsService } from './services/contracts.service';
import { FittingsService } from './services/fittings.service';
import { FleetsService } from './services/fleets.service';
import { FactionWarfareService } from './services/faction-warfare.service';
import { IndustryService } from './services/industry.service';
import { KillmailsService } from './services/killmails.service';
import { LocationService } from './services/location.service';
import { LoyaltyService } from './services/loyalty.service';
import { MailService } from './services/mail.service';
import { OpportunitiesService } from './services/opportunities.service';
import { MarketService } from './services/market.service';
import { PlanetaryInteractionService } from './services/planetary-interaction.service';
import { SearchService } from './services/search.service';
import { WalletService } from './services/wallet.service';
import { CorporationService } from './services/corporation.service';
import { DogmaService } from './services/dogma.service';
import { IncursionsService } from './services/incursions.service';
import { InsuranceService } from './services/insurance.service';
import { RoutesService } from './services/routes.service';
import { SovereigntyService } from './services/sovereignty.service';
import { StatusService } from './services/status.service';
import { UserInterfaceService } from './services/user-interface.service';
import { UniverseService } from './services/universe.service';
import { WarsService } from './services/wars.service';

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
    AllianceService,
    ContactsService,
    CharacterService,
    AssetsService,
    SkillsService,
    BookmarksService,
    CalendarService,
    ClonesService,
    ContractsService,
    FittingsService,
    FleetsService,
    FactionWarfareService,
    IndustryService,
    KillmailsService,
    LocationService,
    LoyaltyService,
    MailService,
    OpportunitiesService,
    MarketService,
    PlanetaryInteractionService,
    SearchService,
    WalletService,
    CorporationService,
    DogmaService,
    IncursionsService,
    InsuranceService,
    RoutesService,
    SovereigntyService,
    StatusService,
    UserInterfaceService,
    UniverseService,
    WarsService
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
