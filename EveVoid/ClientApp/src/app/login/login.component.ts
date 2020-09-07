import { ImageControl } from './../control/image-control';
import { Component, OnInit } from '@angular/core';
import { AppDataService } from '../api/services';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  ssoLink: string;
  fetchingLink = true;
  allianceLogoLink: string;
  corpId: number;
  allianceId: number;
  corpName: string;
  allianceName: string;

  get corpLogo(): string {
    return this.imageControl.getCorpLogo(this.corpId, 128);
  }
  get allianceLogo(): string {
    return this.imageControl.getAllianceLogo(this.allianceId, 128);
  }
  get groupName(): string {
    return this.allianceName === null ? this.corpName : this.allianceName;
  }

  constructor(private appDataService: AppDataService,
    private imageControl: ImageControl) {
    this.appDataService.getApiAppDataGetSSOLoginLink().subscribe(
    (result) => {
      this.ssoLink = result;
      this.fetchingLink = false;
      this.appDataService.getApiAppDataGetMainCorpId().subscribe(res => {
        this.corpId = res;
        this.appDataService.getApiAppDataGetMainCorpName().subscribe(res2 => {
          this.corpName = res2;
          this.appDataService.getApiAppDataGetMainAllianceId().subscribe(res3 => {
            this.allianceId = res3;
            this.appDataService.getApiAppDataGetMainAllianceName().subscribe(res4 => {
              this.allianceName = res4;
            });
          });
        });
      });
    });
  }

  ngOnInit(): void {
  }

}
