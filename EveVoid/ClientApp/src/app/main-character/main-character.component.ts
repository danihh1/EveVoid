import { ImageControl } from './../control/image-control';
import { Component, OnInit, Input } from '@angular/core';
import { MainCharacterDto } from '../api/models';

@Component({
  selector: 'app-main-character',
  templateUrl: './main-character.component.html',
  styleUrls: ['./main-character.component.css']
})
export class MainCharacterComponent implements OnInit {

  @Input() mainChar: MainCharacterDto;
  portraitSize = 128;
  get portrait(): string {
    return this.imageControl.getPortraitForCharacter(this.mainChar.id, this.portraitSize);
  }
  get corpLogo(): string {
    return this.imageControl.getCorpLogo(this.mainChar.id, this.portraitSize/2);
  }
  get allianceLogo(): string {
    return this.imageControl.getAllianceLogo(this.mainChar.id, this.portraitSize/2);
  }
  constructor(private imageControl: ImageControl) { }

  ngOnInit() {
  }

}
