function SwapStyles(){
    //Always returns an array even if there are 1 or 0 elements
    let textNodes = document.querySelectorAll(".text")
    
    for(let i = 0; i < textNodes.length; i++){
        textNodes[i].style.color = "white"; 
    }

    document.getElementById("Image").setAttribute("src", "Shrek.png");

    let bodies = document.getElementsByTagName("body");

    for(let i = 0; i < bodies.length; i++){
        bodies[i].style.backgroundColor = "green";
    }

    let lorem = document.getElementById("IpsumLorem");
    lorem.innerText = "Pain might be the word itself. I am, it is, to you, and he does not have queso"
}