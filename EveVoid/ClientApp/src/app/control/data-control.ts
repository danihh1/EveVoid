import { MainCharacterDto } from './../api/models/main-character-dto';
import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';

@Injectable({
  // we declare that this service should be created
  // by the root application injector.
  providedIn: 'root',
})
export class DataControl {
  mapUpdate$ = new BehaviorSubject<boolean>(true);

  mainChar$ = new BehaviorSubject<MainCharacterDto>({});

  getmainCharObs(): Observable<MainCharacterDto> {
    return this.mainChar$.asObservable();
  }

  setmainCharObs(profile: MainCharacterDto) {
    this.mainChar$.next(profile);
  }

  getMapUpdateObs(): Observable<boolean> {
    return this.mapUpdate$.asObservable();
  }
  forceMapUpdate() {
    this.mapUpdate$.next(true);
  }
}
