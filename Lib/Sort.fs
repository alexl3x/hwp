namespace Lib

open System

module Sort =

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

    open Utils

    let bubbleSort (a: int array) =
        for i = a.Length - 2 downto 0 do
            for j = 0 to i do
                if a[j] > a[j + 1] then
                    swap &a[j] &a[j + 1]

    let rec quickSortInPlaceImpl (sp: Span<int>) =
        if sp.Length <> 0 then
            let pivot = sp[0]
            let m1 = partition sp (fun n -> n < pivot)
            let m2 = partition (sp.Slice(m1)) (fun n -> n = pivot)
            quickSortInPlaceImpl (sp.Slice(0, m1))
            quickSortInPlaceImpl (sp.Slice(m1 + m2))

    let quickSortInPlace (a: int array) =
        quickSortInPlaceImpl (a.AsSpan())

    let rec quickSort (a: int array) =
        if a.Length = 0 then
            a
        else
            let pivot = a[0]
            let less, notLess = a |> Array.partition (fun n -> n < pivot)
            let equal, greater = notLess |> Array.partition (fun n -> n = pivot)
            [ quickSort less; equal; quickSort greater ] |> Array.concat
    