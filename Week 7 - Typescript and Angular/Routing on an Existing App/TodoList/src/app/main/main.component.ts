import { Component } from '@angular/core';
import { Todo } from '../todo';

@Component({
  selector: 'app-main',
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.css']
})
export class MainComponent {
  title = 'TodoList';
  todoList:Todo[] = [
    {name:"Water Cat", completed:false}, 
    {name:"Get Mail", completed:true}, 
    {name:"Mow Lawn", completed:false}, 
    {name:"Cheat on our taxes", completed:true}
  ];

  AddNewTask(t:Todo){
    let todo: Todo = {name:t.name, completed:false};
    this.todoList.push(todo);
  }

  DeleteTodo(index:number){
    this.todoList.splice(index,1);
  }
}
