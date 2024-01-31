import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { ReactiveFormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ListingComponent } from './listing/listing.component';
import { CreateinvoiceComponent } from './createinvoice/createinvoice.component';
import { HttpClientModule } from '@angular/common/http';
import { NgxExtendedPdfViewerModule} from 'ngx-extended-pdf-viewer';

@NgModule({
  declarations: [
    AppComponent,
    ListingComponent,
    CreateinvoiceComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule,
    NgxExtendedPdfViewerModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
