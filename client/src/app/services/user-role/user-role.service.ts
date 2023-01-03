import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { UserRole } from 'src/app/shared/UserRole';
import { AppConfigService } from '../app-config/app-config.service';
import { ResourceService } from '../resource/resource.service';

@Injectable({
  providedIn: 'root'
})
export class UserRoleService extends ResourceService<UserRole> {

  constructor(http: HttpClient, appConfigService: AppConfigService) {
    super(http, appConfigService, 'UserRole');
  }
}
