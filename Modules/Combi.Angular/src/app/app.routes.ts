import { Routes } from '@angular/router';
import { HelloComponent } from './hello/hello.component';
import { WeatherComponent } from './weather/weather.component';

export const routes: Routes = [
    {
        path: 'hello',
        component: HelloComponent
    },
    {
        path: 'weather',
        component: WeatherComponent
    },
    {
        path: '**',
        redirectTo: 'hello',
        pathMatch: 'full'
    }    
];
