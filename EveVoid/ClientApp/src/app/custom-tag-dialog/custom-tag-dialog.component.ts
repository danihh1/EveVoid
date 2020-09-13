import { AuthControl } from './../control/auth-control';
import { TagColorOptions, TagIconOptions } from './../control/constants/tag-types';
import { SolarSystemTagDto } from './../api/models/solar-system-tag-dto';
import { Component, OnInit, Inject } from '@angular/core';
import { TagService } from '../api/services';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { DailogRequestData, DialogResult } from '../signature-dialog/confim-dialog.model';
import * as moment from 'moment';
import { DataControl } from '../control/data-control';

export interface TagDuration {
  name: string;
  duration: number;
}

@Component({
  selector: 'app-custom-tag-dialog',
  templateUrl: './custom-tag-dialog.component.html',
  styleUrls: ['./custom-tag-dialog.component.css']
})
export class CustomTagDialogComponent implements OnInit {

  newTag: SolarSystemTagDto;
  tagColors = TagColorOptions;
  tagIcons = TagIconOptions;
  selectedDuration = 4;
  tagDurations: TagDuration[] = [
    {name: '4 Hours', duration: 4},
    {name: '12 Hours', duration: 12},
    {name: '24 Hours', duration: 24},
    {name: '72 Hours', duration: 72},
  ];

  constructor(@Inject(MAT_DIALOG_DATA) public data: DailogRequestData,
  public dialogRef: MatDialogRef<CustomTagDialogComponent>,
  private tagService: TagService,
  private authControl: AuthControl,
  private dataControl: DataControl) {
    this.newTag = {
      color: 'white',
      icon: 'warning',
      solarSystemId: data.data.solarSystemId,
      expiryDate: moment.utc(new Date(Date.now() + 4 * 60 * 60 * 1000).toJSON()).toISOString()
    } as SolarSystemTagDto;
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
    this.tagService.postApiTagInsert({mainToken: this.authControl.getMainToken(), body: this.newTag}).subscribe(x => {
      console.log(x);
      this.dataControl.forceMapUpdate();
      this.dialogRef.close({
        result: DialogResult.confirmed,
        data: this.data.data
      });
    });
  }

  durationSelected(value: number) {
    const newExp = new Date(Date.now() + value * 60 * 60 * 1000).toJSON();
    this.newTag.expiryDate = moment.utc(newExp).toISOString();
  }
}
