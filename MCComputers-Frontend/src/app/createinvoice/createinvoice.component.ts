import { Component } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { FormGroup, FormControl } from '@angular/forms';
import { MasterService } from '../service/master.service';
import { Router } from '@angular/router';


@Component({
  selector: 'app-createinvoice',
  templateUrl: './createinvoice.component.html',
  styleUrl: './createinvoice.component.css'
})
export class CreateinvoiceComponent {
  constructor(private builder : FormBuilder, private services:MasterService, private router:Router) { }
  pagetitle = 'Create Invoice';
  
 masterInvoice: any;

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

  // Get invoice data and assign it to masterInvoices
getCustomer() {
 
}

}

