import { Observable } from "rxjs/Observable";

export interface Crud <T, ID> {
  save(t: T): Observable<T>;
  update(t: T): Observable<T>;
  findOne(id: ID): Observable<T>;
  findAll(): Observable<T[]>;
  delete(id: ID): Observable<T>;
}
