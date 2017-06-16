import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';
import { RegisterModule } from './register.module';
const platform = platformBrowserDynamic();
platform.bootstrapModule(RegisterModule);