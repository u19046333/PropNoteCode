import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { UserDashBoardComponent } from './Componenets/user-dash-board/user-dash-board.component';
import { StandardbuttonComponent } from './Componenets/Shared/standardbutton/standardbutton.component';
import { UserNavBarComponent } from './Componenets/Shared/standardbutton/NavigationBar/user-nav-bar/user-nav-bar.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {MatButtonModule} from '@angular/material/button';
import { ViewPropertyComponent } from './Componenets/Property/view-property/view-property.component';
import { ViewLeaseComponent } from './Componenets/Lease/view-lease/view-lease.component';
import { DropDownMenuComponent } from './Componenets/Shared/drop-down-menu/drop-down-menu.component';

@NgModule({
  declarations: [
    AppComponent,
    UserDashBoardComponent,
    StandardbuttonComponent,
    UserNavBarComponent,
    ViewPropertyComponent,
    ViewLeaseComponent,
    DropDownMenuComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatButtonModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
