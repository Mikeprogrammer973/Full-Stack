
const person = {
    name: "Caroline",
    age: 17,
    sex: "FEM",
    weigth: 59.7
}
//console.log(person)

function onboarding(func: {name: string})
{
    return `Seja nerm-vindo(a), ${func.name}!`
}
//console.log(onboarding({name: "Xenia"}))

interface Person {
    name: string,
    function: string
}

function onboarding_(func: Person)
{
   return `Seja bem-vindo(a), ${func.name}!\nSua função aqui na empresa é ${func.function}.`
}

//console.log(onboarding_({name: "Daniela", function: "Enfermeira"}))

type Person_ = {
    name: string,
    function: string,
    language ?: string
}

function _onboarding_(func: Person_)
{
   return `Nome: ${func.name}\nFunção: ${func.function}\nLinguagem: ${func.language}`
}

//console.log(_onboarding_({name: "Daniela", function: "Analyst Developer", language: "Python"}))


interface Mom {
    nome: string
}

interface Dad {
    sobrenome: string
}

interface Daughter extends Mom, Dad {
    idade: number
}

const daughter: Daughter = {
    nome: "Theresa",
    sobrenome: "Silva",
    idade: 15
}

//console.log(daughter)

interface Dog {
    tipo: string
}

interface Cat {
    tipo: string
}

type animal = Dog & Cat
