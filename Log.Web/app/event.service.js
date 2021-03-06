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
var http_1 = require('@angular/http');
var Observable_1 = require('rxjs/Observable');
require('./rxjs-operators');
var EventService = (function () {
    function EventService(http) {
        this.http = http;
        this.baseUrl = 'http://localhost/logs/api/Event';
    }
    EventService.prototype.getEvents = function () {
        return this.http.get(this.baseUrl + "/GetAllEvents?name=", { headers: this.getHeaders() })
            .map(function (res) { return res.json(); })
            .catch(handleError);
    };
    EventService.prototype.getEventLogs = function (name, source) {
        return this.http.get(this.baseUrl + "/GetAllLogs?name=" + name + "&source=" + source, { headers: this.getHeaders() })
            .map(function (res) { return res.json(); })
            .catch(handleError);
    };
    EventService.prototype.getEvent = function (name) {
        var event$ = this.http.get(this.baseUrl + "/GetEvent?name=" + name, { headers: this.getHeaders() })
            .map(function (res) { return res.json(); });
        return event$;
    };
    EventService.prototype.getHeaders = function () {
        var headers = new http_1.Headers();
        headers.append('Accept', 'application/json');
        return headers;
    };
    EventService = __decorate([
        core_1.Injectable(), 
        __metadata('design:paramtypes', [http_1.Http])
    ], EventService);
    return EventService;
}());
exports.EventService = EventService;
function handleError(error) {
    // log error
    // could be something more sofisticated
    var errorMsg = error.message || "Yikes! There was was a problem with our hyperdrive device and we couldn't retrieve your data!";
    console.error(errorMsg);
    // throw an application level error
    return Observable_1.Observable.throw(errorMsg);
}
//# sourceMappingURL=event.service.js.map