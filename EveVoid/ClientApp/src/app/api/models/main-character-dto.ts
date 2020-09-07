/* tslint:disable */
import { EsiCharacterDto } from './esi-character-dto';
import { MapLayoutDto } from './map-layout-dto';
import { MaskType } from './mask-type';
export interface MainCharacterDto {
  allianceId?: number;
  allianceName?: string;
  corporationId?: number;
  corporationName?: string;
  esiCharacters?: Array<EsiCharacterDto>;
  id?: number;
  mapLayouts?: Array<MapLayoutDto>;
  maskType?: MaskType;
  name?: string;
}
