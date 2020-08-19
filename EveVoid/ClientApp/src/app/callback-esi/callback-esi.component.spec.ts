import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CallbackEsiComponent } from './callback-esi.component';

describe('CallbackEsiComponent', () => {
  let component: CallbackEsiComponent;
  let fixture: ComponentFixture<CallbackEsiComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CallbackEsiComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CallbackEsiComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
