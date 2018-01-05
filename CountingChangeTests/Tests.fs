module CountingChange.Tests

open Xunit
open FsUnit.Xunit
open System.Collections.Generic
open CountingChange.ChangeCombinationsCount


[<Fact>]
let ``number of combinations for amount 4 and denominations 1,2,3 should be 4`` () =
    countChange 4 [ 1; 2; 3 ] |> should equal 4L 
    
[<Fact>]
let ``number of combinations for amount 15 and denominations 10,5,3 should be 3`` () =
    countChange 15 [ 10; 5; 3 ] |> should equal 3L 

[<Fact>]
let ``number of combinations for amount 10 and denominations 2,5,3,6 should be 5`` () =
    countChange 10 [ 2; 5; 3; 6 ] |> should equal 5L

[<Fact>]
let ``number of combinations for amount 3 and denominations 8,3,1,2 should be 3`` () =
    countChange 3 [ 8; 3; 1; 2 ] |> should equal 3L

[<Fact>]
let ``number of combinations for amount 166 and denominations 5 37 8 39 33 17 22 32 13 7 10 35 40 2 43 49 46 19 41 1 12 11 28 should be 96190959`` () =
    countChange 166 [ 5; 37; 8; 39; 33; 17; 22; 32; 13; 7; 10; 35; 40; 2; 43; 49; 46; 19; 41; 1; 12; 11; 28 ] |> should equal 96190959L

[<Fact>]
let ``number of combinations for amount 219 and denominations 36 10 42 7 50 1 49 24 37 12 34 13 39 18 8 29 19 43 5 44 28 23 35 26 should be 168312708`` () =
    countChange 219 [ 36; 10; 42; 7; 50; 1; 49; 24; 37; 12; 34; 13; 39; 18; 8; 29; 19; 43; 5; 44; 28; 23; 35; 26 ] |> should equal 168312708L
