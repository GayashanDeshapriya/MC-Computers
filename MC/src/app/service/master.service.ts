import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class MasterService {

  constructor(private http:HttpClient) { }

  GetInvoice(){

  }
  GetInvoicebyid(id:number){

  }
  GetCustomer(){

  }
  GetCustomerbyid(id:number){

  }

  GetProduct(){

  }
  GetProductbyid(id:number){

  }


}
