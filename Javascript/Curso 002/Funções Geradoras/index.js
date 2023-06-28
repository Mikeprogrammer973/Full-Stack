function* cores(){
    yield "Rosa"
    yield "Cinza"
    yield "Verde"    
}

const itens = cores()
console.log(itens.next().value)
console.log(itens.next().value)
console.log(itens.next().value)

function* asks(){
    const n = yield "Qual é o seu nome?"
    const i = yield "Qual é a sua idade?"
    const s = yield "Qual é o seu sexo?"

    return `\n\nOlá ${n}, você tem ${i} anos e seu sexo é ${s}!`
}

const resposta = asks()

resposta.next().value
resposta.next("Mike").value
resposta.next(18).value
console.log(resposta.next("Masculino").value)

function* contador(){
    let i = 0
    while(true){
        yield i++
    }
}

const cont = contador()
for(let i = 0; i < 10; i++){
    console.log(cont.next().value)
}