import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Todo } from '../todo';

@Component({
  selector: 'app-edit-todo',
  templateUrl: './edit-todo.component.html',
  styleUrls: ['./edit-todo.component.css']
})
export class EditTodoComponent {
  @Output() editEvent = new EventEmitter<Todo>();
  
  @Input() editTask:Todo = {} as Todo;


  UpdateTask(){
    return this.editEvent.emit(this.editTask);
  }
}
