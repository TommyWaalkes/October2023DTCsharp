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
  area:number = 0; 
  style:string = `width: ${this.len}; height: ${this.len}; background-color: red;`;
  //This pops a service object into existance for the rest of this component to use 
  //This is where the depency injection is happening in Angular
  constructor(private areaService:AreaService){

  }

  getSquareArea(){
    this.area = this.areaService.getSquare(this.len);
    //this.style = `width: '${this.len}'; height: '${this.len}'; background-color: red;`;
    document.getElementById("Square")?.style.width = this.len;
    document.getElementById("Square")?.style.height = this.len;

  }

  getLen(){
    return this.len;
  }
}
