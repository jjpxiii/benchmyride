package main

import (
	"bytes"
	"fmt"
	"log"
	"os"
	"regexp"
)

func measure(data string, pattern string) {
	r, err := regexp.Compile(pattern)
	if err != nil {
		log.Fatal(err)
	}

	matches := r.FindAllString(data, -1)
	count := len(matches)

	fmt.Printf("%v\n", count)
}

func main() {
	filerc, err := os.Open("../../assets/regexin.txt")
	if err != nil {
		log.Fatal(err)
	}
	defer filerc.Close()

	buf := new(bytes.Buffer)
	buf.ReadFrom(filerc)
	data := buf.String()

	// Email
	measure(data, `[\w\.+-]+@[\w\.-]+\.[\w\.-]+`)

	// URI
	measure(data, `[\w]+://[^/\s?#]+[^\s?#]+(?:\?[^\s#]*)?(?:#[^\s]*)?`)

	// IP
	measure(data, `(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9])\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9])`)
}
