import { MapLayoutDto } from './../api/models/map-layout-dto';
import { Injectable } from '@angular/core';

const GATE_COUNT = 'gate_count';
const OVERLAY_POSITION = 'overlay_position';
const MAP_SYSTEM = 'map_system';
const SELECTED_SYSTEM = 'selected_system';

@Injectable({
  // we declare that this service should be created
  // by the root application injector.
  providedIn: 'root',
})
export class PreferencesControl {
  constructor() {
    localStorage.setItem(SELECTED_SYSTEM, JSON.stringify({ solarSystemId: 30000142 }));
  }

  public setGateCount(count: string) {
    localStorage.setItem(GATE_COUNT, count);
  }
  public getGateCount(): string {
    if (localStorage.getItem(GATE_COUNT) == null) {
      this.setGateCount('0');
    }
    return localStorage.getItem(GATE_COUNT);
  }
  public setOverlayPosition(position: string) {
    localStorage.setItem(OVERLAY_POSITION, position);
  }
  public getOverlayPosition(): string {
    if (localStorage.getItem(OVERLAY_POSITION) == null) {
      this.setOverlayPosition('left');
    }
    return localStorage.getItem(OVERLAY_POSITION);
  }
  public setMapSystem(mapLayout: MapLayoutDto) {
    localStorage.setItem(MAP_SYSTEM, JSON.stringify(mapLayout));
  }
  public getMapSystem(): MapLayoutDto {
    const res = JSON.parse(localStorage.getItem(MAP_SYSTEM));
    if (res) {
      return res;
    }
    return this.getSelectedSystem();
  }

  public setSelectedSystem(mapLayout: MapLayoutDto) {
    if (!mapLayout) {
      localStorage.setItem(SELECTED_SYSTEM, JSON.stringify({ solarSystemId: 30000142 }));
    } else {
      localStorage.setItem(SELECTED_SYSTEM, JSON.stringify(mapLayout));
    }
  }
  public getSelectedSystem(): MapLayoutDto {
    const res = JSON.parse(localStorage.getItem(SELECTED_SYSTEM));
    if (res) {
      return res;
    }
    return { solarSystemId: 30000142 } as MapLayoutDto;
  }
}
