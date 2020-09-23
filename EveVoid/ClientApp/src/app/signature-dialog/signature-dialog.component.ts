import { WormholeLifeTypes } from './../control/constants/wormhole-life-types';
import { MassTypes } from './../control/constants/mass-types';
import { MassIndicator } from './../api/models/mass-indicator';
import { AuthControl } from './../control/auth-control';
import { SignatureDto } from './../api/models/signature-dto';
import { SolarSystemDto } from './../api/models/solar-system-dto';
import { WormholeTypeDto } from './../api/models/wormhole-type-dto';
import { SigTypes } from './../control/constants/signature-types';
import { Component, OnInit, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import {
  DialogResult,
  SignatureDailogRequestData,
} from './confim-dialog.model';
import { Observable, of } from 'rxjs';
import { FormControl } from '@angular/forms';
import {
  startWith,
  map,
  debounceTime,
  distinctUntilChanged,
  switchMap,
} from 'rxjs/operators';
import { SignatureService, SolarSystemService } from '../api/services';
import { DataControl } from '../control/data-control';

@Component({
  selector: 'app-signature-dialog',
  templateUrl: './signature-dialog.component.html',
  styleUrls: ['./signature-dialog.component.css'],
})
export class SignatureDialogComponent implements OnInit {
  types = SigTypes;
  control = new FormControl();
  filterControl = new FormControl();
  filteredWormholeTypes: Observable<WormholeTypeDto[]>;
  wormholeTypes = [];

  leadsToControl = new FormControl();
  filteredSystems: Observable<SolarSystemDto[]>;
  fetchedSystems = [];

  massTypes = MassTypes;
  wormholeLifeTypes = WormholeLifeTypes;

  signature: SignatureDto = {
    signatureType: 0,
    signatureId: '???',
    expiryDate: new Date(Date.now() + 24 * 60 * 60 * 1000).toJSON(),
    wormholeType: '????',
    massIndicator: 0,
    timeRemainingIndicator: 0,
    //wormholeTypeId: this.wormholeTypes.find(w => w.name === '????').id,
    creationDate: new Date().toJSON(),
    jumps: [],
  } as SignatureDto;

  constructor(
    private solarSystemService: SolarSystemService,
    private signatureService: SignatureService,
    public dialogRef: MatDialogRef<SignatureDialogComponent>,
    @Inject(MAT_DIALOG_DATA) public data: SignatureDailogRequestData,
    private dataControl: DataControl,
    private authControl: AuthControl
  ) {
    this.signatureService.getApiSignatureGetWormholeTypes().subscribe((x) => {
      this.wormholeTypes = x;
    });
  }

  ngOnInit() {
    this.filteredWormholeTypes = this.control.valueChanges.pipe(
      startWith(''),
      map((value) => this._filter(value))
    );

    this.filteredSystems = this.leadsToControl.valueChanges
      .pipe(
        debounceTime(300),
        distinctUntilChanged(),
        startWith(''),
        switchMap((value) => {
          return this.solarSystemService.getApiSolarSystemFind(value);
        })
      )
      .pipe(
        debounceTime(300),
        distinctUntilChanged(),
        map((result) => {
          this.fetchedSystems = result;
          return result.filter((x) => x.id !== this.signature.systemId);
        })
      );

    if (this.data.data.id > 0) {
      this.signatureService
        .getApiSignatureGetSignatureById(this.data.data.id)
        .subscribe((x) => {
          this.signature = x;
        });
    } else {
      this.signature.systemId = this.data.data.systemId;
    }
  }

  private _filter(value: string): WormholeTypeDto[] {
    const filterValue = this._normalizeValue(value);
    return this.wormholeTypes.filter((type) =>
      this._normalizeValue(type.name).includes(filterValue)
    );
  }

  private _normalizeValue(value: string): string {
    return value.toLowerCase().replace(/\s/g, '');
  }

  leadsToSelected(name: string) {
    const selected = this.fetchedSystems.find((x) => x.name === name);
    this.signature.destinationSystemId = selected.id;
    this.signature.destinationSystemName = selected.name;
  }

  onNoClick(): void {
    this.cancel();
  }

  cancel() {
    this.dialogRef.close({
      result: DialogResult.canceld,
      data: this.data.data,
    });
  }

  confirm() {
    if (this.signature.destinationSystemName === '') {
      this.signature.destinationSystemId = null;
    }
    if (this.signature.id > 0) {
      this.signatureService
        .putApiSignatureUpdateSignature({
          mainToken: this.authControl.getMainToken(),
          body: this.signature,
        })
        .subscribe(
          (x) => {
            this.dataControl.forceMapUpdate();
          },
          (err) => {
            console.log('update failed', err);
          }
        );
    } else {
      this.signatureService
        .postApiSignatureInsertSignature({
          mainToken: this.authControl.getMainToken(),
          body: this.signature,
        })
        .subscribe(
          (x) => {
            this.dataControl.forceMapUpdate();
          },
          (err) => {
            console.log('insert failed', err);
          }
        );
    }
    this.dialogRef.close({
      result: DialogResult.confirmed,
      data: this.data.data,
    });
  }

  wormholeTypeSelected(wormholeTypeName: string) {
    const wormholeType = this.wormholeTypes.find(
      (x) => x.name === wormholeTypeName
    );
    // this.data.data.name = wormholeType.name;
    this.signature.wormholeTypeId = wormholeType.id;
    this.signature.expiryDate = new Date(
      Date.parse(this.signature.creationDate) +
        parseInt(wormholeType.duration, 10) * 60 * 60 * 1000
    ).toISOString();
    // console.log(this.data.data.expiryDate);
    // Date.parse(wormholeType.duration);
  }

  typeSelected(typeId: number) {
    this.signature.name = '';
  }
}
