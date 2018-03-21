import { HttpClient } from "@angular/common/http";
import { Md5 } from "ts-md5";

export class BaseService {

  protected base: string;
  protected http: HttpClient;

  constructor(base: string, http: HttpClient) {
    this.base = base;
    this.http = http;
  }

  hash(word: string): string {
    return Md5.hashStr(word) + "";
  }
}
