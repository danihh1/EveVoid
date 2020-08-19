import { Component } from '@angular/core';
import { AuthControl } from '../control/auth-control';
import { Router } from '@angular/router';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {

  constructor(private authConrol: AuthControl,
    private router: Router) { 
      if (this.authConrol.isLoggedIn()){
        this.router.navigate(['/index']);
      }
    }
}
