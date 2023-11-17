import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { ListItemComponent } from './list-item/list-item.component';
import { AddNewTodoComponent } from './add-new-todo/add-new-todo.component';
import { FormsModule } from '@angular/forms';
import { EditTodoComponent } from './edit-todo/edit-todo.component';
import { RouterModule, Routes } from '@angular/router';
import { MainComponent } from './main/main.component';

let routes:Routes = [
  {path:"Item", component:ListItemComponent},
  {path:"Edit", component:EditTodoComponent}, 
  {path:"AddNew", component: AddNewTodoComponent},
  {path:"Main", component:MainComponent},
  {path:'', pathMatch:"full", redirectTo:"Main"}
  
]
@NgModule({
  declarations: [
    AppComponent,
    ListItemComponent,
    AddNewTodoComponent,
    EditTodoComponent,
    MainComponent
  ],
  imports: [
    BrowserModule, 
    FormsModule,
    [RouterModule.forRoot(routes)]
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
