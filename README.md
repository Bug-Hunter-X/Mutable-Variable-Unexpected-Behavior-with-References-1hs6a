# F# Mutable Variable Unexpected Behavior with References
This example demonstrates a potential confusion when working with mutable variables and references in F#. The issue stems from how changes through references are handled.

## The Bug
The code initializes a mutable integer `x` to 10.  A reference to `x` is then created using `&x`.  Modifying the value through the reference `!y <- 20` unexpectedly alters the original variable `x`.

## The Solution
The solution provides clarification.  It emphasizes that modifying a value using a reference directly updates the original mutable variable. This behavior, while correct, can be unexpected for developers coming from other languages.