interface Room{
    //Everything but class names in JS are camelCase
    //Class names are TitleCase
    //Interfaces main job for us is acting as models
    length:number;
    width:number;
    height:number;
    studentIds: number[];
}

function getArea(room :Room):number{
    return room.length * room.width;
}

function CalcRoom():void{
    //We in typescript can no longer automatically convert between datatypes 
    //We must do casts or explicit conversions 
    //Javascript arrays may shrink or grow in size and can handle 
    //Most operations collections can perform, therefore 
    //Javascript doesn't have collections, there isn't a good built in version of 
    //dictionary/hashmaps
    let nums:number[] = [];

    let input  = prompt("Please input a length");
    let convertedInput:String = new String(input);
    let length:number = parseInt(convertedInput.toString());

    let input2  = prompt("Please input a width");
    let convertedInput2:String = new String(input2);
    let width:number = parseInt(convertedInput2.toString());

    //Interfaces can't have constructor
    //let room:Room = new Room();

    //This is the interface creation syntax it is one way you can create 
    //JS objects without calling their constructor. 
    let room:Room = {height:10, width:width, length:length, studentIds:[]};
    console.log(room);
    let area:number = getArea(room);
    console.log("Area: " + area);

}