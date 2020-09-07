import { MapLayoutDto } from './../api/models/map-layout-dto';
import { DeleteSigsSnackComponent } from './../delete-sigs-snack/delete-sigs-snack.component';
import { WormholeTypeDto } from './../api/models/wormhole-type-dto';
import { PreferencesControl } from './../control/preferences-control';
import { SigTypes } from './../control/constants/signature-types';
import { SignatureDto } from './../api/models/signature-dto';
import { SolarSystemDto } from './../api/models/solar-system-dto';
import { Component, OnInit, OnDestroy, ViewChild, AfterViewInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { switchMap, map, takeUntil } from 'rxjs/operators';
import { MatSnackBar } from '@angular/material/snack-bar';
import { SolarySystemService, SignatureService } from '../api/services';
import { AuthControl } from '../control/auth-control';
import { Subscription, interval, Subject } from 'rxjs';
import { MatDialog } from '@angular/material/dialog';
import { SignatureDialogComponent } from '../signature-dialog/signature-dialog.component';
import { DailogResponseData, DialogResult, SignatureDailogResponseData } from '../signature-dialog/confim-dialog.model';
import * as moment from 'moment';
import { DataControl } from '../control/data-control';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { WormholeTypeMapDto } from '../api/models';
import { NumberAbbreviatePipe } from '../pipes/number-abbreviate.pipe';

@Component({
  selector: 'app-map',
  templateUrl: './map.component.html',
  styleUrls: ['./map.component.css'],
})
export class MapComponent implements OnInit, OnDestroy {
  solarSystem: SolarSystemDto;
  systemObserver: Subscription;
  fetchingData = false;
  sigTypes = SigTypes;
  wormholeTypes: WormholeTypeDto[] = [];
  unsubscribe$: Subject<boolean> = new Subject();
  @ViewChild(MatSort) sort: MatSort;
  dataSource = new MatTableDataSource([]);
  displayedColumns = ['signatureId', 'signatureType', 'leadsTo', 'expiryDate', 'mass', 'actions'];

  constructor(private signatureService: SignatureService,
    private dialog: MatDialog,
    private route: ActivatedRoute,
    private router: Router,
    private readonly snackBar: MatSnackBar,
    private solarySystemService: SolarySystemService,
    private authControl: AuthControl,
    private abbreviate: NumberAbbreviatePipe,
    public preferencesControl: PreferencesControl,
    private dataControl: DataControl
  ) {
    this.signatureService.getApiSignatureGetWormholeTypes().subscribe(x => {
      this.wormholeTypes = x;
    });
    this.solarSystem = {} as SolarSystemDto;
    this.solarSystem.gates = [];
    this.solarSystem.signatures = [];
    this.solarSystem.pilots = [];
  }

  ngOnInit(): void {
    // this.dataControl.forceMapUpdate();
    this.dataControl.getMapUpdateObs().pipe(takeUntil(this.unsubscribe$)).subscribe(update => {
      if (update) {
        this.fetch();
        if (this.systemObserver) {
          this.systemObserver.unsubscribe();
        }
        // this.systemObserver = interval(10000).subscribe(() => {
        //   this.fetch();
        // });
      }
    });
  }
fetch() {
  this.fetchingData = true;
  // this.route.paramMap
  //   .pipe(
  //     switchMap((val) => {
  //       if (val.has('id')) {
  //         return this.solarySystemService
  //           .getApiSolarySystemGetSolarSystemById({
  //             mainToken: this.authControl.getMainToken(),
  //             systemId: parseInt(val.get('id')),
  //           })
  //           .pipe(
  //             map((res) => {
  //               return res;
  //             })
  //           );
  //       } else {
  //         this.goToSystem(this.preferencesControl.getMapSystem() && this.preferencesControl.getMapSystem().solarSystemId ?
  //         this.preferencesControl.getMapSystem().solarSystemId : 30000142);
  //       }
  //     })
  //   )
  this.solarySystemService.getApiSolarySystemGetSolarSystemById({
    mainToken: this.authControl.getMainToken(),
    systemId: this.preferencesControl.getMapSystem().solarSystemId}).subscribe((data) => {
      this.fetchingData = false;
      if (data === null) {
        this.router.navigate(['./map']);
      } else {
        this.solarSystem = data;
        this.dataSource = new MatTableDataSource(this.solarSystem.signatures);
        this.dataSource.sort = this.sort;
      }
    });
}
goToSystem(systemId: number) {
  this.preferencesControl.setSelectedSystem({solarSystemId: systemId});
  this.dataControl.forceMapUpdate();
  // this.router.navigate(['./map/' + systemId]);
}
openSigDialog(id: number) {
  const dialogRef = this.dialog.open(SignatureDialogComponent, {
    data: {
      title: '',
      body: '',
      data: {
        systemId: this.solarSystem.id,
        id: id,
      } as SignatureDto,
    },
  });

}

  ngOnDestroy() {
    this.unsubscribe$.next(true);
    this.unsubscribe$.complete();
    if (this.systemObserver) {
      this.systemObserver.unsubscribe();
    }
  }

  getDateFromFormat(format: string) {
    return Date.parse(format);
  }

  getDateColorFromFormat(format: string) {
    const start = moment.utc(Date.now());
    const expiry = moment.utc(format);
    const duration = moment.duration(expiry.diff(start));
    const hours = duration.asHours();
    return hours < 4 ? 'red' : 'white';
  }

  getMassColor(mass: number): string {
    if (mass < 0) {
      return 'fuchsia';
    }
    if (mass >= 0.9) {
      return 'red';
    }
    if (mass >= 0.5) {
      return 'orange';
    }
    return 'white';
  }

  getMassText(mass: number): string {
    if (mass === 0) {
      return '???';
    }
    if (mass < 0) {
      return 'Frig';
    }
    const percentMass = mass * 100;
    let res = '';
    if (percentMass < 1) {
      res += '<1%';
    } else {
      res += '>' + percentMass.toFixed(0) + '%';
    }
    return res;
  }

  getWormholeType(typeId: number) {
    return this.wormholeTypes.find(x => x.id === typeId);
  }

  deleteSig(id: number) {
    const index = this.solarSystem.signatures.findIndex(x => x.id === id);
    if (index > -1) {
      this.signatureService.deleteApiSignature(id).subscribe(x => {
        this.dataControl.forceMapUpdate();
      });
    }
  }
  onPaste(event: ClipboardEvent) {
    const pastedSigs: SignatureDto[] = [];
    const pasteText = event.clipboardData.getData('text');
    const pasteLines = pasteText.split('\n');
    pasteLines.forEach(x => {
      const pasteSig = x.split('\t');
      if (pasteSig.length < 2) {
        return;
      }
      const sigId = pasteSig[0];
      const sigType = pasteSig[2];
      const sigName = pasteSig[3];
      const regex = /[A-Z]{3}-[0-9]{3}/g;
      const sig = sigId.match(regex);
      if (sig.length === 0) {
        return;
      }
      const sigTypeMatch =  this.sigTypes.find(s => sigType.indexOf(s.name) > -1);
      pastedSigs.push({
        name: sigTypeMatch && sigTypeMatch.id === 1 ? '' : sigName,
        signatureId: sig[0].split('-')[0],
        signatureType: sigTypeMatch ? sigTypeMatch.id : 0,
        expiryDate: new Date(Date.now() + (24 * 60 * 60 * 1000)).toJSON(),
        wormholeType: '????',
        // wormholeTypeId: this.wormholeTypes.find(w => w.name === '????').id,
        creationDate: new Date().toJSON(),
        jumps: []
      } as SignatureDto);
      // console.log(sig[0].split('-')[0]);
    });
    pastedSigs.forEach(x => {
      const existIndex = this.solarSystem.signatures.findIndex(s => s.signatureId === x.signatureId);
      if (existIndex > -1) {
        const existSig = this.solarSystem.signatures[existIndex];
        existSig.signatureType = x.signatureType;
        if (x.signatureType !== 1) {
          existSig.name = x.name;
        }
      } else {
        this.solarSystem.signatures.push(x);
      }
    });
    if (this.solarSystem.signatures.some(x =>
      pastedSigs.findIndex(p => p.signatureId === x.signatureId) === -1 && x.signatureId !== '???')) {
        const deleteSnack =  this.snackBar.openFromComponent(DeleteSigsSnackComponent, {
          data: {signatures: this.solarSystem.signatures,
            pastedData: pastedSigs
          },
          duration: 3000
        });
        deleteSnack.onAction().subscribe(() => {
          this.solarSystem.signatures = this.solarSystem.signatures.filter(x =>
            pastedSigs.findIndex(p => p.signatureId === x.signatureId) > -1 || x.signatureId === '???');
            this.solarySystemService.putApiSolarySystemUpdateSolarSystemSignatures({
              mainToken: this.authControl.getMainToken(), body: this.solarSystem}).subscribe(x => {
                this.solarSystem = x;
              });
        });
    }
    this.solarySystemService.putApiSolarySystemUpdateSolarSystemSignatures({
      mainToken: this.authControl.getMainToken(), body: this.solarSystem}).subscribe(x => {
        this.solarSystem = x;
        this.dataControl.forceMapUpdate();
      });
  }
  getTooltipForWormhole(type: SignatureDto): string {
    if (!type.wormholeType) {
      return;
    }
    let p = this.wormholeTypes.find(x => x.name === type.wormholeType);
    if (type.wormholeType === '????' || type.wormholeType === 'K162') {
      if (type.destinationWormholeType && type.destinationWormholeType !== '????' && type.destinationWormholeType !== 'K162') {
        p = this.wormholeTypes.find(x => x.name === type.destinationWormholeType);
      } else {
        return `Type: ${p.name}\n Duration: Unknown\n Max Jump: Unknown\n Max Mass: Unknown\n LeadsTo: Unknown\n`;
      }
    }
    return `Type: ${p.name}\n Duration: ${p.duration}\n Max Jump: ${this.abbreviate.transform(p.maxJump, 2)}\n Max Mass: ${this.abbreviate.transform(p.maxMass, 2)}\n LeadsTo: ${p.leadsTo}\n`;
  }
}
