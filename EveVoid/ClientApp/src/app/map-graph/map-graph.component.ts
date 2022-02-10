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
import { timer } from 'rxjs/internal/observable/timer';

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
    edgePadding: 15,
    rankPadding: 40,
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
    timer(0, 10000).pipe(
      takeUntil(this.unsubscribe$)
    ).subscribe(() => {
      this.fetch();
    });
    this.dataControl.getMapUpdateObs().pipe(takeUntil(this.unsubscribe$)).subscribe(update => {
      if (update) {
        this.fetch();
        // if (this.systemObserver) {
        //   this.systemObserver.unsubscribe();
        // }
        // this.systemObserver = interval(10000).subscribe(() => {
        //   this.fetch();
        // });
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
            pilots: x.pilots.map(p => `${p.pilotName} - ${p.shipTypeName}`).join('\n'),
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
            targetType: x.targetType,
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
    let res = '0.1px solid gray';
    if (this.preferencesControl.getSelectedSystem().solarSystemId.toString() === id) {
      res = '0.1px solid cyan';
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
    const nameDiv = document.getElementById('NameWidth');
    nameDiv.innerHTML = node.label;
    const nameWidth = nameDiv.clientWidth + (node.data.hasStructureData ? 14 : 0);
    const sysWidth = document.getElementById('SysTypeWidth');
    sysWidth.innerHTML = node.data.systemType;
    const sysTypeWidth = sysWidth.clientWidth + (node.data.effect ? 14 : 0) + 10;
    return Math.max(nameWidth, sysTypeWidth, node.data.tags.length * 14) + 10;
  }

  getEffectIcon(effect: any): string {
    return this.effectIcons.find(x => x.name === effect).icon;
  }
  getEffectColor(effect: any): string {
    return this.effectIcons.find(x => x.name === effect).color;
  }

  getBackground(node: any): string {
    let bg = 'background: ';
    if (node.data.tags && node.data.tags.length > 0) {
      bg += 'radial-gradient(';
      bg += this.multHexColor(this.colourNameToHex(node.data.tags[0].color), 0.5) + ', ';
      bg +=  node.data.customColor + ');';
      return bg;
    }
    bg += node.data.customColor + ';';
    return bg;
  }

  get connectionStyle(): string {
    return this.preferencesControl.getConnectionStyle();
  }

  colourNameToHex(colour) {
    const colours = {'aliceblue': '#f0f8ff', 'antiquewhite': '#faebd7', 'aqua': '#00ffff', 'aquamarine': '#7fffd4', 'azure': '#f0ffff',
    'beige': '#f5f5dc', 'bisque': '#ffe4c4', 'black': '#000000', 'blanchedalmond': '#ffebcd', 'blue': '#0000ff', 'blueviolet': '#8a2be2', 'brown': '#a52a2a', 'burlywood': '#deb887',
    'cadetblue': '#5f9ea0', 'chartreuse': '#7fff00', 'chocolate': '#d2691e', 'coral': '#ff7f50', 'cornflowerblue': '#6495ed', 'cornsilk': '#fff8dc', 'crimson': '#dc143c', 'cyan': '#00ffff',
    'darkblue': '#00008b', 'darkcyan': '#008b8b', 'darkgoldenrod': '#b8860b', 'darkgray': '#a9a9a9', 'darkgreen': '#006400', 'darkkhaki': '#bdb76b', 'darkmagenta': '#8b008b', 'darkolivegreen': '#556b2f',
    'darkorange': '#ff8c00', 'darkorchid': '#9932cc', 'darkred': '#8b0000', 'darksalmon': '#e9967a', 'darkseagreen': '#8fbc8f', 'darkslateblue': '#483d8b', 'darkslategray': '#2f4f4f', 'darkturquoise': '#00ced1',
    'darkviolet': '#9400d3', 'deeppink': '#ff1493', 'deepskyblue': '#00bfff', 'dimgray': '#696969', 'dodgerblue': '#1e90ff',
    'firebrick': '#b22222', 'floralwhite': '#fffaf0', 'forestgreen': '#228b22', 'fuchsia': '#ff00ff',
    'gainsboro': '#dcdcdc', 'ghostwhite': '#f8f8ff', 'gold': '#ffd700', 'goldenrod': '#daa520', 'gray': '#808080', 'green': '#008000', 'greenyellow': '#adff2f',
    'honeydew': '#f0fff0', 'hotpink': '#ff69b4',
    'indianred ': '#cd5c5c', 'indigo': '#4b0082', 'ivory': '#fffff0', 'khaki': '#f0e68c',
    'lavender': '#e6e6fa', 'lavenderblush': '#fff0f5', 'lawngreen': '#7cfc00', 'lemonchiffon': '#fffacd', 'lightblue': '#add8e6', 'lightcoral': '#f08080', 'lightcyan': '#e0ffff', 'lightgoldenrodyellow': '#fafad2',
    'lightgrey': '#d3d3d3', 'lightgreen': '#90ee90', 'lightpink': '#ffb6c1', 'lightsalmon': '#ffa07a', 'lightseagreen': '#20b2aa', 'lightskyblue': '#87cefa', 'lightslategray': '#778899', 'lightsteelblue': '#b0c4de',
    'lightyellow': '#ffffe0', 'lime': '#00ff00', 'limegreen': '#32cd32', 'linen': '#faf0e6',
    'magenta': '#ff00ff', 'maroon': '#800000', 'mediumaquamarine': '#66cdaa', 'mediumblue': '#0000cd', 'mediumorchid': '#ba55d3', 'mediumpurple': '#9370d8', 'mediumseagreen': '#3cb371', 'mediumslateblue': '#7b68ee',
    'mediumspringgreen': '#00fa9a', 'mediumturquoise': '#48d1cc', 'mediumvioletred': '#c71585', 'midnightblue': '#191970', 'mintcream': '#f5fffa', 'mistyrose': '#ffe4e1', 'moccasin': '#ffe4b5',
    'navajowhite': '#ffdead', 'navy': '#000080',
    'oldlace': '#fdf5e6', 'olive': '#808000', 'olivedrab': '#6b8e23', 'orange': '#ffa500', 'orangered': '#ff4500', 'orchid': '#da70d6',
    'palegoldenrod': '#eee8aa', 'palegreen': '#98fb98', 'paleturquoise': '#afeeee', 'palevioletred': '#d87093', 'papayawhip': '#ffefd5', 'peachpuff': '#ffdab9', 'peru': '#cd853f', 'pink': '#ffc0cb', 'plum': '#dda0dd', 'powderblue': '#b0e0e6', 'purple': '#800080',
    'rebeccapurple': '#663399', 'red': '#ff0000', 'rosybrown': '#bc8f8f', 'royalblue': '#4169e1',
    'saddlebrown': '#8b4513', 'salmon': '#fa8072', 'sandybrown': '#f4a460', 'seagreen': '#2e8b57', 'seashell': '#fff5ee', 'sienna': '#a0522d', 'silver': '#c0c0c0', 'skyblue': '#87ceeb', 'slateblue': '#6a5acd', 'slategray': '#708090', 'snow': '#fffafa', 'springgreen': '#00ff7f', 'steelblue': '#4682b4',
    'tan': '#d2b48c', 'teal': '#008080', 'thistle': '#d8bfd8', 'tomato': '#ff6347', 'turquoise': '#40e0d0',
    'violet': '#ee82ee',
    'wheat': '#f5deb3', 'white': '#ffffff', 'whitesmoke': '#f5f5f5',
    'yellow': '#ffff00', 'yellowgreen': '#9acd32'};

    if (typeof colours[colour.toLowerCase()] !== 'undefined') {
        return colours[colour.toLowerCase()];
    }

    return false;
  }

  multHexColor(color: string, mult: number) {
    if (color[0] === '#') {
      color = color.substring(1);
    }
    const rgb = parseInt(color, 16);
    const red = (rgb >> 16) & 0xFF * mult;
    const green = (rgb >> 8) & 0xFF * mult;
    const blue = rgb & 0xFF * mult;

    return 'rgb(' + red + ', ' + green + ', ' + blue + ')';
  }
}
