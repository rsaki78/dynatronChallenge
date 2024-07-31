import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-customer-status',
  templateUrl: './customer-status.component.html',
  styleUrls: ['./customer-status.component.css']
})
export class CustomerStatusComponent implements OnInit {
  @Input() CustomerStatus: boolean = false;

  statusText: string = 'Active';
  statusCssClass: string = 'bg-success';

  constructor() { }

  ngOnInit() {
    this.statusText = this.CustomerStatus ? 'Active' : 'Inactive';
    this.statusCssClass = this.CustomerStatus ? 'bg-success' : 'bg-danger';
  }

}
