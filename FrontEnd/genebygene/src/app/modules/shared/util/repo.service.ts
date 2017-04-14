import { Injectable } from '@angular/core';
import { HttpService } from './authhttp.service';
import { Observable } from 'rxjs/Observable';
import { Headers, RequestOptions, Response } from "@angular/http";
import 'rxjs/add/operator/toPromise';
import { environment } from './../../../../environments/environment';

@Injectable()
export class RepoService {

  constructor(private http: HttpService) { }

  private getHeaders() {

    //console.log('setHeaders started');

    var headers: Headers = new Headers();
    //   {'Accept' : '*/*', 
    //   'Access-Control-Allow-Methods': 'GET', 
    //   'Access-Control-Allow-Origin': '*/*',
    //   // 'Access-Control-Allow-Credentials': 'true',
    //   // 'Access-Control-Allow-Headers': 'x-requested-with'
    // }
    headers.append('Content-Type', 'application/json');
    headers.append('Accept', 'application/json');
    //headers.append('Accept', '*/*');
    //headers.append('Access-Control-Allow-Methods', 'GET');
    //headers.append('Access-Control-Allow-Origin', '*');
    headers.append('Access-Control-Allow-Origin','*');

    return headers;
  }

  public apiHost(): string {
    return environment.apiUrl;
  }

  private prependHost(url: string): string {
    return environment.apiUrl + '/' + url;
  }

  private handleError(error: any): Promise<any> {
    console.error('An error occurred', error); // for demo purposes only
    return Promise.reject(error.message || error);
  }

  public get<T>(url: string): Promise<T[]> {
    console.log('this.prependHost(url)', this.prependHost(url));
    console.log('this.options()', this.options());
    return this.http
      .get(this.prependHost(url), this.options())
      .toPromise()
      .then(response => response.json());
  }

  public post<T>(url: string, content: T): Promise<Response> {
    return this.http
      .post(this.prependHost(url), JSON.stringify(content), this.options())
      .toPromise();
      //.then(response => response);
  }

  private options(): RequestOptions {
    var options = new RequestOptions();
    options.headers = this.getHeaders();
    return options;
  }

  
}

export interface IDataService<T> {
    //getById(id: number): Promise<T>;
    getAll(): Promise<T[]>;
    create(model: T): Promise<Response>;
    //update(model: T): Promise<boolean>;
    //delete(model: T): Promise<boolean>;
} 