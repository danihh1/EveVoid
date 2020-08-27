/* tslint:disable */
import { Flare } from './flare';
import { StargateDto } from './stargate-dto';
import { SolarSystemNoteDto } from './solar-system-note-dto';
import { ActivePilotDto } from './active-pilot-dto';
import { SignatureDto } from './signature-dto';
export interface SolarSystemDto {
  class?: number;
  constellaionId?: number;
  constellaionName?: string;
  flare?: Flare;
  gates?: Array<StargateDto>;
  id?: number;
  name?: string;
  notes?: Array<SolarSystemNoteDto>;
  pilots?: Array<ActivePilotDto>;
  regionId?: number;
  regionName?: string;
  security?: number;
  signatures?: Array<SignatureDto>;
  statics?: Array<string>;
  systemType?: string;
  systemTypeId?: number;
}
