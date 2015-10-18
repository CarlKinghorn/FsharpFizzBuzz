module NaiveFizzBuzz

let MatchFizzBuzz x =
    match x with
    | x when x % 3 = 0 && x % 5 = 0 -> "FizzBuzz"
    | x when x % 3 = 0 -> "Fizz"
    | x when x % 5 = 0 -> "Buzz"
    | _ -> x.ToString()

let IterativeFizzBuzz start max =
    let mutable i = start
    let mutable acc = ""
    while i <= max do
        acc <- acc + (MatchFizzBuzz i) + "\n"
        i <- i+1
    acc