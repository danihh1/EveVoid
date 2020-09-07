import { PreferencesControl } from './../control/preferences-control';
import { Component, ViewChild } from '@angular/core';
import { AuthControl } from '../control/auth-control';
import { Router } from '@angular/router';
import { MatSidenav } from '@angular/material/sidenav';
import { MainCharacterDto } from '../api/models';
import { AppDataService, CharacterService } from '../api/services';
import { DataControl } from '../control/data-control';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  @ViewChild(MatSidenav) sidenav: MatSidenav;
  isExpanded = false;
  ssoLink: string;
  fetchingLink = true;
  mainDto: MainCharacterDto;
  opened = false;

  get auth(): AuthControl {
    return this.authControl;
  }

  get gateCount(): string {
    return this.preferencesControl.getGateCount();
  }

  set gateCount(count: string) {
    this.preferencesControl.setGateCount(count);
  }

  get overlay(): string {
    return this.preferencesControl.getOverlayPosition();
  }

  set overlay(position: string) {
    this.preferencesControl.setOverlayPosition(position);
  }

  constructor(
    public preferencesControl: PreferencesControl,
    public authControl: AuthControl,
    private appDataService: AppDataService,
    private characterService: CharacterService,
    private router: Router,
    private dataControl: DataControl
  ) {
    this.mainDto = {} as MainCharacterDto;
    this.characterService
      .getApiCharacterGetMainCharacter(this.authControl.getMainToken())
      .subscribe(
        (res) => {
          this.mainDto = res;
          this.dataControl.setmainCharObs(res);
          this.appDataService.getApiAppDataGetEsiLoginLink().subscribe(
            (result) => {
              this.ssoLink = result;
              this.fetchingLink = false;
            },
            (error) => console.error(error)
          );
          this.router.navigate(['/map']);
        },
        (err) => {
          console.log(err);
          this.authControl.logout();
        }
      );
  }
  updateMask(value: number) {
    this.characterService.postApiCharacterUpdateMaskType({mainToken: this.authControl.getMainToken(), maskType: value})
    .subscribe(x => {
    }, err => {
      this.authControl.logout();
    });
  }
  logout() {
    this.authControl.logout();
  }
}
