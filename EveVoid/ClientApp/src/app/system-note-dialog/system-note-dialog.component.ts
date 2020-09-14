import { SolarSystemNoteDto } from './../api/models/solar-system-note-dto';
import { Component, Inject, OnInit } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { AuthControl } from '../control/auth-control';
import { DataControl } from '../control/data-control';
import { DailogRequestData, DialogResult } from '../signature-dialog/confim-dialog.model';
import * as DocumentEditor from '@ckeditor/ckeditor5-build-decoupled-document';
import { SolarSystemNoteService } from '../api/services';

@Component({
  selector: 'app-system-note-dialog',
  templateUrl: './system-note-dialog.component.html',
  styleUrls: ['./system-note-dialog.component.css']
})
export class SystemNoteDialogComponent implements OnInit {

note: SolarSystemNoteDto;

public Editor = DocumentEditor;
  constructor(@Inject(MAT_DIALOG_DATA) public data: DailogRequestData,
  public dialogRef: MatDialogRef<SystemNoteDialogComponent>,
  private authControl: AuthControl,
  private dataControl: DataControl,
  private solarSystemNoteService: SolarSystemNoteService) {
    this.note = data.data;
   }
   public onReady(editor) {
    editor.ui.view.editable.element.parentElement.insertBefore(
      editor.ui.view.toolbar.element,
      editor.ui.view.editable.element
    );

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
    if (this.note.id > 0) {
      this.solarSystemNoteService.putApiSolarSystemNoteUpdate({mainToken: this.authControl.getMainToken(), body: this.note})
      .subscribe(x => {
        this.dataControl.forceMapUpdate();
        this.dialogRef.close({
          result: DialogResult.confirmed,
          data: this.data.data
        });
      });
    } else {
      this.solarSystemNoteService.postApiSolarSystemNoteInsert({mainToken: this.authControl.getMainToken(), body: this.note})
      .subscribe(x => {
        this.dataControl.forceMapUpdate();
        this.dialogRef.close({
          result: DialogResult.confirmed,
          data: this.data.data
        });
      });
    }
  }
}
