import { Component, OnInit } from '@angular/core';
import { EmployeesService } from '../../services/employees/employees.services';
import { Router } from '@angular/router';
import 'rxjs/add/operator/map';

@Component({
    selector: 'app-employees',
    templateUrl: './employees.component.html',
    styleUrls: ['./employees.component.css']
})
export class EmployeesComponent implements OnInit {
    polizasResponse: any;
    employees = [];
    employeeId;
    columns = [
        {
            title: 'Id',
            name: 'id',
            sort: true,
        },
        { title: 'Name', name: 'name'},
        {
            title: 'Role Name',
            name: 'roleName',
        },
        {
            title: 'Contract Type',
            name: 'contractTypeName'
        },
        { title: 'Hourly Salary ($)', name: 'hourlySalary' },
        { title: 'Monthly ($)', name: 'monthlySalary' },
        { title: 'Annual ($)', name: 'annualSalary' }
    ];

    public config: any = {
        paging: true,
        sorting: { columns: this.columns },
        filtering: { filterString: '' },
        className: ['table-striped', 'table-bordered']
    };

    constructor(private _service: EmployeesService,
        private _router: Router) { }

    ngOnInit() {
        this.bringEmployees();
    }

    bringEmployees() {
        this._service.getEmployees(this.employeeId)
            .map(res => res)
            .subscribe(res => this.mapEmployees(res));
    }

    mapEmployees(response) {
        const formatter = new Intl.NumberFormat('en-US', {
            style: 'currency',
            currency: 'USD',
            minimumFractionDigits: 2
        })
        this.employees = JSON.parse(response._body);
        this.employees.forEach(employee=>{
            employee.hourlySalary = formatter.format(employee.hourlySalary);
            employee.monthlySalary = formatter.format(employee.monthlySalary);
            employee.annualSalary = formatter.format(employee.annualSalary);
        })
    }

}
