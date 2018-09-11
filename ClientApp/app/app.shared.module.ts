import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './components/app/app.component';
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { HomeComponent } from './components/home/home.component';
import { FetchDataComponent } from './components/fetchdata/fetchdata.component';
import { CounterComponent } from './components/counter/counter.component';
import { EmployeeComponent } from './components/Employee/Employee.component';
import { EditEmployeeComponent } from "./components/EditEmployee/EditEmployee.component";

import { EmployeeService } from "./components/Services/Employee-Service";

@NgModule({
    declarations: [
        AppComponent,
        NavMenuComponent,
        CounterComponent,
        FetchDataComponent,
        HomeComponent,
        EmployeeComponent,
        EditEmployeeComponent
    ],
    imports: [
        CommonModule,
        HttpModule,
        FormsModule,
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },
            { path: 'counter', component: CounterComponent },
            { path: 'fetch-data', component: FetchDataComponent },
            { path: 'Employee-details', component: EmployeeComponent },
            { path: 'EditEmployee/:code', component: EditEmployeeComponent },
            { path: '**', redirectTo: 'home' }
            
        ])
    ],
    providers: [EmployeeService],
})
export class AppModuleShared {
}
