"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
var core_1 = require('@angular/core');
var router_1 = require('@angular/router');
var event_service_1 = require('./event.service');
var DashboardComponent = (function () {
    function DashboardComponent(router, eventService) {
        this.router = router;
        this.eventService = eventService;
        this.events = [];
    }
    DashboardComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.eventService.getEvents()
            .subscribe(function (events) { return _this.events = events; });
    };
    DashboardComponent.prototype.gotoDetail = function (event) {
        var link = ['/detail', event.Name];
        this.router.navigate(link);
    };
    DashboardComponent = __decorate([
        core_1.Component({
            moduleId: module.id,
            selector: 'my-dashboard',
            templateUrl: '../views/dashboard.component.html',
            styleUrls: ['../assets/dashboard.component.css']
        }), 
        __metadata('design:paramtypes', [router_1.Router, event_service_1.EventService])
    ], DashboardComponent);
    return DashboardComponent;
}());
exports.DashboardComponent = DashboardComponent;
/*
Copyright 2016 Google Inc. All Rights Reserved.
Use of this source code is governed by an MIT-style license that
can be found in the LICENSE file at http://angular.io/license
*/ 
//# sourceMappingURL=dashboard.component.js.map