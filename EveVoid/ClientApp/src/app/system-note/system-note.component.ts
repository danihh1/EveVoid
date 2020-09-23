import { SolarSystemNoteDto } from './../api/models/solar-system-note-dto';
import { SystemNoteDialogComponent } from './../system-note-dialog/system-note-dialog.component';
import { Component, Input, OnInit } from '@angular/core';
import * as DocumentEditor from '@ckeditor/ckeditor5-build-decoupled-document';
import { MatDialog } from '@angular/material/dialog';
import { SignatureDto } from '../api/models';
import { DataControl } from '../control/data-control';
import { SolarSystemNoteService } from '../api/services';

@Component({
  selector: 'app-system-note',
  templateUrl: './system-note.component.html',
  styleUrls: ['./system-note.component.css']
})
export class SystemNoteComponent implements OnInit {


  @Input() solarSystemId: number;
  @Input() noteList: SolarSystemNoteDto[];

  htmlText = '';
  public Editor = DocumentEditor;

  constructor(private dialog: MatDialog,
    private dataControl: DataControl,
    private solarSystemNoteService: SolarSystemNoteService) {

    }
  public onReady(editor) {
    editor.ui.view.editable.element.parentElement.insertBefore(
      editor.ui.view.toolbar.element,
      editor.ui.view.editable.element
    );

  }
  ngOnInit(): void {
  }

  openNoteDialog(note: SolarSystemNoteDto) {
    if (!note) {
      note = {
        solarSystemId: this.solarSystemId,
        content: '',
        id: 0
      };
    }
    const dialogRef = this.dialog.open(SystemNoteDialogComponent, {
      data: {
        title: '',
        body: '',
        data: JSON.parse(JSON.stringify(note)),
      },
    });
  }

  deleteNote(id: number) {
    this.solarSystemNoteService.deleteApiSolarSystemNote(id)
    .subscribe(x => {
      this.dataControl.forceMapUpdate();
    });
  }
}
