/* tslint:disable */
import { MapEdgeDto } from './map-edge-dto';
import { MapNodeDto } from './map-node-dto';
export interface MapDto {
  edges?: Array<MapEdgeDto>;
  nodes?: Array<MapNodeDto>;
  rootNodeId?: number;
}
