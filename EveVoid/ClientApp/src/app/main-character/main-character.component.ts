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
  constructor(private imageControl: ImageControl) { }

  ngOnInit() {
  }

}
