function solve(arr) {

    let key = arr.pop();

    let arrLength = arr.length;

    let pairs = [];
    let result = [];

    for(let i = 0; i < arrLength; i++){

        pairs = arr.shift();
        pairs = pairs.split(" ");

        let obj = {
            key: pairs[0],
            value: pairs[1],
         };

         result.push(obj);

    }


    result = result.filter(x => x.key == key);
    if(result !== undefined && result.length > 0){
        for(let i = 0; i < result.length; i++){
            console.log(result[i].value);
        }
    }
    else{
        console.log("None");
    }
}

let input = ['3 test', '3 test1','4 test2', '4 test3', '4 test5', '4'];
console.log(solve(input));