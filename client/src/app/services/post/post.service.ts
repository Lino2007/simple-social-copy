import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Post } from 'src/app/shared/Post';
import { AppConfigService } from '../app-config/app-config.service';
import { ResourceService } from '../resource/resource.service';

@Injectable({
  providedIn: 'root'
})
export class PostService extends ResourceService<Post>  {

  constructor(http: HttpClient, appConfigService: AppConfigService) {
    super(http, appConfigService, 'Post');
  }
}
