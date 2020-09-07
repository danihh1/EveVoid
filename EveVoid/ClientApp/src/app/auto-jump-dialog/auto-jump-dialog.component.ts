import { SignatureDto } from './../api/models/signature-dto';
import { Component, OnInit, Inject } from '@angular/core';
import { SignatureService } from '../api/services';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { AutoJumpDailogRequestData, DialogResult } from '../signature-dialog/confim-dialog.model';
import { AuthControl } from '../control/auth-control';
import * as moment from 'moment';

@Component({
  selector: 'app-auto-jump-dialog',
  templateUrl: './auto-jump-dialog.component.html',
  styleUrls: ['./auto-jump-dialog.component.css']
})
export class AutoJumpDialogComponent implements OnInit {

  selectedSigId: number = null;
  constructor(private signatureService: SignatureService,
    public dialogRef: MatDialogRef<AutoJumpDialogComponent>,
    @Inject(MAT_DIALOG_DATA) public data: AutoJumpDailogRequestData,
    private authControl: AuthControl) { }

  ngOnInit(): void {
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
    const selectedSig = this.data.data.find(x => x.id === this.selectedSigId);
    this.dialogRef.close({
      result: DialogResult.confirmed,
      data: selectedSig,
    });
  }

  getDateColorFromFormat(format: string) {
    const start = moment.utc(Date.now());
    const expiry = moment.utc(format);
    const duration = moment.duration(expiry.diff(start));
    const hours = duration.asHours();
    return hours < 4 ? 'red' : 'white';
  }
}
