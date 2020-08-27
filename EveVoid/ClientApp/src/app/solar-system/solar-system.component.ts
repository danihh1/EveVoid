import { SolarSystemDto } from './../api/models/solar-system-dto';
import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-solar-system',
  templateUrl: './solar-system.component.html',
  styleUrls: ['./solar-system.component.css']
})
export class SolarSystemComponent implements OnInit {

  @Input() solarSystem: SolarSystemDto;

  constructor() { }

  ngOnInit(): void {
  }

}
