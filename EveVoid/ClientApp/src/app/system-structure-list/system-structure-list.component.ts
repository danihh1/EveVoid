import { SystemStructureDialogComponent } from './../system-structure-dialog/system-structure-dialog.component';
import { Component, OnInit, ViewChild, Input } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { SolarSystemStructureDto } from '../api/models';
import { SolarSystemStructureService } from '../api/services';
import { AuthControl } from '../control/auth-control';
import { DataControl } from '../control/data-control';

@Component({
  selector: 'app-system-structure-list',
  templateUrl: './system-structure-list.component.html',
  styleUrls: ['./system-structure-list.component.css']
})
export class SystemStructureListComponent implements OnInit {

  @Input() solarSystemId: number;
  @Input() set structureList(val: SolarSystemStructureDto[]) {
    this.dataSource = new MatTableDataSource(val);
    this.dataSource.sort = this.sort;
  }
  @ViewChild(MatSort) sort: MatSort;
  dataSource = new MatTableDataSource([]);

  displayedColumns = ['name', 'itemTypeName', 'description', 'lastUpdate', 'actions'];

  constructor(private dialog: MatDialog,
    private dataControl: DataControl,
    private authControl: AuthControl,
    private structureService: SolarSystemStructureService) { }

  ngOnInit(): void {
  }

  openStructureDialog(struc: SolarSystemStructureDto) {
    const dialogRef = this.dialog.open(SystemStructureDialogComponent, {
      data: {
        title: '',
        body: '',
        data: struc
      },
    });
  }

  deleteStructure(id: number) {
    this.structureService.deleteApiSolarSystemStructure(id).subscribe(x => {
      this.dataControl.forceMapUpdate();
    });
  }
}
