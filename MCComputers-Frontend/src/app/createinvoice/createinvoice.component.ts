import { Component } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { FormGroup, FormControl } from '@angular/forms';

@Component({
  selector: 'app-createinvoice',
  templateUrl: './createinvoice.component.html',
  styleUrl: './createinvoice.component.css'
})
export class CreateinvoiceComponent {
  constructor(private builder : FormBuilder) { }
  pagetitle = 'Create Invoice';
  
 

  ngOnInit():void {}

  invoiceForm = this.builder.group({
    InvoiceNumber : this.builder.control('',Validators.required),
    CustomerName : this.builder.control(''),
    ProductName: this.builder.control(''),
    TransactionDate: this.builder.control(''),
    Discount: this.builder.control(''),
    Quantity: this.builder.control(''),
    TotalAmount : this.builder.control(''),
    BalanceAmount : this.builder.control(''),
  });

  saveInvoice() {
    console.log(this.invoiceForm.value);
  }
}

