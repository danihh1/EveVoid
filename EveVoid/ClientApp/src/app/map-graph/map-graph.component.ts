import { Component, OnInit, Input, OnDestroy } from '@angular/core';
import { Router } from '@angular/router';
import { AuthControl } from '../control/auth-control';
import { MainCharacterDto, MapDto } from '../api/models';
import { MapService } from '../api/services';
import { Subject, interval, Subscription, combineLatest } from 'rxjs';
import { Node, Edge, NodeDimension, NodePosition, ClusterNode } from '@swimlane/ngx-graph';

@Component({
  selector: 'app-map-graph',
  templateUrl: './map-graph.component.html',
  styleUrls: ['./map-graph.component.css']
})
export class MapGraphComponent implements OnInit, OnDestroy {
  @Input() mainChar: MainCharacterDto;
  maps: MapDto[];
  update$: Subject<boolean> = new Subject();
  systemObserver: Subscription;
  layoutSettings = {
    orientation: 'TB',
    edgePadding: 30,
    rankPadding: 60,
    nodePadding: 10
  };
  nodes: Node[];
  links: Edge[];
  clusters: ClusterNode[] = [
    {
      id: 'c1',
      label: '',
      childNodeIds: ['30000142', '30002187']
    }
  ];

  get homeSystems(): number[] {
    return [30000142, 30002187];
  }

  constructor(private mapService: MapService,
    private authControl: AuthControl,
    private router: Router) {
      // this.map = {} as MapDto;
      // this.map.edges = [];
      // this.map.nodes = [];
      this.links = [];
      this.nodes = [];
     }

  ngOnInit(): void {
    this.systemObserver = interval(5000).subscribe(() => {
        this.fetch();
      });
  }

  fetch() {
    this.maps = [];
    const mapCalls = [];
    this.homeSystems.forEach(sys => {
      mapCalls.push(this.mapService.getApiMapGetMapForRootId({mainToken: this.authControl.getMainToken(), systemId: sys, maxGateLevel: 1}));
    });
    combineLatest(mapCalls).subscribe(res => {
      this.maps = res;
      // this.nodes = [...res.nodes] as Node[];
      // this.links = [...res.links] as Edge[];
      this.buildMap(res);
    });
  }

  goToSystem(systemId: number) {
    this.router.navigate(['./map/' + systemId]);
  }
  ngOnDestroy() {
    this.systemObserver.unsubscribe();
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
            pilots: x.pilots.map(p => `${p.name} ${p.shipTypeName} - ${p.shipName}`).join('\n')
          }
        });
      });
      newMap.edges.forEach(x => {
        this.links.push({
          id: 'e' + x.id,
          source: x.source,
          target: x.target,
          label: x.name,
          data: {
            color: x.color,
            width: 4,
            textcolor: x.color
          }
        });
      });
    });
    this.nodes = [...this.nodes];
    this.links = [...this.links];
    // this.update$.next(true);
  }
}
