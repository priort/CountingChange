// Learn more about F# at http://fsharp.org

open System
open System.Collections.Generic
open CountingChange.ChangeCombinationsCount

[<EntryPoint>]
let main argv =
    let amount = (Console.ReadLine().Split([|' '|])).[0] |> int
    let denominations = (Console.ReadLine().Split([|' '|])) |> Array.toList |> List.map int
    printfn "%i" <| countChange amount denominations 
    0 // return an integer exit code
