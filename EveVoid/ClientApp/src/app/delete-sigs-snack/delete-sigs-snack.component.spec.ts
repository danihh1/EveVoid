import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DeleteSigsSnackComponent } from './delete-sigs-snack.component';

describe('DeleteSigsSnackComponent', () => {
  let component: DeleteSigsSnackComponent;
  let fixture: ComponentFixture<DeleteSigsSnackComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DeleteSigsSnackComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DeleteSigsSnackComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
