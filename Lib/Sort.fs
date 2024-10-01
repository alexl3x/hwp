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

    let rec quickSortImpl (sp: Span<int>) =
        if sp.Length <> 0 then
            let pivot = sp[0]
            let m1 = partition sp (fun n -> n < pivot)
            let m2 = partition (sp.Slice(m1)) (fun n -> n = pivot)
            quickSortImpl (sp.Slice(0, m1))
            quickSortImpl (sp.Slice(m1 + m2))

    let quickSort (a: int array) =
        quickSortImpl (a.AsSpan())