namespace Tests

open System
open Microsoft.VisualStudio.TestTools.UnitTesting

open Lib

[<TestClass>]
type TestNumeric () =

    [<TestMethod>]
    member this.TestFibonacci () =
        Assert.AreEqual(0, Numeric.fibonacci 0);
        Assert.AreEqual(1, Numeric.fibonacci 1);
        Assert.AreEqual(1, Numeric.fibonacci 2);
        Assert.AreEqual(2, Numeric.fibonacci 3);
        Assert.AreEqual(3, Numeric.fibonacci 4);
        Assert.AreEqual(5, Numeric.fibonacci 5);
        Assert.AreEqual(8, Numeric.fibonacci 6);
        Assert.AreEqual(13, Numeric.fibonacci 7);
        Assert.AreEqual(21, Numeric.fibonacci 8);
        Assert.AreEqual(34, Numeric.fibonacci 9);
        Assert.AreEqual(55, Numeric.fibonacci 10);
        Assert.AreEqual(1, Numeric.fibonacci -1);
        Assert.AreEqual(-1, Numeric.fibonacci -2);
        Assert.AreEqual(2, Numeric.fibonacci -3);
        Assert.AreEqual(-3, Numeric.fibonacci -4);
        Assert.AreEqual(5, Numeric.fibonacci -5);
        Assert.AreEqual(-8, Numeric.fibonacci -6);
        Assert.AreEqual(13, Numeric.fibonacci -7);
        Assert.AreEqual(-21, Numeric.fibonacci -8);
        Assert.AreEqual(34, Numeric.fibonacci -9);
        Assert.AreEqual(-55, Numeric.fibonacci -10);

    [<TestMethod>]
    member this.TestFactorial () =
        Assert.AreEqual(1, Numeric.factorial 0);
        Assert.AreEqual(1, Numeric.factorial 1);
        Assert.AreEqual(2, Numeric.factorial 2);
        Assert.AreEqual(6, Numeric.factorial 3);
        Assert.AreEqual(24, Numeric.factorial 4);
        Assert.AreEqual(120, Numeric.factorial 5);
        Assert.AreEqual(720, Numeric.factorial 6);

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