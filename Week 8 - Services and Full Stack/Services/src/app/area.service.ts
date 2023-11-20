//This import allows the service to be used via depency injection
import { Injectable } from '@angular/core';

//This means any componet in the app folder can use this service
@Injectable({
  providedIn: 'root'
})
export class AreaService {

  constructor() { }

  getSquare(side:number):number{
    return side*side;
  }

  getRectangle(len:number, width:number):number{
    return len * width;
  }

  getTriangle(len:number, width:number):number{
    return (len * width)/2;
  }

  getCircle(rad:number):number{
    return rad*rad*Math.PI;
  }
}
