import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { PersonBan } from 'src/app/shared/PersonBan';
import { AppConfigService } from '../app-config/app-config.service';
import { ResourceService } from '../resource/resource.service';

@Injectable({
  providedIn: 'root'
})
export class PersonBanService extends ResourceService<PersonBan> {

  constructor(http: HttpClient, appConfigService: AppConfigService) {
    super(http, appConfigService, 'PersonBan');
  }
}
