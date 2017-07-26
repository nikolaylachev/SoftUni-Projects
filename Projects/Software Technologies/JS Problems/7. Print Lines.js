function solve(arr) {

    let i = 0;
    while(true) {

        if(arr[i] ==='Stop'){
            break;
        }

        else {
            console.log(arr[i]);
            i++;
        }
    }
 
}
console.log(solve(['4', '2', '3', 'Stop', '5']));