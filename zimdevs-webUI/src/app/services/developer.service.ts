import { Injectable } from '@angular/core';
import { Observable }   from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import { HttpClient } from '@angular/common/http';
import { User } from '../models/User';

@Injectable()
export class DeveloperService {

  private serviceUrl = 'https://jsonplaceholder.typicode.com/users';
  
  constructor(private http: HttpClient) { }
  
  getUser(): Observable<User[]> {
    return this.http.get<User[]>(this.serviceUrl);
  }
}
