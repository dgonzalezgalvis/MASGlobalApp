import { Injectable } from '@angular/core';
import { Http, Headers, URLSearchParams } from '@angular/http';
import { Router } from '@angular/router';

@Injectable()
export class EmployeesService {
    url = 'https://masglobalapi20190309101256.azurewebsites.net/api/';
    tempPolizaEdit = {};

    constructor(private http: Http,
        private _router: Router) { }

    getEmployees(employeeId) {
        let suffix = 'employees';
        if(employeeId && employeeId!==''){
            suffix += '/' + employeeId;
        }
        return this.http.get(this.url + suffix);
    }
}
