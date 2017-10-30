import { Injectable } from '@angular/core';

@Injectable()

export class AppConfig {
    static IsDevMode = /localhost/.test(document.location.host);
    static ApiBase = AppConfig.IsDevMode ? 'http://localhost:4168' : '';
}
