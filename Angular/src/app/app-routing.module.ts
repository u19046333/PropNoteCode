import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { UserDashBoardComponent } from './Componenets/user-dash-board/user-dash-board.component';

//Angular Routing
const routes: Routes = [
  { path: 'userDashBoard', component: UserDashBoardComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
