var mountains = [
    { name: "Kilimanjaro", height: 19341 },
    { name: "Everest", height: 29029 },
    { name: "Denali", height: 20310 }
];
function findTallestMountain(mountains) {
    var tallest = { name: "", height: 0 };
    for (var i = 0; i < mountains.length; i++) {
        if (tallest.height < mountains[i].height) {
            tallest = mountains[i];
        }
    }
    return tallest.name;
}
var output = findTallestMountain(mountains);
console.log(output);
