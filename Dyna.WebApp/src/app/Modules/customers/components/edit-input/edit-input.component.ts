import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Customer } from 'src/models/customer';

@Component({
  selector: 'app-edit-input',
  templateUrl: './edit-input.component.html',
  styleUrls: ['./edit-input.component.scss']
})
export class EditInputComponent implements OnInit {
  @Input() data!: string;
  @Input() customerItem!: Customer
  @Output() focusOut: EventEmitter<Customer> = new EventEmitter<Customer>();

  editMode = false;

  constructor() { }

  ngOnInit() {
  }

  onFocusOut() {
    this.focusOut.emit(this.customerItem);
  }

}
