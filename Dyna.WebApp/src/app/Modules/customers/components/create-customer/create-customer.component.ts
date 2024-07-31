import { Component, OnDestroy, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Subject, takeUntil } from 'rxjs';
import { CustomerService } from '../../services/customer.service';
import { Customer } from 'src/models/customer';

@Component({
  selector: 'app-create-customer',
  templateUrl: './create-customer.component.html',
  styleUrls: ['./create-customer.component.scss']
})
export class CreateCustomerComponent implements OnInit, OnDestroy {
  private _unsubscribe$ = new Subject<void>();

  customerForm: FormGroup = new FormGroup({
    firstName: new FormControl(''),
    lastName: new FormControl(''),
    email: new FormControl('')
  });

  submitted = false;
  isCreatingCustomer: boolean = false;
  EMAIL_REGEX = /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;

  get firstName(): FormControl<string> {
    return this.customerForm.get('firstName') as FormControl<string>
  }

  get lastName(): FormControl<string> {
    return this.customerForm.get('lastName') as FormControl<string>
  }

  get email(): FormControl<string> {
    return this.customerForm.get('email') as FormControl<string>
  }

  constructor(
    private _formBuilder: FormBuilder,
    private _router: Router,
    private _customerService: CustomerService,
  ) { }

  ngOnInit() {
    this.customerForm = this._formBuilder.group({
      firstName: ['', Validators.required],
      lastName: ['', Validators.required],
      email: ['',
        [
        Validators.required,
        Validators.pattern(this.EMAIL_REGEX)
        ]
      ],
    })
  }

  handleCancel(): void {
    this._router.navigateByUrl('/');
  }

  handleCreateCustomerSubmission(): void {
    this.customerForm.markAllAsTouched();
    this.submitted = true;

    if (this.customerForm.invalid)
    {
      return;
    }

    this.isCreatingCustomer = true;

    const newCustomer: Customer = { ...this.customerForm.value };
    newCustomer.id = 0;
    newCustomer.createdDate = new Date();
    newCustomer.lastUpdatedDate = new Date();
    newCustomer.isActive = true;

    this._customerService.createCustomer(newCustomer)
          .pipe(
            takeUntil(this._unsubscribe$.asObservable())
          )
          .subscribe(() => {
            this.isCreatingCustomer = false;
            this.handleCancel();
          })
  }

  ngOnDestroy(): void {
    this._unsubscribe$.next();
    this._unsubscribe$.complete();
  }

}
