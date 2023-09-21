export = {}

interface Person<N, A>
{
    name: N
    age: A
}

const person: Person<string, number> = 
{
    name: "Helena Santos",
    age: 26
}

console.log(person)