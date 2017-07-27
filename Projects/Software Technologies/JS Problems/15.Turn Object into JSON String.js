function solve(arr){

    let obj = {};

    arr.map(a => a.split(' -> ')).forEach(studentsTokens => {
     let property = studentsTokens[0];
     let value = isNaN(studentsTokens[1]) ? studentsTokens[1] : Number
     (studentsTokens[1]);

     obj[property] = value;
    });

    console.log(JSON.stringify(obj));

}