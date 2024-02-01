import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class MasterService {
  constructor(private http: HttpClient) {}
  

  //Invoices Endpoints

  GetAllInvoice() {
    return this.http.get('https://localhost:7215/api/Invoices');
  }
  GetInvoicebyid(invoiceNumber: any) {
    return this.http.get('https://localhost:7215/api/Invoices/' + invoiceNumber, { observe: 'response', responseType: 'blob'});
  }
  AddInvoice(id: any, invoiceData: any) {
    return this.http.get('https://localhost:7215/api/Invoices' + id, invoiceData);
  }

  //PDF Generation Endpoints
  GenerateInvoicePDF(invoiceNumber: any) : Observable<any> {
    return this.http.get('https://localhost:7215/api/PDF/'+invoiceNumber, { responseType: 'arraybuffer' as 'json' });
  }

//Customer Endpoints
  GetCustomer() {
    return this.http.get('https://localhost:7215/api/Customers');
  }
  GetCustomerbyid(id: any) {
    return this.http.get('https://localhost:7215/api/Customers/' + id);
  }


//Product Endpoints
  GetProduct() {
    return this.http.get('https://localhost:7215/api/Products');
  }
  GetProductbyid(id: any) {
    return this.http.get('https://localhost:7215/api/Products/' + id);
  }
}
