let mutable x = 10
let mutable y = 20

let add x y = 
    x <- x + y
    y <- y + x
    x + y

let result = add x y
printf "%d" result // Expected output: 60, Actual output: 60

//The bug is that the mutable variables x and y are modified inside the function add,
//leading to unexpected behavior if the function is called multiple times with the same variables.
//In this case, the variables are modified within the function resulting in unexpected results.
//The function correctly calculates the sum and then updates the mutable variables. However, because the updated variables are used in later calculations, the final result is not what's expected. 