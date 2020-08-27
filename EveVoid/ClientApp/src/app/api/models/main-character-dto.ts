/* tslint:disable */
import { EsiCharacterDto } from './esi-character-dto';
import { MaskType } from './mask-type';
export interface MainCharacterDto {
  allianceId?: number;
  allianceName?: string;
  corporationId?: number;
  corporationName?: string;
  esiCharacterDtos?: Array<EsiCharacterDto>;
  id?: number;
  maskType?: MaskType;
  name?: string;
}
