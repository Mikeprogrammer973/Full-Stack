
export = {}

let nome: unknown = "Maria"

console.log((nome as string).toUpperCase())

let car = "Mercedes"

let tam_str = (<string>car).length

console.log("O tamaho do string é " + tam_str)

