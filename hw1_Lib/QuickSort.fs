namespace hw1_Lib

open System

module Utils =

    let swap (lhs : 'a byref) (rhs : 'a byref) =
        let tmp = lhs
        lhs <- rhs
        rhs <- tmp

    let findIndexIfNot (sp: Span<int>) (pred: int -> bool) =
        let mutable i = 0
        while (i < sp.Length) && (pred sp[i]) do
            i <- i + 1
        i

    let partition (sp: Span<int>) (pred: int -> bool) =
        let mutable m = findIndexIfNot sp pred
        let mutable i = m
        while i < sp.Length do
            if pred sp[i] then
                swap &sp[m] &sp[i]
                m <- m + 1
            i <- i + 1
        m

module QuickSort =

    let rec sortInPlaceImpl (sp: Span<int>) =
        if sp.Length <> 0 then
            let pivot = sp[0]
            let m1 = Utils.partition sp (fun n -> n < pivot)
            let m2 = Utils.partition (sp.Slice(m1)) (fun n -> n = pivot)
            sortInPlaceImpl (sp.Slice(0, m1))
            sortInPlaceImpl (sp.Slice(m1 + m2))

    let sortInPlace (a: int array) =
        sortInPlaceImpl (a.AsSpan())

    let rec sort (a: int array) =
        if a.Length = 0 then
            a
        else
            let pivot = a[0]
            let less, notLess = a |> Array.partition (fun n -> n < pivot)
            let equal, greater = notLess |> Array.partition (fun n -> n = pivot)
            [ sort less; equal; sort greater ] |> Array.concat