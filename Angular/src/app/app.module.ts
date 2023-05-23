import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MaterialModule } from './shared/material.module';
import { UserRoleComponent } from './user-role/user-role/user-role.component';
import { CalendarComponent } from './calendar/calendar/calendar.component';
import { ContractorsComponent } from './contractors/contractors/contractors.component';
import { MaintenanceComponent } from './maintenance/maintenance/maintenance.component';
import { PropertyComponent } from './property/property/property.component';
import { TenantsComponent } from './tenants/tenants/tenants.component';
import { UsersComponent } from './users/users/users.component';

import { CommonModule } from '@angular/common';
import { HomeComponent } from './home/home/home.component';
import { BrokerComponent } from './broker/broker/broker.component';
import { EmployeeComponent } from './employee/employee/employee.component';
import { LogoutComponent } from './logout/logout/logout.component';
import { SettingsComponent } from './settings/settings/settings.component';
import { EditProfileComponent } from './edit-profile/edit-profile/edit-profile.component';
import { ViewProfileComponent } from './view-profile/view-profile/view-profile.component';

@NgModule({
  declarations: [
    AppComponent,
    UserRoleComponent,
    CalendarComponent,
    ContractorsComponent,
    MaintenanceComponent,
    PropertyComponent,
    TenantsComponent,
    UsersComponent,
    HomeComponent,
    BrokerComponent,
    EmployeeComponent,
    LogoutComponent,
    SettingsComponent,
    EditProfileComponent,
    ViewProfileComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MaterialModule,
    FormsModule
  ],

  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
