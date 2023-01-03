import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { RolePermission } from 'src/app/shared/RolePermission';
import { AppConfigService } from '../app-config/app-config.service';
import { ResourceService } from '../resource/resource.service';

@Injectable({
  providedIn: 'root'
})
export class RolePermissionService extends ResourceService<RolePermission> {

  constructor(http: HttpClient, appConfigService: AppConfigService) {
    super(http, appConfigService, 'RolePermission');
  }
}
