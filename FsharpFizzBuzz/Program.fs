// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open System
open NaiveFizzBuzz
open RecursiveFizzBuzz


[<EntryPoint>]
let main argv = 
    printfn "Iterative:\n%s" (IterativeFizzBuzz 1 100)
    printfn "Recursive:\n%s" (RecursiveFizzBuzz 1 100)
    printfn "Tail Recursive:\n%s" (TailRecursiveFizzBuzz 1 100 "")
    Console.ReadLine() |> ignore
    0 // return an integer exit code
