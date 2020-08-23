import { Component } from '@angular/core';
import { AuthControl } from '../control/auth-control';
import { AppDataService } from '../api/services';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {
  isExpanded = false;
  ssoLink:string;
  fetchingLink = true;

  get auth(): AuthControl{
    return this.authControl;
  }

  constructor(private appDataService: AppDataService,
    private authControl: AuthControl){
    this.appDataService.getApiAppDataGetSSOLoginLink().subscribe(result => {
      this.ssoLink = result;
      this.fetchingLink = false;
    }, error => console.error(error));
  }
  confirm(){
    console.log(this.authControl.confirmAuthenticaion());
  }

  logout(){
    this.authControl.logout();
  }

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }
}
