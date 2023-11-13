class Product{
    price; 
    name; 

    constructor(name, price){
        this.price = price; 
        this.name = name;
    }
}

//Without typescript JS arrays will allow in any data type. 
products = [new Product("Gum", 0.75 ),
            new Product("Doritos", 2.99),
            new Product("Beef Jerky", 5.99), 
            new Product("Snickers Bar", 1.99)             
];
cart = [];
DisplayProducts();

function DisplayProducts(){
    //This will empty out the products div
    document.getElementById("Products").innerText = "";
    for(let i = 0; i < products.length; i++){
        p = products[i];
        document.getElementById("Products").innerHTML += 
            `<p>Name: ${p.name}, Price: ${p.price} </p> 
            <button onclick="AddToCart(${i})" > Add ${p.name} </button>`
    }
}

function AddToCart(productIndex){
   let p = products[productIndex]; 
   //This is the same as an add in a C# list. 
   //Why is it called push and not add? 
   //JS Arrays are designed to fill as many roles as possible 
   //One of those is being a stack, which has push and pop methods for adding and removing respectively
   cart.push(p);

   console.log(cart);
}

function Checkout(){
    let total = 0; 
    for(let i = 0; i < cart.length; i++){
        total += cart[i].price;
    }

    document.getElementById("GrandTotal").innerHTML = `<p>Total:$${total.toFixed(2)}</p>`
}

function addNewProduct(){
    let name = document.getElementById("Name").value;
    let price = document.getElementById("Price").value;
    let newProd = new Product(name, parseFloat(price));

    products.push(newProd);
    DisplayProducts();
}

