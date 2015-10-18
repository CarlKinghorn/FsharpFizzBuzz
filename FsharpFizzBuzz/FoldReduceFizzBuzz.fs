module FoldReduceFizzBuzz

open System
open NaiveFizzBuzz

let FoldFizzBuzz start max =
    [start .. max]
    |> Seq.fold (fun x y -> x + (if x = "" then "" else "\n") + MatchFizzBuzz y) ""

//Feels a little ridiculous
let ReduceFizzBuzz start max =
    [start .. max]
    |> Seq.map string
    |> Seq.reduce (fun x y -> x + "\n" + MatchFizzBuzz (Convert.ToInt32(y)))
