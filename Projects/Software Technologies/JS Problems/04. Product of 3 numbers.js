
function solve(arr) {

    let firstNum = Number(arr[0]);
    let secondNum = Number(arr[1]);
    let thirdNum = Number(arr[2]);
    
    if(firstNum == 0 || secondNum == 0 || thirdNum == 0){
        
        console.log("Positive");
    }

    else{
       
        let negativeNumbersCount = 0;

        if(firstNum < 0) {
            negativeNumbersCount++;
        }

        if(secondNum < 0) {
            negativeNumbersCount++;
        }

        if(thirdNum < 0) {
            negativeNumbersCount++;
        }

        if(negativeNumbersCount % 2 == 1){
            console.log("Negative");
        }

        else{
            console.log("Positive");
        }

    }
   
}
console.log(solve(['3', '-2','-1']));