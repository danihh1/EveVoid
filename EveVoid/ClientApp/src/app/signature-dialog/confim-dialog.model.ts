import { SignatureDto } from './../api/models/signature-dto';
import { MapLayoutDto } from '../api/models';
export interface DailogRequestData {
  title: string;
  body: string;
  data: any;
}

export interface DailogResponseData {
  result: DialogResult;
  data: any;
}

export enum DialogResult {
  canceld = 10,
  confirmed = 20
}

export interface SignatureDailogRequestData {
  title: string;
  body: string;
  data: SignatureDto;
}

export interface SignatureDailogResponseData {
  result: DialogResult;
  data: SignatureDto;
}

export interface TabDailogRequestData {
  title: string;
  body: string;
  data: MapLayoutDto;
}

export interface TabDailogResponseData {
  result: DialogResult;
  data: MapLayoutDto;
}

export interface AutoJumpDailogRequestData {
  title: string;
  body: string;
  data: SignatureDto[];
}

export interface AutoJumpDailogResponseData {
  result: DialogResult;
  data: SignatureDto;
}
