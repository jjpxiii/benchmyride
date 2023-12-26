package main


import "fmt"

func Fibonacci(index int) int {
	if index == 0 {
		return 0
	}
	if index == 1 {
		return 1
	} else {
		return Fibonacci(index-1) + Fibonacci(index-2)
	}
}

func main() {
	fmt.Println(Fibonacci(42))
	return
}