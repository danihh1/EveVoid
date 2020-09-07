import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MapTabLayoutComponent } from './map-tab-layout.component';

describe('MapTabLayoutComponent', () => {
  let component: MapTabLayoutComponent;
  let fixture: ComponentFixture<MapTabLayoutComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MapTabLayoutComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MapTabLayoutComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
