import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ComponentsModule } from './components/components.module';
import { RouterModule } from '@angular/router';
import { DenemeComponent } from './deneme/deneme.component';



@NgModule({
  declarations: [
    DenemeComponent
  ],
  imports: [
    CommonModule,
    ComponentsModule,
    RouterModule
  ]
  
})
export class UiModule { }
