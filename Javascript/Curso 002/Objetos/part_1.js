class Pessoa{
    origem = "Latina"
    constructor(nome, idade){
        this.set_nome(nome)
        this.set_idade(idade)
    }
    get_nome(){
        return this.nome
    }
    get_idade(){
        return this.idade
    }
    get_info(){
        return [this.nome, this.idade, this.origem]
    }
    set_nome(nome){
        this.nome = nome
    }
    set_idade(idade){
        if(typeof(idade) != "number"){
            throw new Error("Idade inválido!")
        }
        this.idade = idade
    }
    info(){
        return `Nome: ${this.nome}\nTipo: ${this.idade}\nOrigem: ${this.origem}\n---------------`
    }
}

let pessoas = []

const add_pessoa = ()=>{
    document.getElementById("people").innerHTML = ""
    pessoas.map((p)=>{
        const dv = document.createElement("div")
        dv.innerHTML = `<p>${p.get_nome()}</p> <p>${p.get_idade()} anos</p>`
        dv.setAttribute("class", "pessoa")
        document.getElementById("people").append(dv)
    })
}

document.getElementById("f-add").onsubmit = ()=>{
    const pessoa = new Pessoa(document.getElementById("nome").value, Number(document.getElementById("idade").value))
    pessoas.push(pessoa)
    add_pessoa()
    document.getElementById("nome").value = ""
    document.getElementById("idade").value = ""
    return false
}