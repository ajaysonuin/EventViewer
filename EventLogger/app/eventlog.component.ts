import { Component, OnInit, Input, AfterViewInit  }      from '@angular/core';
import { ActivatedRoute, Params } from '@angular/router';
import { Location }               from '@angular/common';

import { Event }         from './event';
import {EventLog} from './eventlog'
import { EventService }  from './event.service';

@Component({
  moduleId: module.id,
  selector: 'eventlog-list',
  templateUrl: '../views/eventlog.component.html',
  styleUrls: [ '../assets/event-detail.component.css' ],
})
export class EventlogComponent {
    @Input() event: Event;
    eventlogs:EventLog[];
    selectedLog: EventLog;
    constructor(private eventService: EventService) {}

     searchLogs(source: string,name:string): void {
    this.eventService.getEventLogs(source,name).subscribe(eventlogs=>this.eventlogs=eventlogs);
  }

   ngAfterViewInit() {
    this.searchLogs(this.event.Name,'');
  }

  onSelect(eventLog: EventLog): void {
    this.selectedLog = eventLog;
  }

  }
  