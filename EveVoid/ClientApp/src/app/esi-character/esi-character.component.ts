import { EsiCharacterDto } from './../api/models/esi-character-dto';
import { Component, OnInit, Input } from '@angular/core';
import { ImageControl } from '../control/image-control';

@Component({
  selector: 'app-esi-character',
  templateUrl: './esi-character.component.html',
  styleUrls: ['./esi-character.component.css']
})
export class EsiCharacterComponent implements OnInit {
  @Input() esiChar: EsiCharacterDto;
  portraitSize = 64;
  get portrait(): string {
    return this.imageControl.getPortraitForCharacter(this.esiChar.id, this.portraitSize);
  }
  constructor(private imageControl: ImageControl) { }

  ngOnInit() {
  }

}
