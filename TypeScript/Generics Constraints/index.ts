
interface Pessoa 
{
    nome: string
    idade: number
}

function obter_pessoas_idade_maior_que<T extends Pessoa>(pessoas: T[], idade: number): T[]
{
    return pessoas.filter(p => p.idade > idade)
}

const pessoas: Pessoa[] =
[
    {nome: "Maria Helena", idade: 17},
    {nome: "Pedro Souza", idade: 19},
    {nome: "Rayssa Álvares", idade: 18},
    {nome: "Xenia Spartaru", idade: 16},
    {nome: "Paula Hernadés", idade: 17},
    {nome: "Sabrina Silveira", idade: 41}
]

console.log(obter_pessoas_idade_maior_que(pessoas, 16))
console.log(obter_pessoas_idade_maior_que(pessoas, 18))

function prop<T, K extends keyof T>(obj: T, key: K)
{
    return obj[key]
}

const p = prop(
    {nome: "Maria Eduarda", idade: 18}, "nome"
)

console.log(p)