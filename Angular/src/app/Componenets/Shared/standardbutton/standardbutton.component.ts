import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
  selector: 'app-standardbutton',
  templateUrl: './standardbutton.component.html',
  styleUrls: ['./standardbutton.component.scss']
})
export class StandardbuttonComponent {
  @Input() label: string | undefined;
  @Input() colour: string | undefined;
  @Output() clicked = new EventEmitter();

  onClick() {
    this.clicked.emit();
  }
}
