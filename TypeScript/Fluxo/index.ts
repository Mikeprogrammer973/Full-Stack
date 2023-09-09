export = {}

// if...else
let idade: number = Math.round(Math.random()*20)

console.log(`Idade: ${idade} anos\n`)

if(idade < 18)
{
    console.log("Você não está habilidado para dirigir!\n")
}else{
    console.log("Você está habilidado para dirigir!\n")
}

// switch...case
switch(idade)
{
    case 16:
        console.log("Paciência, pequeno gafanhoto...\n")
        break
    case 17:
        console.log("Paciência, falta pouco...\n")
        break
    case 18:
        console.log("Já pode ir já...\n")
        break
}

// loop for
for(let i: number = 0; i < idade; i++)
{
    console.log(i+1)
}

// while/do...while
let counter: number = idade
while(counter > 0)
{
    console.log(counter)
    counter--
}

let denied: boolean = true
do
{
    if(idade >= 18)
    {
        for(let i: number = 0; i < 7; i++)
        {
            console.log("\nSim!")
        }
    }
}while(!denied)

function print_name(first_name: string, middle_name?: string, last_name = "Pascal", ...info: string[])
{
    console.log(`\nNome: ${first_name}\n`)
    if(middle_name != undefined) console.log(`Segundo Nome: ${middle_name}\n`)
    console.log(`Sobrenome: ${last_name}\n`)
    if(info.length > 0) console.log(`Detalhes: ${info}\n`)
}

print_name("Maria", undefined, undefined, "Só sei que nada sei!")