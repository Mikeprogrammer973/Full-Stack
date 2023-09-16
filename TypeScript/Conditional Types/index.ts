
export = {}

type Person = {
    nome: string
    idade: number
    address: string
}

type Bussness = {
    nome: string
    cnpj: number
}

type PersonAddress = {
    second_address: string
    city: string
    country: string
}

type BussnessAddress = {
    localization: 'street' | 'avenue' | 'plaza'
}

type Address<T> = T extends {address: string} ? PersonAddress : BussnessAddress

const person_address: Address<Person> = {
    second_address: "9191 Airlie",
    city: "Lasalle",
    country: "Canada"
}

const bussness_address: Address<Bussness> = {
    localization: 'street'
}

console.log(person_address)
console.log(bussness_address)