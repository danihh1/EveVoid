/* tslint:disable */
import { ActivePilotDto } from './active-pilot-dto';
import { WormholeTypeMapDto } from './wormhole-type-map-dto';
import { SolarSystemTagDto } from './solar-system-tag-dto';
export interface MapNodeDto {
  color?: string;
  hasStructureData?: boolean;
  id?: string;
  name?: string;
  pilots?: Array<ActivePilotDto>;
  rank?: number;
  statics?: Array<WormholeTypeMapDto>;
  systemType?: string;
  systemTypeColor?: string;
  tags?: Array<SolarSystemTagDto>;
  wormholeEffect?: string;
}
