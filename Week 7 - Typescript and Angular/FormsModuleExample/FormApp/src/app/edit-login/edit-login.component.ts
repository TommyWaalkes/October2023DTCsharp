import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Login } from '../login';

@Component({
  selector: 'app-edit-login',
  templateUrl: './edit-login.component.html',
  styleUrls: ['./edit-login.component.css']
})
export class EditLoginComponent {

  @Output() doneEditingEvent = new EventEmitter<Login>();
  @Input() 
  editLog:Login = {} as Login;

  EmitEdit(){
    this.doneEditingEvent.emit(this.editLog);
  }
}
