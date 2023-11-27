import { Component, EventEmitter, Output } from '@angular/core';
import { Order } from '../order';

@Component({
  selector: 'app-add-order-form',
  templateUrl: './add-order-form.component.html',
  styleUrls: ['./add-order-form.component.css']
})
export class AddOrderFormComponent {
  newOrder:Order = {} as Order;
  @Output() newOrderEvent = new EventEmitter<Order>();

  emitOrder(){
    this.newOrderEvent.emit(this.newOrder);
  }
}
