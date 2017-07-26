function solve(arr) {
    let arrLength = arr.length;

    let objectsArr = [];

    let obj = {};

    let name = "";
    let age = "";
    let grade = "";

    let tokens = "";
    for(let i = 0; i < arrLength; i++){
        tokens = arr[i].split(" -> ");
        //console.log(tokens);

        name = tokens[0];
        age = tokens[1];
        grade = tokens[2];

        obj = {
            "Name": name,
            "Age": age,
            "Grade": grade, 
        };

        objectsArr.push(obj);
    }
   //console.log(objectsArr);

   for(let i = 0; i < objectsArr.length; i++){
       console.log(`Name: ${objectsArr[i].Name}`);
       console.log(`Age: ${objectsArr[i].Age}`);
       console.log(`Grade: ${objectsArr[i].Grade}`);       
   }
}

let input = [
'Pesho -> 13 -> 6.00', 
"Ivan -> 12 -> 5.57",
'Toni -> 13 -> 4.90'
];
console.log(solve(input));