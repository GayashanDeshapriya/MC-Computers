import { Routes } from '@angular/router';
import { ListingComponent } from './listing/listing.component';
import { CreateinvoiceComponent } from './createinvoice/createinvoice.component';

export const routes: Routes = [
  { component: ListingComponent, path: '' },
  { component: CreateinvoiceComponent, path: 'createinvoice' },
  { component: CreateinvoiceComponent, path: 'editinvoice/:id' },
];
