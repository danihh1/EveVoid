import { CustomTagDialogComponent } from './../custom-tag-dialog/custom-tag-dialog.component';
import { SolarSystemTagDto } from './../api/models/solar-system-tag-dto';
import { MapLayoutDto } from './../api/models/map-layout-dto';
import { NumberAbbreviatePipe } from './../pipes/number-abbreviate.pipe';
import { PreferencesControl } from './../control/preferences-control';
import { WormholeTypeMapDto } from './../api/models/wormhole-type-map-dto';
import { Component, OnInit, OnDestroy, ViewChild } from '@angular/core';
import { Router } from '@angular/router';
import { AuthControl } from '../control/auth-control';
import { MapDto, SignatureDto } from '../api/models';
import { MapService, TagService } from '../api/services';
import { Subject, interval, Subscription, combineLatest } from 'rxjs';
import { Node, Edge, ClusterNode, Alignment } from '@swimlane/ngx-graph';
import { DataControl } from '../control/data-control';
import { takeUntil } from 'rxjs/operators';
import { MatDialog } from '@angular/material/dialog';
import { SignatureDialogComponent } from '../signature-dialog/signature-dialog.component';
import { TagTypes, TagType, EffectIcons } from '../control/constants/tag-types';
import * as moment from 'moment';
import { VoidLayout } from '../control/void-layout';
import { PavloLayout } from '../control/pavlo-layout';

@Component({
  selector: 'app-map-graph',
  templateUrl: './map-graph.component.html',
  styleUrls: ['./map-graph.component.css']
})
export class MapGraphComponent implements OnInit, OnDestroy {
  maps: MapDto[];
  systemObserver: Subscription;
  unsubscribe$: Subject<boolean> = new Subject();
  center$: Subject<boolean> = new Subject();
  update$: Subject<boolean> = new Subject();
  firstLoad = true;
  tags = TagTypes;
  effectIcons = EffectIcons;
  layoutSettings = {
    orientation: 'TB',
    edgePadding: 30,
    rankPadding: 80,
    nodePadding: 10,
  };
  nodes: Node[];
  links: Edge[];
  voidLayout = new VoidLayout();
  pavloLayout = new PavloLayout();

  get mapLayout(): string {
    return this.preferencesControl.getMapLayout();
  }
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
    private tagService: TagService,
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
      // this.router.navigate(['./map/' + systemId]);
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
    const newLinks = [];
    const newNodes = [];
    newMaps.forEach(newMap => {
      newMap.nodes.forEach(x => {
        newNodes.push({
          id: x.id,
          label: x.name,
          data: {
            customColor: x.color,
            pilotCount: x.pilots.length, // x.pilots.length,
            // pilots: x.pilots.map(p => `${p.name} ${p.shipTypeName} - ${p.shipName}`).join('\n'),
            pilots: x.pilots.map(p => `${p.name} - ${p.shipTypeName}`).join('\n'),
            systemType: x.systemType,
            systemTypeColor: x.systemTypeColor,
            statics: x.statics,
            tags: x.tags,
            effect: x.wormholeEffect,
            hasStructureData: x.hasStructureData,
            rank: x.rank
          }
        });
      });
      newMap.edges.forEach(x => {
        newLinks.push({
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
        });
      });
    });
    this.nodes = [...newNodes];
    this.links = [...newLinks];
    // this.update$.next(true);
    if (this.firstLoad) {
      this.center$.next(true);
      this.firstLoad = false;
    }
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

  getBorder(id: string): string {
    let res = '0.5px solid black';
    if (this.preferencesControl.getSelectedSystem().solarSystemId.toString() === id) {
      res = '0.5px solid cyan';
    }
    return res;
  }

  isCharHere(id: string): boolean {
    const charLocations = this.dataControl.getCharLocations();
    return charLocations.some(x => x === id);
  }

  addTag(systemId: string, tag: TagType) {
    const newTag = {
      color: tag.color,
      name: tag.name,
      solarSystemId: parseInt(systemId, 10),
      icon: tag.icon,
      expiryDate: moment.utc(new Date(Date.now() + 4 * 60 * 60 * 1000).toJSON()).toISOString()
    } as SolarSystemTagDto;
    this.tagService.postApiTagInsert({mainToken: this.authControl.getMainToken(), body: newTag}).subscribe(x => {
      this.dataControl.forceMapUpdate();
    }, err => {
      console.error(err);
    });
  }

  newTagDialog(systemId: string) {
    this.dialog.open(CustomTagDialogComponent, {
      data: {
        title: '',
        body: '',
        data: {
          solarSystemId: parseInt(systemId, 10)
        }
      },
    });
  }

  getNodeWidth(node: any): number {
    return Math.max(node.label.length > 5 ? (node.label.length * 11) + 24 : 0, 90, node.data.tags.length * 23);
  }

  getEffectIcon(effect: any): string {
    return this.effectIcons.find(x => x.name === effect).icon;
  }
  getEffectColor(effect: any): string {
    return this.effectIcons.find(x => x.name === effect).color;
  }
}
