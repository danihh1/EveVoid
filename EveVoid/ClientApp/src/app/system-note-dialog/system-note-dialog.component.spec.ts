import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SystemNoteDialogComponent } from './system-note-dialog.component';

describe('SystemNoteDialogComponent', () => {
  let component: SystemNoteDialogComponent;
  let fixture: ComponentFixture<SystemNoteDialogComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SystemNoteDialogComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SystemNoteDialogComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
