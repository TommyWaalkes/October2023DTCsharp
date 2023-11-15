import { Component } from '@angular/core';
import { Todo } from './todo';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'TodoList';
  todoList:Todo[] = [
    {name:"Water Cat", completed:false}, 
    {name:"Get Mail", completed:true}, 
    {name:"Mow Lawn", completed:false}, 
    {name:"Cheat on our taxes", completed:true}
  ];

  
}
