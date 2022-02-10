import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { AuthControl } from '../control/auth-control';

@Component({
  selector: 'app-callback',
  templateUrl: './callback.component.html',
  styleUrls: ['./callback.component.css']
})
export class CallbackComponent implements OnInit {

  _code = "";
  _res = "";

  constructor(private activatedRoute: ActivatedRoute,
    private authConrol: AuthControl,
    private router: Router) {
    this.activatedRoute.queryParams.subscribe(params => {
          let code = params['code'];
          this._code = code;
          this.authConrol.login(code)
          .subscribe(res => {
            if (res){
              this.router.navigate(['']);
            }
          });

      });
  }
  ngOnInit() {
  }

}
