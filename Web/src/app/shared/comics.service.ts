import { Injectable } from '@angular/core';
import { HttpClient, HttpResponse, HttpHeaders } from '@angular/common/http';
import { Router } from '@angular/router';
import { Observable } from 'rxjs/Observable';
import { Subject } from 'rxjs/Subject';
import { Subscription } from 'rxjs/Subscription';

import { environment } from '../../environments/environment';
import { Comic } from './comic';

@Injectable()
export class ComicsService {
  constructor(private http: HttpClient, private router: Router) {

  }

  getComics(): Observable<[Comic]> {
    return this.http.get<[Comic]>(environment.ApiBase + '/api/comics');
  }
}
