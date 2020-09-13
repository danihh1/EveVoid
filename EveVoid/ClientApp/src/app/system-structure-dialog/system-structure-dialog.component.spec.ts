import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SystemStructureDialogComponent } from './system-structure-dialog.component';

describe('SystemStructureDialogComponent', () => {
  let component: SystemStructureDialogComponent;
  let fixture: ComponentFixture<SystemStructureDialogComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SystemStructureDialogComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SystemStructureDialogComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
