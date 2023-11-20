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
  num:number = this.getRndInteger(1,10);
  getRndInteger(min:number, max:number):number {
    return Math.floor(Math.random() * (max - min) ) + min;
  }
  
  AddNewLogin(){
    //Without making a new variable, this will point every entry 
    //in the array to the same spot in memory. Changes made on the form 
    //Change every item in the array. 
    let newLog:Login = {userName:this.login.userName, 
                        email:this.login.email, 
                        password:this.login.password, 
                        age:this.login.age,
                        isEditing:false
                      };
    this.logins.push(newLog);
  }

  AddLoginFromChild(newLogin:Login){
    let newLog:Login = {userName:newLogin.userName, 
      email:newLogin.email, 
      password:newLogin.password, 
      age:newLogin.age,
      isEditing:false
    };
    this.logins.push(newLog);
  }

  ToggleEditing(index:number){
    this.logins[index].isEditing = !this.logins[index].isEditing;
  }

  DoneEditing(index:number, newValues:Login){
    newValues.isEditing = false;
    this.logins[index] = newValues; 
  }

  DeleteItem(index:number){
    //Splice takes in 2 params: first the index we start at, how many items do we want to delete
    this.logins.splice(index, 1);
  }
}
