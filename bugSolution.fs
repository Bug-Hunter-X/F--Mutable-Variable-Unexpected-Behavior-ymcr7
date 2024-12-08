let x = 10
let y = 20

let add x y = 
    let sum = x + y
    let newX = sum + y
    let newY = sum + x
    sum

let result = add x y
printf "%d" result // Expected output: 30, Actual output: 30

//The solution avoids modifying the input mutable variables. A new variable `sum` is created to store the intermediate result, which is then returned. This ensures that the input variables retain their original values.