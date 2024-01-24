import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Invoice } from '../models/invoice';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';
@Injectable({
  providedIn: 'root'
})
export class InvoiceServiceService {

  
  baseApiUrl : string = environment.BaseApiUrl;
  
  constructor(private http: HttpClient) { }
  getAllinvoices(): Observable<Invoice[]>{
    return this.http.get<Invoice[]>(this.baseApiUrl +'/api/Invoices');
  }
}
