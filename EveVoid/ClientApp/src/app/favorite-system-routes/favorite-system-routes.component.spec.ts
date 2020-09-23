import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FavoriteSystemRoutesComponent } from './favorite-system-routes.component';

describe('FavoriteSystemRoutesComponent', () => {
  let component: FavoriteSystemRoutesComponent;
  let fixture: ComponentFixture<FavoriteSystemRoutesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FavoriteSystemRoutesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FavoriteSystemRoutesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
