/* tslint:disable */
import { DscanShipGroupDto } from './dscan-ship-group-dto';
export interface DscanDto {
  creationDate?: string;
  dscanShipGroups?: Array<DscanShipGroupDto>;
  id?: number;
  solarSystemId?: number;
}
