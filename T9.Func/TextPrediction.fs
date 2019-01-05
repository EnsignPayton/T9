module TextPrediction

let private _mappings =
    [
        2, "abc";
        3, "def";
        4, "ghi";
        5, "jkl";
        6, "mno";
        7, "pqrs";
        8, "tuv";
        9, "wxyz";
    ] |> Map.ofList

let private getCombos digit =
    _mappings.[digit]
    |> Seq.map (fun c -> string c)

let private getCombosAppend digit str =
    _mappings.[digit]
    |> Seq.map (fun c -> str + string c)

let private foldDigits acuum digit =
    acuum |> Seq.collect (fun partial -> getCombosAppend digit partial)

let private _getLetterCombinations (digits : seq<int>) : seq<string> =
    let first = (digits
        |> Seq.head
        |> getCombos)
    digits
    |> Seq.skip 1
    |> Seq.fold foldDigits first

let getLetterCombinations (digits : string) : seq<string> =
    let intDigits = digits |> Seq.map (fun d -> int d - int '0')
    _getLetterCombinations intDigits
