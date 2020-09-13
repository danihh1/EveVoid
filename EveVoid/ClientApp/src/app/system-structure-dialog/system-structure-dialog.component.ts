import { SolarSystemStructureDto } from './../api/models/solar-system-structure-dto';
import { Component, Inject, OnInit } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { SolarSystemStructureService } from '../api/services';
import { AuthControl } from '../control/auth-control';
import { DataControl } from '../control/data-control';
import { DailogRequestData, DialogResult } from '../signature-dialog/confim-dialog.model';

@Component({
  selector: 'app-system-structure-dialog',
  templateUrl: './system-structure-dialog.component.html',
  styleUrls: ['./system-structure-dialog.component.css']
})
export class SystemStructureDialogComponent implements OnInit {

  solarSystemStructureDto: SolarSystemStructureDto = {};

  constructor(@Inject(MAT_DIALOG_DATA) public data: DailogRequestData,
  public dialogRef: MatDialogRef<SystemStructureDialogComponent>,
  private authControl: AuthControl,
  private dataControl: DataControl,
  private structureService: SolarSystemStructureService) {
    this.solarSystemStructureDto = this.data.data;
   }

  ngOnInit(): void {
  }
  onNoClick(): void {
    this.cancel();
  }

  cancel() {
    this.dialogRef.close({
      result: DialogResult.canceld,
      data: this.data.data
    });
  }

  confirm() {
    this.structureService.putApiSolarSystemStructureUpdate({mainToken: this.authControl.getMainToken(), body: this.solarSystemStructureDto})
    .subscribe(x => {
      this.dataControl.forceMapUpdate();
      this.dialogRef.close({
        result: DialogResult.confirmed,
        data: this.data.data
      });
    });
  }
}
