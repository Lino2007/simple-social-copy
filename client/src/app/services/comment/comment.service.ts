import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Comment } from 'src/app/shared/Comment';
import { AppConfigService } from '../app-config/app-config.service';
import { ResourceService } from '../resource/resource.service';

@Injectable({
  providedIn: 'root'
})
export class CommentService extends ResourceService<Comment> {

  constructor(http: HttpClient, appConfigService: AppConfigService) {
    super(http, appConfigService, 'Comment');
  }
}
