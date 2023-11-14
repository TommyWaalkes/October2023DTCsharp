class Country {
    constructor(name, lang, greeting, colors, flag) {
        this.name = name;
        this.lang = lang;
        this.greeting = greeting;
        this.colors = colors;
        this.flag = flag;
    }
}
let usa = new Country("USA", "Murican", "Why Hello there world! Have some McDonalds", ["red", "white", "blue"], "usFlag.svg.png");
let mexico = new Country("Mexico", "Spanish", "Hola mundo!", ["red", "white", "green"],"MexicoFlag.jpg");
let algeria = new Country("Algeria", "Arabic and Berber", "Sup", ["green", "red", "white"], "AlgeriaFlag.jpg")
let japan = new Country("Japan", "Japanese", "Konichiwa", ["white", "red"], "JapanFlag.jpg" )

function SwitchCountry() {
    let input = document.getElementById("CountryList").value; 
    let country;
    
    if (input === "USA") {
        //set country to usa 
        country = usa;
    }
    else if (input === "Mexico") {
        country = mexico;
    }
    else if (input === "Algeria") {
        country = algeria;
    }
    else if(input == "Japan"){
        country = japan;
    }

    document.getElementById("Color1").style.backgroundColor = country.colors[0];
    document.getElementById("Color2").style.backgroundColor = country.colors[1];
    console.log(country.colors.length > 2);
    if(country.colors.length > 2){
        document.getElementById("Color3").style.backgroundColor = country.colors[2];
    }
    else{
        console.log(country.colors[1]);
        document.getElementById("Color3").style.backgroundColor = country.colors[1];
    }

    document.getElementById("CountryName").innerText = country.name; 
    document.getElementById("OfficialLanguage").innerText = country.lang; 
    document.getElementById("HelloWorld").innerText = country.greeting;
    document.getElementById("Flag").setAttribute("src", country.flag)
}
