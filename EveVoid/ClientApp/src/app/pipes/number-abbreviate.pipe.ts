import { Pipe, PipeTransform } from '@angular/core';

@Pipe({ name: 'abbreviate' })
export class NumberAbbreviatePipe implements PipeTransform {
  transform(value: number, decPlaces?: number): string {
    decPlaces = Math.pow(10, decPlaces || 0);
    const abbrev = ['K', 'M', 'B', 'T'];

    for (let i = abbrev.length - 1; i >= 0; i--) {
      const size = Math.pow(10, (i + 1) * 3);
      if (size <= value) {
        value = Math.round((value * decPlaces) / size) / decPlaces;

        if (value === 1000 && i < abbrev.length - 1) {
          value = 1;
          i++;
        }
        return value + abbrev[i] + '';
      }
    }

    return '' + value;
  }
}
