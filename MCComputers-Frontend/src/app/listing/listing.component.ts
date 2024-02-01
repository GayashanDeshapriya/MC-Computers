import { Component, OnInit } from '@angular/core';
import { MasterService } from '../service/master.service';


@Component({
  selector: 'app-listing',
  templateUrl: './listing.component.html',
  styleUrl: './listing.component.css'
})
export class ListingComponent implements OnInit {
  constructor(private service:MasterService) {}

  InvoiceList: any;
  
  invoiceNumber: any;

  ngOnInit(): void{
    this.LoadInvoice();
    this.DownloadInvoice(this.invoiceNumber)
  }

  LoadInvoice() {
    this.service.GetAllInvoice().subscribe(
      res => {
        this.InvoiceList = res;
        console.log(this.InvoiceList);
      },
      err => {
        console.error(err);
        // handle the error
      });
  }

  DownloadInvoice(invoiceNumber: any) {
    this.service.GenerateInvoicePDF(invoiceNumber).subscribe((data: any) => {
      const blob = new Blob([data], { type: 'application/pdf' });
      const url = window.URL.createObjectURL(blob);
      const link = document.createElement('a');
      link.href = url;
      link.download = `invoice_${invoiceNumber}.pdf`;
      link.click();
      window.URL.revokeObjectURL(url);
    });
  }

  
}
