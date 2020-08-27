/* tslint:disable */
import { JumpDto } from './jump-dto';
import { SignatureType } from './signature-type';
import { WormholeTypeDto } from './wormhole-type-dto';
export interface SignatureDto {
  creationDate?: string;
  expiryDate?: string;
  id?: number;
  jumps?: Array<JumpDto>;
  lastUpdate?: string;
  leadsTo?: string;
  leadsToId?: number;
  signatureId?: string;
  signatureType?: SignatureType;
  totalMass?: number;
  wormholeType?: WormholeTypeDto;
  wormholeTypeId?: number;
}
