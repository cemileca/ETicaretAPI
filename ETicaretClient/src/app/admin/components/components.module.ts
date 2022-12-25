import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ProductsModule } from './products/products.module';
import { OrdersComponent } from './orders/orders.component';
import { CustomerComponent } from './customer/customer.component';
import { OrdersModule } from './orders/orders.module';
import { CustomerModule } from './customer/customer.module';
import { DashboardModule } from './dashboard/dashboard.module';
import { RouterModule } from '@angular/router';



@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    RouterModule,
    ProductsModule,OrdersModule, CustomerModule,DashboardModule
  ]
})
export class ComponentsModule { }
