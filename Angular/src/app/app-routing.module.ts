import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { UserRoleComponent } from './user-role/user-role/user-role.component';
import { UsersComponent } from './users/users/users.component';
import { PropertyComponent } from './property/property/property.component';
import { TenantsComponent } from './tenants/tenants/tenants.component';
import { ContractorsComponent } from './contractors/contractors/contractors.component';
import { MaintenanceComponent } from './maintenance/maintenance/maintenance.component';
import { CalendarComponent } from './calendar/calendar/calendar.component';
import { HomeComponent } from './home/home/home.component';
import { BrokerComponent } from './broker/broker/broker.component';
import { EmployeeComponent } from './employee/employee/employee.component';
import { LogoutComponent } from './logout/logout/logout.component';
import { SettingsComponent } from './settings/settings/settings.component';
import { EditProfileComponent } from './edit-profile/edit-profile/edit-profile.component';
import { ViewProfileComponent } from './view-profile/view-profile/view-profile.component';


const routes: Routes = [
  {path: 'users', component:UsersComponent},
  {path: 'property', component:PropertyComponent},
  {path: 'tenants', component:TenantsComponent},
  {path: 'contractors', component:ContractorsComponent},
  {path: 'maintenace', component:MaintenanceComponent},
  {path: 'calendar', component:CalendarComponent},
  {path: 'user-role', component:UserRoleComponent},
  {path: 'home', component:HomeComponent},
  {path: 'broker', component:BrokerComponent},
  {path: 'employee', component:EmployeeComponent},
  {path: 'logout', component:LogoutComponent},
  {path: 'settings', component:SettingsComponent},
  {path: 'edit-profile', component:EditProfileComponent},
  {path: 'view-profile', component:ViewProfileComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],

exports: [RouterModule]
})
export class AppRoutingModule { }
