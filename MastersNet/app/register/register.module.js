"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
const core_1 = require("@angular/core");
const platform_browser_1 = require("@angular/platform-browser");
const forms_1 = require("@angular/forms");
const register_component_1 = require("./register.component");
const core_2 = require("@agm/core");
const google_map_component_1 = require("../google/google.map.component");
let RegisterModule = class RegisterModule {
};
RegisterModule = __decorate([
    core_1.NgModule({
        imports: [platform_browser_1.BrowserModule, forms_1.FormsModule, core_2.AgmCoreModule.forRoot({ apiKey: 'AIzaSyDo8tyV8DN_8ohGO7gXZAEdlizNgNZ34Rk' })],
        declarations: [register_component_1.RegisterComponent, google_map_component_1.GoogleMapComponent],
        bootstrap: [register_component_1.RegisterComponent]
    })
], RegisterModule);
exports.RegisterModule = RegisterModule;
//# sourceMappingURL=register.module.js.map