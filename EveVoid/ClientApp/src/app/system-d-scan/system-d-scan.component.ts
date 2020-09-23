import { DscanDto } from './../api/models/dscan-dto';
import { Component, Input, OnInit, ViewChild } from '@angular/core';
import { animate, state, style, transition, trigger } from '@angular/animations';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';

@Component({
  selector: 'app-system-d-scan',
  templateUrl: './system-d-scan.component.html',
  styleUrls: ['./system-d-scan.component.css'],
  animations: [
    trigger('detailExpand', [
      state('collapsed', style({height: '0px', minHeight: '0'})),
      state('expanded', style({height: '*'})),
      transition('expanded <=> collapsed', animate('225ms cubic-bezier(0.4, 0.0, 0.2, 1)')),
    ]),
  ],
})
export class SystemDScanComponent implements OnInit {

  @Input() set dscans(val: DscanDto[]) {
    this.dataSource = new MatTableDataSource(val);
    this.dataSource.sort = this.sort;
  }
  @ViewChild(MatSort) sort: MatSort;
  dataSource = new MatTableDataSource([]);
  columnsToDisplay = ['creationDate', 'shipCount', 'actions'];
  expandedElement: DscanDto | null;

  constructor() { }

  ngOnInit(): void {
  }
  deleteDscan(id: number) {

  }
  totalShipCount(dto: DscanDto): number {
    const tot = dto.dscanShipGroups.reduce((sum, current) => sum + current.groupCount, 0);
    return tot;
  }
}
