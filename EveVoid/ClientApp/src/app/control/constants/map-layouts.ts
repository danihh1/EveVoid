
export interface MapLayout {
  id: string;
  name: string;
  tooltip: string;
}
export const MapLayouts: MapLayout[] = [
  {id: 'dagre', name: 'Tree', tooltip: 'Thin deep chains'},
  {id: 'pavlo', name: 'Circle', tooltip: 'Exponential chains'},
  {id: 'void', name: 'Spiral', tooltip: 'A mix of both (might overlap)'}
];
