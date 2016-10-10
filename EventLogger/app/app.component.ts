import { Component } from '@angular/core';

// Add the RxJS Observable operators we need in this app.
import './rxjs-operators';
//import 'rxjs/add/operator/map'

@Component({
  moduleId: module.id,
  selector: 'my-app',
  template: `
    <h1>{{title}}</h1>
    <nav>
      <a routerLink="/dashboard" routerLinkActive="active">Home</a>
    </nav>
    <router-outlet></router-outlet>
  `,
  styleUrls: ['../assets/app.component.css'],
})
export class AppComponent {
  title="Event Viewer"
}