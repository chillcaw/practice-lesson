package main

import (
    "fmt"
    "strconv"
)

func main() {
    for {
        fmt.Println("Please enter a number or 'x' to exit:")

        var input string
        fmt.Scanln(&input)

        if input == "x" {
            break
        } else {
            n, _ := strconv.Atoi(input)
            fmt.Println(n)

            isPrime := true
            endsIn5Or3 := false
            digitsAddToTen := false

            for i := n - 1; i > 1; i-- {
                if n % i == 0 {
                    isPrime = false
                }
             }

            nString := strconv.Itoa(n)
            digitsSum := 0

            for _, char := range nString {
                tmp, _ := strconv.Atoi(string(char))
                digitsSum += tmp
            }

            if digitsSum == 10 {
                digitsAddToTen = true;
            }

            if (n % 10) == 5 || (n % 10) == 3 {
                endsIn5Or3 = true
            }

            fmt.Printf("Is the number prime? %t\n", isPrime)
            fmt.Printf("Is the sum of digits 10? %t\n", digitsAddToTen)
            fmt.Printf("Is last digit 3 or 5? %t\n", endsIn5Or3)

            if isPrime == true && endsIn5Or3 == true && digitsAddToTen == true {
                fmt.Printf("he number => %d is very interesting\n", n)
            } else if isPrime == true && endsIn5Or3 == true {
                fmt.Printf("The number => %d is interesting\n", n)
            } else if endsIn5Or3 == true && digitsAddToTen == true {
                fmt.Printf("The number => %d is interesting\n", n)
            } else if isPrime == true && digitsAddToTen == true {
                fmt.Printf("The number => %d is interesting\n", n)
            } else if isPrime == true || endsIn5Or3 == true || digitsAddToTen == true {
                fmt.Printf("The number => %d is almost interesting\n", n)
            } else {
                fmt.Printf("The number => %d is boring\n", n)
            }

            fmt.Println("")
        }
    }
}
