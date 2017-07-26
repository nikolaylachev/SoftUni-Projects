function solve(arr) {
   let n = Number(arr.shift());

    let length = arr.length;

    let result = [];//Empty array
     let pairs = [];

    for(let i = 1; i <= length; i++) {

       
        pairs = arr.shift();
        pairs = pairs.split("- ");
   
        //console.log(pairs);

        result[Number(pairs[0])] = Number(pairs[1]);
        //console.log(result);
   }
    for(let i = 0; i < n; i++) {
        if(result[i] === undefined){
            result[i] = 0;
        }
    }

    console.log(result.join('\n'));
}

let input = ['5', '0 - 3', '3 - -1', '4 - 2'];
console.log(solve(input));