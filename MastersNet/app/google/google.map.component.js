"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
const core_1 = require("@angular/core");
let GoogleMapComponent = class GoogleMapComponent {
    constructor() {
        this.title = 'My first AGM project';
        this.lat = 51.678418;
        this.lng = 7.809007;
    }
};
GoogleMapComponent = __decorate([
    core_1.Component({
        selector: 'google-map',
        template: `<h1>{{ title }}</h1>
    <agm-map [latitude]="lat" [longitude]="lng">
        <agm-marker [latitude]="lat" [longitude]="lng"></agm-marker>
    </agm-map>
    <select id="country">
        <option value="all">All</option>
        <option value="au">Australia</option>
        <option value="br">Brazil</option>
        <option value="ca">Canada</option>
        <option value="fr">France</option>
        <option value="de">Germany</option>
        <option value="mx">Mexico</option>
        <option value="nz">New Zealand</option>
        <option value="it">Italy</option>
        <option value="za">South Africa</option>
        <option value="es">Spain</option>
        <option value="pt">Portugal</option>
        <option value="us" selected>U.S.A.</option>
        <option value="uk">United Kingdom</option>
      </select>
`
    })
], GoogleMapComponent);
exports.GoogleMapComponent = GoogleMapComponent;
//# sourceMappingURL=google.map.component.js.map