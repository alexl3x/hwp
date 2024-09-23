namespace hw1_Lib

module BubbleSort =

    let sort (a: int array) =
        for i = a.Length - 2 downto 0 do
            for j = 0 to i do
                if a[j] > a[j + 1] then
                    let tmp = a[j]
                    a[j] <- a[j + 1]
                    a[j + 1] <- tmp