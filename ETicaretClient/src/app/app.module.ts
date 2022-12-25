import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AdminModule } from './admin/admin.module';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { UiModule } from './ui/ui.module';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ComponentsModule } from "./ui/components/components.module";
import { ToastrModule } from 'ngx-toastr';
import { NgxSpinnerModule } from 'ngx-spinner';
import { HttpClient, HttpClientModule } from '@angular/common/http';


@NgModule({
    declarations: [
        AppComponent
       
    ],
    providers: [
        { provide:"baseUrl", useValue:"https://localhost:7186/api", multi:true }
    ],
    bootstrap: [AppComponent],
    imports: [
        BrowserModule,
        AppRoutingModule,
        BrowserAnimationsModule,
        ComponentsModule,
        AdminModule,
        UiModule,
        ToastrModule.forRoot(),
        NgxSpinnerModule,
        HttpClientModule


    ]
})
export class AppModule { }
