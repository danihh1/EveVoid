/* tslint:disable */
import { RouteDto } from './route-dto';
export interface FavoriteDistanceDto {
  distanceInJumps?: number;
  route?: Array<RouteDto>;
  systemId?: number;
  systemName?: string;
}
