import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, throwError } from 'rxjs';
import { catchError, tap } from 'rxjs/operators';
import { environment } from 'src/environments/environment';
import { Customer } from 'src/models/customer';

@Injectable({
  providedIn: 'root'
})
export class CustomerService {
  private baseUrl: string;

  constructor(
    private http: HttpClient
  ) {
    this.baseUrl = `${environment.apis.backEnd.url}/Customers`;
  }

  getCustomers(): Observable<Customer[]> {
    const url = `${this.baseUrl}`;

    return this.http.get<Customer[]>(url);
  }

  getCustomerById(customerId: number): Observable<Customer> {
    const url = `${this.baseUrl}/${customerId}`;

    return this.http.get<Customer>(url);
  }

  createCustomer(customer: Customer): Observable<Customer> {
    const url = `${this.baseUrl}`;

    return this.http.post<Customer>(url, customer);
  }

  updateCustomer(customer: Customer): Observable<void> {
    const url = `${this.baseUrl}/${customer.id}`;

    return this.http.put<void>(url, customer);
  }

  deleteCustomer(customerId: number): Observable<void> {
    const url = `${this.baseUrl}${customerId}`;

    return this.http.delete<void>(url);
  }
}
