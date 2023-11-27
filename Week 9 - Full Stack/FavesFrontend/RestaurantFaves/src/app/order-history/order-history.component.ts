import { Component, OnInit } from '@angular/core';
import { OrdersService } from '../orders.service';
import { Order } from '../order';

@Component({
  selector: 'app-order-history',
  templateUrl: './order-history.component.html',
  styleUrls: ['./order-history.component.css']
})
export class OrderHistoryComponent implements OnInit {

  orders:Order[] = [];
  constructor(private orderApi: OrdersService){

  }
  ngOnInit(): void {
    this.orderApi.GetOrders().subscribe(
      (result) =>{
        this.orders = result;
      }
    )
  }

  AddOrder(newOrder:Order) : void{
    // this.orders.push(newOrder);
    //1) we need to send newOrder to our DB 
    //2) we need to refresh our array 
    this.orderApi.AddOrder(newOrder).subscribe(
      ()=>{
        this.orderApi.GetOrders().subscribe(
          (result) =>
          {
            this.orders = result;
          }
        )
      }
    )
  }

}
