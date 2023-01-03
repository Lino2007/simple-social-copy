export interface AppConfig {
    apiUrl: string;
}

export const configDefaults: AppConfig = {
    apiUrl: 'https://localhost:7289/api'
};