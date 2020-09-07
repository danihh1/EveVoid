import { SignatureType } from 'src/app/api/models';

interface SigType {
  id: SignatureType;
  name: string;
}
export const SigTypes: SigType[] = [
  {id: 0, name: 'Unknown'},
  {id: 1, name: 'Wormhole'},
  {id: 2, name: 'Data'},
  {id: 3, name: 'Relic'},
  {id: 4, name: 'Gas'},
  {id: 5, name: 'Combat'},
  {id: 6, name: 'Ore'}
];
