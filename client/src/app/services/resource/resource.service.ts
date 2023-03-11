import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { ApiEntity } from 'src/app/shared/BaseEntity';
import { AppConfigService } from '../app-config/app-config.service';

export abstract class ResourceService<T extends ApiEntity> {
  protected apiUrl: string;
  protected fullUrl: string;

  constructor(protected http: HttpClient, protected appConfigService: AppConfigService, protected resEndpoint: string) {
    this.apiUrl = appConfigService.getAppConfig().apiUrl;
    this.fullUrl = `${this.apiUrl}/${this.resEndpoint}`;
  }

  getAll(): Observable<T[]> {
    return this.http.get<T[]>(this.fullUrl);
  }

  getById(id: string): Observable<T> {
    return this.http.get<T>(`${this.fullUrl}/${id}`);
  }

  create(item: Omit<T, 'id'>, endpointPath: string = this.fullUrl): Observable<T> {
    if (endpointPath !== this.fullUrl) {
      endpointPath = this.fullUrl + endpointPath;
    }
    return this.http.post<T>(endpointPath, item);
  }

  update(item: T) {
    return this.http.patch<T>(this.fullUrl, item);
  }

  delete(id: string) {
    return this.http.delete<void>(`${this.fullUrl}/${id}`);
  }

  deleteItem(item: T) {
    return this.delete(item.id);
  }
}
