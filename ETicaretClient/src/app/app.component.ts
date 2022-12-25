import { Component } from '@angular/core';
import { NgxSpinnerService } from 'ngx-spinner/public_api';
import { ToastrService } from 'ngx-toastr';
import { CustomToastrService, OzelToastMesajTipi, ToastPosition } from './services/ui/custom-toastr.service';
declare var $ : any;

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'ETicaretClient';
}

$.get("https://localhost:7186/api/products", data=>{
  console.log(data);    
})

