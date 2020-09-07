import { MassIndicator } from './../../api/models/mass-indicator';

interface MassType {
  id: MassIndicator;
  name: string;
}
export const MassTypes: MassType[] = [
  {id: 0, name: 'Stable'},
  {id: 10, name: 'Destabilized'},
  {id: 20, name: 'Verge of Collapse'}
];
