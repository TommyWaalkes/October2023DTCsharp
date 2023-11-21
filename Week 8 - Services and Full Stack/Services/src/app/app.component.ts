import { Component } from '@angular/core';
import { AreaService } from './area.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Services';
  len:number = 10;
  wid:number = 1; 
  area:number = 0; 
  shapes:string[] = [
    "square",
    "triangle",
    "rectangle"
  ];

  selected:string = this.shapes[0];

  getSquareArea(){
    this.area = this.len * this.len;
  }
  getRectangleArea(){
    this.area = this.len * this.wid;
  }

  getTriangleArea(){
    this.area = this.len * this.wid / 2;
  }

  getTriangle(){
    return {
      height:0, 
      width: 0, 
      borderLeft: `${this.len * 5}px solid transparent `, 
      borderRight:`${this.len * 5}px solid transparent `,
      borderBottom:`${this.wid * 5}px solid red`   }
  }


  //This pops a service object into existance for the rest of this component to use 
  //This is where the depency injection is happening in Angular
  constructor(private areaService:AreaService){

  }

}
