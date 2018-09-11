import { Component, Inject, OnInit, Injectable} from "@angular/core";
import { Http, Headers } from "@angular/http";
import "rxjs";
import { inject } from "@angular/core/testing";


@Injectable()
export class EmployeeService {
    public forecasts: UserDetail[];
    public cacheForecasts: UserDetail[];
    public token: any[];
    public summaries: any[];

    private createHeaderGet(header: Headers, tokens: string) {
        header.append('Authorization', 'Bearer ' + tokens);
        header.append('Content-Type', 'application/json');
    }
    constructor(private _http: Http, @Inject('BASE_URL') baseUrl: string) {      
       
    }

    getEmployeeDetails(token: string): any[] {

        var header = new Headers();
        this.createHeaderGet(header, token);
        this._http.get("http://WebAPI.com/api/Values", { headers: header }).map(res => res.json()).subscribe(result1 => {

            this.forecasts = result1;
            return this.forecasts;
        }, error => console.error(error));

        return this.forecasts;
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
