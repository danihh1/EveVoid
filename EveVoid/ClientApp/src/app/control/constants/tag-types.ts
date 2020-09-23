export interface TagType {
  name: string;
  color: string;
  icon: string;
}
export const TagTypes: TagType[] = [
  {name: 'Danger', color: 'red', icon: 'local_fire_department'},
  {name: 'Group Up', color: 'yellow', icon: 'mediation'},
  {name: 'Target', color: 'orange', icon: 'gps_fixed'},
  {name: 'Safe', color: 'cyan', icon: 'eco'},
];

export const TagIconOptions: string[] = [
  'warning',
  'eco',
  'local_fire_department',
  'gps_fixed',
  'star',
  'navigation',
  'tour',
  'mediation'
];

export const TagColorOptions: string[] = [
  'red',
  'yellow',
  'cyan',
  'orange',
  'blueviolet',
  'chartreuse',
  'white'
];

export const EffectIcons: TagType[] = [
  {name: 'Pulsar', icon: 'flare', color: 'deepskyblue'},
  {name: 'Black Hole', icon: 'album', color: 'crimson'},
  {name: 'Cataclysmic Variable', icon: 'healing', color: 'mediumseagreen'},
  {name: 'Magnetar', icon: 'filter_tilt_shift', color: 'peru'},
  {name: 'Red Giant', icon: 'motion_photos_on', color: 'red'},
  {name: 'Wolf-Rayet Star', icon: 'donut_small', color: 'khaki'}
];
