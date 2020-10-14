import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MapLayoutsComponent } from './map-layouts.component';

describe('MapLayoutsComponent', () => {
  let component: MapLayoutsComponent;
  let fixture: ComponentFixture<MapLayoutsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MapLayoutsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MapLayoutsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
