let arr_1 = [12, 9, 23, 13]

console.log(arr_1)

let it_arr_1 = arr_1[Symbol.iterator]()

console.log(it_arr_1)

console.log(it_arr_1.next())
console.log(it_arr_1.next().value)