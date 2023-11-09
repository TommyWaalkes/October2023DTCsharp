// let goOn = true; 

// while(goOn === true){
//     console.log("Hello and welcome to our room calculator app");
//     let width = prompt("Please input a number for width."); 
//     let height = prompt("Please input a number for height."); 
//     let length = prompt("Please input a length");

//     let area = width * length; 
//     let volume = area * height; 
//     let perimeter = 2*width + 2*length;

//     console.log(`Area: ${area}`);
//     console.log(`Volume: ${volume}`);
//     console.log(`Perimeter: ${perimeter}`);

//     goOn = KeepRunning();
// }

function CalcRoom(){
    //Since we're on a form input, we use the value property instead
    let height = document.getElementById("Height").value;
    console.log(height);
    let width = document.getElementById("Width").value; 
    let length = document.getElementById("Length").value;

    document.getElementById("Area").innerText ="Area: "+ length * width;
    document.getElementById("Volume").innerText ="Volume: "+ length * width * height;
    document.getElementById("Perimeter").innerText ="Perimeter: "+ (2*length + 2*width);
}

function KeepRunning(){
    let input = prompt("Would you like to continue? y/n").toLowerCase(); 

    if(input === "y"){
        return true;
    }
    else if(input === "n"){
        console.log("Good bye!");
        return false; 
    }
    else{
        alert("I didn't understand let's try again"); 
        return KeepRunning(); 
    }
}


