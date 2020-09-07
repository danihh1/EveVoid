import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AutoJumpDialogComponent } from './auto-jump-dialog.component';

describe('AutoJumpDialogComponent', () => {
  let component: AutoJumpDialogComponent;
  let fixture: ComponentFixture<AutoJumpDialogComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AutoJumpDialogComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AutoJumpDialogComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
