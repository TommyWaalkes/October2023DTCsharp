interface Mountain{
    name:string, 
    height:number
}

let mountains: Mountain[] = [
    {name:"Kilimanjaro", height:19341}, 
    {name:"Everest", height:29029},
    {name:"Denali", height:20310}
];

function findTallestMountain(mountains: Mountain[]) : string{
    let tallest:Mountain = {name:"", height:0};
    for(let i = 0; i < mountains.length; i++){
        if(tallest.height < mountains[i].height){
            tallest = mountains[i];
        }
    }

    return tallest.name;
}

let output : string = findTallestMountain(mountains);
console.log(output);