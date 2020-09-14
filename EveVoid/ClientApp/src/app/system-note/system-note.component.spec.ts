import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SystemNoteComponent } from './system-note.component';

describe('SystemNoteComponent', () => {
  let component: SystemNoteComponent;
  let fixture: ComponentFixture<SystemNoteComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SystemNoteComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SystemNoteComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
