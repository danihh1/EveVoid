/* tslint:disable */
import { ActivePilotDto } from './active-pilot-dto';
import { WormholeTypeMapDto } from './wormhole-type-map-dto';
export interface MapNodeDto {
  color?: string;
  id?: string;
  name?: string;
  pilots?: Array<ActivePilotDto>;
  statics?: Array<WormholeTypeMapDto>;
  systemType?: string;
  systemTypeColor?: string;
}
