import { Crud } from "./crud.interface";
import { Observable } from "rxjs/Observable";
import { BaseService } from "./base.service";

import 'rxjs/add/operator/catch';

export class CrudService<T, ID> extends BaseService implements Crud<T, ID> {

  save(t: T): Observable<T> {
    return this.http.post<T>(this.base, t);
  }

  update(t: T): Observable<T> {
    return this.http.put<T>(this.base, t);
  }

  findOne(id: ID): Observable<T> {
    return this.http.get<T>(this.base + '/' + id);
  }

  findAll(): Observable<T[]> {
    return this.http.get<T[]>(this.base);
  }

  delete(id: ID): Observable<T> {
    return this.http.delete<T>(this.base + '/' + id);
  }
}
