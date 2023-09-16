export = {}

interface Person {
    nome: string
    idade: number
    deficient: boolean
}

type OpcionalPerson = {
    [P in keyof Person]?: Person[P]
}

const person: Person = {
    nome: "Andressa Souza",
    idade: 19,
    deficient: false
}

const opcional_person: OpcionalPerson = {
    nome: "Rafael Perreira"
}

console.log(person, opcional_person)