/* tslint:disable */
import { EsiCharacterDto } from './esi-character-dto';
export interface MainCharacterDto {
  allianceId?: number;
  allianceName?: string;
  corporationId?: number;
  corporationName?: string;
  esiCharacterDtos?: Array<EsiCharacterDto>;
  id?: number;
  name?: string;
}
