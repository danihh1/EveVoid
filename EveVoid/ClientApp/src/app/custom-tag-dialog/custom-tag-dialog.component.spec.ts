import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CustomTagDialogComponent } from './custom-tag-dialog.component';

describe('CustomTagDialogComponent', () => {
  let component: CustomTagDialogComponent;
  let fixture: ComponentFixture<CustomTagDialogComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CustomTagDialogComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CustomTagDialogComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
