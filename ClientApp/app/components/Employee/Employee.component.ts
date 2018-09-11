import { Component } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';


@Component({
    selector: 'Employee-details',
    templateUrl: './Employee.component.html'
})

export class EmployeeComponent {

    public EmployeeDetail: IEmployeeDetail[];

    constructor() {
        this.EmployeeDetail = [{ id: 1, Name: "manish", DOB: "25/03/1998" }];
      
    }


}

 interface IEmployeeDetail {
    id: number;
    Name: string;
    DOB: string;
    
}