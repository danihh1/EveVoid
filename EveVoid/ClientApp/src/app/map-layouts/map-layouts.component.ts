import { MapLayout, MapLayouts } from './../control/constants/map-layouts';
import { Component, OnInit } from '@angular/core';
import { DataControl } from '../control/data-control';
import { PreferencesControl } from '../control/preferences-control';
import { MatTooltipDefaultOptions, MAT_TOOLTIP_DEFAULT_OPTIONS } from '@angular/material/tooltip';


export const myCustomTooltipDefaults: MatTooltipDefaultOptions = {
  showDelay: 1000,
  hideDelay: 1000,
  touchendHideDelay: 1000,
};

@Component({
  selector: 'app-map-layouts',
  templateUrl: './map-layouts.component.html',
  styleUrls: ['./map-layouts.component.css'],
  providers: [
    {provide: MAT_TOOLTIP_DEFAULT_OPTIONS, useValue: myCustomTooltipDefaults}
  ],
})
export class MapLayoutsComponent implements OnInit {
  layouts = MapLayouts;
  constructor(private preferencesControl: PreferencesControl,
    private dataControl: DataControl) { }

  ngOnInit(): void {

  }

  getCurrentLayout() {
    return this.preferencesControl.getMapLayout();
  }

  changeMapLayout(layout: MapLayout) {
    this.preferencesControl.setMapLayout(layout.id);
    this.dataControl.forceMapUpdate();
  }
}
