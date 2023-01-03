import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Report } from 'src/app/shared/Report';
import { AppConfigService } from '../app-config/app-config.service';
import { ResourceService } from '../resource/resource.service';

@Injectable({
  providedIn: 'root'
})
export class ReportService extends ResourceService<Report> {

  constructor(http: HttpClient, appConfigService: AppConfigService) {
    super(http, appConfigService, 'Report');
  }
}
