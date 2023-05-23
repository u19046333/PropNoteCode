import { Component, ViewChild } from '@angular/core';
import {MatDialog} from '@angular/material/dialog';
import {MatTable} from '@angular/material/table';
import { MatDialogModule } from '@angular/material/dialog';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import { MyModalComponent } from 'src/app/createUserRole-modal/modal.component';

NgModule({
imports: [
  MatDialogModule,
  FormsModule, 
  MatInputModule, 
  MatButtonModule],
})

export interface DialogData {
  name: string;
  description: string;
  access: string;
}

@Component({
  selector: 'app-user-role',
  templateUrl: './user-role.component.html',
  styleUrls: ['./user-role.component.scss']
})
export class UserRoleComponent {

  constructor(public dialog: MatDialog) {}

  openDialog(enterAnimationDuration: string, exitAnimationDuration: string): void {
    this.dialog.open(UserRoleComponent, {
      width: '250px',
      enterAnimationDuration,
      exitAnimationDuration,
    });
  }

    searchTerm: string = '';
  
    search() {
      // Perform search logic here
      console.log('Search term:', this.searchTerm);
    }

    openModal() {
      const dialogRef = this.dialog.open(MyModalComponent, {
        width: '600px', // Adjust the width as needed
      })
    
    }}