import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SystemDScanComponent } from './system-d-scan.component';

describe('SystemDScanComponent', () => {
  let component: SystemDScanComponent;
  let fixture: ComponentFixture<SystemDScanComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SystemDScanComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SystemDScanComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
