export = {}

type City = CityName | CityCoords

type CityName = "Santa Catarina" | "Bahia" | "Manaús" | "Pernambuco"
type CityCoords = {
    x: number
    y: number
}

type Person = {
    local_nasc: City
    current_local: City
}

const person = {
    local_nasc: "Santa Catarina",
    current_local: {x: 158, y: 75}
} satisfies Person

console.log(person.local_nasc.toUpperCase())