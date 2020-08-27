import { Component, ViewChild } from '@angular/core';
import { AuthControl } from '../control/auth-control';
import { Router } from '@angular/router';
import { MatSidenav } from '@angular/material/sidenav';
import { MainCharacterDto } from '../api/models';
import { AppDataService, CharacterService } from '../api/services';

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

  constructor(
    public authConrol: AuthControl,
    private appDataService: AppDataService,
    private characterService: CharacterService,
    private authControl: AuthControl,
    private router: Router
  ) {
    this.mainDto = {} as MainCharacterDto;
    this.characterService
      .getApiCharacterGetMainCharacter(this.authConrol.getMainToken())
      .subscribe(
        (res) => {
          console.error(res);
          this.mainDto = res;
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

  logout() {
    this.authControl.logout();
  }
}
