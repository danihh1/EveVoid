import { environment } from './../../environments/environment.prod';
import { Injectable } from '@angular/core';
@Injectable({
  // we declare that this service should be created
  // by the root application injector.
  providedIn: 'root',
})
export class ImageControl {

  getPortraitForCharacter(id: number, size: number): string {
    return environment.imageBaseUrl + '/characters/' + id + '/portrait?size=' + size;
  }
}
