
function solve(arr) {

    let n = Number(arr[0]);
    let x = Number(arr[1]);
    
    if(x >= n){
        return x * n;
    }
    else if(n > x){
        return n/x;
    }
    //return num1 * num2;
}
console.log(solve(['3', '2']));