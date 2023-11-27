import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Order } from './order';

@Injectable({
  providedIn: 'root'
})
export class OrdersService {
  baseUrl: string = "https://localhost:7101/Orders";
  constructor(private http:HttpClient) { }

  GetOrders():Observable<Order[]>{
    return this.http.get<Order[]>(this.baseUrl);
  }

  AddOrder(newValues: Order):Observable<void>{
    return this.http.post<void>(this.baseUrl, newValues);
  }

  DeleteOrder(id: number):Observable<void>{
    return this.http.delete<void>(this.baseUrl+"/"+id);
  }
}
