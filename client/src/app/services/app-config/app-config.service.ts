import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { AppConfig, configDefaults } from 'src/app/shared/AppConfig';

@Injectable({
  providedIn: 'root'
})
export class AppConfigService {
  private appConfig!: AppConfig;

  constructor(private http: HttpClient) { }

  loadAppConfig(): Promise<AppConfig> {
    return new Promise<AppConfig>(resolve => {
      this.http.get<AppConfig>('/assets/appsettings.json').subscribe({
        next: (config) => {
          this.appConfig = { ...config };
          resolve(this.appConfig);
        },
        error: (e) => {
          console.error((e as Error).message);
          console.info("Using default configuration");
          this.appConfig = configDefaults;
          resolve(this.appConfig);
        }
      });
    });
  }

  getAppConfig(): AppConfig {
    return this.appConfig;
  }
}
