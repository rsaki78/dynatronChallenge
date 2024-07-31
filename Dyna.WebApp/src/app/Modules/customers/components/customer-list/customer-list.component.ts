import { Customer } from './../../../../../models/customer';
import { Component, OnDestroy, OnInit } from '@angular/core';
import { CustomerService } from '../../services/customer.service';
import { Subject, take, takeUntil } from 'rxjs';

@Component({
  selector: 'app-customer-list',
  templateUrl: './customer-list.component.html',
  styleUrls: ['./customer-list.component.scss']
})
export class CustomerListComponent implements OnInit, OnDestroy {
  private readonly _unsuscribe$ = new Subject<void>();
  customersDataSource: Customer[] = [];

  constructor(
    private _customerService: CustomerService
  ) { }

  ngOnInit() {
    this.getCustomers();
  }

  getCustomers() {
    this._customerService
            .getCustomers()
            .pipe(takeUntil(this._unsuscribe$.asObservable()))
            .subscribe((customers: Customer[]) => {
              this.customersDataSource = customers;
            });
  }

  updateCustomer(customer: Customer): void {
    this._customerService
            .updateCustomer(customer)
            .pipe(takeUntil(this._unsuscribe$.asObservable()))
            .subscribe(() => {
              this.getCustomers();
            });
  }

  ngOnDestroy(): void {
    this._unsuscribe$.next();
    this._unsuscribe$.complete();
  }

}
