import { MapLayoutDto } from './../api/models/map-layout-dto';
import { Injectable } from '@angular/core';

const GATE_COUNT = 'gate_count';
const OVERLAY_POSITION = 'overlay_position';
const MAP_SYSTEM = 'map_system';
const SELECTED_SYSTEM = 'selected_system';
const ROUTE_TYPE = 'route_type';
const MAP_LAYOUT = 'map_layout';
const CONNECTION_STYLE = 'connection_style';

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
    let res = JSON.parse(localStorage.getItem(SELECTED_SYSTEM));
    if (res) {
      return res;
    }
    res = JSON.parse(localStorage.getItem(MAP_SYSTEM));
    if (res) {
      return res;
    }
    return { solarSystemId: 30000142 } as MapLayoutDto;
  }

  public setRouteType(count: string) {
    localStorage.setItem(ROUTE_TYPE, count);
  }
  public getRouteType(): string {
    if (localStorage.getItem(ROUTE_TYPE) === null) {
      this.setRouteType('0');
    }
    return localStorage.getItem(ROUTE_TYPE);
  }

  public setMapLayout(count: string) {
    localStorage.setItem(MAP_LAYOUT, count);
  }
  public getMapLayout(): string {
    if (localStorage.getItem(MAP_LAYOUT) === null) {
      this.setMapLayout('dagre');
    }
    return localStorage.getItem(MAP_LAYOUT);
  }

  public setConnectionStyle(count: string) {
    localStorage.setItem(CONNECTION_STYLE, count);
  }
  public getConnectionStyle(): string {
    if (localStorage.getItem(CONNECTION_STYLE) === null) {
      this.setConnectionStyle('Wormhole Type');
    }
    return localStorage.getItem(CONNECTION_STYLE);
  }
}
