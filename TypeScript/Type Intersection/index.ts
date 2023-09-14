interface BankDates
{
    conta: number
    agencia: number
    banco: string
}

interface Client
{
    nome: string
    email: string
}

interface DatesPessoaFisica
{
    cpf: number
}

type DadosCliente = BankDates & Client & DatesPessoaFisica

const dadosCliente: DadosCliente = {
    conta: 815153845,
    agencia: 8151,
    banco: "Itaú",
    nome: "Zhanar Xiao",
    email: "zhanar_xiao987@gmail.com",
    cpf: 80083057637
}

console.log(dadosCliente)