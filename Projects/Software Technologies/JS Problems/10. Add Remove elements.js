function solve(arr) {

    let length = arr.length;

    let pairs = [];
    
    let result = [];

    for(let i = 0; i < length; i++){
        
        pairs = arr.shift();
        pairs = pairs.split(" ");

       // console.log(pairs);
       if(pairs[0] === "add") {

            result.push(Number(pairs[1]));
       }

       else if(pairs[0] === "remove") {
            let index = Number(pairs[1]);

            result.splice(index,1);
       }
  }
    console.log(result.join("\n"));
}

let input = ['add 3', 'add 5','remove 2', 'remove 0','add 7'];
console.log(solve(input));