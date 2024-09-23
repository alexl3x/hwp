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