# F# Mutable Variable Unexpected Behavior

This repository demonstrates a potential issue when using mutable variables in F# functions. The `add` function modifies its input mutable variables `x` and `y`, leading to unexpected results if the function is called multiple times with the same variables.

## Bug Description
The `add` function calculates the sum of `x` and `y`, updates `x` and `y` with new values, and returns the sum. When the function is called, the mutable variables are modified, leading to the unexpected result.

## Solution
The solution involves avoiding the modification of mutable variables within the function. We create a new variable to store the intermediate result before returning the final sum. This maintains the original values of the input variables. 