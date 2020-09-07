import { Pipe, PipeTransform } from '@angular/core';
import * as moment from 'moment';

@Pipe({ name: 'durationLeft' })
export class DurationLeftPipe implements PipeTransform {
  transform(format: string): string {
    let res = '';
    const start = moment.utc(Date.now());
    const expiry = moment.utc(format);
    const duration = moment.duration(expiry.diff(start));
    if (duration.asSeconds() < 0) {
      res += '-';
    }
    const absDuration = Math.abs(duration.asSeconds());
    // const seconds = Math.floor(absDuration % 60) + '';
    const minutes = Math.floor((absDuration / 60) % 60) + '';
    const hours = Math.floor((absDuration / 3600)) + '';
    res += hours.padStart(2, '0') + ':' + minutes.padStart(2, '0'); // + ':' + seconds.padStart(2, '0');
    return res;
  }
}
