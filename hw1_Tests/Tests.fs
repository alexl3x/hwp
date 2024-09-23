namespace hw1_Tests

open System
open Microsoft.VisualStudio.TestTools.UnitTesting

open hw1_Lib

[<TestClass>]
type TestClass () =

    [<TestMethod>]
    member this.Testfib () =
        Assert.AreEqual(0, Algs.fib 0);
        Assert.AreEqual(1, Algs.fib 1);
        Assert.AreEqual(1, Algs.fib 2);
        Assert.AreEqual(2, Algs.fib 3);
        Assert.AreEqual(3, Algs.fib 4);
        Assert.AreEqual(5, Algs.fib 5);
        Assert.AreEqual(8, Algs.fib 6);
        Assert.AreEqual(13, Algs.fib 7);
        Assert.AreEqual(21, Algs.fib 8);
        Assert.AreEqual(34, Algs.fib 9);
        Assert.AreEqual(55, Algs.fib 10);
        Assert.AreEqual(1, Algs.fib -1);
        Assert.AreEqual(-1, Algs.fib -2);
        Assert.AreEqual(2, Algs.fib -3);
        Assert.AreEqual(-3, Algs.fib -4);
        Assert.AreEqual(5, Algs.fib -5);
        Assert.AreEqual(-8, Algs.fib -6);
        Assert.AreEqual(13, Algs.fib -7);
        Assert.AreEqual(-21, Algs.fib -8);
        Assert.AreEqual(34, Algs.fib -9);
        Assert.AreEqual(-55, Algs.fib -10);