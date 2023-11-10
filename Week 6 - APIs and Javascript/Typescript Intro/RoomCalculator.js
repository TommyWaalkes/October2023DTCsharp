function getArea(room) {
    return room.length * room.width;
}
function CalcRoom() {
    //We in typescript can no longer automatically convert between datatypes 
    //We must do casts or explicit conversions 
    var input = prompt("Please input a length");
    var convertedInput = new String(input);
    var length = parseInt(convertedInput.toString());
    var input2 = prompt("Please input a width");
    var convertedInput2 = new String(input2);
    var width = parseInt(convertedInput2.toString());
    //Interfaces can't have constructor
    //let room:Room = new Room();
    //This is the interface creation syntax it is one way you can create 
    //JS objects without calling their constructor. 
    var room = { height: 10, width: width, length: length };
    console.log(room);
    var area = getArea(room);
    console.log("Area: " + area);
}
