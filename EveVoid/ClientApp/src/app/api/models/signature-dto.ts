/* tslint:disable */
import { JumpDto } from './jump-dto';
import { MassIndicator } from './mass-indicator';
import { SignatureType } from './signature-type';
import { TimeRemainingIndicator } from './time-remaining-indicator';
export interface SignatureDto {
  creationDate?: string;
  description?: string;
  destinationSystemId?: number;
  destinationSystemName?: string;
  destinationWormholeType?: string;
  expiryDate?: string;
  id?: number;
  jumps?: Array<JumpDto>;
  lastUpdate?: string;
  massIndicator?: MassIndicator;
  name?: string;
  signatureId?: string;
  signatureType?: SignatureType;
  systemId?: number;
  timeRemainingIndicator?: TimeRemainingIndicator;
  totalMass?: number;
  wormholeType?: string;
  wormholeTypeId?: number;
}
