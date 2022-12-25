import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DashboardComponent } from './dashboard.component';
import { RouterModule } from '@angular/router';
import { AlertifyService } from 'src/app/services/admin/alertify.service';


@NgModule({
  declarations: [DashboardComponent],
  imports: [
    CommonModule,
    RouterModule.forChild([{ path: "", component: DashboardComponent }]),
  ],
})
export class DashboardModule {
 
}
