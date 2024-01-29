import { Component } from '@angular/core';
import { MasterService } from '../service/master.service';

@Component({
  selector: 'app-listing',
  templateUrl: './listing.component.html',
  styleUrl: './listing.component.css'
})
export class ListingComponent {
  constructor(private service:MasterService) {}

  InvoiceList: any;

  ngOnInit(): void{
    this.LoadInvoice();
  }

  LoadInvoice() {
    this.service.GetAllInvoice().subscribe(res => {
      this.InvoiceList = res;
      
    });
  }

}
