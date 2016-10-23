import { Component, OnInit }      from '@angular/core';
import { ActivatedRoute, Params } from '@angular/router';
import { Location }               from '@angular/common';

import { Event }         from './event';
import {EventLog} from './eventlog'
import { EventService }  from './event.service';

@Component({
  moduleId: module.id,  
  selector: 'my-event-detail',
  templateUrl: '../views/event-detail.component.html',
  styleUrls: [ '../assets/event-detail.component.css' ]
})
export class EventDetailComponent implements OnInit {
  event: Event;
  eventlogs:EventLog[];

  constructor(
    private eventService: EventService,
    private route: ActivatedRoute,
    private location: Location
  ) {}

  ngOnInit(): void {
    this.route.params.forEach((params: Params) => {
      let name = params['name'];      
      this.eventService.getEvent(name)
        .subscribe(event => this.event = event);
    });
  }

  

  goBack(): void {
    this.location.back();
  }  
}