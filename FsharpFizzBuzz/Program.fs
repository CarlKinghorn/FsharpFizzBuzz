// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open System

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

[<EntryPoint>]
let main argv = 
    printfn "Iterative:\n%s" (IterativeFizzBuzz 1 100)
    Console.ReadLine() |> ignore
    0 // return an integer exit code
