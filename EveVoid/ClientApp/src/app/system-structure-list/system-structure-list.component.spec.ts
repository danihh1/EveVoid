import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SystemStructureListComponent } from './system-structure-list.component';

describe('SystemStructureListComponent', () => {
  let component: SystemStructureListComponent;
  let fixture: ComponentFixture<SystemStructureListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SystemStructureListComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SystemStructureListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
