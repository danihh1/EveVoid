import { AuthControl } from './../control/auth-control';
import { Component, OnInit, Input } from '@angular/core';
import { ImageControl } from '../control/image-control';
import { Observable, interval, Subscription, combineLatest } from 'rxjs';
import { HttpErrorResponse } from '@angular/common/http';
import { EsiCharacterDto } from '../api/models';
import { CharacterService } from '../api/services';
import { LocationService } from '../eve-esi-api/services';


@Component({
  selector: 'app-esi-character',
  templateUrl: './esi-character.component.html',
  styleUrls: ['./esi-character.component.css']
})
export class EsiCharacterComponent implements OnInit {
  @Input() esiChar: EsiCharacterDto;
  portraitSize = 64;
  locationObserver: Subscription;
  _charLocation: any;
  reportingLocation = false;

  get portrait(): string {
    return this.imageControl.getPortraitForCharacter(this.esiChar.id, this.portraitSize);
  }
  get corpLogo(): string {
    return this.imageControl.getCorpLogo(this.esiChar.id, this.portraitSize/2);
  }
  get allianceLogo(): string {
    return this.imageControl.getAllianceLogo(this.esiChar.id, this.portraitSize/2);
  }
  constructor(private imageControl: ImageControl,
  private _locationApi: LocationService,
  private _characterService: CharacterService,
  private authControl: AuthControl) {

   }

  ngOnInit() {
    this.locationObserver = interval(5000).subscribe(() => {
      console.log(this.esiChar);
      this.reportingLocation = true;
      const location$ = this._locationApi.getCharactersCharacterIdLocation({characterId: this.esiChar.id, token: this.esiChar.esiToken, datasource: null, IfNoneMatch: null});
      const ship$ = this._locationApi.getCharactersCharacterIdShip({characterId: this.esiChar.id, token: this.esiChar.esiToken, datasource: null, IfNoneMatch: null});
      combineLatest(location$, ship$, (location, ship) => ({location, ship}))
      .subscribe( pair => {
        this.esiChar.currentSystemId = pair.location.solar_system_id;
        this.esiChar.currentShipTypeId = pair.ship.ship_type_id;
        this.esiChar.currentShipName = pair.ship.ship_name;
      }, err => {
        console.log(err);
        this._characterService.postApiCharacterGetEsiCharacter({mainToken:this.authControl.getMainToken(),esiToken: this.esiChar.esiToken}).subscribe(dto=> {
          this.esiChar = dto;
        });
      }, () => {
        this._characterService.postApiCharacterUpdateEsiCharacter({mainToken: this.authControl.getMainToken(), body: this.esiChar}).subscribe(res=> {
          this.esiChar = res;
        });
        this.reportingLocation = false;
      });
    });
  }
  ngOnDestroy() {
    this.locationObserver.unsubscribe();
  }

}
