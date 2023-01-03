import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Star } from 'src/app/shared/Star';
import { AppConfigService } from '../app-config/app-config.service';
import { ResourceService } from '../resource/resource.service';

@Injectable({
  providedIn: 'root'
})
export class StarService extends ResourceService<Star> {

  constructor(http: HttpClient, appConfigService: AppConfigService) {
    super(http, appConfigService, 'Star');
  }
}
