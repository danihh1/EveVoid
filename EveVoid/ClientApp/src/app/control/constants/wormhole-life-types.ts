import { TimeRemainingIndicator } from './../../api/models/time-remaining-indicator';

interface WormholeLifeType {
  id: TimeRemainingIndicator;
  name: string;
}
export const WormholeLifeTypes: WormholeLifeType[] = [
  {id: 0, name: 'Stable'},
  {id: 1, name: 'End of Life'}
];
