import { Component, Input } from '@angular/core';
import { Login } from '../login';

@Component({
  selector: 'app-login-details',
  templateUrl: './login-details.component.html',
  styleUrls: ['./login-details.component.css']
})
export class LoginDetailsComponent {
  @Input()
  l:Login = {} as Login;
}
