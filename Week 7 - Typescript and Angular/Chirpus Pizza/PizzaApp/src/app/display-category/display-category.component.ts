import { Component, Input, OnInit } from '@angular/core';
import { MenuItem } from '../MenuItem';

@Component({
  selector: 'app-display-category',
  templateUrl: './display-category.component.html',
  styleUrls: ['./display-category.component.css']
})
export class DisplayCategoryComponent implements OnInit {
  @Input()
  inputCategory:string = "";
  menuItems:MenuItem[] = [
    {name:"Garlic Bread", category:"Appetizer", price:10.99}, 
    {name:"Cheese Pizza", category:"Dinner", price:11.99},
    {name:"House Salad", category:"Side", price:3.99}, 
    {name:"Pizza Sub", category:"Dinner", price:8.99}
  ];

  displayItems:MenuItem[] = [];

  constructor(){
    //The input has not yet made it into our child component here
    
  }
  
  ngOnInit(): void {
    this.getByCategory(); 
  }

  getByCategory():MenuItem[]{
   
    for(let i = 0; i < this.menuItems.length; i++){
      let item: MenuItem = this.menuItems[i];
      console.log(item);
      if(item.category === this.inputCategory){
        //This acts like add in C#, the terms pop and push come from stacks n queues 
        this.displayItems.push(item);
        //console.log(this.menuItems)
      }
    }

    return this.displayItems;
  }

}
