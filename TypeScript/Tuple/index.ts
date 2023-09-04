let pessoa: [string, string, number]
pessoa = ["Carolina", "Student", 17]
console.log(pessoa[0])

let info: [string[], number[]]
info = [["Maria", "Rayssa", "Thalita"], [1456, 6754, 8748]]
console.log(info)

let listFruits: [string, ...string[]] = ['apple', 'orange', 'kiwi', 'pineapple', 'cherry']
console.log(...listFruits)

let pessoa2: [nome: string, status: string, age: number]
pessoa2 = ["Carolina", "Student", 17]
console.log(pessoa2[1])

type Nome = [nome: string, sobrenome: string] | [nome: string, middleName: string, sobrenome: string]

function createName(nome: Nome): Nome
{
    return nome
}

console.log(createName(["Mike", "Pascal"]))