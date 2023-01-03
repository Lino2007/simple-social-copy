import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Category } from 'src/app/shared/Category';
import { AppConfigService } from '../app-config/app-config.service';
import { ResourceService } from '../resource/resource.service';

@Injectable({
  providedIn: 'root'
})
export class CategoryService extends ResourceService<Category> {

  constructor(http: HttpClient, appConfigService: AppConfigService) {
    super(http, appConfigService, 'Category');
  }

  testGet() {
    return this.getAll();
  }
}
