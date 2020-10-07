// Learn more about F# at http://fsharp.org

open System
(* This is block comment *)

let result = 1 + 1 = 2

let hello = "New" + " Aeon"

let verbatimXML = @"<book title=""Paradise Lost"">"

let b, i, l = 86uy, 86, 86L

let s, f, d, bi = 4.14F, 4.14, 0.7833M, 9999I

let negate x = x * -1 
let square x = x * x
let print x = printfn "The number is: %d" x

let ``square, negate, then print `` x = x |> square |> negate |> print

let sumOfLengths (xs : string[]) =
  xs
  |> Array.map (fun s -> s.Length)
  |> Array.sum

[<EntryPoint>]
let main argv =
    printfn "Hello, from F#. This is your friendly captain Abifoluwa."
    0 // return an integer exit code

