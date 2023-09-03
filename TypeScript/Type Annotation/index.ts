// Variable
let nome: string = "Mike D. Pascal"
let num: bigint = 3894798712984098219840912n
console.log(nome, num)

// Array
let animals: string[] = ["Cat", "Dog", "Bird", "Shark", "Butterfly", "Fox", "Lion"]
console.log(animals)
 
// Object
let details : {
    nome: string,
    idade: number,
    in_love: boolean,
    altura: number
}
details = {nome: "Maria Daniela", idade: 18, in_love: false, altura: 1.65}
console.log(details)

// Function
function multiplicarNumber(num1: number, num2: number): number
{
    return num1 * num2 
}

console.log(multiplicarNumber(8, 15)) 