/* tslint:disable */
import { ActivePilotDto } from './active-pilot-dto';
export interface MapNodeDto {
  color?: string;
  id?: string;
  name?: string;
  pilots?: Array<ActivePilotDto>;
}
