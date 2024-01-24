import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { InvoiceComponent } from './components/invoice/invoice.component';
import { CustomerComponent } from './components/customer/customer.component';

export const routes: Routes = [
    {
      path: '',
      component: InvoiceComponent,
    },
    {
      path: 'customer',
      component: CustomerComponent ,
    },
  ];
  

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}