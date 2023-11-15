import { Component } from '@angular/core';
import { MenuItem } from './MenuItem';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'PizzaApp';
  menuItems:MenuItem[] = [
    {name:"Garlic Bread", category:"Appetizer", price:10.99}, 
    {name:"Cheese Pizza", category:"Dinner", price:11.99},
    {name:"House Salad", category:"Side", price:3.99}, 
    {name:"Pizza Sub", category:"Dinner", price:8.99}
  ];

  getByCategory(cat: string):MenuItem[]{
    let output:MenuItem[] = []; 
    for(let i = 0; i < this.menuItems.length; i++){
      let item: MenuItem = this.menuItems[i];
      if(item.category == cat){
        //This acts like add in C#, the terms pop and push come from stacks n queues 
        output.push(item);
      }
    }

    return output;
  }

  getCategories():string[]{
    return ["Dinner", "Appetizer", "Side"];
  }

}
