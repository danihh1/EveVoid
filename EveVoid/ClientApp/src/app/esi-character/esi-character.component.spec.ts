import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { EsiCharacterComponent } from './esi-character.component';

describe('EsiCharacterComponent', () => {
  let component: EsiCharacterComponent;
  let fixture: ComponentFixture<EsiCharacterComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EsiCharacterComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EsiCharacterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
