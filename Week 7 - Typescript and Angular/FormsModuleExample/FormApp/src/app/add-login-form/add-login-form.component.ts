import { Component, EventEmitter, Output } from '@angular/core';
import { Login } from '../login';

@Component({
  selector: 'app-add-login-form',
  templateUrl: './add-login-form.component.html',
  styleUrls: ['./add-login-form.component.css']
})
export class AddLoginFormComponent {
  @Output() newLoginEvent = new EventEmitter<Login>();
  login:Login = {} as Login;

  AddLogin(){
    console.log(this.login);
    //This sends the object out to another component
    //Recall the Etymology of emit 
    //Latin: Ex - out and away from and Mitto - Send
    this.newLoginEvent.emit(this.login);
  }
}
