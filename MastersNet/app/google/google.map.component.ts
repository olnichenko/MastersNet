import { Component } from '@angular/core'

@Component({
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
export class GoogleMapComponent {
    title: string = 'My first AGM project';
    lat: number = 51.678418;
    lng: number = 7.809007;
}