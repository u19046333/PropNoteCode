import { Component } from '@angular/core';
import { MatDialogRef } from '@angular/material/dialog';
import { MatInputModule } from '@angular/material/input'
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import {BrowserModule} from '@angular/platform-browser';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';

NgModule({
  
  imports: [
  BrowserAnimationsModule,
    BrowserModule,
    FormsModule
  ],
})

@Component({
  selector: 'app-createUserRole-modal',
  templateUrl: './modal.component.html',
  styleUrls: ['./modal.component.scss']
})
export class MyModalComponent {
    adminRole: boolean = false;
    editorRole: boolean = false;
    viewerRole: boolean = false;

  constructor(private dialogRef: MatDialogRef<MyModalComponent>) { }

  createRole() {
    this.dialogRef.close();
  }

  closeModal() {
    this.dialogRef.close();
  }
}
