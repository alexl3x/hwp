namespace Lib

open System

module Sort =

    type Compare =
    | Less
    | Equal
    | Greater

    type Comparator<'T> = 'T -> 'T -> Compare

    module Utils =

        let swap (lhs : 'a byref) (rhs : 'a byref) =
            let tmp = lhs
            lhs <- rhs
            rhs <- tmp

        let findIndexIfNot (sp: Span<'T>) (pred: 'T -> bool) =
            let mutable i = 0
            while (i < sp.Length) && (pred sp[i]) do
                i <- i + 1
            i

        let partition (sp: Span<'T>) (pred: 'T -> bool) =
            let mutable m = findIndexIfNot sp pred
            let mutable i = m
            while i < sp.Length do
                if pred sp[i] then
                    swap &sp[m] &sp[i]
                    m <- m + 1
                i <- i + 1
            m

        let merge (comp: Comparator<'T>) (dst: Span<'T>) (src1: Span<'T>) (src2: Span<'T>) =
            assert (src1.Length + src2.Length <= dst.Length)

            let mutable i1 = 0
            let mutable i2 = 0
            let mutable i = 0

            while i1 < src1.Length && i2 < src2.Length do
                if not ((comp src1[i1] src2[i2]) = Greater) then
                    dst[i] <- src1[i1]
                    i1 <- i1 + 1
                else
                    dst[i] <- src2[i2]
                    i2 <- i2 + 1
                i <- i + 1

            while i1 < src1.Length do
                dst[i] <- src1[i1]
                i1 <- i1 + 1
                i <- i + 1

            while i2 < src2.Length do
                dst[i] <- src2[i2]
                i2 <- i2 + 1
                i <- i + 1

    open Utils

    let bubbleSort (comp: Comparator<'T>) (a: 'T array) =
        for i = a.Length - 2 downto 0 do
            for j = 0 to i do
                if (comp a[j] a[j + 1]) = Greater then
                    swap &a[j] &a[j + 1]

    let rec quickSortImpl (comp: Comparator<'T>) (sp: Span<'T>) =
        if sp.Length <> 0 then
            let pivot = sp[0]
            let m1 = partition sp (fun n -> (comp n pivot) = Less)
            let m2 = partition (sp.Slice(m1)) (fun n -> (comp n pivot) = Equal)
            quickSortImpl comp (sp.Slice(0, m1))
            quickSortImpl comp (sp.Slice(m1 + m2))

    let quickSort (comp: Comparator<'T>) (a: 'T array) =
        quickSortImpl comp (a.AsSpan())
    
    let mergeSort (comp: Comparator<'T>) (arr: 'T array) =
        let tmp = Array.zeroCreate (arr.Length)
        let mutable mergeSize = 1
        let mutable arrIsDst = false

        while mergeSize < arr.Length do
            let mutable p = 0
            while p < arr.Length do
                let sizeSrc1 = Math.Min(mergeSize, arr.Length - p)
                let sizeSrc2 = Math.Min(mergeSize, arr.Length - (p + sizeSrc1))
                let dst = (if arrIsDst then arr else tmp).AsSpan(p, sizeSrc1 + sizeSrc2)
                let src1 = (if arrIsDst then tmp else arr).AsSpan(p, sizeSrc1)
                let src2 = (if arrIsDst then tmp else arr).AsSpan(p + sizeSrc1, sizeSrc2)
                merge comp dst src1 src2
                p <- p + mergeSize * 2
            mergeSize <- mergeSize * 2
            arrIsDst <- not arrIsDst

        if arrIsDst then
            for i = 0 to arr.Length - 1 do
                arr[i] <- tmp[i]