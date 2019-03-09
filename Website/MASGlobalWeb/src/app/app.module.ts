import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule, Routes } from '@angular/router';

import { Ng2TableModule } from 'ng2-table/ng2-table';

import { AppComponent } from './app.component';
import { EmployeesComponent } from './components/employees/employees.component';

import { EmployeesService } from './services/employees/employees.services';

import { appRoutes } from './app-routing.module';

@NgModule({
  declarations: [
    AppComponent,
    EmployeesComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule,
    Ng2TableModule,
    RouterModule.forRoot(
      appRoutes,
      { enableTracing: true } // <-- debugging purposes only
    ),
  ],
  providers: [
    EmployeesService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
