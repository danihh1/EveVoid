import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { AuthControl } from '../control/auth-control';
import { MainCharacterDto, EsiLoginDto } from '../api/models';
import { SSOService } from '../api/services';

@Component({
  selector: 'app-callback-esi',
  templateUrl: './callback-esi.component.html',
  styleUrls: ['./callback-esi.component.css']
})
export class CallbackEsiComponent implements OnInit {

  _code = "";
  _res = "";
  mainDto: MainCharacterDto;

  constructor(private activatedRoute: ActivatedRoute,
    private authConrol: AuthControl,
    private ssoService: SSOService,
    private router: Router) {
      this.activatedRoute.queryParams.subscribe(params => {
          let code = params['code'];
          this._code = code;
          if (this.authConrol.isLoggedIn()){
            let dto = {mainCharacterToken: this.authConrol.getMainToken(), accessCode: this._code} as EsiLoginDto;
            console.log(dto);
            this.ssoService.postApiSSOExchangeCodeForTokenEsi(dto)
              .subscribe(res => {
                this.router.navigate(['']);
              }, err => {
                console.log(err);
                this.router.navigate(['']);
              });
          }
      });
  }

  ngOnInit() {
  }

}
