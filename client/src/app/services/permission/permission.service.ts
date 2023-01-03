import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Permission } from 'src/app/shared/Permission';
import { AppConfigService } from '../app-config/app-config.service';
import { ResourceService } from '../resource/resource.service';

@Injectable({
  providedIn: 'root'
})
export class PermissionService extends ResourceService<Permission> {

  constructor(http: HttpClient, appConfigService: AppConfigService) {
    super(http, appConfigService, 'Permission');
  }
}
