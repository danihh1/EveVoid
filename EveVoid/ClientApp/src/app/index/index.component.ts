import { Component, OnInit } from '@angular/core';
import { MainCharacterDto } from '../api/models';
import { AuthControl } from '../control/auth-control';
import { CharacterService, AppDataService } from '../api/services';

@Component({
  selector: 'app-index',
  templateUrl: './index.component.html',
  styleUrls: ['./index.component.css']
})
export class IndexComponent implements OnInit {

  mainDto: MainCharacterDto;
  ssoLink:string;
  fetchingLink = true;

  constructor(private authConrol: AuthControl,
    private appDataService: AppDataService,
    private characterService: CharacterService) { 
      this.mainDto = {} as MainCharacterDto;
      if (this.authConrol.isLoggedIn()){
        this.characterService.getApiCharacterGetMainCharacter(this.authConrol.getMainToken())
        .subscribe(res => {
          this.mainDto = res;
          this.appDataService.getApiAppDataGetEsiLoginLink().subscribe(result => {
            this.ssoLink = result;
            this.fetchingLink = false;
          }, error => console.error(error));
        });
  }}

  ngOnInit() {
  }

}