import { PreferencesControl } from './../control/preferences-control';
import { TabDailogResponseData, DialogResult } from './../signature-dialog/confim-dialog.model';
import { AuthControl } from './../control/auth-control';
import { MapLayoutDto } from './../api/models/map-layout-dto';
import { Component, OnInit, Input, OnDestroy } from '@angular/core';
import {CdkDragDrop, moveItemInArray} from '@angular/cdk/drag-drop';
import { CharacterService } from '../api/services';
import {  } from '../api/models';
import { MatDialog } from '@angular/material/dialog';
import { TabDialogComponent } from '../tab-dialog/tab-dialog.component';
import { DataControl } from '../control/data-control';
import { Subject } from 'rxjs';
import { takeUntil } from 'rxjs/operators';

@Component({
  selector: 'app-map-tab-layout',
  templateUrl: './map-tab-layout.component.html',
  styleUrls: ['./map-tab-layout.component.css']
})
export class MapTabLayoutComponent implements OnInit, OnDestroy {
  tabs: MapLayoutDto[] = [];
  unsubscribe$: Subject<boolean> = new Subject();
  constructor(private authControl: AuthControl,
    private characterService: CharacterService,
    private preferencesControl: PreferencesControl,
    private dialog: MatDialog,
    private dataControl: DataControl) { }

  ngOnInit(): void {
    this.dataControl.getmainCharObs().pipe(takeUntil(this.unsubscribe$)).subscribe(mainChar => {
      if (mainChar) {
        this.tabs = mainChar.mapLayouts;
      }
      // this.dataControl.forceMapUpdate();
    });
    // this.characterService.postApiCharacterUpdateMapLayouts({mainToken: this.authControl.getMainToken(), body: this.tabs })
    // .subscribe(x => {
    //   console.log('success');
    // });
  }

  ngOnDestroy() {
    this.unsubscribe$.next(true);
    this.unsubscribe$.complete();
  }

  drop(event: CdkDragDrop<MapLayoutDto[]>) {
    moveItemInArray(this.tabs, event.previousIndex, event.currentIndex);
  }

  tabDialog(id: number) {
    let tab = {} as MapLayoutDto;
    if (id > 0) {
      tab = this.tabs.find(x => x.id === id);
    }
    const dialogRef = this.dialog.open(TabDialogComponent, {
      data: {
        title: '',
        body: '',
        data: {
          name: tab.name,
          solarSystemName: tab.solarSystemName,
          solarSystemId: tab.solarSystemId,
          id,
          order: this.tabs.length
        } as MapLayoutDto,
      },
    });
    dialogRef.afterClosed()
      .subscribe((response: TabDailogResponseData) => {
        if (response) {
          if (response.result === DialogResult.confirmed) {
            if (id === -1) {
              this.tabs.push(response.data);
            } else {
              const updateTab = this.tabs.find(x => x.id === id);
              updateTab.name = response.data.name;
              updateTab.order = response.data.order;
              updateTab.solarSystemId = response.data.solarSystemId;
              updateTab.solarSystemName = response.data.solarSystemName;
            }
            this.characterService.postApiCharacterUpdateMapLayouts({mainToken: this.authControl.getMainToken(), body: this.tabs })
              .subscribe(x => {
                this.tabs = x;
            });
          } else {
            if (response.result === DialogResult.canceld && id !== -1) {
              this.tabs.splice(this.tabs.findIndex(x => x.id === id), 1);
              this.characterService.postApiCharacterUpdateMapLayouts({mainToken: this.authControl.getMainToken(), body: this.tabs })
              .subscribe(x => {
                this.tabs = x;
            });
            }
          }
        }
      });
  }

  getCurrentSystem(): MapLayoutDto {
    return this.preferencesControl.getMapSystem();
  }

  changeMapSystem(tab: MapLayoutDto) {
    if (this.preferencesControl.getMapSystem() && this.preferencesControl.getMapSystem().solarSystemId === tab.solarSystemId) {
      this.preferencesControl.setMapSystem(null);
    } else {
      this.preferencesControl.setMapSystem(tab);
    }
    this.dataControl.forceMapUpdate();
  }
}
