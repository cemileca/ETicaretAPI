import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ProductsModule } from './products/products.module';
import { BasketsModule } from './baskets/baskets.module';
import { HomeModule } from './home/home.module';
import { RouterModule } from '@angular/router';
import { NavBarComponent } from './nav-bar/nav-bar.component';





@NgModule({
  declarations: [
    NavBarComponent
  ],
  imports: [
    CommonModule,
      ProductsModule,BasketsModule,HomeModule,RouterModule
  ],
  exports: [
    NavBarComponent
  ]
})
export class ComponentsModule { }
