import { Component, Inject } from '@angular/core';
import { Http, Headers } from '@angular/http';
import { EmployeeService } from '../Services/Employee-Service';
import 'rxjs/Rx';

@Component({
    selector: 'fetchdata',
    templateUrl: './fetchdata.component.html'
})
export class FetchDataComponent {
    public forecasts: UserDetail[];
    public cacheForecasts: UserDetail[];
    public token: any[];
    public summaries: any[];
    createAuthorizationHeader(headers: Headers) {
        headers.append('Authorization', 'Basic ' );
          
    }
    createAuthorizationHeader1(headers1: Headers, tokens: string) {
        headers1.append('Authorization', 'Bearer ' + tokens);

    }

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string,_Employee: EmployeeService) {
        var headers = new Headers();
        this.createAuthorizationHeader(headers);
        headers.append('Content-Type', 'application/json');
        var content = JSON.stringify({
            username: "mario", password: "secret" 
        });
        http.post('http://WebAPI.com/api/Token', content, { headers: headers }).map(res => res.json()).subscribe(result => {

            this.token = result;
            //var headers1 = new Headers();
            //this.createAuthorizationHeader1(headers1, result.token);
            //http.get('http://WebAPI.com/api/Values', { headers: headers1 }).subscribe(result => {
            //    debugger;
            //    this.forecasts = result.json();//as UserDetail[];
            //    this.cacheForecasts = this.forecasts;
            //}, error => console.error(error));
            this.forecasts=_Employee.getEmployeeDetails(result.token);
            this.cacheForecasts = this.forecasts;
            //this.forecasts = result.json();//as UserDetail[];
            //this.cacheForecasts = this.forecasts;
        }, error => console.error(error));


       




        http.get(baseUrl + 'api/SampleData/GetSummaries').subscribe(result => {
            this.summaries = result.json() as any[];          
        }, error => console.error(error));
    }

    filterForeCasts(filterVal: any) {
        
        if (filterVal == "0")
            this.forecasts = this.cacheForecasts;
        else
            this.forecasts = this.cacheForecasts.filter(item => item.fname == filterVal);
        
    }


}
interface UserDetail {
    fname: string;
    userId: string;    
    lname: string;
}

interface WeatherForecast {
    dateFormatted: string;
    temperatureC: number;
    temperatureF: number;
    summary: string;
}
interface Summary {
    name: string;
}
