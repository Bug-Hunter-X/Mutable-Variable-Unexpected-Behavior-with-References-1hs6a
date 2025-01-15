let mutable x = 10
let y = &x
printfn "x before: %d" x // Output: 10
!y <- 20
printfn "x after: %d" x  // Output: 20

// Explanation:
// In F#, mutable variables are directly modified when accessed via their references.
// The assignment '!y <- 20' directly changes the value at the memory location pointed to by y, which is the same location where x is stored.