import { Injectable } from '@angular/core';
import {Event} from './event';
import {EventLog} from './eventlog';
import { Http, Response, Headers } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import './rxjs-operators';

@Injectable()
export class EventService {

  private baseUrl='http://localhost/logger/EventService.svc';

constructor(private http: Http) { }

  getEvents(): Observable<Event[]> {
    return this.http.get(`${this.baseUrl}/GetAllEvents/?name=`, {headers: this.getHeaders()})
               .map(res=>res.json())
               .catch(handleError);
  }

  getEventLogs(source:string,name:string): Observable<EventLog[]> {
    return this.http.get(`${this.baseUrl}/GetAllLogs/?source=${source}&name=${name}`, {headers: this.getHeaders()})
               .map(res=>res.json())
               .catch(handleError);
  }

  getEvent(name: string): Observable<Event> {
    let event$ = this.http.get(`${this.baseUrl}/GetEvent/?name=${name}`, {headers: this.getHeaders()})
      .map(res=>res.json());
      return event$;
}

private getHeaders(){
    let headers = new Headers();
    headers.append('Accept', 'application/json');
    return headers;
  }
}
function handleError (error: any) {
  // log error
  // could be something more sofisticated
  let errorMsg = error.message || `Yikes! There was was a problem with our hyperdrive device and we couldn't retrieve your data!`
  console.error(errorMsg);

  // throw an application level error
  return Observable.throw(errorMsg);
}