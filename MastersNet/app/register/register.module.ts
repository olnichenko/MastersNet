import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { RegisterComponent } from './register.component';
import { AgmCoreModule } from '@agm/core';
import { GoogleMapComponent } from '../google/google.map.component'
@NgModule({
    imports: [BrowserModule, FormsModule, AgmCoreModule.forRoot({ apiKey: 'AIzaSyDo8tyV8DN_8ohGO7gXZAEdlizNgNZ34Rk'})],
    declarations: [RegisterComponent, GoogleMapComponent],
    bootstrap: [RegisterComponent]
})
export class RegisterModule{}