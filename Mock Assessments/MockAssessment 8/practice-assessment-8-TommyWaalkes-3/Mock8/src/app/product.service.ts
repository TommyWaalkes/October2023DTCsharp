import { Injectable } from '@angular/core';
import { Product } from './product';

@Injectable({
  providedIn: 'root'
})
export class ProductService {
  products:Product[] = [
    {name:"Squeegee", price:19.99, productId:"123s"},
    {name:"Towels", price:30, productId:"fjkd37"},
    {name:"Meat Balls", price: 12.99, productId:"gd38j"},
    {name:"Mountain Dew Gamer Fuel to the Extreme, you are not hardcore enough", price:5.99, productId:"HARDCOREENOUGH"},
    {name:"Pizza nested in Pizza", price:2.99, productId:"Nested"}
  ]

  constructor() { }

  getAllProducts():Product[]{
    return this.products;
  }
}
