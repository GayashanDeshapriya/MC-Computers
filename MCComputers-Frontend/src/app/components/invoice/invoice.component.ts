import { Component, OnInit } from '@angular/core';
import { Invoice } from '../../../app/models/invoice';
import { InvoiceServiceService } from '../../../app/service/invoice-service.service';

@Component({
  selector: 'app-invoice',
  templateUrl: './invoice.component.html',
  styleUrls: ['./invoice.component.css']
})
export class InvoiceComponent implements OnInit {
  invoices: Invoice[] = [];
  constructor(private invoiceService: InvoiceServiceService) { }

  ngOnInit(): void {
    this.invoiceService.getAllinvoices().subscribe({
      next: (invoices: Invoice[]) => {
        this.invoices = invoices;
      },
      error: (err: any) => console.log(err)
    });
  }
}