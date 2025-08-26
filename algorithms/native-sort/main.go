package main

import (
	"encoding/json"
	"fmt"
	"os"
	"sort"
)

func main() {
	var data []int
	jsonStr, _ := os.ReadFile("../../assets/10mil.json")
	json.Unmarshal([]byte(jsonStr), &data)
	sort.Ints(data)
	fmt.Printf("%v\n", data[666])
	fmt.Printf("%v\n", data[666667])
}

func ToJsonString(array []int32) []byte {
	if bytes, err := json.Marshal(array); err == nil {
		return bytes
	}
	return []byte{}
}
