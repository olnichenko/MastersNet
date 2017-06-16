import { Component, AfterViewInit } from '@angular/core'
import { AgmCoreModule } from '@agm/core'
declare var $: any;

@Component({
    selector: 'register',
    templateUrl: '/template/Register'
})
export class RegisterComponent implements AfterViewInit {
    ngAfterViewInit(): void {
        const currentForm = $("#reg-form");
        currentForm.removeData("validator");
        currentForm.removeData("unobtrusiveValidation");
        $.validator.unobtrusive.parse(currentForm);
        
    }
}