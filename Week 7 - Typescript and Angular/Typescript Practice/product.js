//Javascript does not follow the 1 class 1 file rule, you can have as many classes 
//as you wish in the same. You may also put in inline code. 
//Without typescript JS arrays will allow in any data type. 
// let products: Product[] = [{name:"Gum", price: 0.75 },
//             {name:"Doritos", price:2.99},
//             {name:"Beef Jerky", price:5.99}, 
//             {name:"Snickers Bar", price:1.99}             
// ];
var products = [
    { name: "Motor", price: 10, quantity: 10 },
    { name: "Sensor", price: 12.50, quantity: 4 },
    { name: "LED", price: 1.00, quantity: 20 }
];
function averagePrices(products) {
    var sum = 0;
    for (var i = 0; i < products.length; i++) {
        sum += products[i].price;
    }
    return sum / products.length;
}
var average = averagePrices(products);
// console.log(average);
function calcInventoryValue(products) {
    var sum = 0;
    for (var i = 0; i < products.length; i++) {
        sum += products[i].price * products[i].quantity;
    }
    return sum;
}
var totalValue = calcInventoryValue(products);
console.log(totalValue);
