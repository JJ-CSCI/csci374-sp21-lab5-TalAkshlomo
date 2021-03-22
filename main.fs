module Assignment

type Tree =
    | Node of Tree * Tree
    | Leaf of int

let rec prod (t:Tree) :int =
    let test = Node 23
    match test with
    | Node t
    | Leaf l when t > 23 -> t
    | _ -> 1

let rec map (f:int->int) (t:Tree) :Tree =
    t

let rec foldStr (nf:string -> string -> string) (lf:int->string) (t:Tree) :string =
    ""

// let result (r:Error) :int =
//    match r with
//    OK -> 0 
//    Err n -> n