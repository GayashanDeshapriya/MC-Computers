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
  pdfurl= '';
  invoiceno: any;

  ngOnInit(): void{
    this.LoadInvoice();
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
 
}
