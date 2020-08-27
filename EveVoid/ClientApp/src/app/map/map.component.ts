import { SolarSystemDto } from './../api/models/solar-system-dto';
import { Component, OnInit, OnDestroy } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { switchMap, map } from 'rxjs/operators';
import { MatSnackBar } from '@angular/material/snack-bar';
import { SolarySystemService } from '../api/services';
import { AuthControl } from '../control/auth-control';
import { Subscription, interval } from 'rxjs';

@Component({
  selector: 'app-map',
  templateUrl: './map.component.html',
  styleUrls: ['./map.component.css'],
})
export class MapComponent implements OnInit, OnDestroy {
  solarSystem: SolarSystemDto;
  systemObserver: Subscription;
  fetchingData = false;

  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private readonly snackBar: MatSnackBar,
    private solarySystemService: SolarySystemService,
    private authControl: AuthControl
  ) {
    this.solarSystem = {} as SolarSystemDto;
    this.solarSystem.gates = [];
    this.solarSystem.signatures = [];
    this.solarSystem.pilots = [];
  }

  ngOnInit(): void {
    this.fetch();
    // this.systemObserver = interval(5000).subscribe(() => {
    //   this.fetch();
    // });
  }
fetch() {
  this.fetchingData = true;
  this.route.paramMap
    .pipe(
      switchMap((val) => {
        if (val.has('id')) {
          return this.solarySystemService
            .getApiSolarySystemGetSolarSystemById({
              mainToken: this.authControl.getMainToken(),
              systemId: parseInt(val.get('id')),
            })
            .pipe(
              map((res) => {
                return res;
              })
            );
        } else {
          return this.solarySystemService
            .getApiSolarySystemGetSolarSystemById({
              mainToken: this.authControl.getMainToken(),
              systemId: 30000142,
            })
            .pipe(
              map((res) => {
                return res;
              })
            );
        }
      })
    )
    .subscribe((data) => {
      this.fetchingData = false;
      if (data === null) {
        this.router.navigate(['./map']);
      } else {
        this.solarSystem = data;
      }
    });
}
goToSystem(systemId: number){
  this.router.navigate(['./map/' + systemId]);
}

  ngOnDestroy() {
    //this.systemObserver.unsubscribe();
  }
}
