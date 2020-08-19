import { Observable, Subject, of } from "rxjs";
import { SSOService } from "../api/services";
import { Injectable } from "@angular/core";
import { MainLoginDto } from "../api/models";
import { map } from "rxjs/operators";

const ACCSESS_TOKEN_KEY = 'access_token';
const CHARACTER_ID_KEY = 'character_id';
@Injectable({
    // we declare that this service should be created
    // by the root application injector.
    providedIn: 'root',
  })
export class AuthControl {

    isLoggedIn():boolean{
        return localStorage.getItem(ACCSESS_TOKEN_KEY) != null && localStorage.getItem(CHARACTER_ID_KEY) != null;
    }
    constructor(private ssoService: SSOService) {
    }

    login(code: string): Observable<boolean> {
        return this.ssoService.getApiSSOExchangeCodeForToken(code)
            .pipe(
                map(
                    res => {
                        localStorage.setItem(ACCSESS_TOKEN_KEY, res.accessToken);
                        localStorage.setItem(CHARACTER_ID_KEY, "" + res.characterId);
                        return true;
                    },
                    err => {
                        if (err.status === 401 || err.status === 400) {
                            console.log(err);
                        }
                        return false;
                    }));
    }

    logout(){
        localStorage.removeItem(ACCSESS_TOKEN_KEY);
        localStorage.removeItem(CHARACTER_ID_KEY);
    }
    confirmAuthenticaion(): boolean
    {
        if (!this.isLoggedIn()){
            return false;
        }
        let dto = {} as MainLoginDto;
        dto.characterId = +localStorage.getItem(CHARACTER_ID_KEY);
        dto.accessToken = localStorage.getItem(ACCSESS_TOKEN_KEY);
        this.ssoService.postApiSSOConfirmAuthCharId(dto).subscribe(res => {
            if (!res){
                this.logout();
            }
            return res;
        });
    }

    getMainToken():string{
        return localStorage.getItem(ACCSESS_TOKEN_KEY);
    }
}