import { Component, Injectable } from "@angular/core"
import { ActivatedRoute } from "@angular/router"
import { NgForm } from "@angular/forms";





@Component({
    selector: "EditEmployee",
    templateUrl: "./EditEmployee.component.html"
})

export class EditEmployeeComponent {
    public EmployeeDetail: IEmployeeDetail[];
    public EmployeeDetail1: IEmployeeDetail;
    constructor(private _ActivatedRoute: ActivatedRoute) {
        debugger;
        let code: string = this._ActivatedRoute.snapshot.params['code'];
        this.EmployeeDetail = [{ id: 1, Name: "manish", DOB: "25/03/1998", Code: code }];

    }

    onClickSubmit(data:any) {
        alert("Entered Email id : " + data.emailid);
       
        
    }
}
interface IEmployeeDetail {
    id: number;
    Name: string;
    DOB: string;
    Code: string;

}

