namespace Tests

open System
open Microsoft.VisualStudio.TestTools.UnitTesting

open Lib

[<TestClass>]
type TestNumeric () =

    [<TestMethod>]
    member this.TestFibonacci () =
        Assert.AreEqual(0, Numeric.fib 0);
        Assert.AreEqual(1, Numeric.fib 1);
        Assert.AreEqual(1, Numeric.fib 2);
        Assert.AreEqual(2, Numeric.fib 3);
        Assert.AreEqual(3, Numeric.fib 4);
        Assert.AreEqual(5, Numeric.fib 5);
        Assert.AreEqual(8, Numeric.fib 6);
        Assert.AreEqual(13, Numeric.fib 7);
        Assert.AreEqual(21, Numeric.fib 8);
        Assert.AreEqual(34, Numeric.fib 9);
        Assert.AreEqual(55, Numeric.fib 10);
        Assert.AreEqual(1, Numeric.fib -1);
        Assert.AreEqual(-1, Numeric.fib -2);
        Assert.AreEqual(2, Numeric.fib -3);
        Assert.AreEqual(-3, Numeric.fib -4);
        Assert.AreEqual(5, Numeric.fib -5);
        Assert.AreEqual(-8, Numeric.fib -6);
        Assert.AreEqual(13, Numeric.fib -7);
        Assert.AreEqual(-21, Numeric.fib -8);
        Assert.AreEqual(34, Numeric.fib -9);
        Assert.AreEqual(-55, Numeric.fib -10);

    [<TestMethod>]
    member this.TestFactorial () =
        Assert.AreEqual(1, Numeric.fact 0);
        Assert.AreEqual(1, Numeric.fact 1);
        Assert.AreEqual(2, Numeric.fact 2);
        Assert.AreEqual(6, Numeric.fact 3);
        Assert.AreEqual(24, Numeric.fact 4);
        Assert.AreEqual(120, Numeric.fact 5);
        Assert.AreEqual(720, Numeric.fact 6);

[<TestClass>]
type TestSort () =

    [<TestMethod>]
    member this.TestBubbleSort () =

        let expected = [| |]
        let actual   = [| |]
        Sort.bubbleSort actual
        CollectionAssert.AreEqual(expected, actual)

        let expected = [| 0; 1; 2; 3; 4; 5; 6; 7; 8; 9 |]
        let actual   = [| 0; 1; 2; 3; 4; 5; 6; 7; 8; 9 |]
        Sort.bubbleSort actual
        CollectionAssert.AreEqual(expected, actual)

        let expected = [| 1; 1; 1; 1; 1; 1; 1; 1; 1; 1 |]
        let actual   = [| 1; 1; 1; 1; 1; 1; 1; 1; 1; 1 |]
        Sort.bubbleSort actual
        CollectionAssert.AreEqual(expected, actual)

        let expected = [| 0; 1; 2; 3; 4; 5; 6; 7; 8; 9 |]
        let actual   = [| 2; 6; 8; 4; 1; 5; 7; 9; 3; 0 |]
        Sort.bubbleSort actual
        CollectionAssert.AreEqual(expected, actual)

        let expected = [| 1; 1; 1; 1; 2; 2; 2; 2; 3; 3; |]
        let actual   = [| 2; 2; 2; 2; 1; 1; 1; 1; 3; 3; |]
        Sort.bubbleSort actual
        CollectionAssert.AreEqual(expected, actual)

    [<TestMethod>]
    member this.TestQuickSortInPlace () =

        let expected = [| |]
        let actual   = [| |]
        Sort.quickSortInPlace actual
        CollectionAssert.AreEqual(expected, actual)

        let expected = [| 0; 1; 2; 3; 4; 5; 6; 7; 8; 9 |]
        let actual   = [| 0; 1; 2; 3; 4; 5; 6; 7; 8; 9 |]
        Sort.quickSortInPlace actual
        CollectionAssert.AreEqual(expected, actual)

        let expected = [| 1; 1; 1; 1; 1; 1; 1; 1; 1; 1 |]
        let actual   = [| 1; 1; 1; 1; 1; 1; 1; 1; 1; 1 |]
        Sort.quickSortInPlace actual
        CollectionAssert.AreEqual(expected, actual)

        let expected = [| 0; 1; 2; 3; 4; 5; 6; 7; 8; 9 |]
        let actual   = [| 2; 6; 8; 4; 1; 5; 7; 9; 3; 0 |]
        Sort.quickSortInPlace actual
        CollectionAssert.AreEqual(expected, actual)

        let expected = [| 1; 1; 1; 1; 2; 2; 2; 2; 3; 3; |]
        let actual   = [| 2; 2; 2; 2; 1; 1; 1; 1; 3; 3; |]
        Sort.quickSortInPlace actual
        CollectionAssert.AreEqual(expected, actual)

    [<TestMethod>]
    member this.TestQuickSort () =

        let expected = [| |]
        let shuffled = [| |]
        let actual = Sort.quickSort shuffled
        CollectionAssert.AreEqual(expected, actual)

        let expected = [| 0; 1; 2; 3; 4; 5; 6; 7; 8; 9 |]
        let shuffled = [| 0; 1; 2; 3; 4; 5; 6; 7; 8; 9 |]
        let actual = Sort.quickSort shuffled
        CollectionAssert.AreEqual(expected, actual)

        let expected = [| 1; 1; 1; 1; 1; 1; 1; 1; 1; 1 |]
        let shuffled = [| 1; 1; 1; 1; 1; 1; 1; 1; 1; 1 |]
        let actual = Sort.quickSort shuffled
        CollectionAssert.AreEqual(expected, actual)

        let expected = [| 0; 1; 2; 3; 4; 5; 6; 7; 8; 9 |]
        let shuffled = [| 2; 6; 8; 4; 1; 5; 7; 9; 3; 0 |]
        let actual = Sort.quickSort shuffled
        CollectionAssert.AreEqual(expected, actual)

        let expected = [| 1; 1; 1; 1; 2; 2; 2; 2; 3; 3; |]
        let shuffled = [| 2; 2; 2; 2; 1; 1; 1; 1; 3; 3; |]
        let actual = Sort.quickSort shuffled
        CollectionAssert.AreEqual(expected, actual)