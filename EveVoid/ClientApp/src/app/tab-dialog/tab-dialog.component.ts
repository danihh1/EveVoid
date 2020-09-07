import { Component, OnInit, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { TabDailogRequestData, DialogResult } from '../signature-dialog/confim-dialog.model';
import { FormControl } from '@angular/forms';
import { Observable } from 'rxjs';
import { SolarSystemDto } from '../api/models';
import { SolarySystemService } from '../api/services';
import { debounceTime, distinctUntilChanged, startWith, switchMap, map } from 'rxjs/operators';

@Component({
  selector: 'app-tab-dialog',
  templateUrl: './tab-dialog.component.html',
  styleUrls: ['./tab-dialog.component.css']
})
export class TabDialogComponent implements OnInit {

  tabSystemControl = new FormControl();
  filteredSystems: Observable<SolarSystemDto[]>;
  fetchedSystems = [];

  constructor(@Inject(MAT_DIALOG_DATA) public data: TabDailogRequestData,
  public dialogRef: MatDialogRef<TabDialogComponent>,
  private solarSystemService: SolarySystemService) { }

  ngOnInit(): void {
    this.filteredSystems = this.tabSystemControl.valueChanges.pipe(
      debounceTime(300),
      distinctUntilChanged(),
      startWith(''),
      switchMap(value => {
        return this.solarSystemService.getApiSolarySystemFind(value); }
    )).pipe(
      debounceTime(300),
      distinctUntilChanged(),
      map(result => {
        this.fetchedSystems = result;
        return result;
      }));
  }
  tabSystemSelected(name: string){
    const selected = this.fetchedSystems.find(x => x.name === name);
    this.data.data.solarSystemId = selected.id;
    this.data.data.solarSystemName = selected.name;
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
    this.dialogRef.close({
      result: DialogResult.confirmed,
      data: this.data.data
    });
  }
}
