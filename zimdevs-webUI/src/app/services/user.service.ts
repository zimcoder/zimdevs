import { Injectable }   from '@angular/core';
import { HttpClient }   from '@angular/common/http';
import { Observable }   from 'rxjs/Observable';
import 'rxjs/add/operator/map';

import { User } from '../models/User';
import { BaseService } from './base/base.service';
import { baseUrl } from '../configurations/baseUrl.config';

@Injectable()
export class UserService extends BaseService {

    
  constructor(protected http: HttpClient) {
    super(baseUrl.url + "/api/users", http)
   }
  
  getUser(): Observable<User[]> {
    return this.http.get<User[]>(this.base);
  }
}
