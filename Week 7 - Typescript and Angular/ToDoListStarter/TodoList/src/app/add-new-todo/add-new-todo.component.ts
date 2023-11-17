import { Component, EventEmitter, Output } from '@angular/core';
import { Todo } from '../todo';

@Component({
  selector: 'app-add-new-todo',
  templateUrl: './add-new-todo.component.html',
  styleUrls: ['./add-new-todo.component.css']
})
export class AddNewTodoComponent {
  @Output() newTodoEvent = new EventEmitter<Todo>();
  newTodo:Todo ={} as Todo;

  AddNew(){
    this.newTodoEvent.emit(this.newTodo);
  }
}
