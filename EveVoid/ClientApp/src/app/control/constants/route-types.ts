import { StringifyOptions } from "querystring";

interface RouteType {
  id: string;
  name: string;
}
export const RouteTypes: RouteType[] = [
  {id: '0', name: 'Shortest'},
  {id: '1', name: 'Prefer Hi-Sec'},
  {id: '2', name: 'Prefer J-Space'},
  {id: '3', name: 'Prefer Low/Null'}
];
