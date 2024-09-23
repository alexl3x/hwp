namespace hw1_Lib

module Factorial =

    let rec fact n =
        assert (n >= 0)
        if n = 0
        then 1
        else n * fact (n - 1)