namespace hw1_Tests

open System
open Microsoft.VisualStudio.TestTools.UnitTesting

open hw1_Lib

[<TestClass>]
type TestClass () =

    [<TestMethod>]
    member this.Testfib () =
        Assert.AreEqual(0, Fibonacci.fib 0);
        Assert.AreEqual(1, Fibonacci.fib 1);
        Assert.AreEqual(1, Fibonacci.fib 2);
        Assert.AreEqual(2, Fibonacci.fib 3);
        Assert.AreEqual(3, Fibonacci.fib 4);
        Assert.AreEqual(5, Fibonacci.fib 5);
        Assert.AreEqual(8, Fibonacci.fib 6);
        Assert.AreEqual(13, Fibonacci.fib 7);
        Assert.AreEqual(21, Fibonacci.fib 8);
        Assert.AreEqual(34, Fibonacci.fib 9);
        Assert.AreEqual(55, Fibonacci.fib 10);
        Assert.AreEqual(1, Fibonacci.fib -1);
        Assert.AreEqual(-1, Fibonacci.fib -2);
        Assert.AreEqual(2, Fibonacci.fib -3);
        Assert.AreEqual(-3, Fibonacci.fib -4);
        Assert.AreEqual(5, Fibonacci.fib -5);
        Assert.AreEqual(-8, Fibonacci.fib -6);
        Assert.AreEqual(13, Fibonacci.fib -7);
        Assert.AreEqual(-21, Fibonacci.fib -8);
        Assert.AreEqual(34, Fibonacci.fib -9);
        Assert.AreEqual(-55, Fibonacci.fib -10);

    [<TestMethod>]
    member this.Testfact () =
        Assert.AreEqual(1, Factorial.fact 0);
        Assert.AreEqual(1, Factorial.fact 1);
        Assert.AreEqual(2, Factorial.fact 2);
        Assert.AreEqual(6, Factorial.fact 3);
        Assert.AreEqual(24, Factorial.fact 4);
        Assert.AreEqual(120, Factorial.fact 5);
        Assert.AreEqual(720, Factorial.fact 6);

    [<TestMethod>]
    member this.TestBubbleSort () =

        let expected = [| 0; 1; 2; 3; 4; 5; 6; 7; 8; 9 |]
        let actual   = [| 0; 1; 2; 3; 4; 5; 6; 7; 8; 9 |]
        BubbleSort.sort actual
        CollectionAssert.AreEqual(expected, actual)

        let expected = [| 1; 1; 1; 1; 1; 1; 1; 1; 1; 1 |]
        let actual   = [| 1; 1; 1; 1; 1; 1; 1; 1; 1; 1 |]
        BubbleSort.sort actual
        CollectionAssert.AreEqual(expected, actual)

        let expected = [| 0; 1; 2; 3; 4; 5; 6; 7; 8; 9 |]
        let actual   = [| 2; 6; 8; 4; 1; 5; 7; 9; 3; 0 |]
        BubbleSort.sort actual
        CollectionAssert.AreEqual(expected, actual)

        let expected = [| 1; 1; 1; 1; 2; 2; 2; 2; 3; 3; |]
        let actual   = [| 2; 2; 2; 2; 1; 1; 1; 1; 3; 3; |]
        BubbleSort.sort actual
        CollectionAssert.AreEqual(expected, actual)