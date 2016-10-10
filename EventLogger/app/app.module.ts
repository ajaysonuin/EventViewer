import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpModule,JsonpModule  }    from '@angular/http';
import { RouterModule }   from '@angular/router';

import { AppComponent }         from './app.component';
import { DashboardComponent }   from './dashboard.component';
import { EventDetailComponent }  from './event-detail.component';
import { EventlogComponent }      from './eventlog.component';
import { EventService }          from './event.service';



@NgModule({
  imports: [BrowserModule, FormsModule,HttpModule,JsonpModule,
    RouterModule.forRoot([
      {
        path: '',
        redirectTo: '/dashboard',
        pathMatch: 'full'
      },
      {
        path: 'dashboard',
        component: DashboardComponent
      },
      {
        path: 'detail/:name',
        component: EventDetailComponent
      }
    ])],
  declarations: [AppComponent,DashboardComponent,EventDetailComponent,EventlogComponent],
  providers: [
    EventService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }