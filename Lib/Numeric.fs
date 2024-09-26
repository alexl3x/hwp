namespace Lib

module Numeric =

    module Matrix =

        let identity = array2D [ [ 1; 0 ]; 
                                 [ 0; 1 ] ]

        let multiply (m1: int array2d) (m2: int array2d) =
            Array2D.init 2 2 (fun i j -> m1[i, 0] * m2[0, j] + m1[i, 1] * m2[1, j])

        let square (m: int array2d) =
            multiply m m

        let rec power (n: int) (m: int array2d)  =
            if n = 0 then
                identity
            else
                if n % 2 = 1
                then m |> square |> power (n / 2) |> multiply m 
                else m |> square |> power (n / 2)

        let powerIter (n: int) (m: int array2d)  =
            if n = 0 then
                identity
            else
                let mutable k = n
                let mutable acc = identity
                let mutable pow = m
                while k > 0 do
                    if k % 2 = 1 then
                        acc <- multiply acc pow
                    pow <- multiply pow pow
                    k <- k / 2
                acc

    let rec factorial n =
        assert (n >= 0)
        if n = 0
        then 1
        else n * factorial (n - 1)

    let fibonacciNonNeg n =
        assert (n >= 0)
        if n = 0 then
            0
        else
            let m = array2D [ [ 1; 1 ]; 
                                [ 1; 0 ] ]
            let mpow = Matrix.power n m
            mpow[0, 1]

    let fibonacci n =
        if n >= 0
        then
            fibonacciNonNeg n
        else
            if n % 2 = 0
            then - fibonacciNonNeg (-n)
            else fibonacciNonNeg (-n)
