import { Injectable } from '@angular/core';
import { BaseService } from 'src/services/base.service';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Rick } from '../models/rick.model';

@Injectable({
  providedIn: 'root'
})
export class GridService extends BaseService {

  constructor (
      public http: HttpClient
  ) {
      super('Rick','');
  }

  public get(): Observable<any[]>{
    return this.http.get<any[]>(this.apiEndpoint)
  }
  public getById(id) : Observable<Rick>{
    let params = new HttpParams();
    params = params.append('id', id);
    return this.http.get<Rick>(this.apiEndpoint  + `/GetById/` + id );
  }
}
