module TextPredictionTests

open Xunit
open TextPrediction

let test digits expected =
    let actual = getLetterCombinations digits
    Assert.Equal<seq<string>>(expected, actual)

[<Fact>]
let ``Returns correct combos for 2`` () =
    test "2" ["a"; "b"; "c"]

[<Fact>]
let ``Returns correct combos for 3`` () =
    test "3" ["d"; "e"; "f"]

[<Fact>]
let ``Returns correct combos for 4`` () =
    test "4" ["g"; "h"; "i"]

[<Fact>]
let ``Returns correct combos for 5`` () =
    test "5" ["j"; "k"; "l"]

[<Fact>]
let ``Returns correct combos for 6`` () =
    test "6" ["m"; "n"; "o"]

[<Fact>]
let ``Returns correct combos for 7`` () =
    test "7" ["p"; "q"; "r"; "s"]

[<Fact>]
let ``Returns correct combos for 8`` () =
    test "8" ["t"; "u"; "v"]

[<Fact>]
let ``Returns correct combos for 9`` () =
    test "9" ["w"; "x"; "y"; "z"]

[<Fact>]
let ``Returns example double digit combinations`` () =
    test "23" ["ad"; "ae"; "af"; "bd"; "be"; "bf"; "cd"; "ce"; "cf"]

[<Fact>]
let ``Returns baby got back`` () =
    let actual = getLetterCombinations "6492568"
    Assert.Contains("mixalot", actual)
