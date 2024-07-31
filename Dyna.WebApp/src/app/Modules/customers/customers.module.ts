import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { EditInputComponent } from './components/edit-input/edit-input.component';
import { CustomersRoutingModule } from './components/customers-routing.module';
import { CustomerListComponent } from './components/customer-list/customer-list.component';
import { CreateCustomerComponent } from './components/create-customer/create-customer.component';
import { CustomerStatusComponent } from './components/customer-status/customer-status.component';

@NgModule({
  declarations: [
    EditInputComponent,
    CustomerListComponent,
    CreateCustomerComponent,
    CustomerStatusComponent
  ],
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    CustomersRoutingModule
  ]
})
export class CustomersModule { }
