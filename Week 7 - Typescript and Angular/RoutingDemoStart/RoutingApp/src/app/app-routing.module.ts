import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HelloWorldComponent } from './hello-world/hello-world.component';
import { FishFactsComponent } from './fish-facts/fish-facts.component';
import { ContactComponent } from './contact/contact.component';
import { NotFoundComponent } from './not-found/not-found.component';

const routes: Routes = [
  //Path is what we want to name the route, it ties the URL to this route 
  //Component is for the component we want to swap into for this route

  //Routes are handled on a first match basis. 
  {path:"HelloWorld", component: HelloWorldComponent}, 
  {path:"FishFacts", component:FishFactsComponent}, 
  {path:"Contact", component:ContactComponent}, 
  //if given an empty path, redirect to hello world 
  //This is how we set our landing, which is the first page we see when load up
  //Think of it like the index page in HTML 
  {path:"", redirectTo:"HelloWorld", pathMatch:'full'},
  //This is a wild card, anything that gets down this route will display 
  //Wild card routes should go last 
  {path:"**", component:NotFoundComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
