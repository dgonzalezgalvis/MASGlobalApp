import { RouterModule, Routes } from '@angular/router';

import { EmployeesComponent } from './components/employees/employees.component';

export const appRoutes: Routes = [
    {
        path: 'employees',
        component: EmployeesComponent
    },
    {
        path: '',
        redirectTo: '/employees',
        pathMatch: 'full'
    },
];