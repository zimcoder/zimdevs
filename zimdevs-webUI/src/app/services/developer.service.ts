import { Injectable } from '@angular/core';
import { Observable }   from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import { HttpClient } from '@angular/common/http';
import { Developer } from '../models/Developer';
import { BaseService } from './base/base.service';
import { DatePipe } from '@angular/common';
import { baseUrl } from '../configurations/baseUrl.config';

@Injectable()
export class DeveloperService extends BaseService {
  
  constructor(protected http: HttpClient) {
    super(baseUrl.url + "/api/developers", http)
  }
  getDevelopers(): Observable<Developer[]> {
    return this.http.get<Developer[]>(this.base);
  }
}
