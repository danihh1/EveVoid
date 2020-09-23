import { ImageControl } from './../control/image-control';
import { Component, OnInit } from '@angular/core';
import { AppDataService } from '../api/services';
import { trigger, transition, style, animate } from '@angular/animations';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css'],
  animations: [
    trigger('statusChange', [
      transition('void => *', [
          style({
              opacity: '0',
              transform: 'translateX(-100%)'
          }),
          animate('300ms', style({
              opacity: '1',
              transform: 'translateX(0)'
          }))
      ]),
      transition('loop-state => start-state', [
      ]),
      transition('* => loop-state', [
          style({
              transform: 'translate3d(0,0,0)'
          }),
          animate('600ms', style({
              opacity: '0.1',
          })),
          animate('600ms', style({
              opacity: '1',
          })),
      ]),
      transition('* => end-state', [
          animate('300ms', style({
              opacity: '1',
          })),
      ]),
  ])
  ],
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
