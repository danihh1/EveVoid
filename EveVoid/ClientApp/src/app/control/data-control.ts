import { MainCharacterDto } from './../api/models/main-character-dto';
import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';


interface CharLocation {
  id: number;
  locationId: string;
}

@Injectable({
  // we declare that this service should be created
  // by the root application injector.
  providedIn: 'root',
})
export class DataControl {
  mapUpdate$ = new BehaviorSubject<boolean>(true);

  mainChar$ = new BehaviorSubject<MainCharacterDto>({});

  charLocations: CharLocation[] = [];

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

  setCharLocation(charLocation: CharLocation) {
    if (this.charLocations.find(x => x.id === charLocation.id)) {
      this.charLocations.find(x => x.id === charLocation.id).locationId = charLocation.locationId;
    } else {
      this.charLocations.push(charLocation);
    }
  }

  getCharLocations(): string[] {
    const res = this.charLocations.map(x => x.locationId);
    return res;
  }
}
