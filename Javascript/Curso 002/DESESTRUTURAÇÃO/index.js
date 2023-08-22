"use strict";

//let a, b, c, d

//[a, b, c, d] = ["Blue", "Green", "Teal", "Yellow"]

//({a, b, c, d} = {a: "Blue", b: "Green", c: "Teal", d: "Yellow"})

//let nums = [12, 78, 56, 34]
//let[a, b,c, d] = nums

//[a, b = 7, c = 7, d = 7] = [10]

//let a = 10;
//let b = 20;

//[a, b] = [b, a]

let nums = [10, 20, 30, 40, 50, 60, 70, 80, 90]
let [a, b, c, ...d] = nums

console.log(a)
console.log(b)
console.log(c)
console.log(d)
console.log(`\n\n`)

let info = {nome: "Mike", canal: "Mind & Life", sexo: "Masculino", idade: 18, altura: 1.72}
let {nome, canal, ...details} = info

console.log(nome)
console.log(canal)
console.log(details)
console.log(`\n\n`)