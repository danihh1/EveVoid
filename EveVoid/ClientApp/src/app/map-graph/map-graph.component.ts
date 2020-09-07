import { MapLayoutDto } from './../api/models/map-layout-dto';
import { NumberAbbreviatePipe } from './../pipes/number-abbreviate.pipe';
import { PreferencesControl } from './../control/preferences-control';
import { WormholeTypeMapDto } from './../api/models/wormhole-type-map-dto';
import { Component, OnInit, OnDestroy } from '@angular/core';
import { Router } from '@angular/router';
import { AuthControl } from '../control/auth-control';
import { MapDto, SignatureDto } from '../api/models';
import { MapService } from '../api/services';
import { Subject, interval, Subscription, combineLatest } from 'rxjs';
import { Node, Edge, ClusterNode } from '@swimlane/ngx-graph';
import { DataControl } from '../control/data-control';
import { takeUntil } from 'rxjs/operators';
import { MatDialog } from '@angular/material/dialog';
import { SignatureDialogComponent } from '../signature-dialog/signature-dialog.component';

@Component({
  selector: 'app-map-graph',
  templateUrl: './map-graph.component.html',
  styleUrls: ['./map-graph.component.css']
})
export class MapGraphComponent implements OnInit, OnDestroy {
  maps: MapDto[];
  systemObserver: Subscription;
  unsubscribe$: Subject<boolean> = new Subject();
  layoutSettings = {
    orientation: 'TB',
    edgePadding: 30,
    rankPadding: 80,
    nodePadding: 10,
  };
  nodes: Node[];
  links: Edge[];
  // clusters: ClusterNode[] = [
  //   {
  //     id: 'c1',
  //     label: this.preferencesControl.getMapSystem()?.name,
  //     childNodeIds: [this.preferencesControl.getMapSystem().solarSystemId ?
  //       this.preferencesControl.getMapSystem().solarSystemId.toString() : '']
  //   }
  // ];

  get miniMapPosition(): string {
    return this.preferencesControl.getOverlayPosition() === 'left' ? 'UpperRight' : 'UpperLeft';
  }

  get homeSystems(): MapLayoutDto[] {
    const system = this.preferencesControl.getMapSystem() ? this.preferencesControl.getMapSystem() :
    this.preferencesControl.getSelectedSystem();
    return [system];
  }

  constructor(public preferencesControl: PreferencesControl,
    private dialog: MatDialog,
    private mapService: MapService,
    private authControl: AuthControl,
    private dataControl: DataControl,
    private router: Router,
    private abbreviate: NumberAbbreviatePipe) {
      this.links = [];
      this.nodes = [];
     }

  ngOnInit(): void {
    this.dataControl.getMapUpdateObs().pipe(takeUntil(this.unsubscribe$)).subscribe(update => {
      if (update) {
        this.fetch();
        if (this.systemObserver) {
          this.systemObserver.unsubscribe();
        }
        this.systemObserver = interval(10000).subscribe(() => {
          this.fetch();
        });
      }
    });
  }

  fetch() {
    this.maps = [];
    const mapCalls = [];
    this.homeSystems.forEach(sys => {
      mapCalls.push(this.mapService.getApiMapGetMapForRootId({
        mainToken: this.authControl.getMainToken(),
        systemId: sys.solarSystemId,
        customName: sys.name,
        maxGateLevel: parseInt(this.preferencesControl.getGateCount(), 10)}));
    });
    combineLatest(mapCalls).subscribe(res => {
      this.maps = res;
      this.buildMap(res);
    });
  }

  goToSystem(systemId: number) {
    if (systemId > 10000000) {
      this.preferencesControl.setSelectedSystem({solarSystemId: systemId});
      this.dataControl.forceMapUpdate();
      //this.router.navigate(['./map/' + systemId]);
    }
  }
  ngOnDestroy() {
    if (this.systemObserver) {
      this.systemObserver.unsubscribe();
    }
    this.unsubscribe$.next(true);
    this.unsubscribe$.complete();
  }

  buildMap(newMaps: MapDto[]) {
    this.links = [];
    this.nodes = [];
    newMaps.forEach(newMap => {
      newMap.nodes.forEach(x => {
        this.nodes.push({
          id: x.id,
          label: x.name,
          data: {
            customColor: x.color,
            pilotCount: x.pilots.length, // x.pilots.length,
            pilots: x.pilots.map(p => `${p.name} ${p.shipTypeName} - ${p.shipName}`).join('\n'),
            systemType: x.systemType,
            systemTypeColor: x.systemTypeColor,
            statics: x.statics,
          }
        });
      });
      newMap.edges.forEach(x => {
        this.links.push({
          id: 'e' + x.id,
          source: x.source,
          target: x.target,
          data: {
            id: x.id,
            targetId: x.targetId,
            color: x.color,
            width: x.lineWidth,
            textcolor: x.color,
            lineType: x.lineType,
            sourceName: x.sourceName,
            targetName: x.targetName,
          },
          line: 'test'
        });
      });
    });
    this.nodes = [...this.nodes];
    this.links = [...this.links];

  }

  getTooltipForStatic(p: WormholeTypeMapDto): string {
    return `Type: ${p.name}\n Duration: ${p.duration}\n Max Jump: ${this.abbreviate.transform(p.maxJump, 2)}\n Max Mass: ${this.abbreviate.transform(p.maxMass, 2)}\n LeadsTo: ${p.leadsTo}\n`;
  }
  openSigDialog(id: string) {
    if (!id || id.startsWith('g')) {
      return;
    }
    const dialogRef = this.dialog.open(SignatureDialogComponent, {
      data: {
        title: '',
        body: id,
        data: {
          id,
        },
      },
    });
  }
}
