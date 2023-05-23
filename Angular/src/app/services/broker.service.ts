import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { map, Observable, Subject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class BrokerService {
  apiUrl = 'https://localhost:7251/api';

  httpOptions = {
    headers: new HttpHeaders({
      ContentType: 'application/json',
    }),
  };

  constructor(private httpClient:HttpClient) { }

  GetAllBrokers(): Observable<any> {
    return this.httpClient
    .get(`${this.apiUrl}Broker/GetAllBrokers`)
      .pipe(map((result) => result));
  }

}
