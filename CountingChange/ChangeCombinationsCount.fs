module CountingChange.ChangeCombinationsCount

open System.Collections
open System.Collections.Generic

let rec private numberOfCombinations (amount:int) (denominations: int list) (prevCalculatedSolutions:Dictionary<int * Set<int>, int64>) =
    if prevCalculatedSolutions.ContainsKey((amount, Set.ofList denominations)) then 
        prevCalculatedSolutions.GetValueOrDefault((amount, Set.ofList denominations), 0L)
    else
        match denominations with 
        | [] ->
            0L
        | d :: ds ->
            if amount = 0 then
                1L 
            elif amount < 0 then
                0L
            else 
                let solution = 
                    (numberOfCombinations (amount - d) denominations prevCalculatedSolutions) + 
                    (numberOfCombinations amount ds prevCalculatedSolutions) |> int64
                
                prevCalculatedSolutions.Add((amount, Set.ofList denominations), solution) |> ignore
                solution

let countChange (amount:int) (denominations: int list) =
    numberOfCombinations amount (denominations |> List.sortDescending) (new Dictionary<int * Set<int>, int64>())
