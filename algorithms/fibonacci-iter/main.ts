const fibo = (n) => {
    let total = 0;
    let last = 1;
    let beforeLast = 1
    console.log('rerer')

    for (let i = 2; i < n; i++) {
        let temp = beforeLast
        beforeLast = last
        last = temp + beforeLast
    }
    return last;
}

console.log(fibo(42))