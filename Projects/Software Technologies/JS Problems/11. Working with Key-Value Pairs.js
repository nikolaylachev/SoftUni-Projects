function solve(arr){

    
    let pairs = [];
    let key = arr.pop();
    //console.log(typeof(key));//Prints: key

    let length = arr.length;
    
    let result = [];

    for(let i = 0; i < length; i++){
        pairs = arr[i]; //arr.shift();
        pairs = pairs.split(' ');//key is pairs[0], value is pairs[1]
        //console.log(pairs);

        let keyFromPairs = pairs[0];
        let valueFromPairs = pairs[1];
        result[keyFromPairs] = valueFromPairs;
        //console.log(result);
        
    }
       let giveValue =  getValue(key);
       
       function getValue(myKey){
           if(result[myKey] !== undefined){
            return result[myKey];
            }
            else if(result[myKey] === undefined){
                return 'None';
            }
       }  
       
       console.log(giveValue);
}

let input = [
    '3 test',
    '3 test1',
    '4 test2',
    '3',
    ];
solve(input);