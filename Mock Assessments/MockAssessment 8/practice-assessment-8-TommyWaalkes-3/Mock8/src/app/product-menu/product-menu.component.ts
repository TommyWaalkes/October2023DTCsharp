import { Component } from '@angular/core';
import { Product } from '../product';
import { ProductService } from '../product.service';

@Component({
  selector: 'app-product-menu',
  templateUrl: './product-menu.component.html',
  styleUrls: ['./product-menu.component.css']
})
export class ProductMenuComponent {

  allProducts:Product[] = []; 
  constructor(private productService: ProductService){
    this.allProducts = this.productService.getAllProducts();
  }
}
