function solve(arr) {
   
    
    //console.log(arr);
   // arr = arr.toString();
    //console.log(arr);
    

    let objectsArr = [];

    let obj = {};

    for(let i = 0; i < arr.lenght; i++){

       console.log(arr[i]);
       obj = JSON.parse(arr[i]);

        console.log(obj);

        objectsArr.push(obj);
    }
    //console.log(objectsArr);
   /* let obj = JSON.parse('{"name":"Tosho","age":11,"date":"04/04/2005"}');
    console.log(obj);*/
}

let input = [
'{"name":"Gosho","age":10,"date":"19/06/2005"}', 
'{"name":"Tosho","age":11,"date":"04/04/2005"}',
];
console.log(solve(input));