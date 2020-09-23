import { FavoriteDistanceDto } from './../api/models/favorite-distance-dto';
import { Component, Input, OnDestroy, OnInit } from '@angular/core';
import { RouteService } from '../api/services/route.service';
import { AuthControl } from '../control/auth-control';
import { interval, Subject, Subscription } from 'rxjs';
import { takeUntil } from 'rxjs/operators';
import { DataControl } from '../control/data-control';
import { PreferencesControl } from '../control/preferences-control';

@Component({
  selector: 'app-favorite-system-routes',
  templateUrl: './favorite-system-routes.component.html',
  styleUrls: ['./favorite-system-routes.component.css']
})
export class FavoriteSystemRoutesComponent implements OnInit {
  private _solarSystemId: number;
  @Input() set solarSystemId(value: number) {
    this._solarSystemId = value;
    if (value) {
      this.fetch();
    }
  }
  dto: FavoriteDistanceDto[];
  constructor(private authControl: AuthControl,
    public preferencesControl: PreferencesControl,
    private routeService: RouteService,
    private dataControl: DataControl) {
     }

  ngOnInit(): void {
  }

  fetch() {
    this.routeService.getApiRoute({mainToken: this.authControl.getMainToken(), originSystemId: this._solarSystemId,
      routeType: parseInt(this.preferencesControl.getRouteType(), 10)})
    .subscribe(x => {
      this.dto = x;
    });
  }

  goToSystem(systemId: number) {
    this.preferencesControl.setSelectedSystem({solarSystemId: systemId});
    this.dataControl.forceMapUpdate();
  }
}
