import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { FormsModule } from '@angular/forms';
import { AddLoginFormComponent } from './add-login-form/add-login-form.component';
import { LoginDetailsComponent } from './login-details/login-details.component';
import { EditLoginComponent } from './edit-login/edit-login.component';

@NgModule({
  declarations: [
    AppComponent,
    AddLoginFormComponent,
    LoginDetailsComponent,
    EditLoginComponent
  ],
  imports: [
    BrowserModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
