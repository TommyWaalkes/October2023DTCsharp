import { Component } from '@angular/core';
import { Login } from './login';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'FormApp';
  name:string = "";
  logins:Login[] = [];
  login:Login = {} as Login;

  AddNewLogin(){
    //Without making a new variable, this will point every entry 
    //in the array to the same spot in memory. Changes made on the form 
    //Change every item in the array. 
    let newLog:Login = {userName:this.login.userName, 
                        email:this.login.email, 
                        password:this.login.password, 
                        age:this.login.age
                      };
    this.logins.push(newLog);
  }
}
