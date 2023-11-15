import { Component, Input } from '@angular/core';
import { Todo } from '../todo';

@Component({
  selector: 'app-list-item',
  templateUrl: './list-item.component.html',
  styleUrls: ['./list-item.component.css']
})
export class ListItemComponent {
  
  @Input()
  listItem:Todo = {} as Todo;

  CompleteItem(){
    this.listItem.completed = true;
  }
}
