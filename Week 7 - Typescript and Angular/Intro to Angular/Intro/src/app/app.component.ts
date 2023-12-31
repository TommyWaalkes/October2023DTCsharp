import { Component } from '@angular/core';
import { Student } from './student';

@Component({
  //This is how you call this component elsewhere. We will get into 
  //selectors more when we do multiple components.
  selector: 'app-root',

  //This is the url for the view file. Generally the convention is to name 
  //the view and controller the same thing. 
  templateUrl: './app.component.html',
  //This points to the stylesheet that exist just for this view. 
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Intro';
  //Any variable in the component class are accesible in the html view 
  names:string[] =["Jimmy", "Timmy", "Kimmy"];
  stu:Student = {name:"Jake", favoriteFood:"Hamburgers", hometown:"Detroit"}
  students:Student[] = [
    {name:"Gary", favoriteFood:"Porridge", hometown:"Boston, MA"},
    {name:"Sandra", favoriteFood:"Chicken Nuggets", hometown:"Houston, Texas"},
    {name:"Frank", favoriteFood:"Mac N Cheese", hometown:"Portland, Oregon"}
  ]
  //This casts an empty object to be our selected student
  selectedStudent: Student = {} as Student;

  selectStudent(index:number){
    this.selectedStudent = this.students[index];
    console.log(this.selectedStudent);
  }
}
