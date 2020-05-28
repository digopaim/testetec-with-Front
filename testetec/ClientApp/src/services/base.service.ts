import { Injectable, Inject } from '@angular/core';
import { environment } from 'src/environments/environment';

@Injectable()
export class BaseService {
  private apiURL: string = 'http://localhost:50664';

  protected apiEndpoint: string;
  constructor(endpoint: string, @Inject('BASE_URL') baseUrl: string) {
    this.apiEndpoint =  `/${endpoint}`;
  }
}
