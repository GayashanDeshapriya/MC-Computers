import { NgModule } from '@angular/core';
import { MatSlideToggleModule } from '@angular/material/slide-toggle';
import { HttpClientModule } from '@angular/common/http';
import { InvoiceComponent } from './components/invoice/invoice.component';
import { AppComponent } from './app.component';
import { BrowserModule } from '@angular/platform-browser';
import { InvoiceServiceService } from './service/invoice-service.service';

@NgModule({
  declarations: [InvoiceComponent], // AppComponent should be in declarations
  imports: [BrowserModule, MatSlideToggleModule, HttpClientModule],
  providers: [InvoiceServiceService], // provide your service here
})
export class AppModule {}