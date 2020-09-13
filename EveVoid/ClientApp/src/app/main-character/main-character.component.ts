import { PreferencesControl } from './../control/preferences-control';
import { DataControl } from './../control/data-control';
import { ImageControl } from './../control/image-control';
import { Component, OnInit, Input } from '@angular/core';
import { MainCharacterDto, SolarSystemDto } from '../api/models';
import { FormControl } from '@angular/forms';
import { Observable } from 'rxjs';
import { SolarySystemService } from '../api/services';
import { debounceTime, distinctUntilChanged, startWith, switchMap, map } from 'rxjs/operators';

@Component({
  selector: 'app-main-character',
  templateUrl: './main-character.component.html',
  styleUrls: ['./main-character.component.css']
})
export class MainCharacterComponent implements OnInit {

  @Input() mainChar: MainCharacterDto;
  portraitSize = 64;
  get portrait(): string {
    return this.imageControl.getPortraitForCharacter(this.mainChar.id, this.portraitSize);
  }
  get corpLogo(): string {
    return this.imageControl.getCorpLogo(this.mainChar.id, this.portraitSize / 2);
  }
  get allianceLogo(): string {
    return this.imageControl.getAllianceLogo(this.mainChar.id, this.portraitSize / 2);
  }

  control = new FormControl();
  filteredSystems: Observable<SolarSystemDto[]>;
  fetchedSystems: SolarSystemDto[] = [];

  constructor(private imageControl: ImageControl,
    private dataControl: DataControl,
    private preferencesControl: PreferencesControl,
    private solarSystemService: SolarySystemService) { }

  ngOnInit() {
    this.filteredSystems = this.control.valueChanges
      .pipe(
        debounceTime(300),
        distinctUntilChanged(),
        startWith(''),
        switchMap((value) => {
          return this.solarSystemService.getApiSolarySystemFind(value);
        })
      )
      .pipe(
        debounceTime(300),
        distinctUntilChanged(),
        map((result) => {
          this.fetchedSystems = result;
          return result;
        })
      );
  }

  systemSelected(name: string) {
    const selected = this.fetchedSystems.find((x) => x.name === name);
    this.preferencesControl.setSelectedSystem({solarSystemId: selected.id});
    this.dataControl.forceMapUpdate();
    this.control.setValue('');
  }
}
