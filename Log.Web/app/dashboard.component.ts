import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

import { Event } from './event';
import { EventService } from './event.service';

@Component({
  moduleId: module.id,
  selector: 'my-dashboard',
  templateUrl: '../views/dashboard.component.html',
  styleUrls: [ '../assets/dashboard.component.css' ]
})
export class DashboardComponent implements OnInit {

  events: Event[] = [];

  constructor(
    private router: Router,
    private eventService: EventService) {
  }

  ngOnInit(): void {
    this.eventService.getEvents()
      .subscribe(events => this.events = events);
  }

  gotoDetail(event: Event): void {
    let link = ['/detail', event.Name];
    this.router.navigate(link);
  }
}


/*
Copyright 2016 Google Inc. All Rights Reserved.
Use of this source code is governed by an MIT-style license that
can be found in the LICENSE file at http://angular.io/license
*/