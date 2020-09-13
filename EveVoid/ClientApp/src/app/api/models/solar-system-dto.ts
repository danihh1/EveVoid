/* tslint:disable */
import { StargateDto } from './stargate-dto';
import { SolarSystemNoteDto } from './solar-system-note-dto';
import { ActivePilotDto } from './active-pilot-dto';
import { SignatureDto } from './signature-dto';
import { SolarSystemStructureDto } from './solar-system-structure-dto';
import { SolarSystemTagDto } from './solar-system-tag-dto';
export interface SolarSystemDto {
  class?: number;
  constellaionId?: number;
  constellaionName?: string;
  gates?: Array<StargateDto>;
  id?: number;
  isFavorite?: boolean;
  name?: string;
  notes?: Array<SolarSystemNoteDto>;
  pilots?: Array<ActivePilotDto>;
  regionId?: number;
  regionName?: string;
  security?: number;
  signatures?: Array<SignatureDto>;
  statics?: Array<string>;
  structures?: Array<SolarSystemStructureDto>;
  systemType?: string;
  systemTypeId?: number;
  tags?: Array<SolarSystemTagDto>;
}
