//Javascript does not follow the 1 class 1 file rule, you can have as many classes 
//as you wish in the same. You may also put in inline code. 

interface Product{
    price:number; 
    name:string; 
    quantity:number;
}

//Without typescript JS arrays will allow in any data type. 
// let products: Product[] = [{name:"Gum", price: 0.75 },
//             {name:"Doritos", price:2.99},
//             {name:"Beef Jerky", price:5.99}, 
//             {name:"Snickers Bar", price:1.99}             
// ];

let products:Product[] = [
    {name:"Motor", price:10, quantity: 10}, 
    {name:"Sensor", price:12.50, quantity:4},
    {name: "LED", price:1.00, quantity:20}
];

function averagePrices(products:Product[]){
    let sum:number = 0; 
    for(let i = 0; i < products.length; i++){
        sum+= products[i].price;
    }

    return sum/products.length;
}

let average:number = averagePrices(products);

// console.log(average);

function calcInventoryValue(products: Product[]){
    let sum:number = 0; 
    for(let i = 0; i < products.length; i++){
        sum += products[i].price * products[i].quantity;
    }

    return sum; 
}

let totalValue:number = calcInventoryValue(products);
console.log(totalValue);